using System;
using System.Runtime.InteropServices;

namespace Veldrid.OpenXR.Native;
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVector2f
{
    public float x;
    public float y;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVector3f
{
    public float x;
    public float y;
    public float z;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVector4f
{
    public float x;
    public float y;
    public float z;
    public float w;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrColor4f
{
    public float r;
    public float g;
    public float b;
    public float a;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrQuaternionf
{
    public float x;
    public float y;
    public float z;
    public float w;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPosef
{
    public XrQuaternionf orientation;
    public XrVector3f position;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrOffset2Df
{
    public float x;
    public float y;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrExtent2Df
{
    public float width;
    public float height;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrExtent3DfEXT
{
    public float width;
    public float height;
    public float depth;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrRect2Df
{
    public XrOffset2Df offset;
    public XrExtent2Df extent;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrOffset2Di
{
    public int x;
    public int y;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrExtent2Di
{
    public int width;
    public int height;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrRect2Di
{
    public XrOffset2Di offset;
    public XrExtent2Di extent;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBaseInStructure
{
    public XrStructureType type;
    public XrBaseInStructure* next;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBaseOutStructure
{
    public XrStructureType type;
    public XrBaseOutStructure* next;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrApiLayerProperties
{
    public XrStructureType type;
    public void* next;
    public fixed byte layerName[(int)OpenXRNative.XR_MAX_API_LAYER_NAME_SIZE];
    public ulong specVersion;
    public uint layerVersion;
    public fixed byte description[(int)OpenXRNative.XR_MAX_API_LAYER_DESCRIPTION_SIZE];
    /// <returns>a new <see cref="XrApiLayerProperties"> with it's type member set to <see cref="XrStructureType.XR_TYPE_API_LAYER_PROPERTIES"/></returns>
    public static XrApiLayerProperties New() =>
        new() { type = XrStructureType.XR_TYPE_API_LAYER_PROPERTIES };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrExtensionProperties
{
    public XrStructureType type;
    public void* next;
    public fixed byte extensionName[(int)OpenXRNative.XR_MAX_EXTENSION_NAME_SIZE];
    public uint extensionVersion;
    /// <returns>a new <see cref="XrExtensionProperties"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EXTENSION_PROPERTIES"/></returns>
    public static XrExtensionProperties New() =>
        new() { type = XrStructureType.XR_TYPE_EXTENSION_PROPERTIES };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrApplicationInfo
{
    public fixed byte applicationName[(int)OpenXRNative.XR_MAX_APPLICATION_NAME_SIZE];
    public uint applicationVersion;
    public fixed byte engineName[(int)OpenXRNative.XR_MAX_ENGINE_NAME_SIZE];
    public uint engineVersion;
    public ulong apiVersion;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrInstanceCreateInfo
{
    public XrStructureType type;
    public void* next;
    public ulong createFlags;
    public XrApplicationInfo applicationInfo;
    public uint enabledApiLayerCount;
    public byte** enabledApiLayerNames;
    public uint enabledExtensionCount;
    public byte** enabledExtensionNames;
    /// <returns>a new <see cref="XrInstanceCreateInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_INSTANCE_CREATE_INFO"/></returns>
    public static XrInstanceCreateInfo New() =>
        new() { type = XrStructureType.XR_TYPE_INSTANCE_CREATE_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrInstanceProperties
{
    public XrStructureType type;
    public void* next;
    public ulong runtimeVersion;
    public fixed byte runtimeName[(int)OpenXRNative.XR_MAX_RUNTIME_NAME_SIZE];
    /// <returns>a new <see cref="XrInstanceProperties"> with it's type member set to <see cref="XrStructureType.XR_TYPE_INSTANCE_PROPERTIES"/></returns>
    public static XrInstanceProperties New() =>
        new() { type = XrStructureType.XR_TYPE_INSTANCE_PROPERTIES };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemGetInfo
{
    public XrStructureType type;
    public void* next;
    public XrFormFactor formFactor;
    /// <returns>a new <see cref="XrSystemGetInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_GET_INFO"/></returns>
    public static XrSystemGetInfo New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_GET_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemProperties
{
    public XrStructureType type;
    public void* next;
    public ulong systemId;
    public uint vendorId;
    public fixed byte systemName[(int)OpenXRNative.XR_MAX_SYSTEM_NAME_SIZE];
    public XrSystemGraphicsProperties graphicsProperties;
    public XrSystemTrackingProperties trackingProperties;
    /// <returns>a new <see cref="XrSystemProperties"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_PROPERTIES"/></returns>
    public static XrSystemProperties New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_PROPERTIES };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemGraphicsProperties
{
    public uint maxSwapchainImageHeight;
    public uint maxSwapchainImageWidth;
    public uint maxLayerCount;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemTrackingProperties
{
    public XrBool32 orientationTracking;
    public XrBool32 positionTracking;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsBindingOpenGLWin32KHR
{
    public XrStructureType type;
    public void* next;
    public nint hDC;
    public nint hGLRC;
    /// <returns>a new <see cref="XrGraphicsBindingOpenGLWin32KHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_BINDING_OPENGL_WIN32_KHR"/></returns>
    public static XrGraphicsBindingOpenGLWin32KHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_OPENGL_WIN32_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsBindingOpenGLXlibKHR
{
    public XrStructureType type;
    public void* next;
    public nint* xDisplay;
    public uint visualid;
    public nint glxFBConfig;
    public nint glxDrawable;
    public nint glxContext;
    /// <returns>a new <see cref="XrGraphicsBindingOpenGLXlibKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_BINDING_OPENGL_XLIB_KHR"/></returns>
    public static XrGraphicsBindingOpenGLXlibKHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_OPENGL_XLIB_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsBindingOpenGLXcbKHR
{
    public XrStructureType type;
    public void* next;
    public nint* connection;
    public uint screenNumber;
    public nint fbconfigid;
    public nint visualid;
    public nint glxDrawable;
    public nint glxContext;
    /// <returns>a new <see cref="XrGraphicsBindingOpenGLXcbKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_BINDING_OPENGL_XCB_KHR"/></returns>
    public static XrGraphicsBindingOpenGLXcbKHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_OPENGL_XCB_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsBindingOpenGLWaylandKHR
{
    public XrStructureType type;
    public void* next;
    public nint* display;
    /// <returns>a new <see cref="XrGraphicsBindingOpenGLWaylandKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_BINDING_OPENGL_WAYLAND_KHR"/></returns>
    public static XrGraphicsBindingOpenGLWaylandKHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_OPENGL_WAYLAND_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsBindingD3D11KHR
{
    public XrStructureType type;
    public void* next;
    public nint* device;
    /// <returns>a new <see cref="XrGraphicsBindingD3D11KHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_BINDING_D3D11_KHR"/></returns>
    public static XrGraphicsBindingD3D11KHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_D3D11_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsBindingD3D12KHR
{
    public XrStructureType type;
    public void* next;
    public nint* device;
    public nint* queue;
    /// <returns>a new <see cref="XrGraphicsBindingD3D12KHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_BINDING_D3D12_KHR"/></returns>
    public static XrGraphicsBindingD3D12KHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_D3D12_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsBindingOpenGLESAndroidKHR
{
    public XrStructureType type;
    public void* next;
    public nint display;
    public nint config;
    public nint context;
    /// <returns>a new <see cref="XrGraphicsBindingOpenGLESAndroidKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_BINDING_OPENGL_ES_ANDROID_KHR"/></returns>
    public static XrGraphicsBindingOpenGLESAndroidKHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_OPENGL_ES_ANDROID_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsBindingVulkanKHR
{
    public XrStructureType type;
    public void* next;
    public nint instance;
    public nint physicalDevice;
    public nint device;
    public uint queueFamilyIndex;
    public uint queueIndex;
    /// <returns>a new <see cref="XrGraphicsBindingVulkanKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR"/></returns>
    public static XrGraphicsBindingVulkanKHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSessionCreateInfo
{
    public XrStructureType type;
    public void* next;
    public ulong createFlags;
    public ulong systemId;
    /// <returns>a new <see cref="XrSessionCreateInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SESSION_CREATE_INFO"/></returns>
    public static XrSessionCreateInfo New() =>
        new() { type = XrStructureType.XR_TYPE_SESSION_CREATE_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSessionBeginInfo
{
    public XrStructureType type;
    public void* next;
    public XrViewConfigurationType primaryViewConfigurationType;
    /// <returns>a new <see cref="XrSessionBeginInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SESSION_BEGIN_INFO"/></returns>
    public static XrSessionBeginInfo New() =>
        new() { type = XrStructureType.XR_TYPE_SESSION_BEGIN_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainCreateInfo
{
    public XrStructureType type;
    public void* next;
    public ulong createFlags;
    public ulong usageFlags;
    public long format;
    public uint sampleCount;
    public uint width;
    public uint height;
    public uint faceCount;
    public uint arraySize;
    public uint mipCount;
    /// <returns>a new <see cref="XrSwapchainCreateInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_CREATE_INFO"/></returns>
    public static XrSwapchainCreateInfo New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_CREATE_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainImageBaseHeader
{
    public XrStructureType type;
    public void* next;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainImageOpenGLKHR
{
    public XrStructureType type;
    public void* next;
    public uint image;
    /// <returns>a new <see cref="XrSwapchainImageOpenGLKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_KHR"/></returns>
    public static XrSwapchainImageOpenGLKHR New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainImageOpenGLESKHR
{
    public XrStructureType type;
    public void* next;
    public uint image;
    /// <returns>a new <see cref="XrSwapchainImageOpenGLESKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_ES_KHR"/></returns>
    public static XrSwapchainImageOpenGLESKHR New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_ES_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainImageVulkanKHR
{
    public XrStructureType type;
    public void* next;
    public nint image;
    /// <returns>a new <see cref="XrSwapchainImageVulkanKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_VULKAN_KHR"/></returns>
    public static XrSwapchainImageVulkanKHR New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_VULKAN_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainImageD3D11KHR
{
    public XrStructureType type;
    public void* next;
    public nint* texture;
    /// <returns>a new <see cref="XrSwapchainImageD3D11KHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_D3D11_KHR"/></returns>
    public static XrSwapchainImageD3D11KHR New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_D3D11_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainImageD3D12KHR
{
    public XrStructureType type;
    public void* next;
    public nint* texture;
    /// <returns>a new <see cref="XrSwapchainImageD3D12KHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_D3D12_KHR"/></returns>
    public static XrSwapchainImageD3D12KHR New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_D3D12_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainImageAcquireInfo
{
    public XrStructureType type;
    public void* next;
    /// <returns>a new <see cref="XrSwapchainImageAcquireInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_ACQUIRE_INFO"/></returns>
    public static XrSwapchainImageAcquireInfo New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_ACQUIRE_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainImageWaitInfo
{
    public XrStructureType type;
    public void* next;
    public long timeout;
    /// <returns>a new <see cref="XrSwapchainImageWaitInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_WAIT_INFO"/></returns>
    public static XrSwapchainImageWaitInfo New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_WAIT_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainImageReleaseInfo
{
    public XrStructureType type;
    public void* next;
    /// <returns>a new <see cref="XrSwapchainImageReleaseInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_RELEASE_INFO"/></returns>
    public static XrSwapchainImageReleaseInfo New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_RELEASE_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrReferenceSpaceCreateInfo
{
    public XrStructureType type;
    public void* next;
    public XrReferenceSpaceType referenceSpaceType;
    public XrPosef poseInReferenceSpace;
    /// <returns>a new <see cref="XrReferenceSpaceCreateInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_REFERENCE_SPACE_CREATE_INFO"/></returns>
    public static XrReferenceSpaceCreateInfo New() =>
        new() { type = XrStructureType.XR_TYPE_REFERENCE_SPACE_CREATE_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActionSpaceCreateInfo
{
    public XrStructureType type;
    public void* next;
    public XrAction action;
    public ulong subactionPath;
    public XrPosef poseInActionSpace;
    /// <returns>a new <see cref="XrActionSpaceCreateInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ACTION_SPACE_CREATE_INFO"/></returns>
    public static XrActionSpaceCreateInfo New() =>
        new() { type = XrStructureType.XR_TYPE_ACTION_SPACE_CREATE_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceLocation
{
    public XrStructureType type;
    public void* next;
    public ulong locationFlags;
    public XrPosef pose;
    /// <returns>a new <see cref="XrSpaceLocation"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_LOCATION"/></returns>
    public static XrSpaceLocation New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_LOCATION };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceVelocity
{
    public XrStructureType type;
    public void* next;
    public ulong velocityFlags;
    public XrVector3f linearVelocity;
    public XrVector3f angularVelocity;
    /// <returns>a new <see cref="XrSpaceVelocity"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_VELOCITY"/></returns>
    public static XrSpaceVelocity New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_VELOCITY };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFovf
{
    public float angleLeft;
    public float angleRight;
    public float angleUp;
    public float angleDown;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrView
{
    public XrStructureType type;
    public void* next;
    public XrPosef pose;
    public XrFovf fov;
    /// <returns>a new <see cref="XrView"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIEW"/></returns>
    public static XrView New() =>
        new() { type = XrStructureType.XR_TYPE_VIEW };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrViewLocateInfo
{
    public XrStructureType type;
    public void* next;
    public XrViewConfigurationType viewConfigurationType;
    public long displayTime;
    public XrSpace space;
    /// <returns>a new <see cref="XrViewLocateInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIEW_LOCATE_INFO"/></returns>
    public static XrViewLocateInfo New() =>
        new() { type = XrStructureType.XR_TYPE_VIEW_LOCATE_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrViewState
{
    public XrStructureType type;
    public void* next;
    public ulong viewStateFlags;
    /// <returns>a new <see cref="XrViewState"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIEW_STATE"/></returns>
    public static XrViewState New() =>
        new() { type = XrStructureType.XR_TYPE_VIEW_STATE };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrViewConfigurationView
{
    public XrStructureType type;
    public void* next;
    public uint recommendedImageRectWidth;
    public uint maxImageRectWidth;
    public uint recommendedImageRectHeight;
    public uint maxImageRectHeight;
    public uint recommendedSwapchainSampleCount;
    public uint maxSwapchainSampleCount;
    /// <returns>a new <see cref="XrViewConfigurationView"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIEW_CONFIGURATION_VIEW"/></returns>
    public static XrViewConfigurationView New() =>
        new() { type = XrStructureType.XR_TYPE_VIEW_CONFIGURATION_VIEW };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainSubImage
{
    public XrSwapchain swapchain;
    public XrRect2Di imageRect;
    public uint imageArrayIndex;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerBaseHeader
{
    public XrStructureType type;
    public void* next;
    public ulong layerFlags;
    public XrSpace space;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerProjectionView
{
    public XrStructureType type;
    public void* next;
    public XrPosef pose;
    public XrFovf fov;
    public XrSwapchainSubImage subImage;
    /// <returns>a new <see cref="XrCompositionLayerProjectionView"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_PROJECTION_VIEW"/></returns>
    public static XrCompositionLayerProjectionView New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_PROJECTION_VIEW };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerProjection
{
    public XrStructureType type;
    public void* next;
    public ulong layerFlags;
    public XrSpace space;
    public uint viewCount;
    public XrCompositionLayerProjectionView* views;
    /// <returns>a new <see cref="XrCompositionLayerProjection"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_PROJECTION"/></returns>
    public static XrCompositionLayerProjection New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_PROJECTION };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerQuad
{
    public XrStructureType type;
    public void* next;
    public ulong layerFlags;
    public XrSpace space;
    public XrEyeVisibility eyeVisibility;
    public XrSwapchainSubImage subImage;
    public XrPosef pose;
    public XrExtent2Df size;
    /// <returns>a new <see cref="XrCompositionLayerQuad"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_QUAD"/></returns>
    public static XrCompositionLayerQuad New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_QUAD };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerCylinderKHR
{
    public XrStructureType type;
    public void* next;
    public ulong layerFlags;
    public XrSpace space;
    public XrEyeVisibility eyeVisibility;
    public XrSwapchainSubImage subImage;
    public XrPosef pose;
    public float radius;
    public float centralAngle;
    public float aspectRatio;
    /// <returns>a new <see cref="XrCompositionLayerCylinderKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_CYLINDER_KHR"/></returns>
    public static XrCompositionLayerCylinderKHR New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_CYLINDER_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerCubeKHR
{
    public XrStructureType type;
    public void* next;
    public ulong layerFlags;
    public XrSpace space;
    public XrEyeVisibility eyeVisibility;
    public XrSwapchain swapchain;
    public uint imageArrayIndex;
    public XrQuaternionf orientation;
    /// <returns>a new <see cref="XrCompositionLayerCubeKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_CUBE_KHR"/></returns>
    public static XrCompositionLayerCubeKHR New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_CUBE_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerEquirectKHR
{
    public XrStructureType type;
    public void* next;
    public ulong layerFlags;
    public XrSpace space;
    public XrEyeVisibility eyeVisibility;
    public XrSwapchainSubImage subImage;
    public XrPosef pose;
    public float radius;
    public XrVector2f scale;
    public XrVector2f bias;
    /// <returns>a new <see cref="XrCompositionLayerEquirectKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_EQUIRECT_KHR"/></returns>
    public static XrCompositionLayerEquirectKHR New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_EQUIRECT_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerDepthInfoKHR
{
    public XrStructureType type;
    public void* next;
    public XrSwapchainSubImage subImage;
    public float minDepth;
    public float maxDepth;
    public float nearZ;
    public float farZ;
    /// <returns>a new <see cref="XrCompositionLayerDepthInfoKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_DEPTH_INFO_KHR"/></returns>
    public static XrCompositionLayerDepthInfoKHR New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_DEPTH_INFO_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFrameBeginInfo
{
    public XrStructureType type;
    public void* next;
    /// <returns>a new <see cref="XrFrameBeginInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FRAME_BEGIN_INFO"/></returns>
    public static XrFrameBeginInfo New() =>
        new() { type = XrStructureType.XR_TYPE_FRAME_BEGIN_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFrameEndInfo
{
    public XrStructureType type;
    public void* next;
    public long displayTime;
    public XrEnvironmentBlendMode environmentBlendMode;
    public uint layerCount;
    public XrCompositionLayerBaseHeader** layers;
    /// <returns>a new <see cref="XrFrameEndInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FRAME_END_INFO"/></returns>
    public static XrFrameEndInfo New() =>
        new() { type = XrStructureType.XR_TYPE_FRAME_END_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFrameWaitInfo
{
    public XrStructureType type;
    public void* next;
    /// <returns>a new <see cref="XrFrameWaitInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FRAME_WAIT_INFO"/></returns>
    public static XrFrameWaitInfo New() =>
        new() { type = XrStructureType.XR_TYPE_FRAME_WAIT_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFrameState
{
    public XrStructureType type;
    public void* next;
    public long predictedDisplayTime;
    public long predictedDisplayPeriod;
    public XrBool32 shouldRender;
    /// <returns>a new <see cref="XrFrameState"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FRAME_STATE"/></returns>
    public static XrFrameState New() =>
        new() { type = XrStructureType.XR_TYPE_FRAME_STATE };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHapticBaseHeader
{
    public XrStructureType type;
    public void* next;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHapticVibration
{
    public XrStructureType type;
    public void* next;
    public long duration;
    public float frequency;
    public float amplitude;
    /// <returns>a new <see cref="XrHapticVibration"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAPTIC_VIBRATION"/></returns>
    public static XrHapticVibration New() =>
        new() { type = XrStructureType.XR_TYPE_HAPTIC_VIBRATION };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataBaseHeader
{
    public XrStructureType type;
    public void* next;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataBuffer
{
    public XrStructureType type;
    public void* next;
    public byte varying_0;
    public byte varying_1;
    public byte varying_2;
    public byte varying_3;
    public byte varying_4;
    public byte varying_5;
    public byte varying_6;
    public byte varying_7;
    public byte varying_8;
    public byte varying_9;
    public byte varying_10;
    public byte varying_11;
    public byte varying_12;
    public byte varying_13;
    public byte varying_14;
    public byte varying_15;
    public byte varying_16;
    public byte varying_17;
    public byte varying_18;
    public byte varying_19;
    public byte varying_20;
    public byte varying_21;
    public byte varying_22;
    public byte varying_23;
    public byte varying_24;
    public byte varying_25;
    public byte varying_26;
    public byte varying_27;
    public byte varying_28;
    public byte varying_29;
    public byte varying_30;
    public byte varying_31;
    public byte varying_32;
    public byte varying_33;
    public byte varying_34;
    public byte varying_35;
    public byte varying_36;
    public byte varying_37;
    public byte varying_38;
    public byte varying_39;
    public byte varying_40;
    public byte varying_41;
    public byte varying_42;
    public byte varying_43;
    public byte varying_44;
    public byte varying_45;
    public byte varying_46;
    public byte varying_47;
    public byte varying_48;
    public byte varying_49;
    public byte varying_50;
    public byte varying_51;
    public byte varying_52;
    public byte varying_53;
    public byte varying_54;
    public byte varying_55;
    public byte varying_56;
    public byte varying_57;
    public byte varying_58;
    public byte varying_59;
    public byte varying_60;
    public byte varying_61;
    public byte varying_62;
    public byte varying_63;
    public byte varying_64;
    public byte varying_65;
    public byte varying_66;
    public byte varying_67;
    public byte varying_68;
    public byte varying_69;
    public byte varying_70;
    public byte varying_71;
    public byte varying_72;
    public byte varying_73;
    public byte varying_74;
    public byte varying_75;
    public byte varying_76;
    public byte varying_77;
    public byte varying_78;
    public byte varying_79;
    public byte varying_80;
    public byte varying_81;
    public byte varying_82;
    public byte varying_83;
    public byte varying_84;
    public byte varying_85;
    public byte varying_86;
    public byte varying_87;
    public byte varying_88;
    public byte varying_89;
    public byte varying_90;
    public byte varying_91;
    public byte varying_92;
    public byte varying_93;
    public byte varying_94;
    public byte varying_95;
    public byte varying_96;
    public byte varying_97;
    public byte varying_98;
    public byte varying_99;
    public byte varying_100;
    public byte varying_101;
    public byte varying_102;
    public byte varying_103;
    public byte varying_104;
    public byte varying_105;
    public byte varying_106;
    public byte varying_107;
    public byte varying_108;
    public byte varying_109;
    public byte varying_110;
    public byte varying_111;
    public byte varying_112;
    public byte varying_113;
    public byte varying_114;
    public byte varying_115;
    public byte varying_116;
    public byte varying_117;
    public byte varying_118;
    public byte varying_119;
    public byte varying_120;
    public byte varying_121;
    public byte varying_122;
    public byte varying_123;
    public byte varying_124;
    public byte varying_125;
    public byte varying_126;
    public byte varying_127;
    public byte varying_128;
    public byte varying_129;
    public byte varying_130;
    public byte varying_131;
    public byte varying_132;
    public byte varying_133;
    public byte varying_134;
    public byte varying_135;
    public byte varying_136;
    public byte varying_137;
    public byte varying_138;
    public byte varying_139;
    public byte varying_140;
    public byte varying_141;
    public byte varying_142;
    public byte varying_143;
    public byte varying_144;
    public byte varying_145;
    public byte varying_146;
    public byte varying_147;
    public byte varying_148;
    public byte varying_149;
    public byte varying_150;
    public byte varying_151;
    public byte varying_152;
    public byte varying_153;
    public byte varying_154;
    public byte varying_155;
    public byte varying_156;
    public byte varying_157;
    public byte varying_158;
    public byte varying_159;
    public byte varying_160;
    public byte varying_161;
    public byte varying_162;
    public byte varying_163;
    public byte varying_164;
    public byte varying_165;
    public byte varying_166;
    public byte varying_167;
    public byte varying_168;
    public byte varying_169;
    public byte varying_170;
    public byte varying_171;
    public byte varying_172;
    public byte varying_173;
    public byte varying_174;
    public byte varying_175;
    public byte varying_176;
    public byte varying_177;
    public byte varying_178;
    public byte varying_179;
    public byte varying_180;
    public byte varying_181;
    public byte varying_182;
    public byte varying_183;
    public byte varying_184;
    public byte varying_185;
    public byte varying_186;
    public byte varying_187;
    public byte varying_188;
    public byte varying_189;
    public byte varying_190;
    public byte varying_191;
    public byte varying_192;
    public byte varying_193;
    public byte varying_194;
    public byte varying_195;
    public byte varying_196;
    public byte varying_197;
    public byte varying_198;
    public byte varying_199;
    public byte varying_200;
    public byte varying_201;
    public byte varying_202;
    public byte varying_203;
    public byte varying_204;
    public byte varying_205;
    public byte varying_206;
    public byte varying_207;
    public byte varying_208;
    public byte varying_209;
    public byte varying_210;
    public byte varying_211;
    public byte varying_212;
    public byte varying_213;
    public byte varying_214;
    public byte varying_215;
    public byte varying_216;
    public byte varying_217;
    public byte varying_218;
    public byte varying_219;
    public byte varying_220;
    public byte varying_221;
    public byte varying_222;
    public byte varying_223;
    public byte varying_224;
    public byte varying_225;
    public byte varying_226;
    public byte varying_227;
    public byte varying_228;
    public byte varying_229;
    public byte varying_230;
    public byte varying_231;
    public byte varying_232;
    public byte varying_233;
    public byte varying_234;
    public byte varying_235;
    public byte varying_236;
    public byte varying_237;
    public byte varying_238;
    public byte varying_239;
    public byte varying_240;
    public byte varying_241;
    public byte varying_242;
    public byte varying_243;
    public byte varying_244;
    public byte varying_245;
    public byte varying_246;
    public byte varying_247;
    public byte varying_248;
    public byte varying_249;
    public byte varying_250;
    public byte varying_251;
    public byte varying_252;
    public byte varying_253;
    public byte varying_254;
    public byte varying_255;
    public byte varying_256;
    public byte varying_257;
    public byte varying_258;
    public byte varying_259;
    public byte varying_260;
    public byte varying_261;
    public byte varying_262;
    public byte varying_263;
    public byte varying_264;
    public byte varying_265;
    public byte varying_266;
    public byte varying_267;
    public byte varying_268;
    public byte varying_269;
    public byte varying_270;
    public byte varying_271;
    public byte varying_272;
    public byte varying_273;
    public byte varying_274;
    public byte varying_275;
    public byte varying_276;
    public byte varying_277;
    public byte varying_278;
    public byte varying_279;
    public byte varying_280;
    public byte varying_281;
    public byte varying_282;
    public byte varying_283;
    public byte varying_284;
    public byte varying_285;
    public byte varying_286;
    public byte varying_287;
    public byte varying_288;
    public byte varying_289;
    public byte varying_290;
    public byte varying_291;
    public byte varying_292;
    public byte varying_293;
    public byte varying_294;
    public byte varying_295;
    public byte varying_296;
    public byte varying_297;
    public byte varying_298;
    public byte varying_299;
    public byte varying_300;
    public byte varying_301;
    public byte varying_302;
    public byte varying_303;
    public byte varying_304;
    public byte varying_305;
    public byte varying_306;
    public byte varying_307;
    public byte varying_308;
    public byte varying_309;
    public byte varying_310;
    public byte varying_311;
    public byte varying_312;
    public byte varying_313;
    public byte varying_314;
    public byte varying_315;
    public byte varying_316;
    public byte varying_317;
    public byte varying_318;
    public byte varying_319;
    public byte varying_320;
    public byte varying_321;
    public byte varying_322;
    public byte varying_323;
    public byte varying_324;
    public byte varying_325;
    public byte varying_326;
    public byte varying_327;
    public byte varying_328;
    public byte varying_329;
    public byte varying_330;
    public byte varying_331;
    public byte varying_332;
    public byte varying_333;
    public byte varying_334;
    public byte varying_335;
    public byte varying_336;
    public byte varying_337;
    public byte varying_338;
    public byte varying_339;
    public byte varying_340;
    public byte varying_341;
    public byte varying_342;
    public byte varying_343;
    public byte varying_344;
    public byte varying_345;
    public byte varying_346;
    public byte varying_347;
    public byte varying_348;
    public byte varying_349;
    public byte varying_350;
    public byte varying_351;
    public byte varying_352;
    public byte varying_353;
    public byte varying_354;
    public byte varying_355;
    public byte varying_356;
    public byte varying_357;
    public byte varying_358;
    public byte varying_359;
    public byte varying_360;
    public byte varying_361;
    public byte varying_362;
    public byte varying_363;
    public byte varying_364;
    public byte varying_365;
    public byte varying_366;
    public byte varying_367;
    public byte varying_368;
    public byte varying_369;
    public byte varying_370;
    public byte varying_371;
    public byte varying_372;
    public byte varying_373;
    public byte varying_374;
    public byte varying_375;
    public byte varying_376;
    public byte varying_377;
    public byte varying_378;
    public byte varying_379;
    public byte varying_380;
    public byte varying_381;
    public byte varying_382;
    public byte varying_383;
    public byte varying_384;
    public byte varying_385;
    public byte varying_386;
    public byte varying_387;
    public byte varying_388;
    public byte varying_389;
    public byte varying_390;
    public byte varying_391;
    public byte varying_392;
    public byte varying_393;
    public byte varying_394;
    public byte varying_395;
    public byte varying_396;
    public byte varying_397;
    public byte varying_398;
    public byte varying_399;
    public byte varying_400;
    public byte varying_401;
    public byte varying_402;
    public byte varying_403;
    public byte varying_404;
    public byte varying_405;
    public byte varying_406;
    public byte varying_407;
    public byte varying_408;
    public byte varying_409;
    public byte varying_410;
    public byte varying_411;
    public byte varying_412;
    public byte varying_413;
    public byte varying_414;
    public byte varying_415;
    public byte varying_416;
    public byte varying_417;
    public byte varying_418;
    public byte varying_419;
    public byte varying_420;
    public byte varying_421;
    public byte varying_422;
    public byte varying_423;
    public byte varying_424;
    public byte varying_425;
    public byte varying_426;
    public byte varying_427;
    public byte varying_428;
    public byte varying_429;
    public byte varying_430;
    public byte varying_431;
    public byte varying_432;
    public byte varying_433;
    public byte varying_434;
    public byte varying_435;
    public byte varying_436;
    public byte varying_437;
    public byte varying_438;
    public byte varying_439;
    public byte varying_440;
    public byte varying_441;
    public byte varying_442;
    public byte varying_443;
    public byte varying_444;
    public byte varying_445;
    public byte varying_446;
    public byte varying_447;
    public byte varying_448;
    public byte varying_449;
    public byte varying_450;
    public byte varying_451;
    public byte varying_452;
    public byte varying_453;
    public byte varying_454;
    public byte varying_455;
    public byte varying_456;
    public byte varying_457;
    public byte varying_458;
    public byte varying_459;
    public byte varying_460;
    public byte varying_461;
    public byte varying_462;
    public byte varying_463;
    public byte varying_464;
    public byte varying_465;
    public byte varying_466;
    public byte varying_467;
    public byte varying_468;
    public byte varying_469;
    public byte varying_470;
    public byte varying_471;
    public byte varying_472;
    public byte varying_473;
    public byte varying_474;
    public byte varying_475;
    public byte varying_476;
    public byte varying_477;
    public byte varying_478;
    public byte varying_479;
    public byte varying_480;
    public byte varying_481;
    public byte varying_482;
    public byte varying_483;
    public byte varying_484;
    public byte varying_485;
    public byte varying_486;
    public byte varying_487;
    public byte varying_488;
    public byte varying_489;
    public byte varying_490;
    public byte varying_491;
    public byte varying_492;
    public byte varying_493;
    public byte varying_494;
    public byte varying_495;
    public byte varying_496;
    public byte varying_497;
    public byte varying_498;
    public byte varying_499;
    public byte varying_500;
    public byte varying_501;
    public byte varying_502;
    public byte varying_503;
    public byte varying_504;
    public byte varying_505;
    public byte varying_506;
    public byte varying_507;
    public byte varying_508;
    public byte varying_509;
    public byte varying_510;
    public byte varying_511;
    public byte varying_512;
    public byte varying_513;
    public byte varying_514;
    public byte varying_515;
    public byte varying_516;
    public byte varying_517;
    public byte varying_518;
    public byte varying_519;
    public byte varying_520;
    public byte varying_521;
    public byte varying_522;
    public byte varying_523;
    public byte varying_524;
    public byte varying_525;
    public byte varying_526;
    public byte varying_527;
    public byte varying_528;
    public byte varying_529;
    public byte varying_530;
    public byte varying_531;
    public byte varying_532;
    public byte varying_533;
    public byte varying_534;
    public byte varying_535;
    public byte varying_536;
    public byte varying_537;
    public byte varying_538;
    public byte varying_539;
    public byte varying_540;
    public byte varying_541;
    public byte varying_542;
    public byte varying_543;
    public byte varying_544;
    public byte varying_545;
    public byte varying_546;
    public byte varying_547;
    public byte varying_548;
    public byte varying_549;
    public byte varying_550;
    public byte varying_551;
    public byte varying_552;
    public byte varying_553;
    public byte varying_554;
    public byte varying_555;
    public byte varying_556;
    public byte varying_557;
    public byte varying_558;
    public byte varying_559;
    public byte varying_560;
    public byte varying_561;
    public byte varying_562;
    public byte varying_563;
    public byte varying_564;
    public byte varying_565;
    public byte varying_566;
    public byte varying_567;
    public byte varying_568;
    public byte varying_569;
    public byte varying_570;
    public byte varying_571;
    public byte varying_572;
    public byte varying_573;
    public byte varying_574;
    public byte varying_575;
    public byte varying_576;
    public byte varying_577;
    public byte varying_578;
    public byte varying_579;
    public byte varying_580;
    public byte varying_581;
    public byte varying_582;
    public byte varying_583;
    public byte varying_584;
    public byte varying_585;
    public byte varying_586;
    public byte varying_587;
    public byte varying_588;
    public byte varying_589;
    public byte varying_590;
    public byte varying_591;
    public byte varying_592;
    public byte varying_593;
    public byte varying_594;
    public byte varying_595;
    public byte varying_596;
    public byte varying_597;
    public byte varying_598;
    public byte varying_599;
    public byte varying_600;
    public byte varying_601;
    public byte varying_602;
    public byte varying_603;
    public byte varying_604;
    public byte varying_605;
    public byte varying_606;
    public byte varying_607;
    public byte varying_608;
    public byte varying_609;
    public byte varying_610;
    public byte varying_611;
    public byte varying_612;
    public byte varying_613;
    public byte varying_614;
    public byte varying_615;
    public byte varying_616;
    public byte varying_617;
    public byte varying_618;
    public byte varying_619;
    public byte varying_620;
    public byte varying_621;
    public byte varying_622;
    public byte varying_623;
    public byte varying_624;
    public byte varying_625;
    public byte varying_626;
    public byte varying_627;
    public byte varying_628;
    public byte varying_629;
    public byte varying_630;
    public byte varying_631;
    public byte varying_632;
    public byte varying_633;
    public byte varying_634;
    public byte varying_635;
    public byte varying_636;
    public byte varying_637;
    public byte varying_638;
    public byte varying_639;
    public byte varying_640;
    public byte varying_641;
    public byte varying_642;
    public byte varying_643;
    public byte varying_644;
    public byte varying_645;
    public byte varying_646;
    public byte varying_647;
    public byte varying_648;
    public byte varying_649;
    public byte varying_650;
    public byte varying_651;
    public byte varying_652;
    public byte varying_653;
    public byte varying_654;
    public byte varying_655;
    public byte varying_656;
    public byte varying_657;
    public byte varying_658;
    public byte varying_659;
    public byte varying_660;
    public byte varying_661;
    public byte varying_662;
    public byte varying_663;
    public byte varying_664;
    public byte varying_665;
    public byte varying_666;
    public byte varying_667;
    public byte varying_668;
    public byte varying_669;
    public byte varying_670;
    public byte varying_671;
    public byte varying_672;
    public byte varying_673;
    public byte varying_674;
    public byte varying_675;
    public byte varying_676;
    public byte varying_677;
    public byte varying_678;
    public byte varying_679;
    public byte varying_680;
    public byte varying_681;
    public byte varying_682;
    public byte varying_683;
    public byte varying_684;
    public byte varying_685;
    public byte varying_686;
    public byte varying_687;
    public byte varying_688;
    public byte varying_689;
    public byte varying_690;
    public byte varying_691;
    public byte varying_692;
    public byte varying_693;
    public byte varying_694;
    public byte varying_695;
    public byte varying_696;
    public byte varying_697;
    public byte varying_698;
    public byte varying_699;
    public byte varying_700;
    public byte varying_701;
    public byte varying_702;
    public byte varying_703;
    public byte varying_704;
    public byte varying_705;
    public byte varying_706;
    public byte varying_707;
    public byte varying_708;
    public byte varying_709;
    public byte varying_710;
    public byte varying_711;
    public byte varying_712;
    public byte varying_713;
    public byte varying_714;
    public byte varying_715;
    public byte varying_716;
    public byte varying_717;
    public byte varying_718;
    public byte varying_719;
    public byte varying_720;
    public byte varying_721;
    public byte varying_722;
    public byte varying_723;
    public byte varying_724;
    public byte varying_725;
    public byte varying_726;
    public byte varying_727;
    public byte varying_728;
    public byte varying_729;
    public byte varying_730;
    public byte varying_731;
    public byte varying_732;
    public byte varying_733;
    public byte varying_734;
    public byte varying_735;
    public byte varying_736;
    public byte varying_737;
    public byte varying_738;
    public byte varying_739;
    public byte varying_740;
    public byte varying_741;
    public byte varying_742;
    public byte varying_743;
    public byte varying_744;
    public byte varying_745;
    public byte varying_746;
    public byte varying_747;
    public byte varying_748;
    public byte varying_749;
    public byte varying_750;
    public byte varying_751;
    public byte varying_752;
    public byte varying_753;
    public byte varying_754;
    public byte varying_755;
    public byte varying_756;
    public byte varying_757;
    public byte varying_758;
    public byte varying_759;
    public byte varying_760;
    public byte varying_761;
    public byte varying_762;
    public byte varying_763;
    public byte varying_764;
    public byte varying_765;
    public byte varying_766;
    public byte varying_767;
    public byte varying_768;
    public byte varying_769;
    public byte varying_770;
    public byte varying_771;
    public byte varying_772;
    public byte varying_773;
    public byte varying_774;
    public byte varying_775;
    public byte varying_776;
    public byte varying_777;
    public byte varying_778;
    public byte varying_779;
    public byte varying_780;
    public byte varying_781;
    public byte varying_782;
    public byte varying_783;
    public byte varying_784;
    public byte varying_785;
    public byte varying_786;
    public byte varying_787;
    public byte varying_788;
    public byte varying_789;
    public byte varying_790;
    public byte varying_791;
    public byte varying_792;
    public byte varying_793;
    public byte varying_794;
    public byte varying_795;
    public byte varying_796;
    public byte varying_797;
    public byte varying_798;
    public byte varying_799;
    public byte varying_800;
    public byte varying_801;
    public byte varying_802;
    public byte varying_803;
    public byte varying_804;
    public byte varying_805;
    public byte varying_806;
    public byte varying_807;
    public byte varying_808;
    public byte varying_809;
    public byte varying_810;
    public byte varying_811;
    public byte varying_812;
    public byte varying_813;
    public byte varying_814;
    public byte varying_815;
    public byte varying_816;
    public byte varying_817;
    public byte varying_818;
    public byte varying_819;
    public byte varying_820;
    public byte varying_821;
    public byte varying_822;
    public byte varying_823;
    public byte varying_824;
    public byte varying_825;
    public byte varying_826;
    public byte varying_827;
    public byte varying_828;
    public byte varying_829;
    public byte varying_830;
    public byte varying_831;
    public byte varying_832;
    public byte varying_833;
    public byte varying_834;
    public byte varying_835;
    public byte varying_836;
    public byte varying_837;
    public byte varying_838;
    public byte varying_839;
    public byte varying_840;
    public byte varying_841;
    public byte varying_842;
    public byte varying_843;
    public byte varying_844;
    public byte varying_845;
    public byte varying_846;
    public byte varying_847;
    public byte varying_848;
    public byte varying_849;
    public byte varying_850;
    public byte varying_851;
    public byte varying_852;
    public byte varying_853;
    public byte varying_854;
    public byte varying_855;
    public byte varying_856;
    public byte varying_857;
    public byte varying_858;
    public byte varying_859;
    public byte varying_860;
    public byte varying_861;
    public byte varying_862;
    public byte varying_863;
    public byte varying_864;
    public byte varying_865;
    public byte varying_866;
    public byte varying_867;
    public byte varying_868;
    public byte varying_869;
    public byte varying_870;
    public byte varying_871;
    public byte varying_872;
    public byte varying_873;
    public byte varying_874;
    public byte varying_875;
    public byte varying_876;
    public byte varying_877;
    public byte varying_878;
    public byte varying_879;
    public byte varying_880;
    public byte varying_881;
    public byte varying_882;
    public byte varying_883;
    public byte varying_884;
    public byte varying_885;
    public byte varying_886;
    public byte varying_887;
    public byte varying_888;
    public byte varying_889;
    public byte varying_890;
    public byte varying_891;
    public byte varying_892;
    public byte varying_893;
    public byte varying_894;
    public byte varying_895;
    public byte varying_896;
    public byte varying_897;
    public byte varying_898;
    public byte varying_899;
    public byte varying_900;
    public byte varying_901;
    public byte varying_902;
    public byte varying_903;
    public byte varying_904;
    public byte varying_905;
    public byte varying_906;
    public byte varying_907;
    public byte varying_908;
    public byte varying_909;
    public byte varying_910;
    public byte varying_911;
    public byte varying_912;
    public byte varying_913;
    public byte varying_914;
    public byte varying_915;
    public byte varying_916;
    public byte varying_917;
    public byte varying_918;
    public byte varying_919;
    public byte varying_920;
    public byte varying_921;
    public byte varying_922;
    public byte varying_923;
    public byte varying_924;
    public byte varying_925;
    public byte varying_926;
    public byte varying_927;
    public byte varying_928;
    public byte varying_929;
    public byte varying_930;
    public byte varying_931;
    public byte varying_932;
    public byte varying_933;
    public byte varying_934;
    public byte varying_935;
    public byte varying_936;
    public byte varying_937;
    public byte varying_938;
    public byte varying_939;
    public byte varying_940;
    public byte varying_941;
    public byte varying_942;
    public byte varying_943;
    public byte varying_944;
    public byte varying_945;
    public byte varying_946;
    public byte varying_947;
    public byte varying_948;
    public byte varying_949;
    public byte varying_950;
    public byte varying_951;
    public byte varying_952;
    public byte varying_953;
    public byte varying_954;
    public byte varying_955;
    public byte varying_956;
    public byte varying_957;
    public byte varying_958;
    public byte varying_959;
    public byte varying_960;
    public byte varying_961;
    public byte varying_962;
    public byte varying_963;
    public byte varying_964;
    public byte varying_965;
    public byte varying_966;
    public byte varying_967;
    public byte varying_968;
    public byte varying_969;
    public byte varying_970;
    public byte varying_971;
    public byte varying_972;
    public byte varying_973;
    public byte varying_974;
    public byte varying_975;
    public byte varying_976;
    public byte varying_977;
    public byte varying_978;
    public byte varying_979;
    public byte varying_980;
    public byte varying_981;
    public byte varying_982;
    public byte varying_983;
    public byte varying_984;
    public byte varying_985;
    public byte varying_986;
    public byte varying_987;
    public byte varying_988;
    public byte varying_989;
    public byte varying_990;
    public byte varying_991;
    public byte varying_992;
    public byte varying_993;
    public byte varying_994;
    public byte varying_995;
    public byte varying_996;
    public byte varying_997;
    public byte varying_998;
    public byte varying_999;
    public byte varying_1000;
    public byte varying_1001;
    public byte varying_1002;
    public byte varying_1003;
    public byte varying_1004;
    public byte varying_1005;
    public byte varying_1006;
    public byte varying_1007;
    public byte varying_1008;
    public byte varying_1009;
    public byte varying_1010;
    public byte varying_1011;
    public byte varying_1012;
    public byte varying_1013;
    public byte varying_1014;
    public byte varying_1015;
    public byte varying_1016;
    public byte varying_1017;
    public byte varying_1018;
    public byte varying_1019;
    public byte varying_1020;
    public byte varying_1021;
    public byte varying_1022;
    public byte varying_1023;
    public byte varying_1024;
    public byte varying_1025;
    public byte varying_1026;
    public byte varying_1027;
    public byte varying_1028;
    public byte varying_1029;
    public byte varying_1030;
    public byte varying_1031;
    public byte varying_1032;
    public byte varying_1033;
    public byte varying_1034;
    public byte varying_1035;
    public byte varying_1036;
    public byte varying_1037;
    public byte varying_1038;
    public byte varying_1039;
    public byte varying_1040;
    public byte varying_1041;
    public byte varying_1042;
    public byte varying_1043;
    public byte varying_1044;
    public byte varying_1045;
    public byte varying_1046;
    public byte varying_1047;
    public byte varying_1048;
    public byte varying_1049;
    public byte varying_1050;
    public byte varying_1051;
    public byte varying_1052;
    public byte varying_1053;
    public byte varying_1054;
    public byte varying_1055;
    public byte varying_1056;
    public byte varying_1057;
    public byte varying_1058;
    public byte varying_1059;
    public byte varying_1060;
    public byte varying_1061;
    public byte varying_1062;
    public byte varying_1063;
    public byte varying_1064;
    public byte varying_1065;
    public byte varying_1066;
    public byte varying_1067;
    public byte varying_1068;
    public byte varying_1069;
    public byte varying_1070;
    public byte varying_1071;
    public byte varying_1072;
    public byte varying_1073;
    public byte varying_1074;
    public byte varying_1075;
    public byte varying_1076;
    public byte varying_1077;
    public byte varying_1078;
    public byte varying_1079;
    public byte varying_1080;
    public byte varying_1081;
    public byte varying_1082;
    public byte varying_1083;
    public byte varying_1084;
    public byte varying_1085;
    public byte varying_1086;
    public byte varying_1087;
    public byte varying_1088;
    public byte varying_1089;
    public byte varying_1090;
    public byte varying_1091;
    public byte varying_1092;
    public byte varying_1093;
    public byte varying_1094;
    public byte varying_1095;
    public byte varying_1096;
    public byte varying_1097;
    public byte varying_1098;
    public byte varying_1099;
    public byte varying_1100;
    public byte varying_1101;
    public byte varying_1102;
    public byte varying_1103;
    public byte varying_1104;
    public byte varying_1105;
    public byte varying_1106;
    public byte varying_1107;
    public byte varying_1108;
    public byte varying_1109;
    public byte varying_1110;
    public byte varying_1111;
    public byte varying_1112;
    public byte varying_1113;
    public byte varying_1114;
    public byte varying_1115;
    public byte varying_1116;
    public byte varying_1117;
    public byte varying_1118;
    public byte varying_1119;
    public byte varying_1120;
    public byte varying_1121;
    public byte varying_1122;
    public byte varying_1123;
    public byte varying_1124;
    public byte varying_1125;
    public byte varying_1126;
    public byte varying_1127;
    public byte varying_1128;
    public byte varying_1129;
    public byte varying_1130;
    public byte varying_1131;
    public byte varying_1132;
    public byte varying_1133;
    public byte varying_1134;
    public byte varying_1135;
    public byte varying_1136;
    public byte varying_1137;
    public byte varying_1138;
    public byte varying_1139;
    public byte varying_1140;
    public byte varying_1141;
    public byte varying_1142;
    public byte varying_1143;
    public byte varying_1144;
    public byte varying_1145;
    public byte varying_1146;
    public byte varying_1147;
    public byte varying_1148;
    public byte varying_1149;
    public byte varying_1150;
    public byte varying_1151;
    public byte varying_1152;
    public byte varying_1153;
    public byte varying_1154;
    public byte varying_1155;
    public byte varying_1156;
    public byte varying_1157;
    public byte varying_1158;
    public byte varying_1159;
    public byte varying_1160;
    public byte varying_1161;
    public byte varying_1162;
    public byte varying_1163;
    public byte varying_1164;
    public byte varying_1165;
    public byte varying_1166;
    public byte varying_1167;
    public byte varying_1168;
    public byte varying_1169;
    public byte varying_1170;
    public byte varying_1171;
    public byte varying_1172;
    public byte varying_1173;
    public byte varying_1174;
    public byte varying_1175;
    public byte varying_1176;
    public byte varying_1177;
    public byte varying_1178;
    public byte varying_1179;
    public byte varying_1180;
    public byte varying_1181;
    public byte varying_1182;
    public byte varying_1183;
    public byte varying_1184;
    public byte varying_1185;
    public byte varying_1186;
    public byte varying_1187;
    public byte varying_1188;
    public byte varying_1189;
    public byte varying_1190;
    public byte varying_1191;
    public byte varying_1192;
    public byte varying_1193;
    public byte varying_1194;
    public byte varying_1195;
    public byte varying_1196;
    public byte varying_1197;
    public byte varying_1198;
    public byte varying_1199;
    public byte varying_1200;
    public byte varying_1201;
    public byte varying_1202;
    public byte varying_1203;
    public byte varying_1204;
    public byte varying_1205;
    public byte varying_1206;
    public byte varying_1207;
    public byte varying_1208;
    public byte varying_1209;
    public byte varying_1210;
    public byte varying_1211;
    public byte varying_1212;
    public byte varying_1213;
    public byte varying_1214;
    public byte varying_1215;
    public byte varying_1216;
    public byte varying_1217;
    public byte varying_1218;
    public byte varying_1219;
    public byte varying_1220;
    public byte varying_1221;
    public byte varying_1222;
    public byte varying_1223;
    public byte varying_1224;
    public byte varying_1225;
    public byte varying_1226;
    public byte varying_1227;
    public byte varying_1228;
    public byte varying_1229;
    public byte varying_1230;
    public byte varying_1231;
    public byte varying_1232;
    public byte varying_1233;
    public byte varying_1234;
    public byte varying_1235;
    public byte varying_1236;
    public byte varying_1237;
    public byte varying_1238;
    public byte varying_1239;
    public byte varying_1240;
    public byte varying_1241;
    public byte varying_1242;
    public byte varying_1243;
    public byte varying_1244;
    public byte varying_1245;
    public byte varying_1246;
    public byte varying_1247;
    public byte varying_1248;
    public byte varying_1249;
    public byte varying_1250;
    public byte varying_1251;
    public byte varying_1252;
    public byte varying_1253;
    public byte varying_1254;
    public byte varying_1255;
    public byte varying_1256;
    public byte varying_1257;
    public byte varying_1258;
    public byte varying_1259;
    public byte varying_1260;
    public byte varying_1261;
    public byte varying_1262;
    public byte varying_1263;
    public byte varying_1264;
    public byte varying_1265;
    public byte varying_1266;
    public byte varying_1267;
    public byte varying_1268;
    public byte varying_1269;
    public byte varying_1270;
    public byte varying_1271;
    public byte varying_1272;
    public byte varying_1273;
    public byte varying_1274;
    public byte varying_1275;
    public byte varying_1276;
    public byte varying_1277;
    public byte varying_1278;
    public byte varying_1279;
    public byte varying_1280;
    public byte varying_1281;
    public byte varying_1282;
    public byte varying_1283;
    public byte varying_1284;
    public byte varying_1285;
    public byte varying_1286;
    public byte varying_1287;
    public byte varying_1288;
    public byte varying_1289;
    public byte varying_1290;
    public byte varying_1291;
    public byte varying_1292;
    public byte varying_1293;
    public byte varying_1294;
    public byte varying_1295;
    public byte varying_1296;
    public byte varying_1297;
    public byte varying_1298;
    public byte varying_1299;
    public byte varying_1300;
    public byte varying_1301;
    public byte varying_1302;
    public byte varying_1303;
    public byte varying_1304;
    public byte varying_1305;
    public byte varying_1306;
    public byte varying_1307;
    public byte varying_1308;
    public byte varying_1309;
    public byte varying_1310;
    public byte varying_1311;
    public byte varying_1312;
    public byte varying_1313;
    public byte varying_1314;
    public byte varying_1315;
    public byte varying_1316;
    public byte varying_1317;
    public byte varying_1318;
    public byte varying_1319;
    public byte varying_1320;
    public byte varying_1321;
    public byte varying_1322;
    public byte varying_1323;
    public byte varying_1324;
    public byte varying_1325;
    public byte varying_1326;
    public byte varying_1327;
    public byte varying_1328;
    public byte varying_1329;
    public byte varying_1330;
    public byte varying_1331;
    public byte varying_1332;
    public byte varying_1333;
    public byte varying_1334;
    public byte varying_1335;
    public byte varying_1336;
    public byte varying_1337;
    public byte varying_1338;
    public byte varying_1339;
    public byte varying_1340;
    public byte varying_1341;
    public byte varying_1342;
    public byte varying_1343;
    public byte varying_1344;
    public byte varying_1345;
    public byte varying_1346;
    public byte varying_1347;
    public byte varying_1348;
    public byte varying_1349;
    public byte varying_1350;
    public byte varying_1351;
    public byte varying_1352;
    public byte varying_1353;
    public byte varying_1354;
    public byte varying_1355;
    public byte varying_1356;
    public byte varying_1357;
    public byte varying_1358;
    public byte varying_1359;
    public byte varying_1360;
    public byte varying_1361;
    public byte varying_1362;
    public byte varying_1363;
    public byte varying_1364;
    public byte varying_1365;
    public byte varying_1366;
    public byte varying_1367;
    public byte varying_1368;
    public byte varying_1369;
    public byte varying_1370;
    public byte varying_1371;
    public byte varying_1372;
    public byte varying_1373;
    public byte varying_1374;
    public byte varying_1375;
    public byte varying_1376;
    public byte varying_1377;
    public byte varying_1378;
    public byte varying_1379;
    public byte varying_1380;
    public byte varying_1381;
    public byte varying_1382;
    public byte varying_1383;
    public byte varying_1384;
    public byte varying_1385;
    public byte varying_1386;
    public byte varying_1387;
    public byte varying_1388;
    public byte varying_1389;
    public byte varying_1390;
    public byte varying_1391;
    public byte varying_1392;
    public byte varying_1393;
    public byte varying_1394;
    public byte varying_1395;
    public byte varying_1396;
    public byte varying_1397;
    public byte varying_1398;
    public byte varying_1399;
    public byte varying_1400;
    public byte varying_1401;
    public byte varying_1402;
    public byte varying_1403;
    public byte varying_1404;
    public byte varying_1405;
    public byte varying_1406;
    public byte varying_1407;
    public byte varying_1408;
    public byte varying_1409;
    public byte varying_1410;
    public byte varying_1411;
    public byte varying_1412;
    public byte varying_1413;
    public byte varying_1414;
    public byte varying_1415;
    public byte varying_1416;
    public byte varying_1417;
    public byte varying_1418;
    public byte varying_1419;
    public byte varying_1420;
    public byte varying_1421;
    public byte varying_1422;
    public byte varying_1423;
    public byte varying_1424;
    public byte varying_1425;
    public byte varying_1426;
    public byte varying_1427;
    public byte varying_1428;
    public byte varying_1429;
    public byte varying_1430;
    public byte varying_1431;
    public byte varying_1432;
    public byte varying_1433;
    public byte varying_1434;
    public byte varying_1435;
    public byte varying_1436;
    public byte varying_1437;
    public byte varying_1438;
    public byte varying_1439;
    public byte varying_1440;
    public byte varying_1441;
    public byte varying_1442;
    public byte varying_1443;
    public byte varying_1444;
    public byte varying_1445;
    public byte varying_1446;
    public byte varying_1447;
    public byte varying_1448;
    public byte varying_1449;
    public byte varying_1450;
    public byte varying_1451;
    public byte varying_1452;
    public byte varying_1453;
    public byte varying_1454;
    public byte varying_1455;
    public byte varying_1456;
    public byte varying_1457;
    public byte varying_1458;
    public byte varying_1459;
    public byte varying_1460;
    public byte varying_1461;
    public byte varying_1462;
    public byte varying_1463;
    public byte varying_1464;
    public byte varying_1465;
    public byte varying_1466;
    public byte varying_1467;
    public byte varying_1468;
    public byte varying_1469;
    public byte varying_1470;
    public byte varying_1471;
    public byte varying_1472;
    public byte varying_1473;
    public byte varying_1474;
    public byte varying_1475;
    public byte varying_1476;
    public byte varying_1477;
    public byte varying_1478;
    public byte varying_1479;
    public byte varying_1480;
    public byte varying_1481;
    public byte varying_1482;
    public byte varying_1483;
    public byte varying_1484;
    public byte varying_1485;
    public byte varying_1486;
    public byte varying_1487;
    public byte varying_1488;
    public byte varying_1489;
    public byte varying_1490;
    public byte varying_1491;
    public byte varying_1492;
    public byte varying_1493;
    public byte varying_1494;
    public byte varying_1495;
    public byte varying_1496;
    public byte varying_1497;
    public byte varying_1498;
    public byte varying_1499;
    public byte varying_1500;
    public byte varying_1501;
    public byte varying_1502;
    public byte varying_1503;
    public byte varying_1504;
    public byte varying_1505;
    public byte varying_1506;
    public byte varying_1507;
    public byte varying_1508;
    public byte varying_1509;
    public byte varying_1510;
    public byte varying_1511;
    public byte varying_1512;
    public byte varying_1513;
    public byte varying_1514;
    public byte varying_1515;
    public byte varying_1516;
    public byte varying_1517;
    public byte varying_1518;
    public byte varying_1519;
    public byte varying_1520;
    public byte varying_1521;
    public byte varying_1522;
    public byte varying_1523;
    public byte varying_1524;
    public byte varying_1525;
    public byte varying_1526;
    public byte varying_1527;
    public byte varying_1528;
    public byte varying_1529;
    public byte varying_1530;
    public byte varying_1531;
    public byte varying_1532;
    public byte varying_1533;
    public byte varying_1534;
    public byte varying_1535;
    public byte varying_1536;
    public byte varying_1537;
    public byte varying_1538;
    public byte varying_1539;
    public byte varying_1540;
    public byte varying_1541;
    public byte varying_1542;
    public byte varying_1543;
    public byte varying_1544;
    public byte varying_1545;
    public byte varying_1546;
    public byte varying_1547;
    public byte varying_1548;
    public byte varying_1549;
    public byte varying_1550;
    public byte varying_1551;
    public byte varying_1552;
    public byte varying_1553;
    public byte varying_1554;
    public byte varying_1555;
    public byte varying_1556;
    public byte varying_1557;
    public byte varying_1558;
    public byte varying_1559;
    public byte varying_1560;
    public byte varying_1561;
    public byte varying_1562;
    public byte varying_1563;
    public byte varying_1564;
    public byte varying_1565;
    public byte varying_1566;
    public byte varying_1567;
    public byte varying_1568;
    public byte varying_1569;
    public byte varying_1570;
    public byte varying_1571;
    public byte varying_1572;
    public byte varying_1573;
    public byte varying_1574;
    public byte varying_1575;
    public byte varying_1576;
    public byte varying_1577;
    public byte varying_1578;
    public byte varying_1579;
    public byte varying_1580;
    public byte varying_1581;
    public byte varying_1582;
    public byte varying_1583;
    public byte varying_1584;
    public byte varying_1585;
    public byte varying_1586;
    public byte varying_1587;
    public byte varying_1588;
    public byte varying_1589;
    public byte varying_1590;
    public byte varying_1591;
    public byte varying_1592;
    public byte varying_1593;
    public byte varying_1594;
    public byte varying_1595;
    public byte varying_1596;
    public byte varying_1597;
    public byte varying_1598;
    public byte varying_1599;
    public byte varying_1600;
    public byte varying_1601;
    public byte varying_1602;
    public byte varying_1603;
    public byte varying_1604;
    public byte varying_1605;
    public byte varying_1606;
    public byte varying_1607;
    public byte varying_1608;
    public byte varying_1609;
    public byte varying_1610;
    public byte varying_1611;
    public byte varying_1612;
    public byte varying_1613;
    public byte varying_1614;
    public byte varying_1615;
    public byte varying_1616;
    public byte varying_1617;
    public byte varying_1618;
    public byte varying_1619;
    public byte varying_1620;
    public byte varying_1621;
    public byte varying_1622;
    public byte varying_1623;
    public byte varying_1624;
    public byte varying_1625;
    public byte varying_1626;
    public byte varying_1627;
    public byte varying_1628;
    public byte varying_1629;
    public byte varying_1630;
    public byte varying_1631;
    public byte varying_1632;
    public byte varying_1633;
    public byte varying_1634;
    public byte varying_1635;
    public byte varying_1636;
    public byte varying_1637;
    public byte varying_1638;
    public byte varying_1639;
    public byte varying_1640;
    public byte varying_1641;
    public byte varying_1642;
    public byte varying_1643;
    public byte varying_1644;
    public byte varying_1645;
    public byte varying_1646;
    public byte varying_1647;
    public byte varying_1648;
    public byte varying_1649;
    public byte varying_1650;
    public byte varying_1651;
    public byte varying_1652;
    public byte varying_1653;
    public byte varying_1654;
    public byte varying_1655;
    public byte varying_1656;
    public byte varying_1657;
    public byte varying_1658;
    public byte varying_1659;
    public byte varying_1660;
    public byte varying_1661;
    public byte varying_1662;
    public byte varying_1663;
    public byte varying_1664;
    public byte varying_1665;
    public byte varying_1666;
    public byte varying_1667;
    public byte varying_1668;
    public byte varying_1669;
    public byte varying_1670;
    public byte varying_1671;
    public byte varying_1672;
    public byte varying_1673;
    public byte varying_1674;
    public byte varying_1675;
    public byte varying_1676;
    public byte varying_1677;
    public byte varying_1678;
    public byte varying_1679;
    public byte varying_1680;
    public byte varying_1681;
    public byte varying_1682;
    public byte varying_1683;
    public byte varying_1684;
    public byte varying_1685;
    public byte varying_1686;
    public byte varying_1687;
    public byte varying_1688;
    public byte varying_1689;
    public byte varying_1690;
    public byte varying_1691;
    public byte varying_1692;
    public byte varying_1693;
    public byte varying_1694;
    public byte varying_1695;
    public byte varying_1696;
    public byte varying_1697;
    public byte varying_1698;
    public byte varying_1699;
    public byte varying_1700;
    public byte varying_1701;
    public byte varying_1702;
    public byte varying_1703;
    public byte varying_1704;
    public byte varying_1705;
    public byte varying_1706;
    public byte varying_1707;
    public byte varying_1708;
    public byte varying_1709;
    public byte varying_1710;
    public byte varying_1711;
    public byte varying_1712;
    public byte varying_1713;
    public byte varying_1714;
    public byte varying_1715;
    public byte varying_1716;
    public byte varying_1717;
    public byte varying_1718;
    public byte varying_1719;
    public byte varying_1720;
    public byte varying_1721;
    public byte varying_1722;
    public byte varying_1723;
    public byte varying_1724;
    public byte varying_1725;
    public byte varying_1726;
    public byte varying_1727;
    public byte varying_1728;
    public byte varying_1729;
    public byte varying_1730;
    public byte varying_1731;
    public byte varying_1732;
    public byte varying_1733;
    public byte varying_1734;
    public byte varying_1735;
    public byte varying_1736;
    public byte varying_1737;
    public byte varying_1738;
    public byte varying_1739;
    public byte varying_1740;
    public byte varying_1741;
    public byte varying_1742;
    public byte varying_1743;
    public byte varying_1744;
    public byte varying_1745;
    public byte varying_1746;
    public byte varying_1747;
    public byte varying_1748;
    public byte varying_1749;
    public byte varying_1750;
    public byte varying_1751;
    public byte varying_1752;
    public byte varying_1753;
    public byte varying_1754;
    public byte varying_1755;
    public byte varying_1756;
    public byte varying_1757;
    public byte varying_1758;
    public byte varying_1759;
    public byte varying_1760;
    public byte varying_1761;
    public byte varying_1762;
    public byte varying_1763;
    public byte varying_1764;
    public byte varying_1765;
    public byte varying_1766;
    public byte varying_1767;
    public byte varying_1768;
    public byte varying_1769;
    public byte varying_1770;
    public byte varying_1771;
    public byte varying_1772;
    public byte varying_1773;
    public byte varying_1774;
    public byte varying_1775;
    public byte varying_1776;
    public byte varying_1777;
    public byte varying_1778;
    public byte varying_1779;
    public byte varying_1780;
    public byte varying_1781;
    public byte varying_1782;
    public byte varying_1783;
    public byte varying_1784;
    public byte varying_1785;
    public byte varying_1786;
    public byte varying_1787;
    public byte varying_1788;
    public byte varying_1789;
    public byte varying_1790;
    public byte varying_1791;
    public byte varying_1792;
    public byte varying_1793;
    public byte varying_1794;
    public byte varying_1795;
    public byte varying_1796;
    public byte varying_1797;
    public byte varying_1798;
    public byte varying_1799;
    public byte varying_1800;
    public byte varying_1801;
    public byte varying_1802;
    public byte varying_1803;
    public byte varying_1804;
    public byte varying_1805;
    public byte varying_1806;
    public byte varying_1807;
    public byte varying_1808;
    public byte varying_1809;
    public byte varying_1810;
    public byte varying_1811;
    public byte varying_1812;
    public byte varying_1813;
    public byte varying_1814;
    public byte varying_1815;
    public byte varying_1816;
    public byte varying_1817;
    public byte varying_1818;
    public byte varying_1819;
    public byte varying_1820;
    public byte varying_1821;
    public byte varying_1822;
    public byte varying_1823;
    public byte varying_1824;
    public byte varying_1825;
    public byte varying_1826;
    public byte varying_1827;
    public byte varying_1828;
    public byte varying_1829;
    public byte varying_1830;
    public byte varying_1831;
    public byte varying_1832;
    public byte varying_1833;
    public byte varying_1834;
    public byte varying_1835;
    public byte varying_1836;
    public byte varying_1837;
    public byte varying_1838;
    public byte varying_1839;
    public byte varying_1840;
    public byte varying_1841;
    public byte varying_1842;
    public byte varying_1843;
    public byte varying_1844;
    public byte varying_1845;
    public byte varying_1846;
    public byte varying_1847;
    public byte varying_1848;
    public byte varying_1849;
    public byte varying_1850;
    public byte varying_1851;
    public byte varying_1852;
    public byte varying_1853;
    public byte varying_1854;
    public byte varying_1855;
    public byte varying_1856;
    public byte varying_1857;
    public byte varying_1858;
    public byte varying_1859;
    public byte varying_1860;
    public byte varying_1861;
    public byte varying_1862;
    public byte varying_1863;
    public byte varying_1864;
    public byte varying_1865;
    public byte varying_1866;
    public byte varying_1867;
    public byte varying_1868;
    public byte varying_1869;
    public byte varying_1870;
    public byte varying_1871;
    public byte varying_1872;
    public byte varying_1873;
    public byte varying_1874;
    public byte varying_1875;
    public byte varying_1876;
    public byte varying_1877;
    public byte varying_1878;
    public byte varying_1879;
    public byte varying_1880;
    public byte varying_1881;
    public byte varying_1882;
    public byte varying_1883;
    public byte varying_1884;
    public byte varying_1885;
    public byte varying_1886;
    public byte varying_1887;
    public byte varying_1888;
    public byte varying_1889;
    public byte varying_1890;
    public byte varying_1891;
    public byte varying_1892;
    public byte varying_1893;
    public byte varying_1894;
    public byte varying_1895;
    public byte varying_1896;
    public byte varying_1897;
    public byte varying_1898;
    public byte varying_1899;
    public byte varying_1900;
    public byte varying_1901;
    public byte varying_1902;
    public byte varying_1903;
    public byte varying_1904;
    public byte varying_1905;
    public byte varying_1906;
    public byte varying_1907;
    public byte varying_1908;
    public byte varying_1909;
    public byte varying_1910;
    public byte varying_1911;
    public byte varying_1912;
    public byte varying_1913;
    public byte varying_1914;
    public byte varying_1915;
    public byte varying_1916;
    public byte varying_1917;
    public byte varying_1918;
    public byte varying_1919;
    public byte varying_1920;
    public byte varying_1921;
    public byte varying_1922;
    public byte varying_1923;
    public byte varying_1924;
    public byte varying_1925;
    public byte varying_1926;
    public byte varying_1927;
    public byte varying_1928;
    public byte varying_1929;
    public byte varying_1930;
    public byte varying_1931;
    public byte varying_1932;
    public byte varying_1933;
    public byte varying_1934;
    public byte varying_1935;
    public byte varying_1936;
    public byte varying_1937;
    public byte varying_1938;
    public byte varying_1939;
    public byte varying_1940;
    public byte varying_1941;
    public byte varying_1942;
    public byte varying_1943;
    public byte varying_1944;
    public byte varying_1945;
    public byte varying_1946;
    public byte varying_1947;
    public byte varying_1948;
    public byte varying_1949;
    public byte varying_1950;
    public byte varying_1951;
    public byte varying_1952;
    public byte varying_1953;
    public byte varying_1954;
    public byte varying_1955;
    public byte varying_1956;
    public byte varying_1957;
    public byte varying_1958;
    public byte varying_1959;
    public byte varying_1960;
    public byte varying_1961;
    public byte varying_1962;
    public byte varying_1963;
    public byte varying_1964;
    public byte varying_1965;
    public byte varying_1966;
    public byte varying_1967;
    public byte varying_1968;
    public byte varying_1969;
    public byte varying_1970;
    public byte varying_1971;
    public byte varying_1972;
    public byte varying_1973;
    public byte varying_1974;
    public byte varying_1975;
    public byte varying_1976;
    public byte varying_1977;
    public byte varying_1978;
    public byte varying_1979;
    public byte varying_1980;
    public byte varying_1981;
    public byte varying_1982;
    public byte varying_1983;
    public byte varying_1984;
    public byte varying_1985;
    public byte varying_1986;
    public byte varying_1987;
    public byte varying_1988;
    public byte varying_1989;
    public byte varying_1990;
    public byte varying_1991;
    public byte varying_1992;
    public byte varying_1993;
    public byte varying_1994;
    public byte varying_1995;
    public byte varying_1996;
    public byte varying_1997;
    public byte varying_1998;
    public byte varying_1999;
    public byte varying_2000;
    public byte varying_2001;
    public byte varying_2002;
    public byte varying_2003;
    public byte varying_2004;
    public byte varying_2005;
    public byte varying_2006;
    public byte varying_2007;
    public byte varying_2008;
    public byte varying_2009;
    public byte varying_2010;
    public byte varying_2011;
    public byte varying_2012;
    public byte varying_2013;
    public byte varying_2014;
    public byte varying_2015;
    public byte varying_2016;
    public byte varying_2017;
    public byte varying_2018;
    public byte varying_2019;
    public byte varying_2020;
    public byte varying_2021;
    public byte varying_2022;
    public byte varying_2023;
    public byte varying_2024;
    public byte varying_2025;
    public byte varying_2026;
    public byte varying_2027;
    public byte varying_2028;
    public byte varying_2029;
    public byte varying_2030;
    public byte varying_2031;
    public byte varying_2032;
    public byte varying_2033;
    public byte varying_2034;
    public byte varying_2035;
    public byte varying_2036;
    public byte varying_2037;
    public byte varying_2038;
    public byte varying_2039;
    public byte varying_2040;
    public byte varying_2041;
    public byte varying_2042;
    public byte varying_2043;
    public byte varying_2044;
    public byte varying_2045;
    public byte varying_2046;
    public byte varying_2047;
    public byte varying_2048;
    public byte varying_2049;
    public byte varying_2050;
    public byte varying_2051;
    public byte varying_2052;
    public byte varying_2053;
    public byte varying_2054;
    public byte varying_2055;
    public byte varying_2056;
    public byte varying_2057;
    public byte varying_2058;
    public byte varying_2059;
    public byte varying_2060;
    public byte varying_2061;
    public byte varying_2062;
    public byte varying_2063;
    public byte varying_2064;
    public byte varying_2065;
    public byte varying_2066;
    public byte varying_2067;
    public byte varying_2068;
    public byte varying_2069;
    public byte varying_2070;
    public byte varying_2071;
    public byte varying_2072;
    public byte varying_2073;
    public byte varying_2074;
    public byte varying_2075;
    public byte varying_2076;
    public byte varying_2077;
    public byte varying_2078;
    public byte varying_2079;
    public byte varying_2080;
    public byte varying_2081;
    public byte varying_2082;
    public byte varying_2083;
    public byte varying_2084;
    public byte varying_2085;
    public byte varying_2086;
    public byte varying_2087;
    public byte varying_2088;
    public byte varying_2089;
    public byte varying_2090;
    public byte varying_2091;
    public byte varying_2092;
    public byte varying_2093;
    public byte varying_2094;
    public byte varying_2095;
    public byte varying_2096;
    public byte varying_2097;
    public byte varying_2098;
    public byte varying_2099;
    public byte varying_2100;
    public byte varying_2101;
    public byte varying_2102;
    public byte varying_2103;
    public byte varying_2104;
    public byte varying_2105;
    public byte varying_2106;
    public byte varying_2107;
    public byte varying_2108;
    public byte varying_2109;
    public byte varying_2110;
    public byte varying_2111;
    public byte varying_2112;
    public byte varying_2113;
    public byte varying_2114;
    public byte varying_2115;
    public byte varying_2116;
    public byte varying_2117;
    public byte varying_2118;
    public byte varying_2119;
    public byte varying_2120;
    public byte varying_2121;
    public byte varying_2122;
    public byte varying_2123;
    public byte varying_2124;
    public byte varying_2125;
    public byte varying_2126;
    public byte varying_2127;
    public byte varying_2128;
    public byte varying_2129;
    public byte varying_2130;
    public byte varying_2131;
    public byte varying_2132;
    public byte varying_2133;
    public byte varying_2134;
    public byte varying_2135;
    public byte varying_2136;
    public byte varying_2137;
    public byte varying_2138;
    public byte varying_2139;
    public byte varying_2140;
    public byte varying_2141;
    public byte varying_2142;
    public byte varying_2143;
    public byte varying_2144;
    public byte varying_2145;
    public byte varying_2146;
    public byte varying_2147;
    public byte varying_2148;
    public byte varying_2149;
    public byte varying_2150;
    public byte varying_2151;
    public byte varying_2152;
    public byte varying_2153;
    public byte varying_2154;
    public byte varying_2155;
    public byte varying_2156;
    public byte varying_2157;
    public byte varying_2158;
    public byte varying_2159;
    public byte varying_2160;
    public byte varying_2161;
    public byte varying_2162;
    public byte varying_2163;
    public byte varying_2164;
    public byte varying_2165;
    public byte varying_2166;
    public byte varying_2167;
    public byte varying_2168;
    public byte varying_2169;
    public byte varying_2170;
    public byte varying_2171;
    public byte varying_2172;
    public byte varying_2173;
    public byte varying_2174;
    public byte varying_2175;
    public byte varying_2176;
    public byte varying_2177;
    public byte varying_2178;
    public byte varying_2179;
    public byte varying_2180;
    public byte varying_2181;
    public byte varying_2182;
    public byte varying_2183;
    public byte varying_2184;
    public byte varying_2185;
    public byte varying_2186;
    public byte varying_2187;
    public byte varying_2188;
    public byte varying_2189;
    public byte varying_2190;
    public byte varying_2191;
    public byte varying_2192;
    public byte varying_2193;
    public byte varying_2194;
    public byte varying_2195;
    public byte varying_2196;
    public byte varying_2197;
    public byte varying_2198;
    public byte varying_2199;
    public byte varying_2200;
    public byte varying_2201;
    public byte varying_2202;
    public byte varying_2203;
    public byte varying_2204;
    public byte varying_2205;
    public byte varying_2206;
    public byte varying_2207;
    public byte varying_2208;
    public byte varying_2209;
    public byte varying_2210;
    public byte varying_2211;
    public byte varying_2212;
    public byte varying_2213;
    public byte varying_2214;
    public byte varying_2215;
    public byte varying_2216;
    public byte varying_2217;
    public byte varying_2218;
    public byte varying_2219;
    public byte varying_2220;
    public byte varying_2221;
    public byte varying_2222;
    public byte varying_2223;
    public byte varying_2224;
    public byte varying_2225;
    public byte varying_2226;
    public byte varying_2227;
    public byte varying_2228;
    public byte varying_2229;
    public byte varying_2230;
    public byte varying_2231;
    public byte varying_2232;
    public byte varying_2233;
    public byte varying_2234;
    public byte varying_2235;
    public byte varying_2236;
    public byte varying_2237;
    public byte varying_2238;
    public byte varying_2239;
    public byte varying_2240;
    public byte varying_2241;
    public byte varying_2242;
    public byte varying_2243;
    public byte varying_2244;
    public byte varying_2245;
    public byte varying_2246;
    public byte varying_2247;
    public byte varying_2248;
    public byte varying_2249;
    public byte varying_2250;
    public byte varying_2251;
    public byte varying_2252;
    public byte varying_2253;
    public byte varying_2254;
    public byte varying_2255;
    public byte varying_2256;
    public byte varying_2257;
    public byte varying_2258;
    public byte varying_2259;
    public byte varying_2260;
    public byte varying_2261;
    public byte varying_2262;
    public byte varying_2263;
    public byte varying_2264;
    public byte varying_2265;
    public byte varying_2266;
    public byte varying_2267;
    public byte varying_2268;
    public byte varying_2269;
    public byte varying_2270;
    public byte varying_2271;
    public byte varying_2272;
    public byte varying_2273;
    public byte varying_2274;
    public byte varying_2275;
    public byte varying_2276;
    public byte varying_2277;
    public byte varying_2278;
    public byte varying_2279;
    public byte varying_2280;
    public byte varying_2281;
    public byte varying_2282;
    public byte varying_2283;
    public byte varying_2284;
    public byte varying_2285;
    public byte varying_2286;
    public byte varying_2287;
    public byte varying_2288;
    public byte varying_2289;
    public byte varying_2290;
    public byte varying_2291;
    public byte varying_2292;
    public byte varying_2293;
    public byte varying_2294;
    public byte varying_2295;
    public byte varying_2296;
    public byte varying_2297;
    public byte varying_2298;
    public byte varying_2299;
    public byte varying_2300;
    public byte varying_2301;
    public byte varying_2302;
    public byte varying_2303;
    public byte varying_2304;
    public byte varying_2305;
    public byte varying_2306;
    public byte varying_2307;
    public byte varying_2308;
    public byte varying_2309;
    public byte varying_2310;
    public byte varying_2311;
    public byte varying_2312;
    public byte varying_2313;
    public byte varying_2314;
    public byte varying_2315;
    public byte varying_2316;
    public byte varying_2317;
    public byte varying_2318;
    public byte varying_2319;
    public byte varying_2320;
    public byte varying_2321;
    public byte varying_2322;
    public byte varying_2323;
    public byte varying_2324;
    public byte varying_2325;
    public byte varying_2326;
    public byte varying_2327;
    public byte varying_2328;
    public byte varying_2329;
    public byte varying_2330;
    public byte varying_2331;
    public byte varying_2332;
    public byte varying_2333;
    public byte varying_2334;
    public byte varying_2335;
    public byte varying_2336;
    public byte varying_2337;
    public byte varying_2338;
    public byte varying_2339;
    public byte varying_2340;
    public byte varying_2341;
    public byte varying_2342;
    public byte varying_2343;
    public byte varying_2344;
    public byte varying_2345;
    public byte varying_2346;
    public byte varying_2347;
    public byte varying_2348;
    public byte varying_2349;
    public byte varying_2350;
    public byte varying_2351;
    public byte varying_2352;
    public byte varying_2353;
    public byte varying_2354;
    public byte varying_2355;
    public byte varying_2356;
    public byte varying_2357;
    public byte varying_2358;
    public byte varying_2359;
    public byte varying_2360;
    public byte varying_2361;
    public byte varying_2362;
    public byte varying_2363;
    public byte varying_2364;
    public byte varying_2365;
    public byte varying_2366;
    public byte varying_2367;
    public byte varying_2368;
    public byte varying_2369;
    public byte varying_2370;
    public byte varying_2371;
    public byte varying_2372;
    public byte varying_2373;
    public byte varying_2374;
    public byte varying_2375;
    public byte varying_2376;
    public byte varying_2377;
    public byte varying_2378;
    public byte varying_2379;
    public byte varying_2380;
    public byte varying_2381;
    public byte varying_2382;
    public byte varying_2383;
    public byte varying_2384;
    public byte varying_2385;
    public byte varying_2386;
    public byte varying_2387;
    public byte varying_2388;
    public byte varying_2389;
    public byte varying_2390;
    public byte varying_2391;
    public byte varying_2392;
    public byte varying_2393;
    public byte varying_2394;
    public byte varying_2395;
    public byte varying_2396;
    public byte varying_2397;
    public byte varying_2398;
    public byte varying_2399;
    public byte varying_2400;
    public byte varying_2401;
    public byte varying_2402;
    public byte varying_2403;
    public byte varying_2404;
    public byte varying_2405;
    public byte varying_2406;
    public byte varying_2407;
    public byte varying_2408;
    public byte varying_2409;
    public byte varying_2410;
    public byte varying_2411;
    public byte varying_2412;
    public byte varying_2413;
    public byte varying_2414;
    public byte varying_2415;
    public byte varying_2416;
    public byte varying_2417;
    public byte varying_2418;
    public byte varying_2419;
    public byte varying_2420;
    public byte varying_2421;
    public byte varying_2422;
    public byte varying_2423;
    public byte varying_2424;
    public byte varying_2425;
    public byte varying_2426;
    public byte varying_2427;
    public byte varying_2428;
    public byte varying_2429;
    public byte varying_2430;
    public byte varying_2431;
    public byte varying_2432;
    public byte varying_2433;
    public byte varying_2434;
    public byte varying_2435;
    public byte varying_2436;
    public byte varying_2437;
    public byte varying_2438;
    public byte varying_2439;
    public byte varying_2440;
    public byte varying_2441;
    public byte varying_2442;
    public byte varying_2443;
    public byte varying_2444;
    public byte varying_2445;
    public byte varying_2446;
    public byte varying_2447;
    public byte varying_2448;
    public byte varying_2449;
    public byte varying_2450;
    public byte varying_2451;
    public byte varying_2452;
    public byte varying_2453;
    public byte varying_2454;
    public byte varying_2455;
    public byte varying_2456;
    public byte varying_2457;
    public byte varying_2458;
    public byte varying_2459;
    public byte varying_2460;
    public byte varying_2461;
    public byte varying_2462;
    public byte varying_2463;
    public byte varying_2464;
    public byte varying_2465;
    public byte varying_2466;
    public byte varying_2467;
    public byte varying_2468;
    public byte varying_2469;
    public byte varying_2470;
    public byte varying_2471;
    public byte varying_2472;
    public byte varying_2473;
    public byte varying_2474;
    public byte varying_2475;
    public byte varying_2476;
    public byte varying_2477;
    public byte varying_2478;
    public byte varying_2479;
    public byte varying_2480;
    public byte varying_2481;
    public byte varying_2482;
    public byte varying_2483;
    public byte varying_2484;
    public byte varying_2485;
    public byte varying_2486;
    public byte varying_2487;
    public byte varying_2488;
    public byte varying_2489;
    public byte varying_2490;
    public byte varying_2491;
    public byte varying_2492;
    public byte varying_2493;
    public byte varying_2494;
    public byte varying_2495;
    public byte varying_2496;
    public byte varying_2497;
    public byte varying_2498;
    public byte varying_2499;
    public byte varying_2500;
    public byte varying_2501;
    public byte varying_2502;
    public byte varying_2503;
    public byte varying_2504;
    public byte varying_2505;
    public byte varying_2506;
    public byte varying_2507;
    public byte varying_2508;
    public byte varying_2509;
    public byte varying_2510;
    public byte varying_2511;
    public byte varying_2512;
    public byte varying_2513;
    public byte varying_2514;
    public byte varying_2515;
    public byte varying_2516;
    public byte varying_2517;
    public byte varying_2518;
    public byte varying_2519;
    public byte varying_2520;
    public byte varying_2521;
    public byte varying_2522;
    public byte varying_2523;
    public byte varying_2524;
    public byte varying_2525;
    public byte varying_2526;
    public byte varying_2527;
    public byte varying_2528;
    public byte varying_2529;
    public byte varying_2530;
    public byte varying_2531;
    public byte varying_2532;
    public byte varying_2533;
    public byte varying_2534;
    public byte varying_2535;
    public byte varying_2536;
    public byte varying_2537;
    public byte varying_2538;
    public byte varying_2539;
    public byte varying_2540;
    public byte varying_2541;
    public byte varying_2542;
    public byte varying_2543;
    public byte varying_2544;
    public byte varying_2545;
    public byte varying_2546;
    public byte varying_2547;
    public byte varying_2548;
    public byte varying_2549;
    public byte varying_2550;
    public byte varying_2551;
    public byte varying_2552;
    public byte varying_2553;
    public byte varying_2554;
    public byte varying_2555;
    public byte varying_2556;
    public byte varying_2557;
    public byte varying_2558;
    public byte varying_2559;
    public byte varying_2560;
    public byte varying_2561;
    public byte varying_2562;
    public byte varying_2563;
    public byte varying_2564;
    public byte varying_2565;
    public byte varying_2566;
    public byte varying_2567;
    public byte varying_2568;
    public byte varying_2569;
    public byte varying_2570;
    public byte varying_2571;
    public byte varying_2572;
    public byte varying_2573;
    public byte varying_2574;
    public byte varying_2575;
    public byte varying_2576;
    public byte varying_2577;
    public byte varying_2578;
    public byte varying_2579;
    public byte varying_2580;
    public byte varying_2581;
    public byte varying_2582;
    public byte varying_2583;
    public byte varying_2584;
    public byte varying_2585;
    public byte varying_2586;
    public byte varying_2587;
    public byte varying_2588;
    public byte varying_2589;
    public byte varying_2590;
    public byte varying_2591;
    public byte varying_2592;
    public byte varying_2593;
    public byte varying_2594;
    public byte varying_2595;
    public byte varying_2596;
    public byte varying_2597;
    public byte varying_2598;
    public byte varying_2599;
    public byte varying_2600;
    public byte varying_2601;
    public byte varying_2602;
    public byte varying_2603;
    public byte varying_2604;
    public byte varying_2605;
    public byte varying_2606;
    public byte varying_2607;
    public byte varying_2608;
    public byte varying_2609;
    public byte varying_2610;
    public byte varying_2611;
    public byte varying_2612;
    public byte varying_2613;
    public byte varying_2614;
    public byte varying_2615;
    public byte varying_2616;
    public byte varying_2617;
    public byte varying_2618;
    public byte varying_2619;
    public byte varying_2620;
    public byte varying_2621;
    public byte varying_2622;
    public byte varying_2623;
    public byte varying_2624;
    public byte varying_2625;
    public byte varying_2626;
    public byte varying_2627;
    public byte varying_2628;
    public byte varying_2629;
    public byte varying_2630;
    public byte varying_2631;
    public byte varying_2632;
    public byte varying_2633;
    public byte varying_2634;
    public byte varying_2635;
    public byte varying_2636;
    public byte varying_2637;
    public byte varying_2638;
    public byte varying_2639;
    public byte varying_2640;
    public byte varying_2641;
    public byte varying_2642;
    public byte varying_2643;
    public byte varying_2644;
    public byte varying_2645;
    public byte varying_2646;
    public byte varying_2647;
    public byte varying_2648;
    public byte varying_2649;
    public byte varying_2650;
    public byte varying_2651;
    public byte varying_2652;
    public byte varying_2653;
    public byte varying_2654;
    public byte varying_2655;
    public byte varying_2656;
    public byte varying_2657;
    public byte varying_2658;
    public byte varying_2659;
    public byte varying_2660;
    public byte varying_2661;
    public byte varying_2662;
    public byte varying_2663;
    public byte varying_2664;
    public byte varying_2665;
    public byte varying_2666;
    public byte varying_2667;
    public byte varying_2668;
    public byte varying_2669;
    public byte varying_2670;
    public byte varying_2671;
    public byte varying_2672;
    public byte varying_2673;
    public byte varying_2674;
    public byte varying_2675;
    public byte varying_2676;
    public byte varying_2677;
    public byte varying_2678;
    public byte varying_2679;
    public byte varying_2680;
    public byte varying_2681;
    public byte varying_2682;
    public byte varying_2683;
    public byte varying_2684;
    public byte varying_2685;
    public byte varying_2686;
    public byte varying_2687;
    public byte varying_2688;
    public byte varying_2689;
    public byte varying_2690;
    public byte varying_2691;
    public byte varying_2692;
    public byte varying_2693;
    public byte varying_2694;
    public byte varying_2695;
    public byte varying_2696;
    public byte varying_2697;
    public byte varying_2698;
    public byte varying_2699;
    public byte varying_2700;
    public byte varying_2701;
    public byte varying_2702;
    public byte varying_2703;
    public byte varying_2704;
    public byte varying_2705;
    public byte varying_2706;
    public byte varying_2707;
    public byte varying_2708;
    public byte varying_2709;
    public byte varying_2710;
    public byte varying_2711;
    public byte varying_2712;
    public byte varying_2713;
    public byte varying_2714;
    public byte varying_2715;
    public byte varying_2716;
    public byte varying_2717;
    public byte varying_2718;
    public byte varying_2719;
    public byte varying_2720;
    public byte varying_2721;
    public byte varying_2722;
    public byte varying_2723;
    public byte varying_2724;
    public byte varying_2725;
    public byte varying_2726;
    public byte varying_2727;
    public byte varying_2728;
    public byte varying_2729;
    public byte varying_2730;
    public byte varying_2731;
    public byte varying_2732;
    public byte varying_2733;
    public byte varying_2734;
    public byte varying_2735;
    public byte varying_2736;
    public byte varying_2737;
    public byte varying_2738;
    public byte varying_2739;
    public byte varying_2740;
    public byte varying_2741;
    public byte varying_2742;
    public byte varying_2743;
    public byte varying_2744;
    public byte varying_2745;
    public byte varying_2746;
    public byte varying_2747;
    public byte varying_2748;
    public byte varying_2749;
    public byte varying_2750;
    public byte varying_2751;
    public byte varying_2752;
    public byte varying_2753;
    public byte varying_2754;
    public byte varying_2755;
    public byte varying_2756;
    public byte varying_2757;
    public byte varying_2758;
    public byte varying_2759;
    public byte varying_2760;
    public byte varying_2761;
    public byte varying_2762;
    public byte varying_2763;
    public byte varying_2764;
    public byte varying_2765;
    public byte varying_2766;
    public byte varying_2767;
    public byte varying_2768;
    public byte varying_2769;
    public byte varying_2770;
    public byte varying_2771;
    public byte varying_2772;
    public byte varying_2773;
    public byte varying_2774;
    public byte varying_2775;
    public byte varying_2776;
    public byte varying_2777;
    public byte varying_2778;
    public byte varying_2779;
    public byte varying_2780;
    public byte varying_2781;
    public byte varying_2782;
    public byte varying_2783;
    public byte varying_2784;
    public byte varying_2785;
    public byte varying_2786;
    public byte varying_2787;
    public byte varying_2788;
    public byte varying_2789;
    public byte varying_2790;
    public byte varying_2791;
    public byte varying_2792;
    public byte varying_2793;
    public byte varying_2794;
    public byte varying_2795;
    public byte varying_2796;
    public byte varying_2797;
    public byte varying_2798;
    public byte varying_2799;
    public byte varying_2800;
    public byte varying_2801;
    public byte varying_2802;
    public byte varying_2803;
    public byte varying_2804;
    public byte varying_2805;
    public byte varying_2806;
    public byte varying_2807;
    public byte varying_2808;
    public byte varying_2809;
    public byte varying_2810;
    public byte varying_2811;
    public byte varying_2812;
    public byte varying_2813;
    public byte varying_2814;
    public byte varying_2815;
    public byte varying_2816;
    public byte varying_2817;
    public byte varying_2818;
    public byte varying_2819;
    public byte varying_2820;
    public byte varying_2821;
    public byte varying_2822;
    public byte varying_2823;
    public byte varying_2824;
    public byte varying_2825;
    public byte varying_2826;
    public byte varying_2827;
    public byte varying_2828;
    public byte varying_2829;
    public byte varying_2830;
    public byte varying_2831;
    public byte varying_2832;
    public byte varying_2833;
    public byte varying_2834;
    public byte varying_2835;
    public byte varying_2836;
    public byte varying_2837;
    public byte varying_2838;
    public byte varying_2839;
    public byte varying_2840;
    public byte varying_2841;
    public byte varying_2842;
    public byte varying_2843;
    public byte varying_2844;
    public byte varying_2845;
    public byte varying_2846;
    public byte varying_2847;
    public byte varying_2848;
    public byte varying_2849;
    public byte varying_2850;
    public byte varying_2851;
    public byte varying_2852;
    public byte varying_2853;
    public byte varying_2854;
    public byte varying_2855;
    public byte varying_2856;
    public byte varying_2857;
    public byte varying_2858;
    public byte varying_2859;
    public byte varying_2860;
    public byte varying_2861;
    public byte varying_2862;
    public byte varying_2863;
    public byte varying_2864;
    public byte varying_2865;
    public byte varying_2866;
    public byte varying_2867;
    public byte varying_2868;
    public byte varying_2869;
    public byte varying_2870;
    public byte varying_2871;
    public byte varying_2872;
    public byte varying_2873;
    public byte varying_2874;
    public byte varying_2875;
    public byte varying_2876;
    public byte varying_2877;
    public byte varying_2878;
    public byte varying_2879;
    public byte varying_2880;
    public byte varying_2881;
    public byte varying_2882;
    public byte varying_2883;
    public byte varying_2884;
    public byte varying_2885;
    public byte varying_2886;
    public byte varying_2887;
    public byte varying_2888;
    public byte varying_2889;
    public byte varying_2890;
    public byte varying_2891;
    public byte varying_2892;
    public byte varying_2893;
    public byte varying_2894;
    public byte varying_2895;
    public byte varying_2896;
    public byte varying_2897;
    public byte varying_2898;
    public byte varying_2899;
    public byte varying_2900;
    public byte varying_2901;
    public byte varying_2902;
    public byte varying_2903;
    public byte varying_2904;
    public byte varying_2905;
    public byte varying_2906;
    public byte varying_2907;
    public byte varying_2908;
    public byte varying_2909;
    public byte varying_2910;
    public byte varying_2911;
    public byte varying_2912;
    public byte varying_2913;
    public byte varying_2914;
    public byte varying_2915;
    public byte varying_2916;
    public byte varying_2917;
    public byte varying_2918;
    public byte varying_2919;
    public byte varying_2920;
    public byte varying_2921;
    public byte varying_2922;
    public byte varying_2923;
    public byte varying_2924;
    public byte varying_2925;
    public byte varying_2926;
    public byte varying_2927;
    public byte varying_2928;
    public byte varying_2929;
    public byte varying_2930;
    public byte varying_2931;
    public byte varying_2932;
    public byte varying_2933;
    public byte varying_2934;
    public byte varying_2935;
    public byte varying_2936;
    public byte varying_2937;
    public byte varying_2938;
    public byte varying_2939;
    public byte varying_2940;
    public byte varying_2941;
    public byte varying_2942;
    public byte varying_2943;
    public byte varying_2944;
    public byte varying_2945;
    public byte varying_2946;
    public byte varying_2947;
    public byte varying_2948;
    public byte varying_2949;
    public byte varying_2950;
    public byte varying_2951;
    public byte varying_2952;
    public byte varying_2953;
    public byte varying_2954;
    public byte varying_2955;
    public byte varying_2956;
    public byte varying_2957;
    public byte varying_2958;
    public byte varying_2959;
    public byte varying_2960;
    public byte varying_2961;
    public byte varying_2962;
    public byte varying_2963;
    public byte varying_2964;
    public byte varying_2965;
    public byte varying_2966;
    public byte varying_2967;
    public byte varying_2968;
    public byte varying_2969;
    public byte varying_2970;
    public byte varying_2971;
    public byte varying_2972;
    public byte varying_2973;
    public byte varying_2974;
    public byte varying_2975;
    public byte varying_2976;
    public byte varying_2977;
    public byte varying_2978;
    public byte varying_2979;
    public byte varying_2980;
    public byte varying_2981;
    public byte varying_2982;
    public byte varying_2983;
    public byte varying_2984;
    public byte varying_2985;
    public byte varying_2986;
    public byte varying_2987;
    public byte varying_2988;
    public byte varying_2989;
    public byte varying_2990;
    public byte varying_2991;
    public byte varying_2992;
    public byte varying_2993;
    public byte varying_2994;
    public byte varying_2995;
    public byte varying_2996;
    public byte varying_2997;
    public byte varying_2998;
    public byte varying_2999;
    public byte varying_3000;
    public byte varying_3001;
    public byte varying_3002;
    public byte varying_3003;
    public byte varying_3004;
    public byte varying_3005;
    public byte varying_3006;
    public byte varying_3007;
    public byte varying_3008;
    public byte varying_3009;
    public byte varying_3010;
    public byte varying_3011;
    public byte varying_3012;
    public byte varying_3013;
    public byte varying_3014;
    public byte varying_3015;
    public byte varying_3016;
    public byte varying_3017;
    public byte varying_3018;
    public byte varying_3019;
    public byte varying_3020;
    public byte varying_3021;
    public byte varying_3022;
    public byte varying_3023;
    public byte varying_3024;
    public byte varying_3025;
    public byte varying_3026;
    public byte varying_3027;
    public byte varying_3028;
    public byte varying_3029;
    public byte varying_3030;
    public byte varying_3031;
    public byte varying_3032;
    public byte varying_3033;
    public byte varying_3034;
    public byte varying_3035;
    public byte varying_3036;
    public byte varying_3037;
    public byte varying_3038;
    public byte varying_3039;
    public byte varying_3040;
    public byte varying_3041;
    public byte varying_3042;
    public byte varying_3043;
    public byte varying_3044;
    public byte varying_3045;
    public byte varying_3046;
    public byte varying_3047;
    public byte varying_3048;
    public byte varying_3049;
    public byte varying_3050;
    public byte varying_3051;
    public byte varying_3052;
    public byte varying_3053;
    public byte varying_3054;
    public byte varying_3055;
    public byte varying_3056;
    public byte varying_3057;
    public byte varying_3058;
    public byte varying_3059;
    public byte varying_3060;
    public byte varying_3061;
    public byte varying_3062;
    public byte varying_3063;
    public byte varying_3064;
    public byte varying_3065;
    public byte varying_3066;
    public byte varying_3067;
    public byte varying_3068;
    public byte varying_3069;
    public byte varying_3070;
    public byte varying_3071;
    public byte varying_3072;
    public byte varying_3073;
    public byte varying_3074;
    public byte varying_3075;
    public byte varying_3076;
    public byte varying_3077;
    public byte varying_3078;
    public byte varying_3079;
    public byte varying_3080;
    public byte varying_3081;
    public byte varying_3082;
    public byte varying_3083;
    public byte varying_3084;
    public byte varying_3085;
    public byte varying_3086;
    public byte varying_3087;
    public byte varying_3088;
    public byte varying_3089;
    public byte varying_3090;
    public byte varying_3091;
    public byte varying_3092;
    public byte varying_3093;
    public byte varying_3094;
    public byte varying_3095;
    public byte varying_3096;
    public byte varying_3097;
    public byte varying_3098;
    public byte varying_3099;
    public byte varying_3100;
    public byte varying_3101;
    public byte varying_3102;
    public byte varying_3103;
    public byte varying_3104;
    public byte varying_3105;
    public byte varying_3106;
    public byte varying_3107;
    public byte varying_3108;
    public byte varying_3109;
    public byte varying_3110;
    public byte varying_3111;
    public byte varying_3112;
    public byte varying_3113;
    public byte varying_3114;
    public byte varying_3115;
    public byte varying_3116;
    public byte varying_3117;
    public byte varying_3118;
    public byte varying_3119;
    public byte varying_3120;
    public byte varying_3121;
    public byte varying_3122;
    public byte varying_3123;
    public byte varying_3124;
    public byte varying_3125;
    public byte varying_3126;
    public byte varying_3127;
    public byte varying_3128;
    public byte varying_3129;
    public byte varying_3130;
    public byte varying_3131;
    public byte varying_3132;
    public byte varying_3133;
    public byte varying_3134;
    public byte varying_3135;
    public byte varying_3136;
    public byte varying_3137;
    public byte varying_3138;
    public byte varying_3139;
    public byte varying_3140;
    public byte varying_3141;
    public byte varying_3142;
    public byte varying_3143;
    public byte varying_3144;
    public byte varying_3145;
    public byte varying_3146;
    public byte varying_3147;
    public byte varying_3148;
    public byte varying_3149;
    public byte varying_3150;
    public byte varying_3151;
    public byte varying_3152;
    public byte varying_3153;
    public byte varying_3154;
    public byte varying_3155;
    public byte varying_3156;
    public byte varying_3157;
    public byte varying_3158;
    public byte varying_3159;
    public byte varying_3160;
    public byte varying_3161;
    public byte varying_3162;
    public byte varying_3163;
    public byte varying_3164;
    public byte varying_3165;
    public byte varying_3166;
    public byte varying_3167;
    public byte varying_3168;
    public byte varying_3169;
    public byte varying_3170;
    public byte varying_3171;
    public byte varying_3172;
    public byte varying_3173;
    public byte varying_3174;
    public byte varying_3175;
    public byte varying_3176;
    public byte varying_3177;
    public byte varying_3178;
    public byte varying_3179;
    public byte varying_3180;
    public byte varying_3181;
    public byte varying_3182;
    public byte varying_3183;
    public byte varying_3184;
    public byte varying_3185;
    public byte varying_3186;
    public byte varying_3187;
    public byte varying_3188;
    public byte varying_3189;
    public byte varying_3190;
    public byte varying_3191;
    public byte varying_3192;
    public byte varying_3193;
    public byte varying_3194;
    public byte varying_3195;
    public byte varying_3196;
    public byte varying_3197;
    public byte varying_3198;
    public byte varying_3199;
    public byte varying_3200;
    public byte varying_3201;
    public byte varying_3202;
    public byte varying_3203;
    public byte varying_3204;
    public byte varying_3205;
    public byte varying_3206;
    public byte varying_3207;
    public byte varying_3208;
    public byte varying_3209;
    public byte varying_3210;
    public byte varying_3211;
    public byte varying_3212;
    public byte varying_3213;
    public byte varying_3214;
    public byte varying_3215;
    public byte varying_3216;
    public byte varying_3217;
    public byte varying_3218;
    public byte varying_3219;
    public byte varying_3220;
    public byte varying_3221;
    public byte varying_3222;
    public byte varying_3223;
    public byte varying_3224;
    public byte varying_3225;
    public byte varying_3226;
    public byte varying_3227;
    public byte varying_3228;
    public byte varying_3229;
    public byte varying_3230;
    public byte varying_3231;
    public byte varying_3232;
    public byte varying_3233;
    public byte varying_3234;
    public byte varying_3235;
    public byte varying_3236;
    public byte varying_3237;
    public byte varying_3238;
    public byte varying_3239;
    public byte varying_3240;
    public byte varying_3241;
    public byte varying_3242;
    public byte varying_3243;
    public byte varying_3244;
    public byte varying_3245;
    public byte varying_3246;
    public byte varying_3247;
    public byte varying_3248;
    public byte varying_3249;
    public byte varying_3250;
    public byte varying_3251;
    public byte varying_3252;
    public byte varying_3253;
    public byte varying_3254;
    public byte varying_3255;
    public byte varying_3256;
    public byte varying_3257;
    public byte varying_3258;
    public byte varying_3259;
    public byte varying_3260;
    public byte varying_3261;
    public byte varying_3262;
    public byte varying_3263;
    public byte varying_3264;
    public byte varying_3265;
    public byte varying_3266;
    public byte varying_3267;
    public byte varying_3268;
    public byte varying_3269;
    public byte varying_3270;
    public byte varying_3271;
    public byte varying_3272;
    public byte varying_3273;
    public byte varying_3274;
    public byte varying_3275;
    public byte varying_3276;
    public byte varying_3277;
    public byte varying_3278;
    public byte varying_3279;
    public byte varying_3280;
    public byte varying_3281;
    public byte varying_3282;
    public byte varying_3283;
    public byte varying_3284;
    public byte varying_3285;
    public byte varying_3286;
    public byte varying_3287;
    public byte varying_3288;
    public byte varying_3289;
    public byte varying_3290;
    public byte varying_3291;
    public byte varying_3292;
    public byte varying_3293;
    public byte varying_3294;
    public byte varying_3295;
    public byte varying_3296;
    public byte varying_3297;
    public byte varying_3298;
    public byte varying_3299;
    public byte varying_3300;
    public byte varying_3301;
    public byte varying_3302;
    public byte varying_3303;
    public byte varying_3304;
    public byte varying_3305;
    public byte varying_3306;
    public byte varying_3307;
    public byte varying_3308;
    public byte varying_3309;
    public byte varying_3310;
    public byte varying_3311;
    public byte varying_3312;
    public byte varying_3313;
    public byte varying_3314;
    public byte varying_3315;
    public byte varying_3316;
    public byte varying_3317;
    public byte varying_3318;
    public byte varying_3319;
    public byte varying_3320;
    public byte varying_3321;
    public byte varying_3322;
    public byte varying_3323;
    public byte varying_3324;
    public byte varying_3325;
    public byte varying_3326;
    public byte varying_3327;
    public byte varying_3328;
    public byte varying_3329;
    public byte varying_3330;
    public byte varying_3331;
    public byte varying_3332;
    public byte varying_3333;
    public byte varying_3334;
    public byte varying_3335;
    public byte varying_3336;
    public byte varying_3337;
    public byte varying_3338;
    public byte varying_3339;
    public byte varying_3340;
    public byte varying_3341;
    public byte varying_3342;
    public byte varying_3343;
    public byte varying_3344;
    public byte varying_3345;
    public byte varying_3346;
    public byte varying_3347;
    public byte varying_3348;
    public byte varying_3349;
    public byte varying_3350;
    public byte varying_3351;
    public byte varying_3352;
    public byte varying_3353;
    public byte varying_3354;
    public byte varying_3355;
    public byte varying_3356;
    public byte varying_3357;
    public byte varying_3358;
    public byte varying_3359;
    public byte varying_3360;
    public byte varying_3361;
    public byte varying_3362;
    public byte varying_3363;
    public byte varying_3364;
    public byte varying_3365;
    public byte varying_3366;
    public byte varying_3367;
    public byte varying_3368;
    public byte varying_3369;
    public byte varying_3370;
    public byte varying_3371;
    public byte varying_3372;
    public byte varying_3373;
    public byte varying_3374;
    public byte varying_3375;
    public byte varying_3376;
    public byte varying_3377;
    public byte varying_3378;
    public byte varying_3379;
    public byte varying_3380;
    public byte varying_3381;
    public byte varying_3382;
    public byte varying_3383;
    public byte varying_3384;
    public byte varying_3385;
    public byte varying_3386;
    public byte varying_3387;
    public byte varying_3388;
    public byte varying_3389;
    public byte varying_3390;
    public byte varying_3391;
    public byte varying_3392;
    public byte varying_3393;
    public byte varying_3394;
    public byte varying_3395;
    public byte varying_3396;
    public byte varying_3397;
    public byte varying_3398;
    public byte varying_3399;
    public byte varying_3400;
    public byte varying_3401;
    public byte varying_3402;
    public byte varying_3403;
    public byte varying_3404;
    public byte varying_3405;
    public byte varying_3406;
    public byte varying_3407;
    public byte varying_3408;
    public byte varying_3409;
    public byte varying_3410;
    public byte varying_3411;
    public byte varying_3412;
    public byte varying_3413;
    public byte varying_3414;
    public byte varying_3415;
    public byte varying_3416;
    public byte varying_3417;
    public byte varying_3418;
    public byte varying_3419;
    public byte varying_3420;
    public byte varying_3421;
    public byte varying_3422;
    public byte varying_3423;
    public byte varying_3424;
    public byte varying_3425;
    public byte varying_3426;
    public byte varying_3427;
    public byte varying_3428;
    public byte varying_3429;
    public byte varying_3430;
    public byte varying_3431;
    public byte varying_3432;
    public byte varying_3433;
    public byte varying_3434;
    public byte varying_3435;
    public byte varying_3436;
    public byte varying_3437;
    public byte varying_3438;
    public byte varying_3439;
    public byte varying_3440;
    public byte varying_3441;
    public byte varying_3442;
    public byte varying_3443;
    public byte varying_3444;
    public byte varying_3445;
    public byte varying_3446;
    public byte varying_3447;
    public byte varying_3448;
    public byte varying_3449;
    public byte varying_3450;
    public byte varying_3451;
    public byte varying_3452;
    public byte varying_3453;
    public byte varying_3454;
    public byte varying_3455;
    public byte varying_3456;
    public byte varying_3457;
    public byte varying_3458;
    public byte varying_3459;
    public byte varying_3460;
    public byte varying_3461;
    public byte varying_3462;
    public byte varying_3463;
    public byte varying_3464;
    public byte varying_3465;
    public byte varying_3466;
    public byte varying_3467;
    public byte varying_3468;
    public byte varying_3469;
    public byte varying_3470;
    public byte varying_3471;
    public byte varying_3472;
    public byte varying_3473;
    public byte varying_3474;
    public byte varying_3475;
    public byte varying_3476;
    public byte varying_3477;
    public byte varying_3478;
    public byte varying_3479;
    public byte varying_3480;
    public byte varying_3481;
    public byte varying_3482;
    public byte varying_3483;
    public byte varying_3484;
    public byte varying_3485;
    public byte varying_3486;
    public byte varying_3487;
    public byte varying_3488;
    public byte varying_3489;
    public byte varying_3490;
    public byte varying_3491;
    public byte varying_3492;
    public byte varying_3493;
    public byte varying_3494;
    public byte varying_3495;
    public byte varying_3496;
    public byte varying_3497;
    public byte varying_3498;
    public byte varying_3499;
    public byte varying_3500;
    public byte varying_3501;
    public byte varying_3502;
    public byte varying_3503;
    public byte varying_3504;
    public byte varying_3505;
    public byte varying_3506;
    public byte varying_3507;
    public byte varying_3508;
    public byte varying_3509;
    public byte varying_3510;
    public byte varying_3511;
    public byte varying_3512;
    public byte varying_3513;
    public byte varying_3514;
    public byte varying_3515;
    public byte varying_3516;
    public byte varying_3517;
    public byte varying_3518;
    public byte varying_3519;
    public byte varying_3520;
    public byte varying_3521;
    public byte varying_3522;
    public byte varying_3523;
    public byte varying_3524;
    public byte varying_3525;
    public byte varying_3526;
    public byte varying_3527;
    public byte varying_3528;
    public byte varying_3529;
    public byte varying_3530;
    public byte varying_3531;
    public byte varying_3532;
    public byte varying_3533;
    public byte varying_3534;
    public byte varying_3535;
    public byte varying_3536;
    public byte varying_3537;
    public byte varying_3538;
    public byte varying_3539;
    public byte varying_3540;
    public byte varying_3541;
    public byte varying_3542;
    public byte varying_3543;
    public byte varying_3544;
    public byte varying_3545;
    public byte varying_3546;
    public byte varying_3547;
    public byte varying_3548;
    public byte varying_3549;
    public byte varying_3550;
    public byte varying_3551;
    public byte varying_3552;
    public byte varying_3553;
    public byte varying_3554;
    public byte varying_3555;
    public byte varying_3556;
    public byte varying_3557;
    public byte varying_3558;
    public byte varying_3559;
    public byte varying_3560;
    public byte varying_3561;
    public byte varying_3562;
    public byte varying_3563;
    public byte varying_3564;
    public byte varying_3565;
    public byte varying_3566;
    public byte varying_3567;
    public byte varying_3568;
    public byte varying_3569;
    public byte varying_3570;
    public byte varying_3571;
    public byte varying_3572;
    public byte varying_3573;
    public byte varying_3574;
    public byte varying_3575;
    public byte varying_3576;
    public byte varying_3577;
    public byte varying_3578;
    public byte varying_3579;
    public byte varying_3580;
    public byte varying_3581;
    public byte varying_3582;
    public byte varying_3583;
    public byte varying_3584;
    public byte varying_3585;
    public byte varying_3586;
    public byte varying_3587;
    public byte varying_3588;
    public byte varying_3589;
    public byte varying_3590;
    public byte varying_3591;
    public byte varying_3592;
    public byte varying_3593;
    public byte varying_3594;
    public byte varying_3595;
    public byte varying_3596;
    public byte varying_3597;
    public byte varying_3598;
    public byte varying_3599;
    public byte varying_3600;
    public byte varying_3601;
    public byte varying_3602;
    public byte varying_3603;
    public byte varying_3604;
    public byte varying_3605;
    public byte varying_3606;
    public byte varying_3607;
    public byte varying_3608;
    public byte varying_3609;
    public byte varying_3610;
    public byte varying_3611;
    public byte varying_3612;
    public byte varying_3613;
    public byte varying_3614;
    public byte varying_3615;
    public byte varying_3616;
    public byte varying_3617;
    public byte varying_3618;
    public byte varying_3619;
    public byte varying_3620;
    public byte varying_3621;
    public byte varying_3622;
    public byte varying_3623;
    public byte varying_3624;
    public byte varying_3625;
    public byte varying_3626;
    public byte varying_3627;
    public byte varying_3628;
    public byte varying_3629;
    public byte varying_3630;
    public byte varying_3631;
    public byte varying_3632;
    public byte varying_3633;
    public byte varying_3634;
    public byte varying_3635;
    public byte varying_3636;
    public byte varying_3637;
    public byte varying_3638;
    public byte varying_3639;
    public byte varying_3640;
    public byte varying_3641;
    public byte varying_3642;
    public byte varying_3643;
    public byte varying_3644;
    public byte varying_3645;
    public byte varying_3646;
    public byte varying_3647;
    public byte varying_3648;
    public byte varying_3649;
    public byte varying_3650;
    public byte varying_3651;
    public byte varying_3652;
    public byte varying_3653;
    public byte varying_3654;
    public byte varying_3655;
    public byte varying_3656;
    public byte varying_3657;
    public byte varying_3658;
    public byte varying_3659;
    public byte varying_3660;
    public byte varying_3661;
    public byte varying_3662;
    public byte varying_3663;
    public byte varying_3664;
    public byte varying_3665;
    public byte varying_3666;
    public byte varying_3667;
    public byte varying_3668;
    public byte varying_3669;
    public byte varying_3670;
    public byte varying_3671;
    public byte varying_3672;
    public byte varying_3673;
    public byte varying_3674;
    public byte varying_3675;
    public byte varying_3676;
    public byte varying_3677;
    public byte varying_3678;
    public byte varying_3679;
    public byte varying_3680;
    public byte varying_3681;
    public byte varying_3682;
    public byte varying_3683;
    public byte varying_3684;
    public byte varying_3685;
    public byte varying_3686;
    public byte varying_3687;
    public byte varying_3688;
    public byte varying_3689;
    public byte varying_3690;
    public byte varying_3691;
    public byte varying_3692;
    public byte varying_3693;
    public byte varying_3694;
    public byte varying_3695;
    public byte varying_3696;
    public byte varying_3697;
    public byte varying_3698;
    public byte varying_3699;
    public byte varying_3700;
    public byte varying_3701;
    public byte varying_3702;
    public byte varying_3703;
    public byte varying_3704;
    public byte varying_3705;
    public byte varying_3706;
    public byte varying_3707;
    public byte varying_3708;
    public byte varying_3709;
    public byte varying_3710;
    public byte varying_3711;
    public byte varying_3712;
    public byte varying_3713;
    public byte varying_3714;
    public byte varying_3715;
    public byte varying_3716;
    public byte varying_3717;
    public byte varying_3718;
    public byte varying_3719;
    public byte varying_3720;
    public byte varying_3721;
    public byte varying_3722;
    public byte varying_3723;
    public byte varying_3724;
    public byte varying_3725;
    public byte varying_3726;
    public byte varying_3727;
    public byte varying_3728;
    public byte varying_3729;
    public byte varying_3730;
    public byte varying_3731;
    public byte varying_3732;
    public byte varying_3733;
    public byte varying_3734;
    public byte varying_3735;
    public byte varying_3736;
    public byte varying_3737;
    public byte varying_3738;
    public byte varying_3739;
    public byte varying_3740;
    public byte varying_3741;
    public byte varying_3742;
    public byte varying_3743;
    public byte varying_3744;
    public byte varying_3745;
    public byte varying_3746;
    public byte varying_3747;
    public byte varying_3748;
    public byte varying_3749;
    public byte varying_3750;
    public byte varying_3751;
    public byte varying_3752;
    public byte varying_3753;
    public byte varying_3754;
    public byte varying_3755;
    public byte varying_3756;
    public byte varying_3757;
    public byte varying_3758;
    public byte varying_3759;
    public byte varying_3760;
    public byte varying_3761;
    public byte varying_3762;
    public byte varying_3763;
    public byte varying_3764;
    public byte varying_3765;
    public byte varying_3766;
    public byte varying_3767;
    public byte varying_3768;
    public byte varying_3769;
    public byte varying_3770;
    public byte varying_3771;
    public byte varying_3772;
    public byte varying_3773;
    public byte varying_3774;
    public byte varying_3775;
    public byte varying_3776;
    public byte varying_3777;
    public byte varying_3778;
    public byte varying_3779;
    public byte varying_3780;
    public byte varying_3781;
    public byte varying_3782;
    public byte varying_3783;
    public byte varying_3784;
    public byte varying_3785;
    public byte varying_3786;
    public byte varying_3787;
    public byte varying_3788;
    public byte varying_3789;
    public byte varying_3790;
    public byte varying_3791;
    public byte varying_3792;
    public byte varying_3793;
    public byte varying_3794;
    public byte varying_3795;
    public byte varying_3796;
    public byte varying_3797;
    public byte varying_3798;
    public byte varying_3799;
    public byte varying_3800;
    public byte varying_3801;
    public byte varying_3802;
    public byte varying_3803;
    public byte varying_3804;
    public byte varying_3805;
    public byte varying_3806;
    public byte varying_3807;
    public byte varying_3808;
    public byte varying_3809;
    public byte varying_3810;
    public byte varying_3811;
    public byte varying_3812;
    public byte varying_3813;
    public byte varying_3814;
    public byte varying_3815;
    public byte varying_3816;
    public byte varying_3817;
    public byte varying_3818;
    public byte varying_3819;
    public byte varying_3820;
    public byte varying_3821;
    public byte varying_3822;
    public byte varying_3823;
    public byte varying_3824;
    public byte varying_3825;
    public byte varying_3826;
    public byte varying_3827;
    public byte varying_3828;
    public byte varying_3829;
    public byte varying_3830;
    public byte varying_3831;
    public byte varying_3832;
    public byte varying_3833;
    public byte varying_3834;
    public byte varying_3835;
    public byte varying_3836;
    public byte varying_3837;
    public byte varying_3838;
    public byte varying_3839;
    public byte varying_3840;
    public byte varying_3841;
    public byte varying_3842;
    public byte varying_3843;
    public byte varying_3844;
    public byte varying_3845;
    public byte varying_3846;
    public byte varying_3847;
    public byte varying_3848;
    public byte varying_3849;
    public byte varying_3850;
    public byte varying_3851;
    public byte varying_3852;
    public byte varying_3853;
    public byte varying_3854;
    public byte varying_3855;
    public byte varying_3856;
    public byte varying_3857;
    public byte varying_3858;
    public byte varying_3859;
    public byte varying_3860;
    public byte varying_3861;
    public byte varying_3862;
    public byte varying_3863;
    public byte varying_3864;
    public byte varying_3865;
    public byte varying_3866;
    public byte varying_3867;
    public byte varying_3868;
    public byte varying_3869;
    public byte varying_3870;
    public byte varying_3871;
    public byte varying_3872;
    public byte varying_3873;
    public byte varying_3874;
    public byte varying_3875;
    public byte varying_3876;
    public byte varying_3877;
    public byte varying_3878;
    public byte varying_3879;
    public byte varying_3880;
    public byte varying_3881;
    public byte varying_3882;
    public byte varying_3883;
    public byte varying_3884;
    public byte varying_3885;
    public byte varying_3886;
    public byte varying_3887;
    public byte varying_3888;
    public byte varying_3889;
    public byte varying_3890;
    public byte varying_3891;
    public byte varying_3892;
    public byte varying_3893;
    public byte varying_3894;
    public byte varying_3895;
    public byte varying_3896;
    public byte varying_3897;
    public byte varying_3898;
    public byte varying_3899;
    public byte varying_3900;
    public byte varying_3901;
    public byte varying_3902;
    public byte varying_3903;
    public byte varying_3904;
    public byte varying_3905;
    public byte varying_3906;
    public byte varying_3907;
    public byte varying_3908;
    public byte varying_3909;
    public byte varying_3910;
    public byte varying_3911;
    public byte varying_3912;
    public byte varying_3913;
    public byte varying_3914;
    public byte varying_3915;
    public byte varying_3916;
    public byte varying_3917;
    public byte varying_3918;
    public byte varying_3919;
    public byte varying_3920;
    public byte varying_3921;
    public byte varying_3922;
    public byte varying_3923;
    public byte varying_3924;
    public byte varying_3925;
    public byte varying_3926;
    public byte varying_3927;
    public byte varying_3928;
    public byte varying_3929;
    public byte varying_3930;
    public byte varying_3931;
    public byte varying_3932;
    public byte varying_3933;
    public byte varying_3934;
    public byte varying_3935;
    public byte varying_3936;
    public byte varying_3937;
    public byte varying_3938;
    public byte varying_3939;
    public byte varying_3940;
    public byte varying_3941;
    public byte varying_3942;
    public byte varying_3943;
    public byte varying_3944;
    public byte varying_3945;
    public byte varying_3946;
    public byte varying_3947;
    public byte varying_3948;
    public byte varying_3949;
    public byte varying_3950;
    public byte varying_3951;
    public byte varying_3952;
    public byte varying_3953;
    public byte varying_3954;
    public byte varying_3955;
    public byte varying_3956;
    public byte varying_3957;
    public byte varying_3958;
    public byte varying_3959;
    public byte varying_3960;
    public byte varying_3961;
    public byte varying_3962;
    public byte varying_3963;
    public byte varying_3964;
    public byte varying_3965;
    public byte varying_3966;
    public byte varying_3967;
    public byte varying_3968;
    public byte varying_3969;
    public byte varying_3970;
    public byte varying_3971;
    public byte varying_3972;
    public byte varying_3973;
    public byte varying_3974;
    public byte varying_3975;
    public byte varying_3976;
    public byte varying_3977;
    public byte varying_3978;
    public byte varying_3979;
    public byte varying_3980;
    public byte varying_3981;
    public byte varying_3982;
    public byte varying_3983;
    public byte varying_3984;
    public byte varying_3985;
    public byte varying_3986;
    public byte varying_3987;
    public byte varying_3988;
    public byte varying_3989;
    public byte varying_3990;
    public byte varying_3991;
    public byte varying_3992;
    public byte varying_3993;
    public byte varying_3994;
    public byte varying_3995;
    public byte varying_3996;
    public byte varying_3997;
    public byte varying_3998;
    public byte varying_3999;
    /// <returns>a new <see cref="XrEventDataBuffer"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_BUFFER"/></returns>
    public static XrEventDataBuffer New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_BUFFER };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataEventsLost
{
    public XrStructureType type;
    public void* next;
    public uint lostEventCount;
    /// <returns>a new <see cref="XrEventDataEventsLost"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_EVENTS_LOST"/></returns>
    public static XrEventDataEventsLost New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_EVENTS_LOST };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataInstanceLossPending
{
    public XrStructureType type;
    public void* next;
    public long lossTime;
    /// <returns>a new <see cref="XrEventDataInstanceLossPending"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_INSTANCE_LOSS_PENDING"/></returns>
    public static XrEventDataInstanceLossPending New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_INSTANCE_LOSS_PENDING };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataSessionStateChanged
{
    public XrStructureType type;
    public void* next;
    public XrSession session;
    public XrSessionState state;
    public long time;
    /// <returns>a new <see cref="XrEventDataSessionStateChanged"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_SESSION_STATE_CHANGED"/></returns>
    public static XrEventDataSessionStateChanged New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_SESSION_STATE_CHANGED };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataReferenceSpaceChangePending
{
    public XrStructureType type;
    public void* next;
    public XrSession session;
    public XrReferenceSpaceType referenceSpaceType;
    public long changeTime;
    public XrBool32 poseValid;
    public XrPosef poseInPreviousSpace;
    /// <returns>a new <see cref="XrEventDataReferenceSpaceChangePending"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_REFERENCE_SPACE_CHANGE_PENDING"/></returns>
    public static XrEventDataReferenceSpaceChangePending New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_REFERENCE_SPACE_CHANGE_PENDING };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataPerfSettingsEXT
{
    public XrStructureType type;
    public void* next;
    public XrPerfSettingsDomainEXT domain;
    public XrPerfSettingsSubDomainEXT subDomain;
    public XrPerfSettingsNotificationLevelEXT fromLevel;
    public XrPerfSettingsNotificationLevelEXT toLevel;
    /// <returns>a new <see cref="XrEventDataPerfSettingsEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_PERF_SETTINGS_EXT"/></returns>
    public static XrEventDataPerfSettingsEXT New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_PERF_SETTINGS_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataVisibilityMaskChangedKHR
{
    public XrStructureType type;
    public void* next;
    public XrSession session;
    public XrViewConfigurationType viewConfigurationType;
    public uint viewIndex;
    /// <returns>a new <see cref="XrEventDataVisibilityMaskChangedKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_VISIBILITY_MASK_CHANGED_KHR"/></returns>
    public static XrEventDataVisibilityMaskChangedKHR New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_VISIBILITY_MASK_CHANGED_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrViewConfigurationProperties
{
    public XrStructureType type;
    public void* next;
    public XrViewConfigurationType viewConfigurationType;
    public XrBool32 fovMutable;
    /// <returns>a new <see cref="XrViewConfigurationProperties"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIEW_CONFIGURATION_PROPERTIES"/></returns>
    public static XrViewConfigurationProperties New() =>
        new() { type = XrStructureType.XR_TYPE_VIEW_CONFIGURATION_PROPERTIES };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActionStateBoolean
{
    public XrStructureType type;
    public void* next;
    public XrBool32 currentState;
    public XrBool32 changedSinceLastSync;
    public long lastChangeTime;
    public XrBool32 isActive;
    /// <returns>a new <see cref="XrActionStateBoolean"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ACTION_STATE_BOOLEAN"/></returns>
    public static XrActionStateBoolean New() =>
        new() { type = XrStructureType.XR_TYPE_ACTION_STATE_BOOLEAN };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActionStateFloat
{
    public XrStructureType type;
    public void* next;
    public float currentState;
    public XrBool32 changedSinceLastSync;
    public long lastChangeTime;
    public XrBool32 isActive;
    /// <returns>a new <see cref="XrActionStateFloat"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ACTION_STATE_FLOAT"/></returns>
    public static XrActionStateFloat New() =>
        new() { type = XrStructureType.XR_TYPE_ACTION_STATE_FLOAT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActionStateVector2f
{
    public XrStructureType type;
    public void* next;
    public XrVector2f currentState;
    public XrBool32 changedSinceLastSync;
    public long lastChangeTime;
    public XrBool32 isActive;
    /// <returns>a new <see cref="XrActionStateVector2f"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ACTION_STATE_VECTOR2F"/></returns>
    public static XrActionStateVector2f New() =>
        new() { type = XrStructureType.XR_TYPE_ACTION_STATE_VECTOR2F };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActionStatePose
{
    public XrStructureType type;
    public void* next;
    public XrBool32 isActive;
    /// <returns>a new <see cref="XrActionStatePose"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ACTION_STATE_POSE"/></returns>
    public static XrActionStatePose New() =>
        new() { type = XrStructureType.XR_TYPE_ACTION_STATE_POSE };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActionStateGetInfo
{
    public XrStructureType type;
    public void* next;
    public XrAction action;
    public ulong subactionPath;
    /// <returns>a new <see cref="XrActionStateGetInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ACTION_STATE_GET_INFO"/></returns>
    public static XrActionStateGetInfo New() =>
        new() { type = XrStructureType.XR_TYPE_ACTION_STATE_GET_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHapticActionInfo
{
    public XrStructureType type;
    public void* next;
    public XrAction action;
    public ulong subactionPath;
    /// <returns>a new <see cref="XrHapticActionInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAPTIC_ACTION_INFO"/></returns>
    public static XrHapticActionInfo New() =>
        new() { type = XrStructureType.XR_TYPE_HAPTIC_ACTION_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActionSetCreateInfo
{
    public XrStructureType type;
    public void* next;
    public fixed byte actionSetName[(int)OpenXRNative.XR_MAX_ACTION_SET_NAME_SIZE];
    public fixed byte localizedActionSetName[(int)OpenXRNative.XR_MAX_LOCALIZED_ACTION_SET_NAME_SIZE];
    public uint priority;
    /// <returns>a new <see cref="XrActionSetCreateInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ACTION_SET_CREATE_INFO"/></returns>
    public static XrActionSetCreateInfo New() =>
        new() { type = XrStructureType.XR_TYPE_ACTION_SET_CREATE_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActionSuggestedBinding
{
    public XrAction action;
    public ulong binding;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrInteractionProfileSuggestedBinding
{
    public XrStructureType type;
    public void* next;
    public ulong interactionProfile;
    public uint countSuggestedBindings;
    public XrActionSuggestedBinding* suggestedBindings;
    /// <returns>a new <see cref="XrInteractionProfileSuggestedBinding"> with it's type member set to <see cref="XrStructureType.XR_TYPE_INTERACTION_PROFILE_SUGGESTED_BINDING"/></returns>
    public static XrInteractionProfileSuggestedBinding New() =>
        new() { type = XrStructureType.XR_TYPE_INTERACTION_PROFILE_SUGGESTED_BINDING };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActiveActionSet
{
    public XrActionSet actionSet;
    public ulong subactionPath;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSessionActionSetsAttachInfo
{
    public XrStructureType type;
    public void* next;
    public uint countActionSets;
    public XrActionSet* actionSets;
    /// <returns>a new <see cref="XrSessionActionSetsAttachInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SESSION_ACTION_SETS_ATTACH_INFO"/></returns>
    public static XrSessionActionSetsAttachInfo New() =>
        new() { type = XrStructureType.XR_TYPE_SESSION_ACTION_SETS_ATTACH_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActionsSyncInfo
{
    public XrStructureType type;
    public void* next;
    public uint countActiveActionSets;
    public XrActiveActionSet* activeActionSets;
    /// <returns>a new <see cref="XrActionsSyncInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ACTIONS_SYNC_INFO"/></returns>
    public static XrActionsSyncInfo New() =>
        new() { type = XrStructureType.XR_TYPE_ACTIONS_SYNC_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBoundSourcesForActionEnumerateInfo
{
    public XrStructureType type;
    public void* next;
    public XrAction action;
    /// <returns>a new <see cref="XrBoundSourcesForActionEnumerateInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_BOUND_SOURCES_FOR_ACTION_ENUMERATE_INFO"/></returns>
    public static XrBoundSourcesForActionEnumerateInfo New() =>
        new() { type = XrStructureType.XR_TYPE_BOUND_SOURCES_FOR_ACTION_ENUMERATE_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrInputSourceLocalizedNameGetInfo
{
    public XrStructureType type;
    public void* next;
    public ulong sourcePath;
    public ulong whichComponents;
    /// <returns>a new <see cref="XrInputSourceLocalizedNameGetInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_INPUT_SOURCE_LOCALIZED_NAME_GET_INFO"/></returns>
    public static XrInputSourceLocalizedNameGetInfo New() =>
        new() { type = XrStructureType.XR_TYPE_INPUT_SOURCE_LOCALIZED_NAME_GET_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataInteractionProfileChanged
{
    public XrStructureType type;
    public void* next;
    public XrSession session;
    /// <returns>a new <see cref="XrEventDataInteractionProfileChanged"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_INTERACTION_PROFILE_CHANGED"/></returns>
    public static XrEventDataInteractionProfileChanged New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_INTERACTION_PROFILE_CHANGED };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrInteractionProfileState
{
    public XrStructureType type;
    public void* next;
    public ulong interactionProfile;
    /// <returns>a new <see cref="XrInteractionProfileState"> with it's type member set to <see cref="XrStructureType.XR_TYPE_INTERACTION_PROFILE_STATE"/></returns>
    public static XrInteractionProfileState New() =>
        new() { type = XrStructureType.XR_TYPE_INTERACTION_PROFILE_STATE };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActionCreateInfo
{
    public XrStructureType type;
    public void* next;
    public fixed byte actionName[(int)OpenXRNative.XR_MAX_ACTION_NAME_SIZE];
    public XrActionType actionType;
    public uint countSubactionPaths;
    public ulong* subactionPaths;
    public fixed byte localizedActionName[(int)OpenXRNative.XR_MAX_LOCALIZED_ACTION_NAME_SIZE];
    /// <returns>a new <see cref="XrActionCreateInfo"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ACTION_CREATE_INFO"/></returns>
    public static XrActionCreateInfo New() =>
        new() { type = XrStructureType.XR_TYPE_ACTION_CREATE_INFO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrInstanceCreateInfoAndroidKHR
{
    public XrStructureType type;
    public void* next;
    public void* applicationVM;
    public void* applicationActivity;
    /// <returns>a new <see cref="XrInstanceCreateInfoAndroidKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_INSTANCE_CREATE_INFO_ANDROID_KHR"/></returns>
    public static XrInstanceCreateInfoAndroidKHR New() =>
        new() { type = XrStructureType.XR_TYPE_INSTANCE_CREATE_INFO_ANDROID_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVulkanSwapchainFormatListCreateInfoKHR
{
    public XrStructureType type;
    public void* next;
    public uint viewFormatCount;
    public nint* viewFormats;
    /// <returns>a new <see cref="XrVulkanSwapchainFormatListCreateInfoKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VULKAN_SWAPCHAIN_FORMAT_LIST_CREATE_INFO_KHR"/></returns>
    public static XrVulkanSwapchainFormatListCreateInfoKHR New() =>
        new() { type = XrStructureType.XR_TYPE_VULKAN_SWAPCHAIN_FORMAT_LIST_CREATE_INFO_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrDebugUtilsObjectNameInfoEXT
{
    public XrStructureType type;
    public void* next;
    public XrObjectType objectType;
    public ulong objectHandle;
    public byte* objectName;
    /// <returns>a new <see cref="XrDebugUtilsObjectNameInfoEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT"/></returns>
    public static XrDebugUtilsObjectNameInfoEXT New() =>
        new() { type = XrStructureType.XR_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrDebugUtilsLabelEXT
{
    public XrStructureType type;
    public void* next;
    public byte* labelName;
    /// <returns>a new <see cref="XrDebugUtilsLabelEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_DEBUG_UTILS_LABEL_EXT"/></returns>
    public static XrDebugUtilsLabelEXT New() =>
        new() { type = XrStructureType.XR_TYPE_DEBUG_UTILS_LABEL_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrDebugUtilsMessengerCallbackDataEXT
{
    public XrStructureType type;
    public void* next;
    public byte* messageId;
    public byte* functionName;
    public byte* message;
    public uint objectCount;
    public XrDebugUtilsObjectNameInfoEXT* objects;
    public uint sessionLabelCount;
    public XrDebugUtilsLabelEXT* sessionLabels;
    /// <returns>a new <see cref="XrDebugUtilsMessengerCallbackDataEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT"/></returns>
    public static XrDebugUtilsMessengerCallbackDataEXT New() =>
        new() { type = XrStructureType.XR_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrDebugUtilsMessengerCreateInfoEXT
{
    public XrStructureType type;
    public void* next;
    public ulong messageSeverities;
    public ulong messageTypes;
    public delegate* unmanaged [Stdcall]<XrDebugUtilsMessageSeverityFlagsEXT, XrDebugUtilsMessageTypeFlagsEXT, XrDebugUtilsMessengerCallbackDataEXT*, void*, XrBool32> userCallback;
    public void* userData;
    /// <returns>a new <see cref="XrDebugUtilsMessengerCreateInfoEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT"/></returns>
    public static XrDebugUtilsMessengerCreateInfoEXT New() =>
        new() { type = XrStructureType.XR_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVisibilityMaskKHR
{
    public XrStructureType type;
    public void* next;
    public uint vertexCapacityInput;
    public uint vertexCountOutput;
    public XrVector2f* vertices;
    public uint indexCapacityInput;
    public uint indexCountOutput;
    public uint* indices;
    /// <returns>a new <see cref="XrVisibilityMaskKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VISIBILITY_MASK_KHR"/></returns>
    public static XrVisibilityMaskKHR New() =>
        new() { type = XrStructureType.XR_TYPE_VISIBILITY_MASK_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsRequirementsOpenGLKHR
{
    public XrStructureType type;
    public void* next;
    public ulong minApiVersionSupported;
    public ulong maxApiVersionSupported;
    /// <returns>a new <see cref="XrGraphicsRequirementsOpenGLKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_KHR"/></returns>
    public static XrGraphicsRequirementsOpenGLKHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsRequirementsOpenGLESKHR
{
    public XrStructureType type;
    public void* next;
    public ulong minApiVersionSupported;
    public ulong maxApiVersionSupported;
    /// <returns>a new <see cref="XrGraphicsRequirementsOpenGLESKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_ES_KHR"/></returns>
    public static XrGraphicsRequirementsOpenGLESKHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_ES_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsRequirementsVulkanKHR
{
    public XrStructureType type;
    public void* next;
    public ulong minApiVersionSupported;
    public ulong maxApiVersionSupported;
    /// <returns>a new <see cref="XrGraphicsRequirementsVulkanKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN_KHR"/></returns>
    public static XrGraphicsRequirementsVulkanKHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsRequirementsD3D11KHR
{
    public XrStructureType type;
    public void* next;
    public nint adapterLuid;
    public uint minFeatureLevel;
    /// <returns>a new <see cref="XrGraphicsRequirementsD3D11KHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_REQUIREMENTS_D3D11_KHR"/></returns>
    public static XrGraphicsRequirementsD3D11KHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_REQUIREMENTS_D3D11_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsRequirementsD3D12KHR
{
    public XrStructureType type;
    public void* next;
    public nint adapterLuid;
    public uint minFeatureLevel;
    /// <returns>a new <see cref="XrGraphicsRequirementsD3D12KHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_REQUIREMENTS_D3D12_KHR"/></returns>
    public static XrGraphicsRequirementsD3D12KHR New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_REQUIREMENTS_D3D12_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVulkanInstanceCreateInfoKHR
{
    public XrStructureType type;
    public void* next;
    public ulong systemId;
    public ulong createFlags;
    public void* pfnGetInstanceProcAddr;
    public nint* vulkanCreateInfo;
    public nint* vulkanAllocator;
    /// <returns>a new <see cref="XrVulkanInstanceCreateInfoKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VULKAN_INSTANCE_CREATE_INFO_KHR"/></returns>
    public static XrVulkanInstanceCreateInfoKHR New() =>
        new() { type = XrStructureType.XR_TYPE_VULKAN_INSTANCE_CREATE_INFO_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVulkanDeviceCreateInfoKHR
{
    public XrStructureType type;
    public void* next;
    public ulong systemId;
    public ulong createFlags;
    public void* pfnGetInstanceProcAddr;
    public nint vulkanPhysicalDevice;
    public nint* vulkanCreateInfo;
    public nint* vulkanAllocator;
    /// <returns>a new <see cref="XrVulkanDeviceCreateInfoKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VULKAN_DEVICE_CREATE_INFO_KHR"/></returns>
    public static XrVulkanDeviceCreateInfoKHR New() =>
        new() { type = XrStructureType.XR_TYPE_VULKAN_DEVICE_CREATE_INFO_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVulkanGraphicsDeviceGetInfoKHR
{
    public XrStructureType type;
    public void* next;
    public ulong systemId;
    public nint vulkanInstance;
    /// <returns>a new <see cref="XrVulkanGraphicsDeviceGetInfoKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VULKAN_GRAPHICS_DEVICE_GET_INFO_KHR"/></returns>
    public static XrVulkanGraphicsDeviceGetInfoKHR New() =>
        new() { type = XrStructureType.XR_TYPE_VULKAN_GRAPHICS_DEVICE_GET_INFO_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVulkanSwapchainCreateInfoMETA
{
    public XrStructureType type;
    public void* next;
    public VkImageCreateFlags additionalCreateFlags;
    public VkImageUsageFlags additionalUsageFlags;
    /// <returns>a new <see cref="XrVulkanSwapchainCreateInfoMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VULKAN_SWAPCHAIN_CREATE_INFO_META"/></returns>
    public static XrVulkanSwapchainCreateInfoMETA New() =>
        new() { type = XrStructureType.XR_TYPE_VULKAN_SWAPCHAIN_CREATE_INFO_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSessionCreateInfoOverlayEXTX
{
    public XrStructureType type;
    public void* next;
    public ulong createFlags;
    public uint sessionLayersPlacement;
    /// <returns>a new <see cref="XrSessionCreateInfoOverlayEXTX"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SESSION_CREATE_INFO_OVERLAY_EXTX"/></returns>
    public static XrSessionCreateInfoOverlayEXTX New() =>
        new() { type = XrStructureType.XR_TYPE_SESSION_CREATE_INFO_OVERLAY_EXTX };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataMainSessionVisibilityChangedEXTX
{
    public XrStructureType type;
    public void* next;
    public XrBool32 visible;
    public ulong flags;
    /// <returns>a new <see cref="XrEventDataMainSessionVisibilityChangedEXTX"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_MAIN_SESSION_VISIBILITY_CHANGED_EXTX"/></returns>
    public static XrEventDataMainSessionVisibilityChangedEXTX New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_MAIN_SESSION_VISIBILITY_CHANGED_EXTX };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataDisplayRefreshRateChangedFB
{
    public XrStructureType type;
    public void* next;
    public float fromDisplayRefreshRate;
    public float toDisplayRefreshRate;
    /// <returns>a new <see cref="XrEventDataDisplayRefreshRateChangedFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_DISPLAY_REFRESH_RATE_CHANGED_FB"/></returns>
    public static XrEventDataDisplayRefreshRateChangedFB New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_DISPLAY_REFRESH_RATE_CHANGED_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrViewConfigurationDepthRangeEXT
{
    public XrStructureType type;
    public void* next;
    public float recommendedNearZ;
    public float minNearZ;
    public float recommendedFarZ;
    public float maxFarZ;
    /// <returns>a new <see cref="XrViewConfigurationDepthRangeEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIEW_CONFIGURATION_DEPTH_RANGE_EXT"/></returns>
    public static XrViewConfigurationDepthRangeEXT New() =>
        new() { type = XrStructureType.XR_TYPE_VIEW_CONFIGURATION_DEPTH_RANGE_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrViewConfigurationViewFovEPIC
{
    public XrStructureType type;
    public void* next;
    public XrFovf recommendedFov;
    public XrFovf maxMutableFov;
    /// <returns>a new <see cref="XrViewConfigurationViewFovEPIC"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIEW_CONFIGURATION_VIEW_FOV_EPIC"/></returns>
    public static XrViewConfigurationViewFovEPIC New() =>
        new() { type = XrStructureType.XR_TYPE_VIEW_CONFIGURATION_VIEW_FOV_EPIC };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrInteractionProfileDpadBindingEXT
{
    public XrStructureType type;
    public void* next;
    public ulong binding;
    public XrActionSet actionSet;
    public float forceThreshold;
    public float forceThresholdReleased;
    public float centerRegion;
    public float wedgeAngle;
    public XrBool32 isSticky;
    public XrHapticBaseHeader* onHaptic;
    public XrHapticBaseHeader* offHaptic;
    /// <returns>a new <see cref="XrInteractionProfileDpadBindingEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_INTERACTION_PROFILE_DPAD_BINDING_EXT"/></returns>
    public static XrInteractionProfileDpadBindingEXT New() =>
        new() { type = XrStructureType.XR_TYPE_INTERACTION_PROFILE_DPAD_BINDING_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrInteractionProfileAnalogThresholdVALVE
{
    public XrStructureType type;
    public void* next;
    public XrAction action;
    public ulong binding;
    public float onThreshold;
    public float offThreshold;
    public XrHapticBaseHeader* onHaptic;
    public XrHapticBaseHeader* offHaptic;
    /// <returns>a new <see cref="XrInteractionProfileAnalogThresholdVALVE"> with it's type member set to <see cref="XrStructureType.XR_TYPE_INTERACTION_PROFILE_ANALOG_THRESHOLD_VALVE"/></returns>
    public static XrInteractionProfileAnalogThresholdVALVE New() =>
        new() { type = XrStructureType.XR_TYPE_INTERACTION_PROFILE_ANALOG_THRESHOLD_VALVE };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBindingModificationsKHR
{
    public XrStructureType type;
    public void* next;
    public uint bindingModificationCount;
    public XrBindingModificationBaseHeaderKHR** bindingModifications;
    /// <returns>a new <see cref="XrBindingModificationsKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_BINDING_MODIFICATIONS_KHR"/></returns>
    public static XrBindingModificationsKHR New() =>
        new() { type = XrStructureType.XR_TYPE_BINDING_MODIFICATIONS_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBindingModificationBaseHeaderKHR
{
    public XrStructureType type;
    public void* next;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemEyeGazeInteractionPropertiesEXT
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsEyeGazeInteraction;
    /// <returns>a new <see cref="XrSystemEyeGazeInteractionPropertiesEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_EYE_GAZE_INTERACTION_PROPERTIES_EXT"/></returns>
    public static XrSystemEyeGazeInteractionPropertiesEXT New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_EYE_GAZE_INTERACTION_PROPERTIES_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEyeGazeSampleTimeEXT
{
    public XrStructureType type;
    public void* next;
    public long time;
    /// <returns>a new <see cref="XrEyeGazeSampleTimeEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EYE_GAZE_SAMPLE_TIME_EXT"/></returns>
    public static XrEyeGazeSampleTimeEXT New() =>
        new() { type = XrStructureType.XR_TYPE_EYE_GAZE_SAMPLE_TIME_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpatialAnchorCreateInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrSpace space;
    public XrPosef pose;
    public long time;
    /// <returns>a new <see cref="XrSpatialAnchorCreateInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_MSFT"/></returns>
    public static XrSpatialAnchorCreateInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpatialAnchorSpaceCreateInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrSpatialAnchorMSFT anchor;
    public XrPosef poseInAnchorSpace;
    /// <returns>a new <see cref="XrSpatialAnchorSpaceCreateInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPATIAL_ANCHOR_SPACE_CREATE_INFO_MSFT"/></returns>
    public static XrSpatialAnchorSpaceCreateInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SPATIAL_ANCHOR_SPACE_CREATE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerImageLayoutFB
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    /// <returns>a new <see cref="XrCompositionLayerImageLayoutFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_IMAGE_LAYOUT_FB"/></returns>
    public static XrCompositionLayerImageLayoutFB New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_IMAGE_LAYOUT_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerAlphaBlendFB
{
    public XrStructureType type;
    public void* next;
    public XrBlendFactorFB srcFactorColor;
    public XrBlendFactorFB dstFactorColor;
    public XrBlendFactorFB srcFactorAlpha;
    public XrBlendFactorFB dstFactorAlpha;
    /// <returns>a new <see cref="XrCompositionLayerAlphaBlendFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_ALPHA_BLEND_FB"/></returns>
    public static XrCompositionLayerAlphaBlendFB New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_ALPHA_BLEND_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGraphicsBindingEGLMNDX
{
    public XrStructureType type;
    public void* next;
    public void* getProcAddress;
    public nint display;
    public nint config;
    public nint context;
    /// <returns>a new <see cref="XrGraphicsBindingEGLMNDX"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GRAPHICS_BINDING_EGL_MNDX"/></returns>
    public static XrGraphicsBindingEGLMNDX New() =>
        new() { type = XrStructureType.XR_TYPE_GRAPHICS_BINDING_EGL_MNDX };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpatialGraphNodeSpaceCreateInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrSpatialGraphNodeTypeMSFT nodeType;
    public fixed byte nodeId[(int)OpenXRNative.XR_GUID_SIZE_MSFT];
    public XrPosef pose;
    /// <returns>a new <see cref="XrSpatialGraphNodeSpaceCreateInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPATIAL_GRAPH_NODE_SPACE_CREATE_INFO_MSFT"/></returns>
    public static XrSpatialGraphNodeSpaceCreateInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SPATIAL_GRAPH_NODE_SPACE_CREATE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpatialGraphStaticNodeBindingCreateInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrSpace space;
    public XrPosef poseInSpace;
    public long time;
    /// <returns>a new <see cref="XrSpatialGraphStaticNodeBindingCreateInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPATIAL_GRAPH_STATIC_NODE_BINDING_CREATE_INFO_MSFT"/></returns>
    public static XrSpatialGraphStaticNodeBindingCreateInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SPATIAL_GRAPH_STATIC_NODE_BINDING_CREATE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpatialGraphNodeBindingPropertiesGetInfoMSFT
{
    public XrStructureType type;
    public void* next;
    /// <returns>a new <see cref="XrSpatialGraphNodeBindingPropertiesGetInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_GET_INFO_MSFT"/></returns>
    public static XrSpatialGraphNodeBindingPropertiesGetInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_GET_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpatialGraphNodeBindingPropertiesMSFT
{
    public XrStructureType type;
    public void* next;
    public fixed byte nodeId[(int)OpenXRNative.XR_GUID_SIZE_MSFT];
    public XrPosef poseInNodeSpace;
    /// <returns>a new <see cref="XrSpatialGraphNodeBindingPropertiesMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_MSFT"/></returns>
    public static XrSpatialGraphNodeBindingPropertiesMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemHandTrackingPropertiesEXT
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsHandTracking;
    /// <returns>a new <see cref="XrSystemHandTrackingPropertiesEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_HAND_TRACKING_PROPERTIES_EXT"/></returns>
    public static XrSystemHandTrackingPropertiesEXT New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_HAND_TRACKING_PROPERTIES_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandTrackerCreateInfoEXT
{
    public XrStructureType type;
    public void* next;
    public XrHandEXT hand;
    public XrHandJointSetEXT handJointSet;
    /// <returns>a new <see cref="XrHandTrackerCreateInfoEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_TRACKER_CREATE_INFO_EXT"/></returns>
    public static XrHandTrackerCreateInfoEXT New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_TRACKER_CREATE_INFO_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandJointsLocateInfoEXT
{
    public XrStructureType type;
    public void* next;
    public XrSpace baseSpace;
    public long time;
    /// <returns>a new <see cref="XrHandJointsLocateInfoEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_JOINTS_LOCATE_INFO_EXT"/></returns>
    public static XrHandJointsLocateInfoEXT New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_JOINTS_LOCATE_INFO_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandJointLocationEXT
{
    public ulong locationFlags;
    public XrPosef pose;
    public float radius;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandJointVelocityEXT
{
    public ulong velocityFlags;
    public XrVector3f linearVelocity;
    public XrVector3f angularVelocity;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandJointLocationsEXT
{
    public XrStructureType type;
    public void* next;
    public XrBool32 isActive;
    public uint jointCount;
    public XrHandJointLocationEXT* jointLocations;
    /// <returns>a new <see cref="XrHandJointLocationsEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_JOINT_LOCATIONS_EXT"/></returns>
    public static XrHandJointLocationsEXT New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_JOINT_LOCATIONS_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandJointVelocitiesEXT
{
    public XrStructureType type;
    public void* next;
    public uint jointCount;
    public XrHandJointVelocityEXT* jointVelocities;
    /// <returns>a new <see cref="XrHandJointVelocitiesEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_JOINT_VELOCITIES_EXT"/></returns>
    public static XrHandJointVelocitiesEXT New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_JOINT_VELOCITIES_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemFaceTrackingPropertiesFB
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsFaceTracking;
    /// <returns>a new <see cref="XrSystemFaceTrackingPropertiesFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES_FB"/></returns>
    public static XrSystemFaceTrackingPropertiesFB New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFaceTrackerCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrFaceExpressionSetFB faceExpressionSet;
    /// <returns>a new <see cref="XrFaceTrackerCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FACE_TRACKER_CREATE_INFO_FB"/></returns>
    public static XrFaceTrackerCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_FACE_TRACKER_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFaceExpressionInfoFB
{
    public XrStructureType type;
    public void* next;
    public long time;
    /// <returns>a new <see cref="XrFaceExpressionInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FACE_EXPRESSION_INFO_FB"/></returns>
    public static XrFaceExpressionInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_FACE_EXPRESSION_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFaceExpressionStatusFB
{
    public XrBool32 isValid;
    public XrBool32 isEyeFollowingBlendshapesValid;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFaceExpressionWeightsFB
{
    public XrStructureType type;
    public void* next;
    public uint weightCount;
    public float* weights;
    public uint confidenceCount;
    public float* confidences;
    public XrFaceExpressionStatusFB status;
    public long time;
    /// <returns>a new <see cref="XrFaceExpressionWeightsFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FACE_EXPRESSION_WEIGHTS_FB"/></returns>
    public static XrFaceExpressionWeightsFB New() =>
        new() { type = XrStructureType.XR_TYPE_FACE_EXPRESSION_WEIGHTS_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemBodyTrackingPropertiesFB
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsBodyTracking;
    /// <returns>a new <see cref="XrSystemBodyTrackingPropertiesFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_FB"/></returns>
    public static XrSystemBodyTrackingPropertiesFB New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBodyTrackerCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrBodyJointSetFB bodyJointSet;
    /// <returns>a new <see cref="XrBodyTrackerCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_BODY_TRACKER_CREATE_INFO_FB"/></returns>
    public static XrBodyTrackerCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_BODY_TRACKER_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBodySkeletonJointFB
{
    public int joint;
    public int parentJoint;
    public XrPosef pose;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBodySkeletonFB
{
    public XrStructureType type;
    public void* next;
    public uint jointCount;
    public XrBodySkeletonJointFB* joints;
    /// <returns>a new <see cref="XrBodySkeletonFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_BODY_SKELETON_FB"/></returns>
    public static XrBodySkeletonFB New() =>
        new() { type = XrStructureType.XR_TYPE_BODY_SKELETON_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBodyJointsLocateInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrSpace baseSpace;
    public long time;
    /// <returns>a new <see cref="XrBodyJointsLocateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_BODY_JOINTS_LOCATE_INFO_FB"/></returns>
    public static XrBodyJointsLocateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_BODY_JOINTS_LOCATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBodyJointLocationFB
{
    public ulong locationFlags;
    public XrPosef pose;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBodyJointLocationsFB
{
    public XrStructureType type;
    public void* next;
    public XrBool32 isActive;
    public float confidence;
    public uint jointCount;
    public XrBodyJointLocationFB* jointLocations;
    public uint skeletonChangedCount;
    public long time;
    /// <returns>a new <see cref="XrBodyJointLocationsFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_BODY_JOINT_LOCATIONS_FB"/></returns>
    public static XrBodyJointLocationsFB New() =>
        new() { type = XrStructureType.XR_TYPE_BODY_JOINT_LOCATIONS_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemEyeTrackingPropertiesFB
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsEyeTracking;
    /// <returns>a new <see cref="XrSystemEyeTrackingPropertiesFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_EYE_TRACKING_PROPERTIES_FB"/></returns>
    public static XrSystemEyeTrackingPropertiesFB New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_EYE_TRACKING_PROPERTIES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEyeTrackerCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    /// <returns>a new <see cref="XrEyeTrackerCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EYE_TRACKER_CREATE_INFO_FB"/></returns>
    public static XrEyeTrackerCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_EYE_TRACKER_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEyeGazesInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrSpace baseSpace;
    public long time;
    /// <returns>a new <see cref="XrEyeGazesInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EYE_GAZES_INFO_FB"/></returns>
    public static XrEyeGazesInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_EYE_GAZES_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEyeGazeFB
{
    public XrBool32 isValid;
    public XrPosef gazePose;
    public float gazeConfidence;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEyeGazesFB
{
    public XrStructureType type;
    public void* next;
    public XrEyeGazeFB gaze;
    public long time;
    /// <returns>a new <see cref="XrEyeGazesFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EYE_GAZES_FB"/></returns>
    public static XrEyeGazesFB New() =>
        new() { type = XrStructureType.XR_TYPE_EYE_GAZES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandJointsMotionRangeInfoEXT
{
    public XrStructureType type;
    public void* next;
    public XrHandJointsMotionRangeEXT handJointsMotionRange;
    /// <returns>a new <see cref="XrHandJointsMotionRangeInfoEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_JOINTS_MOTION_RANGE_INFO_EXT"/></returns>
    public static XrHandJointsMotionRangeInfoEXT New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_JOINTS_MOTION_RANGE_INFO_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandTrackingDataSourceInfoEXT
{
    public XrStructureType type;
    public void* next;
    public uint requestedDataSourceCount;
    public XrHandTrackingDataSourceEXT* requestedDataSources;
    /// <returns>a new <see cref="XrHandTrackingDataSourceInfoEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_TRACKING_DATA_SOURCE_INFO_EXT"/></returns>
    public static XrHandTrackingDataSourceInfoEXT New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_TRACKING_DATA_SOURCE_INFO_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandTrackingDataSourceStateEXT
{
    public XrStructureType type;
    public void* next;
    public XrBool32 isActive;
    public XrHandTrackingDataSourceEXT dataSource;
    /// <returns>a new <see cref="XrHandTrackingDataSourceStateEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_TRACKING_DATA_SOURCE_STATE_EXT"/></returns>
    public static XrHandTrackingDataSourceStateEXT New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_TRACKING_DATA_SOURCE_STATE_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandMeshSpaceCreateInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrHandPoseTypeMSFT handPoseType;
    public XrPosef poseInHandMeshSpace;
    /// <returns>a new <see cref="XrHandMeshSpaceCreateInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_MESH_SPACE_CREATE_INFO_MSFT"/></returns>
    public static XrHandMeshSpaceCreateInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_MESH_SPACE_CREATE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandMeshUpdateInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public long time;
    public XrHandPoseTypeMSFT handPoseType;
    /// <returns>a new <see cref="XrHandMeshUpdateInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_MESH_UPDATE_INFO_MSFT"/></returns>
    public static XrHandMeshUpdateInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_MESH_UPDATE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandMeshMSFT
{
    public XrStructureType type;
    public void* next;
    public XrBool32 isActive;
    public XrBool32 indexBufferChanged;
    public XrBool32 vertexBufferChanged;
    public XrHandMeshIndexBufferMSFT indexBuffer;
    public XrHandMeshVertexBufferMSFT vertexBuffer;
    /// <returns>a new <see cref="XrHandMeshMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_MESH_MSFT"/></returns>
    public static XrHandMeshMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_MESH_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandMeshIndexBufferMSFT
{
    public uint indexBufferKey;
    public uint indexCapacityInput;
    public uint indexCountOutput;
    public uint* indices;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandMeshVertexBufferMSFT
{
    public long vertexUpdateTime;
    public uint vertexCapacityInput;
    public uint vertexCountOutput;
    public XrHandMeshVertexMSFT* vertices;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandMeshVertexMSFT
{
    public XrVector3f position;
    public XrVector3f normal;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemHandTrackingMeshPropertiesMSFT
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsHandTrackingMesh;
    public uint maxHandMeshIndexCount;
    public uint maxHandMeshVertexCount;
    /// <returns>a new <see cref="XrSystemHandTrackingMeshPropertiesMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_HAND_TRACKING_MESH_PROPERTIES_MSFT"/></returns>
    public static XrSystemHandTrackingMeshPropertiesMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_HAND_TRACKING_MESH_PROPERTIES_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandPoseTypeInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrHandPoseTypeMSFT handPoseType;
    /// <returns>a new <see cref="XrHandPoseTypeInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_POSE_TYPE_INFO_MSFT"/></returns>
    public static XrHandPoseTypeInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_POSE_TYPE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSecondaryViewConfigurationSessionBeginInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public uint viewConfigurationCount;
    public XrViewConfigurationType* enabledViewConfigurationTypes;
    /// <returns>a new <see cref="XrSecondaryViewConfigurationSessionBeginInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SESSION_BEGIN_INFO_MSFT"/></returns>
    public static XrSecondaryViewConfigurationSessionBeginInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SESSION_BEGIN_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSecondaryViewConfigurationStateMSFT
{
    public XrStructureType type;
    public void* next;
    public XrViewConfigurationType viewConfigurationType;
    public XrBool32 active;
    /// <returns>a new <see cref="XrSecondaryViewConfigurationStateMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_STATE_MSFT"/></returns>
    public static XrSecondaryViewConfigurationStateMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_STATE_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSecondaryViewConfigurationFrameStateMSFT
{
    public XrStructureType type;
    public void* next;
    public uint viewConfigurationCount;
    public XrSecondaryViewConfigurationStateMSFT* viewConfigurationStates;
    /// <returns>a new <see cref="XrSecondaryViewConfigurationFrameStateMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_STATE_MSFT"/></returns>
    public static XrSecondaryViewConfigurationFrameStateMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_STATE_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSecondaryViewConfigurationFrameEndInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public uint viewConfigurationCount;
    public XrSecondaryViewConfigurationLayerInfoMSFT* viewConfigurationLayersInfo;
    /// <returns>a new <see cref="XrSecondaryViewConfigurationFrameEndInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_END_INFO_MSFT"/></returns>
    public static XrSecondaryViewConfigurationFrameEndInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_END_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSecondaryViewConfigurationLayerInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrViewConfigurationType viewConfigurationType;
    public XrEnvironmentBlendMode environmentBlendMode;
    public uint layerCount;
    public XrCompositionLayerBaseHeader** layers;
    /// <returns>a new <see cref="XrSecondaryViewConfigurationLayerInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_LAYER_INFO_MSFT"/></returns>
    public static XrSecondaryViewConfigurationLayerInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_LAYER_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSecondaryViewConfigurationSwapchainCreateInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrViewConfigurationType viewConfigurationType;
    /// <returns>a new <see cref="XrSecondaryViewConfigurationSwapchainCreateInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SWAPCHAIN_CREATE_INFO_MSFT"/></returns>
    public static XrSecondaryViewConfigurationSwapchainCreateInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SWAPCHAIN_CREATE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHolographicWindowAttachmentMSFT
{
    public XrStructureType type;
    public void* next;
    public nint* holographicSpace;
    public nint* coreWindow;
    /// <returns>a new <see cref="XrHolographicWindowAttachmentMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HOLOGRAPHIC_WINDOW_ATTACHMENT_MSFT"/></returns>
    public static XrHolographicWindowAttachmentMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_HOLOGRAPHIC_WINDOW_ATTACHMENT_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrAndroidSurfaceSwapchainCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    public ulong createFlags;
    /// <returns>a new <see cref="XrAndroidSurfaceSwapchainCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ANDROID_SURFACE_SWAPCHAIN_CREATE_INFO_FB"/></returns>
    public static XrAndroidSurfaceSwapchainCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_ANDROID_SURFACE_SWAPCHAIN_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainStateBaseHeaderFB
{
    public XrStructureType type;
    public void* next;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainStateAndroidSurfaceDimensionsFB
{
    public XrStructureType type;
    public void* next;
    public uint width;
    public uint height;
    /// <returns>a new <see cref="XrSwapchainStateAndroidSurfaceDimensionsFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_STATE_ANDROID_SURFACE_DIMENSIONS_FB"/></returns>
    public static XrSwapchainStateAndroidSurfaceDimensionsFB New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_STATE_ANDROID_SURFACE_DIMENSIONS_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainStateSamplerOpenGLESFB
{
    public XrStructureType type;
    public void* next;
    public nint minFilter;
    public nint magFilter;
    public nint wrapModeS;
    public nint wrapModeT;
    public nint swizzleRed;
    public nint swizzleGreen;
    public nint swizzleBlue;
    public nint swizzleAlpha;
    public float maxAnisotropy;
    public XrColor4f borderColor;
    /// <returns>a new <see cref="XrSwapchainStateSamplerOpenGLESFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_STATE_SAMPLER_OPENGL_ES_FB"/></returns>
    public static XrSwapchainStateSamplerOpenGLESFB New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_STATE_SAMPLER_OPENGL_ES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainStateSamplerVulkanFB
{
    public XrStructureType type;
    public void* next;
    public nint minFilter;
    public nint magFilter;
    public nint mipmapMode;
    public nint wrapModeS;
    public nint wrapModeT;
    public nint swizzleRed;
    public nint swizzleGreen;
    public nint swizzleBlue;
    public nint swizzleAlpha;
    public float maxAnisotropy;
    public XrColor4f borderColor;
    /// <returns>a new <see cref="XrSwapchainStateSamplerVulkanFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_STATE_SAMPLER_VULKAN_FB"/></returns>
    public static XrSwapchainStateSamplerVulkanFB New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_STATE_SAMPLER_VULKAN_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerSecureContentFB
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    /// <returns>a new <see cref="XrCompositionLayerSecureContentFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_SECURE_CONTENT_FB"/></returns>
    public static XrCompositionLayerSecureContentFB New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_SECURE_CONTENT_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrLoaderInitInfoBaseHeaderKHR
{
    public XrStructureType type;
    public void* next;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrLoaderInitInfoAndroidKHR
{
    public XrStructureType type;
    public void* next;
    public void* applicationVM;
    public void* applicationContext;
    /// <returns>a new <see cref="XrLoaderInitInfoAndroidKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_LOADER_INIT_INFO_ANDROID_KHR"/></returns>
    public static XrLoaderInitInfoAndroidKHR New() =>
        new() { type = XrStructureType.XR_TYPE_LOADER_INIT_INFO_ANDROID_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerEquirect2KHR
{
    public XrStructureType type;
    public void* next;
    public ulong layerFlags;
    public XrSpace space;
    public XrEyeVisibility eyeVisibility;
    public XrSwapchainSubImage subImage;
    public XrPosef pose;
    public float radius;
    public float centralHorizontalAngle;
    public float upperVerticalAngle;
    public float lowerVerticalAngle;
    /// <returns>a new <see cref="XrCompositionLayerEquirect2KHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_EQUIRECT2_KHR"/></returns>
    public static XrCompositionLayerEquirect2KHR New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_EQUIRECT2_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerColorScaleBiasKHR
{
    public XrStructureType type;
    public void* next;
    public XrColor4f colorScale;
    public XrColor4f colorBias;
    /// <returns>a new <see cref="XrCompositionLayerColorScaleBiasKHR"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_COLOR_SCALE_BIAS_KHR"/></returns>
    public static XrCompositionLayerColorScaleBiasKHR New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_COLOR_SCALE_BIAS_KHR };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrControllerModelKeyStateMSFT
{
    public XrStructureType type;
    public void* next;
    public ulong modelKey;
    /// <returns>a new <see cref="XrControllerModelKeyStateMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_CONTROLLER_MODEL_KEY_STATE_MSFT"/></returns>
    public static XrControllerModelKeyStateMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_CONTROLLER_MODEL_KEY_STATE_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrControllerModelNodePropertiesMSFT
{
    public XrStructureType type;
    public void* next;
    public fixed byte parentNodeName[(int)OpenXRNative.XR_MAX_CONTROLLER_MODEL_NODE_NAME_SIZE_MSFT];
    public fixed byte nodeName[(int)OpenXRNative.XR_MAX_CONTROLLER_MODEL_NODE_NAME_SIZE_MSFT];
    /// <returns>a new <see cref="XrControllerModelNodePropertiesMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_CONTROLLER_MODEL_NODE_PROPERTIES_MSFT"/></returns>
    public static XrControllerModelNodePropertiesMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_CONTROLLER_MODEL_NODE_PROPERTIES_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrControllerModelPropertiesMSFT
{
    public XrStructureType type;
    public void* next;
    public uint nodeCapacityInput;
    public uint nodeCountOutput;
    public XrControllerModelNodePropertiesMSFT* nodeProperties;
    /// <returns>a new <see cref="XrControllerModelPropertiesMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_CONTROLLER_MODEL_PROPERTIES_MSFT"/></returns>
    public static XrControllerModelPropertiesMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_CONTROLLER_MODEL_PROPERTIES_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrControllerModelNodeStateMSFT
{
    public XrStructureType type;
    public void* next;
    public XrPosef nodePose;
    /// <returns>a new <see cref="XrControllerModelNodeStateMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_CONTROLLER_MODEL_NODE_STATE_MSFT"/></returns>
    public static XrControllerModelNodeStateMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_CONTROLLER_MODEL_NODE_STATE_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrControllerModelStateMSFT
{
    public XrStructureType type;
    public void* next;
    public uint nodeCapacityInput;
    public uint nodeCountOutput;
    public XrControllerModelNodeStateMSFT* nodeStates;
    /// <returns>a new <see cref="XrControllerModelStateMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_CONTROLLER_MODEL_STATE_MSFT"/></returns>
    public static XrControllerModelStateMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_CONTROLLER_MODEL_STATE_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrUuidMSFT
{
    public byte bytes_0;
    public byte bytes_1;
    public byte bytes_2;
    public byte bytes_3;
    public byte bytes_4;
    public byte bytes_5;
    public byte bytes_6;
    public byte bytes_7;
    public byte bytes_8;
    public byte bytes_9;
    public byte bytes_10;
    public byte bytes_11;
    public byte bytes_12;
    public byte bytes_13;
    public byte bytes_14;
    public byte bytes_15;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneObserverCreateInfoMSFT
{
    public XrStructureType type;
    public void* next;
    /// <returns>a new <see cref="XrSceneObserverCreateInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_OBSERVER_CREATE_INFO_MSFT"/></returns>
    public static XrSceneObserverCreateInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_OBSERVER_CREATE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneCreateInfoMSFT
{
    public XrStructureType type;
    public void* next;
    /// <returns>a new <see cref="XrSceneCreateInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_CREATE_INFO_MSFT"/></returns>
    public static XrSceneCreateInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_CREATE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrNewSceneComputeInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public uint requestedFeatureCount;
    public XrSceneComputeFeatureMSFT* requestedFeatures;
    public XrSceneComputeConsistencyMSFT consistency;
    public XrSceneBoundsMSFT bounds;
    /// <returns>a new <see cref="XrNewSceneComputeInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_NEW_SCENE_COMPUTE_INFO_MSFT"/></returns>
    public static XrNewSceneComputeInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_NEW_SCENE_COMPUTE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVisualMeshComputeLodInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrMeshComputeLodMSFT lod;
    /// <returns>a new <see cref="XrVisualMeshComputeLodInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VISUAL_MESH_COMPUTE_LOD_INFO_MSFT"/></returns>
    public static XrVisualMeshComputeLodInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_VISUAL_MESH_COMPUTE_LOD_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneSphereBoundMSFT
{
    public XrVector3f center;
    public float radius;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneOrientedBoxBoundMSFT
{
    public XrPosef pose;
    public XrVector3f extents;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneFrustumBoundMSFT
{
    public XrPosef pose;
    public XrFovf fov;
    public float farDistance;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneBoundsMSFT
{
    public XrSpace space;
    public long time;
    public uint sphereCount;
    public XrSceneSphereBoundMSFT* spheres;
    public uint boxCount;
    public XrSceneOrientedBoxBoundMSFT* boxes;
    public uint frustumCount;
    public XrSceneFrustumBoundMSFT* frustums;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneComponentMSFT
{
    public XrSceneComponentTypeMSFT componentType;
    public XrUuidMSFT id;
    public XrUuidMSFT parentId;
    public long updateTime;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneComponentsMSFT
{
    public XrStructureType type;
    public void* next;
    public uint componentCapacityInput;
    public uint componentCountOutput;
    public XrSceneComponentMSFT* components;
    /// <returns>a new <see cref="XrSceneComponentsMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_COMPONENTS_MSFT"/></returns>
    public static XrSceneComponentsMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_COMPONENTS_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneComponentsGetInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrSceneComponentTypeMSFT componentType;
    /// <returns>a new <see cref="XrSceneComponentsGetInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_COMPONENTS_GET_INFO_MSFT"/></returns>
    public static XrSceneComponentsGetInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_COMPONENTS_GET_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneComponentLocationMSFT
{
    public ulong flags;
    public XrPosef pose;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneComponentLocationsMSFT
{
    public XrStructureType type;
    public void* next;
    public uint locationCount;
    public XrSceneComponentLocationMSFT* locations;
    /// <returns>a new <see cref="XrSceneComponentLocationsMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_COMPONENT_LOCATIONS_MSFT"/></returns>
    public static XrSceneComponentLocationsMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_COMPONENT_LOCATIONS_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneComponentsLocateInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrSpace baseSpace;
    public long time;
    public uint componentIdCount;
    public XrUuidMSFT* componentIds;
    /// <returns>a new <see cref="XrSceneComponentsLocateInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_COMPONENTS_LOCATE_INFO_MSFT"/></returns>
    public static XrSceneComponentsLocateInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_COMPONENTS_LOCATE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneObjectMSFT
{
    public XrSceneObjectTypeMSFT objectType;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneObjectsMSFT
{
    public XrStructureType type;
    public void* next;
    public uint sceneObjectCount;
    public XrSceneObjectMSFT* sceneObjects;
    /// <returns>a new <see cref="XrSceneObjectsMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_OBJECTS_MSFT"/></returns>
    public static XrSceneObjectsMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_OBJECTS_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneComponentParentFilterInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrUuidMSFT parentId;
    /// <returns>a new <see cref="XrSceneComponentParentFilterInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_COMPONENT_PARENT_FILTER_INFO_MSFT"/></returns>
    public static XrSceneComponentParentFilterInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_COMPONENT_PARENT_FILTER_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneObjectTypesFilterInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public uint objectTypeCount;
    public XrSceneObjectTypeMSFT* objectTypes;
    /// <returns>a new <see cref="XrSceneObjectTypesFilterInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_OBJECT_TYPES_FILTER_INFO_MSFT"/></returns>
    public static XrSceneObjectTypesFilterInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_OBJECT_TYPES_FILTER_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrScenePlaneMSFT
{
    public XrScenePlaneAlignmentTypeMSFT alignment;
    public XrExtent2Df size;
    public ulong meshBufferId;
    public XrBool32 supportsIndicesUint16;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrScenePlanesMSFT
{
    public XrStructureType type;
    public void* next;
    public uint scenePlaneCount;
    public XrScenePlaneMSFT* scenePlanes;
    /// <returns>a new <see cref="XrScenePlanesMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_PLANES_MSFT"/></returns>
    public static XrScenePlanesMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_PLANES_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrScenePlaneAlignmentFilterInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public uint alignmentCount;
    public XrScenePlaneAlignmentTypeMSFT* alignments;
    /// <returns>a new <see cref="XrScenePlaneAlignmentFilterInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_PLANE_ALIGNMENT_FILTER_INFO_MSFT"/></returns>
    public static XrScenePlaneAlignmentFilterInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_PLANE_ALIGNMENT_FILTER_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneMeshMSFT
{
    public ulong meshBufferId;
    public XrBool32 supportsIndicesUint16;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneMeshesMSFT
{
    public XrStructureType type;
    public void* next;
    public uint sceneMeshCount;
    public XrSceneMeshMSFT* sceneMeshes;
    /// <returns>a new <see cref="XrSceneMeshesMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_MESHES_MSFT"/></returns>
    public static XrSceneMeshesMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_MESHES_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneMeshBuffersGetInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public ulong meshBufferId;
    /// <returns>a new <see cref="XrSceneMeshBuffersGetInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_MESH_BUFFERS_GET_INFO_MSFT"/></returns>
    public static XrSceneMeshBuffersGetInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_MESH_BUFFERS_GET_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneMeshBuffersMSFT
{
    public XrStructureType type;
    public void* next;
    /// <returns>a new <see cref="XrSceneMeshBuffersMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_MESH_BUFFERS_MSFT"/></returns>
    public static XrSceneMeshBuffersMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_MESH_BUFFERS_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneMeshVertexBufferMSFT
{
    public XrStructureType type;
    public void* next;
    public uint vertexCapacityInput;
    public uint vertexCountOutput;
    public XrVector3f* vertices;
    /// <returns>a new <see cref="XrSceneMeshVertexBufferMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_MESH_VERTEX_BUFFER_MSFT"/></returns>
    public static XrSceneMeshVertexBufferMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_MESH_VERTEX_BUFFER_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneMeshIndicesUint32MSFT
{
    public XrStructureType type;
    public void* next;
    public uint indexCapacityInput;
    public uint indexCountOutput;
    public uint* indices;
    /// <returns>a new <see cref="XrSceneMeshIndicesUint32MSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_MESH_INDICES_UINT32_MSFT"/></returns>
    public static XrSceneMeshIndicesUint32MSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_MESH_INDICES_UINT32_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneMeshIndicesUint16MSFT
{
    public XrStructureType type;
    public void* next;
    public uint indexCapacityInput;
    public uint indexCountOutput;
    public ushort* indices;
    /// <returns>a new <see cref="XrSceneMeshIndicesUint16MSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_MESH_INDICES_UINT16_MSFT"/></returns>
    public static XrSceneMeshIndicesUint16MSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_MESH_INDICES_UINT16_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSerializedSceneFragmentDataGetInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrUuidMSFT sceneFragmentId;
    /// <returns>a new <see cref="XrSerializedSceneFragmentDataGetInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SERIALIZED_SCENE_FRAGMENT_DATA_GET_INFO_MSFT"/></returns>
    public static XrSerializedSceneFragmentDataGetInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SERIALIZED_SCENE_FRAGMENT_DATA_GET_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrDeserializeSceneFragmentMSFT
{
    public uint bufferSize;
    public byte* buffer;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneDeserializeInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public uint fragmentCount;
    public XrDeserializeSceneFragmentMSFT* fragments;
    /// <returns>a new <see cref="XrSceneDeserializeInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_DESERIALIZE_INFO_MSFT"/></returns>
    public static XrSceneDeserializeInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_DESERIALIZE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemColorSpacePropertiesFB
{
    public XrStructureType type;
    public void* next;
    public XrColorSpaceFB colorSpace;
    /// <returns>a new <see cref="XrSystemColorSpacePropertiesFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_COLOR_SPACE_PROPERTIES_FB"/></returns>
    public static XrSystemColorSpacePropertiesFB New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_COLOR_SPACE_PROPERTIES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemSpatialEntityPropertiesFB
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsSpatialEntity;
    /// <returns>a new <see cref="XrSystemSpatialEntityPropertiesFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_SPATIAL_ENTITY_PROPERTIES_FB"/></returns>
    public static XrSystemSpatialEntityPropertiesFB New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_SPATIAL_ENTITY_PROPERTIES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpatialAnchorCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrSpace space;
    public XrPosef poseInSpace;
    public long time;
    /// <returns>a new <see cref="XrSpatialAnchorCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_FB"/></returns>
    public static XrSpatialAnchorCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceComponentStatusSetInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrSpaceComponentTypeFB componentType;
    public XrBool32 enabled;
    public long timeout;
    /// <returns>a new <see cref="XrSpaceComponentStatusSetInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_COMPONENT_STATUS_SET_INFO_FB"/></returns>
    public static XrSpaceComponentStatusSetInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_COMPONENT_STATUS_SET_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceComponentStatusFB
{
    public XrStructureType type;
    public void* next;
    public XrBool32 enabled;
    public XrBool32 changePending;
    /// <returns>a new <see cref="XrSpaceComponentStatusFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_COMPONENT_STATUS_FB"/></returns>
    public static XrSpaceComponentStatusFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_COMPONENT_STATUS_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataSpatialAnchorCreateCompleteFB
{
    public XrStructureType type;
    public void* next;
    public ulong requestId;
    public XrResult result;
    public XrSpace space;
    public XrUuidEXT uuid;
    /// <returns>a new <see cref="XrEventDataSpatialAnchorCreateCompleteFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_SPATIAL_ANCHOR_CREATE_COMPLETE_FB"/></returns>
    public static XrEventDataSpatialAnchorCreateCompleteFB New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_SPATIAL_ANCHOR_CREATE_COMPLETE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataSpaceSetStatusCompleteFB
{
    public XrStructureType type;
    public void* next;
    public ulong requestId;
    public XrResult result;
    public XrSpace space;
    public XrUuidEXT uuid;
    public XrSpaceComponentTypeFB componentType;
    public XrBool32 enabled;
    /// <returns>a new <see cref="XrEventDataSpaceSetStatusCompleteFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_SPACE_SET_STATUS_COMPLETE_FB"/></returns>
    public static XrEventDataSpaceSetStatusCompleteFB New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_SPACE_SET_STATUS_COMPLETE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFoveationProfileCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    /// <returns>a new <see cref="XrFoveationProfileCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FOVEATION_PROFILE_CREATE_INFO_FB"/></returns>
    public static XrFoveationProfileCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_FOVEATION_PROFILE_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainCreateInfoFoveationFB
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    /// <returns>a new <see cref="XrSwapchainCreateInfoFoveationFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_CREATE_INFO_FOVEATION_FB"/></returns>
    public static XrSwapchainCreateInfoFoveationFB New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_CREATE_INFO_FOVEATION_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainStateFoveationFB
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    public XrFoveationProfileFB profile;
    /// <returns>a new <see cref="XrSwapchainStateFoveationFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_STATE_FOVEATION_FB"/></returns>
    public static XrSwapchainStateFoveationFB New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_STATE_FOVEATION_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSwapchainImageFoveationVulkanFB
{
    public XrStructureType type;
    public void* next;
    public nint image;
    public uint width;
    public uint height;
    /// <returns>a new <see cref="XrSwapchainImageFoveationVulkanFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_FOVEATION_VULKAN_FB"/></returns>
    public static XrSwapchainImageFoveationVulkanFB New() =>
        new() { type = XrStructureType.XR_TYPE_SWAPCHAIN_IMAGE_FOVEATION_VULKAN_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFoveationLevelProfileCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrFoveationLevelFB level;
    public float verticalOffset;
    public XrFoveationDynamicFB dynamic;
    /// <returns>a new <see cref="XrFoveationLevelProfileCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FOVEATION_LEVEL_PROFILE_CREATE_INFO_FB"/></returns>
    public static XrFoveationLevelProfileCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_FOVEATION_LEVEL_PROFILE_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFoveationEyeTrackedProfileCreateInfoMETA
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    /// <returns>a new <see cref="XrFoveationEyeTrackedProfileCreateInfoMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FOVEATION_EYE_TRACKED_PROFILE_CREATE_INFO_META"/></returns>
    public static XrFoveationEyeTrackedProfileCreateInfoMETA New() =>
        new() { type = XrStructureType.XR_TYPE_FOVEATION_EYE_TRACKED_PROFILE_CREATE_INFO_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFoveationEyeTrackedStateMETA
{
    public XrStructureType type;
    public void* next;
    public XrVector2f foveationCenter_0;
    public XrVector2f foveationCenter_1;
    public ulong flags;
    /// <returns>a new <see cref="XrFoveationEyeTrackedStateMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FOVEATION_EYE_TRACKED_STATE_META"/></returns>
    public static XrFoveationEyeTrackedStateMETA New() =>
        new() { type = XrStructureType.XR_TYPE_FOVEATION_EYE_TRACKED_STATE_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemFoveationEyeTrackedPropertiesMETA
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsFoveationEyeTracked;
    /// <returns>a new <see cref="XrSystemFoveationEyeTrackedPropertiesMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_FOVEATION_EYE_TRACKED_PROPERTIES_META"/></returns>
    public static XrSystemFoveationEyeTrackedPropertiesMETA New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_FOVEATION_EYE_TRACKED_PROPERTIES_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVector4sFB
{
    public short x;
    public short y;
    public short z;
    public short w;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandTrackingMeshFB
{
    public XrStructureType type;
    public void* next;
    public uint jointCapacityInput;
    public uint jointCountOutput;
    public XrPosef* jointBindPoses;
    public float* jointRadii;
    public XrHandJointEXT* jointParents;
    public uint vertexCapacityInput;
    public uint vertexCountOutput;
    public XrVector3f* vertexPositions;
    public XrVector3f* vertexNormals;
    public XrVector2f* vertexUVs;
    public XrVector4sFB* vertexBlendIndices;
    public XrVector4f* vertexBlendWeights;
    public uint indexCapacityInput;
    public uint indexCountOutput;
    public short* indices;
    /// <returns>a new <see cref="XrHandTrackingMeshFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_TRACKING_MESH_FB"/></returns>
    public static XrHandTrackingMeshFB New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_TRACKING_MESH_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandTrackingScaleFB
{
    public XrStructureType type;
    public void* next;
    public float sensorOutput;
    public float currentOutput;
    public XrBool32 overrideHandScale;
    public float overrideValueInput;
    /// <returns>a new <see cref="XrHandTrackingScaleFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_TRACKING_SCALE_FB"/></returns>
    public static XrHandTrackingScaleFB New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_TRACKING_SCALE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandTrackingAimStateFB
{
    public XrStructureType type;
    public void* next;
    public ulong status;
    public XrPosef aimPose;
    public float pinchStrengthIndex;
    public float pinchStrengthMiddle;
    public float pinchStrengthRing;
    public float pinchStrengthLittle;
    /// <returns>a new <see cref="XrHandTrackingAimStateFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_TRACKING_AIM_STATE_FB"/></returns>
    public static XrHandTrackingAimStateFB New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_TRACKING_AIM_STATE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandCapsuleFB
{
    public XrVector3f points_0;
    public XrVector3f points_1;
    public float radius;
    public XrHandJointEXT joint;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHandTrackingCapsulesStateFB
{
    public XrStructureType type;
    public void* next;
    public XrHandCapsuleFB capsules_0;
    public XrHandCapsuleFB capsules_1;
    public XrHandCapsuleFB capsules_2;
    public XrHandCapsuleFB capsules_3;
    public XrHandCapsuleFB capsules_4;
    public XrHandCapsuleFB capsules_5;
    public XrHandCapsuleFB capsules_6;
    public XrHandCapsuleFB capsules_7;
    public XrHandCapsuleFB capsules_8;
    public XrHandCapsuleFB capsules_9;
    public XrHandCapsuleFB capsules_10;
    public XrHandCapsuleFB capsules_11;
    public XrHandCapsuleFB capsules_12;
    public XrHandCapsuleFB capsules_13;
    public XrHandCapsuleFB capsules_14;
    public XrHandCapsuleFB capsules_15;
    public XrHandCapsuleFB capsules_16;
    public XrHandCapsuleFB capsules_17;
    public XrHandCapsuleFB capsules_18;
    /// <returns>a new <see cref="XrHandTrackingCapsulesStateFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAND_TRACKING_CAPSULES_STATE_FB"/></returns>
    public static XrHandTrackingCapsulesStateFB New() =>
        new() { type = XrStructureType.XR_TYPE_HAND_TRACKING_CAPSULES_STATE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrRenderModelPathInfoFB
{
    public XrStructureType type;
    public void* next;
    public ulong path;
    /// <returns>a new <see cref="XrRenderModelPathInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_RENDER_MODEL_PATH_INFO_FB"/></returns>
    public static XrRenderModelPathInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_RENDER_MODEL_PATH_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrRenderModelPropertiesFB
{
    public XrStructureType type;
    public void* next;
    public uint vendorId;
    public fixed byte modelName[(int)OpenXRNative.XR_MAX_RENDER_MODEL_NAME_SIZE_FB];
    public ulong modelKey;
    public uint modelVersion;
    public ulong flags;
    /// <returns>a new <see cref="XrRenderModelPropertiesFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_RENDER_MODEL_PROPERTIES_FB"/></returns>
    public static XrRenderModelPropertiesFB New() =>
        new() { type = XrStructureType.XR_TYPE_RENDER_MODEL_PROPERTIES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrRenderModelBufferFB
{
    public XrStructureType type;
    public void* next;
    public uint bufferCapacityInput;
    public uint bufferCountOutput;
    public byte* buffer;
    /// <returns>a new <see cref="XrRenderModelBufferFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_RENDER_MODEL_BUFFER_FB"/></returns>
    public static XrRenderModelBufferFB New() =>
        new() { type = XrStructureType.XR_TYPE_RENDER_MODEL_BUFFER_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrRenderModelLoadInfoFB
{
    public XrStructureType type;
    public void* next;
    public ulong modelKey;
    /// <returns>a new <see cref="XrRenderModelLoadInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_RENDER_MODEL_LOAD_INFO_FB"/></returns>
    public static XrRenderModelLoadInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_RENDER_MODEL_LOAD_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemRenderModelPropertiesFB
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsRenderModelLoading;
    /// <returns>a new <see cref="XrSystemRenderModelPropertiesFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_RENDER_MODEL_PROPERTIES_FB"/></returns>
    public static XrSystemRenderModelPropertiesFB New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_RENDER_MODEL_PROPERTIES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrRenderModelCapabilitiesRequestFB
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    /// <returns>a new <see cref="XrRenderModelCapabilitiesRequestFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_RENDER_MODEL_CAPABILITIES_REQUEST_FB"/></returns>
    public static XrRenderModelCapabilitiesRequestFB New() =>
        new() { type = XrStructureType.XR_TYPE_RENDER_MODEL_CAPABILITIES_REQUEST_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceQueryInfoBaseHeaderFB
{
    public XrStructureType type;
    public void* next;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceFilterInfoBaseHeaderFB
{
    public XrStructureType type;
    public void* next;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceQueryInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrSpaceQueryActionFB queryAction;
    public uint maxResultCount;
    public long timeout;
    public XrSpaceFilterInfoBaseHeaderFB* filter;
    public XrSpaceFilterInfoBaseHeaderFB* excludeFilter;
    /// <returns>a new <see cref="XrSpaceQueryInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_QUERY_INFO_FB"/></returns>
    public static XrSpaceQueryInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_QUERY_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceStorageLocationFilterInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrSpaceStorageLocationFB location;
    /// <returns>a new <see cref="XrSpaceStorageLocationFilterInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_STORAGE_LOCATION_FILTER_INFO_FB"/></returns>
    public static XrSpaceStorageLocationFilterInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_STORAGE_LOCATION_FILTER_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceUuidFilterInfoFB
{
    public XrStructureType type;
    public void* next;
    public uint uuidCount;
    public XrUuidEXT* uuids;
    /// <returns>a new <see cref="XrSpaceUuidFilterInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_UUID_FILTER_INFO_FB"/></returns>
    public static XrSpaceUuidFilterInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_UUID_FILTER_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceComponentFilterInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrSpaceComponentTypeFB componentType;
    /// <returns>a new <see cref="XrSpaceComponentFilterInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_COMPONENT_FILTER_INFO_FB"/></returns>
    public static XrSpaceComponentFilterInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_COMPONENT_FILTER_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceQueryResultFB
{
    public XrSpace space;
    public XrUuidEXT uuid;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceQueryResultsFB
{
    public XrStructureType type;
    public void* next;
    public uint resultCapacityInput;
    public uint resultCountOutput;
    public XrSpaceQueryResultFB* results;
    /// <returns>a new <see cref="XrSpaceQueryResultsFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_QUERY_RESULTS_FB"/></returns>
    public static XrSpaceQueryResultsFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_QUERY_RESULTS_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataSpaceQueryResultsAvailableFB
{
    public XrStructureType type;
    public void* next;
    public ulong requestId;
    /// <returns>a new <see cref="XrEventDataSpaceQueryResultsAvailableFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_SPACE_QUERY_RESULTS_AVAILABLE_FB"/></returns>
    public static XrEventDataSpaceQueryResultsAvailableFB New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_SPACE_QUERY_RESULTS_AVAILABLE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataSpaceQueryCompleteFB
{
    public XrStructureType type;
    public void* next;
    public ulong requestId;
    public XrResult result;
    /// <returns>a new <see cref="XrEventDataSpaceQueryCompleteFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_SPACE_QUERY_COMPLETE_FB"/></returns>
    public static XrEventDataSpaceQueryCompleteFB New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_SPACE_QUERY_COMPLETE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceSaveInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrSpace space;
    public XrSpaceStorageLocationFB location;
    public XrSpacePersistenceModeFB persistenceMode;
    /// <returns>a new <see cref="XrSpaceSaveInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_SAVE_INFO_FB"/></returns>
    public static XrSpaceSaveInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_SAVE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceEraseInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrSpace space;
    public XrSpaceStorageLocationFB location;
    /// <returns>a new <see cref="XrSpaceEraseInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_ERASE_INFO_FB"/></returns>
    public static XrSpaceEraseInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_ERASE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataSpaceSaveCompleteFB
{
    public XrStructureType type;
    public void* next;
    public ulong requestId;
    public XrResult result;
    public XrSpace space;
    public XrUuidEXT uuid;
    public XrSpaceStorageLocationFB location;
    /// <returns>a new <see cref="XrEventDataSpaceSaveCompleteFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_SPACE_SAVE_COMPLETE_FB"/></returns>
    public static XrEventDataSpaceSaveCompleteFB New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_SPACE_SAVE_COMPLETE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataSpaceEraseCompleteFB
{
    public XrStructureType type;
    public void* next;
    public ulong requestId;
    public XrResult result;
    public XrSpace space;
    public XrUuidEXT uuid;
    public XrSpaceStorageLocationFB location;
    /// <returns>a new <see cref="XrEventDataSpaceEraseCompleteFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_SPACE_ERASE_COMPLETE_FB"/></returns>
    public static XrEventDataSpaceEraseCompleteFB New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_SPACE_ERASE_COMPLETE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceShareInfoFB
{
    public XrStructureType type;
    public void* next;
    public uint spaceCount;
    public XrSpace* spaces;
    public uint userCount;
    public XrSpaceUserFB* users;
    /// <returns>a new <see cref="XrSpaceShareInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_SHARE_INFO_FB"/></returns>
    public static XrSpaceShareInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_SHARE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataSpaceShareCompleteFB
{
    public XrStructureType type;
    public void* next;
    public ulong requestId;
    public XrResult result;
    /// <returns>a new <see cref="XrEventDataSpaceShareCompleteFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_SPACE_SHARE_COMPLETE_FB"/></returns>
    public static XrEventDataSpaceShareCompleteFB New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_SPACE_SHARE_COMPLETE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceListSaveInfoFB
{
    public XrStructureType type;
    public void* next;
    public uint spaceCount;
    public XrSpace* spaces;
    public XrSpaceStorageLocationFB location;
    /// <returns>a new <see cref="XrSpaceListSaveInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_LIST_SAVE_INFO_FB"/></returns>
    public static XrSpaceListSaveInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_LIST_SAVE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataSpaceListSaveCompleteFB
{
    public XrStructureType type;
    public void* next;
    public ulong requestId;
    public XrResult result;
    /// <returns>a new <see cref="XrEventDataSpaceListSaveCompleteFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_SPACE_LIST_SAVE_COMPLETE_FB"/></returns>
    public static XrEventDataSpaceListSaveCompleteFB New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_SPACE_LIST_SAVE_COMPLETE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceContainerFB
{
    public XrStructureType type;
    public void* next;
    public uint uuidCapacityInput;
    public uint uuidCountOutput;
    public XrUuidEXT* uuids;
    /// <returns>a new <see cref="XrSpaceContainerFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_CONTAINER_FB"/></returns>
    public static XrSpaceContainerFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_CONTAINER_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrExtent3DfFB
{
    public float width;
    public float height;
    public float depth;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrOffset3DfFB
{
    public float x;
    public float y;
    public float z;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrRect3DfFB
{
    public XrOffset3DfFB offset;
    public XrExtent3DfFB extent;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSemanticLabelsFB
{
    public XrStructureType type;
    public void* next;
    public uint bufferCapacityInput;
    public uint bufferCountOutput;
    public byte* buffer;
    /// <returns>a new <see cref="XrSemanticLabelsFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SEMANTIC_LABELS_FB"/></returns>
    public static XrSemanticLabelsFB New() =>
        new() { type = XrStructureType.XR_TYPE_SEMANTIC_LABELS_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrRoomLayoutFB
{
    public XrStructureType type;
    public void* next;
    public XrUuidEXT floorUuid;
    public XrUuidEXT ceilingUuid;
    public uint wallUuidCapacityInput;
    public uint wallUuidCountOutput;
    public XrUuidEXT* wallUuids;
    /// <returns>a new <see cref="XrRoomLayoutFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ROOM_LAYOUT_FB"/></returns>
    public static XrRoomLayoutFB New() =>
        new() { type = XrStructureType.XR_TYPE_ROOM_LAYOUT_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrBoundary2DFB
{
    public XrStructureType type;
    public void* next;
    public uint vertexCapacityInput;
    public uint vertexCountOutput;
    public XrVector2f* vertices;
    /// <returns>a new <see cref="XrBoundary2DFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_BOUNDARY_2D_FB"/></returns>
    public static XrBoundary2DFB New() =>
        new() { type = XrStructureType.XR_TYPE_BOUNDARY_2D_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSemanticLabelsSupportInfoFB
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    public byte* recognizedLabels;
    /// <returns>a new <see cref="XrSemanticLabelsSupportInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SEMANTIC_LABELS_SUPPORT_INFO_FB"/></returns>
    public static XrSemanticLabelsSupportInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SEMANTIC_LABELS_SUPPORT_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSceneCaptureRequestInfoFB
{
    public XrStructureType type;
    public void* next;
    public uint requestByteCount;
    public byte* request;
    /// <returns>a new <see cref="XrSceneCaptureRequestInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SCENE_CAPTURE_REQUEST_INFO_FB"/></returns>
    public static XrSceneCaptureRequestInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SCENE_CAPTURE_REQUEST_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataSceneCaptureCompleteFB
{
    public XrStructureType type;
    public void* next;
    public ulong requestId;
    public XrResult result;
    /// <returns>a new <see cref="XrEventDataSceneCaptureCompleteFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_SCENE_CAPTURE_COMPLETE_FB"/></returns>
    public static XrEventDataSceneCaptureCompleteFB New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_SCENE_CAPTURE_COMPLETE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemKeyboardTrackingPropertiesFB
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsKeyboardTracking;
    /// <returns>a new <see cref="XrSystemKeyboardTrackingPropertiesFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_KEYBOARD_TRACKING_PROPERTIES_FB"/></returns>
    public static XrSystemKeyboardTrackingPropertiesFB New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_KEYBOARD_TRACKING_PROPERTIES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrKeyboardTrackingDescriptionFB
{
    public ulong trackedKeyboardId;
    public XrVector3f size;
    public ulong flags;
    public fixed byte name[(int)OpenXRNative.XR_MAX_KEYBOARD_TRACKING_NAME_SIZE_FB];
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrKeyboardSpaceCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    public ulong trackedKeyboardId;
    /// <returns>a new <see cref="XrKeyboardSpaceCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_KEYBOARD_SPACE_CREATE_INFO_FB"/></returns>
    public static XrKeyboardSpaceCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_KEYBOARD_SPACE_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrKeyboardTrackingQueryFB
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    /// <returns>a new <see cref="XrKeyboardTrackingQueryFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_KEYBOARD_TRACKING_QUERY_FB"/></returns>
    public static XrKeyboardTrackingQueryFB New() =>
        new() { type = XrStructureType.XR_TYPE_KEYBOARD_TRACKING_QUERY_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerDepthTestVARJO
{
    public XrStructureType type;
    public void* next;
    public float depthTestRangeNearZ;
    public float depthTestRangeFarZ;
    /// <returns>a new <see cref="XrCompositionLayerDepthTestVARJO"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_VARJO"/></returns>
    public static XrCompositionLayerDepthTestVARJO New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_VARJO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrViewLocateFoveatedRenderingVARJO
{
    public XrStructureType type;
    public void* next;
    public XrBool32 foveatedRenderingActive;
    /// <returns>a new <see cref="XrViewLocateFoveatedRenderingVARJO"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIEW_LOCATE_FOVEATED_RENDERING_VARJO"/></returns>
    public static XrViewLocateFoveatedRenderingVARJO New() =>
        new() { type = XrStructureType.XR_TYPE_VIEW_LOCATE_FOVEATED_RENDERING_VARJO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFoveatedViewConfigurationViewVARJO
{
    public XrStructureType type;
    public void* next;
    public XrBool32 foveatedRenderingActive;
    /// <returns>a new <see cref="XrFoveatedViewConfigurationViewVARJO"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FOVEATED_VIEW_CONFIGURATION_VIEW_VARJO"/></returns>
    public static XrFoveatedViewConfigurationViewVARJO New() =>
        new() { type = XrStructureType.XR_TYPE_FOVEATED_VIEW_CONFIGURATION_VIEW_VARJO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemFoveatedRenderingPropertiesVARJO
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsFoveatedRendering;
    /// <returns>a new <see cref="XrSystemFoveatedRenderingPropertiesVARJO"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_FOVEATED_RENDERING_PROPERTIES_VARJO"/></returns>
    public static XrSystemFoveatedRenderingPropertiesVARJO New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_FOVEATED_RENDERING_PROPERTIES_VARJO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerReprojectionInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrReprojectionModeMSFT reprojectionMode;
    /// <returns>a new <see cref="XrCompositionLayerReprojectionInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_REPROJECTION_INFO_MSFT"/></returns>
    public static XrCompositionLayerReprojectionInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_REPROJECTION_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerReprojectionPlaneOverrideMSFT
{
    public XrStructureType type;
    public void* next;
    public XrVector3f position;
    public XrVector3f normal;
    public XrVector3f velocity;
    /// <returns>a new <see cref="XrCompositionLayerReprojectionPlaneOverrideMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_REPROJECTION_PLANE_OVERRIDE_MSFT"/></returns>
    public static XrCompositionLayerReprojectionPlaneOverrideMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_REPROJECTION_PLANE_OVERRIDE_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrTriangleMeshCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    public XrWindingOrderFB windingOrder;
    public uint vertexCount;
    public XrVector3f* vertexBuffer;
    public uint triangleCount;
    public uint* indexBuffer;
    /// <returns>a new <see cref="XrTriangleMeshCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_TRIANGLE_MESH_CREATE_INFO_FB"/></returns>
    public static XrTriangleMeshCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_TRIANGLE_MESH_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemPassthroughPropertiesFB
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsPassthrough;
    /// <returns>a new <see cref="XrSystemPassthroughPropertiesFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES_FB"/></returns>
    public static XrSystemPassthroughPropertiesFB New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemPassthroughProperties2FB
{
    public XrStructureType type;
    public void* next;
    public ulong capabilities;
    /// <returns>a new <see cref="XrSystemPassthroughProperties2FB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES2_FB"/></returns>
    public static XrSystemPassthroughProperties2FB New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES2_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    /// <returns>a new <see cref="XrPassthroughCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_CREATE_INFO_FB"/></returns>
    public static XrPassthroughCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughLayerCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrPassthroughFB passthrough;
    public ulong flags;
    public XrPassthroughLayerPurposeFB purpose;
    /// <returns>a new <see cref="XrPassthroughLayerCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_FB"/></returns>
    public static XrPassthroughLayerCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerPassthroughFB
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    public XrSpace space;
    public XrPassthroughLayerFB layerHandle;
    /// <returns>a new <see cref="XrCompositionLayerPassthroughFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_FB"/></returns>
    public static XrCompositionLayerPassthroughFB New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGeometryInstanceCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    public XrPassthroughLayerFB layer;
    public XrTriangleMeshFB mesh;
    public XrSpace baseSpace;
    public XrPosef pose;
    public XrVector3f scale;
    /// <returns>a new <see cref="XrGeometryInstanceCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GEOMETRY_INSTANCE_CREATE_INFO_FB"/></returns>
    public static XrGeometryInstanceCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_GEOMETRY_INSTANCE_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGeometryInstanceTransformFB
{
    public XrStructureType type;
    public void* next;
    public XrSpace baseSpace;
    public long time;
    public XrPosef pose;
    public XrVector3f scale;
    /// <returns>a new <see cref="XrGeometryInstanceTransformFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GEOMETRY_INSTANCE_TRANSFORM_FB"/></returns>
    public static XrGeometryInstanceTransformFB New() =>
        new() { type = XrStructureType.XR_TYPE_GEOMETRY_INSTANCE_TRANSFORM_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughStyleFB
{
    public XrStructureType type;
    public void* next;
    public float textureOpacityFactor;
    public XrColor4f edgeColor;
    /// <returns>a new <see cref="XrPassthroughStyleFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_STYLE_FB"/></returns>
    public static XrPassthroughStyleFB New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_STYLE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughColorMapMonoToRgbaFB
{
    public XrStructureType type;
    public void* next;
    public XrColor4f textureColorMap_0;
    public XrColor4f textureColorMap_1;
    public XrColor4f textureColorMap_2;
    public XrColor4f textureColorMap_3;
    public XrColor4f textureColorMap_4;
    public XrColor4f textureColorMap_5;
    public XrColor4f textureColorMap_6;
    public XrColor4f textureColorMap_7;
    public XrColor4f textureColorMap_8;
    public XrColor4f textureColorMap_9;
    public XrColor4f textureColorMap_10;
    public XrColor4f textureColorMap_11;
    public XrColor4f textureColorMap_12;
    public XrColor4f textureColorMap_13;
    public XrColor4f textureColorMap_14;
    public XrColor4f textureColorMap_15;
    public XrColor4f textureColorMap_16;
    public XrColor4f textureColorMap_17;
    public XrColor4f textureColorMap_18;
    public XrColor4f textureColorMap_19;
    public XrColor4f textureColorMap_20;
    public XrColor4f textureColorMap_21;
    public XrColor4f textureColorMap_22;
    public XrColor4f textureColorMap_23;
    public XrColor4f textureColorMap_24;
    public XrColor4f textureColorMap_25;
    public XrColor4f textureColorMap_26;
    public XrColor4f textureColorMap_27;
    public XrColor4f textureColorMap_28;
    public XrColor4f textureColorMap_29;
    public XrColor4f textureColorMap_30;
    public XrColor4f textureColorMap_31;
    public XrColor4f textureColorMap_32;
    public XrColor4f textureColorMap_33;
    public XrColor4f textureColorMap_34;
    public XrColor4f textureColorMap_35;
    public XrColor4f textureColorMap_36;
    public XrColor4f textureColorMap_37;
    public XrColor4f textureColorMap_38;
    public XrColor4f textureColorMap_39;
    public XrColor4f textureColorMap_40;
    public XrColor4f textureColorMap_41;
    public XrColor4f textureColorMap_42;
    public XrColor4f textureColorMap_43;
    public XrColor4f textureColorMap_44;
    public XrColor4f textureColorMap_45;
    public XrColor4f textureColorMap_46;
    public XrColor4f textureColorMap_47;
    public XrColor4f textureColorMap_48;
    public XrColor4f textureColorMap_49;
    public XrColor4f textureColorMap_50;
    public XrColor4f textureColorMap_51;
    public XrColor4f textureColorMap_52;
    public XrColor4f textureColorMap_53;
    public XrColor4f textureColorMap_54;
    public XrColor4f textureColorMap_55;
    public XrColor4f textureColorMap_56;
    public XrColor4f textureColorMap_57;
    public XrColor4f textureColorMap_58;
    public XrColor4f textureColorMap_59;
    public XrColor4f textureColorMap_60;
    public XrColor4f textureColorMap_61;
    public XrColor4f textureColorMap_62;
    public XrColor4f textureColorMap_63;
    public XrColor4f textureColorMap_64;
    public XrColor4f textureColorMap_65;
    public XrColor4f textureColorMap_66;
    public XrColor4f textureColorMap_67;
    public XrColor4f textureColorMap_68;
    public XrColor4f textureColorMap_69;
    public XrColor4f textureColorMap_70;
    public XrColor4f textureColorMap_71;
    public XrColor4f textureColorMap_72;
    public XrColor4f textureColorMap_73;
    public XrColor4f textureColorMap_74;
    public XrColor4f textureColorMap_75;
    public XrColor4f textureColorMap_76;
    public XrColor4f textureColorMap_77;
    public XrColor4f textureColorMap_78;
    public XrColor4f textureColorMap_79;
    public XrColor4f textureColorMap_80;
    public XrColor4f textureColorMap_81;
    public XrColor4f textureColorMap_82;
    public XrColor4f textureColorMap_83;
    public XrColor4f textureColorMap_84;
    public XrColor4f textureColorMap_85;
    public XrColor4f textureColorMap_86;
    public XrColor4f textureColorMap_87;
    public XrColor4f textureColorMap_88;
    public XrColor4f textureColorMap_89;
    public XrColor4f textureColorMap_90;
    public XrColor4f textureColorMap_91;
    public XrColor4f textureColorMap_92;
    public XrColor4f textureColorMap_93;
    public XrColor4f textureColorMap_94;
    public XrColor4f textureColorMap_95;
    public XrColor4f textureColorMap_96;
    public XrColor4f textureColorMap_97;
    public XrColor4f textureColorMap_98;
    public XrColor4f textureColorMap_99;
    public XrColor4f textureColorMap_100;
    public XrColor4f textureColorMap_101;
    public XrColor4f textureColorMap_102;
    public XrColor4f textureColorMap_103;
    public XrColor4f textureColorMap_104;
    public XrColor4f textureColorMap_105;
    public XrColor4f textureColorMap_106;
    public XrColor4f textureColorMap_107;
    public XrColor4f textureColorMap_108;
    public XrColor4f textureColorMap_109;
    public XrColor4f textureColorMap_110;
    public XrColor4f textureColorMap_111;
    public XrColor4f textureColorMap_112;
    public XrColor4f textureColorMap_113;
    public XrColor4f textureColorMap_114;
    public XrColor4f textureColorMap_115;
    public XrColor4f textureColorMap_116;
    public XrColor4f textureColorMap_117;
    public XrColor4f textureColorMap_118;
    public XrColor4f textureColorMap_119;
    public XrColor4f textureColorMap_120;
    public XrColor4f textureColorMap_121;
    public XrColor4f textureColorMap_122;
    public XrColor4f textureColorMap_123;
    public XrColor4f textureColorMap_124;
    public XrColor4f textureColorMap_125;
    public XrColor4f textureColorMap_126;
    public XrColor4f textureColorMap_127;
    public XrColor4f textureColorMap_128;
    public XrColor4f textureColorMap_129;
    public XrColor4f textureColorMap_130;
    public XrColor4f textureColorMap_131;
    public XrColor4f textureColorMap_132;
    public XrColor4f textureColorMap_133;
    public XrColor4f textureColorMap_134;
    public XrColor4f textureColorMap_135;
    public XrColor4f textureColorMap_136;
    public XrColor4f textureColorMap_137;
    public XrColor4f textureColorMap_138;
    public XrColor4f textureColorMap_139;
    public XrColor4f textureColorMap_140;
    public XrColor4f textureColorMap_141;
    public XrColor4f textureColorMap_142;
    public XrColor4f textureColorMap_143;
    public XrColor4f textureColorMap_144;
    public XrColor4f textureColorMap_145;
    public XrColor4f textureColorMap_146;
    public XrColor4f textureColorMap_147;
    public XrColor4f textureColorMap_148;
    public XrColor4f textureColorMap_149;
    public XrColor4f textureColorMap_150;
    public XrColor4f textureColorMap_151;
    public XrColor4f textureColorMap_152;
    public XrColor4f textureColorMap_153;
    public XrColor4f textureColorMap_154;
    public XrColor4f textureColorMap_155;
    public XrColor4f textureColorMap_156;
    public XrColor4f textureColorMap_157;
    public XrColor4f textureColorMap_158;
    public XrColor4f textureColorMap_159;
    public XrColor4f textureColorMap_160;
    public XrColor4f textureColorMap_161;
    public XrColor4f textureColorMap_162;
    public XrColor4f textureColorMap_163;
    public XrColor4f textureColorMap_164;
    public XrColor4f textureColorMap_165;
    public XrColor4f textureColorMap_166;
    public XrColor4f textureColorMap_167;
    public XrColor4f textureColorMap_168;
    public XrColor4f textureColorMap_169;
    public XrColor4f textureColorMap_170;
    public XrColor4f textureColorMap_171;
    public XrColor4f textureColorMap_172;
    public XrColor4f textureColorMap_173;
    public XrColor4f textureColorMap_174;
    public XrColor4f textureColorMap_175;
    public XrColor4f textureColorMap_176;
    public XrColor4f textureColorMap_177;
    public XrColor4f textureColorMap_178;
    public XrColor4f textureColorMap_179;
    public XrColor4f textureColorMap_180;
    public XrColor4f textureColorMap_181;
    public XrColor4f textureColorMap_182;
    public XrColor4f textureColorMap_183;
    public XrColor4f textureColorMap_184;
    public XrColor4f textureColorMap_185;
    public XrColor4f textureColorMap_186;
    public XrColor4f textureColorMap_187;
    public XrColor4f textureColorMap_188;
    public XrColor4f textureColorMap_189;
    public XrColor4f textureColorMap_190;
    public XrColor4f textureColorMap_191;
    public XrColor4f textureColorMap_192;
    public XrColor4f textureColorMap_193;
    public XrColor4f textureColorMap_194;
    public XrColor4f textureColorMap_195;
    public XrColor4f textureColorMap_196;
    public XrColor4f textureColorMap_197;
    public XrColor4f textureColorMap_198;
    public XrColor4f textureColorMap_199;
    public XrColor4f textureColorMap_200;
    public XrColor4f textureColorMap_201;
    public XrColor4f textureColorMap_202;
    public XrColor4f textureColorMap_203;
    public XrColor4f textureColorMap_204;
    public XrColor4f textureColorMap_205;
    public XrColor4f textureColorMap_206;
    public XrColor4f textureColorMap_207;
    public XrColor4f textureColorMap_208;
    public XrColor4f textureColorMap_209;
    public XrColor4f textureColorMap_210;
    public XrColor4f textureColorMap_211;
    public XrColor4f textureColorMap_212;
    public XrColor4f textureColorMap_213;
    public XrColor4f textureColorMap_214;
    public XrColor4f textureColorMap_215;
    public XrColor4f textureColorMap_216;
    public XrColor4f textureColorMap_217;
    public XrColor4f textureColorMap_218;
    public XrColor4f textureColorMap_219;
    public XrColor4f textureColorMap_220;
    public XrColor4f textureColorMap_221;
    public XrColor4f textureColorMap_222;
    public XrColor4f textureColorMap_223;
    public XrColor4f textureColorMap_224;
    public XrColor4f textureColorMap_225;
    public XrColor4f textureColorMap_226;
    public XrColor4f textureColorMap_227;
    public XrColor4f textureColorMap_228;
    public XrColor4f textureColorMap_229;
    public XrColor4f textureColorMap_230;
    public XrColor4f textureColorMap_231;
    public XrColor4f textureColorMap_232;
    public XrColor4f textureColorMap_233;
    public XrColor4f textureColorMap_234;
    public XrColor4f textureColorMap_235;
    public XrColor4f textureColorMap_236;
    public XrColor4f textureColorMap_237;
    public XrColor4f textureColorMap_238;
    public XrColor4f textureColorMap_239;
    public XrColor4f textureColorMap_240;
    public XrColor4f textureColorMap_241;
    public XrColor4f textureColorMap_242;
    public XrColor4f textureColorMap_243;
    public XrColor4f textureColorMap_244;
    public XrColor4f textureColorMap_245;
    public XrColor4f textureColorMap_246;
    public XrColor4f textureColorMap_247;
    public XrColor4f textureColorMap_248;
    public XrColor4f textureColorMap_249;
    public XrColor4f textureColorMap_250;
    public XrColor4f textureColorMap_251;
    public XrColor4f textureColorMap_252;
    public XrColor4f textureColorMap_253;
    public XrColor4f textureColorMap_254;
    public XrColor4f textureColorMap_255;
    /// <returns>a new <see cref="XrPassthroughColorMapMonoToRgbaFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_RGBA_FB"/></returns>
    public static XrPassthroughColorMapMonoToRgbaFB New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_RGBA_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughColorMapMonoToMonoFB
{
    public XrStructureType type;
    public void* next;
    public fixed byte textureColorMap[(int)OpenXRNative.XR_PASSTHROUGH_COLOR_MAP_MONO_SIZE_FB];
    /// <returns>a new <see cref="XrPassthroughColorMapMonoToMonoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_MONO_FB"/></returns>
    public static XrPassthroughColorMapMonoToMonoFB New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_MONO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughBrightnessContrastSaturationFB
{
    public XrStructureType type;
    public void* next;
    public float brightness;
    public float contrast;
    public float saturation;
    /// <returns>a new <see cref="XrPassthroughBrightnessContrastSaturationFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_BRIGHTNESS_CONTRAST_SATURATION_FB"/></returns>
    public static XrPassthroughBrightnessContrastSaturationFB New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_BRIGHTNESS_CONTRAST_SATURATION_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataPassthroughStateChangedFB
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    /// <returns>a new <see cref="XrEventDataPassthroughStateChangedFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_PASSTHROUGH_STATE_CHANGED_FB"/></returns>
    public static XrEventDataPassthroughStateChangedFB New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_PASSTHROUGH_STATE_CHANGED_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughKeyboardHandsIntensityFB
{
    public XrStructureType type;
    public void* next;
    public float leftHandIntensity;
    public float rightHandIntensity;
    /// <returns>a new <see cref="XrPassthroughKeyboardHandsIntensityFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_KEYBOARD_HANDS_INTENSITY_FB"/></returns>
    public static XrPassthroughKeyboardHandsIntensityFB New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_KEYBOARD_HANDS_INTENSITY_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrLocalDimmingFrameEndInfoMETA
{
    public XrStructureType type;
    public void* next;
    public XrLocalDimmingModeMETA localDimmingMode;
    /// <returns>a new <see cref="XrLocalDimmingFrameEndInfoMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_LOCAL_DIMMING_FRAME_END_INFO_META"/></returns>
    public static XrLocalDimmingFrameEndInfoMETA New() =>
        new() { type = XrStructureType.XR_TYPE_LOCAL_DIMMING_FRAME_END_INFO_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpatialAnchorPersistenceNameMSFT
{
    public fixed byte name[(int)OpenXRNative.XR_MAX_SPATIAL_ANCHOR_NAME_SIZE_MSFT];
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpatialAnchorPersistenceInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrSpatialAnchorPersistenceNameMSFT spatialAnchorPersistenceName;
    public XrSpatialAnchorMSFT spatialAnchor;
    /// <returns>a new <see cref="XrSpatialAnchorPersistenceInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPATIAL_ANCHOR_PERSISTENCE_INFO_MSFT"/></returns>
    public static XrSpatialAnchorPersistenceInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SPATIAL_ANCHOR_PERSISTENCE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT
{
    public XrStructureType type;
    public void* next;
    public XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore;
    public XrSpatialAnchorPersistenceNameMSFT spatialAnchorPersistenceName;
    /// <returns>a new <see cref="XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPATIAL_ANCHOR_FROM_PERSISTED_ANCHOR_CREATE_INFO_MSFT"/></returns>
    public static XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT New() =>
        new() { type = XrStructureType.XR_TYPE_SPATIAL_ANCHOR_FROM_PERSISTED_ANCHOR_CREATE_INFO_MSFT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFacialTrackerCreateInfoHTC
{
    public XrStructureType type;
    public void* next;
    public XrFacialTrackingTypeHTC facialTrackingType;
    /// <returns>a new <see cref="XrFacialTrackerCreateInfoHTC"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FACIAL_TRACKER_CREATE_INFO_HTC"/></returns>
    public static XrFacialTrackerCreateInfoHTC New() =>
        new() { type = XrStructureType.XR_TYPE_FACIAL_TRACKER_CREATE_INFO_HTC };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemFacialTrackingPropertiesHTC
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportEyeFacialTracking;
    public XrBool32 supportLipFacialTracking;
    /// <returns>a new <see cref="XrSystemFacialTrackingPropertiesHTC"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_FACIAL_TRACKING_PROPERTIES_HTC"/></returns>
    public static XrSystemFacialTrackingPropertiesHTC New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_FACIAL_TRACKING_PROPERTIES_HTC };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFacialExpressionsHTC
{
    public XrStructureType type;
    public void* next;
    public XrBool32 isActive;
    public long sampleTime;
    public uint expressionCount;
    public float* expressionWeightings;
    /// <returns>a new <see cref="XrFacialExpressionsHTC"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FACIAL_EXPRESSIONS_HTC"/></returns>
    public static XrFacialExpressionsHTC New() =>
        new() { type = XrStructureType.XR_TYPE_FACIAL_EXPRESSIONS_HTC };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughCreateInfoHTC
{
    public XrStructureType type;
    public void* next;
    public XrPassthroughFormHTC form;
    /// <returns>a new <see cref="XrPassthroughCreateInfoHTC"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_CREATE_INFO_HTC"/></returns>
    public static XrPassthroughCreateInfoHTC New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_CREATE_INFO_HTC };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughColorHTC
{
    public XrStructureType type;
    public void* next;
    public float alpha;
    /// <returns>a new <see cref="XrPassthroughColorHTC"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_HTC"/></returns>
    public static XrPassthroughColorHTC New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_HTC };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughMeshTransformInfoHTC
{
    public XrStructureType type;
    public void* next;
    public uint vertexCount;
    public XrVector3f* vertices;
    public uint indexCount;
    public uint* indices;
    public XrSpace baseSpace;
    public long time;
    public XrPosef pose;
    public XrVector3f scale;
    /// <returns>a new <see cref="XrPassthroughMeshTransformInfoHTC"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_MESH_TRANSFORM_INFO_HTC"/></returns>
    public static XrPassthroughMeshTransformInfoHTC New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_MESH_TRANSFORM_INFO_HTC };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerPassthroughHTC
{
    public XrStructureType type;
    public void* next;
    public ulong layerFlags;
    public XrSpace space;
    public XrPassthroughHTC passthrough;
    public XrPassthroughColorHTC color;
    /// <returns>a new <see cref="XrCompositionLayerPassthroughHTC"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_HTC"/></returns>
    public static XrCompositionLayerPassthroughHTC New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_HTC };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrViveTrackerPathsHTCX
{
    public XrStructureType type;
    public void* next;
    public ulong persistentPath;
    public ulong rolePath;
    /// <returns>a new <see cref="XrViveTrackerPathsHTCX"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIVE_TRACKER_PATHS_HTCX"/></returns>
    public static XrViveTrackerPathsHTCX New() =>
        new() { type = XrStructureType.XR_TYPE_VIVE_TRACKER_PATHS_HTCX };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataViveTrackerConnectedHTCX
{
    public XrStructureType type;
    public void* next;
    public XrViveTrackerPathsHTCX* paths;
    /// <returns>a new <see cref="XrEventDataViveTrackerConnectedHTCX"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_VIVE_TRACKER_CONNECTED_HTCX"/></returns>
    public static XrEventDataViveTrackerConnectedHTCX New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_VIVE_TRACKER_CONNECTED_HTCX };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerSpaceWarpInfoFB
{
    public XrStructureType type;
    public void* next;
    public ulong layerFlags;
    public XrSwapchainSubImage motionVectorSubImage;
    public XrPosef appSpaceDeltaPose;
    public XrSwapchainSubImage depthSubImage;
    public float minDepth;
    public float maxDepth;
    public float nearZ;
    public float farZ;
    /// <returns>a new <see cref="XrCompositionLayerSpaceWarpInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_SPACE_WARP_INFO_FB"/></returns>
    public static XrCompositionLayerSpaceWarpInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_SPACE_WARP_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemSpaceWarpPropertiesFB
{
    public XrStructureType type;
    public void* next;
    public uint recommendedMotionVectorImageRectWidth;
    public uint recommendedMotionVectorImageRectHeight;
    /// <returns>a new <see cref="XrSystemSpaceWarpPropertiesFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_SPACE_WARP_PROPERTIES_FB"/></returns>
    public static XrSystemSpaceWarpPropertiesFB New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_SPACE_WARP_PROPERTIES_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemMarkerTrackingPropertiesVARJO
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsMarkerTracking;
    /// <returns>a new <see cref="XrSystemMarkerTrackingPropertiesVARJO"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_VARJO"/></returns>
    public static XrSystemMarkerTrackingPropertiesVARJO New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_VARJO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataMarkerTrackingUpdateVARJO
{
    public XrStructureType type;
    public void* next;
    public ulong markerId;
    public XrBool32 isActive;
    public XrBool32 isPredicted;
    public long time;
    /// <returns>a new <see cref="XrEventDataMarkerTrackingUpdateVARJO"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_MARKER_TRACKING_UPDATE_VARJO"/></returns>
    public static XrEventDataMarkerTrackingUpdateVARJO New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_MARKER_TRACKING_UPDATE_VARJO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrMarkerSpaceCreateInfoVARJO
{
    public XrStructureType type;
    public void* next;
    public ulong markerId;
    public XrPosef poseInMarkerSpace;
    /// <returns>a new <see cref="XrMarkerSpaceCreateInfoVARJO"> with it's type member set to <see cref="XrStructureType.XR_TYPE_MARKER_SPACE_CREATE_INFO_VARJO"/></returns>
    public static XrMarkerSpaceCreateInfoVARJO New() =>
        new() { type = XrStructureType.XR_TYPE_MARKER_SPACE_CREATE_INFO_VARJO };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrUuidEXT
{
    public fixed byte data[(int)OpenXRNative.XR_UUID_SIZE_EXT];
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrGlobalDimmerFrameEndInfoML
{
    public XrStructureType type;
    public void* next;
    public float dimmerValue;
    public ulong flags;
    /// <returns>a new <see cref="XrGlobalDimmerFrameEndInfoML"> with it's type member set to <see cref="XrStructureType.XR_TYPE_GLOBAL_DIMMER_FRAME_END_INFO_ML"/></returns>
    public static XrGlobalDimmerFrameEndInfoML New() =>
        new() { type = XrStructureType.XR_TYPE_GLOBAL_DIMMER_FRAME_END_INFO_ML };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrDigitalLensControlALMALENCE
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    /// <returns>a new <see cref="XrDigitalLensControlALMALENCE"> with it's type member set to <see cref="XrStructureType.XR_TYPE_DIGITAL_LENS_CONTROL_ALMALENCE"/></returns>
    public static XrDigitalLensControlALMALENCE New() =>
        new() { type = XrStructureType.XR_TYPE_DIGITAL_LENS_CONTROL_ALMALENCE };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerSettingsFB
{
    public XrStructureType type;
    public void* next;
    public ulong layerFlags;
    /// <returns>a new <see cref="XrCompositionLayerSettingsFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_SETTINGS_FB"/></returns>
    public static XrCompositionLayerSettingsFB New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_SETTINGS_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrExternalCameraIntrinsicsOCULUS
{
    public long lastChangeTime;
    public XrFovf fov;
    public float virtualNearPlaneDistance;
    public float virtualFarPlaneDistance;
    public XrExtent2Di imageSensorPixelResolution;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrExternalCameraExtrinsicsOCULUS
{
    public long lastChangeTime;
    public ulong cameraStatusFlags;
    public XrExternalCameraAttachedToDeviceOCULUS attachedToDevice;
    public XrPosef relativePose;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrExternalCameraOCULUS
{
    public XrStructureType type;
    public void* next;
    public fixed byte name[(int)OpenXRNative.XR_MAX_EXTERNAL_CAMERA_NAME_SIZE_OCULUS];
    public XrExternalCameraIntrinsicsOCULUS intrinsics;
    public XrExternalCameraExtrinsicsOCULUS extrinsics;
    /// <returns>a new <see cref="XrExternalCameraOCULUS"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EXTERNAL_CAMERA_OCULUS"/></returns>
    public static XrExternalCameraOCULUS New() =>
        new() { type = XrStructureType.XR_TYPE_EXTERNAL_CAMERA_OCULUS };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPerformanceMetricsStateMETA
{
    public XrStructureType type;
    public void* next;
    public XrBool32 enabled;
    /// <returns>a new <see cref="XrPerformanceMetricsStateMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PERFORMANCE_METRICS_STATE_META"/></returns>
    public static XrPerformanceMetricsStateMETA New() =>
        new() { type = XrStructureType.XR_TYPE_PERFORMANCE_METRICS_STATE_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPerformanceMetricsCounterMETA
{
    public XrStructureType type;
    public void* next;
    public ulong counterFlags;
    public XrPerformanceMetricsCounterUnitMETA counterUnit;
    public uint uintValue;
    public float floatValue;
    /// <returns>a new <see cref="XrPerformanceMetricsCounterMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PERFORMANCE_METRICS_COUNTER_META"/></returns>
    public static XrPerformanceMetricsCounterMETA New() =>
        new() { type = XrStructureType.XR_TYPE_PERFORMANCE_METRICS_COUNTER_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughPreferencesMETA
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    /// <returns>a new <see cref="XrPassthroughPreferencesMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_PREFERENCES_META"/></returns>
    public static XrPassthroughPreferencesMETA New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_PREFERENCES_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemHeadsetIdPropertiesMETA
{
    public XrStructureType type;
    public void* next;
    public XrUuidEXT id;
    /// <returns>a new <see cref="XrSystemHeadsetIdPropertiesMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_HEADSET_ID_PROPERTIES_META"/></returns>
    public static XrSystemHeadsetIdPropertiesMETA New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_HEADSET_ID_PROPERTIES_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughColorLutDataMETA
{
    public uint bufferSize;
    public byte* buffer;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughColorLutCreateInfoMETA
{
    public XrStructureType type;
    public void* next;
    public XrPassthroughColorLutChannelsMETA channels;
    public uint resolution;
    public XrPassthroughColorLutDataMETA data;
    /// <returns>a new <see cref="XrPassthroughColorLutCreateInfoMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_LUT_CREATE_INFO_META"/></returns>
    public static XrPassthroughColorLutCreateInfoMETA New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_LUT_CREATE_INFO_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughColorLutUpdateInfoMETA
{
    public XrStructureType type;
    public void* next;
    public XrPassthroughColorLutDataMETA data;
    /// <returns>a new <see cref="XrPassthroughColorLutUpdateInfoMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_LUT_UPDATE_INFO_META"/></returns>
    public static XrPassthroughColorLutUpdateInfoMETA New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_LUT_UPDATE_INFO_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughColorMapLutMETA
{
    public XrStructureType type;
    public void* next;
    public XrPassthroughColorLutMETA colorLut;
    public float weight;
    /// <returns>a new <see cref="XrPassthroughColorMapLutMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_MAP_LUT_META"/></returns>
    public static XrPassthroughColorMapLutMETA New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_MAP_LUT_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPassthroughColorMapInterpolatedLutMETA
{
    public XrStructureType type;
    public void* next;
    public XrPassthroughColorLutMETA sourceColorLut;
    public XrPassthroughColorLutMETA targetColorLut;
    public float weight;
    /// <returns>a new <see cref="XrPassthroughColorMapInterpolatedLutMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_MAP_INTERPOLATED_LUT_META"/></returns>
    public static XrPassthroughColorMapInterpolatedLutMETA New() =>
        new() { type = XrStructureType.XR_TYPE_PASSTHROUGH_COLOR_MAP_INTERPOLATED_LUT_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemPassthroughColorLutPropertiesMETA
{
    public XrStructureType type;
    public void* next;
    public uint maxColorLutResolution;
    /// <returns>a new <see cref="XrSystemPassthroughColorLutPropertiesMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_PASSTHROUGH_COLOR_LUT_PROPERTIES_META"/></returns>
    public static XrSystemPassthroughColorLutPropertiesMETA New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_PASSTHROUGH_COLOR_LUT_PROPERTIES_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFoveationApplyInfoHTC
{
    public XrStructureType type;
    public void* next;
    public XrFoveationModeHTC mode;
    public uint subImageCount;
    public XrSwapchainSubImage* subImages;
    /// <returns>a new <see cref="XrFoveationApplyInfoHTC"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FOVEATION_APPLY_INFO_HTC"/></returns>
    public static XrFoveationApplyInfoHTC New() =>
        new() { type = XrStructureType.XR_TYPE_FOVEATION_APPLY_INFO_HTC };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFoveationConfigurationHTC
{
    public XrFoveationLevelHTC level;
    public float clearFovDegree;
    public XrVector2f focalCenterOffset;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFoveationDynamicModeInfoHTC
{
    public XrStructureType type;
    public void* next;
    public ulong dynamicFlags;
    /// <returns>a new <see cref="XrFoveationDynamicModeInfoHTC"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FOVEATION_DYNAMIC_MODE_INFO_HTC"/></returns>
    public static XrFoveationDynamicModeInfoHTC New() =>
        new() { type = XrStructureType.XR_TYPE_FOVEATION_DYNAMIC_MODE_INFO_HTC };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFoveationCustomModeInfoHTC
{
    public XrStructureType type;
    public void* next;
    public uint configCount;
    public XrFoveationConfigurationHTC* configs;
    /// <returns>a new <see cref="XrFoveationCustomModeInfoHTC"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FOVEATION_CUSTOM_MODE_INFO_HTC"/></returns>
    public static XrFoveationCustomModeInfoHTC New() =>
        new() { type = XrStructureType.XR_TYPE_FOVEATION_CUSTOM_MODE_INFO_HTC };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActiveActionSetPrioritiesEXT
{
    public XrStructureType type;
    public void* next;
    public uint actionSetPriorityCount;
    public XrActiveActionSetPriorityEXT* actionSetPriorities;
    /// <returns>a new <see cref="XrActiveActionSetPrioritiesEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_ACTIVE_ACTION_SET_PRIORITIES_EXT"/></returns>
    public static XrActiveActionSetPrioritiesEXT New() =>
        new() { type = XrStructureType.XR_TYPE_ACTIVE_ACTION_SET_PRIORITIES_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrActiveActionSetPriorityEXT
{
    public XrActionSet actionSet;
    public uint priorityOverride;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCompositionLayerDepthTestFB
{
    public XrStructureType type;
    public void* next;
    public XrBool32 depthMask;
    public XrCompareOpFB compareOp;
    /// <returns>a new <see cref="XrCompositionLayerDepthTestFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_FB"/></returns>
    public static XrCompositionLayerDepthTestFB New() =>
        new() { type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrCoordinateSpaceCreateInfoML
{
    public XrStructureType type;
    public void* next;
    public nint cfuid;
    public XrPosef poseInCoordinateSpace;
    /// <returns>a new <see cref="XrCoordinateSpaceCreateInfoML"> with it's type member set to <see cref="XrStructureType.XR_TYPE_COORDINATE_SPACE_CREATE_INFO_ML"/></returns>
    public static XrCoordinateSpaceCreateInfoML New() =>
        new() { type = XrStructureType.XR_TYPE_COORDINATE_SPACE_CREATE_INFO_ML };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrFrameEndInfoML
{
    public XrStructureType type;
    public void* next;
    public float focusDistance;
    public ulong flags;
    /// <returns>a new <see cref="XrFrameEndInfoML"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FRAME_END_INFO_ML"/></returns>
    public static XrFrameEndInfoML New() =>
        new() { type = XrStructureType.XR_TYPE_FRAME_END_INFO_ML };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHapticAmplitudeEnvelopeVibrationFB
{
    public XrStructureType type;
    public void* next;
    public long duration;
    public uint amplitudeCount;
    public float* amplitudes;
    /// <returns>a new <see cref="XrHapticAmplitudeEnvelopeVibrationFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAPTIC_AMPLITUDE_ENVELOPE_VIBRATION_FB"/></returns>
    public static XrHapticAmplitudeEnvelopeVibrationFB New() =>
        new() { type = XrStructureType.XR_TYPE_HAPTIC_AMPLITUDE_ENVELOPE_VIBRATION_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrHapticPcmVibrationFB
{
    public XrStructureType type;
    public void* next;
    public uint bufferSize;
    public float* buffer;
    public float sampleRate;
    public XrBool32 append;
    public uint* samplesConsumed;
    /// <returns>a new <see cref="XrHapticPcmVibrationFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_HAPTIC_PCM_VIBRATION_FB"/></returns>
    public static XrHapticPcmVibrationFB New() =>
        new() { type = XrStructureType.XR_TYPE_HAPTIC_PCM_VIBRATION_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrDevicePcmSampleRateStateFB
{
    public XrStructureType type;
    public void* next;
    public float sampleRate;
    /// <returns>a new <see cref="XrDevicePcmSampleRateStateFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_DEVICE_PCM_SAMPLE_RATE_STATE_FB"/></returns>
    public static XrDevicePcmSampleRateStateFB New() =>
        new() { type = XrStructureType.XR_TYPE_DEVICE_PCM_SAMPLE_RATE_STATE_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSpaceUserCreateInfoFB
{
    public XrStructureType type;
    public void* next;
    public ulong userId;
    /// <returns>a new <see cref="XrSpaceUserCreateInfoFB"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SPACE_USER_CREATE_INFO_FB"/></returns>
    public static XrSpaceUserCreateInfoFB New() =>
        new() { type = XrStructureType.XR_TYPE_SPACE_USER_CREATE_INFO_FB };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemForceFeedbackCurlPropertiesMNDX
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsForceFeedbackCurl;
    /// <returns>a new <see cref="XrSystemForceFeedbackCurlPropertiesMNDX"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_FORCE_FEEDBACK_CURL_PROPERTIES_MNDX"/></returns>
    public static XrSystemForceFeedbackCurlPropertiesMNDX New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_FORCE_FEEDBACK_CURL_PROPERTIES_MNDX };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrForceFeedbackCurlApplyLocationsMNDX
{
    public XrStructureType type;
    public void* next;
    public uint locationCount;
    public XrForceFeedbackCurlApplyLocationMNDX* locations;
    /// <returns>a new <see cref="XrForceFeedbackCurlApplyLocationsMNDX"> with it's type member set to <see cref="XrStructureType.XR_TYPE_FORCE_FEEDBACK_CURL_APPLY_LOCATIONS_MNDX"/></returns>
    public static XrForceFeedbackCurlApplyLocationsMNDX New() =>
        new() { type = XrStructureType.XR_TYPE_FORCE_FEEDBACK_CURL_APPLY_LOCATIONS_MNDX };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrForceFeedbackCurlApplyLocationMNDX
{
    public XrForceFeedbackCurlLocationMNDX location;
    public float value;
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemPlaneDetectionPropertiesEXT
{
    public XrStructureType type;
    public void* next;
    public ulong supportedFeatures;
    /// <returns>a new <see cref="XrSystemPlaneDetectionPropertiesEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_PLANE_DETECTION_PROPERTIES_EXT"/></returns>
    public static XrSystemPlaneDetectionPropertiesEXT New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_PLANE_DETECTION_PROPERTIES_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPlaneDetectorCreateInfoEXT
{
    public XrStructureType type;
    public void* next;
    public ulong flags;
    /// <returns>a new <see cref="XrPlaneDetectorCreateInfoEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PLANE_DETECTOR_CREATE_INFO_EXT"/></returns>
    public static XrPlaneDetectorCreateInfoEXT New() =>
        new() { type = XrStructureType.XR_TYPE_PLANE_DETECTOR_CREATE_INFO_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPlaneDetectorBeginInfoEXT
{
    public XrStructureType type;
    public void* next;
    public XrSpace baseSpace;
    public long time;
    public uint orientationCount;
    public XrPlaneDetectorOrientationEXT* orientations;
    public uint semanticTypeCount;
    public XrPlaneDetectorSemanticTypeEXT* semanticTypes;
    public uint maxPlanes;
    public float minArea;
    public XrPosef boundingBoxPose;
    public XrExtent3DfEXT boundingBoxExtent;
    /// <returns>a new <see cref="XrPlaneDetectorBeginInfoEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PLANE_DETECTOR_BEGIN_INFO_EXT"/></returns>
    public static XrPlaneDetectorBeginInfoEXT New() =>
        new() { type = XrStructureType.XR_TYPE_PLANE_DETECTOR_BEGIN_INFO_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPlaneDetectorGetInfoEXT
{
    public XrStructureType type;
    public void* next;
    public XrSpace baseSpace;
    public long time;
    /// <returns>a new <see cref="XrPlaneDetectorGetInfoEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PLANE_DETECTOR_GET_INFO_EXT"/></returns>
    public static XrPlaneDetectorGetInfoEXT New() =>
        new() { type = XrStructureType.XR_TYPE_PLANE_DETECTOR_GET_INFO_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPlaneDetectorLocationsEXT
{
    public XrStructureType type;
    public void* next;
    public uint planeLocationCapacityInput;
    public uint planeLocationCountOutput;
    public XrPlaneDetectorLocationEXT* planeLocations;
    /// <returns>a new <see cref="XrPlaneDetectorLocationsEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PLANE_DETECTOR_LOCATIONS_EXT"/></returns>
    public static XrPlaneDetectorLocationsEXT New() =>
        new() { type = XrStructureType.XR_TYPE_PLANE_DETECTOR_LOCATIONS_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPlaneDetectorLocationEXT
{
    public XrStructureType type;
    public void* next;
    public ulong planeId;
    public ulong locationFlags;
    public XrPosef pose;
    public XrExtent2Df extents;
    public XrPlaneDetectorOrientationEXT orientation;
    public XrPlaneDetectorSemanticTypeEXT semanticType;
    public uint polygonBufferCount;
    /// <returns>a new <see cref="XrPlaneDetectorLocationEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PLANE_DETECTOR_LOCATION_EXT"/></returns>
    public static XrPlaneDetectorLocationEXT New() =>
        new() { type = XrStructureType.XR_TYPE_PLANE_DETECTOR_LOCATION_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrPlaneDetectorPolygonBufferEXT
{
    public XrStructureType type;
    public void* next;
    public uint vertexCapacityInput;
    public uint vertexCountOutput;
    public XrVector2f* vertices;
    /// <returns>a new <see cref="XrPlaneDetectorPolygonBufferEXT"> with it's type member set to <see cref="XrStructureType.XR_TYPE_PLANE_DETECTOR_POLYGON_BUFFER_EXT"/></returns>
    public static XrPlaneDetectorPolygonBufferEXT New() =>
        new() { type = XrStructureType.XR_TYPE_PLANE_DETECTOR_POLYGON_BUFFER_EXT };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrSystemVirtualKeyboardPropertiesMETA
{
    public XrStructureType type;
    public void* next;
    public XrBool32 supportsVirtualKeyboard;
    /// <returns>a new <see cref="XrSystemVirtualKeyboardPropertiesMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_SYSTEM_VIRTUAL_KEYBOARD_PROPERTIES_META"/></returns>
    public static XrSystemVirtualKeyboardPropertiesMETA New() =>
        new() { type = XrStructureType.XR_TYPE_SYSTEM_VIRTUAL_KEYBOARD_PROPERTIES_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVirtualKeyboardCreateInfoMETA
{
    public XrStructureType type;
    public void* next;
    /// <returns>a new <see cref="XrVirtualKeyboardCreateInfoMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_CREATE_INFO_META"/></returns>
    public static XrVirtualKeyboardCreateInfoMETA New() =>
        new() { type = XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_CREATE_INFO_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVirtualKeyboardSpaceCreateInfoMETA
{
    public XrStructureType type;
    public void* next;
    public XrVirtualKeyboardLocationTypeMETA locationType;
    public XrSpace space;
    public XrPosef poseInSpace;
    /// <returns>a new <see cref="XrVirtualKeyboardSpaceCreateInfoMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_SPACE_CREATE_INFO_META"/></returns>
    public static XrVirtualKeyboardSpaceCreateInfoMETA New() =>
        new() { type = XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_SPACE_CREATE_INFO_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVirtualKeyboardLocationInfoMETA
{
    public XrStructureType type;
    public void* next;
    public XrVirtualKeyboardLocationTypeMETA locationType;
    public XrSpace space;
    public XrPosef poseInSpace;
    public float scale;
    /// <returns>a new <see cref="XrVirtualKeyboardLocationInfoMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_LOCATION_INFO_META"/></returns>
    public static XrVirtualKeyboardLocationInfoMETA New() =>
        new() { type = XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_LOCATION_INFO_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVirtualKeyboardModelVisibilitySetInfoMETA
{
    public XrStructureType type;
    public void* next;
    public XrBool32 visible;
    /// <returns>a new <see cref="XrVirtualKeyboardModelVisibilitySetInfoMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_MODEL_VISIBILITY_SET_INFO_META"/></returns>
    public static XrVirtualKeyboardModelVisibilitySetInfoMETA New() =>
        new() { type = XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_MODEL_VISIBILITY_SET_INFO_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVirtualKeyboardAnimationStateMETA
{
    public XrStructureType type;
    public void* next;
    public int animationIndex;
    public float fraction;
    /// <returns>a new <see cref="XrVirtualKeyboardAnimationStateMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_ANIMATION_STATE_META"/></returns>
    public static XrVirtualKeyboardAnimationStateMETA New() =>
        new() { type = XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_ANIMATION_STATE_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVirtualKeyboardModelAnimationStatesMETA
{
    public XrStructureType type;
    public void* next;
    public uint stateCapacityInput;
    public uint stateCountOutput;
    public XrVirtualKeyboardAnimationStateMETA* states;
    /// <returns>a new <see cref="XrVirtualKeyboardModelAnimationStatesMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_MODEL_ANIMATION_STATES_META"/></returns>
    public static XrVirtualKeyboardModelAnimationStatesMETA New() =>
        new() { type = XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_MODEL_ANIMATION_STATES_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVirtualKeyboardTextureDataMETA
{
    public XrStructureType type;
    public void* next;
    public uint textureWidth;
    public uint textureHeight;
    public uint bufferCapacityInput;
    public uint bufferCountOutput;
    public byte* buffer;
    /// <returns>a new <see cref="XrVirtualKeyboardTextureDataMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_TEXTURE_DATA_META"/></returns>
    public static XrVirtualKeyboardTextureDataMETA New() =>
        new() { type = XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_TEXTURE_DATA_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVirtualKeyboardInputInfoMETA
{
    public XrStructureType type;
    public void* next;
    public XrVirtualKeyboardInputSourceMETA inputSource;
    public XrSpace inputSpace;
    public XrPosef inputPoseInSpace;
    public ulong inputState;
    /// <returns>a new <see cref="XrVirtualKeyboardInputInfoMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_INPUT_INFO_META"/></returns>
    public static XrVirtualKeyboardInputInfoMETA New() =>
        new() { type = XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_INPUT_INFO_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrVirtualKeyboardTextContextChangeInfoMETA
{
    public XrStructureType type;
    public void* next;
    public byte* textContext;
    /// <returns>a new <see cref="XrVirtualKeyboardTextContextChangeInfoMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_TEXT_CONTEXT_CHANGE_INFO_META"/></returns>
    public static XrVirtualKeyboardTextContextChangeInfoMETA New() =>
        new() { type = XrStructureType.XR_TYPE_VIRTUAL_KEYBOARD_TEXT_CONTEXT_CHANGE_INFO_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataVirtualKeyboardCommitTextMETA
{
    public XrStructureType type;
    public void* next;
    public XrVirtualKeyboardMETA keyboard;
    public fixed byte text[(int)OpenXRNative.XR_MAX_VIRTUAL_KEYBOARD_COMMIT_TEXT_SIZE_META];
    /// <returns>a new <see cref="XrEventDataVirtualKeyboardCommitTextMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_COMMIT_TEXT_META"/></returns>
    public static XrEventDataVirtualKeyboardCommitTextMETA New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_COMMIT_TEXT_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataVirtualKeyboardBackspaceMETA
{
    public XrStructureType type;
    public void* next;
    public XrVirtualKeyboardMETA keyboard;
    /// <returns>a new <see cref="XrEventDataVirtualKeyboardBackspaceMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_BACKSPACE_META"/></returns>
    public static XrEventDataVirtualKeyboardBackspaceMETA New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_BACKSPACE_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataVirtualKeyboardEnterMETA
{
    public XrStructureType type;
    public void* next;
    public XrVirtualKeyboardMETA keyboard;
    /// <returns>a new <see cref="XrEventDataVirtualKeyboardEnterMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_ENTER_META"/></returns>
    public static XrEventDataVirtualKeyboardEnterMETA New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_ENTER_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataVirtualKeyboardShownMETA
{
    public XrStructureType type;
    public void* next;
    public XrVirtualKeyboardMETA keyboard;
    /// <returns>a new <see cref="XrEventDataVirtualKeyboardShownMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_SHOWN_META"/></returns>
    public static XrEventDataVirtualKeyboardShownMETA New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_SHOWN_META };
}
[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct XrEventDataVirtualKeyboardHiddenMETA
{
    public XrStructureType type;
    public void* next;
    public XrVirtualKeyboardMETA keyboard;
    /// <returns>a new <see cref="XrEventDataVirtualKeyboardHiddenMETA"> with it's type member set to <see cref="XrStructureType.XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_HIDDEN_META"/></returns>
    public static XrEventDataVirtualKeyboardHiddenMETA New() =>
        new() { type = XrStructureType.XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_HIDDEN_META };
}