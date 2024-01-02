using System.Xml.Linq;

namespace Veldrid.OpenXR.SourceGen.Definitions;
public enum ConstantType
{
    None,
    UInt32,
    UInt64,
    Float32,
    String
}
public struct ConstantDefinition
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
        else if (value.EndsWith('f') || value.EndsWith('F'))
            return ConstantType.Float32;
        else if (value.EndsWith("ULL)"))
            return ConstantType.UInt64;
        else
            return ConstantType.UInt32;
    }
    public ConstantDefinition(XElement elem)
    {
        Name = elem.Attribute("name").Value;
        Comment = elem.Attribute("comment")?.Value;
        Alias = elem.Attribute("alias")?.Value;

        if (Alias == null)
        {
            Value = elem.Attribute("value").Value;
            Type = ParseType(Value);
        }
    }
    public static object NormalizeValue(string value)
    {
        return value.Replace("ULL", "UL");
    }
}