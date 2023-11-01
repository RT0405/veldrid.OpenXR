using Veldrid.OpenXR.Native;

namespace Veldrid.OpenXR;
public readonly struct XrSessionInfo
{
    public readonly XrInstance Instance;
    public readonly ulong SystemID;
    public readonly XrSession Session;
}