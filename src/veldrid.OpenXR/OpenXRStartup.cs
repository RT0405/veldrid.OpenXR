using Veldrid.D3D11;
using Veldrid.OpenXR.Native;
using Veldrid.OpenXR.Vk;
using Veldrid.Vk;
using static Veldrid.OpenXR.Native.OpenXRNative;

namespace Veldrid.OpenXR;
public static partial class OpenXRUtils
{
    #region GraphicsDevice Creation
    public static GraphicsDevice CreateGraphicsDevice(XrInstance instance, ulong systemID, GraphicsDeviceOptions options, GraphicsBackend backend) => CreateGraphicsDevice(instance, systemID, options, backend, out _, out _);
    public static GraphicsDevice CreateGraphicsDevice(XrInstance instance, ulong systemID, GraphicsDeviceOptions options, GraphicsBackend backend, out XrResult result, out string? message)
    {
#pragma warning disable IDE0066 // Convert switch statement to expression
        switch (backend)
        {
            case GraphicsBackend.Direct3D11:
#if !EXCLUDE_D3D11_BACKEND
                return CreateGraphicsDeviceD3D11(instance, systemID, options, out result, out message);
#else
                        throw new VeldridException("D3D11 support has not been included in this configuration of Veldrid");
#endif
            case GraphicsBackend.Vulkan:
#if !EXCLUDE_VULKAN_BACKEND
                return CreateGraphicsDeviceVulkan(instance, systemID, options, out result, out message);
#else
                        throw new VeldridException("Vulkan support has not been included in this configuration of Veldrid");
#endif
            default: throw NewInvalidBackendException("Unable to create GraphicsDevice", backend);
        };
#pragma warning restore IDE0066 // Convert switch statement to expression
    }
#if !EXCLUDE_VULKAN_BACKEND
    public static unsafe GraphicsDevice CreateGraphicsDeviceVulkan(XrInstance instance, ulong systemID, GraphicsDeviceOptions options, out XrResult result, out string? errorMessage)
    {
        try
        {
            errorMessage = null;
            result = XrResult.XR_SUCCESS;
            return new XrVkGraphicsDevice(instance, systemID, options, new());
        }
        catch (XRResultException e)
        {
            errorMessage = e.Message;
            result = e.Result;
            return null;
        }
    }
#endif
#if !EXCLUDE_D3D11_BACKEND
    public static unsafe GraphicsDevice CreateGraphicsDeviceD3D11(XrInstance instance, ulong systemID, GraphicsDeviceOptions options, out XrResult result, out string? errorMessage)
    {
        XrGraphicsRequirementsD3D11KHR requirements = XrGraphicsRequirementsD3D11KHR.New();
        result = xrGetD3D11GraphicsRequirementsKHR(instance, systemID, &requirements);
        if (result != XrResult.XR_SUCCESS)
        {
            errorMessage = "Unable to get XrGraphicsRequirementsD3D11KHR: " + result;
            return null;
        }
        else
            errorMessage = null;
        
        return new D3D11GraphicsDevice(options, new D3D11DeviceOptions()
        {
            AdapterPtr = *(nint*)requirements.adapterLuid
        }, null);
    }
#endif
    #endregion
    public static unsafe XrSession CreateXRSession(XrInstance instance, ulong systemID, GraphicsDevice graphicsDevice)
    {
        return graphicsDevice.BackendType switch
        {
            GraphicsBackend.Vulkan => CreateXRSessionVulkan(),
            GraphicsBackend.Direct3D11 => CreateXRSessionD3D11(),
            _ => throw NewInvalidBackendException("Unable to create XrGraphicsBinding", graphicsDevice.BackendType),
        };
        XrSession CreateXRSessionVulkan()
        {
            BackendInfoVulkan backendInfo = graphicsDevice.GetVulkanInfo();
            XrGraphicsBindingVulkanKHR graphicsBinding = new()
            {
                type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR,
                next = null,
                device = backendInfo.Device,
                instance = backendInfo.Instance,
                physicalDevice = backendInfo.PhysicalDevice,
                queueFamilyIndex = backendInfo.GraphicsQueueFamilyIndex,
                queueIndex = ((VkGraphicsDevice)graphicsDevice).GraphicsQueueIndex,
            };
            return CreateSession(&graphicsBinding);
        }
        XrSession CreateXRSessionD3D11()
        {
            BackendInfoD3D11 backendInfo = graphicsDevice.GetD3D11Info();
            nint device = backendInfo.Device;
            XrGraphicsBindingD3D11KHR graphicsBinding = new()
            {
                type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_D3D11_KHR,
                next = null,
                device = &device,
            };
            return CreateSession(&graphicsBinding);
        }
        XrSession CreateSession(void* graphicsBindingPtr)
        {
            XrSessionCreateInfo sessionCreateInfo = new()
            {
                type = XrStructureType.XR_TYPE_SESSION_CREATE_INFO,
                next = graphicsBindingPtr,
                createFlags = 0,
                systemId = systemID
            };

            XrSession session;
            XrResult result = xrCreateSession(instance, &sessionCreateInfo, &session);
            if (result != XrResult.XR_SUCCESS)
                throw new XRResultException(result, "Failed to create OpenXR session: " + result);

            return session;
        }
    }
    public static unsafe (XRSwapchain, XRSwapchain) AqquireSwapchainsStereo(XrInstance instance, ulong systemID, XrSession session, GraphicsDevice graphicsDevice, PixelFormat depthFormat)
    {
        const uint viewCount = 2;
        XrViewConfigurationView* configViews =
            stackalloc XrViewConfigurationView[(int)viewCount].Populate(viewCount,
            new XrViewConfigurationView() { type = XrStructureType.XR_TYPE_VIEW_CONFIGURATION_VIEW });
        uint configViewCount = viewCount;
        XrResult result = xrEnumerateViewConfigurationViews(instance, systemID, XrViewConfigurationType.XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO, viewCount, &configViewCount, configViews);
        if (result != XrResult.XR_SUCCESS || configViewCount != viewCount)
            throw new XRResultException(result, "Failed to enumerate view configuration views: " + result);

        PixelFormat format = GetSwapchainFormats(session, graphicsDevice.BackendType)[0];

        XrSwapchain* swapchains = stackalloc XrSwapchain[(int)viewCount];
        XRSwapchain left, right;
        for (int i = 0; i < viewCount; i++)
        {
            XrSwapchainCreateInfo swapchainCreateInfo;
            swapchainCreateInfo.type = XrStructureType.XR_TYPE_SWAPCHAIN_CREATE_INFO;
            swapchainCreateInfo.usageFlags = (ulong)XrSwapchainUsageFlags.XR_SWAPCHAIN_USAGE_COLOR_ATTACHMENT_BIT;
            swapchainCreateInfo.format = FormatUtils.VeldridToNativeFormat(format, graphicsDevice.BackendType, false);
            swapchainCreateInfo.sampleCount = 1;
            swapchainCreateInfo.width = configViews[i].recommendedImageRectWidth;
            swapchainCreateInfo.height = configViews[i].recommendedImageRectHeight;
            swapchainCreateInfo.faceCount = 1;
            swapchainCreateInfo.arraySize = 1;
            swapchainCreateInfo.mipCount = 1;

            result = xrCreateSwapchain(session, &swapchainCreateInfo, &swapchains[i]);
            if (result != XrResult.XR_SUCCESS)
                throw new XRResultException(result, "Failed to create swapchain: " + result);
        }
        left = new(graphicsDevice, new(swapchains[0], configViews[0].recommendedImageRectWidth, configViews[0].recommendedImageRectHeight, format, depthFormat));
        right = new(graphicsDevice, new(swapchains[1], configViews[1].recommendedImageRectWidth, configViews[1].recommendedImageRectHeight, format, depthFormat));
        return (left, right);
    }
    public static unsafe PixelFormat[] GetSwapchainFormats(XrSession session, GraphicsBackend backend)
    {
        uint formatCount = 0;
        XrResult result = xrEnumerateSwapchainFormats(session, 0, &formatCount, null);
        if (result != XrResult.XR_SUCCESS)
            throw new XRResultException(result, "Failed to enumerate swapchain formats: " + result);
        PixelFormat[] formats = new PixelFormat[formatCount];
        fixed (PixelFormat* span = formats)
            _ = GetSwapchainFormats(session, backend, new Span<PixelFormat>(span, (int)formatCount));
        return formats;
    }
    /// <summary>
    /// Fills a buffer with the available swapchain pixel formats for the session.<br/>
    /// <b><i>Warning the buffer may not get completely filled</i></b>
    /// </summary>
    /// <param name="session">the session to get the available swapchain formats for</param>
    /// <param name="backend">the graphics backend that is currently being used</param>
    /// <param name="formats">a buffer to fill with the available formats</param>
    /// <returns>the number of elements placed in the span, or the number of elements required</returns>
    /// <exception cref="XRResultException"></exception>
    public static unsafe int GetSwapchainFormats(XrSession session, GraphicsBackend backend, Span<PixelFormat> formats)
    {
        uint formatCount = 0;
        XrResult result = xrEnumerateSwapchainFormats(session, 0, &formatCount, null);
        if (result != XrResult.XR_SUCCESS)
            throw new XRResultException(result, "Failed to enumerate swapchain formats: " + result);
        long* formatBuffer = stackalloc long[(int)formatCount];
        result = xrEnumerateSwapchainFormats(session, formatCount, &formatCount, formatBuffer);
        if (result != XrResult.XR_SUCCESS)
            throw new XRResultException(result, "Failed to enumerate swapchain formats: " + result);
        switch (backend)
        {
            case GraphicsBackend.Vulkan:
            case GraphicsBackend.Direct3D11:
                int index = 0;
                for (int i = 0; i < formatCount; i++)
                {
                    if (index == formats.Length)
                    {
                        //add the number of remaining valid formats to the count
                        while (i < formatCount)
                            if (FormatUtils.IsValidFormat(formatBuffer[i], backend))
                                index++;
                        break;
                    }
                    PixelFormat format = FormatUtils.NativeToVeldridFormat(formatBuffer[i], backend);
                    if (FormatUtils.IsValidFormat(format))
                        formats[index++] = format;
                }
                return index;
            default:
                throw NewInvalidBackendException("Failed to convert swapchain formats", backend);
        }
    }
}