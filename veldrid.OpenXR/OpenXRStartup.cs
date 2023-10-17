using Veldrid.OpenXR.Native;
using Veldrid.OpenXR.Vk;
using Veldrid.Vk;
using Vulkan;
using static Veldrid.OpenXR.Native.OpenXRNative;

namespace Veldrid.OpenXR;
public static partial class OpenXRUtils
{
    public static GraphicsDevice CreateGraphicsDevice(XrInstance instance, ulong systemID, GraphicsDeviceOptions options, GraphicsBackend backend)
    {
        switch (backend)
        {

            case GraphicsBackend.Direct3D11:
#if !EXCLUDE_D3D11_BACKEND
                //return CreateDefaultD3D11GraphicsDevice(options, window);
#else
                    throw new VeldridException("D3D11 support has not been included in this configuration of Veldrid");
#endif
            case GraphicsBackend.Vulkan:
#if !EXCLUDE_VULKAN_BACKEND
                return CreateVulkanGraphicsDevice(instance, systemID, options, out _);
#else
                    throw new VeldridException("Vulkan support has not been included in this configuration of Veldrid");
#endif
        }
    }
#if !EXCLUDE_VULKAN_BACKEND
    public static unsafe GraphicsDevice CreateVulkanGraphicsDevice(XrInstance instance, ulong systemID, GraphicsDeviceOptions options, out XrResult result)
    {
        XrGraphicsRequirementsVulkanKHR graphicsRequirements;
        graphicsRequirements.type = XrStructureType.XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN_KHR;
        graphicsRequirements.next = null;
        result = xrGetVulkanGraphicsRequirementsKHR(instance, systemID, &graphicsRequirements);
        if (result != XrResult.XR_SUCCESS)
            return null;

        string[] GetInstanceExtensions(out XrResult result)
        {
            uint instanceExtensionsSize;
            result = xrGetVulkanInstanceExtensionsKHR(instance, systemID, 0, &instanceExtensionsSize, null);
            if (result != XrResult.XR_SUCCESS)
                return null;

            byte* buffer = stackalloc byte[(int)instanceExtensionsSize];

            result = xrGetVulkanInstanceExtensionsKHR(instance, systemID, instanceExtensionsSize, &instanceExtensionsSize, buffer);
            if (result != XrResult.XR_SUCCESS)
                return null;

            string vkInstanceExtensionsData = GetString(buffer);
            int vkExtCount = 0;
            for (int i = 0; i <= instanceExtensionsSize; i++)
                if (i == instanceExtensionsSize || buffer[i] == ' ')
                    vkExtCount++;
            string[] vkInstanceExtensions = new string[vkExtCount];

            int vkExtIndex = 0;
            int last = 0;
            for (int i = 0; i <= vkInstanceExtensionsData.Length; i++)
            {
                if (i == vkInstanceExtensionsData.Length || vkInstanceExtensionsData[i] == ' ')
                {
                    vkInstanceExtensions[vkExtIndex++] = vkInstanceExtensionsData[last..(i - last)];
                    last = i + 1;
                }
            }
            return vkInstanceExtensions;
        }
        string[] GetDeviceExtensions(VkInstance vulkanInstance, out XrResult result, out VkPhysicalDevice physicalDevice)
        {
            VkPhysicalDevice device = VkPhysicalDevice.Null;
            result = xrGetVulkanGraphicsDeviceKHR(instance, systemID, vulkanInstance.Handle, (IntPtr)&device);
            physicalDevice = device;
        }
        string[] vkinstexts = GetInstanceExtensions(out result);
        if (result != XrResult.XR_SUCCESS)
            return null;
        string[] vkdevexts = GetDeviceExtensions(out result, out VkPhysicalDevice physicalDevice);
        if (result != XrResult.XR_SUCCESS)
            return null;
        VulkanDeviceOptions deviceOptions = new(vkinstexts, vkdevexts);

        return new XrVkGraphicsDevice(options, null, deviceOptions, physicalDevice);
    }
#endif
}