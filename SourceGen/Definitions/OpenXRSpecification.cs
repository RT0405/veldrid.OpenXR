using System.Xml.Linq;

namespace SourceGen;
public class OpenXRSpecification
{
    public List<VendorDefinition> Vendors = new();
    public List<TagDefinition> Tags = new();
    public List<ConstantDefinition> Constants = new();
    public List<TypedefDefinition> TypeDefs = new();
    public List<FuncpointerDefinition> FuncPointers = new();
    public List<EnumDefinition> Enums = new();
    public List<StructureDefinition> Structs = new();
    public List<StructureDefinition> Unions = new();
    public List<HandleDefinition> Handles = new();
    public List<CommandDefinition> Commands = new();
    public List<FeatureDefinition> Features = new();
    public Dictionary<string, string> BaseTypes = new();
    public Dictionary<string, string> Alias = new();
    public List<ExtensionDefinition> Extensions = new();
    public static OpenXRSpecification FromFile(string filePath)
    {
        XDocument file = XDocument.Load(filePath);
        OpenXRSpecification spec = new();

        XElement registry = file.Element("registry");

        //vendor ids
        var vendors = registry.Element("vendorids").Elements("vendorid");
        foreach (var vendor in vendors)
        {
            spec.Vendors.Add(VendorDefinition.FromXML(vendor));
        }

        // Tags
        var tags = registry.Element("tags").Elements("tag");
        foreach (var tag in tags)
        {
            spec.Tags.Add(TagDefinition.FromXML(tag));
        }

        // Constants
        var constants = (registry.Elements("enums").Where(e => e.Attribute("name").Value == "API Constants")).Elements("enum");
        foreach (var c in constants)
        {
            spec.Constants.Add(ConstantDefinition.FromXML(c));
        }

        // Enums
        var enums = registry.Elements("enums").Where(e => e.Attribute("type")?.Value == "enum" || e.Attribute("type")?.Value == "bitmask");
        foreach (var e in enums)
        {
            spec.Enums.Add(EnumDefinition.FromXML(e));
        }

        var types = registry.Elements("types");

        // FuncPointers
        var funcPointers = types.Elements("type").Where(f => f.Attribute("category")?.Value == "funcpointer");
        foreach (var func in funcPointers)
        {
            spec.FuncPointers.Add(FuncpointerDefinition.FromXML(func));
        }

        // Alias
        spec.Alias = types.Elements("type").Where(a => a.Attribute("alias") != null)
            .ToDictionary(
                a => a.Attribute("name").Value,
                a => a.Attribute("alias").Value);

        // Command Alias
        var commandAlias = registry.Element("commands").Elements("command").Where(c => c.Attribute("alias") != null);
        foreach (var c in commandAlias)
        {
            spec.Alias.Add(c.Attribute("name").Value, c.Attribute("alias").Value);
        }

        // Structs
        var structs = types.Elements("type").Where(s => s.Attribute("category")?.Value == "struct" && s.Attribute("alias") == null);
        foreach (var s in structs)
        {
            spec.Structs.Add(StructureDefinition.FromXML(s));
        }

        // Unions
        var unions = types.Elements("type").Where(u => u.Attribute("category")?.Value == "union");
        foreach (var u in unions)
        {
            spec.Unions.Add(StructureDefinition.FromXML(u));
        }

        // TypeDef
        var typeDefs = types.Elements("type").Where(t => t.Value.Contains("typedef") && t.Attribute("category")?.Value == "bitmask");
        foreach (var type in typeDefs)
        {
            spec.TypeDefs.Add(TypedefDefinition.FromXML(type));
        }

        // BaseTypes
        spec.BaseTypes = types.Elements("type").Where(bt => bt.Attribute("category")?.Value == "basetype")
            .ToDictionary(
                bt => bt.Element("name").Value,
                bt => bt.Element("type")?.Value);

        // Handles
        var handles = types.Elements("type").Where(h => h.Attribute("category")?.Value == "handle");
        foreach (var h in handles)
        {
            spec.Handles.Add(HandleDefinition.FromXML(h));
        }

        // Commands
        var commands = registry.Element("commands").Elements("command").Where(c => c.Attribute("alias") == null);
        foreach (var command in commands)
        {
            spec.Commands.Add(CommandDefinition.FromXML(command));
        }

        // Features
        var features = registry.Elements("feature");
        foreach (var feature in features)
        {
            spec.Features.Add(FeatureDefinition.FromXML(feature));

        }

        // Extensions
        var extensions = registry.Element("extensions").Elements("extension");
        foreach (var extension in extensions)
        {
            spec.Extensions.Add(ExtensionDefinition.FromXML(extension));
        }

        return spec;
    }
}