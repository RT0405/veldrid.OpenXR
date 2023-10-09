using System.Text;

namespace SourceGen;
public static class Helpers
{
    public static string ToCSharp(this ConstantType type)
    {
        return type switch
        {
            ConstantType.UInt32 => "uint",
            ConstantType.UInt64 => "ulong",
            ConstantType.Float32 => "float",
            ConstantType.String => "string",
            _ => throw new InvalidOperationException("Invalid value"),
        };
    }

    public static string ValidatedName(string name)
    {
        if (name == "object")
            return "vkObject";
        else if (name == "event")
            return "vkEvent";

        return name;
    }

    public static string GetPrettyEnumName(string value)
    {
        int start;
        if((start = value.IndexOf("bit", StringComparison.OrdinalIgnoreCase)) != -1)
            return value.Remove(start, 3);

        return value;
    }

    public static uint GetTypeSize(string type)
    {
        if (type == "char" || type == "uint8_t")
            return 1;
        else if (type == "uint16_t" || type == "int16_t")
            return 2;

        // uint32_t, uint64_t, int32_t, int64_t, int64_t*, size_t, DWORD
        return 4;
    }

    public static string ConvertToCSharpType(string type, int pointerlevel, OpenXRSpecification spec)
    {
        string memberType = type;

        if (type.StartsWith("PFN") || IsIntPtr(memberType))
            return "IntPtr";

        string result = ConvertBasicTypes(memberType);
        if (result == string.Empty)
        {
            if (spec.Alias.TryGetValue(memberType, out string alias))
                memberType = alias;

            spec.BaseTypes.TryGetValue(memberType, out string baseType);
            if (baseType != null)
                result = ConvertBasicTypes(baseType);
            else
            {
                var typeDef = spec.TypeDefs.Find(t => t.Name == memberType);
                if (typeDef != null)
                {
                    if (typeDef.Requires != null)
                        result = typeDef.Requires;
                    else
                    {
                        spec.BaseTypes.TryGetValue(typeDef.Type, out baseType);
                        if (baseType != null)
                            result = ConvertBasicTypes(baseType);
                    }
                }
                else
                    result = memberType;
            }
        }

        if (pointerlevel > 0)
            for (int i = 0; i < pointerlevel; i++)
                result += "*";

        return result;
    }

    public static string ConvertBasicTypes(string type)
    {
        return type switch
        {
            "int8_t" => "sbyte",
            "int8_t*" => "sbyte*",
            "uint8_t" or "char" => "byte",
            "wchar_t" => "string",
            "uint8_t*" or "char*" => "byte*",
            "uint16_t" => "ushort",
            "uint16_t*" => "ushort*",
            "int16_t" => "short",
            "int16_t*" => "int16*",
            "uint32_t" or "DWORD" => "uint",
            "uint32_t*" => "uint*",
            "uint64_t" or "XR_DEFINE_ATOM" => "ulong",
            "uint64_t*" => "ulong*",
            "int32_t" => "int",
            "int32_t*" => "int*",
            "int64_t" => "long",
            "int64_t*" => "long*",
            "size_t" => "UIntPtr",
            "float" => "float",
            "float*" => "float*",
            "double" => "double",
            "double*" => "double*",
            "void" => "void",
            "XrBool32" => "XrBool32",
            "D3D_FEATURE_LEVEL" => "uint",
            _ => string.Empty,
        };
    }
    public static bool SupportFixed(string type)
    {
#pragma warning disable IDE0066 // Convert switch statement to expression
        switch (type)
        {
            case "bool":
            case "byte":
            case "short":
            case "int":
            case "long":
            case "char":
            case "sbyte":
            case "ushort":
            case "uint":
            case "ulong":
            case "float":
            case "double":
                return true;
            default:
                return false;
        }
    }
    public static bool IsIntPtr(string type)
    {
        switch (type)
        {
            case "ANativeWindow":
            case "jobject":
            case "ID3D11Device":
            case "ID3D11Texture2D":
            case "ID3D12CommandQueue":
            case "ID3D12Device":
            case "ID3D12Resource":
            case "EGLDisplay":
            case "EGLConfig":
            case "EGLContext":
            case "PFNEGLGETPROCADDRESSPROC":
            case "GLXFBConfig":
            case "GLXDrawable":
            case "GLXContext":
            case "HGLRC":
            case "IUnknown":
            case "wl_display":
            case "HDC":
            case "LUID":
            case "LARGE_INTEGER":
            case "Display":
            case "VisualID":
            case "Window":
            case "xcb_glx_fbconfig_t":
            case "xcb_glx_drawable_t":
            case "xcb_glx_context_t":
            case "xcb_connection_t":
            case "xcb_visualid_t":
            case "xcb_window_t":
            case "PFN_vkGetInstanceProcAddr":
            case "VkAllocationCallbacks":
            case "VkDevice":
            case "VkDeviceCreateInfo":
            case "VkFormat":
            case "VkImage":
            case "VkInstance":
            case "VkInstanceCreateInfo":
            case "VkPhysicalDevice":
            case "VkResult":
            case "timespec":
            case "EGLenum":
            case "VkFilter":
            case "VkSamplerMipmapMode":
            case "VkSamplerAddressMode":
            case "VkComponentSwizzle":
            case "MLCoordinateFrameUID":
                return true;
            default:
                return false;
        }
#pragma warning restore IDE0066 // Convert switch statement to expression
    }
    /// <summary> replaces the text in between  </summary>
    /// <param name="src"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="replace"></param>
    /// <returns></returns>
    public static string Replace(string src, string start, string end, string replace)
    {
        try
        {
            StringBuilder sb = new();
            string[] split = src.Split(start, 2);
            sb.Append(split[0]);
            sb.Append(start);
            split = split[1].Split(end, 2);
            sb.Append(replace);
            sb.Append(end);
            sb.Append(split[1]);
            return sb.ToString();
        }
        catch
        {
            Console.WriteLine("Replace Failed");
            return src;
        }
    }
}