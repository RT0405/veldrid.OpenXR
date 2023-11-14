using Veldrid.D3D11;
using Veldrid.Vk;
using Vortice.DXGI;
using Vulkan;

namespace Veldrid.OpenXR
{
    public static class FormatUtils
    {
        public const PixelFormat InvalidFormat = unchecked((PixelFormat)(-1));
        public static bool IsValidFormat(PixelFormat format)
            => Enum.IsDefined(format);
        public static bool IsValidFormat(long nativeFormat, GraphicsBackend backend)
            => Enum.IsDefined(NativeToVeldridFormat(nativeFormat, backend));
        public static bool IsValidFormat(long nativeFormat, GraphicsBackend backend, out PixelFormat format)
            => Enum.IsDefined(format = NativeToVeldridFormat(nativeFormat, backend));

#pragma warning disable IDE0066 // Convert switch statement to expression
        #region NativeToVeldridFormat
        public static PixelFormat NativeToVeldridFormat(long nativeFormat, GraphicsBackend backend)
        {
            return backend switch
            {
                GraphicsBackend.Direct3D11 => NativeToVeldridFormat((Format)nativeFormat),
                GraphicsBackend.Vulkan => NativeToVeldridFormat((VkFormat)nativeFormat),
                _ => InvalidFormat,
            };
        }

