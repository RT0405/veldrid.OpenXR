namespace SourceGen;
public class OpenXRVersion
{
    public List<ConstantDefinition> Constants = [];
    public List<FuncpointerDefinition> FuncPointers = [];
    public List<EnumDefinition> Enums = [];
    public List<StructureDefinition> Structs = [];
    public List<StructureDefinition> Unions = [];
    public List<HandleDefinition> Handles = [];
    public List<CommandDefinition> Commands = [];

    public static OpenXRVersion FromSpec(OpenXRSpecification spec, string versionName, List<ExtensionDefinition> extensions)
    {
        OpenXRVersion version = new()
        {
            Constants = spec.Constants,
            FuncPointers = spec.FuncPointers,
            Handles = spec.Handles,
            Unions = spec.Unions,
            Structs = spec.Structs,
            Enums = spec.Enums
        };

        for (int i = 0; i < spec.Features.Count; i++)
        {
            FeatureDefinition feature = spec.Features[i];

            // Extend Enums
            foreach (var enumType in feature.Enums)
            {
                if (enumType.Extends != null & enumType.Alias == null)
                {
                    string name = enumType.Extends;
                    var enumDefinition = spec.Enums.Find(c => c.Name == name);

                    EnumValue newValue = new()
                    {
                        Name = enumType.Name,
                        Value = int.Parse(enumType.Value)
                    };
                    enumDefinition.Values.Add(newValue);
                }
            }

            // Add commands
            foreach (var command in feature.Commands)
            {
                string name = command;
                if (spec.Alias.TryGetValue(name, out string alias))
                    name = alias;

                var commandDefinition = spec.Commands.Find(c => c.Name == name);
                version.Commands.Add(commandDefinition);
            }

            if (feature.Name == versionName)
                break;
        }

        foreach (var extension in extensions)
        {
            if (extension.Supported == "disabled")
                continue;

            // Add Constant
            foreach (var constantType in extension.Constants)
            {
                if (!version.Constants.Exists(c => c.Name == constantType.Name))
                {
                    ConstantDefinition newConstant = new()
                    {
                        Name = constantType.Name,
                        Value = constantType.Value,
                        Alias = constantType.Alias
                    };

                    if (constantType.Value != null)
                        newConstant.Type = ConstantDefinition.ParseType(constantType.Value);

                    version.Constants.Add(newConstant);
                }
            }

            // Add Enums
            foreach (var enumType in extension.Enums)
            {
                if (enumType.Extends != null & enumType.Alias == null)
                {
                    var enumDefinition = spec.Enums.Find(c => c.Name == enumType.Extends);

                    if (!enumDefinition.Values.Exists(e => e.Name == enumType.Name))
                    {
                        enumDefinition.Values.Add(new()
                        {
                            Name = enumType.Name,
                            Value = int.Parse(enumType.Value)
                        });
                    }
                }
            }

            // Add commands
            foreach (var command in extension.Commands)
            {
                string name = command.Name;
                if (spec.Alias.TryGetValue(name, out string alias))
                    name = alias;

                var commandDefinition = spec.Commands.Find(c => c.Name == name);

                if (!version.Commands.Exists(c => c.Name == name))
                    version.Commands.Add(commandDefinition);
            }
        }

        return version;
    }
}