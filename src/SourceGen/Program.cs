using System.Text;
using System.Text.RegularExpressions;

namespace SourceGen;
internal static partial class Program
{
    private const string projectPath = @"..\..\..\..\veldrid.OpenXR";
    private const string specFileDir = @"..\..\..\..\KhronosRegistry\xr.xml";
    private const string outputDir = @"..\..\..\..\veldrid.OpenXR.Native\Generated";
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

            sb.AppendLine($"\tpublic static XRVersion XR_CURRENT_API_VERSION => new{openXRSpec.Version};");

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
                {
                    ExtensionDefinition extension = null;
                    foreach (var e in openXRSpec.Extensions)
                    {
                        if (e.Name == constant.Name)
                            extension = e;
                    }

                    sb.AppendLine($"\tpublic static XRExtensionDescriptor {constant.Name[..^15]} => new(OpenXRNativeExtensionConstants.{constant.Name}, OpenXRNativeExtensionConstants.{constant.Value.Trim('"') + "_SPEC_VERSION"});");
                }
            }
            const string path = projectPath + @"\XRExtensionDescriptor.cs";
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
            if (structure.Members?.Count >= 2 && structure.Members[0].Type == "XrStructureType" && !structure.Name.Contains("Base"))
            {
                string XrStructureTypeName = structure.Name switch
                {
                    "XrBoundary2DFB" => "XrStructureType.XR_TYPE_BOUNDARY_2D_FB",
                    _ => "XrStructureType.XR_TYPE_" + Regex.Replace(structure.Name, @"((D3D1[1-2])|(OpenGL)|(ES)|(Win32)|(Xlib)|(XCB)|(Wayland)|(EGL)|(MNDX)|([A-Z]{1}([a-z]|([A-Z]*(?=[A-Z])))))", @"_$1")[4..].Replace("OpenGLES", "OpenGL_ES").ToUpper(),
                };
                sb.AppendLine($"\t/// <returns>a new <see cref=\"{structure.Name}\"> with it's type member set to <see cref=\"{XrStructureTypeName}\"/></returns>");
                sb.AppendLine($"\tpublic static {structure.Name} New() =>");
                sb.AppendLine($"\t\tnew() {{ type = {XrStructureTypeName} }};");
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
            sb.AppendLine($"public partial struct {handle.Name}(ulong existingHandle) : IEquatable<{handle.Name}>");
            sb.AppendLine("{");
            string handleType = handle.Dispatchable ? "nint" : "ulong";
            string nullValue = handle.Dispatchable ? "nint.Zero" : "0";

            sb.AppendLine($"\tpublic readonly {handleType} Handle = existingHandle;");

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
        Commands(true);
        Commands(false);
        void Commands(bool instance)
        {
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.CompilerServices;");
            sb.AppendLine("using System.Runtime.InteropServices;\n");
            sb.AppendLine("namespace Veldrid.OpenXR.Native;");
            sb.AppendLine($"public{(instance ? null : " static")} unsafe partial class OpenXRNative{(instance ? "Instance" : null)}");
            sb.AppendLine("{");
            if (instance)
                sb.AppendLine("#pragma warning disable CA1822 // Mark members as static");
            foreach (var command in openXRVersion.Commands)
            {
                string convertedType = Helpers.ConvertToCSharpType(command.ReturnType, 0, openXRSpec);
                if (!instance && command.Name == "xrCreateInstance")
                {
                    sb.AppendLine("\t[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                    sb.AppendLine($"\t[LibraryImport(LoaderName, EntryPoint = \"xrCreateInstance\")]");
                    sb.AppendLine($"\t[UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]");
                    sb.AppendLine($"\tprivate static partial {convertedType} {command.Name}Native({command.GetParametersSignature(openXRSpec)});");
                    CommandComment(command);
                    sb.AppendLine($"\tpublic static {convertedType} {command.Name}({command.GetParametersSignature(openXRSpec)})");
                    sb.AppendLine("\t{");
                    sb.AppendLine($"\t\tXrResult result = xrCreateInstanceNative({command.GetParametersSignature(openXRSpec, useTypes: false)});");
                    sb.AppendLine($"\t\tif(result == XrResult.XR_SUCCESS)");
                    sb.AppendLine($"\t\t\tInstance = new(*instance, *createInfo);");
                    sb.AppendLine($"\t\treturn result;");
                    sb.AppendLine("\t}");

                    continue;
                }
                if (!instance && command.Name == "xrDestroyInstance")
                {
                    sb.AppendLine("\t[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                    sb.AppendLine($"\t[LibraryImport(LoaderName, EntryPoint = \"xrDestroyInstance\")]");
                    sb.AppendLine($"\t[UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]");
                    sb.AppendLine($"\tprivate static partial {convertedType} {command.Name}Native({command.GetParametersSignature(openXRSpec)});");
                    CommandComment(command);
                    sb.AppendLine($"\tpublic static {convertedType} {command.Name}({command.GetParametersSignature(openXRSpec)})");
                    sb.AppendLine("\t{");
                    sb.AppendLine($"        XrResult result = xrDestroyInstanceNative({command.GetParametersSignature(openXRSpec, useTypes: false)});");
                    sb.AppendLine($"        if(Instance?.XrInstance == instance)");
                    sb.AppendLine($"            Instance = null;");
                    sb.AppendLine($"        return result;");
                    sb.AppendLine("\t}");

                    continue;
                }
                if (command.extension != null)
                {
                    if (instance)
                    {
                        // Delegate
                        // comments
                        CommandComment(command);
                        // public function
                        sb.AppendLine("\t[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                        sb.AppendLine($"\tpublic {convertedType} {command.Name}({command.GetParametersSignature(openXRSpec)})");
                        sb.AppendLine($"\t\t=> {command.Name}_funcPtr({command.GetParametersSignature(openXRSpec, useTypes: false)});");
                        sb.AppendLine($"\tprivate delegate* unmanaged<{command.GetParametersSignature(openXRSpec, useNames: false)}, {convertedType}> {command.Name}_funcPtr;");
                    }
                    else
                    {
                        CommandComment(command);
                        sb.AppendLine("\t[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                        sb.AppendLine($"\tpublic static {convertedType} {command.Name}({command.GetParametersSignature(openXRSpec)})");
                        sb.AppendLine($"\t\t=> Instance.{command.Name}({command.GetParametersSignature(openXRSpec, useTypes: false)});");
                    }
                }
                else
                {
                    if (instance)
                    {
                        CommandComment(command);
                        sb.AppendLine("\t[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                        sb.AppendLine($"\tpublic {convertedType} {command.Name}({command.GetParametersSignature(openXRSpec)})");
                        sb.AppendLine($"\t\t=> OpenXRNative.{command.Name}({command.GetParametersSignature(openXRSpec, useTypes: false)});");
                    }
                    else
                    {
                        CommandComment(command);
                        sb.AppendLine("\t[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                        sb.AppendLine($"\t[LibraryImport(LoaderName)]");
                        sb.AppendLine($"\t[UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]");
                        sb.AppendLine($"\tpublic static partial {convertedType} {command.Name}({command.GetParametersSignature(openXRSpec)});");
                    }
                }
                sb.AppendLine();
            }
            if (instance)
            {
                sb.AppendLine($"\tpublic void LoadFunctionPointers()");
                sb.AppendLine("\t{");
                foreach (var extension in openXRSpec.Extensions)
                {
                    if (extension.Commands.Count == 0)
                        continue;
                    sb.AppendLine($"\t\tif (HasExtensionEnabled(\"{extension.Name}\"u8))");
                    sb.AppendLine("\t\t{");
                    foreach (var command in extension.Commands)
                        sb.AppendLine($"\t\t\t{command.Name}_funcPtr = (delegate* unmanaged<{command.GetParametersSignature(openXRSpec, useNames: false)}, {Helpers.ConvertToCSharpType(command.ReturnType, 0, openXRSpec)}>)GetFunctionPointer(\"{command.Name}\"u8);");
                    sb.AppendLine("\t\t}");
                }
                //we don't have to do the commands without extensions, since they are handled by the [LibraryImport] attribute
                //foreach (var command in openXRVersion.Commands)
                //    if (command.extension == null)
                //        sb.AppendLine($"\t\t{command.Name}_funcPtr = (delegate* unmanaged<{command.GetParametersSignature(openXRSpec, useNames: false)}, {Helpers.ConvertToCSharpType(command.ReturnType, 0, openXRSpec)}>)GetFunctionPointer(\"{command.Name}\"u8);");

                sb.AppendLine("\t}");
            }
            if (instance)
                sb.AppendLine("#pragma warning restore CA1822 // Mark members as static");
            sb.AppendLine("}");
            WriteToFile(outputDir + @$"\Commands{(instance ? "Instance" : null)}.cs", sb);

            void CommandComment(CommandDefinition command)
            {
                if (command.extension != null)
                {
                    sb.AppendLine($"\t/// <summary> Requires XR extension \"{command.extension.Name}\" </summary>");
                }
                if (command.Comment != null)
                {
                    sb.AppendLine("\t/// <remarks>");
                    sb.AppendLine("\t/// " + command.Comment.Replace("\n", "\n/// <br/> "));
                    sb.AppendLine("\t/// </remarks>");
                }
                if (command.SuccessCodes != null)
                {
                    sb.AppendLine("\t/// <returns>");
                    sb.AppendLine("\t///       Success Codes:");
                    for (int i = 0; i < command.SuccessCodes.Length; i++)
                        sb.AppendLine($"\t/// <br/> ⠀⠀<see cref=\"XrResult.{command.SuccessCodes[i]}\"/>");
                    sb.AppendLine("\t/// <br/> Error Codes:");
                    for (int i = 0; i < command.ErrorCodes.Length; i++)
                        sb.AppendLine($"\t/// <br/> ⠀⠀<see cref=\"XrResult.{command.ErrorCodes[i]}\"/>");
                    sb.AppendLine("\t/// </returns>");
                }
            }
        }

        //Name Structs
        sb.AppendLine("using System.Text;");
        sb.AppendLine();
        sb.AppendLine("namespace Veldrid.OpenXR.Native;");
        foreach (var constant in openXRSpec.Constants)
        {
            if (!constant.Name.EndsWith("_NAME_SIZE"))
                continue;
            string structName = $"Xr{SnakeCaseToCamelCase(constant.Name[7..^10], true)}Name";
            sb.AppendLine();
            sb.AppendLine($"public unsafe struct {structName} : IEquatable<{structName}>");
            sb.AppendLine("{");
            sb.AppendLine($"    public const int MaxLength = (int)OpenXRNative.{constant.Name};");
            sb.AppendLine($"    public fixed byte bytes[MaxLength];");
            sb.AppendLine($"    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>");
            sb.AppendLine($"    public byte* Ptr");
            sb.AppendLine("    {");
            sb.AppendLine("        get");
            sb.AppendLine("        {");
            sb.AppendLine($"            fixed({structName}* ptr = &this)");
            sb.AppendLine($"                return (byte*)ptr;");
            sb.AppendLine("        }");
            sb.AppendLine("        set");
            sb.AppendLine("        {");
            sb.AppendLine($"            int i = 0;");
            sb.AppendLine($"            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;");
            sb.AppendLine("            bytes[MaxLength - 1] = 0;");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine($"    public string Name");
            sb.AppendLine("    {");
            sb.AppendLine("        get");
            sb.AppendLine("        {");
            sb.AppendLine($"            int i = 0;");
            sb.AppendLine($"            int byteCount = 0;");
            sb.AppendLine($"            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;");
            sb.AppendLine($"                byteCount++;");
            sb.AppendLine();
            sb.AppendLine($"            fixed(byte* ptr = bytes)");
            sb.AppendLine($"                return Encoding.UTF8.GetString(ptr, byteCount);");
            sb.AppendLine("        }");
            sb.AppendLine("        set");
            sb.AppendLine("        {");
            sb.AppendLine($"            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)");
            sb.AppendLine($"                throw new InvalidOperationException(\"string was too large to fit inside of {structName} struct, which has a size of {constant.Value}\");");
            sb.AppendLine($"            fixed(byte* ptr = bytes)");
            sb.AppendLine($"                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine($"    public {structName}(ReadOnlySpan<byte> value)");
            sb.AppendLine("    {");
            sb.AppendLine("        if (value.Length >= MaxLength - 1)");
            sb.AppendLine("            throw new InvalidOperationException(\"string was too large to fit inside of {structName} struct, which has a size of {constant.Value}\");");
            sb.AppendLine("        int i = 0;");
            sb.AppendLine("        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)");
            sb.AppendLine("            if(i == value.Length)");
            sb.AppendLine("            {");
            sb.AppendLine("                bytes[i] = 0;");
            sb.AppendLine("                return;");
            sb.AppendLine("            }");
            sb.AppendLine("        bytes[MaxLength - 1] = 0;");
            sb.AppendLine("    }");
            sb.AppendLine($"    public {structName}(string name) => Name = name;");
            sb.AppendLine($"    public {structName}(byte* ptr) => Ptr = ptr;");
            sb.AppendLine($"    public static implicit operator string({structName} value) => value.Name;");
            sb.AppendLine($"    public static implicit operator {structName}(string value) => new(value);");
            sb.AppendLine($"    public static implicit operator byte*({structName} value) => value.Ptr;");
            sb.AppendLine($"    public static implicit operator {structName}(byte* value) => new(value);");
            sb.AppendLine($"    public static implicit operator {structName}(ReadOnlySpan<byte> value) => new(value);");
            sb.AppendLine($"    public static bool operator !=({structName} lhs, {structName} rhs) => !(lhs == rhs);");
            sb.AppendLine($"    public static bool operator ==({structName} lhs, {structName} rhs)");
            sb.AppendLine("    {");
            sb.AppendLine($"        for(int i = 0; i < MaxLength; i++)");
            sb.AppendLine("        {");
            sb.AppendLine("            if(lhs.bytes[i] != rhs.bytes[i])");
            sb.AppendLine("                return false;");
            sb.AppendLine("            if(lhs.bytes[i] == 0)");
            sb.AppendLine("                return true;");
            sb.AppendLine("        }");
            sb.AppendLine("        return false;");
            sb.AppendLine("    }");
            sb.AppendLine($"    public readonly override bool Equals(object obj) => obj is {structName} e && Equals(e);");
            sb.AppendLine($"    public readonly bool Equals({structName} other) => this == other;");
            sb.AppendLine("    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be");
            sb.AppendLine("    {");
            sb.AppendLine("        int hash = 0;");
            sb.AppendLine("        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)");
            sb.AppendLine("            hash = HashCode.Combine(hash, bytes[i]);");
            sb.AppendLine("        return hash;");
            sb.AppendLine("    }");
            sb.AppendLine("}");
        }
        WriteToFile(outputDir + @$"\NameStructs.cs", sb);
    }
    private static void WriteToFile(string dir, StringBuilder sb) { WriteToFile(dir, sb.ToString()); sb.Clear(); }
    private static void WriteToFile(string dir, string text)
    {

        text = text.Replace("\t", "    "); //replace tabs

        text = text.Replace("\r\n", "\n"); //replace nl
        text = text.Replace("\n", "\r\n");

        // Trim trailing spaces that could have come from code gen.
        var lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

        for (int i = 0; i < lines.Length; ++i)
            lines[i] = lines[i].TrimEnd(' ');

        text = string.Join("\r\n", lines);
        text = text.TrimEnd('\r', '\n', ' ');
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
    public static string SnakeCaseToCamelCase(string value, bool capitalizeFirstChar)
    {
        StringBuilder sb = new();
        bool capitalize = capitalizeFirstChar;
        for (int i = 0; i < value.Length; ++i)
        {
            char c = value[i];
            if (capitalize)
                c = char.ToUpper(c);
            else
                c = char.ToLower(c);
            capitalize = false;
            if (c == '_')
            {
                capitalize = true;
                continue;
            }
            sb.Append(c);
        }
        return sb.ToString();
    }
}