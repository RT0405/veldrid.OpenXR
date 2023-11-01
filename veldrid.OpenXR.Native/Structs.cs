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
}