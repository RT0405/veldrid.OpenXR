using System.Xml.Linq;

namespace Veldrid.OpenXR.SourceGen.Definitions;
public struct CommandDefinition
{
    public string Name;
    public string ReturnType;
    public List<Parameter> Parameters = [];
    public string[] SuccessCodes;
    public string[] ErrorCodes;
    public string Comment;
    public string Alias;
    public string Extension;
    public CommandDefinition(XElement element)
    {
        SuccessCodes = element.Attribute("successcodes")?.Value.Split(',');
        ErrorCodes = element.Attribute("errorcodes")?.Value.Split(',');
        Comment = element.Attribute("comment")?.Value;

        var proto = element.Element("proto");
        Name = proto.Element("name").Value;
        if (proto == null)//means it will be an alias method
        {
            Alias = element.Attribute("alias").Value;
            return;
        }
        ReturnType = proto.Element("type").Value;


        foreach (var param in element.Elements("param"))
            Parameters.Add(new Parameter(param));
    }
}
public struct Parameter
{
    public string Type;
    public string Name;
    public int PointerLevel;
    public bool IsOptional;
    public string Externsync;
    public string Len;
    public bool IsNoautovalidity;
    public Parameter(XElement element)
    {
        Type = element.Element("type").Value;
        Name = element.Element("name").Value;
        Externsync = element.Attribute("externsync")?.Value;
        Len = element.Attribute("len")?.Value;
        IsNoautovalidity = element.Attribute("noautovalidity")?.Value == "true";
        IsOptional = element.Attribute("optional")?.Value == "true";

        if (element.Value.Contains($"{Type}**") || element.Value.Contains($"{Type}* const*"))
            PointerLevel = 2;
        else if (element.Value.Contains($"{Type}*"))
            PointerLevel = 1;
    }
}