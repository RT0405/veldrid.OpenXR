using System.Runtime.CompilerServices;

[assembly: DisableRuntimeMarshalling]

namespace Veldrid.OpenXR.Native;
public unsafe partial class OpenXRNativeInstance
{
    public bool IsDisposed { get; private set; }
    public readonly XrInstance XrInstance;
    public ReadOnlyMemory<XrExtensionName> EnabledExtensions => enabledExtensions;
    private readonly XrExtensionName[] enabledExtensions;
    public ReadOnlyMemory<XrApiLayerName> EnabledApiLayers => enabledApiLayers;
    private readonly XrApiLayerName[] enabledApiLayers;

    private readonly HashSet<XrExtensionName> enabledExtensionsHashSet;
    internal OpenXRNativeInstance(XrInstance instance, XrInstanceCreateInfo createInfo)
    {
        XrInstance = instance;

        enabledExtensions = new XrExtensionName[createInfo.enabledExtensionCount];
        for (int i = 0; i < createInfo.enabledExtensionCount; i++)
            enabledExtensions[i] = createInfo.enabledExtensionNames[i];
        enabledApiLayers = new XrApiLayerName[createInfo.enabledApiLayerCount];
        for (int i = 0; i < createInfo.enabledApiLayerCount; i++)
            enabledApiLayers[i] = createInfo.enabledApiLayerNames[i];

        enabledExtensionsHashSet = new HashSet<XrExtensionName>(enabledExtensions);

        LoadFunctionPointers();
    }
    [SkipLocalsInit]//to skip the extemely low overhead of setting all the bytes of the name buffer twice, which would only happen when the game loads anyways
    private void* GetFunctionPointer(ReadOnlySpan<byte> name)
    {
        byte* bytes = stackalloc byte[name.Length + 1];//stackalloc new buffer in order to get byte* as well as add null char
        name.CopyTo(new Span<byte>(bytes, name.Length));//copy old bytes over
        bytes[name.Length] = 0;//append null char

        void* funcPtr;
        if (xrGetInstanceProcAddr(XrInstance, bytes, &funcPtr).Failed())
            return null;
        return funcPtr;
    }
    public bool HasExtensionEnabled(ReadOnlySpan<byte> name)
    {
        return enabledExtensionsHashSet.Contains(name);
    }
}