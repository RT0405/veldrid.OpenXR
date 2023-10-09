using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Veldrid.OpenXR.Native;
using Vulkan;
using static Veldrid.OpenXR.Utils;

//https://github.com/maluoi/OpenXRSamples/blob/master/SingleFileExample/main.cpp is a very good single-file example of openxr, and this code wa written along with it

namespace Veldrid.OpenXR;
public static partial class OpenXRUtils
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
    public static unsafe XrResult CreateXRSession(XrInstance instance, GraphicsDevice graphicsDevice, XrFormFactor formFactor, out ulong systemID, out XrSession session)
    {
        XrSystemGetInfo systemGetInfo = new()
        {
            type = XrStructureType.XR_TYPE_SYSTEM_GET_INFO,
            next = null,
            formFactor = formFactor,
        };

        XrResult r;
        Unsafe.SkipInit(out systemID);
        fixed (ulong* ptr = &systemID)
            r = OpenXRNative.xrGetSystem(instance, &systemGetInfo, ptr);
        if (r != XrResult.XR_SUCCESS)
        {
            session = default;
            return r;
        }
        return CreateXRSession(instance, graphicsDevice, systemID, out session);
    }
    public static unsafe XrResult CreateXRSession(XrInstance instance, GraphicsDevice graphicsDevice, ulong systemID, out XrSession session)
    {
        XrGraphicsBindingFromGraphicsDevice(graphicsDevice, out void* bindingPtr, out DisposeCallback ptrDisposer);
        using DisposeCallback d = ptrDisposer; // will call dispose once it leaves this method no matter what happens
        XrSessionCreateInfo sessionCreateInfo = new()
        {
            type = XrStructureType.XR_TYPE_SESSION_CREATE_INFO,
            next = bindingPtr,
            createFlags = (ulong)XrSessionCreateFlags.None,
            systemId = systemID,
        };

        Unsafe.SkipInit(out session);
        fixed (XrSession* ptr = &session)
            return OpenXRNative.xrCreateSession(instance, &sessionCreateInfo, ptr);
    }
    public static unsafe bool XrGraphicsBindingFromGraphicsDevice(GraphicsDevice graphicsDevice, out void* bindingPtr, out IDisposable ptrDisposer) => XrGraphicsBindingFromGraphicsDevice(graphicsDevice, out bindingPtr, out ptrDisposer);
    internal static unsafe bool XrGraphicsBindingFromGraphicsDevice(GraphicsDevice graphicsDevice, out void* bindingPtr, out DisposeCallback ptrDisposer)
    {
        switch (graphicsDevice.BackendType)
        {
            case GraphicsBackend.Direct3D11:
                {
                    BackendInfoD3D11 backendInfoD3D11 = graphicsDevice.GetD3D11Info();
                    XrGraphicsBindingD3D11KHR binding = new()
                    {
                        type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_D3D11_KHR,
                        next = null,
                        device = backendInfoD3D11.Device
                    };
                    void* ptr = NativeMemory.Alloc((nuint)sizeof(XrGraphicsBindingD3D11KHR));
                    *(XrGraphicsBindingD3D11KHR*)ptr = binding;
                    ptrDisposer = new DisposeCallback(() => { NativeMemory.Free(ptr); });
                    bindingPtr = ptr;
                    return true;
                }
            case GraphicsBackend.Vulkan:
                {
                    BackendInfoVulkan backendInfoVulkan = graphicsDevice.GetVulkanInfo();
                    VkInstance vkInstance = backendInfoVulkan.Instance;
                    XrGraphicsBindingVulkanKHR binding = new()
                    {
                        type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR,
                        next = null,
                        device = backendInfoVulkan.Device,
                        instance = backendInfoVulkan.Instance,
                        physicalDevice = backendInfoVulkan.PhysicalDevice,
                        queueFamilyIndex = backendInfoVulkan.GraphicsQueueFamilyIndex,
                        queueIndex = 0,// don't know if this is correct, but looking at https://github.com/tdbe/openxr-vulkan-project-fundamentals/blob/d4d3d9ccf70b2c3b685c4eea4df4f755c59c29bf/src/Headset.cpp#L120 that's what they did... so idk
                    };
                    void* ptr = NativeMemory.Alloc((nuint)sizeof(XrGraphicsBindingVulkanKHR));
                    *(XrGraphicsBindingVulkanKHR*)ptr = binding;
                    ptrDisposer = new DisposeCallback(() => { NativeMemory.Free(ptr); });
                    bindingPtr = ptr;
                    return true;
                }
            case GraphicsBackend.OpenGL: throw new NotImplementedException("Creating an xr graphics binding from a GraphicsDevice for OpenGL is not implemented");
            case GraphicsBackend.OpenGLES: throw new NotImplementedException("Creating an xr graphics binding from a GraphicsDevice for OpenGLES is not implemented");
            case GraphicsBackend.Metal: throw new PlatformNotSupportedException("Cannot create an openxr isntance with metal backend");
            default: throw new InvalidOperationException("invalid graphics backend type");
        }
    }
    /// <summary> returns whether the given GraphicsBackend is supported by the current OpenXR Runtime </summary>
    public static bool IsGraphicsBackendSupported(GraphicsBackend backend)
    {
        if (backend == GraphicsBackend.Direct3D11)
            return Check(XRExtensionDescriptor.XR_KHR_D3D11_ENABLE);
        if (backend == GraphicsBackend.Vulkan)
            return Check(XRExtensionDescriptor.XR_KHR_VULKAN_ENABLE2);
        return false;

        static bool Check(string extension)
        {
            GetAvailableExtensions(out XRExtensionDescriptor[] availableExtensions);
            for (int i = 0; i < availableExtensions.Length; i++)
                if (availableExtensions[i].ExtensionName == extension)
                    return true;
            return false;
        }
    }
    /// <summary> returns whether the given GraphicsBackend is supported by this version of Velrid.OpenXR </summary>
    public static bool IsValidOpenXRGraphicsBackend(GraphicsBackend backend) => backend is GraphicsBackend.Direct3D11 or GraphicsBackend.Vulkan;
    public static unsafe void PollXREvents(XrInstance instance, Action<XrEventDataBuffer> perEventCallback)
    {
        XrEventDataBuffer eventBuffer = new() { type = XrStructureType.XR_TYPE_EVENT_DATA_BUFFER };
        while(OpenXRNative.xrPollEvent(instance, &eventBuffer) == XrResult.XR_SUCCESS)
        {
            perEventCallback?.Invoke(eventBuffer);
            eventBuffer.type = XrStructureType.XR_TYPE_EVENT_DATA_BUFFER;
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
        XrResult r;
        if ((r = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, 0, &extCount, null)) != XrResult.XR_SUCCESS) return r;

        availableExtensions = new XrExtensionProperties[extCount].Populate(new() { type = XrStructureType.XR_TYPE_EXTENSION_PROPERTIES });
        fixed (XrExtensionProperties* ptr = availableExtensions)
            return OpenXRNative.xrEnumerateInstanceExtensionProperties(null, extCount, &extCount, ptr);
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
    /// <summary> get the number of available OpenXR extensions </summary>
    public static unsafe XrResult GetExtensionCount(out uint extensionCount)
    {
        fixed (uint* ptr = &extensionCount)
            return OpenXRNative.xrEnumerateInstanceExtensionProperties(null, 0, ptr, null);
    }
    public static unsafe XrResult CreateReferenceSpace(XrSession session, XrReferenceSpaceType referenceSpaceType, out XrSpace space)
    {
        return CreateReferenceSpace(session, Quaternion.Identity, Vector3.Zero, referenceSpaceType, out space);
    }
    public static unsafe XrResult CreateReferenceSpace(XrSession session, Quaternion rotation, Vector3 position, XrReferenceSpaceType referenceSpaceType, out XrSpace space)
    {
        return CreateReferenceSpace(session, new() { orientation = Unsafe.As<Quaternion, XrQuaternionf>(ref rotation), position = Unsafe.As<Vector3, XrVector3f>(ref position) }, referenceSpaceType, out space);
    }
    public static unsafe XrResult CreateReferenceSpace(XrSession session, XrPosef pose, XrReferenceSpaceType referenceSpaceType, out XrSpace space)
    {
        XrReferenceSpaceCreateInfo info = new()
        {
            type = XrStructureType.XR_TYPE_REFERENCE_SPACE_CREATE_INFO,
            next = null,
            poseInReferenceSpace = pose,
            referenceSpaceType = referenceSpaceType,
        };
        Unsafe.SkipInit(out space);
        fixed (XrSpace* ptr = &space)
            return OpenXRNative.xrCreateReferenceSpace(session, &info, ptr);
    }
    public static unsafe XrResult GetViewconfigurations(XrInstance instance, ulong systemID, out XrViewConfigurationType[] configViews)
    {
        uint viewCount = 0;
        configViews = null;
        XrResult r = OpenXRNative.xrEnumerateViewConfigurations(instance, systemID, 0, &viewCount, null);
        if (r != XrResult.XR_SUCCESS) return r;
        configViews = new XrViewConfigurationType[viewCount];
        fixed (XrViewConfigurationType* configViewsPtr = configViews)
            return OpenXRNative.xrEnumerateViewConfigurations(instance, systemID, viewCount, &viewCount, configViewsPtr);
    }
    public static unsafe XrResult GetViewconfigurationViews(XrInstance instance, ulong systemID, XrViewConfigurationType configView, out XrViewConfigurationView[] configViews)
    {
        uint viewCount = 0;
        configViews = null;
        XrResult r = OpenXRNative.xrEnumerateViewConfigurationViews(instance, systemID, configView, 0, &viewCount, null);
        if (r != XrResult.XR_SUCCESS) return r;
        configViews = new XrViewConfigurationView[viewCount].Populate(new() { type = XrStructureType.XR_TYPE_VIEW_CONFIGURATION_VIEW });
        fixed (XrViewConfigurationView* configViewsPtr = configViews)
            return OpenXRNative.xrEnumerateViewConfigurationViews(instance, systemID, configView, viewCount, &viewCount, configViewsPtr);
    }
    public static unsafe XrResult GetValidSwapchainFormats(XrSession session, GraphicsDevice graphicsDevice) => GetValidSwapchainFormats(session, graphicsDevice.BackendType);
    public static unsafe XrResult GetValidSwapchainFormats(XrSession session, GraphicsBackend backend, out PixelFormat[] formats)
    {
        formats = null;
        if (!IsValidOpenXRGraphicsBackend(backend)) return XrResult.XR_ERROR_GRAPHICS_DEVICE_INVALID;
        uint formatCount = 0;
        XrResult r = OpenXRNative.xrEnumerateSwapchainFormats(session, 0, &formatCount, null);
        if (r != XrResult.XR_SUCCESS) return r;
        long* lformats = stackalloc long[(int)formatCount];
        r = OpenXRNative.xrEnumerateSwapchainFormats(session, formatCount, &formatCount, lformats);
        if (r != XrResult.XR_SUCCESS) return r;

        formats = new PixelFormat[formatCount];
        switch (backend)
        {
            case GraphicsBackend.Direct3D11:
                for(int i = 0; i < formatCount is++)
                    
                break;
            case GraphicsBackend.Vulkan:

                break;
        }
    }
}