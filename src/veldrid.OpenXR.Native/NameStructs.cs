using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Veldrid.OpenXR.Native;
public struct XrExtensionName
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_EXTENSION_NAME_SIZE;
    public unsafe fixed byte bytes[MaxLength];
    /// <summary> only for use with stackalloc </summary>
    public unsafe byte* Ptr
    {
        get
        {
            fixed (XrExtensionName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while (i < MaxLength && (bytes[i] = value[i++]) != 0) ;
        }
    }
    public unsafe string Name
    {
        get
        {
            int characters = 0;
            while (bytes[characters] != 0 && characters < MaxLength)
                characters++;

            fixed (byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, characters);
        }
        set
        {
            fixed (byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrExtensionName(string name) => Name = name;
    public unsafe XrExtensionName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrExtensionName value) => value.Name;
    public static implicit operator XrExtensionName(string value) => new(value);
    public static unsafe implicit operator byte*(XrExtensionName value) => value.Ptr;
    public static unsafe implicit operator XrExtensionName(byte* value) => new(value);
    public static bool operator !=(XrExtensionName lhs, XrExtensionName rhs) => !(lhs == rhs);
    public static unsafe bool operator ==(XrExtensionName lhs, XrExtensionName rhs)
    {
        for(int i =0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrExtensionName e && this == e;
    public override int GetHashCode() => Name.GetHashCode();
}
public struct XrApiLayerName
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_API_LAYER_NAME_SIZE;
    public unsafe fixed byte bytes[MaxLength];
    /// <summary> only for use with stackalloc </summary>
    public unsafe byte* Ptr
    {
        get
        {
            fixed (XrApiLayerName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while (i < MaxLength && (bytes[i] = value[i++]) != 0) ;
        }
    }
    public unsafe string Name
    {
        get
        {
            int characters = 0;
            while (bytes[characters] != 0 && characters < MaxLength)
                characters++;

            fixed (byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, characters);
        }
        set
        {
            fixed (byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrApiLayerName(string name) => Name = name;
    public unsafe XrApiLayerName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrApiLayerName value) => value.Name;
    public static implicit operator XrApiLayerName(string value) => new(value);
    public static unsafe implicit operator byte*(XrApiLayerName value) => value.Ptr;
    public static unsafe implicit operator XrApiLayerName(byte* value) => new(value);
}
public struct XrApplicationName
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_APPLICATION_NAME_SIZE;
    public unsafe fixed byte bytes[MaxLength];
    /// <summary> only for use with stackalloc </summary>
    public unsafe byte* Ptr
    {
        get
        {
            fixed (XrApplicationName* ptr = &this)
                return (byte*)ptr;
        }
    }
    public unsafe string Name
    {
        get
        {
            int characters = 0;
            while (bytes[characters] != 0 && characters < MaxLength)
                characters++;

            fixed (byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, characters);
        }
        set
        {
            fixed (byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrApplicationName(string name) => Name = name;
    public static implicit operator string(XrApplicationName value) => value.Name;
    public static implicit operator XrApplicationName(string value) => new(value);
}
public struct XrEngineName
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_ENGINE_NAME_SIZE;
    public unsafe fixed byte bytes[MaxLength];
    /// <summary> only for use with stackalloc </summary>
    public unsafe byte* Ptr
    {
        get
        {
            fixed (XrEngineName* ptr = &this)
                return (byte*)ptr;
        }
    }
    public unsafe string Name
    {
        get
        {
            int characters = 0;
            while (bytes[characters] != 0 && characters < MaxLength)
                characters++;

            fixed (byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, characters);
        }
        set
        {
            fixed (byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrEngineName(string name)
    {
        Name = name;
    }
    public static implicit operator string(XrEngineName value) => value.Name;
    public static implicit operator XrEngineName(string value) => new(value);
}