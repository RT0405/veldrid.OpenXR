using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Vulkan;
using Veldrid.Vk;
using static Veldrid.Vk.VulkanUtil;
using static Vulkan.VulkanNative;
using Veldrid.OpenXR.Native;

namespace Veldrid.OpenXR.Vk;
public unsafe class XrVkGraphicsDevice : VkGraphicsDevice
{
    public override GraphicsDeviceFeatures Features { get; }
    public override ResourceFactory ResourceFactory { get; }
    public XrVkGraphicsDevice(XrInstance xrInstance, ulong xrSystemID, GraphicsDeviceOptions options, VulkanDeviceOptions vkOptions)
    {
        CreateInstanceXR(xrInstance, options.Debug, vkOptions, xrSystemID);



        CreatePhysicalDeviceXR(xrInstance, xrSystemID);
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
        for (int i = 0; i < SharedCommandPoolCount; i++)
        {
            _sharedGraphicsCommandPools.Push(new SharedCommandPool(this, true));
        }

        _vulkanInfo = new BackendInfoVulkan(this);

        PostDeviceCreated();
    }
    private void CreateInstanceXR(XrInstance xrInstance, bool debug, VulkanDeviceOptions vkOptions, ulong xrSystemID)
    {
        HashSet<string> availableInstanceLayers = new(EnumerateInstanceLayers());
        HashSet<string> availableInstanceExtensions = new(GetInstanceExtensions());

        VkInstanceCreateInfo instanceCI = VkInstanceCreateInfo.New();
        VkApplicationInfo applicationInfo = new();
        applicationInfo.apiVersion = new VkVersion(1, 0, 0);
        applicationInfo.applicationVersion = new VkVersion(1, 0, 0);
        applicationInfo.engineVersion = new VkVersion(1, 0, 0);
        applicationInfo.pApplicationName = s_name;
        applicationInfo.pEngineName = s_name;

        instanceCI.pApplicationInfo = &applicationInfo;

        StackList<IntPtr, Size64Bytes> instanceExtensions = new();
        StackList<IntPtr, Size64Bytes> instanceLayers = new();

        if (availableInstanceExtensions.Contains(CommonStrings.VK_KHR_portability_subset))
        {
            _surfaceExtensions.Add(CommonStrings.VK_KHR_portability_subset);
        }

        if (availableInstanceExtensions.Contains(CommonStrings.VK_KHR_SURFACE_EXTENSION_NAME))
        {
            _surfaceExtensions.Add(CommonStrings.VK_KHR_SURFACE_EXTENSION_NAME);
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            if (availableInstanceExtensions.Contains(CommonStrings.VK_KHR_WIN32_SURFACE_EXTENSION_NAME))
            {
                _surfaceExtensions.Add(CommonStrings.VK_KHR_WIN32_SURFACE_EXTENSION_NAME);
            }
        }
        else if (
#if NET5_0_OR_GREATER
            OperatingSystem.IsAndroid() ||
#endif
            RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            if (availableInstanceExtensions.Contains(CommonStrings.VK_KHR_ANDROID_SURFACE_EXTENSION_NAME))
            {
                _surfaceExtensions.Add(CommonStrings.VK_KHR_ANDROID_SURFACE_EXTENSION_NAME);
            }
            if (availableInstanceExtensions.Contains(CommonStrings.VK_KHR_XLIB_SURFACE_EXTENSION_NAME))
            {
                _surfaceExtensions.Add(CommonStrings.VK_KHR_XLIB_SURFACE_EXTENSION_NAME);
            }
            if (availableInstanceExtensions.Contains(CommonStrings.VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME))
            {
                _surfaceExtensions.Add(CommonStrings.VK_KHR_WAYLAND_SURFACE_EXTENSION_NAME);
            }
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            if (availableInstanceExtensions.Contains(CommonStrings.VK_EXT_METAL_SURFACE_EXTENSION_NAME))
            {
                _surfaceExtensions.Add(CommonStrings.VK_EXT_METAL_SURFACE_EXTENSION_NAME);
            }
            else // Legacy MoltenVK extensions
            {
                if (availableInstanceExtensions.Contains(CommonStrings.VK_MVK_MACOS_SURFACE_EXTENSION_NAME))
                {
                    _surfaceExtensions.Add(CommonStrings.VK_MVK_MACOS_SURFACE_EXTENSION_NAME);
                }
                if (availableInstanceExtensions.Contains(CommonStrings.VK_MVK_IOS_SURFACE_EXTENSION_NAME))
                {
                    _surfaceExtensions.Add(CommonStrings.VK_MVK_IOS_SURFACE_EXTENSION_NAME);
                }
            }
        }

        foreach (var ext in _surfaceExtensions)
        {
            instanceExtensions.Add(ext);
        }

        bool hasDeviceProperties2 = availableInstanceExtensions.Contains(CommonStrings.VK_KHR_get_physical_device_properties2);
        if (hasDeviceProperties2)
        {
            instanceExtensions.Add(CommonStrings.VK_KHR_get_physical_device_properties2);
        }

        string[] requestedInstanceExtensions = vkOptions.InstanceExtensions ?? Array.Empty<string>();

        List<FixedUtf8String> tempStrings = new();
        foreach (string requiredExt in requestedInstanceExtensions)
        {
            if (!availableInstanceExtensions.Contains(requiredExt))
            {
                throw new VeldridException($"The required instance extension was not available: {requiredExt}");
            }

            FixedUtf8String utf8Str = new FixedUtf8String(requiredExt);
            instanceExtensions.Add(utf8Str);
            tempStrings.Add(utf8Str);
        }

        bool debugReportExtensionAvailable = false;
        if (debug)
        {
            if (availableInstanceExtensions.Contains(CommonStrings.VK_EXT_DEBUG_REPORT_EXTENSION_NAME))
            {
                debugReportExtensionAvailable = true;
                instanceExtensions.Add(CommonStrings.VK_EXT_DEBUG_REPORT_EXTENSION_NAME);
            }
            if (availableInstanceLayers.Contains(CommonStrings.StandardValidationLayerName))
            {
                _standardValidationSupported = true;
                instanceLayers.Add(CommonStrings.StandardValidationLayerName);
            }
            if (availableInstanceLayers.Contains(CommonStrings.KhronosValidationLayerName))
            {
                _khronosValidationSupported = true;
                instanceLayers.Add(CommonStrings.KhronosValidationLayerName);
            }
        }

        instanceCI.enabledExtensionCount = instanceExtensions.Count;
        instanceCI.ppEnabledExtensionNames = (byte**)instanceExtensions.Data;

        instanceCI.enabledLayerCount = instanceLayers.Count;
        if (instanceLayers.Count > 0)
        {
            instanceCI.ppEnabledLayerNames = (byte**)instanceLayers.Data;
        }

        VkResult result = vkCreateInstance(ref instanceCI, null, out _instance);

        if (HasSurfaceExtension(CommonStrings.VK_EXT_METAL_SURFACE_EXTENSION_NAME))
        {
            _createMetalSurfaceEXT = GetInstanceProcAddr<vkCreateMetalSurfaceEXT_t>("vkCreateMetalSurfaceEXT");
        }

        if (debug && debugReportExtensionAvailable)
        {
            EnableDebugCallback();
        }

        if (hasDeviceProperties2)
        {
            _getPhysicalDeviceProperties2 = GetInstanceProcAddr<vkGetPhysicalDeviceProperties2_t>("vkGetPhysicalDeviceProperties2")
                ?? GetInstanceProcAddr<vkGetPhysicalDeviceProperties2_t>("vkGetPhysicalDeviceProperties2KHR");
        }

        foreach (FixedUtf8String tempStr in tempStrings)
        {
            tempStr.Dispose();
        }
    }
    protected void CreatePhysicalDeviceXR(XrInstance xrInstance, ulong xrSystemID)
    {
        XrResult result;
        fixed (VkInstance* vkInstancePtr = &_instance)
        fixed (VkPhysicalDevice* vkDevicePtr = &_physicalDevice)
            result = OpenXRNative.xrGetVulkanGraphicsDeviceKHR(xrInstance, xrSystemID, (IntPtr)vkInstancePtr, (IntPtr)vkDevicePtr);
        if(result != XrResult.XR_SUCCESS)
            throw new XRResultException(result, "Failed to get VkPhysicalDevice");

        vkGetPhysicalDeviceProperties(_physicalDevice, out _physicalDeviceProperties);
        fixed (byte* utf8NamePtr = _physicalDeviceProperties.deviceName)
        {
            _deviceName = Encoding.UTF8.GetString(utf8NamePtr, (int)MaxPhysicalDeviceNameSize).TrimEnd('\0');
        }

        _vendorName = "id:" + _physicalDeviceProperties.vendorID.ToString("x8");
        _apiVersion = GraphicsApiVersion.Unknown;
        _driverInfo = "version:" + _physicalDeviceProperties.driverVersion.ToString("x8");

        vkGetPhysicalDeviceFeatures(_physicalDevice, out _physicalDeviceFeatures);

        vkGetPhysicalDeviceMemoryProperties(_physicalDevice, out _physicalDeviceMemProperties);
    }
}