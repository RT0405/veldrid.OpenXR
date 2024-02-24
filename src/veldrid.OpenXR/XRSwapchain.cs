using Veldrid.OpenXR.Native;
using static Veldrid.OpenXR.Native.OpenXRNative;
using static Veldrid.OpenXR.Native.XrResult;

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
        if (result != XR_SUCCESS)
            throw new XRResultException(result, "Failed to enumerate swapchain images: " + result);

        this.imageCount = imageCount;

        framebuffers = new Framebuffer[imageCount];

        ResourceFactory factory = graphicsDevice.ResourceFactory;

        Span<ulong> textureHandles = stackalloc ulong[(int)imageCount];

        switch (graphicsDevice.BackendType)
        {
            case GraphicsBackend.Direct3D11:
                {
                    XrSwapchainImageD3D11KHR* images = stackalloc XrSwapchainImageD3D11KHR[(int)imageCount]
                        .Populate(XrSwapchainImageD3D11KHR.New());

                    result = xrEnumerateSwapchainImages(Swapchain, imageCount, &imageCount, (XrSwapchainImageBaseHeader*)images);
                    if (result != XR_SUCCESS)
                        throw new XRResultException(result, "Failed to enumerate swapchain images: " + result);

                    for (int i = 0; i < imageCount; i++)
                        textureHandles[i] = (ulong)*images[i].texture;
                }
                break;
            case GraphicsBackend.Vulkan:
                {
                    XrSwapchainImageVulkanKHR* images = stackalloc XrSwapchainImageVulkanKHR[(int)imageCount]
                        .Populate(XrSwapchainImageVulkanKHR.New());

                    result = xrEnumerateSwapchainImages(Swapchain, imageCount, &imageCount, (XrSwapchainImageBaseHeader*)images);
                    if (result != XR_SUCCESS)
                        throw new XRResultException(result, "Failed to enumerate swapchain images: " + result);

                    for (int i = 0; i < imageCount; i++)
                        textureHandles[i] = (ulong)images[i].image;
                }
                break;
            default:
                throw OpenXRUtils.NewInvalidBackendException("Unable to create XRSwapchain", graphicsDevice.BackendType);
        }

        for (int i = 0; i < imageCount; i++)
        {
            Console.WriteLine(i);
            TextureDescription colorTextureDescription = new(width, height, 1, mipLevels, 1, colorFormat, TextureUsage.RenderTarget, TextureType.Texture2D);
            Console.WriteLine(i);
            Texture colorTexture = factory.CreateTexture(textureHandles[i], ref colorTextureDescription);
            Console.WriteLine(i);

            TextureDescription depthTextureDescription = new(width, height, 1, mipLevels, 1, depthFormat, TextureUsage.DepthStencil, TextureType.Texture2D);
            Texture depthTexture = factory.CreateTexture(depthTextureDescription);

            FramebufferDescription framebufferDesc = new(depthTexture, colorTexture);
            framebuffers[i] = factory.CreateFramebuffer(framebufferDesc);
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
        if (result != XR_SUCCESS)
            return result;

        XrSwapchainImageWaitInfo waitImageInfo = XrSwapchainImageWaitInfo.New();
        waitImageInfo.timeout = timeoutNanoseconds;

        result = xrWaitSwapchainImage(Swapchain, &waitImageInfo);
        if (result != XR_SUCCESS)
            return result;

        framebuffer = framebuffers[activeIndex];
        return XR_SUCCESS;
    }
    public unsafe XrResult AqquireFramebuffer(out Framebuffer framebuffer) => AqquireFramebuffer(out framebuffer, out _);
    public unsafe XrResult AqquireFramebuffer(out Framebuffer framebuffer, out uint index)
    {
        framebuffer = null;
        XrSwapchainImageAcquireInfo acquireImageInfo = XrSwapchainImageAcquireInfo.New();

        uint activeIndex;
        XrResult result = xrAcquireSwapchainImage(Swapchain, &acquireImageInfo, &activeIndex);
        index = activeIndex;
        if (result != XR_SUCCESS)
            return result;

        framebuffer = framebuffers[activeIndex];
        return result;
    }
    public unsafe XrResult WaitFramebuffer(long timeoutNanoseconds = long.MaxValue)
    {
        XrSwapchainImageWaitInfo waitImageInfo = XrSwapchainImageWaitInfo.New();
        waitImageInfo.timeout = timeoutNanoseconds;

        XrResult result = xrWaitSwapchainImage(Swapchain, &waitImageInfo);
        if (result != XR_SUCCESS)
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
        for (int i = 0; i < framebuffers.Length; i++)
            framebuffers[i].Dispose();
        xrDestroySwapchain(Swapchain);
        GC.SuppressFinalize(this);
    }
}