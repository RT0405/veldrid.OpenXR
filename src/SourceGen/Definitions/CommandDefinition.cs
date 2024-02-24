using System.Text;
using System.Xml.Linq;

namespace SourceGen;
public class CommandDefinition
{
    public string Name;
    public string ReturnType;
    public List<Param> Parameters = [];
    public string[] SuccessCodes;
    public string[] ErrorCodes;
    public string Comment;
    public ExtensionDefinition extension;

    public CommandDefinition(XElement element)
    {
        SuccessCodes = element.Attribute("successcodes")?.Value.Split(',');
        ErrorCodes = element.Attribute("errorcodes")?.Value.Split(',');
        Comment = element.Attribute("comment")?.Value;

        var proto = element.Element("proto");

        if (proto != null)
        {
            Name = proto.Element("name").Value;
            ReturnType = proto.Element("type").Value;
        }

        var parameters = element.Elements("param");
        foreach (var param in parameters)
        {
            Parameters.Add(Param.FromXML(param));
        }
    }

    public string GetParametersSignature(OpenXRSpecification spec, bool useTypes = true, bool useNames = true)
    {
        StringBuilder signature = new();
        foreach (var p in Parameters)
        {
            string convertedType = Helpers.GetPrettyEnumName(Helpers.ConvertToCSharpType(p.Type, p.PointerLevel, spec));
            string convertedName = Helpers.ValidatedName(p.Name);

            if (useTypes)
                signature.Append($"{convertedType}");
            if (useTypes && useNames)
                signature.Append(' ');
            if (useNames)
                signature.Append($"{convertedName}");
            signature.Append(", ");
        }

        signature.Length -= 2;

        return signature.ToString();
    }
}

public class Proto
{
    public string Type;
    public string Name;
}

public class Param
{
    public string Type;
    public string Name;
    public int PointerLevel;
    public bool IsOptional;
    public string Externsync;
    public string Len;
    public bool IsNoautovalidity;

    internal static Param FromXML(XElement elem)
    {
        Param p = new()
        {
            Type = elem.Element("type").Value,
            Name = elem.Element("name").Value,
            Externsync = elem.Attribute("externsync")?.Value,
            Len = elem.Attribute("len")?.Value,
            IsNoautovalidity = elem.Attribute("noautovalidity")?.Value == "true",
            IsOptional = elem.Attribute("optional")?.Value == "true"
        };

        if (elem.Value.Contains($"{p.Type}**") || elem.Value.Contains($"{p.Type}* const*"))
            p.PointerLevel = 2;
        else if (elem.Value.Contains($"{p.Type}*"))
            p.PointerLevel = 1;

        return p;
    }
}