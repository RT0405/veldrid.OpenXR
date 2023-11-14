using System.Text;
using System.Xml.Linq;

namespace SourceGen;
public class CommandDefinition
{
    public Proto Prototype;
    public string Name;
    public string ReturnType;
    public List<Param> Parameters = new();
    public string[] Queues;
    public string RenderPass;
    public string[] CmdBufferLevel;
    public string Pipeline;
    public string[] SuccessCodes;
    public string[] ErrorCodes;
    public string Comment;
    public ExtensionDefinition extension;

    public static CommandDefinition FromXML(XElement elem)
    {
        CommandDefinition command = new()
        {
            SuccessCodes = elem.Attribute("successcodes")?.Value.Split(','),
            ErrorCodes = elem.Attribute("errorcodes")?.Value.Split(','),
            Queues = elem.Attribute("queues")?.Value.Split(','),
            RenderPass = elem.Attribute("renderpass")?.Value,
            Pipeline = elem.Attribute("pipeline")?.Value,
            CmdBufferLevel = elem.Attribute("cmdbufferlevel")?.Value.Split(','),
            Comment = elem.Attribute("comment")?.Value
        };

        var proto = elem.Element("proto");

        if (proto != null)
        command.Prototype = new() { Name = proto.Element("name").Value, Type = proto.Element("type").Value };

        var parameters = elem.Elements("param");
        foreach (var param in parameters)
        {
            command.Parameters.Add(Param.FromXML(param));
        }

        return command;
    }

    public string GetParametersSignature(OpenXRSpecification spec, bool useTypes = true)
    {
        StringBuilder signature = new();
        foreach (var p in Parameters)
        {
            string convertedType = Helpers.GetPrettyEnumName(Helpers.ConvertToCSharpType(p.Type, p.PointerLevel, spec));
            string convertedName = Helpers.ValidatedName(p.Name);

            if (useTypes)
                signature.Append($"{convertedType} ");

            signature.Append($"{convertedName}, ");
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