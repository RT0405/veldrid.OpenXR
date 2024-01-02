using System.Xml.Linq;

namespace Veldrid.OpenXR.SourceGen.Definitions;

public enum EnumType
{
    Enum,
    Bitmask,
}

public struct EnumDefinition
{
    public string Name;
    public EnumType Type;
    public List<EnumValue> Values = [];

    public EnumDefinition(XElement element)
    {
        Name = element.Attribute("name").Value;
        Type = element.Attribute("type").Value == "enum" ? EnumType.Enum : EnumType.Bitmask;

        foreach (var v in element.Elements("enum"))
            Values.Add(new(v));
    }
}

public struct EnumValue
{
    public string Name;
    public string Alias;
    public int Value;
    public string Comment;

    public EnumValue(XElement element)
    {
        Name = element.Attribute("name").Value;
        Comment = element.Attribute("comment")?.Value;
        Alias = element.Attribute("alias")?.Value;

        string valueString = element.Attribute("value")?.Value;
        if (valueString != null)
        {
            if (valueString.StartsWith("0x"))
                Value = int.Parse(valueString[2..], System.Globalization.NumberStyles.HexNumber);
            else
                Value = int.Parse(valueString);
        }
        else if (Alias == null)
            Value = 1 << int.Parse(element.Attribute("bitpos").Value);
    }
}