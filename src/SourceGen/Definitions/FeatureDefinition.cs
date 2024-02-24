using System.Xml.Linq;

namespace SourceGen;
public class FeatureDefinition
{
    public string Api;
    public string Name;
    public string Number;
    public string Comment;

    public List<EnumFeature> Enums = [];
    public List<ConstantFeature> Constants = [];
    public List<string> Types = [];
    public List<string> Commands = [];

    public static FeatureDefinition FromXML(XElement elem)
    {
        FeatureDefinition feature = new()
        {
            Name = elem.Attribute("name").Value,
            Number = elem.Attribute("number").Value,
            Api = elem.Attribute("api").Value,
            Comment = elem.Attribute("comment")?.Value
        };

        var requires = elem.Elements("require");
        foreach (var require in requires)
        {
            var enums = require.Elements("enum");
            foreach (var e in enums)
            {
                string enumName = e.Attribute("name").Value;
                string extends = e.Attribute("extends")?.Value;
                if (extends != null)
                {
                    string valueString;
                    string alias = null;
                    string offsetString = e.Attribute("offset")?.Value;
                    if (offsetString != null)
                    {
                        int extNumber = int.Parse(e.Attribute("extnumber").Value);
                        int offset = int.Parse(offsetString);
                        int direction = 1;
                        if (e.Attribute("dir")?.Value == "-")
                        {
                            direction = -1;
                        }

                        int value = direction * (1000000000 + (extNumber - 1) * 1000 + offset);
                        valueString = value.ToString();
                    }
                    else
                    {
                        string bitPosString = e.Attribute("bitpos")?.Value;
                        if (bitPosString != null)
                        {
                            int shift = int.Parse(bitPosString);
                            valueString = (1 << shift).ToString();
                        }
                        else
                        {
                            alias = e.Attribute("alias")?.Value;
                            valueString = e.Attribute("value")?.Value;
                        }
                    }

                    feature.Enums.Add(new EnumFeature() { Extends = extends, Name = enumName, Value = valueString, Alias = alias });
                }
                else
                {
                    ConstantFeature constant = new()
                    {
                        Name = enumName,
                        Alias = e.Attribute("alias")?.Value,
                        Value = e.Attribute("value")?.Value
                    };

                    feature.Constants.Add(constant);
                }
            }

            foreach (var t in require.Elements("type"))
            {
                string name = t.Attribute("name").Value;
                feature.Types.Add(name);
            }

            foreach (var command in require.Elements("command"))
                feature.Commands.Add(command.Attribute("name").Value);
        }

        return feature;
    }

    public class EnumFeature
    {
        public string Name;
        public string Extends;
        public string Value;
        public string Alias;
    }

    public class ConstantFeature
    {
        public string Name;
        public string Value;
        public string Alias;
    }
}