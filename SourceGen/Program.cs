using System.Collections.Immutable;
using System.Text;

namespace SourceGen;
internal static partial class Program
{
    private const string projectPath = @"..\..\..\..\veldrid.OpenXR";
    private const string specFileDir = @"..\..\..\..\SourceGen\KhronosRegistry\xr.xml";
    private const string outputDir = @"..\..\..\..\veldrid.OpenXR\Native\Generated";
    static void Main()
    {
        Console.WriteLine(Path.GetFullPath(specFileDir));

        var openXRSpec = OpenXRSpecification.FromFile(specFileDir);
        var openXRVersion = OpenXRVersion.FromSpec(openXRSpec, "AllVersions", openXRSpec.Extensions);

        StringBuilder sb = new();

        // Write Constants
        {
            StringBuilder sbe = new();
            StringBuilder extensionNames = new();
            StringBuilder extensionSpecVersions = new();
            sb.AppendLine("namespace Veldrid.OpenXR.Native;");
            sb.AppendLine("public static partial class OpenXRNative");
            sb.AppendLine("{");
            sbe.AppendLine("namespace Veldrid.OpenXR.Native;");
            sbe.AppendLine("public static class OpenXRNativeExtensionConstants");
            sbe.AppendLine("{");
            foreach (var constant in openXRVersion.Constants)
            {
                StringBuilder s;
                if (constant.Name.EndsWith("_EXTENSION_NAME"))
                    s = extensionNames;
                else if (constant.Name.EndsWith("_SPEC_VERSION"))
                    s = extensionSpecVersions;
                else
                    s = sb;

                if (constant.Alias != null)
                {
                    var refConstant = openXRVersion.Constants.FirstOrDefault(c => c.Name == constant.Alias);
                    s.AppendLine($"\tpublic const {refConstant.Type.ToCSharp()} {constant.Name} = {refConstant.Name};");
                }
                else
                    s.AppendLine($"\tpublic const {constant.Type.ToCSharp()} {constant.Name} = {ConstantDefinition.NormalizeValue(constant.Value)};");
            }
            sb.AppendLine("}");
            WriteToFile(outputDir + @"\NativeConstants.cs", sb);
            sbe.Append(extensionNames);
            sbe.Append(extensionSpecVersions);
            sbe.AppendLine("}");
            WriteToFile(outputDir + @"\OpenXRNativeExtensionConstants.cs", sbe);
        }

        // Extension "consts"
        {
            foreach (var constant in openXRVersion.Constants)
            {
                if (constant.Name.EndsWith("_EXTENSION_NAME"))
                    sb.AppendLine($"\tpublic static XRExtensionDescriptor {constant.Name[..^15]} => new(OpenXRNativeExtensionConstants.{constant.Name}, OpenXRNativeExtensionConstants.{constant.Value.Trim('"') + "_SPEC_VERSION"});");
            }
            const string path = projectPath + @"\API\Structs\XRExtensionDescriptor.cs";
            WriteToFile(path, Helpers.Replace(File.ReadAllText(path), "#region Extensions\r\n", "    #endregion", sb.ToString()));
            sb.Clear();
        }

        // Enums
        sb.AppendLine("using System;\n");
        sb.AppendLine("namespace Veldrid.OpenXR.Native;");
        foreach (var e in openXRVersion.Enums)
        {
            if (e.Type == EnumType.Bitmask)
                sb.AppendLine("[Flags]");

            sb.AppendLine($"public enum {Helpers.GetPrettyEnumName(e.Name)}");
            sb.AppendLine("{");

            if (!e.Values.Exists(v => v.Value == 0))
                sb.AppendLine("\tNone = 0,");

            foreach (var val in e.Values)
            {
                if (!string.IsNullOrWhiteSpace(val.Comment))
                    sb.AppendLine($"\t/// <summary> {val.Comment.Replace("\r", "\r    /// ")} </summary>");
                sb.AppendLine($"\t{val.Name} = {val.Value},");
            }
            sb.AppendLine("}");
        }
        WriteToFile(outputDir + @$"\Enums.cs", sb);


        // structs
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Runtime.InteropServices;\n");
        sb.AppendLine("namespace Veldrid.OpenXR.Native;");
        foreach (var structure in openXRVersion.Structs)
        {
            var useExplicitLayout = structure.Members.Any(s => s.ExplicityLayoutValue.HasValue == true);
            int layoutValue = 0;
            if (useExplicitLayout)
                sb.AppendLine("[StructLayout(LayoutKind.Explicit)]");
            else
                sb.AppendLine("[StructLayout(LayoutKind.Sequential)]");
            sb.AppendLine($"public unsafe partial struct {structure.Name}");
            sb.AppendLine("{");

            foreach (var member in structure.Members)
            {
                if (useExplicitLayout)
                {
                    sb.AppendLine($"\t[FieldOffset({layoutValue})]");
                    layoutValue += Member.GetSizeInBytes(member, openXRVersion);
                }

                string csType = Helpers.GetPrettyEnumName(Helpers.ConvertToCSharpType(member.Type, member.PointerLevel, openXRSpec));

                if (member.ElementCount > 1)
                {
                    for (int i = 0; i < member.ElementCount; i++)
                    {
                        sb.AppendLine($"\tpublic {csType} {member.Name}_{i};");
                    }
                }
                else if (member.ConstantValue != null)
                {
                    var validConstant = openXRVersion.Constants.FirstOrDefault(c => c.Name == member.ConstantValue);

                    if (Helpers.SupportFixed(csType))
                    {
                        sb.AppendLine($"\tpublic fixed {csType} {Helpers.ValidatedName(member.Name)}[(int)OpenXRNative.{validConstant.Name}];");
                    }
                    else
                    {
                        int count = 0;

                        if (validConstant.Value == null)
                        {
                            var alias = openXRVersion.Constants.FirstOrDefault(c => c.Name == validConstant.Alias);
                            count = int.Parse(alias.Value);
                        }
                        else
                        {
                            count = int.Parse(validConstant.Value);
                        }

                        for (int i = 0; i < count; i++)
                        {
                            sb.AppendLine($"\tpublic {csType} {member.Name}_{i};");
                        }
                    }
                }
                else
                {
                    sb.AppendLine($"\tpublic {csType} {Helpers.ValidatedName(member.Name)};");
                }
            }
            sb.AppendLine("}");
        }
        WriteToFile(outputDir + @$"\Structs.cs", sb);


        // Handles
        sb.AppendLine("using System;\n");
        sb.AppendLine("namespace Veldrid.OpenXR.Native;");
        sb.AppendLine("#pragma warning disable IDE0250 // Make struct 'readonly'");
        foreach (var handle in openXRVersion.Handles)
        {
            sb.AppendLine($"public partial struct {handle.Name} : IEquatable<{handle.Name}>");
            sb.AppendLine("{");
            string handleType = handle.Dispatchable ? "IntPtr" : "ulong";
            string nullValue = handle.Dispatchable ? "IntPtr.Zero" : "0";

            sb.AppendLine($"\tpublic readonly {handleType} Handle;");

            sb.AppendLine($"\tpublic {handle.Name}({handleType} existingHandle) {{ Handle = existingHandle; }}");
            sb.AppendLine($"\tpublic static {handle.Name} Null => new({nullValue});");
            sb.AppendLine($"\tpublic static implicit operator {handle.Name}({handleType} handle) => new(handle);");
            sb.AppendLine($"\tpublic static bool operator ==({handle.Name} left, {handle.Name} right) => left.Handle == right.Handle;");
            sb.AppendLine($"\tpublic static bool operator !=({handle.Name} left, {handle.Name} right) => left.Handle != right.Handle;");
            sb.AppendLine($"\tpublic static bool operator ==({handle.Name} left, {handleType} right) => left.Handle == right;");
            sb.AppendLine($"\tpublic static bool operator !=({handle.Name} left, {handleType} right) => left.Handle != right;");
            sb.AppendLine($"\tpublic readonly bool Equals({handle.Name} h) => Handle == h.Handle;");
            sb.AppendLine($"\tpublic readonly override bool Equals(object o) => o is {handle.Name} h && Equals(h);");
            sb.AppendLine($"\tpublic readonly override int GetHashCode() => Handle.GetHashCode();");
            sb.AppendLine("}\n");
        }
        sb.AppendLine($"#pragma warning restore IDE0250 // Make struct 'readonly'");
        WriteToFile(outputDir + @"\Handles.cs", sb);

        // Commands
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Runtime.InteropServices;\n");
        sb.AppendLine("namespace Veldrid.OpenXR.Native;");
        sb.AppendLine("public static unsafe partial class OpenXRNative");
        sb.AppendLine("{");
        sb.AppendLine("#pragma warning disable CA1401 // P/Invokes should not be visible");
        foreach (var command in openXRVersion.Commands)
        {
            string convertedType = Helpers.ConvertToCSharpType(command.Prototype.Type, 0, openXRSpec);
            if(command.Comment != null)
            {
                sb.AppendLine("/// <summary>");
                sb.AppendLine("/// " + command.Comment.Replace("\n", "\n/// <br/> "));
                sb.AppendLine("/// </summary>");
            }
            if(command.SuccessCodes != null)
            {
                sb.AppendLine("/// <returns>");
                sb.AppendLine("///       Success Codes:");
                for(int i = 0; i < command.SuccessCodes.Length; i++)
                    sb.AppendLine($"/// <br/> ⠀⠀<see cref=\"XrResult.{command.SuccessCodes[i]}\"/>");
                sb.AppendLine("/// <br/> Error Codes:");
                for(int i = 0; i < command.ErrorCodes.Length; i++)
                    sb.AppendLine($"/// <br/> ⠀⠀<see cref=\"XrResult.{command.ErrorCodes[i]}\"/>");
                sb.AppendLine("/// </returns>");
            }
            sb.AppendLine("\t[DllImport(dllName, CallingConvention = callConv)]");
            sb.AppendLine($"\tpublic static extern {convertedType} {command.Prototype.Name}({command.GetParametersSignature(openXRSpec)});");
        }
        sb.AppendLine("#pragma warning restore CA1401 // P/Invokes should not be visible");
        sb.AppendLine("}");
        WriteToFile(outputDir + @"\Commands.cs", sb);
    }
    private static void WriteToFile(string dir, StringBuilder sb) { WriteToFile(dir, sb.ToString()); sb.Clear(); }
    private static void WriteToFile(string dir, string text)
    {

        text = text.Replace("\t", "    "); //replace tabs

        text = text.Replace("\r\n", "\n"); //replace nl
        text = text.Replace("\n", "\r\n");

        // Trim trailing spaces that could have come from code gen.
        var lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

        for(int i = 0; i < lines.Length; ++i)
            lines[i] = lines[i].TrimEnd(' ');

        text = string.Join("\r\n", lines);
        text = text.TrimEnd('\r','\n', ' ');
        File.WriteAllText(dir, text);
    }
    public static string Replace(string src, string start, string end, string replace)
    {
        StringBuilder sb = new();
        string[] split = src.Split(start, 2);
        sb.Append(split[0]);
        sb.Append(start);
        src = split[1];
        split = src.Split(end, 2);
        sb.Append(replace);
        sb.Append(end);
        sb.Append(split[1]);
        return sb.ToString();
    }
}