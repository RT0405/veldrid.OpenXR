using System.Xml.Linq;

namespace SourceGen;

public enum EnumType
{
    Enum,
    Bitmask,
}

public class EnumDefinition
{
    public string Name;
    public EnumType Type;
    public List<EnumValue> Values = new List<EnumValue>();

    public static EnumDefinition FromXML(XElement elem)
    {
        EnumDefinition enums = new()
        {
            Name = elem.Attribute("name").Value,
            Type = elem.Attribute("type").Value == "enum" ? EnumType.Enum : EnumType.Bitmask
        };
        var values = elem.Elements("enum");
        foreach (var v in values)
            enums.Values.Add(EnumValue.FromXML(v));

        return enums;
    }
}

public class EnumValue
{
    public string Name;
    public string Alias;
    public int Value;
    public string Comment;

    internal static EnumValue FromXML(XElement elem)
    {
        EnumValue enumValue = new()
        {
            Name = elem.Attribute("name").Value,
            Comment = elem.Attribute("comment")?.Value,
            Alias = elem.Attribute("alias")?.Value
        };

        string valueString = elem.Attribute("value")?.Value;
        if (valueString != null)
        {
            if (valueString.StartsWith("0x"))
                enumValue.Value = int.Parse(valueString[2..], System.Globalization.NumberStyles.HexNumber);
            else
                enumValue.Value = int.Parse(valueString);
        }
        else if (enumValue.Alias == null)
            enumValue.Value = 1 << int.Parse(elem.Attribute("bitpos").Value);

        return enumValue;
    }
}