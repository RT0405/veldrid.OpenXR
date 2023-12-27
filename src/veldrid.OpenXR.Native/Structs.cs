using System.Numerics;
using System.Runtime.CompilerServices;

namespace Veldrid.OpenXR.Native;
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