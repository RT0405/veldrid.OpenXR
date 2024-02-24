using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Veldrid.OpenXR.Native;
[StructLayout(LayoutKind.Explicit)]
public struct XRVersion
{
    [FieldOffset(0)] public ulong RawValue;
    [FieldOffset(6)] public ushort Major;
    [FieldOffset(4)] public ushort Minor;
    [FieldOffset(0)] public uint Patch;
    public XRVersion(ulong raw)
    {
        Unsafe.SkipInit(out this);
        RawValue = raw;
    }
    public XRVersion(ushort major, ushort minor, uint patch)
    {
        Unsafe.SkipInit(out this);
        Major = major;
        Minor = minor;
        Patch = patch;
    }
    public static explicit operator XRVersion(ulong raw) => Unsafe.As<ulong, XRVersion>(ref raw);
    public static implicit operator ulong(XRVersion raw) => Unsafe.As<XRVersion, ulong>(ref raw);
}