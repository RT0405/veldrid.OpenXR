using System.Runtime.InteropServices;
using System.Text;
using Veldrid.OpenXR.Native;
using Veldrid.OpenXR.PostCompilerFixup;
using Veldrid.Vk;
using Vulkan;
using static Veldrid.OpenXR.Native.OpenXRNative;
using static Vulkan.VulkanNative;
using static Veldrid.Vk.VulkanUtil;
using System.Runtime.ExceptionServices;

namespace Veldrid.OpenXR.Vk;

public unsafe class XrVkGraphicsDevice : VkGraphicsDevice
{
    public override GraphicsDeviceFeatures Features { get; }
    public override ResourceFactory ResourceFactory { get; }
    [RemoveBaseConstructorCall(KeepInitialization = true, ReplaceWith = "")]
    public XrVkGraphicsDevice(XrInstance xrInstance, ulong xrSystemID, GraphicsDeviceOptions options, VulkanDeviceOptions vkOptions) : base(options, null, default)//we use the three param constructor because the 2 param one doesn't have the field initialization
    {
        Console.WriteLine("creating stuff vk");
        if(_surfaceExtensions == null)
            Console.WriteLine("locals not intitialized");
        //xr
        if(this == null)
            Console.WriteLine("null gd in constructor");
        else
            Console.WriteLine("gd is not null in constructor");
        GetXRVulkanInstanceRequirements(xrInstance, xrSystemID, out string[] instanceExtensions);
        if(vkOptions.InstanceExtensions == null)
            vkOptions.InstanceExtensions = instanceExtensions;
        else
            vkOptions.InstanceExtensions = vkOptions.InstanceExtensions.Union(instanceExtensions).ToArray();

        XrGraphicsRequirementsVulkanKHR xrGraphicsRequirements = XrGraphicsRequirementsVulkanKHR.New();
        xrGetVulkanGraphicsRequirementsKHR(xrInstance, xrSystemID, &xrGraphicsRequirements);
        Console.WriteLine($"Called xrGetVulkanGraphicsRequirementsKHR with {xrInstance.Handle}, and {xrSystemID}");
        XRVersion minVersion = (XRVersion)xrGraphicsRequirements.minApiVersionSupported;
        XRVersion version = new(1, 0, 0);
        if(version < minVersion)
        {
            version = minVersion;
            Console.WriteLine($"Warning: Creating a Vulkan GraphicsDevice with api version {version.Major}.{version.Minor}.{version.Patch} as required by this instance of OpenXR, but Veldrid always creates with version 1.0.0");
        }
        //replacement only changes it so you can set the api version, figured it was better than just leaving it at 1.0.0 every time...

        XrCreateInstance(options.Debug, vkOptions, new VkVersion(version.Major, version.Minor, version.Patch));

        CreatePhysicalDeviceXR(xrInstance, xrSystemID);

        GetXRVulkanDeviceRequirements(xrInstance, xrSystemID, PhysicalDevice, out string[] deviceExtensions);
        if(vkOptions.DeviceExtensions == null)
            vkOptions.DeviceExtensions = deviceExtensions;
        else
            vkOptions.DeviceExtensions = vkOptions.InstanceExtensions.Union(deviceExtensions).ToArray();
        //xr end

        CreateLogicalDevice(VkSurfaceKHR.Null, options.PreferStandardClipSpaceYDirection, vkOptions);

        _memoryManager = new VkDeviceMemoryManager(
            _device,
            _physicalDevice,
            _physicalDeviceProperties.limits.bufferImageGranularity,
            _getBufferMemoryRequirements2,
            _getImageMemoryRequirements2);

        Features = new GraphicsDeviceFeatures(
            computeShader: true,
            geometryShader: _physicalDeviceFeatures.geometryShader,
            tessellationShaders: _physicalDeviceFeatures.tessellationShader,
            multipleViewports: _physicalDeviceFeatures.multiViewport,
            samplerLodBias: true,
            drawBaseVertex: true,
            drawBaseInstance: true,
            drawIndirect: true,
            drawIndirectBaseInstance: _physicalDeviceFeatures.drawIndirectFirstInstance,
            fillModeWireframe: _physicalDeviceFeatures.fillModeNonSolid,
            samplerAnisotropy: _physicalDeviceFeatures.samplerAnisotropy,
            depthClipDisable: _physicalDeviceFeatures.depthClamp,
            texture1D: true,
            independentBlend: _physicalDeviceFeatures.independentBlend,
            structuredBuffer: true,
            subsetTextureView: true,
            commandListDebugMarkers: _debugMarkerEnabled,
            bufferRangeBinding: true,
            shaderFloat64: _physicalDeviceFeatures.shaderFloat64);

        ResourceFactory = new VkResourceFactory(this);

        CreateDescriptorPool();
        CreateGraphicsCommandPool();
        for(int i = 0; i < SharedCommandPoolCount; i++)
        {
            _sharedGraphicsCommandPools.Push(new SharedCommandPool(this, true));
        }

        _vulkanInfo = new BackendInfoVulkan(this);

        PostDeviceCreated();
    }
    private void GetXRVulkanInstanceRequirements(XrInstance xrInstance, ulong xrSystemID, out string[] vkInstanceExtensions)
    {
        uint vkInstanceExtensionsBufferSize;
        XrResult result = xrGetVulkanInstanceExtensionsKHR(xrInstance, xrSystemID, 0, &vkInstanceExtensionsBufferSize, null);
        if(result != XrResult.XR_SUCCESS)
            throw new XRResultException(result, "Failed to get Vulkan instance extensions: " + result);
        byte* buffer = stackalloc byte[(int)vkInstanceExtensionsBufferSize];
        result = xrGetVulkanInstanceExtensionsKHR(xrInstance, xrSystemID, vkInstanceExtensionsBufferSize, &vkInstanceExtensionsBufferSize, buffer);
        if(result != XrResult.XR_SUCCESS)
            throw new XRResultException(result, "Failed to get Vulkan instance extensions: " + result);

        string strBuffer = Encoding.UTF8.GetString(buffer, (int)vkInstanceExtensionsBufferSize);
        int extensionCount = vkInstanceExtensionsBufferSize > 0 ? 1 : 0;
        for(int i = 0; i < strBuffer.Length; i++)
            if(strBuffer[i] == ' ')
                extensionCount++;

        vkInstanceExtensions = new string[extensionCount];
        int last = 0;
        int extensionIndex = 0;
        for(int i = 0; i <= strBuffer.Length; i++)
        {
            if(i == strBuffer.Length || strBuffer[i] == ' ')
            {
                vkInstanceExtensions[extensionIndex++] = strBuffer[last..i].TrimEnd((char)0);
                last = i + 1;
            }
        }
    }
    private void GetXRVulkanDeviceRequirements(XrInstance xrInstance, ulong xrSystemID, VkPhysicalDevice physicalDevice, out string[] deviceExtensions)
    {
        uint vkDeviceExtensionsBufferSize;
        XrResult result = xrGetVulkanDeviceExtensionsKHR(xrInstance, xrSystemID, 0, &vkDeviceExtensionsBufferSize, null);
        if(result != XrResult.XR_SUCCESS)
            throw new XRResultException(result, "Failed to get Vulkan device extensions: " + result);
        byte* buffer = stackalloc byte[(int)vkDeviceExtensionsBufferSize];
        result = xrGetVulkanDeviceExtensionsKHR(xrInstance, xrSystemID, vkDeviceExtensionsBufferSize, &vkDeviceExtensionsBufferSize, buffer);
        if(result != XrResult.XR_SUCCESS)
            throw new XRResultException(result, "Failed to get Vulkan device extensions: " + result);

        string strBuffer = Encoding.UTF8.GetString(buffer, (int)vkDeviceExtensionsBufferSize);
        int extensionCount = vkDeviceExtensionsBufferSize > 0 ? 1 : 0;
        for(int i = 0; i < strBuffer.Length; i++)
            if(strBuffer[i] == ' ')
                extensionCount++;

        deviceExtensions = new string[extensionCount];
        int last = 0;
        int extensionIndex = 0;
        for(int i = 0; i <= strBuffer.Length; i++)
        {
            if(i == strBuffer.Length || strBuffer[i] == ' ')
            {
                deviceExtensions[extensionIndex++] = strBuffer[last..i].TrimEnd((char)0);
                last = i + 1;
            }
        }
    }
    protected void CreatePhysicalDeviceXR(XrInstance xrInstance, ulong xrSystemID)
    {
        //xr
        XrResult result;
        VkPhysicalDevice vkPhysicalDevice;
        result = xrGetVulkanGraphicsDeviceKHR(xrInstance, xrSystemID, _instance.Handle, (IntPtr)(&vkPhysicalDevice));
        if(result != XrResult.XR_SUCCESS)
            throw new XRResultException(result, "Failed to get VkPhysicalDevice: " + result);
        _physicalDevice = vkPhysicalDevice;
        //xr end

        vkGetPhysicalDeviceProperties(_physicalDevice, out _physicalDeviceProperties);
        fixed(byte* utf8NamePtr = _physicalDeviceProperties.deviceName)
        {
            _deviceName = Encoding.UTF8.GetString(utf8NamePtr, (int)MaxPhysicalDeviceNameSize).TrimEnd('\0');
        }

        _vendorName = "id:" + _physicalDeviceProperties.vendorID.ToString("x8");
        _apiVersion = GraphicsApiVersion.Unknown;
        _driverInfo = "version:" + _physicalDeviceProperties.driverVersion.ToString("x8");

        vkGetPhysicalDeviceFeatures(_physicalDevice, out _physicalDeviceFeatures);

        vkGetPhysicalDeviceMemoryProperties(_physicalDevice, out _physicalDeviceMemProperties);
    }
    protected void XrCreateInstance(bool debug, VulkanDeviceOptions options, VkVersion version)
    {
        HashSet<string> availableInstanceLayers = new(EnumerateInstanceLayers());
        HashSet<string> availableInstanceExtensions = new(GetInstanceExtensions());

        VkInstanceCreateInfo instanceCI = VkInstanceCreateInfo.New();
        VkApplicationInfo applicationInfo = new()
        {
            apiVersion = version,
            applicationVersion = new VkVersion(1, 0, 0),
            engineVersion = new VkVersion(1, 0, 0),
            pApplicationName = s_name,
            pEngineName = s_name
        };

        instanceCI.pApplicationInfo = &applicationInfo;

        List<IntPtr> instanceExtensions = new();//converted these to normal lists since the stacklists seemed to be throwing AccessViolationExceptions
        List<IntPtr> instanceLayers = new();

        if(availableInstanceExtensions.Contains(CommonStrings.VK_KHR_portability_subset))
        {
            _surfaceExtensions.Add(CommonStrings.VK_KHR_portability_subset);
        }

        if(availableInstanceExtensions.Contains(CommonStrings.VK_KHR_SURFACE_EXTENSION_NAME))
        {
            _surfaceExtensions.Add(CommonStrings.VK_KHR_SURFACE_EXTENSION_NAME);
        }

        if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            if(availableInstanceExtensions.Contains(CommonStrings.VK_KHR_WIN32_SURFACE_EXTENSION_NAME))
            {
                _surfaceExtensions.Add(CommonStrings.VK_KHR_WIN32_SURFACE_EXTENSION_NAME);
            }
        }
        else if(
#if NET5_0_OR_GREATER
            OperatingSystem.IsAndroid() ||
#endif
            RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            if(availableInstanceExtensions.Contains(CommonStrings.VK_KHR_ANDROID_SURFACE_EXTENSION_NAME))
            {
                _surfaceExtensions.Add(CommonStrings.VK_KHR_ANDROID_SURFACE_EXTENSION_NAME);
            }
            if(availableInstanceExtensions.Contains(CommonStrings.VK_KHR_XLIB_SURFACE_EXTENSION_NAME))
            {
                _surfaceExtensions.Add(CommonStrings.VK_KHR_XLIB_SURFACE_EXTENSION_NAME);
            }
            if(availableInstanceExtensions.Contains(CommonStrings.VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME))
            {
                _surfaceExtensions.Add(CommonStrings.VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME);
            }
        }
        else if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            if(availableInstanceExtensions.Contains(CommonStrings.VK_EXT_METAL_SURFACE_EXTENSION_NAME))
            {
                _surfaceExtensions.Add(CommonStrings.VK_EXT_METAL_SURFACE_EXTENSION_NAME);
            }
            else // Legacy MoltenVK extensions
            {
                if(availableInstanceExtensions.Contains(CommonStrings.VK_MVK_MACOS_SURFACE_EXTENSION_NAME))
                {
                    _surfaceExtensions.Add(CommonStrings.VK_MVK_MACOS_SURFACE_EXTENSION_NAME);
                }
                if(availableInstanceExtensions.Contains(CommonStrings.VK_MVK_IOS_SURFACE_EXTENSION_NAME))
                {
                    _surfaceExtensions.Add(CommonStrings.VK_MVK_IOS_SURFACE_EXTENSION_NAME);
                }
            }
        }

        foreach(var ext in _surfaceExtensions)
        {
            instanceExtensions.Add(ext);
        }

        bool hasDeviceProperties2 = availableInstanceExtensions.Contains(CommonStrings.VK_KHR_get_physical_device_properties2);
        if(hasDeviceProperties2)
        {
            instanceExtensions.Add(CommonStrings.VK_KHR_get_physical_device_properties2);
        }

        string[] requestedInstanceExtensions = options.InstanceExtensions ?? Array.Empty<string>();
        List<FixedUtf8String> tempStrings = new();
        foreach(string requiredExt in requestedInstanceExtensions)
        {
            if(!availableInstanceExtensions.Contains(requiredExt))
            {
                throw new VeldridException($"The required instance extension was not available: {requiredExt}");
            }

            FixedUtf8String utf8Str = new(requiredExt);
            instanceExtensions.Add(utf8Str);
            tempStrings.Add(utf8Str);
        }

        bool debugReportExtensionAvailable = false;
        if(debug)
        {
            if(availableInstanceExtensions.Contains(CommonStrings.VK_EXT_DEBUG_REPORT_EXTENSION_NAME))
            {
                debugReportExtensionAvailable = true;
                instanceExtensions.Add(CommonStrings.VK_EXT_DEBUG_REPORT_EXTENSION_NAME);
            }
            if(availableInstanceLayers.Contains(CommonStrings.StandardValidationLayerName))
            {
                _standardValidationSupported = true;
                instanceLayers.Add(CommonStrings.StandardValidationLayerName);
            }
            if(availableInstanceLayers.Contains(CommonStrings.KhronosValidationLayerName))
            {
                _khronosValidationSupported = true;
                instanceLayers.Add(CommonStrings.KhronosValidationLayerName);
            }
        }

        {
            IntPtr[] ie = instanceExtensions.ToArray();
            IntPtr[] il = instanceLayers.ToArray();
            fixed(IntPtr* instanceExtensionsPtr = ie)
            fixed(IntPtr* instancelayersPtr = il)
            {
                instanceCI.enabledExtensionCount = (uint)instanceExtensions.Count;
                instanceCI.ppEnabledExtensionNames = (byte**)instanceExtensionsPtr;

                instanceCI.enabledLayerCount = (uint)instanceLayers.Count;
                if(instanceLayers.Count > 0)
                {
                    instanceCI.ppEnabledLayerNames = (byte**)instancelayersPtr;
                }

                VkResult result = vkCreateInstance(ref instanceCI, null, out _instance);
                CheckResult(result);
            }
        }

        if(HasSurfaceExtension(CommonStrings.VK_EXT_METAL_SURFACE_EXTENSION_NAME))
        {
            _createMetalSurfaceEXT = GetInstanceProcAddr<vkCreateMetalSurfaceEXT_t>("vkCreateMetalSurfaceEXT");
        }

        if(debug && debugReportExtensionAvailable)
        {
            EnableDebugCallback();
        }

        if(hasDeviceProperties2)
        {
            _getPhysicalDeviceProperties2 = GetInstanceProcAddr<vkGetPhysicalDeviceProperties2_t>("vkGetPhysicalDeviceProperties2")
                ?? GetInstanceProcAddr<vkGetPhysicalDeviceProperties2_t>("vkGetPhysicalDeviceProperties2KHR");
        }

        foreach(FixedUtf8String tempStr in tempStrings)
        {
            tempStr.Dispose();
        }
    }
}