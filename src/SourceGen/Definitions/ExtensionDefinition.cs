﻿using System.Xml.Linq;

namespace SourceGen;
public class ExtensionDefinition
{
    public string Name;
    public int Number;
    public string Type;
    public string[] Requires;
    public string Author;
    public string Contact;
    public string Platform;
    public string Supported;
    public bool IsProvisional;
    public int SortOrder;
    public string Comment;

    public string SpecVersionConstName;
    public string ExtensionNameConstName;

    public List<EnumExtension> Enums = [];
    public List<ConstantExtension> Constants = [];
    public List<string> Types = [];
    public List<CommandDefinition> Commands = [];

    public static ExtensionDefinition FromXML(XElement elem, List<CommandDefinition> specCommands)
    {
        ExtensionDefinition extension = new()
        {
            Name = elem.Attribute("name").Value,
            Number = int.Parse(elem.Attribute("number").Value),
            Type = elem.Attribute("type")?.Value,
            Requires = elem.Attribute("requires")?.Value.Split(','),
            Author = elem.Attribute("author")?.Value,
            Contact = elem.Attribute("contact")?.Value,
            Platform = elem.Attribute("platform")?.Value,
            Supported = elem.Attribute("supported")?.Value,
            IsProvisional = elem.Attribute("provisional")?.Value == "true",
            Comment = elem.Attribute("comment")?.Value
        };
        string sortString = elem.Attribute("sortorder")?.Value;
        if (sortString != null)
            extension.SortOrder = int.Parse(sortString);

        var requires = elem.Element("require");
        if (requires != null)
        {
            var enums = requires.Elements("enum");
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
                        int offset = int.Parse(offsetString);
                        int direction = 1;
                        if (e.Attribute("dir")?.Value == "-")
                            direction = -1;

                        string extstring = e.Attribute("extnumber")?.Value;
                        int extNumber = extension.Number;
                        if (extstring != null)
                            extNumber = int.Parse(extstring);

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

                    extension.Enums.Add(new EnumExtension() { Extends = extends, Name = enumName, Value = valueString, Alias = alias });
                }
                else
                {
                    ConstantExtension constant = new()
                    {
                        Name = enumName,
                        Alias = e.Attribute("alias")?.Value
                    };
                    string rawValue = e.Attribute("value")?.Value;
                    if (rawValue != null)
                        constant.Value = FilterString(rawValue);

                    extension.Constants.Add(constant);
                }

                string name = e.Attribute("name")?.Value;
                if (name.EndsWith("_SPEC_VERSION"))
                    extension.SpecVersionConstName = name;
                else if (name.EndsWith("_EXTENSION_NAME"))
                    extension.ExtensionNameConstName = name;
            }

            var types = requires.Elements("type");
            foreach (var t in types)
            {
                string name = t.Attribute("name").Value;
                extension.Types.Add(name);
            }

            var commands = requires.Elements("command");
            foreach (var command in commands)
            {
                string name = command.Attribute("name").Value;
                CommandDefinition cdef = null;
                foreach (CommandDefinition c in specCommands)
                {
                    if (c.Name == name)
                    {
                        cdef = c;
                        cdef.extension = extension;
                    }
                }
                if (cdef == null)
                    Console.WriteLine(name + " failed to be found");
                else
                    extension.Commands.Add(cdef);
            }
        }

        return extension;
    }
    private static string FilterString(string value) => value.Replace("&quot;", "");
}

public class EnumExtension
{
    public string Name;
    public string Extends;
    public string Value;
    public string Alias;
}

public class ConstantExtension
{
    public string Name;
    public string Value;
    public string Alias;
}
