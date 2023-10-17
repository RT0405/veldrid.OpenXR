using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Veldrid.OpenXR.Native;
public unsafe partial class OpenXRNativeInstance
{
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetInstanceProcAddr(XrInstance instance, byte* name, IntPtr function)
        => OpenXRNative.xrGetInstanceProcAddr(instance, name, function);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_SIZE_INSUFFICIENT"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateApiLayerProperties(uint propertyCapacityInput, uint* propertyCountOutput, XrApiLayerProperties* properties)
        => OpenXRNative.xrEnumerateApiLayerProperties(propertyCapacityInput, propertyCountOutput, properties);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateInstanceExtensionProperties(byte* layerName, uint propertyCapacityInput, uint* propertyCountOutput, XrExtensionProperties* properties)
        => OpenXRNative.xrEnumerateInstanceExtensionProperties(layerName, propertyCapacityInput, propertyCountOutput, properties);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateInstance(XrInstanceCreateInfo* createInfo, XrInstance* instance)
        => OpenXRNative.xrCreateInstance(createInfo, instance);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyInstance(XrInstance instance)
        => OpenXRNative.xrDestroyInstance(instance);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetInstanceProperties(XrInstance instance, XrInstanceProperties* instanceProperties)
        => OpenXRNative.xrGetInstanceProperties(instance, instanceProperties);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrPollEvent(XrInstance instance, XrEventDataBuffer* eventData)
        => OpenXRNative.xrPollEvent(instance, eventData);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrResultToString(XrInstance instance, XrResult value, byte buffer)
        => OpenXRNative.xrResultToString(instance, value, buffer);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_INSTANCE_LOST"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrStructureTypeToString(XrInstance instance, XrStructureType value, byte buffer)
        => OpenXRNative.xrStructureTypeToString(instance, value, buffer);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSystem(XrInstance instance, XrSystemGetInfo* getInfo, ulong* systemId)
        => OpenXRNative.xrGetSystem(instance, getInfo, systemId);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSystemProperties(XrInstance instance, ulong systemId, XrSystemProperties* properties)
        => OpenXRNative.xrGetSystemProperties(instance, systemId, properties);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateEnvironmentBlendModes(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint environmentBlendModeCapacityInput, uint* environmentBlendModeCountOutput, XrEnvironmentBlendMode* environmentBlendModes)
        => OpenXRNative.xrEnumerateEnvironmentBlendModes(instance, systemId, viewConfigurationType, environmentBlendModeCapacityInput, environmentBlendModeCountOutput, environmentBlendModes);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSession(XrInstance instance, XrSessionCreateInfo* createInfo, XrSession* session)
        => OpenXRNative.xrCreateSession(instance, createInfo, session);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroySession(XrSession session)
        => OpenXRNative.xrDestroySession(session);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateReferenceSpaces(XrSession session, uint spaceCapacityInput, uint* spaceCountOutput, XrReferenceSpaceType* spaces)
        => OpenXRNative.xrEnumerateReferenceSpaces(session, spaceCapacityInput, spaceCountOutput, spaces);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateReferenceSpace(XrSession session, XrReferenceSpaceCreateInfo* createInfo, XrSpace* space)
        => OpenXRNative.xrCreateReferenceSpace(session, createInfo, space);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetReferenceSpaceBoundsRect(XrSession session, XrReferenceSpaceType referenceSpaceType, XrExtent2Df* bounds)
        => OpenXRNative.xrGetReferenceSpaceBoundsRect(session, referenceSpaceType, bounds);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateActionSpace(XrSession session, XrActionSpaceCreateInfo* createInfo, XrSpace* space)
        => OpenXRNative.xrCreateActionSpace(session, createInfo, space);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrLocateSpace(XrSpace space, XrSpace baseSpace, long time, XrSpaceLocation* location)
        => OpenXRNative.xrLocateSpace(space, baseSpace, time, location);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroySpace(XrSpace space)
        => OpenXRNative.xrDestroySpace(space);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateViewConfigurations(XrInstance instance, ulong systemId, uint viewConfigurationTypeCapacityInput, uint* viewConfigurationTypeCountOutput, XrViewConfigurationType* viewConfigurationTypes)
        => OpenXRNative.xrEnumerateViewConfigurations(instance, systemId, viewConfigurationTypeCapacityInput, viewConfigurationTypeCountOutput, viewConfigurationTypes);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetViewConfigurationProperties(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, XrViewConfigurationProperties* configurationProperties)
        => OpenXRNative.xrGetViewConfigurationProperties(instance, systemId, viewConfigurationType, configurationProperties);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateViewConfigurationViews(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint viewCapacityInput, uint* viewCountOutput, XrViewConfigurationView* views)
        => OpenXRNative.xrEnumerateViewConfigurationViews(instance, systemId, viewConfigurationType, viewCapacityInput, viewCountOutput, views);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateSwapchainFormats(XrSession session, uint formatCapacityInput, uint* formatCountOutput, long* formats)
        => OpenXRNative.xrEnumerateSwapchainFormats(session, formatCapacityInput, formatCountOutput, formats);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSwapchain(XrSession session, XrSwapchainCreateInfo* createInfo, XrSwapchain* swapchain)
        => OpenXRNative.xrCreateSwapchain(session, createInfo, swapchain);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroySwapchain(XrSwapchain swapchain)
        => OpenXRNative.xrDestroySwapchain(swapchain);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateSwapchainImages(XrSwapchain swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images)
        => OpenXRNative.xrEnumerateSwapchainImages(swapchain, imageCapacityInput, imageCountOutput, images);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrAcquireSwapchainImage(XrSwapchain swapchain, XrSwapchainImageAcquireInfo* acquireInfo, uint* index)
        => OpenXRNative.xrAcquireSwapchainImage(swapchain, acquireInfo, index);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrWaitSwapchainImage(XrSwapchain swapchain, XrSwapchainImageWaitInfo* waitInfo)
        => OpenXRNative.xrWaitSwapchainImage(swapchain, waitInfo);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrReleaseSwapchainImage(XrSwapchain swapchain, XrSwapchainImageReleaseInfo* releaseInfo)
        => OpenXRNative.xrReleaseSwapchainImage(swapchain, releaseInfo);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrBeginSession(XrSession session, XrSessionBeginInfo* beginInfo)
        => OpenXRNative.xrBeginSession(session, beginInfo);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEndSession(XrSession session)
        => OpenXRNative.xrEndSession(session);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrRequestExitSession(XrSession session)
        => OpenXRNative.xrRequestExitSession(session);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrWaitFrame(XrSession session, XrFrameWaitInfo* frameWaitInfo, XrFrameState* frameState)
        => OpenXRNative.xrWaitFrame(session, frameWaitInfo, frameState);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrBeginFrame(XrSession session, XrFrameBeginInfo* frameBeginInfo)
        => OpenXRNative.xrBeginFrame(session, frameBeginInfo);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEndFrame(XrSession session, XrFrameEndInfo* frameEndInfo)
        => OpenXRNative.xrEndFrame(session, frameEndInfo);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrLocateViews(XrSession session, XrViewLocateInfo* viewLocateInfo, XrViewState* viewState, uint viewCapacityInput, uint* viewCountOutput, XrView* views)
        => OpenXRNative.xrLocateViews(session, viewLocateInfo, viewState, viewCapacityInput, viewCountOutput, views);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrStringToPath(XrInstance instance, byte* pathString, ulong* path)
        => OpenXRNative.xrStringToPath(instance, pathString, path);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrPathToString(XrInstance instance, ulong path, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        => OpenXRNative.xrPathToString(instance, path, bufferCapacityInput, bufferCountOutput, buffer);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateActionSet(XrInstance instance, XrActionSetCreateInfo* createInfo, XrActionSet* actionSet)
        => OpenXRNative.xrCreateActionSet(instance, createInfo, actionSet);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyActionSet(XrActionSet actionSet)
        => OpenXRNative.xrDestroyActionSet(actionSet);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateAction(XrActionSet actionSet, XrActionCreateInfo* createInfo, XrAction* action)
        => OpenXRNative.xrCreateAction(actionSet, createInfo, action);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyAction(XrAction action)
        => OpenXRNative.xrDestroyAction(action);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSuggestInteractionProfileBindings(XrInstance instance, XrInteractionProfileSuggestedBinding* suggestedBindings)
        => OpenXRNative.xrSuggestInteractionProfileBindings(instance, suggestedBindings);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrAttachSessionActionSets(XrSession session, XrSessionActionSetsAttachInfo* attachInfo)
        => OpenXRNative.xrAttachSessionActionSets(session, attachInfo);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetCurrentInteractionProfile(XrSession session, ulong topLevelUserPath, XrInteractionProfileState* interactionProfile)
        => OpenXRNative.xrGetCurrentInteractionProfile(session, topLevelUserPath, interactionProfile);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetActionStateBoolean(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateBoolean* state)
        => OpenXRNative.xrGetActionStateBoolean(session, getInfo, state);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetActionStateFloat(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateFloat* state)
        => OpenXRNative.xrGetActionStateFloat(session, getInfo, state);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetActionStateVector2f(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateVector2f* state)
        => OpenXRNative.xrGetActionStateVector2f(session, getInfo, state);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetActionStatePose(XrSession session, XrActionStateGetInfo* getInfo, XrActionStatePose* state)
        => OpenXRNative.xrGetActionStatePose(session, getInfo, state);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSyncActions(XrSession session, XrActionsSyncInfo* syncInfo)
        => OpenXRNative.xrSyncActions(session, syncInfo);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateBoundSourcesForAction(XrSession session, XrBoundSourcesForActionEnumerateInfo* enumerateInfo, uint sourceCapacityInput, uint* sourceCountOutput, ulong* sources)
        => OpenXRNative.xrEnumerateBoundSourcesForAction(session, enumerateInfo, sourceCapacityInput, sourceCountOutput, sources);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetInputSourceLocalizedName(XrSession session, XrInputSourceLocalizedNameGetInfo* getInfo, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        => OpenXRNative.xrGetInputSourceLocalizedName(session, getInfo, bufferCapacityInput, bufferCountOutput, buffer);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrApplyHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo, XrHapticBaseHeader* hapticFeedback)
        => OpenXRNative.xrApplyHapticFeedback(session, hapticActionInfo, hapticFeedback);

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrStopHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo)
        => OpenXRNative.xrStopHapticFeedback(session, hapticActionInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetAndroidApplicationThreadKHRDelegate(XrSession session, XrAndroidThreadTypeKHR threadType, uint threadId);
        private  xrSetAndroidApplicationThreadKHRDelegate xrSetAndroidApplicationThreadKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_android_thread_settings" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetAndroidApplicationThreadKHR(XrSession session, XrAndroidThreadTypeKHR threadType, uint threadId)
        => xrSetAndroidApplicationThreadKHR_ptr(session, threadType, threadId);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSwapchainAndroidSurfaceKHRDelegate(XrSession session, XrSwapchainCreateInfo* info, XrSwapchain* swapchain, IntPtr surface);
        private  xrCreateSwapchainAndroidSurfaceKHRDelegate xrCreateSwapchainAndroidSurfaceKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_android_surface_swapchain" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSwapchainAndroidSurfaceKHR(XrSession session, XrSwapchainCreateInfo* info, XrSwapchain* swapchain, IntPtr surface)
        => xrCreateSwapchainAndroidSurfaceKHR_ptr(session, info, swapchain, surface);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrPerfSettingsSetPerformanceLevelEXTDelegate(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsLevelEXT level);
        private  xrPerfSettingsSetPerformanceLevelEXTDelegate xrPerfSettingsSetPerformanceLevelEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_performance_settings" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrPerfSettingsSetPerformanceLevelEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsLevelEXT level)
        => xrPerfSettingsSetPerformanceLevelEXT_ptr(session, domain, level);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrThermalGetTemperatureTrendEXTDelegate(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsNotificationLevelEXT* notificationLevel, float* tempHeadroom, float* tempSlope);
        private  xrThermalGetTemperatureTrendEXTDelegate xrThermalGetTemperatureTrendEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_thermal_query" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrThermalGetTemperatureTrendEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsNotificationLevelEXT* notificationLevel, float* tempHeadroom, float* tempSlope)
        => xrThermalGetTemperatureTrendEXT_ptr(session, domain, notificationLevel, tempHeadroom, tempSlope);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetDebugUtilsObjectNameEXTDelegate(XrInstance instance, XrDebugUtilsObjectNameInfoEXT* nameInfo);
        private  xrSetDebugUtilsObjectNameEXTDelegate xrSetDebugUtilsObjectNameEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_debug_utils" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetDebugUtilsObjectNameEXT(XrInstance instance, XrDebugUtilsObjectNameInfoEXT* nameInfo)
        => xrSetDebugUtilsObjectNameEXT_ptr(instance, nameInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateDebugUtilsMessengerEXTDelegate(XrInstance instance, XrDebugUtilsMessengerCreateInfoEXT* createInfo, XrDebugUtilsMessengerEXT* messenger);
        private  xrCreateDebugUtilsMessengerEXTDelegate xrCreateDebugUtilsMessengerEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_debug_utils" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateDebugUtilsMessengerEXT(XrInstance instance, XrDebugUtilsMessengerCreateInfoEXT* createInfo, XrDebugUtilsMessengerEXT* messenger)
        => xrCreateDebugUtilsMessengerEXT_ptr(instance, createInfo, messenger);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyDebugUtilsMessengerEXTDelegate(XrDebugUtilsMessengerEXT messenger);
        private  xrDestroyDebugUtilsMessengerEXTDelegate xrDestroyDebugUtilsMessengerEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_debug_utils" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyDebugUtilsMessengerEXT(XrDebugUtilsMessengerEXT messenger)
        => xrDestroyDebugUtilsMessengerEXT_ptr(messenger);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSubmitDebugUtilsMessageEXTDelegate(XrInstance instance, ulong messageSeverity, ulong messageTypes, XrDebugUtilsMessengerCallbackDataEXT* callbackData);
        private  xrSubmitDebugUtilsMessageEXTDelegate xrSubmitDebugUtilsMessageEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_debug_utils" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSubmitDebugUtilsMessageEXT(XrInstance instance, ulong messageSeverity, ulong messageTypes, XrDebugUtilsMessengerCallbackDataEXT* callbackData)
        => xrSubmitDebugUtilsMessageEXT_ptr(instance, messageSeverity, messageTypes, callbackData);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSessionBeginDebugUtilsLabelRegionEXTDelegate(XrSession session, XrDebugUtilsLabelEXT* labelInfo);
        private  xrSessionBeginDebugUtilsLabelRegionEXTDelegate xrSessionBeginDebugUtilsLabelRegionEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_debug_utils" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSessionBeginDebugUtilsLabelRegionEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo)
        => xrSessionBeginDebugUtilsLabelRegionEXT_ptr(session, labelInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSessionEndDebugUtilsLabelRegionEXTDelegate(XrSession session);
        private  xrSessionEndDebugUtilsLabelRegionEXTDelegate xrSessionEndDebugUtilsLabelRegionEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_debug_utils" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSessionEndDebugUtilsLabelRegionEXT(XrSession session)
        => xrSessionEndDebugUtilsLabelRegionEXT_ptr(session);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSessionInsertDebugUtilsLabelEXTDelegate(XrSession session, XrDebugUtilsLabelEXT* labelInfo);
        private  xrSessionInsertDebugUtilsLabelEXTDelegate xrSessionInsertDebugUtilsLabelEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_debug_utils" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSessionInsertDebugUtilsLabelEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo)
        => xrSessionInsertDebugUtilsLabelEXT_ptr(session, labelInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetOpenGLGraphicsRequirementsKHRDelegate(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLKHR* graphicsRequirements);
        private  xrGetOpenGLGraphicsRequirementsKHRDelegate xrGetOpenGLGraphicsRequirementsKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_opengl_enable" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetOpenGLGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLKHR* graphicsRequirements)
        => xrGetOpenGLGraphicsRequirementsKHR_ptr(instance, systemId, graphicsRequirements);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetOpenGLESGraphicsRequirementsKHRDelegate(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLESKHR* graphicsRequirements);
        private  xrGetOpenGLESGraphicsRequirementsKHRDelegate xrGetOpenGLESGraphicsRequirementsKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_opengl_es_enable" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetOpenGLESGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLESKHR* graphicsRequirements)
        => xrGetOpenGLESGraphicsRequirementsKHR_ptr(instance, systemId, graphicsRequirements);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetVulkanInstanceExtensionsKHRDelegate(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
        private  xrGetVulkanInstanceExtensionsKHRDelegate xrGetVulkanInstanceExtensionsKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_vulkan_enable" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetVulkanInstanceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        => xrGetVulkanInstanceExtensionsKHR_ptr(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetVulkanDeviceExtensionsKHRDelegate(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
        private  xrGetVulkanDeviceExtensionsKHRDelegate xrGetVulkanDeviceExtensionsKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_vulkan_enable" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetVulkanDeviceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        => xrGetVulkanDeviceExtensionsKHR_ptr(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetVulkanGraphicsDeviceKHRDelegate(XrInstance instance, ulong systemId, IntPtr vkInstance, IntPtr vkPhysicalDevice);
        private  xrGetVulkanGraphicsDeviceKHRDelegate xrGetVulkanGraphicsDeviceKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_vulkan_enable" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetVulkanGraphicsDeviceKHR(XrInstance instance, ulong systemId, IntPtr vkInstance, IntPtr vkPhysicalDevice)
        => xrGetVulkanGraphicsDeviceKHR_ptr(instance, systemId, vkInstance, vkPhysicalDevice);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetVulkanGraphicsRequirementsKHRDelegate(XrInstance instance, ulong systemId, XrGraphicsRequirementsVulkanKHR* graphicsRequirements);
        private  xrGetVulkanGraphicsRequirementsKHRDelegate xrGetVulkanGraphicsRequirementsKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_vulkan_enable" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetVulkanGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsVulkanKHR* graphicsRequirements)
        => xrGetVulkanGraphicsRequirementsKHR_ptr(instance, systemId, graphicsRequirements);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetD3D11GraphicsRequirementsKHRDelegate(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D11KHR* graphicsRequirements);
        private  xrGetD3D11GraphicsRequirementsKHRDelegate xrGetD3D11GraphicsRequirementsKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_D3D11_enable" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetD3D11GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D11KHR* graphicsRequirements)
        => xrGetD3D11GraphicsRequirementsKHR_ptr(instance, systemId, graphicsRequirements);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetD3D12GraphicsRequirementsKHRDelegate(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D12KHR* graphicsRequirements);
        private  xrGetD3D12GraphicsRequirementsKHRDelegate xrGetD3D12GraphicsRequirementsKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_D3D12_enable" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetD3D12GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D12KHR* graphicsRequirements)
        => xrGetD3D12GraphicsRequirementsKHR_ptr(instance, systemId, graphicsRequirements);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetVisibilityMaskKHRDelegate(XrSession session, XrViewConfigurationType viewConfigurationType, uint viewIndex, XrVisibilityMaskTypeKHR visibilityMaskType, XrVisibilityMaskKHR* visibilityMask);
        private  xrGetVisibilityMaskKHRDelegate xrGetVisibilityMaskKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_visibility_mask" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetVisibilityMaskKHR(XrSession session, XrViewConfigurationType viewConfigurationType, uint viewIndex, XrVisibilityMaskTypeKHR visibilityMaskType, XrVisibilityMaskKHR* visibilityMask)
        => xrGetVisibilityMaskKHR_ptr(session, viewConfigurationType, viewIndex, visibilityMaskType, visibilityMask);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrConvertWin32PerformanceCounterToTimeKHRDelegate(XrInstance instance, IntPtr performanceCounter, long* time);
        private  xrConvertWin32PerformanceCounterToTimeKHRDelegate xrConvertWin32PerformanceCounterToTimeKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_win32_convert_performance_counter_time" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrConvertWin32PerformanceCounterToTimeKHR(XrInstance instance, IntPtr performanceCounter, long* time)
        => xrConvertWin32PerformanceCounterToTimeKHR_ptr(instance, performanceCounter, time);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrConvertTimeToWin32PerformanceCounterKHRDelegate(XrInstance instance, long time, IntPtr performanceCounter);
        private  xrConvertTimeToWin32PerformanceCounterKHRDelegate xrConvertTimeToWin32PerformanceCounterKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_win32_convert_performance_counter_time" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrConvertTimeToWin32PerformanceCounterKHR(XrInstance instance, long time, IntPtr performanceCounter)
        => xrConvertTimeToWin32PerformanceCounterKHR_ptr(instance, time, performanceCounter);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrConvertTimespecTimeToTimeKHRDelegate(XrInstance instance, IntPtr timespecTime, long* time);
        private  xrConvertTimespecTimeToTimeKHRDelegate xrConvertTimespecTimeToTimeKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_convert_timespec_time" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrConvertTimespecTimeToTimeKHR(XrInstance instance, IntPtr timespecTime, long* time)
        => xrConvertTimespecTimeToTimeKHR_ptr(instance, timespecTime, time);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrConvertTimeToTimespecTimeKHRDelegate(XrInstance instance, long time, IntPtr timespecTime);
        private  xrConvertTimeToTimespecTimeKHRDelegate xrConvertTimeToTimespecTimeKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_convert_timespec_time" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrConvertTimeToTimespecTimeKHR(XrInstance instance, long time, IntPtr timespecTime)
        => xrConvertTimeToTimespecTimeKHR_ptr(instance, time, timespecTime);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSpatialAnchorMSFTDelegate(XrSession session, XrSpatialAnchorCreateInfoMSFT* createInfo, XrSpatialAnchorMSFT* anchor);
        private  xrCreateSpatialAnchorMSFTDelegate xrCreateSpatialAnchorMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_anchor" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSpatialAnchorMSFT(XrSession session, XrSpatialAnchorCreateInfoMSFT* createInfo, XrSpatialAnchorMSFT* anchor)
        => xrCreateSpatialAnchorMSFT_ptr(session, createInfo, anchor);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSpatialAnchorSpaceMSFTDelegate(XrSession session, XrSpatialAnchorSpaceCreateInfoMSFT* createInfo, XrSpace* space);
        private  xrCreateSpatialAnchorSpaceMSFTDelegate xrCreateSpatialAnchorSpaceMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_anchor" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSpatialAnchorSpaceMSFT(XrSession session, XrSpatialAnchorSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        => xrCreateSpatialAnchorSpaceMSFT_ptr(session, createInfo, space);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroySpatialAnchorMSFTDelegate(XrSpatialAnchorMSFT anchor);
        private  xrDestroySpatialAnchorMSFTDelegate xrDestroySpatialAnchorMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_anchor" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroySpatialAnchorMSFT(XrSpatialAnchorMSFT anchor)
        => xrDestroySpatialAnchorMSFT_ptr(anchor);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetInputDeviceActiveEXTDelegate(XrSession session, ulong interactionProfile, ulong topLevelPath, XrBool32 isActive);
        private  xrSetInputDeviceActiveEXTDelegate xrSetInputDeviceActiveEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_conformance_automation" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetInputDeviceActiveEXT(XrSession session, ulong interactionProfile, ulong topLevelPath, XrBool32 isActive)
        => xrSetInputDeviceActiveEXT_ptr(session, interactionProfile, topLevelPath, isActive);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetInputDeviceStateBoolEXTDelegate(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrBool32 state);
        private  xrSetInputDeviceStateBoolEXTDelegate xrSetInputDeviceStateBoolEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_conformance_automation" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetInputDeviceStateBoolEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrBool32 state)
        => xrSetInputDeviceStateBoolEXT_ptr(session, topLevelPath, inputSourcePath, state);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetInputDeviceStateFloatEXTDelegate(XrSession session, ulong topLevelPath, ulong inputSourcePath, float state);
        private  xrSetInputDeviceStateFloatEXTDelegate xrSetInputDeviceStateFloatEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_conformance_automation" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetInputDeviceStateFloatEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, float state)
        => xrSetInputDeviceStateFloatEXT_ptr(session, topLevelPath, inputSourcePath, state);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetInputDeviceStateVector2fEXTDelegate(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrVector2f state);
        private  xrSetInputDeviceStateVector2fEXTDelegate xrSetInputDeviceStateVector2fEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_conformance_automation" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetInputDeviceStateVector2fEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrVector2f state)
        => xrSetInputDeviceStateVector2fEXT_ptr(session, topLevelPath, inputSourcePath, state);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetInputDeviceLocationEXTDelegate(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrSpace space, XrPosef pose);
        private  xrSetInputDeviceLocationEXTDelegate xrSetInputDeviceLocationEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_conformance_automation" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetInputDeviceLocationEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrSpace space, XrPosef pose)
        => xrSetInputDeviceLocationEXT_ptr(session, topLevelPath, inputSourcePath, space, pose);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSpatialGraphNodeSpaceMSFTDelegate(XrSession session, XrSpatialGraphNodeSpaceCreateInfoMSFT* createInfo, XrSpace* space);
        private  xrCreateSpatialGraphNodeSpaceMSFTDelegate xrCreateSpatialGraphNodeSpaceMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_graph_bridge" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSpatialGraphNodeSpaceMSFT(XrSession session, XrSpatialGraphNodeSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        => xrCreateSpatialGraphNodeSpaceMSFT_ptr(session, createInfo, space);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrTryCreateSpatialGraphStaticNodeBindingMSFTDelegate(XrSession session, XrSpatialGraphStaticNodeBindingCreateInfoMSFT* createInfo, XrSpatialGraphNodeBindingMSFT* nodeBinding);
        private  xrTryCreateSpatialGraphStaticNodeBindingMSFTDelegate xrTryCreateSpatialGraphStaticNodeBindingMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_graph_bridge" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrTryCreateSpatialGraphStaticNodeBindingMSFT(XrSession session, XrSpatialGraphStaticNodeBindingCreateInfoMSFT* createInfo, XrSpatialGraphNodeBindingMSFT* nodeBinding)
        => xrTryCreateSpatialGraphStaticNodeBindingMSFT_ptr(session, createInfo, nodeBinding);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroySpatialGraphNodeBindingMSFTDelegate(XrSpatialGraphNodeBindingMSFT nodeBinding);
        private  xrDestroySpatialGraphNodeBindingMSFTDelegate xrDestroySpatialGraphNodeBindingMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_graph_bridge" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroySpatialGraphNodeBindingMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding)
        => xrDestroySpatialGraphNodeBindingMSFT_ptr(nodeBinding);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSpatialGraphNodeBindingPropertiesMSFTDelegate(XrSpatialGraphNodeBindingMSFT nodeBinding, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT* getInfo, XrSpatialGraphNodeBindingPropertiesMSFT* properties);
        private  xrGetSpatialGraphNodeBindingPropertiesMSFTDelegate xrGetSpatialGraphNodeBindingPropertiesMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_graph_bridge" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSpatialGraphNodeBindingPropertiesMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT* getInfo, XrSpatialGraphNodeBindingPropertiesMSFT* properties)
        => xrGetSpatialGraphNodeBindingPropertiesMSFT_ptr(nodeBinding, getInfo, properties);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateHandTrackerEXTDelegate(XrSession session, XrHandTrackerCreateInfoEXT* createInfo, XrHandTrackerEXT* handTracker);
        private  xrCreateHandTrackerEXTDelegate xrCreateHandTrackerEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_hand_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateHandTrackerEXT(XrSession session, XrHandTrackerCreateInfoEXT* createInfo, XrHandTrackerEXT* handTracker)
        => xrCreateHandTrackerEXT_ptr(session, createInfo, handTracker);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyHandTrackerEXTDelegate(XrHandTrackerEXT handTracker);
        private  xrDestroyHandTrackerEXTDelegate xrDestroyHandTrackerEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_hand_tracking" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyHandTrackerEXT(XrHandTrackerEXT handTracker)
        => xrDestroyHandTrackerEXT_ptr(handTracker);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrLocateHandJointsEXTDelegate(XrHandTrackerEXT handTracker, XrHandJointsLocateInfoEXT* locateInfo, XrHandJointLocationsEXT* locations);
        private  xrLocateHandJointsEXTDelegate xrLocateHandJointsEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_hand_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrLocateHandJointsEXT(XrHandTrackerEXT handTracker, XrHandJointsLocateInfoEXT* locateInfo, XrHandJointLocationsEXT* locations)
        => xrLocateHandJointsEXT_ptr(handTracker, locateInfo, locations);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateHandMeshSpaceMSFTDelegate(XrHandTrackerEXT handTracker, XrHandMeshSpaceCreateInfoMSFT* createInfo, XrSpace* space);
        private  xrCreateHandMeshSpaceMSFTDelegate xrCreateHandMeshSpaceMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_hand_tracking_mesh" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateHandMeshSpaceMSFT(XrHandTrackerEXT handTracker, XrHandMeshSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        => xrCreateHandMeshSpaceMSFT_ptr(handTracker, createInfo, space);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrUpdateHandMeshMSFTDelegate(XrHandTrackerEXT handTracker, XrHandMeshUpdateInfoMSFT* updateInfo, XrHandMeshMSFT* handMesh);
        private  xrUpdateHandMeshMSFTDelegate xrUpdateHandMeshMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_hand_tracking_mesh" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrUpdateHandMeshMSFT(XrHandTrackerEXT handTracker, XrHandMeshUpdateInfoMSFT* updateInfo, XrHandMeshMSFT* handMesh)
        => xrUpdateHandMeshMSFT_ptr(handTracker, updateInfo, handMesh);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetControllerModelKeyMSFTDelegate(XrSession session, ulong topLevelUserPath, XrControllerModelKeyStateMSFT* controllerModelKeyState);
        private  xrGetControllerModelKeyMSFTDelegate xrGetControllerModelKeyMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_controller_model" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetControllerModelKeyMSFT(XrSession session, ulong topLevelUserPath, XrControllerModelKeyStateMSFT* controllerModelKeyState)
        => xrGetControllerModelKeyMSFT_ptr(session, topLevelUserPath, controllerModelKeyState);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrLoadControllerModelMSFTDelegate(XrSession session, ulong modelKey, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
        private  xrLoadControllerModelMSFTDelegate xrLoadControllerModelMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_controller_model" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrLoadControllerModelMSFT(XrSession session, ulong modelKey, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        => xrLoadControllerModelMSFT_ptr(session, modelKey, bufferCapacityInput, bufferCountOutput, buffer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetControllerModelPropertiesMSFTDelegate(XrSession session, ulong modelKey, XrControllerModelPropertiesMSFT* properties);
        private  xrGetControllerModelPropertiesMSFTDelegate xrGetControllerModelPropertiesMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_controller_model" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetControllerModelPropertiesMSFT(XrSession session, ulong modelKey, XrControllerModelPropertiesMSFT* properties)
        => xrGetControllerModelPropertiesMSFT_ptr(session, modelKey, properties);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetControllerModelStateMSFTDelegate(XrSession session, ulong modelKey, XrControllerModelStateMSFT* state);
        private  xrGetControllerModelStateMSFTDelegate xrGetControllerModelStateMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_controller_model" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetControllerModelStateMSFT(XrSession session, ulong modelKey, XrControllerModelStateMSFT* state)
        => xrGetControllerModelStateMSFT_ptr(session, modelKey, state);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSpatialAnchorFromPerceptionAnchorMSFTDelegate(XrSession session, IntPtr perceptionAnchor, XrSpatialAnchorMSFT* anchor);
        private  xrCreateSpatialAnchorFromPerceptionAnchorMSFTDelegate xrCreateSpatialAnchorFromPerceptionAnchorMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_perception_anchor_interop" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSpatialAnchorFromPerceptionAnchorMSFT(XrSession session, IntPtr perceptionAnchor, XrSpatialAnchorMSFT* anchor)
        => xrCreateSpatialAnchorFromPerceptionAnchorMSFT_ptr(session, perceptionAnchor, anchor);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrTryGetPerceptionAnchorFromSpatialAnchorMSFTDelegate(XrSession session, XrSpatialAnchorMSFT anchor, IntPtr perceptionAnchor);
        private  xrTryGetPerceptionAnchorFromSpatialAnchorMSFTDelegate xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_perception_anchor_interop" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrTryGetPerceptionAnchorFromSpatialAnchorMSFT(XrSession session, XrSpatialAnchorMSFT anchor, IntPtr perceptionAnchor)
        => xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_ptr(session, anchor, perceptionAnchor);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrEnumerateReprojectionModesMSFTDelegate(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint modeCapacityInput, uint* modeCountOutput, XrReprojectionModeMSFT* modes);
        private  xrEnumerateReprojectionModesMSFTDelegate xrEnumerateReprojectionModesMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_composition_layer_reprojection" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateReprojectionModesMSFT(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint modeCapacityInput, uint* modeCountOutput, XrReprojectionModeMSFT* modes)
        => xrEnumerateReprojectionModesMSFT_ptr(instance, systemId, viewConfigurationType, modeCapacityInput, modeCountOutput, modes);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrUpdateSwapchainFBDelegate(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state);
        private  xrUpdateSwapchainFBDelegate xrUpdateSwapchainFB_ptr;
    /// <summary> Requires XR extension "XR_FB_swapchain_update_state" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrUpdateSwapchainFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state)
        => xrUpdateSwapchainFB_ptr(swapchain, state);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSwapchainStateFBDelegate(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state);
        private  xrGetSwapchainStateFBDelegate xrGetSwapchainStateFB_ptr;
    /// <summary> Requires XR extension "XR_FB_swapchain_update_state" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSwapchainStateFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state)
        => xrGetSwapchainStateFB_ptr(swapchain, state);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateBodyTrackerFBDelegate(XrSession session, XrBodyTrackerCreateInfoFB* createInfo, XrBodyTrackerFB* bodyTracker);
        private  xrCreateBodyTrackerFBDelegate xrCreateBodyTrackerFB_ptr;
    /// <summary> Requires XR extension "XR_FB_body_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateBodyTrackerFB(XrSession session, XrBodyTrackerCreateInfoFB* createInfo, XrBodyTrackerFB* bodyTracker)
        => xrCreateBodyTrackerFB_ptr(session, createInfo, bodyTracker);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyBodyTrackerFBDelegate(XrBodyTrackerFB bodyTracker);
        private  xrDestroyBodyTrackerFBDelegate xrDestroyBodyTrackerFB_ptr;
    /// <summary> Requires XR extension "XR_FB_body_tracking" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyBodyTrackerFB(XrBodyTrackerFB bodyTracker)
        => xrDestroyBodyTrackerFB_ptr(bodyTracker);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrLocateBodyJointsFBDelegate(XrBodyTrackerFB bodyTracker, XrBodyJointsLocateInfoFB* locateInfo, XrBodyJointLocationsFB* locations);
        private  xrLocateBodyJointsFBDelegate xrLocateBodyJointsFB_ptr;
    /// <summary> Requires XR extension "XR_FB_body_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrLocateBodyJointsFB(XrBodyTrackerFB bodyTracker, XrBodyJointsLocateInfoFB* locateInfo, XrBodyJointLocationsFB* locations)
        => xrLocateBodyJointsFB_ptr(bodyTracker, locateInfo, locations);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetBodySkeletonFBDelegate(XrBodyTrackerFB bodyTracker, XrBodySkeletonFB* skeleton);
        private  xrGetBodySkeletonFBDelegate xrGetBodySkeletonFB_ptr;
    /// <summary> Requires XR extension "XR_FB_body_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetBodySkeletonFB(XrBodyTrackerFB bodyTracker, XrBodySkeletonFB* skeleton)
        => xrGetBodySkeletonFB_ptr(bodyTracker, skeleton);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrInitializeLoaderKHRDelegate(XrLoaderInitInfoBaseHeaderKHR* loaderInitInfo);
        private  xrInitializeLoaderKHRDelegate xrInitializeLoaderKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_loader_init" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrInitializeLoaderKHR(XrLoaderInitInfoBaseHeaderKHR* loaderInitInfo)
        => xrInitializeLoaderKHR_ptr(loaderInitInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateVulkanInstanceKHRDelegate(XrInstance instance, XrVulkanInstanceCreateInfoKHR* createInfo, IntPtr vulkanInstance, IntPtr vulkanResult);
        private  xrCreateVulkanInstanceKHRDelegate xrCreateVulkanInstanceKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_vulkan_enable2" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateVulkanInstanceKHR(XrInstance instance, XrVulkanInstanceCreateInfoKHR* createInfo, IntPtr vulkanInstance, IntPtr vulkanResult)
        => xrCreateVulkanInstanceKHR_ptr(instance, createInfo, vulkanInstance, vulkanResult);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateVulkanDeviceKHRDelegate(XrInstance instance, XrVulkanDeviceCreateInfoKHR* createInfo, IntPtr vulkanDevice, IntPtr vulkanResult);
        private  xrCreateVulkanDeviceKHRDelegate xrCreateVulkanDeviceKHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_vulkan_enable2" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateVulkanDeviceKHR(XrInstance instance, XrVulkanDeviceCreateInfoKHR* createInfo, IntPtr vulkanDevice, IntPtr vulkanResult)
        => xrCreateVulkanDeviceKHR_ptr(instance, createInfo, vulkanDevice, vulkanResult);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetVulkanGraphicsDevice2KHRDelegate(XrInstance instance, XrVulkanGraphicsDeviceGetInfoKHR* getInfo, IntPtr vulkanPhysicalDevice);
        private  xrGetVulkanGraphicsDevice2KHRDelegate xrGetVulkanGraphicsDevice2KHR_ptr;
    /// <summary> Requires XR extension "XR_KHR_vulkan_enable2" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetVulkanGraphicsDevice2KHR(XrInstance instance, XrVulkanGraphicsDeviceGetInfoKHR* getInfo, IntPtr vulkanPhysicalDevice)
        => xrGetVulkanGraphicsDevice2KHR_ptr(instance, getInfo, vulkanPhysicalDevice);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrEnumerateSceneComputeFeaturesMSFTDelegate(XrInstance instance, ulong systemId, uint featureCapacityInput, uint* featureCountOutput, XrSceneComputeFeatureMSFT* features);
        private  xrEnumerateSceneComputeFeaturesMSFTDelegate xrEnumerateSceneComputeFeaturesMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateSceneComputeFeaturesMSFT(XrInstance instance, ulong systemId, uint featureCapacityInput, uint* featureCountOutput, XrSceneComputeFeatureMSFT* features)
        => xrEnumerateSceneComputeFeaturesMSFT_ptr(instance, systemId, featureCapacityInput, featureCountOutput, features);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSceneObserverMSFTDelegate(XrSession session, XrSceneObserverCreateInfoMSFT* createInfo, XrSceneObserverMSFT* sceneObserver);
        private  xrCreateSceneObserverMSFTDelegate xrCreateSceneObserverMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSceneObserverMSFT(XrSession session, XrSceneObserverCreateInfoMSFT* createInfo, XrSceneObserverMSFT* sceneObserver)
        => xrCreateSceneObserverMSFT_ptr(session, createInfo, sceneObserver);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroySceneObserverMSFTDelegate(XrSceneObserverMSFT sceneObserver);
        private  xrDestroySceneObserverMSFTDelegate xrDestroySceneObserverMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroySceneObserverMSFT(XrSceneObserverMSFT sceneObserver)
        => xrDestroySceneObserverMSFT_ptr(sceneObserver);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSceneMSFTDelegate(XrSceneObserverMSFT sceneObserver, XrSceneCreateInfoMSFT* createInfo, XrSceneMSFT* scene);
        private  xrCreateSceneMSFTDelegate xrCreateSceneMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneCreateInfoMSFT* createInfo, XrSceneMSFT* scene)
        => xrCreateSceneMSFT_ptr(sceneObserver, createInfo, scene);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroySceneMSFTDelegate(XrSceneMSFT scene);
        private  xrDestroySceneMSFTDelegate xrDestroySceneMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroySceneMSFT(XrSceneMSFT scene)
        => xrDestroySceneMSFT_ptr(scene);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrComputeNewSceneMSFTDelegate(XrSceneObserverMSFT sceneObserver, XrNewSceneComputeInfoMSFT* computeInfo);
        private  xrComputeNewSceneMSFTDelegate xrComputeNewSceneMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrComputeNewSceneMSFT(XrSceneObserverMSFT sceneObserver, XrNewSceneComputeInfoMSFT* computeInfo)
        => xrComputeNewSceneMSFT_ptr(sceneObserver, computeInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSceneComputeStateMSFTDelegate(XrSceneObserverMSFT sceneObserver, XrSceneComputeStateMSFT* state);
        private  xrGetSceneComputeStateMSFTDelegate xrGetSceneComputeStateMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSceneComputeStateMSFT(XrSceneObserverMSFT sceneObserver, XrSceneComputeStateMSFT* state)
        => xrGetSceneComputeStateMSFT_ptr(sceneObserver, state);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSceneComponentsMSFTDelegate(XrSceneMSFT scene, XrSceneComponentsGetInfoMSFT* getInfo, XrSceneComponentsMSFT* components);
        private  xrGetSceneComponentsMSFTDelegate xrGetSceneComponentsMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsGetInfoMSFT* getInfo, XrSceneComponentsMSFT* components)
        => xrGetSceneComponentsMSFT_ptr(scene, getInfo, components);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrLocateSceneComponentsMSFTDelegate(XrSceneMSFT scene, XrSceneComponentsLocateInfoMSFT* locateInfo, XrSceneComponentLocationsMSFT* locations);
        private  xrLocateSceneComponentsMSFTDelegate xrLocateSceneComponentsMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrLocateSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsLocateInfoMSFT* locateInfo, XrSceneComponentLocationsMSFT* locations)
        => xrLocateSceneComponentsMSFT_ptr(scene, locateInfo, locations);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSceneMeshBuffersMSFTDelegate(XrSceneMSFT scene, XrSceneMeshBuffersGetInfoMSFT* getInfo, XrSceneMeshBuffersMSFT* buffers);
        private  xrGetSceneMeshBuffersMSFTDelegate xrGetSceneMeshBuffersMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSceneMeshBuffersMSFT(XrSceneMSFT scene, XrSceneMeshBuffersGetInfoMSFT* getInfo, XrSceneMeshBuffersMSFT* buffers)
        => xrGetSceneMeshBuffersMSFT_ptr(scene, getInfo, buffers);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDeserializeSceneMSFTDelegate(XrSceneObserverMSFT sceneObserver, XrSceneDeserializeInfoMSFT* deserializeInfo);
        private  xrDeserializeSceneMSFTDelegate xrDeserializeSceneMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding_serialization" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDeserializeSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneDeserializeInfoMSFT* deserializeInfo)
        => xrDeserializeSceneMSFT_ptr(sceneObserver, deserializeInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSerializedSceneFragmentDataMSFTDelegate(XrSceneMSFT scene, XrSerializedSceneFragmentDataGetInfoMSFT* getInfo, uint countInput, uint* readOutput, byte* buffer);
        private  xrGetSerializedSceneFragmentDataMSFTDelegate xrGetSerializedSceneFragmentDataMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_scene_understanding_serialization" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSerializedSceneFragmentDataMSFT(XrSceneMSFT scene, XrSerializedSceneFragmentDataGetInfoMSFT* getInfo, uint countInput, uint* readOutput, byte* buffer)
        => xrGetSerializedSceneFragmentDataMSFT_ptr(scene, getInfo, countInput, readOutput, buffer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrEnumerateDisplayRefreshRatesFBDelegate(XrSession session, uint displayRefreshRateCapacityInput, uint* displayRefreshRateCountOutput, float* displayRefreshRates);
        private  xrEnumerateDisplayRefreshRatesFBDelegate xrEnumerateDisplayRefreshRatesFB_ptr;
    /// <summary> Requires XR extension "XR_FB_display_refresh_rate" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateDisplayRefreshRatesFB(XrSession session, uint displayRefreshRateCapacityInput, uint* displayRefreshRateCountOutput, float* displayRefreshRates)
        => xrEnumerateDisplayRefreshRatesFB_ptr(session, displayRefreshRateCapacityInput, displayRefreshRateCountOutput, displayRefreshRates);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetDisplayRefreshRateFBDelegate(XrSession session, float* displayRefreshRate);
        private  xrGetDisplayRefreshRateFBDelegate xrGetDisplayRefreshRateFB_ptr;
    /// <summary> Requires XR extension "XR_FB_display_refresh_rate" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetDisplayRefreshRateFB(XrSession session, float* displayRefreshRate)
        => xrGetDisplayRefreshRateFB_ptr(session, displayRefreshRate);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrRequestDisplayRefreshRateFBDelegate(XrSession session, float displayRefreshRate);
        private  xrRequestDisplayRefreshRateFBDelegate xrRequestDisplayRefreshRateFB_ptr;
    /// <summary> Requires XR extension "XR_FB_display_refresh_rate" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrRequestDisplayRefreshRateFB(XrSession session, float displayRefreshRate)
        => xrRequestDisplayRefreshRateFB_ptr(session, displayRefreshRate);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrEnumerateViveTrackerPathsHTCXDelegate(XrInstance instance, uint pathCapacityInput, uint* pathCountOutput, XrViveTrackerPathsHTCX* paths);
        private  xrEnumerateViveTrackerPathsHTCXDelegate xrEnumerateViveTrackerPathsHTCX_ptr;
    /// <summary> Requires XR extension "XR_HTCX_vive_tracker_interaction" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateViveTrackerPathsHTCX(XrInstance instance, uint pathCapacityInput, uint* pathCountOutput, XrViveTrackerPathsHTCX* paths)
        => xrEnumerateViveTrackerPathsHTCX_ptr(instance, pathCapacityInput, pathCountOutput, paths);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateFacialTrackerHTCDelegate(XrSession session, XrFacialTrackerCreateInfoHTC* createInfo, XrFacialTrackerHTC* facialTracker);
        private  xrCreateFacialTrackerHTCDelegate xrCreateFacialTrackerHTC_ptr;
    /// <summary> Requires XR extension "XR_HTC_facial_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateFacialTrackerHTC(XrSession session, XrFacialTrackerCreateInfoHTC* createInfo, XrFacialTrackerHTC* facialTracker)
        => xrCreateFacialTrackerHTC_ptr(session, createInfo, facialTracker);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyFacialTrackerHTCDelegate(XrFacialTrackerHTC facialTracker);
        private  xrDestroyFacialTrackerHTCDelegate xrDestroyFacialTrackerHTC_ptr;
    /// <summary> Requires XR extension "XR_HTC_facial_tracking" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyFacialTrackerHTC(XrFacialTrackerHTC facialTracker)
        => xrDestroyFacialTrackerHTC_ptr(facialTracker);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetFacialExpressionsHTCDelegate(XrFacialTrackerHTC facialTracker, XrFacialExpressionsHTC* facialExpressions);
        private  xrGetFacialExpressionsHTCDelegate xrGetFacialExpressionsHTC_ptr;
    /// <summary> Requires XR extension "XR_HTC_facial_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetFacialExpressionsHTC(XrFacialTrackerHTC facialTracker, XrFacialExpressionsHTC* facialExpressions)
        => xrGetFacialExpressionsHTC_ptr(facialTracker, facialExpressions);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrEnumerateColorSpacesFBDelegate(XrSession session, uint colorSpaceCapacityInput, uint* colorSpaceCountOutput, XrColorSpaceFB* colorSpaces);
        private  xrEnumerateColorSpacesFBDelegate xrEnumerateColorSpacesFB_ptr;
    /// <summary> Requires XR extension "XR_FB_color_space" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateColorSpacesFB(XrSession session, uint colorSpaceCapacityInput, uint* colorSpaceCountOutput, XrColorSpaceFB* colorSpaces)
        => xrEnumerateColorSpacesFB_ptr(session, colorSpaceCapacityInput, colorSpaceCountOutput, colorSpaces);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetColorSpaceFBDelegate(XrSession session, XrColorSpaceFB colorSpace);
        private  xrSetColorSpaceFBDelegate xrSetColorSpaceFB_ptr;
    /// <summary> Requires XR extension "XR_FB_color_space" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetColorSpaceFB(XrSession session, XrColorSpaceFB colorSpace)
        => xrSetColorSpaceFB_ptr(session, colorSpace);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetHandMeshFBDelegate(XrHandTrackerEXT handTracker, XrHandTrackingMeshFB* mesh);
        private  xrGetHandMeshFBDelegate xrGetHandMeshFB_ptr;
    /// <summary> Requires XR extension "XR_FB_hand_tracking_mesh" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetHandMeshFB(XrHandTrackerEXT handTracker, XrHandTrackingMeshFB* mesh)
        => xrGetHandMeshFB_ptr(handTracker, mesh);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSpatialAnchorFBDelegate(XrSession session, XrSpatialAnchorCreateInfoFB* info, ulong* requestId);
        private  xrCreateSpatialAnchorFBDelegate xrCreateSpatialAnchorFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSpatialAnchorFB(XrSession session, XrSpatialAnchorCreateInfoFB* info, ulong* requestId)
        => xrCreateSpatialAnchorFB_ptr(session, info, requestId);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSpaceUuidFBDelegate(XrSpace space, XrUuidEXT* uuid);
        private  xrGetSpaceUuidFBDelegate xrGetSpaceUuidFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSpaceUuidFB(XrSpace space, XrUuidEXT* uuid)
        => xrGetSpaceUuidFB_ptr(space, uuid);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrEnumerateSpaceSupportedComponentsFBDelegate(XrSpace space, uint componentTypeCapacityInput, uint* componentTypeCountOutput, XrSpaceComponentTypeFB* componentTypes);
        private  xrEnumerateSpaceSupportedComponentsFBDelegate xrEnumerateSpaceSupportedComponentsFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateSpaceSupportedComponentsFB(XrSpace space, uint componentTypeCapacityInput, uint* componentTypeCountOutput, XrSpaceComponentTypeFB* componentTypes)
        => xrEnumerateSpaceSupportedComponentsFB_ptr(space, componentTypeCapacityInput, componentTypeCountOutput, componentTypes);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetSpaceComponentStatusFBDelegate(XrSpace space, XrSpaceComponentStatusSetInfoFB* info, ulong* requestId);
        private  xrSetSpaceComponentStatusFBDelegate xrSetSpaceComponentStatusFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentStatusSetInfoFB* info, ulong* requestId)
        => xrSetSpaceComponentStatusFB_ptr(space, info, requestId);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSpaceComponentStatusFBDelegate(XrSpace space, XrSpaceComponentTypeFB componentType, XrSpaceComponentStatusFB* status);
        private  xrGetSpaceComponentStatusFBDelegate xrGetSpaceComponentStatusFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentTypeFB componentType, XrSpaceComponentStatusFB* status)
        => xrGetSpaceComponentStatusFB_ptr(space, componentType, status);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateFoveationProfileFBDelegate(XrSession session, XrFoveationProfileCreateInfoFB* createInfo, XrFoveationProfileFB* profile);
        private  xrCreateFoveationProfileFBDelegate xrCreateFoveationProfileFB_ptr;
    /// <summary> Requires XR extension "XR_FB_foveation" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateFoveationProfileFB(XrSession session, XrFoveationProfileCreateInfoFB* createInfo, XrFoveationProfileFB* profile)
        => xrCreateFoveationProfileFB_ptr(session, createInfo, profile);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyFoveationProfileFBDelegate(XrFoveationProfileFB profile);
        private  xrDestroyFoveationProfileFBDelegate xrDestroyFoveationProfileFB_ptr;
    /// <summary> Requires XR extension "XR_FB_foveation" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyFoveationProfileFB(XrFoveationProfileFB profile)
        => xrDestroyFoveationProfileFB_ptr(profile);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrQuerySystemTrackedKeyboardFBDelegate(XrSession session, XrKeyboardTrackingQueryFB* queryInfo, XrKeyboardTrackingDescriptionFB* keyboard);
        private  xrQuerySystemTrackedKeyboardFBDelegate xrQuerySystemTrackedKeyboardFB_ptr;
    /// <summary> Requires XR extension "XR_FB_keyboard_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrQuerySystemTrackedKeyboardFB(XrSession session, XrKeyboardTrackingQueryFB* queryInfo, XrKeyboardTrackingDescriptionFB* keyboard)
        => xrQuerySystemTrackedKeyboardFB_ptr(session, queryInfo, keyboard);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateKeyboardSpaceFBDelegate(XrSession session, XrKeyboardSpaceCreateInfoFB* createInfo, XrSpace* keyboardSpace);
        private  xrCreateKeyboardSpaceFBDelegate xrCreateKeyboardSpaceFB_ptr;
    /// <summary> Requires XR extension "XR_FB_keyboard_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateKeyboardSpaceFB(XrSession session, XrKeyboardSpaceCreateInfoFB* createInfo, XrSpace* keyboardSpace)
        => xrCreateKeyboardSpaceFB_ptr(session, createInfo, keyboardSpace);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateTriangleMeshFBDelegate(XrSession session, XrTriangleMeshCreateInfoFB* createInfo, XrTriangleMeshFB* outTriangleMesh);
        private  xrCreateTriangleMeshFBDelegate xrCreateTriangleMeshFB_ptr;
    /// <summary> Requires XR extension "XR_FB_triangle_mesh" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateTriangleMeshFB(XrSession session, XrTriangleMeshCreateInfoFB* createInfo, XrTriangleMeshFB* outTriangleMesh)
        => xrCreateTriangleMeshFB_ptr(session, createInfo, outTriangleMesh);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyTriangleMeshFBDelegate(XrTriangleMeshFB mesh);
        private  xrDestroyTriangleMeshFBDelegate xrDestroyTriangleMeshFB_ptr;
    /// <summary> Requires XR extension "XR_FB_triangle_mesh" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyTriangleMeshFB(XrTriangleMeshFB mesh)
        => xrDestroyTriangleMeshFB_ptr(mesh);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrTriangleMeshGetVertexBufferFBDelegate(XrTriangleMeshFB mesh, XrVector3f** outVertexBuffer);
        private  xrTriangleMeshGetVertexBufferFBDelegate xrTriangleMeshGetVertexBufferFB_ptr;
    /// <summary> Requires XR extension "XR_FB_triangle_mesh" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrTriangleMeshGetVertexBufferFB(XrTriangleMeshFB mesh, XrVector3f** outVertexBuffer)
        => xrTriangleMeshGetVertexBufferFB_ptr(mesh, outVertexBuffer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrTriangleMeshGetIndexBufferFBDelegate(XrTriangleMeshFB mesh, uint** outIndexBuffer);
        private  xrTriangleMeshGetIndexBufferFBDelegate xrTriangleMeshGetIndexBufferFB_ptr;
    /// <summary> Requires XR extension "XR_FB_triangle_mesh" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrTriangleMeshGetIndexBufferFB(XrTriangleMeshFB mesh, uint** outIndexBuffer)
        => xrTriangleMeshGetIndexBufferFB_ptr(mesh, outIndexBuffer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrTriangleMeshBeginUpdateFBDelegate(XrTriangleMeshFB mesh);
        private  xrTriangleMeshBeginUpdateFBDelegate xrTriangleMeshBeginUpdateFB_ptr;
    /// <summary> Requires XR extension "XR_FB_triangle_mesh" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrTriangleMeshBeginUpdateFB(XrTriangleMeshFB mesh)
        => xrTriangleMeshBeginUpdateFB_ptr(mesh);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrTriangleMeshEndUpdateFBDelegate(XrTriangleMeshFB mesh, uint vertexCount, uint triangleCount);
        private  xrTriangleMeshEndUpdateFBDelegate xrTriangleMeshEndUpdateFB_ptr;
    /// <summary> Requires XR extension "XR_FB_triangle_mesh" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrTriangleMeshEndUpdateFB(XrTriangleMeshFB mesh, uint vertexCount, uint triangleCount)
        => xrTriangleMeshEndUpdateFB_ptr(mesh, vertexCount, triangleCount);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrTriangleMeshBeginVertexBufferUpdateFBDelegate(XrTriangleMeshFB mesh, uint* outVertexCount);
        private  xrTriangleMeshBeginVertexBufferUpdateFBDelegate xrTriangleMeshBeginVertexBufferUpdateFB_ptr;
    /// <summary> Requires XR extension "XR_FB_triangle_mesh" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrTriangleMeshBeginVertexBufferUpdateFB(XrTriangleMeshFB mesh, uint* outVertexCount)
        => xrTriangleMeshBeginVertexBufferUpdateFB_ptr(mesh, outVertexCount);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrTriangleMeshEndVertexBufferUpdateFBDelegate(XrTriangleMeshFB mesh);
        private  xrTriangleMeshEndVertexBufferUpdateFBDelegate xrTriangleMeshEndVertexBufferUpdateFB_ptr;
    /// <summary> Requires XR extension "XR_FB_triangle_mesh" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrTriangleMeshEndVertexBufferUpdateFB(XrTriangleMeshFB mesh)
        => xrTriangleMeshEndVertexBufferUpdateFB_ptr(mesh);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreatePassthroughFBDelegate(XrSession session, XrPassthroughCreateInfoFB* createInfo, XrPassthroughFB* outPassthrough);
        private  xrCreatePassthroughFBDelegate xrCreatePassthroughFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreatePassthroughFB(XrSession session, XrPassthroughCreateInfoFB* createInfo, XrPassthroughFB* outPassthrough)
        => xrCreatePassthroughFB_ptr(session, createInfo, outPassthrough);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyPassthroughFBDelegate(XrPassthroughFB passthrough);
        private  xrDestroyPassthroughFBDelegate xrDestroyPassthroughFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyPassthroughFB(XrPassthroughFB passthrough)
        => xrDestroyPassthroughFB_ptr(passthrough);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrPassthroughStartFBDelegate(XrPassthroughFB passthrough);
        private  xrPassthroughStartFBDelegate xrPassthroughStartFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrPassthroughStartFB(XrPassthroughFB passthrough)
        => xrPassthroughStartFB_ptr(passthrough);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrPassthroughPauseFBDelegate(XrPassthroughFB passthrough);
        private  xrPassthroughPauseFBDelegate xrPassthroughPauseFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrPassthroughPauseFB(XrPassthroughFB passthrough)
        => xrPassthroughPauseFB_ptr(passthrough);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreatePassthroughLayerFBDelegate(XrSession session, XrPassthroughLayerCreateInfoFB* createInfo, XrPassthroughLayerFB* outLayer);
        private  xrCreatePassthroughLayerFBDelegate xrCreatePassthroughLayerFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreatePassthroughLayerFB(XrSession session, XrPassthroughLayerCreateInfoFB* createInfo, XrPassthroughLayerFB* outLayer)
        => xrCreatePassthroughLayerFB_ptr(session, createInfo, outLayer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyPassthroughLayerFBDelegate(XrPassthroughLayerFB layer);
        private  xrDestroyPassthroughLayerFBDelegate xrDestroyPassthroughLayerFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyPassthroughLayerFB(XrPassthroughLayerFB layer)
        => xrDestroyPassthroughLayerFB_ptr(layer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrPassthroughLayerPauseFBDelegate(XrPassthroughLayerFB layer);
        private  xrPassthroughLayerPauseFBDelegate xrPassthroughLayerPauseFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrPassthroughLayerPauseFB(XrPassthroughLayerFB layer)
        => xrPassthroughLayerPauseFB_ptr(layer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrPassthroughLayerResumeFBDelegate(XrPassthroughLayerFB layer);
        private  xrPassthroughLayerResumeFBDelegate xrPassthroughLayerResumeFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrPassthroughLayerResumeFB(XrPassthroughLayerFB layer)
        => xrPassthroughLayerResumeFB_ptr(layer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrPassthroughLayerSetStyleFBDelegate(XrPassthroughLayerFB layer, XrPassthroughStyleFB* style);
        private  xrPassthroughLayerSetStyleFBDelegate xrPassthroughLayerSetStyleFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrPassthroughLayerSetStyleFB(XrPassthroughLayerFB layer, XrPassthroughStyleFB* style)
        => xrPassthroughLayerSetStyleFB_ptr(layer, style);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateGeometryInstanceFBDelegate(XrSession session, XrGeometryInstanceCreateInfoFB* createInfo, XrGeometryInstanceFB* outGeometryInstance);
        private  xrCreateGeometryInstanceFBDelegate xrCreateGeometryInstanceFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateGeometryInstanceFB(XrSession session, XrGeometryInstanceCreateInfoFB* createInfo, XrGeometryInstanceFB* outGeometryInstance)
        => xrCreateGeometryInstanceFB_ptr(session, createInfo, outGeometryInstance);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyGeometryInstanceFBDelegate(XrGeometryInstanceFB instance);
        private  xrDestroyGeometryInstanceFBDelegate xrDestroyGeometryInstanceFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyGeometryInstanceFB(XrGeometryInstanceFB instance)
        => xrDestroyGeometryInstanceFB_ptr(instance);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGeometryInstanceSetTransformFBDelegate(XrGeometryInstanceFB instance, XrGeometryInstanceTransformFB* transformation);
        private  xrGeometryInstanceSetTransformFBDelegate xrGeometryInstanceSetTransformFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGeometryInstanceSetTransformFB(XrGeometryInstanceFB instance, XrGeometryInstanceTransformFB* transformation)
        => xrGeometryInstanceSetTransformFB_ptr(instance, transformation);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrEnumerateRenderModelPathsFBDelegate(XrSession session, uint pathCapacityInput, uint* pathCountOutput, XrRenderModelPathInfoFB* paths);
        private  xrEnumerateRenderModelPathsFBDelegate xrEnumerateRenderModelPathsFB_ptr;
    /// <summary> Requires XR extension "XR_FB_render_model" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateRenderModelPathsFB(XrSession session, uint pathCapacityInput, uint* pathCountOutput, XrRenderModelPathInfoFB* paths)
        => xrEnumerateRenderModelPathsFB_ptr(session, pathCapacityInput, pathCountOutput, paths);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetRenderModelPropertiesFBDelegate(XrSession session, ulong path, XrRenderModelPropertiesFB* properties);
        private  xrGetRenderModelPropertiesFBDelegate xrGetRenderModelPropertiesFB_ptr;
    /// <summary> Requires XR extension "XR_FB_render_model" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetRenderModelPropertiesFB(XrSession session, ulong path, XrRenderModelPropertiesFB* properties)
        => xrGetRenderModelPropertiesFB_ptr(session, path, properties);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrLoadRenderModelFBDelegate(XrSession session, XrRenderModelLoadInfoFB* info, XrRenderModelBufferFB* buffer);
        private  xrLoadRenderModelFBDelegate xrLoadRenderModelFB_ptr;
    /// <summary> Requires XR extension "XR_FB_render_model" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrLoadRenderModelFB(XrSession session, XrRenderModelLoadInfoFB* info, XrRenderModelBufferFB* buffer)
        => xrLoadRenderModelFB_ptr(session, info, buffer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetEnvironmentDepthEstimationVARJODelegate(XrSession session, XrBool32 enabled);
        private  xrSetEnvironmentDepthEstimationVARJODelegate xrSetEnvironmentDepthEstimationVARJO_ptr;
    /// <summary> Requires XR extension "XR_VARJO_environment_depth_estimation" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetEnvironmentDepthEstimationVARJO(XrSession session, XrBool32 enabled)
        => xrSetEnvironmentDepthEstimationVARJO_ptr(session, enabled);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetMarkerTrackingVARJODelegate(XrSession session, XrBool32 enabled);
        private  xrSetMarkerTrackingVARJODelegate xrSetMarkerTrackingVARJO_ptr;
    /// <summary> Requires XR extension "XR_VARJO_marker_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetMarkerTrackingVARJO(XrSession session, XrBool32 enabled)
        => xrSetMarkerTrackingVARJO_ptr(session, enabled);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetMarkerTrackingTimeoutVARJODelegate(XrSession session, ulong markerId, long timeout);
        private  xrSetMarkerTrackingTimeoutVARJODelegate xrSetMarkerTrackingTimeoutVARJO_ptr;
    /// <summary> Requires XR extension "XR_VARJO_marker_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetMarkerTrackingTimeoutVARJO(XrSession session, ulong markerId, long timeout)
        => xrSetMarkerTrackingTimeoutVARJO_ptr(session, markerId, timeout);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetMarkerTrackingPredictionVARJODelegate(XrSession session, ulong markerId, XrBool32 enable);
        private  xrSetMarkerTrackingPredictionVARJODelegate xrSetMarkerTrackingPredictionVARJO_ptr;
    /// <summary> Requires XR extension "XR_VARJO_marker_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetMarkerTrackingPredictionVARJO(XrSession session, ulong markerId, XrBool32 enable)
        => xrSetMarkerTrackingPredictionVARJO_ptr(session, markerId, enable);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetMarkerSizeVARJODelegate(XrSession session, ulong markerId, XrExtent2Df* size);
        private  xrGetMarkerSizeVARJODelegate xrGetMarkerSizeVARJO_ptr;
    /// <summary> Requires XR extension "XR_VARJO_marker_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetMarkerSizeVARJO(XrSession session, ulong markerId, XrExtent2Df* size)
        => xrGetMarkerSizeVARJO_ptr(session, markerId, size);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateMarkerSpaceVARJODelegate(XrSession session, XrMarkerSpaceCreateInfoVARJO* createInfo, XrSpace* space);
        private  xrCreateMarkerSpaceVARJODelegate xrCreateMarkerSpaceVARJO_ptr;
    /// <summary> Requires XR extension "XR_VARJO_marker_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateMarkerSpaceVARJO(XrSession session, XrMarkerSpaceCreateInfoVARJO* createInfo, XrSpace* space)
        => xrCreateMarkerSpaceVARJO_ptr(session, createInfo, space);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetViewOffsetVARJODelegate(XrSession session, float offset);
        private  xrSetViewOffsetVARJODelegate xrSetViewOffsetVARJO_ptr;
    /// <summary> Requires XR extension "XR_VARJO_view_offset" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetViewOffsetVARJO(XrSession session, float offset)
        => xrSetViewOffsetVARJO_ptr(session, offset);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSpaceFromCoordinateFrameUIDMLDelegate(XrSession session, XrCoordinateSpaceCreateInfoML createInfo, XrSpace* space);
        private  xrCreateSpaceFromCoordinateFrameUIDMLDelegate xrCreateSpaceFromCoordinateFrameUIDML_ptr;
    /// <summary> Requires XR extension "XR_ML_compat" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSpaceFromCoordinateFrameUIDML(XrSession session, XrCoordinateSpaceCreateInfoML createInfo, XrSpace* space)
        => xrCreateSpaceFromCoordinateFrameUIDML_ptr(session, createInfo, space);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSpatialAnchorStoreConnectionMSFTDelegate(XrSession session, XrSpatialAnchorStoreConnectionMSFT* spatialAnchorStore);
        private  xrCreateSpatialAnchorStoreConnectionMSFTDelegate xrCreateSpatialAnchorStoreConnectionMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_anchor_persistence" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSpatialAnchorStoreConnectionMSFT(XrSession session, XrSpatialAnchorStoreConnectionMSFT* spatialAnchorStore)
        => xrCreateSpatialAnchorStoreConnectionMSFT_ptr(session, spatialAnchorStore);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroySpatialAnchorStoreConnectionMSFTDelegate(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore);
        private  xrDestroySpatialAnchorStoreConnectionMSFTDelegate xrDestroySpatialAnchorStoreConnectionMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_anchor_persistence" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_OUT_OF_MEMORY"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroySpatialAnchorStoreConnectionMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore)
        => xrDestroySpatialAnchorStoreConnectionMSFT_ptr(spatialAnchorStore);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrPersistSpatialAnchorMSFTDelegate(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceInfoMSFT* spatialAnchorPersistenceInfo);
        private  xrPersistSpatialAnchorMSFTDelegate xrPersistSpatialAnchorMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_anchor_persistence" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrPersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceInfoMSFT* spatialAnchorPersistenceInfo)
        => xrPersistSpatialAnchorMSFT_ptr(spatialAnchorStore, spatialAnchorPersistenceInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrEnumeratePersistedSpatialAnchorNamesMSFTDelegate(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, uint spatialAnchorNamesCapacityInput, uint* spatialAnchorNamesCountOutput, XrSpatialAnchorPersistenceNameMSFT* persistedAnchorNames);
        private  xrEnumeratePersistedSpatialAnchorNamesMSFTDelegate xrEnumeratePersistedSpatialAnchorNamesMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_anchor_persistence" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumeratePersistedSpatialAnchorNamesMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, uint spatialAnchorNamesCapacityInput, uint* spatialAnchorNamesCountOutput, XrSpatialAnchorPersistenceNameMSFT* persistedAnchorNames)
        => xrEnumeratePersistedSpatialAnchorNamesMSFT_ptr(spatialAnchorStore, spatialAnchorNamesCapacityInput, spatialAnchorNamesCountOutput, persistedAnchorNames);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSpatialAnchorFromPersistedNameMSFTDelegate(XrSession session, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, XrSpatialAnchorMSFT* spatialAnchor);
        private  xrCreateSpatialAnchorFromPersistedNameMSFTDelegate xrCreateSpatialAnchorFromPersistedNameMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_anchor_persistence" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSpatialAnchorFromPersistedNameMSFT(XrSession session, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, XrSpatialAnchorMSFT* spatialAnchor)
        => xrCreateSpatialAnchorFromPersistedNameMSFT_ptr(session, spatialAnchorCreateInfo, spatialAnchor);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrUnpersistSpatialAnchorMSFTDelegate(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorPersistenceName);
        private  xrUnpersistSpatialAnchorMSFTDelegate xrUnpersistSpatialAnchorMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_anchor_persistence" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrUnpersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorPersistenceName)
        => xrUnpersistSpatialAnchorMSFT_ptr(spatialAnchorStore, spatialAnchorPersistenceName);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrClearSpatialAnchorStoreMSFTDelegate(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore);
        private  xrClearSpatialAnchorStoreMSFTDelegate xrClearSpatialAnchorStoreMSFT_ptr;
    /// <summary> Requires XR extension "XR_MSFT_spatial_anchor_persistence" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrClearSpatialAnchorStoreMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore)
        => xrClearSpatialAnchorStoreMSFT_ptr(spatialAnchorStore);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrQuerySpacesFBDelegate(XrSession session, XrSpaceQueryInfoBaseHeaderFB* info, ulong* requestId);
        private  xrQuerySpacesFBDelegate xrQuerySpacesFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity_query" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrQuerySpacesFB(XrSession session, XrSpaceQueryInfoBaseHeaderFB* info, ulong* requestId)
        => xrQuerySpacesFB_ptr(session, info, requestId);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrRetrieveSpaceQueryResultsFBDelegate(XrSession session, ulong requestId, XrSpaceQueryResultsFB* results);
        private  xrRetrieveSpaceQueryResultsFBDelegate xrRetrieveSpaceQueryResultsFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity_query" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrRetrieveSpaceQueryResultsFB(XrSession session, ulong requestId, XrSpaceQueryResultsFB* results)
        => xrRetrieveSpaceQueryResultsFB_ptr(session, requestId, results);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSaveSpaceFBDelegate(XrSession session, XrSpaceSaveInfoFB* info, ulong* requestId);
        private  xrSaveSpaceFBDelegate xrSaveSpaceFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity_storage" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSaveSpaceFB(XrSession session, XrSpaceSaveInfoFB* info, ulong* requestId)
        => xrSaveSpaceFB_ptr(session, info, requestId);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrEraseSpaceFBDelegate(XrSession session, XrSpaceEraseInfoFB* info, ulong* requestId);
        private  xrEraseSpaceFBDelegate xrEraseSpaceFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity_storage" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEraseSpaceFB(XrSession session, XrSpaceEraseInfoFB* info, ulong* requestId)
        => xrEraseSpaceFB_ptr(session, info, requestId);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetAudioOutputDeviceGuidOculusDelegate(XrInstance instance, string buffer);
        private  xrGetAudioOutputDeviceGuidOculusDelegate xrGetAudioOutputDeviceGuidOculus_ptr;
    /// <summary> Requires XR extension "XR_OCULUS_audio_device_guid" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetAudioOutputDeviceGuidOculus(XrInstance instance, string buffer)
        => xrGetAudioOutputDeviceGuidOculus_ptr(instance, buffer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetAudioInputDeviceGuidOculusDelegate(XrInstance instance, string buffer);
        private  xrGetAudioInputDeviceGuidOculusDelegate xrGetAudioInputDeviceGuidOculus_ptr;
    /// <summary> Requires XR extension "XR_OCULUS_audio_device_guid" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetAudioInputDeviceGuidOculus(XrInstance instance, string buffer)
        => xrGetAudioInputDeviceGuidOculus_ptr(instance, buffer);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrShareSpacesFBDelegate(XrSession session, XrSpaceShareInfoFB* info, ulong* requestId);
        private  xrShareSpacesFBDelegate xrShareSpacesFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity_sharing" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrShareSpacesFB(XrSession session, XrSpaceShareInfoFB* info, ulong* requestId)
        => xrShareSpacesFB_ptr(session, info, requestId);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSpaceBoundingBox2DFBDelegate(XrSession session, XrSpace space, XrRect2Df* boundingBox2DOutput);
        private  xrGetSpaceBoundingBox2DFBDelegate xrGetSpaceBoundingBox2DFB_ptr;
    /// <summary> Requires XR extension "XR_FB_scene" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSpaceBoundingBox2DFB(XrSession session, XrSpace space, XrRect2Df* boundingBox2DOutput)
        => xrGetSpaceBoundingBox2DFB_ptr(session, space, boundingBox2DOutput);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSpaceBoundingBox3DFBDelegate(XrSession session, XrSpace space, XrRect3DfFB* boundingBox3DOutput);
        private  xrGetSpaceBoundingBox3DFBDelegate xrGetSpaceBoundingBox3DFB_ptr;
    /// <summary> Requires XR extension "XR_FB_scene" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSpaceBoundingBox3DFB(XrSession session, XrSpace space, XrRect3DfFB* boundingBox3DOutput)
        => xrGetSpaceBoundingBox3DFB_ptr(session, space, boundingBox3DOutput);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSpaceSemanticLabelsFBDelegate(XrSession session, XrSpace space, XrSemanticLabelsFB* semanticLabelsOutput);
        private  xrGetSpaceSemanticLabelsFBDelegate xrGetSpaceSemanticLabelsFB_ptr;
    /// <summary> Requires XR extension "XR_FB_scene" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSpaceSemanticLabelsFB(XrSession session, XrSpace space, XrSemanticLabelsFB* semanticLabelsOutput)
        => xrGetSpaceSemanticLabelsFB_ptr(session, space, semanticLabelsOutput);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSpaceBoundary2DFBDelegate(XrSession session, XrSpace space, XrBoundary2DFB* boundary2DOutput);
        private  xrGetSpaceBoundary2DFBDelegate xrGetSpaceBoundary2DFB_ptr;
    /// <summary> Requires XR extension "XR_FB_scene" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSpaceBoundary2DFB(XrSession session, XrSpace space, XrBoundary2DFB* boundary2DOutput)
        => xrGetSpaceBoundary2DFB_ptr(session, space, boundary2DOutput);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSpaceRoomLayoutFBDelegate(XrSession session, XrSpace space, XrRoomLayoutFB* roomLayoutOutput);
        private  xrGetSpaceRoomLayoutFBDelegate xrGetSpaceRoomLayoutFB_ptr;
    /// <summary> Requires XR extension "XR_FB_scene" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSpaceRoomLayoutFB(XrSession session, XrSpace space, XrRoomLayoutFB* roomLayoutOutput)
        => xrGetSpaceRoomLayoutFB_ptr(session, space, roomLayoutOutput);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetDigitalLensControlALMALENCEDelegate(XrSession session, XrDigitalLensControlALMALENCE* digitalLensControl);
        private  xrSetDigitalLensControlALMALENCEDelegate xrSetDigitalLensControlALMALENCE_ptr;
    /// <summary> Requires XR extension "XR_ALMALENCE_digital_lens_control" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetDigitalLensControlALMALENCE(XrSession session, XrDigitalLensControlALMALENCE* digitalLensControl)
        => xrSetDigitalLensControlALMALENCE_ptr(session, digitalLensControl);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrRequestSceneCaptureFBDelegate(XrSession session, XrSceneCaptureRequestInfoFB* info, ulong* requestId);
        private  xrRequestSceneCaptureFBDelegate xrRequestSceneCaptureFB_ptr;
    /// <summary> Requires XR extension "XR_FB_scene_capture" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrRequestSceneCaptureFB(XrSession session, XrSceneCaptureRequestInfoFB* info, ulong* requestId)
        => xrRequestSceneCaptureFB_ptr(session, info, requestId);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSpaceContainerFBDelegate(XrSession session, XrSpace space, XrSpaceContainerFB* spaceContainerOutput);
        private  xrGetSpaceContainerFBDelegate xrGetSpaceContainerFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity_container" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSpaceContainerFB(XrSession session, XrSpace space, XrSpaceContainerFB* spaceContainerOutput)
        => xrGetSpaceContainerFB_ptr(session, space, spaceContainerOutput);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetFoveationEyeTrackedStateMETADelegate(XrSession session, XrFoveationEyeTrackedStateMETA* foveationState);
        private  xrGetFoveationEyeTrackedStateMETADelegate xrGetFoveationEyeTrackedStateMETA_ptr;
    /// <summary> Requires XR extension "XR_META_foveation_eye_tracked" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetFoveationEyeTrackedStateMETA(XrSession session, XrFoveationEyeTrackedStateMETA* foveationState)
        => xrGetFoveationEyeTrackedStateMETA_ptr(session, foveationState);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateFaceTrackerFBDelegate(XrSession session, XrFaceTrackerCreateInfoFB* createInfo, XrFaceTrackerFB* faceTracker);
        private  xrCreateFaceTrackerFBDelegate xrCreateFaceTrackerFB_ptr;
    /// <summary> Requires XR extension "XR_FB_face_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateFaceTrackerFB(XrSession session, XrFaceTrackerCreateInfoFB* createInfo, XrFaceTrackerFB* faceTracker)
        => xrCreateFaceTrackerFB_ptr(session, createInfo, faceTracker);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyFaceTrackerFBDelegate(XrFaceTrackerFB faceTracker);
        private  xrDestroyFaceTrackerFBDelegate xrDestroyFaceTrackerFB_ptr;
    /// <summary> Requires XR extension "XR_FB_face_tracking" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyFaceTrackerFB(XrFaceTrackerFB faceTracker)
        => xrDestroyFaceTrackerFB_ptr(faceTracker);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetFaceExpressionWeightsFBDelegate(XrFaceTrackerFB faceTracker, XrFaceExpressionInfoFB* expressionInfo, XrFaceExpressionWeightsFB* expressionWeights);
        private  xrGetFaceExpressionWeightsFBDelegate xrGetFaceExpressionWeightsFB_ptr;
    /// <summary> Requires XR extension "XR_FB_face_tracking" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetFaceExpressionWeightsFB(XrFaceTrackerFB faceTracker, XrFaceExpressionInfoFB* expressionInfo, XrFaceExpressionWeightsFB* expressionWeights)
        => xrGetFaceExpressionWeightsFB_ptr(faceTracker, expressionInfo, expressionWeights);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateEyeTrackerFBDelegate(XrSession session, XrEyeTrackerCreateInfoFB* createInfo, XrEyeTrackerFB* eyeTracker);
        private  xrCreateEyeTrackerFBDelegate xrCreateEyeTrackerFB_ptr;
    /// <summary> Requires XR extension "XR_FB_eye_tracking_social" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateEyeTrackerFB(XrSession session, XrEyeTrackerCreateInfoFB* createInfo, XrEyeTrackerFB* eyeTracker)
        => xrCreateEyeTrackerFB_ptr(session, createInfo, eyeTracker);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyEyeTrackerFBDelegate(XrEyeTrackerFB eyeTracker);
        private  xrDestroyEyeTrackerFBDelegate xrDestroyEyeTrackerFB_ptr;
    /// <summary> Requires XR extension "XR_FB_eye_tracking_social" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyEyeTrackerFB(XrEyeTrackerFB eyeTracker)
        => xrDestroyEyeTrackerFB_ptr(eyeTracker);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetEyeGazesFBDelegate(XrEyeTrackerFB eyeTracker, XrEyeGazesInfoFB* gazeInfo, XrEyeGazesFB* eyeGazes);
        private  xrGetEyeGazesFBDelegate xrGetEyeGazesFB_ptr;
    /// <summary> Requires XR extension "XR_FB_eye_tracking_social" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetEyeGazesFB(XrEyeTrackerFB eyeTracker, XrEyeGazesInfoFB* gazeInfo, XrEyeGazesFB* eyeGazes)
        => xrGetEyeGazesFB_ptr(eyeTracker, gazeInfo, eyeGazes);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrPassthroughLayerSetKeyboardHandsIntensityFBDelegate(XrPassthroughLayerFB layer, XrPassthroughKeyboardHandsIntensityFB* intensity);
        private  xrPassthroughLayerSetKeyboardHandsIntensityFBDelegate xrPassthroughLayerSetKeyboardHandsIntensityFB_ptr;
    /// <summary> Requires XR extension "XR_FB_passthrough_keyboard_hands" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrPassthroughLayerSetKeyboardHandsIntensityFB(XrPassthroughLayerFB layer, XrPassthroughKeyboardHandsIntensityFB* intensity)
        => xrPassthroughLayerSetKeyboardHandsIntensityFB_ptr(layer, intensity);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetDeviceSampleRateFBDelegate(XrSession session, XrHapticActionInfo* hapticActionInfo, XrDevicePcmSampleRateStateFB* deviceSampleRate);
        private  xrGetDeviceSampleRateFBDelegate xrGetDeviceSampleRateFB_ptr;
    /// <summary> Requires XR extension "XR_FB_haptic_pcm" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetDeviceSampleRateFB(XrSession session, XrHapticActionInfo* hapticActionInfo, XrDevicePcmSampleRateStateFB* deviceSampleRate)
        => xrGetDeviceSampleRateFB_ptr(session, hapticActionInfo, deviceSampleRate);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetPassthroughPreferencesMETADelegate(XrSession session, XrPassthroughPreferencesMETA* preferences);
        private  xrGetPassthroughPreferencesMETADelegate xrGetPassthroughPreferencesMETA_ptr;
    /// <summary> Requires XR extension "XR_META_passthrough_preferences" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetPassthroughPreferencesMETA(XrSession session, XrPassthroughPreferencesMETA* preferences)
        => xrGetPassthroughPreferencesMETA_ptr(session, preferences);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateVirtualKeyboardMETADelegate(XrSession session, XrVirtualKeyboardCreateInfoMETA* createInfo, XrVirtualKeyboardMETA* keyboard);
        private  xrCreateVirtualKeyboardMETADelegate xrCreateVirtualKeyboardMETA_ptr;
    /// <summary> Requires XR extension "XR_META_virtual_keyboard" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateVirtualKeyboardMETA(XrSession session, XrVirtualKeyboardCreateInfoMETA* createInfo, XrVirtualKeyboardMETA* keyboard)
        => xrCreateVirtualKeyboardMETA_ptr(session, createInfo, keyboard);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyVirtualKeyboardMETADelegate(XrVirtualKeyboardMETA keyboard);
        private  xrDestroyVirtualKeyboardMETADelegate xrDestroyVirtualKeyboardMETA_ptr;
    /// <summary> Requires XR extension "XR_META_virtual_keyboard" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyVirtualKeyboardMETA(XrVirtualKeyboardMETA keyboard)
        => xrDestroyVirtualKeyboardMETA_ptr(keyboard);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateVirtualKeyboardSpaceMETADelegate(XrSession session, XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardSpaceCreateInfoMETA* createInfo, XrSpace* keyboardSpace);
        private  xrCreateVirtualKeyboardSpaceMETADelegate xrCreateVirtualKeyboardSpaceMETA_ptr;
    /// <summary> Requires XR extension "XR_META_virtual_keyboard" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateVirtualKeyboardSpaceMETA(XrSession session, XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardSpaceCreateInfoMETA* createInfo, XrSpace* keyboardSpace)
        => xrCreateVirtualKeyboardSpaceMETA_ptr(session, keyboard, createInfo, keyboardSpace);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSuggestVirtualKeyboardLocationMETADelegate(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardLocationInfoMETA* locationInfo);
        private  xrSuggestVirtualKeyboardLocationMETADelegate xrSuggestVirtualKeyboardLocationMETA_ptr;
    /// <summary> Requires XR extension "XR_META_virtual_keyboard" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSuggestVirtualKeyboardLocationMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardLocationInfoMETA* locationInfo)
        => xrSuggestVirtualKeyboardLocationMETA_ptr(keyboard, locationInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetVirtualKeyboardScaleMETADelegate(XrVirtualKeyboardMETA keyboard, float* scale);
        private  xrGetVirtualKeyboardScaleMETADelegate xrGetVirtualKeyboardScaleMETA_ptr;
    /// <summary> Requires XR extension "XR_META_virtual_keyboard" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetVirtualKeyboardScaleMETA(XrVirtualKeyboardMETA keyboard, float* scale)
        => xrGetVirtualKeyboardScaleMETA_ptr(keyboard, scale);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetVirtualKeyboardModelVisibilityMETADelegate(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelVisibilitySetInfoMETA* modelVisibility);
        private  xrSetVirtualKeyboardModelVisibilityMETADelegate xrSetVirtualKeyboardModelVisibilityMETA_ptr;
    /// <summary> Requires XR extension "XR_META_virtual_keyboard" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetVirtualKeyboardModelVisibilityMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelVisibilitySetInfoMETA* modelVisibility)
        => xrSetVirtualKeyboardModelVisibilityMETA_ptr(keyboard, modelVisibility);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetVirtualKeyboardModelAnimationStatesMETADelegate(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelAnimationStatesMETA* animationStates);
        private  xrGetVirtualKeyboardModelAnimationStatesMETADelegate xrGetVirtualKeyboardModelAnimationStatesMETA_ptr;
    /// <summary> Requires XR extension "XR_META_virtual_keyboard" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetVirtualKeyboardModelAnimationStatesMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelAnimationStatesMETA* animationStates)
        => xrGetVirtualKeyboardModelAnimationStatesMETA_ptr(keyboard, animationStates);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetVirtualKeyboardDirtyTexturesMETADelegate(XrVirtualKeyboardMETA keyboard, uint textureIdCapacityInput, uint* textureIdCountOutput, ulong* textureIds);
        private  xrGetVirtualKeyboardDirtyTexturesMETADelegate xrGetVirtualKeyboardDirtyTexturesMETA_ptr;
    /// <summary> Requires XR extension "XR_META_virtual_keyboard" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetVirtualKeyboardDirtyTexturesMETA(XrVirtualKeyboardMETA keyboard, uint textureIdCapacityInput, uint* textureIdCountOutput, ulong* textureIds)
        => xrGetVirtualKeyboardDirtyTexturesMETA_ptr(keyboard, textureIdCapacityInput, textureIdCountOutput, textureIds);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetVirtualKeyboardTextureDataMETADelegate(XrVirtualKeyboardMETA keyboard, ulong textureId, XrVirtualKeyboardTextureDataMETA* textureData);
        private  xrGetVirtualKeyboardTextureDataMETADelegate xrGetVirtualKeyboardTextureDataMETA_ptr;
    /// <summary> Requires XR extension "XR_META_virtual_keyboard" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetVirtualKeyboardTextureDataMETA(XrVirtualKeyboardMETA keyboard, ulong textureId, XrVirtualKeyboardTextureDataMETA* textureData)
        => xrGetVirtualKeyboardTextureDataMETA_ptr(keyboard, textureId, textureData);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSendVirtualKeyboardInputMETADelegate(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardInputInfoMETA* info, XrPosef* interactorRootPose);
        private  xrSendVirtualKeyboardInputMETADelegate xrSendVirtualKeyboardInputMETA_ptr;
    /// <summary> Requires XR extension "XR_META_virtual_keyboard" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSendVirtualKeyboardInputMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardInputInfoMETA* info, XrPosef* interactorRootPose)
        => xrSendVirtualKeyboardInputMETA_ptr(keyboard, info, interactorRootPose);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrChangeVirtualKeyboardTextContextMETADelegate(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardTextContextChangeInfoMETA* changeInfo);
        private  xrChangeVirtualKeyboardTextContextMETADelegate xrChangeVirtualKeyboardTextContextMETA_ptr;
    /// <summary> Requires XR extension "XR_META_virtual_keyboard" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrChangeVirtualKeyboardTextContextMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardTextContextChangeInfoMETA* changeInfo)
        => xrChangeVirtualKeyboardTextContextMETA_ptr(keyboard, changeInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrEnumerateExternalCamerasOCULUSDelegate(XrSession session, uint cameraCapacityInput, uint* cameraCountOutput, XrExternalCameraOCULUS* cameras);
        private  xrEnumerateExternalCamerasOCULUSDelegate xrEnumerateExternalCamerasOCULUS_ptr;
    /// <summary> Requires XR extension "XR_OCULUS_external_camera" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumerateExternalCamerasOCULUS(XrSession session, uint cameraCapacityInput, uint* cameraCountOutput, XrExternalCameraOCULUS* cameras)
        => xrEnumerateExternalCamerasOCULUS_ptr(session, cameraCapacityInput, cameraCountOutput, cameras);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrEnumeratePerformanceMetricsCounterPathsMETADelegate(XrInstance instance, uint counterPathCapacityInput, uint* counterPathCountOutput, ulong* counterPaths);
        private  xrEnumeratePerformanceMetricsCounterPathsMETADelegate xrEnumeratePerformanceMetricsCounterPathsMETA_ptr;
    /// <summary> Requires XR extension "XR_META_performance_metrics" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrEnumeratePerformanceMetricsCounterPathsMETA(XrInstance instance, uint counterPathCapacityInput, uint* counterPathCountOutput, ulong* counterPaths)
        => xrEnumeratePerformanceMetricsCounterPathsMETA_ptr(instance, counterPathCapacityInput, counterPathCountOutput, counterPaths);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetPerformanceMetricsStateMETADelegate(XrSession session, XrPerformanceMetricsStateMETA* state);
        private  xrSetPerformanceMetricsStateMETADelegate xrSetPerformanceMetricsStateMETA_ptr;
    /// <summary> Requires XR extension "XR_META_performance_metrics" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state)
        => xrSetPerformanceMetricsStateMETA_ptr(session, state);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetPerformanceMetricsStateMETADelegate(XrSession session, XrPerformanceMetricsStateMETA* state);
        private  xrGetPerformanceMetricsStateMETADelegate xrGetPerformanceMetricsStateMETA_ptr;
    /// <summary> Requires XR extension "XR_META_performance_metrics" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state)
        => xrGetPerformanceMetricsStateMETA_ptr(session, state);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrQueryPerformanceMetricsCounterMETADelegate(XrSession session, ulong counterPath, XrPerformanceMetricsCounterMETA* counter);
        private  xrQueryPerformanceMetricsCounterMETADelegate xrQueryPerformanceMetricsCounterMETA_ptr;
    /// <summary> Requires XR extension "XR_META_performance_metrics" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrQueryPerformanceMetricsCounterMETA(XrSession session, ulong counterPath, XrPerformanceMetricsCounterMETA* counter)
        => xrQueryPerformanceMetricsCounterMETA_ptr(session, counterPath, counter);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSaveSpaceListFBDelegate(XrSession session, XrSpaceListSaveInfoFB* info, ulong* requestId);
        private  xrSaveSpaceListFBDelegate xrSaveSpaceListFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity_storage_batch" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSaveSpaceListFB(XrSession session, XrSpaceListSaveInfoFB* info, ulong* requestId)
        => xrSaveSpaceListFB_ptr(session, info, requestId);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreateSpaceUserFBDelegate(XrSession session, XrSpaceUserCreateInfoFB* info, XrSpaceUserFB* user);
        private  xrCreateSpaceUserFBDelegate xrCreateSpaceUserFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity_user" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreateSpaceUserFB(XrSession session, XrSpaceUserCreateInfoFB* info, XrSpaceUserFB* user)
        => xrCreateSpaceUserFB_ptr(session, info, user);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetSpaceUserIdFBDelegate(XrSpaceUserFB user, ulong* userId);
        private  xrGetSpaceUserIdFBDelegate xrGetSpaceUserIdFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity_user" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetSpaceUserIdFB(XrSpaceUserFB user, ulong* userId)
        => xrGetSpaceUserIdFB_ptr(user, userId);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroySpaceUserFBDelegate(XrSpaceUserFB user);
        private  xrDestroySpaceUserFBDelegate xrDestroySpaceUserFB_ptr;
    /// <summary> Requires XR extension "XR_FB_spatial_entity_user" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroySpaceUserFB(XrSpaceUserFB user)
        => xrDestroySpaceUserFB_ptr(user);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreatePassthroughColorLutMETADelegate(XrPassthroughFB passthrough, XrPassthroughColorLutCreateInfoMETA* createInfo, XrPassthroughColorLutMETA* colorLut);
        private  xrCreatePassthroughColorLutMETADelegate xrCreatePassthroughColorLutMETA_ptr;
    /// <summary> Requires XR extension "XR_META_passthrough_color_lut" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreatePassthroughColorLutMETA(XrPassthroughFB passthrough, XrPassthroughColorLutCreateInfoMETA* createInfo, XrPassthroughColorLutMETA* colorLut)
        => xrCreatePassthroughColorLutMETA_ptr(passthrough, createInfo, colorLut);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyPassthroughColorLutMETADelegate(XrPassthroughColorLutMETA colorLut);
        private  xrDestroyPassthroughColorLutMETADelegate xrDestroyPassthroughColorLutMETA_ptr;
    /// <summary> Requires XR extension "XR_META_passthrough_color_lut" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FEATURE_UNSUPPORTED"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyPassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut)
        => xrDestroyPassthroughColorLutMETA_ptr(colorLut);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrUpdatePassthroughColorLutMETADelegate(XrPassthroughColorLutMETA colorLut, XrPassthroughColorLutUpdateInfoMETA* updateInfo);
        private  xrUpdatePassthroughColorLutMETADelegate xrUpdatePassthroughColorLutMETA_ptr;
    /// <summary> Requires XR extension "XR_META_passthrough_color_lut" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrUpdatePassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut, XrPassthroughColorLutUpdateInfoMETA* updateInfo)
        => xrUpdatePassthroughColorLutMETA_ptr(colorLut, updateInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrSetTrackingOptimizationSettingsHintQCOMDelegate(XrSession session, XrTrackingOptimizationSettingsDomainQCOM domain, XrTrackingOptimizationSettingsHintQCOM hint);
        private  xrSetTrackingOptimizationSettingsHintQCOMDelegate xrSetTrackingOptimizationSettingsHintQCOM_ptr;
    /// <summary> Requires XR extension "XR_QCOM_tracking_optimization_settings" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrSetTrackingOptimizationSettingsHintQCOM(XrSession session, XrTrackingOptimizationSettingsDomainQCOM domain, XrTrackingOptimizationSettingsHintQCOM hint)
        => xrSetTrackingOptimizationSettingsHintQCOM_ptr(session, domain, hint);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreatePassthroughHTCDelegate(XrSession session, XrPassthroughCreateInfoHTC* createInfo, XrPassthroughHTC* passthrough);
        private  xrCreatePassthroughHTCDelegate xrCreatePassthroughHTC_ptr;
    /// <summary> Requires XR extension "XR_HTC_passthrough" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreatePassthroughHTC(XrSession session, XrPassthroughCreateInfoHTC* createInfo, XrPassthroughHTC* passthrough)
        => xrCreatePassthroughHTC_ptr(session, createInfo, passthrough);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyPassthroughHTCDelegate(XrPassthroughHTC passthrough);
        private  xrDestroyPassthroughHTCDelegate xrDestroyPassthroughHTC_ptr;
    /// <summary> Requires XR extension "XR_HTC_passthrough" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyPassthroughHTC(XrPassthroughHTC passthrough)
        => xrDestroyPassthroughHTC_ptr(passthrough);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrApplyFoveationHTCDelegate(XrSession session, XrFoveationApplyInfoHTC* applyInfo);
        private  xrApplyFoveationHTCDelegate xrApplyFoveationHTC_ptr;
    /// <summary> Requires XR extension "XR_HTC_foveation" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrApplyFoveationHTC(XrSession session, XrFoveationApplyInfoHTC* applyInfo)
        => xrApplyFoveationHTC_ptr(session, applyInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrApplyForceFeedbackCurlMNDXDelegate(XrHandTrackerEXT handTracker, XrForceFeedbackCurlApplyLocationsMNDX* locations);
        private  xrApplyForceFeedbackCurlMNDXDelegate xrApplyForceFeedbackCurlMNDX_ptr;
    /// <summary> Requires XR extension "XR_MNDX_force_feedback_curl" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrApplyForceFeedbackCurlMNDX(XrHandTrackerEXT handTracker, XrForceFeedbackCurlApplyLocationsMNDX* locations)
        => xrApplyForceFeedbackCurlMNDX_ptr(handTracker, locations);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrCreatePlaneDetectorEXTDelegate(XrSession session, XrPlaneDetectorCreateInfoEXT* createInfo, XrPlaneDetectorEXT* planeDetector);
        private  xrCreatePlaneDetectorEXTDelegate xrCreatePlaneDetectorEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_plane_detection" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrCreatePlaneDetectorEXT(XrSession session, XrPlaneDetectorCreateInfoEXT* createInfo, XrPlaneDetectorEXT* planeDetector)
        => xrCreatePlaneDetectorEXT_ptr(session, createInfo, planeDetector);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrDestroyPlaneDetectorEXTDelegate(XrPlaneDetectorEXT planeDetector);
        private  xrDestroyPlaneDetectorEXTDelegate xrDestroyPlaneDetectorEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_plane_detection" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_RUNTIME_FAILURE"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrDestroyPlaneDetectorEXT(XrPlaneDetectorEXT planeDetector)
        => xrDestroyPlaneDetectorEXT_ptr(planeDetector);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrBeginPlaneDetectionEXTDelegate(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorBeginInfoEXT* beginInfo);
        private  xrBeginPlaneDetectionEXTDelegate xrBeginPlaneDetectionEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_plane_detection" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrBeginPlaneDetectionEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorBeginInfoEXT* beginInfo)
        => xrBeginPlaneDetectionEXT_ptr(planeDetector, beginInfo);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetPlaneDetectionStateEXTDelegate(XrPlaneDetectorEXT planeDetector, XrPlaneDetectionStateEXT* state);
        private  xrGetPlaneDetectionStateEXTDelegate xrGetPlaneDetectionStateEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_plane_detection" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetPlaneDetectionStateEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectionStateEXT* state)
        => xrGetPlaneDetectionStateEXT_ptr(planeDetector, state);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetPlaneDetectionsEXTDelegate(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorGetInfoEXT* info, XrPlaneDetectorLocationsEXT* locations);
        private  xrGetPlaneDetectionsEXTDelegate xrGetPlaneDetectionsEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_plane_detection" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetPlaneDetectionsEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorGetInfoEXT* info, XrPlaneDetectorLocationsEXT* locations)
        => xrGetPlaneDetectionsEXT_ptr(planeDetector, info, locations);

        [UnmanagedFunctionPointer(OpenXRNative.CallConv)]
        private delegate XrResult xrGetPlanePolygonBufferEXTDelegate(XrPlaneDetectorEXT planeDetector, ulong planeId, uint polygonBufferIndex, XrPlaneDetectorPolygonBufferEXT* polygonBuffer);
        private  xrGetPlanePolygonBufferEXTDelegate xrGetPlanePolygonBufferEXT_ptr;
    /// <summary> Requires XR extension "XR_EXT_plane_detection" </summary>
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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public XrResult xrGetPlanePolygonBufferEXT(XrPlaneDetectorEXT planeDetector, ulong planeId, uint polygonBufferIndex, XrPlaneDetectorPolygonBufferEXT* polygonBuffer)
        => xrGetPlanePolygonBufferEXT_ptr(planeDetector, planeId, polygonBufferIndex, polygonBuffer);

    public void LoadFunctionPointers(XrInstance instance = default)
    {
        if (instance != default)
            nativeLib.instance = instance;

        nativeLib.LoadFunction("xrSetAndroidApplicationThreadKHR",  out xrSetAndroidApplicationThreadKHR_ptr);
        nativeLib.LoadFunction("xrCreateSwapchainAndroidSurfaceKHR",  out xrCreateSwapchainAndroidSurfaceKHR_ptr);
        nativeLib.LoadFunction("xrPerfSettingsSetPerformanceLevelEXT",  out xrPerfSettingsSetPerformanceLevelEXT_ptr);
        nativeLib.LoadFunction("xrThermalGetTemperatureTrendEXT",  out xrThermalGetTemperatureTrendEXT_ptr);
        nativeLib.LoadFunction("xrSetDebugUtilsObjectNameEXT",  out xrSetDebugUtilsObjectNameEXT_ptr);
        nativeLib.LoadFunction("xrCreateDebugUtilsMessengerEXT",  out xrCreateDebugUtilsMessengerEXT_ptr);
        nativeLib.LoadFunction("xrDestroyDebugUtilsMessengerEXT",  out xrDestroyDebugUtilsMessengerEXT_ptr);
        nativeLib.LoadFunction("xrSubmitDebugUtilsMessageEXT",  out xrSubmitDebugUtilsMessageEXT_ptr);
        nativeLib.LoadFunction("xrSessionBeginDebugUtilsLabelRegionEXT",  out xrSessionBeginDebugUtilsLabelRegionEXT_ptr);
        nativeLib.LoadFunction("xrSessionEndDebugUtilsLabelRegionEXT",  out xrSessionEndDebugUtilsLabelRegionEXT_ptr);
        nativeLib.LoadFunction("xrSessionInsertDebugUtilsLabelEXT",  out xrSessionInsertDebugUtilsLabelEXT_ptr);
        nativeLib.LoadFunction("xrGetOpenGLGraphicsRequirementsKHR",  out xrGetOpenGLGraphicsRequirementsKHR_ptr);
        nativeLib.LoadFunction("xrGetOpenGLESGraphicsRequirementsKHR",  out xrGetOpenGLESGraphicsRequirementsKHR_ptr);
        nativeLib.LoadFunction("xrGetVulkanInstanceExtensionsKHR",  out xrGetVulkanInstanceExtensionsKHR_ptr);
        nativeLib.LoadFunction("xrGetVulkanDeviceExtensionsKHR",  out xrGetVulkanDeviceExtensionsKHR_ptr);
        nativeLib.LoadFunction("xrGetVulkanGraphicsDeviceKHR",  out xrGetVulkanGraphicsDeviceKHR_ptr);
        nativeLib.LoadFunction("xrGetVulkanGraphicsRequirementsKHR",  out xrGetVulkanGraphicsRequirementsKHR_ptr);
        nativeLib.LoadFunction("xrGetD3D11GraphicsRequirementsKHR",  out xrGetD3D11GraphicsRequirementsKHR_ptr);
        nativeLib.LoadFunction("xrGetD3D12GraphicsRequirementsKHR",  out xrGetD3D12GraphicsRequirementsKHR_ptr);
        nativeLib.LoadFunction("xrGetVisibilityMaskKHR",  out xrGetVisibilityMaskKHR_ptr);
        nativeLib.LoadFunction("xrConvertWin32PerformanceCounterToTimeKHR",  out xrConvertWin32PerformanceCounterToTimeKHR_ptr);
        nativeLib.LoadFunction("xrConvertTimeToWin32PerformanceCounterKHR",  out xrConvertTimeToWin32PerformanceCounterKHR_ptr);
        nativeLib.LoadFunction("xrConvertTimespecTimeToTimeKHR",  out xrConvertTimespecTimeToTimeKHR_ptr);
        nativeLib.LoadFunction("xrConvertTimeToTimespecTimeKHR",  out xrConvertTimeToTimespecTimeKHR_ptr);
        nativeLib.LoadFunction("xrCreateSpatialAnchorMSFT",  out xrCreateSpatialAnchorMSFT_ptr);
        nativeLib.LoadFunction("xrCreateSpatialAnchorSpaceMSFT",  out xrCreateSpatialAnchorSpaceMSFT_ptr);
        nativeLib.LoadFunction("xrDestroySpatialAnchorMSFT",  out xrDestroySpatialAnchorMSFT_ptr);
        nativeLib.LoadFunction("xrSetInputDeviceActiveEXT",  out xrSetInputDeviceActiveEXT_ptr);
        nativeLib.LoadFunction("xrSetInputDeviceStateBoolEXT",  out xrSetInputDeviceStateBoolEXT_ptr);
        nativeLib.LoadFunction("xrSetInputDeviceStateFloatEXT",  out xrSetInputDeviceStateFloatEXT_ptr);
        nativeLib.LoadFunction("xrSetInputDeviceStateVector2fEXT",  out xrSetInputDeviceStateVector2fEXT_ptr);
        nativeLib.LoadFunction("xrSetInputDeviceLocationEXT",  out xrSetInputDeviceLocationEXT_ptr);
        nativeLib.LoadFunction("xrCreateSpatialGraphNodeSpaceMSFT",  out xrCreateSpatialGraphNodeSpaceMSFT_ptr);
        nativeLib.LoadFunction("xrTryCreateSpatialGraphStaticNodeBindingMSFT",  out xrTryCreateSpatialGraphStaticNodeBindingMSFT_ptr);
        nativeLib.LoadFunction("xrDestroySpatialGraphNodeBindingMSFT",  out xrDestroySpatialGraphNodeBindingMSFT_ptr);
        nativeLib.LoadFunction("xrGetSpatialGraphNodeBindingPropertiesMSFT",  out xrGetSpatialGraphNodeBindingPropertiesMSFT_ptr);
        nativeLib.LoadFunction("xrCreateHandTrackerEXT",  out xrCreateHandTrackerEXT_ptr);
        nativeLib.LoadFunction("xrDestroyHandTrackerEXT",  out xrDestroyHandTrackerEXT_ptr);
        nativeLib.LoadFunction("xrLocateHandJointsEXT",  out xrLocateHandJointsEXT_ptr);
        nativeLib.LoadFunction("xrCreateHandMeshSpaceMSFT",  out xrCreateHandMeshSpaceMSFT_ptr);
        nativeLib.LoadFunction("xrUpdateHandMeshMSFT",  out xrUpdateHandMeshMSFT_ptr);
        nativeLib.LoadFunction("xrGetControllerModelKeyMSFT",  out xrGetControllerModelKeyMSFT_ptr);
        nativeLib.LoadFunction("xrLoadControllerModelMSFT",  out xrLoadControllerModelMSFT_ptr);
        nativeLib.LoadFunction("xrGetControllerModelPropertiesMSFT",  out xrGetControllerModelPropertiesMSFT_ptr);
        nativeLib.LoadFunction("xrGetControllerModelStateMSFT",  out xrGetControllerModelStateMSFT_ptr);
        nativeLib.LoadFunction("xrCreateSpatialAnchorFromPerceptionAnchorMSFT",  out xrCreateSpatialAnchorFromPerceptionAnchorMSFT_ptr);
        nativeLib.LoadFunction("xrTryGetPerceptionAnchorFromSpatialAnchorMSFT",  out xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_ptr);
        nativeLib.LoadFunction("xrEnumerateReprojectionModesMSFT",  out xrEnumerateReprojectionModesMSFT_ptr);
        nativeLib.LoadFunction("xrUpdateSwapchainFB",  out xrUpdateSwapchainFB_ptr);
        nativeLib.LoadFunction("xrGetSwapchainStateFB",  out xrGetSwapchainStateFB_ptr);
        nativeLib.LoadFunction("xrCreateBodyTrackerFB",  out xrCreateBodyTrackerFB_ptr);
        nativeLib.LoadFunction("xrDestroyBodyTrackerFB",  out xrDestroyBodyTrackerFB_ptr);
        nativeLib.LoadFunction("xrLocateBodyJointsFB",  out xrLocateBodyJointsFB_ptr);
        nativeLib.LoadFunction("xrGetBodySkeletonFB",  out xrGetBodySkeletonFB_ptr);
        nativeLib.LoadFunction("xrInitializeLoaderKHR",  out xrInitializeLoaderKHR_ptr);
        nativeLib.LoadFunction("xrCreateVulkanInstanceKHR",  out xrCreateVulkanInstanceKHR_ptr);
        nativeLib.LoadFunction("xrCreateVulkanDeviceKHR",  out xrCreateVulkanDeviceKHR_ptr);
        nativeLib.LoadFunction("xrGetVulkanGraphicsDevice2KHR",  out xrGetVulkanGraphicsDevice2KHR_ptr);
        nativeLib.LoadFunction("xrEnumerateSceneComputeFeaturesMSFT",  out xrEnumerateSceneComputeFeaturesMSFT_ptr);
        nativeLib.LoadFunction("xrCreateSceneObserverMSFT",  out xrCreateSceneObserverMSFT_ptr);
        nativeLib.LoadFunction("xrDestroySceneObserverMSFT",  out xrDestroySceneObserverMSFT_ptr);
        nativeLib.LoadFunction("xrCreateSceneMSFT",  out xrCreateSceneMSFT_ptr);
        nativeLib.LoadFunction("xrDestroySceneMSFT",  out xrDestroySceneMSFT_ptr);
        nativeLib.LoadFunction("xrComputeNewSceneMSFT",  out xrComputeNewSceneMSFT_ptr);
        nativeLib.LoadFunction("xrGetSceneComputeStateMSFT",  out xrGetSceneComputeStateMSFT_ptr);
        nativeLib.LoadFunction("xrGetSceneComponentsMSFT",  out xrGetSceneComponentsMSFT_ptr);
        nativeLib.LoadFunction("xrLocateSceneComponentsMSFT",  out xrLocateSceneComponentsMSFT_ptr);
        nativeLib.LoadFunction("xrGetSceneMeshBuffersMSFT",  out xrGetSceneMeshBuffersMSFT_ptr);
        nativeLib.LoadFunction("xrDeserializeSceneMSFT",  out xrDeserializeSceneMSFT_ptr);
        nativeLib.LoadFunction("xrGetSerializedSceneFragmentDataMSFT",  out xrGetSerializedSceneFragmentDataMSFT_ptr);
        nativeLib.LoadFunction("xrEnumerateDisplayRefreshRatesFB",  out xrEnumerateDisplayRefreshRatesFB_ptr);
        nativeLib.LoadFunction("xrGetDisplayRefreshRateFB",  out xrGetDisplayRefreshRateFB_ptr);
        nativeLib.LoadFunction("xrRequestDisplayRefreshRateFB",  out xrRequestDisplayRefreshRateFB_ptr);
        nativeLib.LoadFunction("xrEnumerateViveTrackerPathsHTCX",  out xrEnumerateViveTrackerPathsHTCX_ptr);
        nativeLib.LoadFunction("xrCreateFacialTrackerHTC",  out xrCreateFacialTrackerHTC_ptr);
        nativeLib.LoadFunction("xrDestroyFacialTrackerHTC",  out xrDestroyFacialTrackerHTC_ptr);
        nativeLib.LoadFunction("xrGetFacialExpressionsHTC",  out xrGetFacialExpressionsHTC_ptr);
        nativeLib.LoadFunction("xrEnumerateColorSpacesFB",  out xrEnumerateColorSpacesFB_ptr);
        nativeLib.LoadFunction("xrSetColorSpaceFB",  out xrSetColorSpaceFB_ptr);
        nativeLib.LoadFunction("xrGetHandMeshFB",  out xrGetHandMeshFB_ptr);
        nativeLib.LoadFunction("xrCreateSpatialAnchorFB",  out xrCreateSpatialAnchorFB_ptr);
        nativeLib.LoadFunction("xrGetSpaceUuidFB",  out xrGetSpaceUuidFB_ptr);
        nativeLib.LoadFunction("xrEnumerateSpaceSupportedComponentsFB",  out xrEnumerateSpaceSupportedComponentsFB_ptr);
        nativeLib.LoadFunction("xrSetSpaceComponentStatusFB",  out xrSetSpaceComponentStatusFB_ptr);
        nativeLib.LoadFunction("xrGetSpaceComponentStatusFB",  out xrGetSpaceComponentStatusFB_ptr);
        nativeLib.LoadFunction("xrCreateFoveationProfileFB",  out xrCreateFoveationProfileFB_ptr);
        nativeLib.LoadFunction("xrDestroyFoveationProfileFB",  out xrDestroyFoveationProfileFB_ptr);
        nativeLib.LoadFunction("xrQuerySystemTrackedKeyboardFB",  out xrQuerySystemTrackedKeyboardFB_ptr);
        nativeLib.LoadFunction("xrCreateKeyboardSpaceFB",  out xrCreateKeyboardSpaceFB_ptr);
        nativeLib.LoadFunction("xrCreateTriangleMeshFB",  out xrCreateTriangleMeshFB_ptr);
        nativeLib.LoadFunction("xrDestroyTriangleMeshFB",  out xrDestroyTriangleMeshFB_ptr);
        nativeLib.LoadFunction("xrTriangleMeshGetVertexBufferFB",  out xrTriangleMeshGetVertexBufferFB_ptr);
        nativeLib.LoadFunction("xrTriangleMeshGetIndexBufferFB",  out xrTriangleMeshGetIndexBufferFB_ptr);
        nativeLib.LoadFunction("xrTriangleMeshBeginUpdateFB",  out xrTriangleMeshBeginUpdateFB_ptr);
        nativeLib.LoadFunction("xrTriangleMeshEndUpdateFB",  out xrTriangleMeshEndUpdateFB_ptr);
        nativeLib.LoadFunction("xrTriangleMeshBeginVertexBufferUpdateFB",  out xrTriangleMeshBeginVertexBufferUpdateFB_ptr);
        nativeLib.LoadFunction("xrTriangleMeshEndVertexBufferUpdateFB",  out xrTriangleMeshEndVertexBufferUpdateFB_ptr);
        nativeLib.LoadFunction("xrCreatePassthroughFB",  out xrCreatePassthroughFB_ptr);
        nativeLib.LoadFunction("xrDestroyPassthroughFB",  out xrDestroyPassthroughFB_ptr);
        nativeLib.LoadFunction("xrPassthroughStartFB",  out xrPassthroughStartFB_ptr);
        nativeLib.LoadFunction("xrPassthroughPauseFB",  out xrPassthroughPauseFB_ptr);
        nativeLib.LoadFunction("xrCreatePassthroughLayerFB",  out xrCreatePassthroughLayerFB_ptr);
        nativeLib.LoadFunction("xrDestroyPassthroughLayerFB",  out xrDestroyPassthroughLayerFB_ptr);
        nativeLib.LoadFunction("xrPassthroughLayerPauseFB",  out xrPassthroughLayerPauseFB_ptr);
        nativeLib.LoadFunction("xrPassthroughLayerResumeFB",  out xrPassthroughLayerResumeFB_ptr);
        nativeLib.LoadFunction("xrPassthroughLayerSetStyleFB",  out xrPassthroughLayerSetStyleFB_ptr);
        nativeLib.LoadFunction("xrCreateGeometryInstanceFB",  out xrCreateGeometryInstanceFB_ptr);
        nativeLib.LoadFunction("xrDestroyGeometryInstanceFB",  out xrDestroyGeometryInstanceFB_ptr);
        nativeLib.LoadFunction("xrGeometryInstanceSetTransformFB",  out xrGeometryInstanceSetTransformFB_ptr);
        nativeLib.LoadFunction("xrEnumerateRenderModelPathsFB",  out xrEnumerateRenderModelPathsFB_ptr);
        nativeLib.LoadFunction("xrGetRenderModelPropertiesFB",  out xrGetRenderModelPropertiesFB_ptr);
        nativeLib.LoadFunction("xrLoadRenderModelFB",  out xrLoadRenderModelFB_ptr);
        nativeLib.LoadFunction("xrSetEnvironmentDepthEstimationVARJO",  out xrSetEnvironmentDepthEstimationVARJO_ptr);
        nativeLib.LoadFunction("xrSetMarkerTrackingVARJO",  out xrSetMarkerTrackingVARJO_ptr);
        nativeLib.LoadFunction("xrSetMarkerTrackingTimeoutVARJO",  out xrSetMarkerTrackingTimeoutVARJO_ptr);
        nativeLib.LoadFunction("xrSetMarkerTrackingPredictionVARJO",  out xrSetMarkerTrackingPredictionVARJO_ptr);
        nativeLib.LoadFunction("xrGetMarkerSizeVARJO",  out xrGetMarkerSizeVARJO_ptr);
        nativeLib.LoadFunction("xrCreateMarkerSpaceVARJO",  out xrCreateMarkerSpaceVARJO_ptr);
        nativeLib.LoadFunction("xrSetViewOffsetVARJO",  out xrSetViewOffsetVARJO_ptr);
        nativeLib.LoadFunction("xrCreateSpaceFromCoordinateFrameUIDML",  out xrCreateSpaceFromCoordinateFrameUIDML_ptr);
        nativeLib.LoadFunction("xrCreateSpatialAnchorStoreConnectionMSFT",  out xrCreateSpatialAnchorStoreConnectionMSFT_ptr);
        nativeLib.LoadFunction("xrDestroySpatialAnchorStoreConnectionMSFT",  out xrDestroySpatialAnchorStoreConnectionMSFT_ptr);
        nativeLib.LoadFunction("xrPersistSpatialAnchorMSFT",  out xrPersistSpatialAnchorMSFT_ptr);
        nativeLib.LoadFunction("xrEnumeratePersistedSpatialAnchorNamesMSFT",  out xrEnumeratePersistedSpatialAnchorNamesMSFT_ptr);
        nativeLib.LoadFunction("xrCreateSpatialAnchorFromPersistedNameMSFT",  out xrCreateSpatialAnchorFromPersistedNameMSFT_ptr);
        nativeLib.LoadFunction("xrUnpersistSpatialAnchorMSFT",  out xrUnpersistSpatialAnchorMSFT_ptr);
        nativeLib.LoadFunction("xrClearSpatialAnchorStoreMSFT",  out xrClearSpatialAnchorStoreMSFT_ptr);
        nativeLib.LoadFunction("xrQuerySpacesFB",  out xrQuerySpacesFB_ptr);
        nativeLib.LoadFunction("xrRetrieveSpaceQueryResultsFB",  out xrRetrieveSpaceQueryResultsFB_ptr);
        nativeLib.LoadFunction("xrSaveSpaceFB",  out xrSaveSpaceFB_ptr);
        nativeLib.LoadFunction("xrEraseSpaceFB",  out xrEraseSpaceFB_ptr);
        nativeLib.LoadFunction("xrGetAudioOutputDeviceGuidOculus",  out xrGetAudioOutputDeviceGuidOculus_ptr);
        nativeLib.LoadFunction("xrGetAudioInputDeviceGuidOculus",  out xrGetAudioInputDeviceGuidOculus_ptr);
        nativeLib.LoadFunction("xrShareSpacesFB",  out xrShareSpacesFB_ptr);
        nativeLib.LoadFunction("xrGetSpaceBoundingBox2DFB",  out xrGetSpaceBoundingBox2DFB_ptr);
        nativeLib.LoadFunction("xrGetSpaceBoundingBox3DFB",  out xrGetSpaceBoundingBox3DFB_ptr);
        nativeLib.LoadFunction("xrGetSpaceSemanticLabelsFB",  out xrGetSpaceSemanticLabelsFB_ptr);
        nativeLib.LoadFunction("xrGetSpaceBoundary2DFB",  out xrGetSpaceBoundary2DFB_ptr);
        nativeLib.LoadFunction("xrGetSpaceRoomLayoutFB",  out xrGetSpaceRoomLayoutFB_ptr);
        nativeLib.LoadFunction("xrSetDigitalLensControlALMALENCE",  out xrSetDigitalLensControlALMALENCE_ptr);
        nativeLib.LoadFunction("xrRequestSceneCaptureFB",  out xrRequestSceneCaptureFB_ptr);
        nativeLib.LoadFunction("xrGetSpaceContainerFB",  out xrGetSpaceContainerFB_ptr);
        nativeLib.LoadFunction("xrGetFoveationEyeTrackedStateMETA",  out xrGetFoveationEyeTrackedStateMETA_ptr);
        nativeLib.LoadFunction("xrCreateFaceTrackerFB",  out xrCreateFaceTrackerFB_ptr);
        nativeLib.LoadFunction("xrDestroyFaceTrackerFB",  out xrDestroyFaceTrackerFB_ptr);
        nativeLib.LoadFunction("xrGetFaceExpressionWeightsFB",  out xrGetFaceExpressionWeightsFB_ptr);
        nativeLib.LoadFunction("xrCreateEyeTrackerFB",  out xrCreateEyeTrackerFB_ptr);
        nativeLib.LoadFunction("xrDestroyEyeTrackerFB",  out xrDestroyEyeTrackerFB_ptr);
        nativeLib.LoadFunction("xrGetEyeGazesFB",  out xrGetEyeGazesFB_ptr);
        nativeLib.LoadFunction("xrPassthroughLayerSetKeyboardHandsIntensityFB",  out xrPassthroughLayerSetKeyboardHandsIntensityFB_ptr);
        nativeLib.LoadFunction("xrGetDeviceSampleRateFB",  out xrGetDeviceSampleRateFB_ptr);
        nativeLib.LoadFunction("xrGetPassthroughPreferencesMETA",  out xrGetPassthroughPreferencesMETA_ptr);
        nativeLib.LoadFunction("xrCreateVirtualKeyboardMETA",  out xrCreateVirtualKeyboardMETA_ptr);
        nativeLib.LoadFunction("xrDestroyVirtualKeyboardMETA",  out xrDestroyVirtualKeyboardMETA_ptr);
        nativeLib.LoadFunction("xrCreateVirtualKeyboardSpaceMETA",  out xrCreateVirtualKeyboardSpaceMETA_ptr);
        nativeLib.LoadFunction("xrSuggestVirtualKeyboardLocationMETA",  out xrSuggestVirtualKeyboardLocationMETA_ptr);
        nativeLib.LoadFunction("xrGetVirtualKeyboardScaleMETA",  out xrGetVirtualKeyboardScaleMETA_ptr);
        nativeLib.LoadFunction("xrSetVirtualKeyboardModelVisibilityMETA",  out xrSetVirtualKeyboardModelVisibilityMETA_ptr);
        nativeLib.LoadFunction("xrGetVirtualKeyboardModelAnimationStatesMETA",  out xrGetVirtualKeyboardModelAnimationStatesMETA_ptr);
        nativeLib.LoadFunction("xrGetVirtualKeyboardDirtyTexturesMETA",  out xrGetVirtualKeyboardDirtyTexturesMETA_ptr);
        nativeLib.LoadFunction("xrGetVirtualKeyboardTextureDataMETA",  out xrGetVirtualKeyboardTextureDataMETA_ptr);
        nativeLib.LoadFunction("xrSendVirtualKeyboardInputMETA",  out xrSendVirtualKeyboardInputMETA_ptr);
        nativeLib.LoadFunction("xrChangeVirtualKeyboardTextContextMETA",  out xrChangeVirtualKeyboardTextContextMETA_ptr);
        nativeLib.LoadFunction("xrEnumerateExternalCamerasOCULUS",  out xrEnumerateExternalCamerasOCULUS_ptr);
        nativeLib.LoadFunction("xrEnumeratePerformanceMetricsCounterPathsMETA",  out xrEnumeratePerformanceMetricsCounterPathsMETA_ptr);
        nativeLib.LoadFunction("xrSetPerformanceMetricsStateMETA",  out xrSetPerformanceMetricsStateMETA_ptr);
        nativeLib.LoadFunction("xrGetPerformanceMetricsStateMETA",  out xrGetPerformanceMetricsStateMETA_ptr);
        nativeLib.LoadFunction("xrQueryPerformanceMetricsCounterMETA",  out xrQueryPerformanceMetricsCounterMETA_ptr);
        nativeLib.LoadFunction("xrSaveSpaceListFB",  out xrSaveSpaceListFB_ptr);
        nativeLib.LoadFunction("xrCreateSpaceUserFB",  out xrCreateSpaceUserFB_ptr);
        nativeLib.LoadFunction("xrGetSpaceUserIdFB",  out xrGetSpaceUserIdFB_ptr);
        nativeLib.LoadFunction("xrDestroySpaceUserFB",  out xrDestroySpaceUserFB_ptr);
        nativeLib.LoadFunction("xrCreatePassthroughColorLutMETA",  out xrCreatePassthroughColorLutMETA_ptr);
        nativeLib.LoadFunction("xrDestroyPassthroughColorLutMETA",  out xrDestroyPassthroughColorLutMETA_ptr);
        nativeLib.LoadFunction("xrUpdatePassthroughColorLutMETA",  out xrUpdatePassthroughColorLutMETA_ptr);
        nativeLib.LoadFunction("xrSetTrackingOptimizationSettingsHintQCOM",  out xrSetTrackingOptimizationSettingsHintQCOM_ptr);
        nativeLib.LoadFunction("xrCreatePassthroughHTC",  out xrCreatePassthroughHTC_ptr);
        nativeLib.LoadFunction("xrDestroyPassthroughHTC",  out xrDestroyPassthroughHTC_ptr);
        nativeLib.LoadFunction("xrApplyFoveationHTC",  out xrApplyFoveationHTC_ptr);
        nativeLib.LoadFunction("xrApplyForceFeedbackCurlMNDX",  out xrApplyForceFeedbackCurlMNDX_ptr);
        nativeLib.LoadFunction("xrCreatePlaneDetectorEXT",  out xrCreatePlaneDetectorEXT_ptr);
        nativeLib.LoadFunction("xrDestroyPlaneDetectorEXT",  out xrDestroyPlaneDetectorEXT_ptr);
        nativeLib.LoadFunction("xrBeginPlaneDetectionEXT",  out xrBeginPlaneDetectionEXT_ptr);
        nativeLib.LoadFunction("xrGetPlaneDetectionStateEXT",  out xrGetPlaneDetectionStateEXT_ptr);
        nativeLib.LoadFunction("xrGetPlaneDetectionsEXT",  out xrGetPlaneDetectionsEXT_ptr);
        nativeLib.LoadFunction("xrGetPlanePolygonBufferEXT",  out xrGetPlanePolygonBufferEXT_ptr);
    }
}