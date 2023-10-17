using Veldrid.OpenXR.Native;

namespace Veldrid.OpenXR;
public class XRInstance : IDisposable
{
    public bool IsDisposed { get; private set; }
    public readonly OpenXRNativeInstance LibraryInstance;
    public readonly XrInstance Instance;
    private readonly XrExtensionName[] enabledExtensions;
    public readonly ReadOnlyMemory<XrExtensionName> EnabledExtensions;
    private readonly XrApiLayerName[] enabledApiLayers;
    public readonly ReadOnlyMemory<XrApiLayerName> EnabledApiLayers;
    public unsafe XRInstance(OpenXRNativeInstance libraryInstance, XrInstanceCreateInfo createInfo, XrInstance instance)
    {
        LibraryInstance = libraryInstance;
        Instance = instance;

        if (createInfo.enabledExtensionCount != 0)
        {
            enabledExtensions = new XrExtensionName[createInfo.enabledExtensionCount];
            for (int i = 0; i < enabledExtensions.Length; i++)
                enabledExtensions[i] = createInfo.enabledExtensionNames[i];
            EnabledExtensions = enabledExtensions;
        }
        if(createInfo.enabledApiLayerCount != 0)
        {
            enabledApiLayers = new XrApiLayerName[createInfo.enabledApiLayerCount];
            for (int i = 0; i < enabledApiLayers.Length; i++)
                enabledApiLayers[i] = createInfo.enabledApiLayerNames[i];
            EnabledApiLayers = enabledApiLayers;
        }
    }
    ~XRInstance() => Dispose(false);
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    private void Dispose(bool disposing)
    {
        if (!IsDisposed)
        {
            LibraryInstance.Dispose();
            OpenXRNative.xrDestroyInstance(Instance);
            IsDisposed = true;
        }
    }
}