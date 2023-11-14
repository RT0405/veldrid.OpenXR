using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace SourceGen;
public class StructureDefinition
{
    public string Name;
    public bool IsReturnedOnly;
    public List<Member> Members = new();

    public static StructureDefinition FromXML(XElement elem)
    {
        StructureDefinition s = new()
        {
            Name = elem.Attribute("name").Value,
            IsReturnedOnly = elem.Attribute("returnedonly")?.Value == "true"
        };

        var members = elem.Elements("member");
        foreach (var m in members)
            s.Members.Add(Member.FromXML(m));

        return s;
    }
    public static int GetSizeInBytes(StructureDefinition s, OpenXRVersion openXRVersion)
    {
        int size = 0;
        foreach (var member in s.Members)
        {
            int multiply = 1;
            if (member.ElementCount > 0)
            {
                multiply = member.ElementCount;
            }

            size += Member.GetSizeInBytes(member, openXRVersion) * multiply;
        }

        return size;
    }
}

public class Member
{
    public string Name;
    public string Type;
    public int PointerLevel;
    public bool IsOptional;
    public bool IsNoautovalidity;
    public string Comment;
    public int ElementCount;
    public string ConstantValue;
    public string Value;
    public int? ExplicityLayoutValue;

    public static Member FromXML(XElement elem)
    {
        Member m = new()
        {
            Name = elem.Element("name").Value,
            Type = elem.Element("type").Value,
            Comment = elem.Element("comment")?.Value,
            IsOptional = elem.Attribute("optional")?.Value == "true",
            IsNoautovalidity = elem.Attribute("noautovalidity")?.Value == "true",

            Value = elem.Value
        };

        Match layouts = Regex.Match(m.Value, $@":(\d+)");
        if (layouts.Groups.Count > 1)
            m.ExplicityLayoutValue = int.Parse(layouts.Groups[1].Value);

        if (elem.Value.Contains($"{m.Type}**") || elem.Value.Contains($"{m.Type}* const*"))
            m.PointerLevel = 2;
        else if (elem.Value.Contains($"{m.Type}*"))
            m.PointerLevel = 1;

        m.ConstantValue = elem.Element("enum")?.Value;

        if (m.ConstantValue == null)
        {
            Match match = Regex.Match(m.Value, $@"{m.Name}\[(\d+)\](\[(\d+)\])?");
            if (match.Captures.Count > 0)
            {
                if (match.Groups[2].Value != string.Empty)
                    m.ElementCount = int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[3].Value);
                else
                    m.ElementCount = int.Parse(match.Groups[1].Value);
            }
        }

        return m;
    }
    public static int GetSizeInBytes(Member m, OpenXRVersion openXRVersion)
    {
        if (m.ExplicityLayoutValue.HasValue)
            return m.ExplicityLayoutValue.Value / 8;
        else
        {
            switch (m.Type)
            {
                case "int8_t":
                case "int8_t*":
                case "uint8_t":
                case "char":
                case "uint8_t*":
                case "char*":
                    return 1;
                case "uint16_t":
                case "uint16_t*":
                case "int16_t":
                case "int16_t*":
                    return 2;
                case "uint32_t":
                case "DWORD":
                case "uint32_t*":
                case "int32_t":
                case "int32_t*":
                case "size_t":
                case "float":
                case "float*":
                    return 4;
                case "uint64_t":
                case "uint64_t*":
                case "int64_t":
                case "int64_t*":
                case "double":
                case "double*":
                case "void":
                    return 8;
                case "XrBool32":
                    return 4;
                default:
                    var @struct = openXRVersion.Structs.Find(s => s.Name == m.Type);

                    if (@struct != null) // structs
                        return StructureDefinition.GetSizeInBytes(@struct, openXRVersion);
                    else
                        return 4; // enums
            }
        }
    }
}