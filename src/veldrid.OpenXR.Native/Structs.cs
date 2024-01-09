using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Veldrid.OpenXR.Native;
#pragma warning disable IDE0290 // Use primary constructor
public partial struct XrPosef
{
    public static XrPosef Identity => new(XrQuaternionf.Identity, XrVector3f.Identity);
    public XrPosef(XrQuaternionf orientation, XrVector3f position)
    {
        this.orientation = orientation;
        this.position = position;
    }
}
public partial struct XrQuaternionf
{
    public static XrQuaternionf Identity => new(0, 0, 0, 1);
    public XrQuaternionf(float x, float y, float z, float w)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;
    }
    public static implicit operator XrQuaternionf(Quaternion q) => Unsafe.BitCast<Quaternion, XrQuaternionf>(q);
    public static implicit operator Quaternion(XrQuaternionf q) => Unsafe.BitCast<XrQuaternionf, Quaternion>(q);
}
public partial struct XrVector3f
{
    public static XrVector3f Identity => new();
    public XrVector3f(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public static implicit operator XrVector3f(Vector3 v) => Unsafe.BitCast<Vector3, XrVector3f>(v);
    public static implicit operator Vector3(XrVector3f v) => Unsafe.BitCast<XrVector3f, Vector3>(v);
}
#pragma warning restore IDE0290 // Use primary constructor

public unsafe struct XrOculusAudioDeviceGuid : IEquatable<XrOculusAudioDeviceGuid>
{
    public const int MaxLength = (int)OpenXRNative.XR_MAX_AUDIO_DEVICE_STR_SIZE_OCULUS;
    public fixed uint data[MaxLength];
    /// <summary> Only use when you know for sure that the struct is pinned (such as being on the stack and not in an object).<br/>In all other cases pin it manually using the fixed keyword. </summary>
    public void* Ptr
    {
        get
        {
            fixed(XrOculusAudioDeviceGuid* ptr = &this)
                return (byte*)ptr;
        }
        set => this = *(XrOculusAudioDeviceGuid*)value;
    }
    public XrOculusAudioDeviceGuid(void* ptr) => Ptr = ptr;
    public static implicit operator void*(XrOculusAudioDeviceGuid value) => value.Ptr;
    public static implicit operator XrOculusAudioDeviceGuid(void* value) => new(value);
    public static bool operator !=(XrOculusAudioDeviceGuid lhs, XrOculusAudioDeviceGuid rhs) => !(lhs == rhs);
    public static bool operator ==(XrOculusAudioDeviceGuid lhs, XrOculusAudioDeviceGuid rhs)
    {
        for(int i = 0; i < MaxLength; i++)
        {
            if(lhs.data[i] != rhs.data[i])
                return false;
            if(lhs.data[i] == 0)
                return true;
        }
        return false;
    }
    public readonly override bool Equals(object obj) => obj is XrOculusAudioDeviceGuid e && Equals(e);
    public readonly bool Equals(XrOculusAudioDeviceGuid other) => this == other;
    public override int GetHashCode() // I'm fully aware of how slow/inefficient this might be
    {
        int hash = 0;
        for(int i = 0; i < MaxLength && data[i] != 0; i++)
            hash = HashCode.Combine(hash, data[i]);
        return hash;
    }
}