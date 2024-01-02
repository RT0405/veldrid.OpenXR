using System.Text;

namespace Veldrid.OpenXR.Native;

public unsafe struct XrExtensionName : IEquatable<XrExtensionName>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_EXTENSION_NAME_SIZE;
    public fixed byte bytes[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public byte* Ptr
    {
        get
        {
            fixed(XrExtensionName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;
            bytes[MaxLength - 1] = 0;
        }
    }
    public string Name
    {
        get
        {
            int i = 0;
            int byteCount = 0;
            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;
                byteCount++;

            fixed(byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, byteCount);
        }
        set
        {
            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)
                throw new InvalidOperationException("string was too large to fit inside of XrExtensionName struct, which has a size of 128");
            fixed(byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrExtensionName(ReadOnlySpan<byte> value)
    {
        if (value.Length >= MaxLength - 1)
            throw new InvalidOperationException("string was too large to fit inside of {structName} struct, which has a size of {constant.Value}");
        int i = 0;
        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)
            if(i == value.Length)
            {
                bytes[i] = 0;
                return;
            }
        bytes[MaxLength - 1] = 0;
    }
    public XrExtensionName(string name) => Name = name;
    public XrExtensionName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrExtensionName value) => value.Name;
    public static implicit operator XrExtensionName(string value) => new(value);
    public static implicit operator byte*(XrExtensionName value) => value.Ptr;
    public static implicit operator XrExtensionName(byte* value) => new(value);
    public static implicit operator XrExtensionName(ReadOnlySpan<byte> value) => new(value);
    public static bool operator !=(XrExtensionName lhs, XrExtensionName rhs) => !(lhs == rhs);
    public static bool operator ==(XrExtensionName lhs, XrExtensionName rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrExtensionName e && Equals(e);
    public readonly bool Equals(XrExtensionName other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)
            hash = HashCode.Combine(hash, bytes[i]);
        return hash;
    }
}

public unsafe struct XrApiLayerName : IEquatable<XrApiLayerName>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_API_LAYER_NAME_SIZE;
    public fixed byte bytes[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public byte* Ptr
    {
        get
        {
            fixed(XrApiLayerName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;
            bytes[MaxLength - 1] = 0;
        }
    }
    public string Name
    {
        get
        {
            int i = 0;
            int byteCount = 0;
            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;
                byteCount++;

            fixed(byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, byteCount);
        }
        set
        {
            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)
                throw new InvalidOperationException("string was too large to fit inside of XrApiLayerName struct, which has a size of 256");
            fixed(byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrApiLayerName(ReadOnlySpan<byte> value)
    {
        if (value.Length >= MaxLength - 1)
            throw new InvalidOperationException("string was too large to fit inside of {structName} struct, which has a size of {constant.Value}");
        int i = 0;
        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)
            if(i == value.Length)
            {
                bytes[i] = 0;
                return;
            }
        bytes[MaxLength - 1] = 0;
    }
    public XrApiLayerName(string name) => Name = name;
    public XrApiLayerName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrApiLayerName value) => value.Name;
    public static implicit operator XrApiLayerName(string value) => new(value);
    public static implicit operator byte*(XrApiLayerName value) => value.Ptr;
    public static implicit operator XrApiLayerName(byte* value) => new(value);
    public static implicit operator XrApiLayerName(ReadOnlySpan<byte> value) => new(value);
    public static bool operator !=(XrApiLayerName lhs, XrApiLayerName rhs) => !(lhs == rhs);
    public static bool operator ==(XrApiLayerName lhs, XrApiLayerName rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrApiLayerName e && Equals(e);
    public readonly bool Equals(XrApiLayerName other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)
            hash = HashCode.Combine(hash, bytes[i]);
        return hash;
    }
}

public unsafe struct XrSystemName : IEquatable<XrSystemName>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_SYSTEM_NAME_SIZE;
    public fixed byte bytes[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public byte* Ptr
    {
        get
        {
            fixed(XrSystemName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;
            bytes[MaxLength - 1] = 0;
        }
    }
    public string Name
    {
        get
        {
            int i = 0;
            int byteCount = 0;
            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;
                byteCount++;

            fixed(byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, byteCount);
        }
        set
        {
            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)
                throw new InvalidOperationException("string was too large to fit inside of XrSystemName struct, which has a size of 256");
            fixed(byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrSystemName(ReadOnlySpan<byte> value)
    {
        if (value.Length >= MaxLength - 1)
            throw new InvalidOperationException("string was too large to fit inside of {structName} struct, which has a size of {constant.Value}");
        int i = 0;
        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)
            if(i == value.Length)
            {
                bytes[i] = 0;
                return;
            }
        bytes[MaxLength - 1] = 0;
    }
    public XrSystemName(string name) => Name = name;
    public XrSystemName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrSystemName value) => value.Name;
    public static implicit operator XrSystemName(string value) => new(value);
    public static implicit operator byte*(XrSystemName value) => value.Ptr;
    public static implicit operator XrSystemName(byte* value) => new(value);
    public static implicit operator XrSystemName(ReadOnlySpan<byte> value) => new(value);
    public static bool operator !=(XrSystemName lhs, XrSystemName rhs) => !(lhs == rhs);
    public static bool operator ==(XrSystemName lhs, XrSystemName rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrSystemName e && Equals(e);
    public readonly bool Equals(XrSystemName other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)
            hash = HashCode.Combine(hash, bytes[i]);
        return hash;
    }
}

public unsafe struct XrApplicationName : IEquatable<XrApplicationName>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_APPLICATION_NAME_SIZE;
    public fixed byte bytes[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public byte* Ptr
    {
        get
        {
            fixed(XrApplicationName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;
            bytes[MaxLength - 1] = 0;
        }
    }
    public string Name
    {
        get
        {
            int i = 0;
            int byteCount = 0;
            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;
                byteCount++;

            fixed(byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, byteCount);
        }
        set
        {
            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)
                throw new InvalidOperationException("string was too large to fit inside of XrApplicationName struct, which has a size of 128");
            fixed(byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrApplicationName(ReadOnlySpan<byte> value)
    {
        if (value.Length >= MaxLength - 1)
            throw new InvalidOperationException("string was too large to fit inside of {structName} struct, which has a size of {constant.Value}");
        int i = 0;
        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)
            if(i == value.Length)
            {
                bytes[i] = 0;
                return;
            }
        bytes[MaxLength - 1] = 0;
    }
    public XrApplicationName(string name) => Name = name;
    public XrApplicationName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrApplicationName value) => value.Name;
    public static implicit operator XrApplicationName(string value) => new(value);
    public static implicit operator byte*(XrApplicationName value) => value.Ptr;
    public static implicit operator XrApplicationName(byte* value) => new(value);
    public static implicit operator XrApplicationName(ReadOnlySpan<byte> value) => new(value);
    public static bool operator !=(XrApplicationName lhs, XrApplicationName rhs) => !(lhs == rhs);
    public static bool operator ==(XrApplicationName lhs, XrApplicationName rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrApplicationName e && Equals(e);
    public readonly bool Equals(XrApplicationName other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)
            hash = HashCode.Combine(hash, bytes[i]);
        return hash;
    }
}

public unsafe struct XrEngineName : IEquatable<XrEngineName>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_ENGINE_NAME_SIZE;
    public fixed byte bytes[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public byte* Ptr
    {
        get
        {
            fixed(XrEngineName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;
            bytes[MaxLength - 1] = 0;
        }
    }
    public string Name
    {
        get
        {
            int i = 0;
            int byteCount = 0;
            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;
                byteCount++;

            fixed(byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, byteCount);
        }
        set
        {
            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)
                throw new InvalidOperationException("string was too large to fit inside of XrEngineName struct, which has a size of 128");
            fixed(byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrEngineName(ReadOnlySpan<byte> value)
    {
        if (value.Length >= MaxLength - 1)
            throw new InvalidOperationException("string was too large to fit inside of {structName} struct, which has a size of {constant.Value}");
        int i = 0;
        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)
            if(i == value.Length)
            {
                bytes[i] = 0;
                return;
            }
        bytes[MaxLength - 1] = 0;
    }
    public XrEngineName(string name) => Name = name;
    public XrEngineName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrEngineName value) => value.Name;
    public static implicit operator XrEngineName(string value) => new(value);
    public static implicit operator byte*(XrEngineName value) => value.Ptr;
    public static implicit operator XrEngineName(byte* value) => new(value);
    public static implicit operator XrEngineName(ReadOnlySpan<byte> value) => new(value);
    public static bool operator !=(XrEngineName lhs, XrEngineName rhs) => !(lhs == rhs);
    public static bool operator ==(XrEngineName lhs, XrEngineName rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrEngineName e && Equals(e);
    public readonly bool Equals(XrEngineName other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)
            hash = HashCode.Combine(hash, bytes[i]);
        return hash;
    }
}

public unsafe struct XrRuntimeName : IEquatable<XrRuntimeName>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_RUNTIME_NAME_SIZE;
    public fixed byte bytes[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public byte* Ptr
    {
        get
        {
            fixed(XrRuntimeName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;
            bytes[MaxLength - 1] = 0;
        }
    }
    public string Name
    {
        get
        {
            int i = 0;
            int byteCount = 0;
            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;
                byteCount++;

            fixed(byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, byteCount);
        }
        set
        {
            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)
                throw new InvalidOperationException("string was too large to fit inside of XrRuntimeName struct, which has a size of 128");
            fixed(byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrRuntimeName(ReadOnlySpan<byte> value)
    {
        if (value.Length >= MaxLength - 1)
            throw new InvalidOperationException("string was too large to fit inside of {structName} struct, which has a size of {constant.Value}");
        int i = 0;
        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)
            if(i == value.Length)
            {
                bytes[i] = 0;
                return;
            }
        bytes[MaxLength - 1] = 0;
    }
    public XrRuntimeName(string name) => Name = name;
    public XrRuntimeName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrRuntimeName value) => value.Name;
    public static implicit operator XrRuntimeName(string value) => new(value);
    public static implicit operator byte*(XrRuntimeName value) => value.Ptr;
    public static implicit operator XrRuntimeName(byte* value) => new(value);
    public static implicit operator XrRuntimeName(ReadOnlySpan<byte> value) => new(value);
    public static bool operator !=(XrRuntimeName lhs, XrRuntimeName rhs) => !(lhs == rhs);
    public static bool operator ==(XrRuntimeName lhs, XrRuntimeName rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrRuntimeName e && Equals(e);
    public readonly bool Equals(XrRuntimeName other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)
            hash = HashCode.Combine(hash, bytes[i]);
        return hash;
    }
}

public unsafe struct XrStructureName : IEquatable<XrStructureName>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_STRUCTURE_NAME_SIZE;
    public fixed byte bytes[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public byte* Ptr
    {
        get
        {
            fixed(XrStructureName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;
            bytes[MaxLength - 1] = 0;
        }
    }
    public string Name
    {
        get
        {
            int i = 0;
            int byteCount = 0;
            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;
                byteCount++;

            fixed(byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, byteCount);
        }
        set
        {
            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)
                throw new InvalidOperationException("string was too large to fit inside of XrStructureName struct, which has a size of 64");
            fixed(byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrStructureName(ReadOnlySpan<byte> value)
    {
        if (value.Length >= MaxLength - 1)
            throw new InvalidOperationException("string was too large to fit inside of {structName} struct, which has a size of {constant.Value}");
        int i = 0;
        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)
            if(i == value.Length)
            {
                bytes[i] = 0;
                return;
            }
        bytes[MaxLength - 1] = 0;
    }
    public XrStructureName(string name) => Name = name;
    public XrStructureName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrStructureName value) => value.Name;
    public static implicit operator XrStructureName(string value) => new(value);
    public static implicit operator byte*(XrStructureName value) => value.Ptr;
    public static implicit operator XrStructureName(byte* value) => new(value);
    public static implicit operator XrStructureName(ReadOnlySpan<byte> value) => new(value);
    public static bool operator !=(XrStructureName lhs, XrStructureName rhs) => !(lhs == rhs);
    public static bool operator ==(XrStructureName lhs, XrStructureName rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrStructureName e && Equals(e);
    public readonly bool Equals(XrStructureName other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)
            hash = HashCode.Combine(hash, bytes[i]);
        return hash;
    }
}

public unsafe struct XrActionSetName : IEquatable<XrActionSetName>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_ACTION_SET_NAME_SIZE;
    public fixed byte bytes[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public byte* Ptr
    {
        get
        {
            fixed(XrActionSetName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;
            bytes[MaxLength - 1] = 0;
        }
    }
    public string Name
    {
        get
        {
            int i = 0;
            int byteCount = 0;
            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;
                byteCount++;

            fixed(byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, byteCount);
        }
        set
        {
            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)
                throw new InvalidOperationException("string was too large to fit inside of XrActionSetName struct, which has a size of 64");
            fixed(byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrActionSetName(ReadOnlySpan<byte> value)
    {
        if (value.Length >= MaxLength - 1)
            throw new InvalidOperationException("string was too large to fit inside of {structName} struct, which has a size of {constant.Value}");
        int i = 0;
        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)
            if(i == value.Length)
            {
                bytes[i] = 0;
                return;
            }
        bytes[MaxLength - 1] = 0;
    }
    public XrActionSetName(string name) => Name = name;
    public XrActionSetName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrActionSetName value) => value.Name;
    public static implicit operator XrActionSetName(string value) => new(value);
    public static implicit operator byte*(XrActionSetName value) => value.Ptr;
    public static implicit operator XrActionSetName(byte* value) => new(value);
    public static implicit operator XrActionSetName(ReadOnlySpan<byte> value) => new(value);
    public static bool operator !=(XrActionSetName lhs, XrActionSetName rhs) => !(lhs == rhs);
    public static bool operator ==(XrActionSetName lhs, XrActionSetName rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrActionSetName e && Equals(e);
    public readonly bool Equals(XrActionSetName other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)
            hash = HashCode.Combine(hash, bytes[i]);
        return hash;
    }
}

public unsafe struct XrActionName : IEquatable<XrActionName>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_ACTION_NAME_SIZE;
    public fixed byte bytes[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public byte* Ptr
    {
        get
        {
            fixed(XrActionName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;
            bytes[MaxLength - 1] = 0;
        }
    }
    public string Name
    {
        get
        {
            int i = 0;
            int byteCount = 0;
            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;
                byteCount++;

            fixed(byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, byteCount);
        }
        set
        {
            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)
                throw new InvalidOperationException("string was too large to fit inside of XrActionName struct, which has a size of 64");
            fixed(byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrActionName(ReadOnlySpan<byte> value)
    {
        if (value.Length >= MaxLength - 1)
            throw new InvalidOperationException("string was too large to fit inside of {structName} struct, which has a size of {constant.Value}");
        int i = 0;
        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)
            if(i == value.Length)
            {
                bytes[i] = 0;
                return;
            }
        bytes[MaxLength - 1] = 0;
    }
    public XrActionName(string name) => Name = name;
    public XrActionName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrActionName value) => value.Name;
    public static implicit operator XrActionName(string value) => new(value);
    public static implicit operator byte*(XrActionName value) => value.Ptr;
    public static implicit operator XrActionName(byte* value) => new(value);
    public static implicit operator XrActionName(ReadOnlySpan<byte> value) => new(value);
    public static bool operator !=(XrActionName lhs, XrActionName rhs) => !(lhs == rhs);
    public static bool operator ==(XrActionName lhs, XrActionName rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrActionName e && Equals(e);
    public readonly bool Equals(XrActionName other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)
            hash = HashCode.Combine(hash, bytes[i]);
        return hash;
    }
}

public unsafe struct XrLocalizedActionSetName : IEquatable<XrLocalizedActionSetName>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_LOCALIZED_ACTION_SET_NAME_SIZE;
    public fixed byte bytes[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public byte* Ptr
    {
        get
        {
            fixed(XrLocalizedActionSetName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;
            bytes[MaxLength - 1] = 0;
        }
    }
    public string Name
    {
        get
        {
            int i = 0;
            int byteCount = 0;
            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;
                byteCount++;

            fixed(byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, byteCount);
        }
        set
        {
            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)
                throw new InvalidOperationException("string was too large to fit inside of XrLocalizedActionSetName struct, which has a size of 128");
            fixed(byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrLocalizedActionSetName(ReadOnlySpan<byte> value)
    {
        if (value.Length >= MaxLength - 1)
            throw new InvalidOperationException("string was too large to fit inside of {structName} struct, which has a size of {constant.Value}");
        int i = 0;
        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)
            if(i == value.Length)
            {
                bytes[i] = 0;
                return;
            }
        bytes[MaxLength - 1] = 0;
    }
    public XrLocalizedActionSetName(string name) => Name = name;
    public XrLocalizedActionSetName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrLocalizedActionSetName value) => value.Name;
    public static implicit operator XrLocalizedActionSetName(string value) => new(value);
    public static implicit operator byte*(XrLocalizedActionSetName value) => value.Ptr;
    public static implicit operator XrLocalizedActionSetName(byte* value) => new(value);
    public static implicit operator XrLocalizedActionSetName(ReadOnlySpan<byte> value) => new(value);
    public static bool operator !=(XrLocalizedActionSetName lhs, XrLocalizedActionSetName rhs) => !(lhs == rhs);
    public static bool operator ==(XrLocalizedActionSetName lhs, XrLocalizedActionSetName rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrLocalizedActionSetName e && Equals(e);
    public readonly bool Equals(XrLocalizedActionSetName other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)
            hash = HashCode.Combine(hash, bytes[i]);
        return hash;
    }
}

public unsafe struct XrLocalizedActionName : IEquatable<XrLocalizedActionName>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_LOCALIZED_ACTION_NAME_SIZE;
    public fixed byte bytes[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public byte* Ptr
    {
        get
        {
            fixed(XrLocalizedActionName* ptr = &this)
                return (byte*)ptr;
        }
        set
        {
            int i = 0;
            while(i < MaxLength && (bytes[i] = value[i++]) != 0) ;
            bytes[MaxLength - 1] = 0;
        }
    }
    public string Name
    {
        get
        {
            int i = 0;
            int byteCount = 0;
            while(i < MaxLength && (bytes[i] = bytes[i++]) != 0) ;
                byteCount++;

            fixed(byte* ptr = bytes)
                return Encoding.UTF8.GetString(ptr, byteCount);
        }
        set
        {
            if(Encoding.UTF8.GetByteCount(value) >= MaxLength - 1)
                throw new InvalidOperationException("string was too large to fit inside of XrLocalizedActionName struct, which has a size of 128");
            fixed(byte* ptr = bytes)
                bytes[Encoding.UTF8.GetBytes(value.AsSpan(), new Span<byte>(ptr, MaxLength - 1)) + 1] = 0;
        }
    }
    public XrLocalizedActionName(ReadOnlySpan<byte> value)
    {
        if (value.Length >= MaxLength - 1)
            throw new InvalidOperationException("string was too large to fit inside of {structName} struct, which has a size of {constant.Value}");
        int i = 0;
        while (i < MaxLength - 1 && (bytes[i] = value[i++]) != 0)
            if(i == value.Length)
            {
                bytes[i] = 0;
                return;
            }
        bytes[MaxLength - 1] = 0;
    }
    public XrLocalizedActionName(string name) => Name = name;
    public XrLocalizedActionName(byte* ptr) => Ptr = ptr;
    public static implicit operator string(XrLocalizedActionName value) => value.Name;
    public static implicit operator XrLocalizedActionName(string value) => new(value);
    public static implicit operator byte*(XrLocalizedActionName value) => value.Ptr;
    public static implicit operator XrLocalizedActionName(byte* value) => new(value);
    public static implicit operator XrLocalizedActionName(ReadOnlySpan<byte> value) => new(value);
    public static bool operator !=(XrLocalizedActionName lhs, XrLocalizedActionName rhs) => !(lhs == rhs);
    public static bool operator ==(XrLocalizedActionName lhs, XrLocalizedActionName rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.bytes[i] != rhs.bytes[i])
                return false;
            if(lhs.bytes[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrLocalizedActionName e && Equals(e);
    public readonly bool Equals(XrLocalizedActionName other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && bytes[i] != 0; i++)
            hash = HashCode.Combine(hash, bytes[i]);
        return hash;
    }
}