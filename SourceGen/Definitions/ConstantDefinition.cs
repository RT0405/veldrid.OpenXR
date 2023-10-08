using System.Xml.Linq;

namespace SourceGen;
public enum ConstantType
{
    None,
    UInt32,
    UInt64,
    Float32,
    String
}
public class ConstantDefinition
{
    public string Name;
    public string Value;
    public string Alias;
    public ConstantType Type;
    public string Comment;

    public static ConstantType ParseType(string value)
    {
        if (value.StartsWith('"'))
            return ConstantType.String;
        else if (value.EndsWith("f") || value.EndsWith("F"))
            return ConstantType.Float32;
        else if (value.EndsWith("ULL)"))
            return ConstantType.UInt64;
        else
            return ConstantType.UInt32;
    }
    public static ConstantDefinition FromXML(XElement elem)
    {
        ConstantDefinition constant = new()
        {
            Name = elem.Attribute("name").Value,
            Comment = elem.Attribute("comment")?.Value,
            Alias = elem.Attribute("alias")?.Value
        };

        if (constant.Alias == null)
        {
            constant.Value = elem.Attribute("value").Value;
            constant.Type = ParseType(constant.Value);
        }

        return constant;
    }
    public static object NormalizeValue(string value)
    {
        return value.Replace("ULL", "UL");
    }
}