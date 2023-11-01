namespace Veldrid.OpenXR.Native;

using static Evergine.Bindings.OpenXR.OperatingSystemHelper;
using NativeLib = Evergine.Bindings.OpenXR.NativeLibrary;
public unsafe partial class OpenXRNativeInstance : IDisposable
{
    public bool IsDisposed { get; private set; }
    private readonly NativeLib nativeLib;
    public readonly ReadOnlyMemory<XrExtensionName> EnabledExtensions;
    public readonly ReadOnlyMemory<XrApiLayerName> EnabledApiLayers;

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
        if(disposing && !IsDisposed)
            nativeLib.Dispose();
        IsDisposed = true;
    }
    internal OpenXRNativeInstance(XrInstance instance, XrInstanceCreateInfo createInfo)
    {
        nativeLib = LoadNativeLibrary();
        LoadFunctionPointers(instance);
        XrExtensionName[] enabledExtensions = new XrExtensionName[createInfo.enabledExtensionCount];
        for(int i = 0; i < createInfo.enabledExtensionCount; i++)
            enabledExtensions[i] = createInfo.enabledExtensionNames[i];
        EnabledExtensions = enabledExtensions;
        XrApiLayerName[] enabledApiLayers = new XrApiLayerName[createInfo.enabledExtensionCount];
        for(int i = 0; i < createInfo.enabledApiLayerCount; i++)
            enabledApiLayers[i] = createInfo.enabledApiLayerNames[i];
        EnabledApiLayers = enabledApiLayers;
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