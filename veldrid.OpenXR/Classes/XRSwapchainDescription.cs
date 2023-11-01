using System;
using Veldrid.OpenXR.Native;
using Vulkan;

namespace Veldrid.OpenXR.Classes;
public readonly struct XRSwapchainDescription
{
    public readonly XrSwapchain Swapchain;
    public readonly PixelFormat ColorFormat;
    public readonly PixelFormat DepthFormat;
    public readonly uint Width;
    public readonly uint Height;
    public XRSwapchainDescription(XrSwapchain swapchain, uint width, uint height, PixelFormat colorFormat, PixelFormat depthFormat)
    {
        Swapchain = swapchain;
        Width = width;
        Height = height;
        ColorFormat = colorFormat;
        DepthFormat = depthFormat;
    }
}