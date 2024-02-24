using Veldrid.OpenXR.Native;

namespace Veldrid.OpenXR;
public readonly struct XRSwapchainDescription(XrSwapchain swapchain, uint width, uint height, PixelFormat colorFormat, PixelFormat depthFormat)
{
    public readonly XrSwapchain Swapchain = swapchain;
    public readonly PixelFormat ColorFormat = colorFormat;
    public readonly PixelFormat DepthFormat = depthFormat;
    public readonly uint Width = width;
    public readonly uint Height = height;
}