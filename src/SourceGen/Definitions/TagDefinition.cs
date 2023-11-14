using System.Xml.Linq;

namespace SourceGen;
public class TagDefinition
{
    public string Name;
    public string Author;
    public string Contact;
    public static TagDefinition FromXML(XElement e) => new() 
    {
        Name = e.Attribute("name").Value,
        Author = e.Attribute("author").Value,
        Contact = e.Attribute("contact").Value
    };
}