using Evergine.Bindings.OpenXR;
using static Evergine.Bindings.OpenXR.OperatingSystemHelper;
using CC = System.Runtime.InteropServices.CallingConvention;

namespace Veldrid.OpenXR.Native;
public static unsafe partial class OpenXRNative
{
    internal const CC CallConv = CC.StdCall;
    private const string LoaderName = "openxr_loader";

    public static OpenXRNativeInstance Instance;
}