        public static PixelFormat NativeToVeldridFormat(Format d3d11Format)
        {
            switch (d3d11Format)
            {
                case Format.R8_UNorm:
                    return PixelFormat.R8_UNorm;
                case Format.R8_SNorm:
                    return PixelFormat.R8_SNorm;
                case Format.R8_UInt:
                    return PixelFormat.R8_UInt;
                case Format.R8_SInt:
                    return PixelFormat.R8_SInt;

                case Format.R16_UNorm:
                case Format.D16_UNorm:
                    return PixelFormat.R16_UNorm;
                case Format.R16_SNorm:
                    return PixelFormat.R16_SNorm;
                case Format.R16_UInt:
                    return PixelFormat.R16_UInt;
                case Format.R16_SInt:
                    return PixelFormat.R16_SInt;
                case Format.R16_Float:
                    return PixelFormat.R16_Float;

                case Format.R32_UInt:
                    return PixelFormat.R32_UInt;
                case Format.R32_SInt:
                    return PixelFormat.R32_SInt;
                case Format.R32_Float:
                case Format.D32_Float:
                    return PixelFormat.R32_Float;

                case Format.R8G8_UNorm:
                    return PixelFormat.R8_G8_UNorm;
                case Format.R8G8_SNorm:
                    return PixelFormat.R8_G8_SNorm;
                case Format.R8G8_UInt:
                    return PixelFormat.R8_G8_UInt;
                case Format.R8G8_SInt:
                    return PixelFormat.R8_G8_SInt;

                case Format.R16G16_UNorm:
                    return PixelFormat.R16_G16_UNorm;
                case Format.R16G16_SNorm:
                    return PixelFormat.R16_G16_SNorm;
                case Format.R16G16_UInt:
                    return PixelFormat.R16_G16_UInt;
                case Format.R16G16_SInt:
                    return PixelFormat.R16_G16_SInt;
                case Format.R16G16_Float:
                    return PixelFormat.R16_G16_Float;

                case Format.R32G32_UInt:
                    return PixelFormat.R32_G32_UInt;
                case Format.R32G32_SInt:
                    return PixelFormat.R32_G32_SInt;
                case Format.R32G32_Float:
                    return PixelFormat.R32_G32_Float;

                case Format.R8G8B8A8_UNorm:
                    return PixelFormat.R8_G8_B8_A8_UNorm;
                case Format.R8G8B8A8_UNorm_SRgb:
                    return PixelFormat.R8_G8_B8_A8_UNorm_SRgb;

                case Format.B8G8R8A8_UNorm:
                    return PixelFormat.B8_G8_R8_A8_UNorm;
                case Format.B8G8R8A8_UNorm_SRgb:
                    return PixelFormat.B8_G8_R8_A8_UNorm_SRgb;
                case Format.R8G8B8A8_SNorm:
                    return PixelFormat.R8_G8_B8_A8_SNorm;
                case Format.R8G8B8A8_UInt:
                    return PixelFormat.R8_G8_B8_A8_UInt;
                case Format.R8G8B8A8_SInt:
                    return PixelFormat.R8_G8_B8_A8_SInt;

                case Format.R16G16B16A16_UNorm:
                    return PixelFormat.R16_G16_B16_A16_UNorm;
                case Format.R16G16B16A16_SNorm:
                    return PixelFormat.R16_G16_B16_A16_SNorm;
                case Format.R16G16B16A16_UInt:
                    return PixelFormat.R16_G16_B16_A16_UInt;
                case Format.R16G16B16A16_SInt:
                    return PixelFormat.R16_G16_B16_A16_SInt;
                case Format.R16G16B16A16_Float:
                    return PixelFormat.R16_G16_B16_A16_Float;

                case Format.R32G32B32A32_UInt:
                    return PixelFormat.R32_G32_B32_A32_UInt;
                case Format.R32G32B32A32_SInt:
                    return PixelFormat.R32_G32_B32_A32_SInt;
                case Format.R32G32B32A32_Float:
                    return PixelFormat.R32_G32_B32_A32_Float;

                case Format.BC1_UNorm:
                case Format.BC1_Typeless:
                    return PixelFormat.BC1_Rgba_UNorm;
                case Format.BC2_UNorm:
                    return PixelFormat.BC2_UNorm;
                case Format.BC3_UNorm:
                    return PixelFormat.BC3_UNorm;
                case Format.BC4_UNorm:
                    return PixelFormat.BC4_UNorm;
                case Format.BC4_SNorm:
                    return PixelFormat.BC4_SNorm;
                case Format.BC5_UNorm:
                    return PixelFormat.BC5_UNorm;
                case Format.BC5_SNorm:
                    return PixelFormat.BC5_SNorm;
                case Format.BC7_UNorm:
                    return PixelFormat.BC7_UNorm;

                case Format.D24_UNorm_S8_UInt:
                    return PixelFormat.D24_UNorm_S8_UInt;
                case Format.D32_Float_S8X24_UInt:
                    return PixelFormat.D32_Float_S8_UInt;

                case Format.R10G10B10A2_UInt:
                    return PixelFormat.R10_G10_B10_A2_UInt;
                case Format.R10G10B10A2_UNorm:
                    return PixelFormat.R10_G10_B10_A2_UNorm;
                case Format.R11G11B10_Float:
                    return PixelFormat.R11_G11_B10_Float;

                default:
                    return InvalidFormat;
            }
        }
        public static PixelFormat NativeToVeldridFormat(VkFormat vkFormat)
        {
            switch(vkFormat)
            {
                case VkFormat.R8Unorm:
                    return PixelFormat.R8_UNorm;
                case VkFormat.R8Snorm:
                    return PixelFormat.R8_SNorm;
                case VkFormat.R8Uint:
                    return PixelFormat.R8_UInt;
                case VkFormat.R8Sint:
                    return PixelFormat.R8_SInt;

                case VkFormat.R16Unorm:
                    return PixelFormat.R16_UNorm;
                case VkFormat.R16Snorm:
                    return PixelFormat.R16_SNorm;
                case VkFormat.R16Uint:
                    return PixelFormat.R16_UInt;
                case VkFormat.R16Sint:
                    return PixelFormat.R16_SInt;
                case VkFormat.R16Sfloat:
                    return PixelFormat.R16_Float;

                case VkFormat.R32Uint:
                    return PixelFormat.R32_UInt;
                case VkFormat.R32Sint:
                    return PixelFormat.R32_SInt;
                case VkFormat.R32Sfloat:
                case VkFormat.D32Sfloat:
                    return PixelFormat.R32_Float;

                case VkFormat.R8g8Unorm:
                    return PixelFormat.R8_G8_UNorm;
                case VkFormat.R8g8Snorm:
                    return PixelFormat.R8_G8_SNorm;
                case VkFormat.R8g8Uint:
                    return PixelFormat.R8_G8_UInt;
                case VkFormat.R8g8Sint:
                    return PixelFormat.R8_G8_SInt;

                case VkFormat.R16g16Unorm:
                    return PixelFormat.R16_G16_UNorm;
                case VkFormat.R16g16Snorm:
                    return PixelFormat.R16_G16_SNorm;
                case VkFormat.R16g16Uint:
                    return PixelFormat.R16_G16_UInt;
                case VkFormat.R16g16Sint:
                    return PixelFormat.R16_G16_SInt;
                case VkFormat.R16g16Sfloat:
                    return PixelFormat.R16_G16_Float;

                case VkFormat.R32g32Uint:
                    return PixelFormat.R32_G32_UInt;
                case VkFormat.R32g32Sint:
                    return PixelFormat.R32_G32_SInt;
                case VkFormat.R32g32Sfloat:
                    return PixelFormat.R32_G32_Float;

                case VkFormat.R8g8b8a8Unorm:
                    return PixelFormat.R8_G8_B8_A8_UNorm;
                case VkFormat.R8g8b8a8Srgb:
                    return PixelFormat.R8_G8_B8_A8_UNorm_SRgb;
                case VkFormat.B8g8r8a8Unorm:
                    return PixelFormat.B8_G8_R8_A8_UNorm;
                case VkFormat.B8g8r8a8Srgb:
                    return PixelFormat.B8_G8_R8_A8_UNorm_SRgb;
                case VkFormat.R8g8b8a8Snorm:
                    return PixelFormat.R8_G8_B8_A8_SNorm;
                case VkFormat.R8g8b8a8Uint:
                    return PixelFormat.R8_G8_B8_A8_UInt;
                case VkFormat.R8g8b8a8Sint:
                    return PixelFormat.R8_G8_B8_A8_SInt;

                case VkFormat.R16g16b16a16Unorm:
                    return PixelFormat.R16_G16_B16_A16_UNorm;
                case VkFormat.R16g16b16a16Snorm:
                    return PixelFormat.R16_G16_B16_A16_SNorm;
                case VkFormat.R16g16b16a16Uint:
                    return PixelFormat.R16_G16_B16_A16_UInt;
                case VkFormat.R16g16b16a16Sint:
                    return PixelFormat.R16_G16_B16_A16_SInt;
                case VkFormat.R16g16b16a16Sfloat:
                    return PixelFormat.R16_G16_B16_A16_Float;

                case VkFormat.R32g32b32a32Uint:
                    return PixelFormat.R32_G32_B32_A32_UInt;
                case VkFormat.R32g32b32a32Sint:
                    return PixelFormat.R32_G32_B32_A32_SInt;
                case VkFormat.R32g32b32a32Sfloat:
                    return PixelFormat.R32_G32_B32_A32_Float;

                case VkFormat.Bc1RgbUnormBlock:
                    return PixelFormat.BC1_Rgb_UNorm;
                case VkFormat.Bc1RgbSrgbBlock:
                    return PixelFormat.BC1_Rgb_UNorm_SRgb;
                case VkFormat.Bc1RgbaUnormBlock:
                    return PixelFormat.BC1_Rgba_UNorm;
                case VkFormat.Bc1RgbaSrgbBlock:
                    return PixelFormat.BC1_Rgba_UNorm_SRgb;
                case VkFormat.Bc2UnormBlock:
                    return PixelFormat.BC2_UNorm;
                case VkFormat.Bc2SrgbBlock:
                    return PixelFormat.BC2_UNorm_SRgb;
                case VkFormat.Bc3UnormBlock:
                    return PixelFormat.BC3_UNorm;
                case VkFormat.Bc3SrgbBlock:
                    return PixelFormat.BC3_UNorm_SRgb;
                case VkFormat.Bc4UnormBlock:
                    return PixelFormat.BC4_UNorm;
                case VkFormat.Bc4SnormBlock:
                    return PixelFormat.BC4_SNorm;
                case VkFormat.Bc5UnormBlock:
                    return PixelFormat.BC5_UNorm;
                case VkFormat.Bc5SnormBlock:
                    return PixelFormat.BC5_SNorm;
                case VkFormat.Bc7UnormBlock:
                    return PixelFormat.BC7_UNorm;
                case VkFormat.Bc7SrgbBlock:
                    return PixelFormat.BC7_UNorm_SRgb;

                case VkFormat.A2b10g10r10UnormPack32:
                    return PixelFormat.R10_G10_B10_A2_UNorm;
                case VkFormat.A2b10g10r10UintPack32:
                    return PixelFormat.R10_G10_B10_A2_UInt;
                case VkFormat.B10g11r11UfloatPack32:
                    return PixelFormat.R11_G11_B10_Float;

                case VkFormat.D16Unorm:
                    return PixelFormat.R16_UNorm;
                case VkFormat.D24UnormS8Uint:
                    return PixelFormat.D24_UNorm_S8_UInt;
                case VkFormat.D32SfloatS8Uint:
                    return PixelFormat.D32_Float_S8_UInt;

                default:
                    return InvalidFormat;
            }
        }
        #endregion
        #region VeldridFormatToNative
        public static long VeldridToNativeFormat(PixelFormat format, GraphicsBackend backend, bool toDepthFormat)
        {
            try
            {
                return backend switch
                {
                    GraphicsBackend.Direct3D11 => (long)D3D11Formats.ToDxgiFormat(format, toDepthFormat),
                    GraphicsBackend.Vulkan => (long)VkFormats.VdToVkPixelFormat(format, toDepthFormat),
                    _ => -1,
                };
            }
            catch
            {
                return -1;
            }
        }
        #endregion
#pragma warning restore IDE0066 // Convert switch statement to expression
    }
}
