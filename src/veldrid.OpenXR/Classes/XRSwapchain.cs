using SharpGen.Runtime;
using System.Runtime.CompilerServices;
using Veldrid.D3D11;
using Veldrid.OpenXR.Classes;
using Veldrid.OpenXR.Native;
using Veldrid.Vk;
using Vortice.Direct3D11;
using Vulkan;
using static Veldrid.OpenXR.Native.OpenXRNative;
using static Veldrid.OpenXR.Native.XrResult;
using VkFramebuffer = Veldrid.Vk.VkFramebuffer;

namespace Veldrid.OpenXR;

public class XRSwapchain : IDisposable
{
    public readonly XrSwapchain Swapchain;
    public uint Width => width;
    public uint Height => height;
    public int Size => (int)imageCount;
    public Framebuffer this[int index] => framebuffers[index];

    private readonly uint width;
    private readonly uint height;

    private readonly uint imageCount;
    private readonly Framebuffer[] framebuffers;

    public readonly PixelFormat colorFormat;
    public readonly PixelFormat depthFormat;
    public unsafe XRSwapchain(GraphicsDevice graphicsDevice, XRSwapchainDescription description)
    {
        const uint mipLevels = 1;
        Swapchain = description.Swapchain;
        colorFormat = description.ColorFormat;
        depthFormat = description.DepthFormat;

        width = description.Width;
        height = description.Height;

        uint imageCount;

        XrResult result = xrEnumerateSwapchainImages(Swapchain, 0, &imageCount, null);
        if(result != XR_SUCCESS)
            throw new XRResultException(result, "Failed to enumerate swapchain images: " + result);

        this.imageCount = imageCount;

        framebuffers = new Framebuffer[imageCount];

        switch(graphicsDevice.BackendType)
        {
            case GraphicsBackend.Direct3D11:
            {
                XrSwapchainImageD3D11KHR* images = stackalloc XrSwapchainImageD3D11KHR[(int)imageCount]
                    .Populate(imageCount, XrSwapchainImageD3D11KHR.New());

                result = xrEnumerateSwapchainImages(Swapchain, imageCount, &imageCount, (XrSwapchainImageBaseHeader*)images);
                if(result != XR_SUCCESS)
                    throw new XRResultException(result, "Failed to enumerate swapchain images: " + result);

                D3D11GraphicsDevice d3d11GraphicsDevice = Util.AssertSubtype<GraphicsDevice, D3D11GraphicsDevice>(graphicsDevice);

                for(int i = 0; i < imageCount; i++)
                {
                    TextureDescription colorTextureDescription = new(width, height, 1, 0, 1, colorFormat, TextureUsage.RenderTarget, TextureType.Texture2D);
                    ID3D11Texture2D colorTexture2D = new(images[i].texture);
                    Texture colorTexture = new D3D11Texture(colorTexture2D, TextureType.Texture2D, colorFormat);

                    TextureDescription depthTextureDescription = new(width, height, 1, 0, 1, depthFormat, TextureUsage.DepthStencil, TextureType.Texture2D);
                    Texture depthTexture = graphicsDevice.ResourceFactory.CreateTexture(depthTextureDescription);

                    FramebufferDescription framebufferDesc = new(depthTexture, colorTexture);

                    framebuffers[i] = new D3D11Framebuffer(d3d11GraphicsDevice.Device, ref framebufferDesc);
                }
            }
            break;
            case GraphicsBackend.Vulkan:
            {
                XrSwapchainImageVulkanKHR* images = stackalloc XrSwapchainImageVulkanKHR[(int)imageCount]
                    .Populate(imageCount, XrSwapchainImageVulkanKHR.New());

                result = xrEnumerateSwapchainImages(Swapchain, imageCount, &imageCount, (XrSwapchainImageBaseHeader*)images);
                if(result != XR_SUCCESS)
                    throw new XRResultException(result, "Failed to enumerate swapchain images: " + result);

                VkGraphicsDevice vkGraphicsDevice = Util.AssertSubtype<GraphicsDevice, VkGraphicsDevice>(graphicsDevice);

                for(int i = 0; i < imageCount; i++)
                {
                    TextureDescription depthTextureDescription = new(width, height, 1, mipLevels, 1, depthFormat, TextureUsage.DepthStencil, TextureType.Texture2D);
                    Texture depthTexture = graphicsDevice.ResourceFactory.CreateTexture(depthTextureDescription);

                    TextureDescription colorTextureDescription = new(width, height, 1, mipLevels, 1, colorFormat, TextureUsage.RenderTarget, TextureType.Texture2D);
                    Texture colorTexture = new VkTexture(
                        vkGraphicsDevice,
                        width, height,
                        mipLevels, 1,
                        VkFormats.VdToVkPixelFormat(colorFormat),
                        TextureUsage.RenderTarget,
                        TextureSampleCount.Count1,
                        new VkImage((ulong)images[i].image.ToInt64()));

                    FramebufferDescription framebufferDesc = new(depthTexture, colorTexture);

                    framebuffers[i] = new VkFramebuffer(vkGraphicsDevice, ref framebufferDesc, false);
                }
            }
            break;
            default:
                throw OpenXRUtils.NewInvalidBackendException("Unable to create XRSwapchain", graphicsDevice.BackendType);
        }
    }
    public unsafe XrResult AqquireAndWaitNextFramebuffer(out Framebuffer framebuffer, long timeoutNanoseconds = long.MaxValue) => AqquireAndWaitNextFramebuffer(out framebuffer, out _, timeoutNanoseconds);
    public unsafe XrResult AqquireAndWaitNextFramebuffer(out Framebuffer framebuffer, out uint index, long timeoutNanoseconds = long.MaxValue)
    {
        framebuffer = null;
        XrSwapchainImageAcquireInfo acquireImageInfo = XrSwapchainImageAcquireInfo.New();

        uint activeIndex;
        XrResult result = xrAcquireSwapchainImage(Swapchain, &acquireImageInfo, &activeIndex);
        index = activeIndex;
        if(result != XR_SUCCESS)
            return result;

        XrSwapchainImageWaitInfo waitImageInfo = XrSwapchainImageWaitInfo.New();
        waitImageInfo.timeout = timeoutNanoseconds;

        result = xrWaitSwapchainImage(Swapchain, &waitImageInfo);
        if(result != XR_SUCCESS)
            return result;

        framebuffer = framebuffers[activeIndex];
        return XR_SUCCESS;
    }
    public unsafe XrResult AqquireNextFramebuffer(out Framebuffer framebuffer) => AqquireNextFramebuffer(out framebuffer, out _);
    public unsafe XrResult AqquireNextFramebuffer(out Framebuffer framebuffer, out uint index)
    {
        framebuffer = null;
        XrSwapchainImageAcquireInfo acquireImageInfo = XrSwapchainImageAcquireInfo.New();

        uint activeIndex;
        XrResult result = xrAcquireSwapchainImage(Swapchain, &acquireImageInfo, &activeIndex);
        index = activeIndex;
        if(result != XR_SUCCESS)
            return result;

        framebuffer = framebuffers[activeIndex];
        return result;
    }
    public unsafe XrResult WaitFramebuffer(long timeoutNanoseconds = long.MaxValue)
    {
        XrSwapchainImageWaitInfo waitImageInfo = XrSwapchainImageWaitInfo.New();
        waitImageInfo.timeout = timeoutNanoseconds;

        XrResult result = xrWaitSwapchainImage(Swapchain, &waitImageInfo);
        if(result != XR_SUCCESS)
            return result;
        return result;
    }
    public unsafe XrResult ReleaseFramebuffer()
    {
        XrSwapchainImageReleaseInfo releaseImageInfo = XrSwapchainImageReleaseInfo.New();
        return xrReleaseSwapchainImage(Swapchain, &releaseImageInfo);
    }
    public void Dispose()
    {
        for(int i = 0; i < framebuffers.Length; i++)
            framebuffers[i].Dispose(); 
        xrDestroySwapchain(Swapchain);
        GC.SuppressFinalize(this);
    }
}