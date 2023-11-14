using System.Xml.Linq;

namespace SourceGen;
public class TypedefDefinition
{
    public string Name;
    public string Requires;
    public string Type;

    public static TypedefDefinition FromXML(XElement e) => new()
    {
        Name = e.Element("name").Value,
        Requires = e.Attribute("requires")?.Value,
        Type = e.Element("type").Value
    };
}