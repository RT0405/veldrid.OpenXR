namespace Veldrid.OpenXR.Native;

using static Evergine.Bindings.OpenXR.OperatingSystemHelper;
using NativeLib = Evergine.Bindings.OpenXR.NativeLibrary;
public unsafe partial class OpenXRNativeInstance : IDisposable
{
    public bool IsDisposed { get; private set; }
    private readonly NativeLib nativeLib;
    ~OpenXRNativeInstance()
    {
        Dispose(false);
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    private void Dispose(bool disposing)
    {
        if(!IsDisposed)
            nativeLib.Dispose();
        IsDisposed = true;
    }
    internal OpenXRNativeInstance(XrInstanceCreateInfo createInfo, XrInstance instance)
    {
        nativeLib = LoadNativeLibrary();
        LoadFunctionPointers(instance);
    }
    private static NativeLib LoadNativeLibrary()
    {
        return NativeLib.Load(GetOpenXRName());
    }
    private static string GetOpenXRName()
    {
        if (IsOSPlatform(PlatformType.Windows))
        {
            return "openxr_loader.dll";
        }
        else if (IsOSPlatform(PlatformType.Android))
        {
            // Android
            return "libopenxr_loader.so";
        }
        else if (IsOSPlatform(PlatformType.Linux))
        {
            // Desktop Linux
            return "libopenxr_loader.so.1";
        }
        else
        {
            throw new PlatformNotSupportedException();
        }
    }
}