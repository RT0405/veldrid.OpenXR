using System.Text;
using Veldrid.OpenXR.Native;

namespace Veldrid.OpenXR;
public static partial class OpenXRUtils
{
    internal static unsafe string GetString(byte* stringStart)
    {
        int characters = 0;
        while (stringStart[characters] != 0)
        {
            characters++;
        }

        return Encoding.UTF8.GetString(stringStart, characters);
    }
    internal static T[] Populate<T>(this T[] array, T value)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = value;
        return array;
    }
    internal static unsafe T* Populate<T>(T* buffer, uint length, T value) where T : unmanaged => Populate(buffer, (int)length, value);
    internal static unsafe T* Populate<T>(this Span<T> buffer, uint length, T value) where T : unmanaged => Populate(buffer, (int)length, value);
    internal static unsafe T* Populate<T>(this Span<T> buffer, T value) where T : unmanaged => Populate(buffer, buffer.Length, value);
    internal static unsafe T* Populate<T>(T* buffer, int length, T value) where T : unmanaged
    {
        for (int i = 0; i < length; i++)
            buffer[i] = value;
        return buffer;
    }
    internal static unsafe T* Populate<T>(this Span<T> buffer, int length, T value) where T : unmanaged
    {
        for (int i = 0; i < length; i++)
            buffer[i] = value;
        fixed (T* ptr = buffer)
            return ptr;
    }
    public static Exception NewInvalidBackendException(string error, GraphicsBackend backend) => throw backend switch
    {
        GraphicsBackend.OpenGL or GraphicsBackend.OpenGLES => new NotImplementedException($"{error}, {backend} support has not yet been added to Veldrid.OpenXR"),
        GraphicsBackend.Metal => new InvalidOperationException($"{error}, OpenXR does not support Metal"),
        _ => new InvalidOperationException($"{error}, unknown GraphicsBackend: {backend}"),
    };
    private static XRExtensionDescriptor[] availableExtensions;
    public static unsafe ReadOnlyMemory<XRExtensionDescriptor> AvailableExtensions
    {
        get
        {
            if (availableExtensions == null)
            {
                uint extCount;
                XrResult result = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, 0, &extCount, null);
                if (result != XrResult.XR_SUCCESS)
                    return null;

                XrExtensionProperties[] xrExtensionProperties = new XrExtensionProperties[extCount].Populate(new XrExtensionProperties() { type = XrStructureType.XR_TYPE_EXTENSION_PROPERTIES });
                fixed (XrExtensionProperties* ptr = xrExtensionProperties)
                    result = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, extCount, &extCount, ptr);
                if (result != XrResult.XR_SUCCESS)
                    return null;
                availableExtensions = new XRExtensionDescriptor[extCount];
                for (int i = 0; i < extCount; i++)
                    availableExtensions[i] = (XRExtensionDescriptor)xrExtensionProperties[i];
            }
            return availableExtensions;
        }
    }
    public static bool IsBackendSupported(GraphicsBackend backend)
    {
        switch (backend)
        {
            case GraphicsBackend.Direct3D11:
                {
                    ReadOnlySpan<XRExtensionDescriptor> availableExtensions = AvailableExtensions.Span;
                    for (int i = 0; i < availableExtensions.Length; i++)
                    {
                        if (availableExtensions[i].ExtensionName == XRExtensionDescriptor.XR_KHR_D3D11_ENABLE.ExtensionName)
                            return true;
                    }
                }
                return false;
            case GraphicsBackend.Vulkan:
                {
                    bool enable = false, enable2 = false;
                    ReadOnlySpan<XRExtensionDescriptor> availableExtensions = AvailableExtensions.Span;
                    for (int i = 0; i < availableExtensions.Length; i++)
                    {
                        if (availableExtensions[i].ExtensionName == XRExtensionDescriptor.XR_KHR_VULKAN_ENABLE.ExtensionName)
                            enable = true;
                        if (availableExtensions[i].ExtensionName == XRExtensionDescriptor.XR_KHR_VULKAN_ENABLE2.ExtensionName)
                            enable2 = true;
                    }
                    return enable && enable2;
                }
            default:
                return false;
        }
    }
}