using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace SourceGen;
public class FuncpointerDefinition
{
    public string Name;
    public string Type;
    public List<Parameter> Parameters = [];

    public static FuncpointerDefinition FromXML(XElement elem)
    {
        Match pointerType = Regex.Match(elem.Value, @"typedef\s+(\w+[*]?)");
        FuncpointerDefinition funcpointer = new()
        {
            Name = elem.Element("name").Value,
            Type = pointerType.Groups[1].Value
        };

        foreach (Match match in Regex.Matches(elem.Value, @"((\w+[*]?)\s+(\w+),|(\w+[*]?)\s+(\w+)\);)").Cast<Match>())
        {
            Parameter p = new();

            if (match.Groups[2].Value != string.Empty)
            {
                p.Type = match.Groups[2].Value;
                p.Name = match.Groups[3].Value;
            }
            else
            {
                p.Type = match.Groups[4].Value;
                p.Name = match.Groups[5].Value;
            }

            funcpointer.Parameters.Add(p);
        }

        return funcpointer;
    }
}
public class Parameter
{
    public string Type;
    public string Name;
}