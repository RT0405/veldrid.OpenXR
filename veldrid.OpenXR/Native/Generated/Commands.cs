using System;
using System.Runtime.InteropServices;

namespace Veldrid.OpenXR.Native;
public static unsafe partial class OpenXRNative
{
#pragma warning disable CA1401 // P/Invokes should not be visible
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetInstanceProcAddr(XrInstance instance, byte* name, IntPtr function);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateApiLayerProperties(uint propertyCapacityInput, uint* propertyCountOutput, XrApiLayerProperties* properties);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_UNAVAILABLE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_API_LAYER_NOT_PRESENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateInstanceExtensionProperties(byte* layerName, uint propertyCapacityInput, uint* propertyCountOutput, XrExtensionProperties* properties);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_UNAVAILABLE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_NAME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INITIALIZATION_FAILED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_EXTENSION_NOT_PRESENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_API_VERSION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_API_LAYER_NOT_PRESENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateInstance(XrInstanceCreateInfo* createInfo, XrInstance* instance);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyInstance(XrInstance instance);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetInstanceProperties(XrInstance instance, XrInstanceProperties* instanceProperties);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_EVENT_UNAVAILABLE"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPollEvent(XrInstance instance, XrEventDataBuffer* eventData);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrResultToString(XrInstance instance, XrResult value, byte buffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrStructureTypeToString(XrInstance instance, XrStructureType value, byte buffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FORM_FACTOR_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FORM_FACTOR_UNAVAILABLE"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSystem(XrInstance instance, XrSystemGetInfo* getInfo, ulong* systemId);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSystemProperties(XrInstance instance, ulong systemId, XrSystemProperties* properties);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VIEW_CONFIGURATION_TYPE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateEnvironmentBlendModes(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint environmentBlendModeCapacityInput, uint* environmentBlendModeCountOutput, XrEnvironmentBlendMode* environmentBlendModes);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INITIALIZATION_FAILED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_GRAPHICS_REQUIREMENTS_CALL_MISSING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_GRAPHICS_DEVICE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSession(XrInstance instance, XrSessionCreateInfo* createInfo, XrSession* session);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySession(XrSession session);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateReferenceSpaces(XrSession session, uint spaceCapacityInput, uint* spaceCountOutput, XrReferenceSpaceType* spaces);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_REFERENCE_SPACE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateReferenceSpace(XrSession session, XrReferenceSpaceCreateInfo* createInfo, XrSpace* space);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SPACE_BOUNDS_UNAVAILABLE"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_REFERENCE_SPACE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetReferenceSpaceBoundsRect(XrSession session, XrReferenceSpaceType referenceSpaceType, XrExtent2Df* bounds);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTION_TYPE_MISMATCH"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateActionSpace(XrSession session, XrActionSpaceCreateInfo* createInfo, XrSpace* space);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLocateSpace(XrSpace space, XrSpace baseSpace, long time, XrSpaceLocation* location);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySpace(XrSpace space);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateViewConfigurations(XrInstance instance, ulong systemId, uint viewConfigurationTypeCapacityInput, uint* viewConfigurationTypeCountOutput, XrViewConfigurationType* viewConfigurationTypes);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VIEW_CONFIGURATION_TYPE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetViewConfigurationProperties(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, XrViewConfigurationProperties* configurationProperties);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VIEW_CONFIGURATION_TYPE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateViewConfigurationViews(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint viewCapacityInput, uint* viewCountOutput, XrViewConfigurationView* views);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateSwapchainFormats(XrSession session, uint formatCapacityInput, uint* formatCountOutput, long* formats);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SWAPCHAIN_FORMAT_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSwapchain(XrSession session, XrSwapchainCreateInfo* createInfo, XrSwapchain* swapchain);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySwapchain(XrSwapchain swapchain);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateSwapchainImages(XrSwapchain swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CALL_ORDER_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrAcquireSwapchainImage(XrSwapchain swapchain, XrSwapchainImageAcquireInfo* acquireInfo, uint* index);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_TIMEOUT_EXPIRED"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CALL_ORDER_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrWaitSwapchainImage(XrSwapchain swapchain, XrSwapchainImageWaitInfo* waitInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CALL_ORDER_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrReleaseSwapchainImage(XrSwapchain swapchain, XrSwapchainImageReleaseInfo* releaseInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VIEW_CONFIGURATION_TYPE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_RUNNING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_NOT_READY"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrBeginSession(XrSession session, XrSessionBeginInfo* beginInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_NOT_STOPPING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_NOT_RUNNING"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEndSession(XrSession session);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_NOT_RUNNING"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrRequestExitSession(XrSession session);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_NOT_RUNNING"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrWaitFrame(XrSession session, XrFrameWaitInfo* frameWaitInfo, XrFrameState* frameState);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_FRAME_DISCARDED"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_NOT_RUNNING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CALL_ORDER_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrBeginFrame(XrSession session, XrFrameBeginInfo* frameBeginInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SWAPCHAIN_RECT_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_NOT_RUNNING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LAYER_LIMIT_EXCEEDED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LAYER_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ENVIRONMENT_BLEND_MODE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CALL_ORDER_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEndFrame(XrSession session, XrFrameEndInfo* frameEndInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VIEW_CONFIGURATION_TYPE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLocateViews(XrSession session, XrViewLocateInfo* viewLocateInfo, XrViewState* viewState, uint viewCapacityInput, uint* viewCountOutput, XrView* views);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_FORMAT_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_COUNT_EXCEEDED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrStringToPath(XrInstance instance, byte* pathString, ulong* path);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPathToString(XrInstance instance, ulong path, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_FORMAT_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_NAME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_NAME_DUPLICATED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LOCALIZED_NAME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LOCALIZED_NAME_DUPLICATED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateActionSet(XrInstance instance, XrActionSetCreateInfo* createInfo, XrActionSet* actionSet);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyActionSet(XrActionSet actionSet);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_FORMAT_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_NAME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_NAME_DUPLICATED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LOCALIZED_NAME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LOCALIZED_NAME_DUPLICATED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSETS_ALREADY_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateAction(XrActionSet actionSet, XrActionCreateInfo* createInfo, XrAction* action);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyAction(XrAction action);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSETS_ALREADY_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSuggestInteractionProfileBindings(XrInstance instance, XrInteractionProfileSuggestedBinding* suggestedBindings);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSETS_ALREADY_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrAttachSessionActionSets(XrSession session, XrSessionActionSetsAttachInfo* attachInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSET_NOT_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetCurrentInteractionProfile(XrSession session, ulong topLevelUserPath, XrInteractionProfileState* interactionProfile);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTION_TYPE_MISMATCH"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSET_NOT_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetActionStateBoolean(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateBoolean* state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTION_TYPE_MISMATCH"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSET_NOT_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetActionStateFloat(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateFloat* state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTION_TYPE_MISMATCH"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSET_NOT_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetActionStateVector2f(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateVector2f* state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTION_TYPE_MISMATCH"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSET_NOT_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetActionStatePose(XrSession session, XrActionStateGetInfo* getInfo, XrActionStatePose* state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_NOT_FOCUSED"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSET_NOT_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSyncActions(XrSession session, XrActionsSyncInfo* syncInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSET_NOT_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateBoundSourcesForAction(XrSession session, XrBoundSourcesForActionEnumerateInfo* enumerateInfo, uint sourceCapacityInput, uint* sourceCountOutput, ulong* sources);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSET_NOT_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetInputSourceLocalizedName(XrSession session, XrInputSourceLocalizedNameGetInfo* getInfo, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_NOT_FOCUSED"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTION_TYPE_MISMATCH"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSET_NOT_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrApplyHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo, XrHapticBaseHeader* hapticFeedback);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_NOT_FOCUSED"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTION_TYPE_MISMATCH"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSET_NOT_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrStopHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ANDROID_THREAD_SETTINGS_ID_INVALID_KHR"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ANDROID_THREAD_SETTINGS_FAILURE_KHR"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetAndroidApplicationThreadKHR(XrSession session, XrAndroidThreadTypeKHR threadType, uint threadId);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSwapchainAndroidSurfaceKHR(XrSession session, XrSwapchainCreateInfo* info, XrSwapchain* swapchain, IntPtr surface);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPerfSettingsSetPerformanceLevelEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsLevelEXT level);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrThermalGetTemperatureTrendEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsNotificationLevelEXT* notificationLevel, float* tempHeadroom, float* tempSlope);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetDebugUtilsObjectNameEXT(XrInstance instance, XrDebugUtilsObjectNameInfoEXT* nameInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateDebugUtilsMessengerEXT(XrInstance instance, XrDebugUtilsMessengerCreateInfoEXT* createInfo, XrDebugUtilsMessengerEXT* messenger);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyDebugUtilsMessengerEXT(XrDebugUtilsMessengerEXT messenger);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSubmitDebugUtilsMessageEXT(XrInstance instance, ulong messageSeverity, ulong messageTypes, XrDebugUtilsMessengerCallbackDataEXT* callbackData);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSessionBeginDebugUtilsLabelRegionEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSessionEndDebugUtilsLabelRegionEXT(XrSession session);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSessionInsertDebugUtilsLabelEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetOpenGLGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLKHR* graphicsRequirements);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetOpenGLESGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLESKHR* graphicsRequirements);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVulkanInstanceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVulkanDeviceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVulkanGraphicsDeviceKHR(XrInstance instance, ulong systemId, IntPtr vkInstance, IntPtr vkPhysicalDevice);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVulkanGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsVulkanKHR* graphicsRequirements);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetD3D11GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D11KHR* graphicsRequirements);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetD3D12GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D12KHR* graphicsRequirements);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VIEW_CONFIGURATION_TYPE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVisibilityMaskKHR(XrSession session, XrViewConfigurationType viewConfigurationType, uint viewIndex, XrVisibilityMaskTypeKHR visibilityMaskType, XrVisibilityMaskKHR* visibilityMask);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrConvertWin32PerformanceCounterToTimeKHR(XrInstance instance, IntPtr performanceCounter, long* time);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrConvertTimeToWin32PerformanceCounterKHR(XrInstance instance, long time, IntPtr performanceCounter);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrConvertTimespecTimeToTimeKHR(XrInstance instance, IntPtr timespecTime, long* time);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrConvertTimeToTimespecTimeKHR(XrInstance instance, long time, IntPtr timespecTime);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CREATE_SPATIAL_ANCHOR_FAILED_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorMSFT(XrSession session, XrSpatialAnchorCreateInfoMSFT* createInfo, XrSpatialAnchorMSFT* anchor);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorSpaceMSFT(XrSession session, XrSpatialAnchorSpaceCreateInfoMSFT* createInfo, XrSpace* space);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySpatialAnchorMSFT(XrSpatialAnchorMSFT anchor);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetInputDeviceActiveEXT(XrSession session, ulong interactionProfile, ulong topLevelPath, XrBool32 isActive);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetInputDeviceStateBoolEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrBool32 state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetInputDeviceStateFloatEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, float state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetInputDeviceStateVector2fEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrVector2f state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetInputDeviceLocationEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrSpace space, XrPosef pose);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialGraphNodeSpaceMSFT(XrSession session, XrSpatialGraphNodeSpaceCreateInfoMSFT* createInfo, XrSpace* space);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTryCreateSpatialGraphStaticNodeBindingMSFT(XrSession session, XrSpatialGraphStaticNodeBindingCreateInfoMSFT* createInfo, XrSpatialGraphNodeBindingMSFT* nodeBinding);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySpatialGraphNodeBindingMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpatialGraphNodeBindingPropertiesMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT* getInfo, XrSpatialGraphNodeBindingPropertiesMSFT* properties);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateHandTrackerEXT(XrSession session, XrHandTrackerCreateInfoEXT* createInfo, XrHandTrackerEXT* handTracker);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyHandTrackerEXT(XrHandTrackerEXT handTracker);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLocateHandJointsEXT(XrHandTrackerEXT handTracker, XrHandJointsLocateInfoEXT* locateInfo, XrHandJointLocationsEXT* locations);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateHandMeshSpaceMSFT(XrHandTrackerEXT handTracker, XrHandMeshSpaceCreateInfoMSFT* createInfo, XrSpace* space);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrUpdateHandMeshMSFT(XrHandTrackerEXT handTracker, XrHandMeshUpdateInfoMSFT* updateInfo, XrHandMeshMSFT* handMesh);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CONTROLLER_MODEL_KEY_INVALID_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetControllerModelKeyMSFT(XrSession session, ulong topLevelUserPath, XrControllerModelKeyStateMSFT* controllerModelKeyState);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CONTROLLER_MODEL_KEY_INVALID_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLoadControllerModelMSFT(XrSession session, ulong modelKey, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CONTROLLER_MODEL_KEY_INVALID_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetControllerModelPropertiesMSFT(XrSession session, ulong modelKey, XrControllerModelPropertiesMSFT* properties);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CONTROLLER_MODEL_KEY_INVALID_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetControllerModelStateMSFT(XrSession session, ulong modelKey, XrControllerModelStateMSFT* state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorFromPerceptionAnchorMSFT(XrSession session, IntPtr perceptionAnchor, XrSpatialAnchorMSFT* anchor);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTryGetPerceptionAnchorFromSpatialAnchorMSFT(XrSession session, XrSpatialAnchorMSFT anchor, IntPtr perceptionAnchor);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VIEW_CONFIGURATION_TYPE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateReprojectionModesMSFT(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint modeCapacityInput, uint* modeCountOutput, XrReprojectionModeMSFT* modes);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrUpdateSwapchainFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSwapchainStateFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateBodyTrackerFB(XrSession session, XrBodyTrackerCreateInfoFB* createInfo, XrBodyTrackerFB* bodyTracker);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyBodyTrackerFB(XrBodyTrackerFB bodyTracker);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLocateBodyJointsFB(XrBodyTrackerFB bodyTracker, XrBodyJointsLocateInfoFB* locateInfo, XrBodyJointLocationsFB* locations);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetBodySkeletonFB(XrBodyTrackerFB bodyTracker, XrBodySkeletonFB* skeleton);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrInitializeLoaderKHR(XrLoaderInitInfoBaseHeaderKHR* loaderInitInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateVulkanInstanceKHR(XrInstance instance, XrVulkanInstanceCreateInfoKHR* createInfo, IntPtr vulkanInstance, IntPtr vulkanResult);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateVulkanDeviceKHR(XrInstance instance, XrVulkanDeviceCreateInfoKHR* createInfo, IntPtr vulkanDevice, IntPtr vulkanResult);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVulkanGraphicsDevice2KHR(XrInstance instance, XrVulkanGraphicsDeviceGetInfoKHR* getInfo, IntPtr vulkanPhysicalDevice);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SYSTEM_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateSceneComputeFeaturesMSFT(XrInstance instance, ulong systemId, uint featureCapacityInput, uint* featureCountOutput, XrSceneComputeFeatureMSFT* features);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSceneObserverMSFT(XrSession session, XrSceneObserverCreateInfoMSFT* createInfo, XrSceneObserverMSFT* sceneObserver);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySceneObserverMSFT(XrSceneObserverMSFT sceneObserver);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_COMPUTE_NEW_SCENE_NOT_COMPLETED_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneCreateInfoMSFT* createInfo, XrSceneMSFT* scene);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySceneMSFT(XrSceneMSFT scene);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SCENE_COMPUTE_FEATURE_INCOMPATIBLE_MSFT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SCENE_COMPUTE_CONSISTENCY_MISMATCH_MSFT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_COMPUTE_NEW_SCENE_NOT_COMPLETED_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrComputeNewSceneMSFT(XrSceneObserverMSFT sceneObserver, XrNewSceneComputeInfoMSFT* computeInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSceneComputeStateMSFT(XrSceneObserverMSFT sceneObserver, XrSceneComputeStateMSFT* state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SCENE_COMPONENT_TYPE_MISMATCH_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsGetInfoMSFT* getInfo, XrSceneComponentsMSFT* components);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLocateSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsLocateInfoMSFT* locateInfo, XrSceneComponentLocationsMSFT* locations);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SCENE_MESH_BUFFER_ID_INVALID_MSFT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SCENE_COMPONENT_ID_INVALID_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSceneMeshBuffersMSFT(XrSceneMSFT scene, XrSceneMeshBuffersGetInfoMSFT* getInfo, XrSceneMeshBuffersMSFT* buffers);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_COMPUTE_NEW_SCENE_NOT_COMPLETED_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDeserializeSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneDeserializeInfoMSFT* deserializeInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SCENE_COMPONENT_ID_INVALID_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSerializedSceneFragmentDataMSFT(XrSceneMSFT scene, XrSerializedSceneFragmentDataGetInfoMSFT* getInfo, uint countInput, uint* readOutput, byte* buffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateDisplayRefreshRatesFB(XrSession session, uint displayRefreshRateCapacityInput, uint* displayRefreshRateCountOutput, float* displayRefreshRates);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetDisplayRefreshRateFB(XrSession session, float* displayRefreshRate);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_DISPLAY_REFRESH_RATE_UNSUPPORTED_FB"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrRequestDisplayRefreshRateFB(XrSession session, float displayRefreshRate);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateViveTrackerPathsHTCX(XrInstance instance, uint pathCapacityInput, uint* pathCountOutput, XrViveTrackerPathsHTCX* paths);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateFacialTrackerHTC(XrSession session, XrFacialTrackerCreateInfoHTC* createInfo, XrFacialTrackerHTC* facialTracker);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyFacialTrackerHTC(XrFacialTrackerHTC facialTracker);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetFacialExpressionsHTC(XrFacialTrackerHTC facialTracker, XrFacialExpressionsHTC* facialExpressions);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateColorSpacesFB(XrSession session, uint colorSpaceCapacityInput, uint* colorSpaceCountOutput, XrColorSpaceFB* colorSpaces);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_COLOR_SPACE_UNSUPPORTED_FB"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetColorSpaceFB(XrSession session, XrColorSpaceFB colorSpace);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetHandMeshFB(XrHandTrackerEXT handTracker, XrHandTrackingMeshFB* mesh);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorFB(XrSession session, XrSpatialAnchorCreateInfoFB* info, ulong* requestId);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceUuidFB(XrSpace space, XrUuidEXT* uuid);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateSpaceSupportedComponentsFB(XrSpace space, uint componentTypeCapacityInput, uint* componentTypeCountOutput, XrSpaceComponentTypeFB* componentTypes);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_STATUS_PENDING_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_STATUS_ALREADY_SET_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_SUPPORTED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentStatusSetInfoFB* info, ulong* requestId);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_SUPPORTED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentTypeFB componentType, XrSpaceComponentStatusFB* status);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateFoveationProfileFB(XrSession session, XrFoveationProfileCreateInfoFB* createInfo, XrFoveationProfileFB* profile);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyFoveationProfileFB(XrFoveationProfileFB profile);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrQuerySystemTrackedKeyboardFB(XrSession session, XrKeyboardTrackingQueryFB* queryInfo, XrKeyboardTrackingDescriptionFB* keyboard);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateKeyboardSpaceFB(XrSession session, XrKeyboardSpaceCreateInfoFB* createInfo, XrSpace* keyboardSpace);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSUFFICIENT_RESOURCES_PASSTHROUGH_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateTriangleMeshFB(XrSession session, XrTriangleMeshCreateInfoFB* createInfo, XrTriangleMeshFB* outTriangleMesh);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyTriangleMeshFB(XrTriangleMeshFB mesh);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshGetVertexBufferFB(XrTriangleMeshFB mesh, XrVector3f** outVertexBuffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshGetIndexBufferFB(XrTriangleMeshFB mesh, uint** outIndexBuffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CALL_ORDER_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshBeginUpdateFB(XrTriangleMeshFB mesh);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CALL_ORDER_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshEndUpdateFB(XrTriangleMeshFB mesh, uint vertexCount, uint triangleCount);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CALL_ORDER_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshBeginVertexBufferUpdateFB(XrTriangleMeshFB mesh, uint* outVertexCount);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CALL_ORDER_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshEndVertexBufferUpdateFB(XrTriangleMeshFB mesh);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_UNKNOWN_PASSTHROUGH_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_NOT_PERMITTED_PASSTHROUGH_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_ALREADY_CREATED_PASSTHROUGH_FB"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreatePassthroughFB(XrSession session, XrPassthroughCreateInfoFB* createInfo, XrPassthroughFB* outPassthrough);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyPassthroughFB(XrPassthroughFB passthrough);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_UNEXPECTED_STATE_PASSTHROUGH_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughStartFB(XrPassthroughFB passthrough);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_UNEXPECTED_STATE_PASSTHROUGH_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughPauseFB(XrPassthroughFB passthrough);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_UNKNOWN_PASSTHROUGH_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSUFFICIENT_RESOURCES_PASSTHROUGH_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_REQUIRED_PASSTHROUGH_FB"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreatePassthroughLayerFB(XrSession session, XrPassthroughLayerCreateInfoFB* createInfo, XrPassthroughLayerFB* outLayer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyPassthroughLayerFB(XrPassthroughLayerFB layer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_UNEXPECTED_STATE_PASSTHROUGH_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughLayerPauseFB(XrPassthroughLayerFB layer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_UNEXPECTED_STATE_PASSTHROUGH_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughLayerResumeFB(XrPassthroughLayerFB layer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughLayerSetStyleFB(XrPassthroughLayerFB layer, XrPassthroughStyleFB* style);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSUFFICIENT_RESOURCES_PASSTHROUGH_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateGeometryInstanceFB(XrSession session, XrGeometryInstanceCreateInfoFB* createInfo, XrGeometryInstanceFB* outGeometryInstance);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyGeometryInstanceFB(XrGeometryInstanceFB instance);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGeometryInstanceSetTransformFB(XrGeometryInstanceFB instance, XrGeometryInstanceTransformFB* transformation);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateRenderModelPathsFB(XrSession session, uint pathCapacityInput, uint* pathCountOutput, XrRenderModelPathInfoFB* paths);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_RENDER_MODEL_UNAVAILABLE_FB"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CALL_ORDER_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetRenderModelPropertiesFB(XrSession session, ulong path, XrRenderModelPropertiesFB* properties);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_RENDER_MODEL_UNAVAILABLE_FB"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RENDER_MODEL_KEY_INVALID_FB"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLoadRenderModelFB(XrSession session, XrRenderModelLoadInfoFB* info, XrRenderModelBufferFB* buffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetEnvironmentDepthEstimationVARJO(XrSession session, XrBool32 enabled);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetMarkerTrackingVARJO(XrSession session, XrBool32 enabled);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_MARKER_ID_INVALID_VARJO"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetMarkerTrackingTimeoutVARJO(XrSession session, ulong markerId, long timeout);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_MARKER_ID_INVALID_VARJO"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetMarkerTrackingPredictionVARJO(XrSession session, ulong markerId, XrBool32 enable);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_MARKER_NOT_TRACKED_VARJO"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_MARKER_ID_INVALID_VARJO"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetMarkerSizeVARJO(XrSession session, ulong markerId, XrExtent2Df* size);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_MARKER_ID_INVALID_VARJO"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateMarkerSpaceVARJO(XrSession session, XrMarkerSpaceCreateInfoVARJO* createInfo, XrSpace* space);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetViewOffsetVARJO(XrSession session, float offset);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpaceFromCoordinateFrameUIDML(XrSession session, XrCoordinateSpaceCreateInfoML createInfo, XrSpace* space);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorStoreConnectionMSFT(XrSession session, XrSpatialAnchorStoreConnectionMSFT* spatialAnchorStore);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySpatialAnchorStoreConnectionMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPATIAL_ANCHOR_NAME_INVALID_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceInfoMSFT* spatialAnchorPersistenceInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumeratePersistedSpatialAnchorNamesMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, uint spatialAnchorNamesCapacityInput, uint* spatialAnchorNamesCountOutput, XrSpatialAnchorPersistenceNameMSFT* persistedAnchorNames);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPATIAL_ANCHOR_NAME_NOT_FOUND_MSFT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPATIAL_ANCHOR_NAME_INVALID_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorFromPersistedNameMSFT(XrSession session, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, XrSpatialAnchorMSFT* spatialAnchor);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPATIAL_ANCHOR_NAME_NOT_FOUND_MSFT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPATIAL_ANCHOR_NAME_INVALID_MSFT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrUnpersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorPersistenceName);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrClearSpatialAnchorStoreMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrQuerySpacesFB(XrSession session, XrSpaceQueryInfoBaseHeaderFB* info, ulong* requestId);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrRetrieveSpaceQueryResultsFB(XrSession session, ulong requestId, XrSpaceQueryResultsFB* results);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSaveSpaceFB(XrSession session, XrSpaceSaveInfoFB* info, ulong* requestId);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEraseSpaceFB(XrSession session, XrSpaceEraseInfoFB* info, ulong* requestId);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetAudioOutputDeviceGuidOculus(XrInstance instance, string buffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetAudioInputDeviceGuidOculus(XrInstance instance, string buffer);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_NETWORK_TIMEOUT_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_NETWORK_REQUEST_FAILED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_MAPPING_INSUFFICIENT_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_LOCALIZATION_FAILED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_CLOUD_STORAGE_DISABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrShareSpacesFB(XrSession session, XrSpaceShareInfoFB* info, ulong* requestId);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceBoundingBox2DFB(XrSession session, XrSpace space, XrRect2Df* boundingBox2DOutput);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceBoundingBox3DFB(XrSession session, XrSpace space, XrRect3DfFB* boundingBox3DOutput);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceSemanticLabelsFB(XrSession session, XrSpace space, XrSemanticLabelsFB* semanticLabelsOutput);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceBoundary2DFB(XrSession session, XrSpace space, XrBoundary2DFB* boundary2DOutput);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceRoomLayoutFB(XrSession session, XrSpace space, XrRoomLayoutFB* roomLayoutOutput);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetDigitalLensControlALMALENCE(XrSession session, XrDigitalLensControlALMALENCE* digitalLensControl);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrRequestSceneCaptureFB(XrSession session, XrSceneCaptureRequestInfoFB* info, ulong* requestId);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceContainerFB(XrSession session, XrSpace space, XrSpaceContainerFB* spaceContainerOutput);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetFoveationEyeTrackedStateMETA(XrSession session, XrFoveationEyeTrackedStateMETA* foveationState);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateFaceTrackerFB(XrSession session, XrFaceTrackerCreateInfoFB* createInfo, XrFaceTrackerFB* faceTracker);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyFaceTrackerFB(XrFaceTrackerFB faceTracker);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetFaceExpressionWeightsFB(XrFaceTrackerFB faceTracker, XrFaceExpressionInfoFB* expressionInfo, XrFaceExpressionWeightsFB* expressionWeights);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateEyeTrackerFB(XrSession session, XrEyeTrackerCreateInfoFB* createInfo, XrEyeTrackerFB* eyeTracker);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyEyeTrackerFB(XrEyeTrackerFB eyeTracker);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetEyeGazesFB(XrEyeTrackerFB eyeTracker, XrEyeGazesInfoFB* gazeInfo, XrEyeGazesFB* eyeGazes);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughLayerSetKeyboardHandsIntensityFB(XrPassthroughLayerFB layer, XrPassthroughKeyboardHandsIntensityFB* intensity);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTION_TYPE_MISMATCH"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_ACTIONSET_NOT_ATTACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetDeviceSampleRateFB(XrSession session, XrHapticActionInfo* hapticActionInfo, XrDevicePcmSampleRateStateFB* deviceSampleRate);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetPassthroughPreferencesMETA(XrSession session, XrPassthroughPreferencesMETA* preferences);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateVirtualKeyboardMETA(XrSession session, XrVirtualKeyboardCreateInfoMETA* createInfo, XrVirtualKeyboardMETA* keyboard);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyVirtualKeyboardMETA(XrVirtualKeyboardMETA keyboard);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateVirtualKeyboardSpaceMETA(XrSession session, XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardSpaceCreateInfoMETA* createInfo, XrSpace* keyboardSpace);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSuggestVirtualKeyboardLocationMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardLocationInfoMETA* locationInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVirtualKeyboardScaleMETA(XrVirtualKeyboardMETA keyboard, float* scale);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetVirtualKeyboardModelVisibilityMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelVisibilitySetInfoMETA* modelVisibility);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVirtualKeyboardModelAnimationStatesMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelAnimationStatesMETA* animationStates);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVirtualKeyboardDirtyTexturesMETA(XrVirtualKeyboardMETA keyboard, uint textureIdCapacityInput, uint* textureIdCountOutput, ulong* textureIds);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVirtualKeyboardTextureDataMETA(XrVirtualKeyboardMETA keyboard, ulong textureId, XrVirtualKeyboardTextureDataMETA* textureData);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSendVirtualKeyboardInputMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardInputInfoMETA* info, XrPosef* interactorRootPose);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrChangeVirtualKeyboardTextContextMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardTextContextChangeInfoMETA* changeInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateExternalCamerasOCULUS(XrSession session, uint cameraCapacityInput, uint* cameraCountOutput, XrExternalCameraOCULUS* cameras);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumeratePerformanceMetricsCounterPathsMETA(XrInstance instance, uint counterPathCapacityInput, uint* counterPathCountOutput, ulong* counterPaths);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PATH_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrQueryPerformanceMetricsCounterMETA(XrSession session, ulong counterPath, XrPerformanceMetricsCounterMETA* counter);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_NETWORK_TIMEOUT_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_NETWORK_REQUEST_FAILED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_MAPPING_INSUFFICIENT_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_LOCALIZATION_FAILED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_COMPONENT_NOT_ENABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_CLOUD_STORAGE_DISABLED_FB"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSaveSpaceListFB(XrSession session, XrSpaceListSaveInfoFB* info, ulong* requestId);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpaceUserFB(XrSession session, XrSpaceUserCreateInfoFB* info, XrSpaceUserFB* user);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceUserIdFB(XrSpaceUserFB user, ulong* userId);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySpaceUserFB(XrSpaceUserFB user);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PASSTHROUGH_COLOR_LUT_BUFFER_SIZE_MISMATCH_META"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreatePassthroughColorLutMETA(XrPassthroughFB passthrough, XrPassthroughColorLutCreateInfoMETA* createInfo, XrPassthroughColorLutMETA* colorLut);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyPassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PASSTHROUGH_COLOR_LUT_BUFFER_SIZE_MISMATCH_META"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrUpdatePassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut, XrPassthroughColorLutUpdateInfoMETA* updateInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HINT_ALREADY_SET_QCOM"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetTrackingOptimizationSettingsHintQCOM(XrSession session, XrTrackingOptimizationSettingsDomainQCOM domain, XrTrackingOptimizationSettingsHintQCOM hint);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreatePassthroughHTC(XrSession session, XrPassthroughCreateInfoHTC* createInfo, XrPassthroughHTC* passthrough);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyPassthroughHTC(XrPassthroughHTC passthrough);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrApplyFoveationHTC(XrSession session, XrFoveationApplyInfoHTC* applyInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_NOT_FOCUSED"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrApplyForceFeedbackCurlMNDX(XrHandTrackerEXT handTracker, XrForceFeedbackCurlApplyLocationsMNDX* locations);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_LIMIT_REACHED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_PLANE_DETECTION_PERMISSION_DENIED_EXT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreatePlaneDetectorEXT(XrSession session, XrPlaneDetectorCreateInfoEXT* createInfo, XrPlaneDetectorEXT* planeDetector);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyPlaneDetectorEXT(XrPlaneDetectorEXT planeDetector);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_NOT_LOCATABLE_EXT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_POSE_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrBeginPlaneDetectionEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorBeginInfoEXT* beginInfo);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetPlaneDetectionStateEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectionStateEXT* state);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_TIME_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SPACE_NOT_LOCATABLE_EXT"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_CALL_ORDER_INVALID"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetPlaneDetectionsEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorGetInfoEXT* info, XrPlaneDetectorLocationsEXT* locations);
/// <returns>
///       Success Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_SESSION_LOSS_PENDING"/>
/// <br/> Error Codes:
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
/// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SESSION_LOST"/>
/// </returns>
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetPlanePolygonBufferEXT(XrPlaneDetectorEXT planeDetector, ulong planeId, uint polygonBufferIndex, XrPlaneDetectorPolygonBufferEXT* polygonBuffer);
#pragma warning restore CA1401 // P/Invokes should not be visible
}