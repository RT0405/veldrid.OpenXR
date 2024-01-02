using System.Xml.Linq;

namespace SourceGen;
public class VendorDefinition
{
    public string Name;
    public string Id;
    public string Comment;

    public static VendorDefinition FromXML(XElement e) => new()
    {
        Name = e.Attribute("name").Value,
        Id = e.Attribute("id").Value,
        Comment = e.Attribute("comment").Value
    };
}