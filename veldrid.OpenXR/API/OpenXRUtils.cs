using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Veldrid.OpenXR.Native;
using Vulkan;

namespace Veldrid.OpenXR;
public static class OpenXRUtils
{
    private static T[] Populate<T>(this T[] arr, T value)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = value;
        return arr;
    }
    /// <summary> Create a <see cref="XrInstance"/> with the given extensions </summary>
    /// <returns>
    /// <see cref="XrResult.XR_SUCCESS"/> if instance creation was successful <br/>
    /// <see cref="XrResult.XR_ERROR_EXTENSION_NOT_PRESENT"/> if any of the <paramref name="requiredExtensions"/> were unavailable
    /// </returns>
    public static unsafe XrResult CreateXRInstance(ReadOnlySpan<string> requiredExtensions, out XrInstance instance) => CreateXRInstance(requiredExtensions, out instance, "Veldrid OpenXR Application", 0, "Veldrid", 0);
    /// <summary> Create a <see cref="XrInstance"/> with the given extensions </summary>
    /// <returns>
    /// <see cref="XrResult.XR_SUCCESS"/> if instance creation was successful <br/>
    /// <see cref="XrResult.XR_ERROR_EXTENSION_NOT_PRESENT"/> if any of the <paramref name="requiredExtensions"/> were unavailable
    /// <see cref="XrResult.XR_ERROR_NAME_INVALID"/> if either <paramref name="appName"/> or <paramref name="engineName"/> is too long or have unsupported characters
    /// </returns>
    public static unsafe XrResult CreateXRInstance(ReadOnlySpan<string> requiredExtensions, out XrInstance instance, string appName, uint appVersion, string engineName, uint engineVersion)
    {
        instance = default;
        if (Encoding.UTF8.GetByteCount(appName) >= OpenXRNative.XR_MAX_APPLICATION_NAME_SIZE) return XrResult.XR_ERROR_NAME_INVALID;
        if (Encoding.UTF8.GetByteCount(engineName) >= OpenXRNative.XR_MAX_ENGINE_NAME_SIZE) return XrResult.XR_ERROR_NAME_INVALID;


        uint extCount = 0;
        XrResult r = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, 0, &extCount, null);
        if (r != XrResult.XR_SUCCESS) return r;

        XrExtensionProperties[] xrExts = new XrExtensionProperties[extCount].Populate(new() { type = XrStructureType.XR_TYPE_EXTENSION_PROPERTIES });

        byte** enabledExtensionNames = (byte**)Marshal.AllocHGlobal(sizeof(byte*) * requiredExtensions.Length);
        using autoMarshalDispose ad0 = new((IntPtr)enabledExtensionNames);

        fixed (XrExtensionProperties* ptr = xrExts)
        {
            r = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, extCount, &extCount, ptr);
            if (r != XrResult.XR_SUCCESS) return r;
            for (int i = 0; i < requiredExtensions.Length; i++)
            {
                bool contains = false;
                for (int n = 0; n < xrExts.Length; n++)
                {
                    if (Marshal.PtrToStringUTF8((IntPtr)ptr[n].extensionName) == requiredExtensions[i])
                    {
                        contains = true;
                        enabledExtensionNames[i] = ptr[n].extensionName;
                        break;
                    }
                }
                if (!contains)
                    return XrResult.XR_ERROR_EXTENSION_NOT_PRESENT;
            }
        }

        XrInstanceCreateInfo instanceCreateInfo = new()
        {
            type = XrStructureType.XR_TYPE_INSTANCE_CREATE_INFO,
            applicationInfo = new()
            {
                apiVersion = new XRVersion(1, 0, 30),
                applicationVersion = appVersion,
                engineVersion = engineVersion,
            },
            createFlags = (ulong)XrInstanceCreateFlags.None,
            enabledExtensionCount = (uint)requiredExtensions.Length,
            enabledExtensionNames = enabledExtensionNames,
            
        };

        OpenXRNative.StringToUTF8NullTerminated(appName, new Span<byte>(instanceCreateInfo.applicationInfo.applicationName, (int)OpenXRNative.XR_MAX_APPLICATION_NAME_SIZE));
        OpenXRNative.StringToUTF8NullTerminated(engineName, new Span<byte>(instanceCreateInfo.applicationInfo.engineName, (int)OpenXRNative.XR_MAX_ENGINE_NAME_SIZE));

        fixed (XrInstance* instancePtr = &instance)
            r = OpenXRNative.xrCreateInstance(&instanceCreateInfo, instancePtr);

        return r;
    }
    private struct autoMarshalDispose : IDisposable
    {
        public IntPtr ptr;
        public autoMarshalDispose (IntPtr intPtr)
        {
            ptr = intPtr;
        }
        public void Dispose()
        {
            if(ptr != IntPtr.Zero)
                Marshal.FreeHGlobal(ptr);
            ptr = IntPtr.Zero;
        }
    }
    /// <summary> gets the available OpenXR extensions. Consider using <see cref="GetAvailableExtensions(out XRExtensionDescriptor[])"/> which uses more a .net-like syntax datatype </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_UNAVAILABLE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_API_LAYER_NOT_PRESENT"/>
    /// </returns>
    public static unsafe XrResult GetAvailableExtensions(out XrExtensionProperties[] availableExtensions)
    {
        availableExtensions = null;
        uint extCount = 0;
        XrResult r = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, 0, &extCount, null);
        if (r != XrResult.XR_SUCCESS) return r;

        availableExtensions = new XrExtensionProperties[extCount].Populate(new() { type = XrStructureType.XR_TYPE_EXTENSION_PROPERTIES });
        fixed (XrExtensionProperties* ptr = availableExtensions)
            r = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, extCount, &extCount, ptr);
        return r;
    }
    /// <summary> gets the available OpenXR extensions </summary>
    /// <param name="availableExtensions"></param>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_UNAVAILABLE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_API_LAYER_NOT_PRESENT"/>
    /// </returns>
    public static unsafe XrResult GetAvailableExtensions(out XRExtensionDescriptor[] availableExtensions)
    {
        availableExtensions = null;
        uint extCount = 0;
        XrResult r = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, 0, &extCount, null);
        if (r != XrResult.XR_SUCCESS) return r;

        XrExtensionProperties[] xrExts = new XrExtensionProperties[extCount].Populate(new() { type = XrStructureType.XR_TYPE_EXTENSION_PROPERTIES });
        fixed (XrExtensionProperties* ptr = xrExts)
            r = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, extCount, &extCount, ptr);
        availableExtensions = new XRExtensionDescriptor[xrExts.Length];
        for (int i = 0; i < availableExtensions.Length; i++)
            availableExtensions[i] = (XRExtensionDescriptor)xrExts[i];
        return r;
    }
}