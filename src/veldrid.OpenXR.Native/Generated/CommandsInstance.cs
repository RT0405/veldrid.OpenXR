using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Veldrid.OpenXR.Native;
public unsafe partial class OpenXRNativeInstance
{
#pragma warning disable CA1822 // Mark members as static
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
    public XrResult xrGetInstanceProcAddr(XrInstance instance, byte* name, void** function)
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
        => xrSetAndroidApplicationThreadKHR_funcPtr(session, threadType, threadId);
    private delegate* unmanaged<XrSession, XrAndroidThreadTypeKHR, uint, XrResult> xrSetAndroidApplicationThreadKHR_funcPtr;

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
    public XrResult xrCreateSwapchainAndroidSurfaceKHR(XrSession session, XrSwapchainCreateInfo* info, XrSwapchain* swapchain, nint* surface)
        => xrCreateSwapchainAndroidSurfaceKHR_funcPtr(session, info, swapchain, surface);
    private delegate* unmanaged<XrSession, XrSwapchainCreateInfo*, XrSwapchain*, nint*, XrResult> xrCreateSwapchainAndroidSurfaceKHR_funcPtr;

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
        => xrPerfSettingsSetPerformanceLevelEXT_funcPtr(session, domain, level);
    private delegate* unmanaged<XrSession, XrPerfSettingsDomainEXT, XrPerfSettingsLevelEXT, XrResult> xrPerfSettingsSetPerformanceLevelEXT_funcPtr;

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
        => xrThermalGetTemperatureTrendEXT_funcPtr(session, domain, notificationLevel, tempHeadroom, tempSlope);
    private delegate* unmanaged<XrSession, XrPerfSettingsDomainEXT, XrPerfSettingsNotificationLevelEXT*, float*, float*, XrResult> xrThermalGetTemperatureTrendEXT_funcPtr;

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
        => xrSetDebugUtilsObjectNameEXT_funcPtr(instance, nameInfo);
    private delegate* unmanaged<XrInstance, XrDebugUtilsObjectNameInfoEXT*, XrResult> xrSetDebugUtilsObjectNameEXT_funcPtr;

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
        => xrCreateDebugUtilsMessengerEXT_funcPtr(instance, createInfo, messenger);
    private delegate* unmanaged<XrInstance, XrDebugUtilsMessengerCreateInfoEXT*, XrDebugUtilsMessengerEXT*, XrResult> xrCreateDebugUtilsMessengerEXT_funcPtr;

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
        => xrDestroyDebugUtilsMessengerEXT_funcPtr(messenger);
    private delegate* unmanaged<XrDebugUtilsMessengerEXT, XrResult> xrDestroyDebugUtilsMessengerEXT_funcPtr;

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
        => xrSubmitDebugUtilsMessageEXT_funcPtr(instance, messageSeverity, messageTypes, callbackData);
    private delegate* unmanaged<XrInstance, ulong, ulong, XrDebugUtilsMessengerCallbackDataEXT*, XrResult> xrSubmitDebugUtilsMessageEXT_funcPtr;

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
        => xrSessionBeginDebugUtilsLabelRegionEXT_funcPtr(session, labelInfo);
    private delegate* unmanaged<XrSession, XrDebugUtilsLabelEXT*, XrResult> xrSessionBeginDebugUtilsLabelRegionEXT_funcPtr;

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
        => xrSessionEndDebugUtilsLabelRegionEXT_funcPtr(session);
    private delegate* unmanaged<XrSession, XrResult> xrSessionEndDebugUtilsLabelRegionEXT_funcPtr;

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
        => xrSessionInsertDebugUtilsLabelEXT_funcPtr(session, labelInfo);
    private delegate* unmanaged<XrSession, XrDebugUtilsLabelEXT*, XrResult> xrSessionInsertDebugUtilsLabelEXT_funcPtr;

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
        => xrGetOpenGLGraphicsRequirementsKHR_funcPtr(instance, systemId, graphicsRequirements);
    private delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsOpenGLKHR*, XrResult> xrGetOpenGLGraphicsRequirementsKHR_funcPtr;

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
        => xrGetOpenGLESGraphicsRequirementsKHR_funcPtr(instance, systemId, graphicsRequirements);
    private delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsOpenGLESKHR*, XrResult> xrGetOpenGLESGraphicsRequirementsKHR_funcPtr;

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
        => xrGetVulkanInstanceExtensionsKHR_funcPtr(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);
    private delegate* unmanaged<XrInstance, ulong, uint, uint*, byte*, XrResult> xrGetVulkanInstanceExtensionsKHR_funcPtr;

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
        => xrGetVulkanDeviceExtensionsKHR_funcPtr(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);
    private delegate* unmanaged<XrInstance, ulong, uint, uint*, byte*, XrResult> xrGetVulkanDeviceExtensionsKHR_funcPtr;

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
    public XrResult xrGetVulkanGraphicsDeviceKHR(XrInstance instance, ulong systemId, nint vkInstance, nint* vkPhysicalDevice)
        => xrGetVulkanGraphicsDeviceKHR_funcPtr(instance, systemId, vkInstance, vkPhysicalDevice);
    private delegate* unmanaged<XrInstance, ulong, nint, nint*, XrResult> xrGetVulkanGraphicsDeviceKHR_funcPtr;

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
        => xrGetVulkanGraphicsRequirementsKHR_funcPtr(instance, systemId, graphicsRequirements);
    private delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsVulkanKHR*, XrResult> xrGetVulkanGraphicsRequirementsKHR_funcPtr;

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
        => xrGetD3D11GraphicsRequirementsKHR_funcPtr(instance, systemId, graphicsRequirements);
    private delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsD3D11KHR*, XrResult> xrGetD3D11GraphicsRequirementsKHR_funcPtr;

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
        => xrGetD3D12GraphicsRequirementsKHR_funcPtr(instance, systemId, graphicsRequirements);
    private delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsD3D12KHR*, XrResult> xrGetD3D12GraphicsRequirementsKHR_funcPtr;

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
        => xrGetVisibilityMaskKHR_funcPtr(session, viewConfigurationType, viewIndex, visibilityMaskType, visibilityMask);
    private delegate* unmanaged<XrSession, XrViewConfigurationType, uint, XrVisibilityMaskTypeKHR, XrVisibilityMaskKHR*, XrResult> xrGetVisibilityMaskKHR_funcPtr;

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
    public XrResult xrConvertWin32PerformanceCounterToTimeKHR(XrInstance instance, nint* performanceCounter, long* time)
        => xrConvertWin32PerformanceCounterToTimeKHR_funcPtr(instance, performanceCounter, time);
    private delegate* unmanaged<XrInstance, nint*, long*, XrResult> xrConvertWin32PerformanceCounterToTimeKHR_funcPtr;

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
    public XrResult xrConvertTimeToWin32PerformanceCounterKHR(XrInstance instance, long time, nint* performanceCounter)
        => xrConvertTimeToWin32PerformanceCounterKHR_funcPtr(instance, time, performanceCounter);
    private delegate* unmanaged<XrInstance, long, nint*, XrResult> xrConvertTimeToWin32PerformanceCounterKHR_funcPtr;

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
    public XrResult xrConvertTimespecTimeToTimeKHR(XrInstance instance, nint* timespecTime, long* time)
        => xrConvertTimespecTimeToTimeKHR_funcPtr(instance, timespecTime, time);
    private delegate* unmanaged<XrInstance, nint*, long*, XrResult> xrConvertTimespecTimeToTimeKHR_funcPtr;

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
    public XrResult xrConvertTimeToTimespecTimeKHR(XrInstance instance, long time, nint* timespecTime)
        => xrConvertTimeToTimespecTimeKHR_funcPtr(instance, time, timespecTime);
    private delegate* unmanaged<XrInstance, long, nint*, XrResult> xrConvertTimeToTimespecTimeKHR_funcPtr;

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
        => xrCreateSpatialAnchorMSFT_funcPtr(session, createInfo, anchor);
    private delegate* unmanaged<XrSession, XrSpatialAnchorCreateInfoMSFT*, XrSpatialAnchorMSFT*, XrResult> xrCreateSpatialAnchorMSFT_funcPtr;

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
        => xrCreateSpatialAnchorSpaceMSFT_funcPtr(session, createInfo, space);
    private delegate* unmanaged<XrSession, XrSpatialAnchorSpaceCreateInfoMSFT*, XrSpace*, XrResult> xrCreateSpatialAnchorSpaceMSFT_funcPtr;

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
        => xrDestroySpatialAnchorMSFT_funcPtr(anchor);
    private delegate* unmanaged<XrSpatialAnchorMSFT, XrResult> xrDestroySpatialAnchorMSFT_funcPtr;

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
        => xrSetInputDeviceActiveEXT_funcPtr(session, interactionProfile, topLevelPath, isActive);
    private delegate* unmanaged<XrSession, ulong, ulong, XrBool32, XrResult> xrSetInputDeviceActiveEXT_funcPtr;

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
        => xrSetInputDeviceStateBoolEXT_funcPtr(session, topLevelPath, inputSourcePath, state);
    private delegate* unmanaged<XrSession, ulong, ulong, XrBool32, XrResult> xrSetInputDeviceStateBoolEXT_funcPtr;

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
        => xrSetInputDeviceStateFloatEXT_funcPtr(session, topLevelPath, inputSourcePath, state);
    private delegate* unmanaged<XrSession, ulong, ulong, float, XrResult> xrSetInputDeviceStateFloatEXT_funcPtr;

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
        => xrSetInputDeviceStateVector2fEXT_funcPtr(session, topLevelPath, inputSourcePath, state);
    private delegate* unmanaged<XrSession, ulong, ulong, XrVector2f, XrResult> xrSetInputDeviceStateVector2fEXT_funcPtr;

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
        => xrSetInputDeviceLocationEXT_funcPtr(session, topLevelPath, inputSourcePath, space, pose);
    private delegate* unmanaged<XrSession, ulong, ulong, XrSpace, XrPosef, XrResult> xrSetInputDeviceLocationEXT_funcPtr;

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
        => xrCreateSpatialGraphNodeSpaceMSFT_funcPtr(session, createInfo, space);
    private delegate* unmanaged<XrSession, XrSpatialGraphNodeSpaceCreateInfoMSFT*, XrSpace*, XrResult> xrCreateSpatialGraphNodeSpaceMSFT_funcPtr;

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
        => xrTryCreateSpatialGraphStaticNodeBindingMSFT_funcPtr(session, createInfo, nodeBinding);
    private delegate* unmanaged<XrSession, XrSpatialGraphStaticNodeBindingCreateInfoMSFT*, XrSpatialGraphNodeBindingMSFT*, XrResult> xrTryCreateSpatialGraphStaticNodeBindingMSFT_funcPtr;

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
        => xrDestroySpatialGraphNodeBindingMSFT_funcPtr(nodeBinding);
    private delegate* unmanaged<XrSpatialGraphNodeBindingMSFT, XrResult> xrDestroySpatialGraphNodeBindingMSFT_funcPtr;

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
        => xrGetSpatialGraphNodeBindingPropertiesMSFT_funcPtr(nodeBinding, getInfo, properties);
    private delegate* unmanaged<XrSpatialGraphNodeBindingMSFT, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT*, XrSpatialGraphNodeBindingPropertiesMSFT*, XrResult> xrGetSpatialGraphNodeBindingPropertiesMSFT_funcPtr;

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
        => xrCreateHandTrackerEXT_funcPtr(session, createInfo, handTracker);
    private delegate* unmanaged<XrSession, XrHandTrackerCreateInfoEXT*, XrHandTrackerEXT*, XrResult> xrCreateHandTrackerEXT_funcPtr;

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
        => xrDestroyHandTrackerEXT_funcPtr(handTracker);
    private delegate* unmanaged<XrHandTrackerEXT, XrResult> xrDestroyHandTrackerEXT_funcPtr;

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
        => xrLocateHandJointsEXT_funcPtr(handTracker, locateInfo, locations);
    private delegate* unmanaged<XrHandTrackerEXT, XrHandJointsLocateInfoEXT*, XrHandJointLocationsEXT*, XrResult> xrLocateHandJointsEXT_funcPtr;

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
        => xrCreateHandMeshSpaceMSFT_funcPtr(handTracker, createInfo, space);
    private delegate* unmanaged<XrHandTrackerEXT, XrHandMeshSpaceCreateInfoMSFT*, XrSpace*, XrResult> xrCreateHandMeshSpaceMSFT_funcPtr;

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
        => xrUpdateHandMeshMSFT_funcPtr(handTracker, updateInfo, handMesh);
    private delegate* unmanaged<XrHandTrackerEXT, XrHandMeshUpdateInfoMSFT*, XrHandMeshMSFT*, XrResult> xrUpdateHandMeshMSFT_funcPtr;

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
        => xrGetControllerModelKeyMSFT_funcPtr(session, topLevelUserPath, controllerModelKeyState);
    private delegate* unmanaged<XrSession, ulong, XrControllerModelKeyStateMSFT*, XrResult> xrGetControllerModelKeyMSFT_funcPtr;

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
        => xrLoadControllerModelMSFT_funcPtr(session, modelKey, bufferCapacityInput, bufferCountOutput, buffer);
    private delegate* unmanaged<XrSession, ulong, uint, uint*, byte*, XrResult> xrLoadControllerModelMSFT_funcPtr;

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
        => xrGetControllerModelPropertiesMSFT_funcPtr(session, modelKey, properties);
    private delegate* unmanaged<XrSession, ulong, XrControllerModelPropertiesMSFT*, XrResult> xrGetControllerModelPropertiesMSFT_funcPtr;

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
        => xrGetControllerModelStateMSFT_funcPtr(session, modelKey, state);
    private delegate* unmanaged<XrSession, ulong, XrControllerModelStateMSFT*, XrResult> xrGetControllerModelStateMSFT_funcPtr;

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
    public XrResult xrCreateSpatialAnchorFromPerceptionAnchorMSFT(XrSession session, nint* perceptionAnchor, XrSpatialAnchorMSFT* anchor)
        => xrCreateSpatialAnchorFromPerceptionAnchorMSFT_funcPtr(session, perceptionAnchor, anchor);
    private delegate* unmanaged<XrSession, nint*, XrSpatialAnchorMSFT*, XrResult> xrCreateSpatialAnchorFromPerceptionAnchorMSFT_funcPtr;

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
    public XrResult xrTryGetPerceptionAnchorFromSpatialAnchorMSFT(XrSession session, XrSpatialAnchorMSFT anchor, nint** perceptionAnchor)
        => xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_funcPtr(session, anchor, perceptionAnchor);
    private delegate* unmanaged<XrSession, XrSpatialAnchorMSFT, nint**, XrResult> xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_funcPtr;

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
        => xrEnumerateReprojectionModesMSFT_funcPtr(instance, systemId, viewConfigurationType, modeCapacityInput, modeCountOutput, modes);
    private delegate* unmanaged<XrInstance, ulong, XrViewConfigurationType, uint, uint*, XrReprojectionModeMSFT*, XrResult> xrEnumerateReprojectionModesMSFT_funcPtr;

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
        => xrUpdateSwapchainFB_funcPtr(swapchain, state);
    private delegate* unmanaged<XrSwapchain, XrSwapchainStateBaseHeaderFB*, XrResult> xrUpdateSwapchainFB_funcPtr;

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
        => xrGetSwapchainStateFB_funcPtr(swapchain, state);
    private delegate* unmanaged<XrSwapchain, XrSwapchainStateBaseHeaderFB*, XrResult> xrGetSwapchainStateFB_funcPtr;

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
        => xrCreateBodyTrackerFB_funcPtr(session, createInfo, bodyTracker);
    private delegate* unmanaged<XrSession, XrBodyTrackerCreateInfoFB*, XrBodyTrackerFB*, XrResult> xrCreateBodyTrackerFB_funcPtr;

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
        => xrDestroyBodyTrackerFB_funcPtr(bodyTracker);
    private delegate* unmanaged<XrBodyTrackerFB, XrResult> xrDestroyBodyTrackerFB_funcPtr;

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
        => xrLocateBodyJointsFB_funcPtr(bodyTracker, locateInfo, locations);
    private delegate* unmanaged<XrBodyTrackerFB, XrBodyJointsLocateInfoFB*, XrBodyJointLocationsFB*, XrResult> xrLocateBodyJointsFB_funcPtr;

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
        => xrGetBodySkeletonFB_funcPtr(bodyTracker, skeleton);
    private delegate* unmanaged<XrBodyTrackerFB, XrBodySkeletonFB*, XrResult> xrGetBodySkeletonFB_funcPtr;

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
        => xrInitializeLoaderKHR_funcPtr(loaderInitInfo);
    private delegate* unmanaged<XrLoaderInitInfoBaseHeaderKHR*, XrResult> xrInitializeLoaderKHR_funcPtr;

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
    public XrResult xrCreateVulkanInstanceKHR(XrInstance instance, XrVulkanInstanceCreateInfoKHR* createInfo, nint* vulkanInstance, nint* vulkanResult)
        => xrCreateVulkanInstanceKHR_funcPtr(instance, createInfo, vulkanInstance, vulkanResult);
    private delegate* unmanaged<XrInstance, XrVulkanInstanceCreateInfoKHR*, nint*, nint*, XrResult> xrCreateVulkanInstanceKHR_funcPtr;

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
    public XrResult xrCreateVulkanDeviceKHR(XrInstance instance, XrVulkanDeviceCreateInfoKHR* createInfo, nint* vulkanDevice, nint* vulkanResult)
        => xrCreateVulkanDeviceKHR_funcPtr(instance, createInfo, vulkanDevice, vulkanResult);
    private delegate* unmanaged<XrInstance, XrVulkanDeviceCreateInfoKHR*, nint*, nint*, XrResult> xrCreateVulkanDeviceKHR_funcPtr;

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
    public XrResult xrGetVulkanGraphicsDevice2KHR(XrInstance instance, XrVulkanGraphicsDeviceGetInfoKHR* getInfo, nint* vulkanPhysicalDevice)
        => xrGetVulkanGraphicsDevice2KHR_funcPtr(instance, getInfo, vulkanPhysicalDevice);
    private delegate* unmanaged<XrInstance, XrVulkanGraphicsDeviceGetInfoKHR*, nint*, XrResult> xrGetVulkanGraphicsDevice2KHR_funcPtr;

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
        => xrEnumerateSceneComputeFeaturesMSFT_funcPtr(instance, systemId, featureCapacityInput, featureCountOutput, features);
    private delegate* unmanaged<XrInstance, ulong, uint, uint*, XrSceneComputeFeatureMSFT*, XrResult> xrEnumerateSceneComputeFeaturesMSFT_funcPtr;

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
        => xrCreateSceneObserverMSFT_funcPtr(session, createInfo, sceneObserver);
    private delegate* unmanaged<XrSession, XrSceneObserverCreateInfoMSFT*, XrSceneObserverMSFT*, XrResult> xrCreateSceneObserverMSFT_funcPtr;

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
        => xrDestroySceneObserverMSFT_funcPtr(sceneObserver);
    private delegate* unmanaged<XrSceneObserverMSFT, XrResult> xrDestroySceneObserverMSFT_funcPtr;

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
        => xrCreateSceneMSFT_funcPtr(sceneObserver, createInfo, scene);
    private delegate* unmanaged<XrSceneObserverMSFT, XrSceneCreateInfoMSFT*, XrSceneMSFT*, XrResult> xrCreateSceneMSFT_funcPtr;

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
        => xrDestroySceneMSFT_funcPtr(scene);
    private delegate* unmanaged<XrSceneMSFT, XrResult> xrDestroySceneMSFT_funcPtr;

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
        => xrComputeNewSceneMSFT_funcPtr(sceneObserver, computeInfo);
    private delegate* unmanaged<XrSceneObserverMSFT, XrNewSceneComputeInfoMSFT*, XrResult> xrComputeNewSceneMSFT_funcPtr;

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
        => xrGetSceneComputeStateMSFT_funcPtr(sceneObserver, state);
    private delegate* unmanaged<XrSceneObserverMSFT, XrSceneComputeStateMSFT*, XrResult> xrGetSceneComputeStateMSFT_funcPtr;

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
        => xrGetSceneComponentsMSFT_funcPtr(scene, getInfo, components);
    private delegate* unmanaged<XrSceneMSFT, XrSceneComponentsGetInfoMSFT*, XrSceneComponentsMSFT*, XrResult> xrGetSceneComponentsMSFT_funcPtr;

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
        => xrLocateSceneComponentsMSFT_funcPtr(scene, locateInfo, locations);
    private delegate* unmanaged<XrSceneMSFT, XrSceneComponentsLocateInfoMSFT*, XrSceneComponentLocationsMSFT*, XrResult> xrLocateSceneComponentsMSFT_funcPtr;

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
        => xrGetSceneMeshBuffersMSFT_funcPtr(scene, getInfo, buffers);
    private delegate* unmanaged<XrSceneMSFT, XrSceneMeshBuffersGetInfoMSFT*, XrSceneMeshBuffersMSFT*, XrResult> xrGetSceneMeshBuffersMSFT_funcPtr;

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
        => xrDeserializeSceneMSFT_funcPtr(sceneObserver, deserializeInfo);
    private delegate* unmanaged<XrSceneObserverMSFT, XrSceneDeserializeInfoMSFT*, XrResult> xrDeserializeSceneMSFT_funcPtr;

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
        => xrGetSerializedSceneFragmentDataMSFT_funcPtr(scene, getInfo, countInput, readOutput, buffer);
    private delegate* unmanaged<XrSceneMSFT, XrSerializedSceneFragmentDataGetInfoMSFT*, uint, uint*, byte*, XrResult> xrGetSerializedSceneFragmentDataMSFT_funcPtr;

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
        => xrEnumerateDisplayRefreshRatesFB_funcPtr(session, displayRefreshRateCapacityInput, displayRefreshRateCountOutput, displayRefreshRates);
    private delegate* unmanaged<XrSession, uint, uint*, float*, XrResult> xrEnumerateDisplayRefreshRatesFB_funcPtr;

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
        => xrGetDisplayRefreshRateFB_funcPtr(session, displayRefreshRate);
    private delegate* unmanaged<XrSession, float*, XrResult> xrGetDisplayRefreshRateFB_funcPtr;

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
        => xrRequestDisplayRefreshRateFB_funcPtr(session, displayRefreshRate);
    private delegate* unmanaged<XrSession, float, XrResult> xrRequestDisplayRefreshRateFB_funcPtr;

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
        => xrEnumerateViveTrackerPathsHTCX_funcPtr(instance, pathCapacityInput, pathCountOutput, paths);
    private delegate* unmanaged<XrInstance, uint, uint*, XrViveTrackerPathsHTCX*, XrResult> xrEnumerateViveTrackerPathsHTCX_funcPtr;

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
        => xrCreateFacialTrackerHTC_funcPtr(session, createInfo, facialTracker);
    private delegate* unmanaged<XrSession, XrFacialTrackerCreateInfoHTC*, XrFacialTrackerHTC*, XrResult> xrCreateFacialTrackerHTC_funcPtr;

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
        => xrDestroyFacialTrackerHTC_funcPtr(facialTracker);
    private delegate* unmanaged<XrFacialTrackerHTC, XrResult> xrDestroyFacialTrackerHTC_funcPtr;

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
        => xrGetFacialExpressionsHTC_funcPtr(facialTracker, facialExpressions);
    private delegate* unmanaged<XrFacialTrackerHTC, XrFacialExpressionsHTC*, XrResult> xrGetFacialExpressionsHTC_funcPtr;

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
        => xrEnumerateColorSpacesFB_funcPtr(session, colorSpaceCapacityInput, colorSpaceCountOutput, colorSpaces);
    private delegate* unmanaged<XrSession, uint, uint*, XrColorSpaceFB*, XrResult> xrEnumerateColorSpacesFB_funcPtr;

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
        => xrSetColorSpaceFB_funcPtr(session, colorSpace);
    private delegate* unmanaged<XrSession, XrColorSpaceFB, XrResult> xrSetColorSpaceFB_funcPtr;

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
        => xrGetHandMeshFB_funcPtr(handTracker, mesh);
    private delegate* unmanaged<XrHandTrackerEXT, XrHandTrackingMeshFB*, XrResult> xrGetHandMeshFB_funcPtr;

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
        => xrCreateSpatialAnchorFB_funcPtr(session, info, requestId);
    private delegate* unmanaged<XrSession, XrSpatialAnchorCreateInfoFB*, ulong*, XrResult> xrCreateSpatialAnchorFB_funcPtr;

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
        => xrGetSpaceUuidFB_funcPtr(space, uuid);
    private delegate* unmanaged<XrSpace, XrUuidEXT*, XrResult> xrGetSpaceUuidFB_funcPtr;

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
        => xrEnumerateSpaceSupportedComponentsFB_funcPtr(space, componentTypeCapacityInput, componentTypeCountOutput, componentTypes);
    private delegate* unmanaged<XrSpace, uint, uint*, XrSpaceComponentTypeFB*, XrResult> xrEnumerateSpaceSupportedComponentsFB_funcPtr;

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
        => xrSetSpaceComponentStatusFB_funcPtr(space, info, requestId);
    private delegate* unmanaged<XrSpace, XrSpaceComponentStatusSetInfoFB*, ulong*, XrResult> xrSetSpaceComponentStatusFB_funcPtr;

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
        => xrGetSpaceComponentStatusFB_funcPtr(space, componentType, status);
    private delegate* unmanaged<XrSpace, XrSpaceComponentTypeFB, XrSpaceComponentStatusFB*, XrResult> xrGetSpaceComponentStatusFB_funcPtr;

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
        => xrCreateFoveationProfileFB_funcPtr(session, createInfo, profile);
    private delegate* unmanaged<XrSession, XrFoveationProfileCreateInfoFB*, XrFoveationProfileFB*, XrResult> xrCreateFoveationProfileFB_funcPtr;

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
        => xrDestroyFoveationProfileFB_funcPtr(profile);
    private delegate* unmanaged<XrFoveationProfileFB, XrResult> xrDestroyFoveationProfileFB_funcPtr;

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
        => xrQuerySystemTrackedKeyboardFB_funcPtr(session, queryInfo, keyboard);
    private delegate* unmanaged<XrSession, XrKeyboardTrackingQueryFB*, XrKeyboardTrackingDescriptionFB*, XrResult> xrQuerySystemTrackedKeyboardFB_funcPtr;

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
        => xrCreateKeyboardSpaceFB_funcPtr(session, createInfo, keyboardSpace);
    private delegate* unmanaged<XrSession, XrKeyboardSpaceCreateInfoFB*, XrSpace*, XrResult> xrCreateKeyboardSpaceFB_funcPtr;

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
        => xrCreateTriangleMeshFB_funcPtr(session, createInfo, outTriangleMesh);
    private delegate* unmanaged<XrSession, XrTriangleMeshCreateInfoFB*, XrTriangleMeshFB*, XrResult> xrCreateTriangleMeshFB_funcPtr;

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
        => xrDestroyTriangleMeshFB_funcPtr(mesh);
    private delegate* unmanaged<XrTriangleMeshFB, XrResult> xrDestroyTriangleMeshFB_funcPtr;

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
        => xrTriangleMeshGetVertexBufferFB_funcPtr(mesh, outVertexBuffer);
    private delegate* unmanaged<XrTriangleMeshFB, XrVector3f**, XrResult> xrTriangleMeshGetVertexBufferFB_funcPtr;

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
        => xrTriangleMeshGetIndexBufferFB_funcPtr(mesh, outIndexBuffer);
    private delegate* unmanaged<XrTriangleMeshFB, uint**, XrResult> xrTriangleMeshGetIndexBufferFB_funcPtr;

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
        => xrTriangleMeshBeginUpdateFB_funcPtr(mesh);
    private delegate* unmanaged<XrTriangleMeshFB, XrResult> xrTriangleMeshBeginUpdateFB_funcPtr;

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
        => xrTriangleMeshEndUpdateFB_funcPtr(mesh, vertexCount, triangleCount);
    private delegate* unmanaged<XrTriangleMeshFB, uint, uint, XrResult> xrTriangleMeshEndUpdateFB_funcPtr;

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
        => xrTriangleMeshBeginVertexBufferUpdateFB_funcPtr(mesh, outVertexCount);
    private delegate* unmanaged<XrTriangleMeshFB, uint*, XrResult> xrTriangleMeshBeginVertexBufferUpdateFB_funcPtr;

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
        => xrTriangleMeshEndVertexBufferUpdateFB_funcPtr(mesh);
    private delegate* unmanaged<XrTriangleMeshFB, XrResult> xrTriangleMeshEndVertexBufferUpdateFB_funcPtr;

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
        => xrCreatePassthroughFB_funcPtr(session, createInfo, outPassthrough);
    private delegate* unmanaged<XrSession, XrPassthroughCreateInfoFB*, XrPassthroughFB*, XrResult> xrCreatePassthroughFB_funcPtr;

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
        => xrDestroyPassthroughFB_funcPtr(passthrough);
    private delegate* unmanaged<XrPassthroughFB, XrResult> xrDestroyPassthroughFB_funcPtr;

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
        => xrPassthroughStartFB_funcPtr(passthrough);
    private delegate* unmanaged<XrPassthroughFB, XrResult> xrPassthroughStartFB_funcPtr;

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
        => xrPassthroughPauseFB_funcPtr(passthrough);
    private delegate* unmanaged<XrPassthroughFB, XrResult> xrPassthroughPauseFB_funcPtr;

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
        => xrCreatePassthroughLayerFB_funcPtr(session, createInfo, outLayer);
    private delegate* unmanaged<XrSession, XrPassthroughLayerCreateInfoFB*, XrPassthroughLayerFB*, XrResult> xrCreatePassthroughLayerFB_funcPtr;

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
        => xrDestroyPassthroughLayerFB_funcPtr(layer);
    private delegate* unmanaged<XrPassthroughLayerFB, XrResult> xrDestroyPassthroughLayerFB_funcPtr;

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
        => xrPassthroughLayerPauseFB_funcPtr(layer);
    private delegate* unmanaged<XrPassthroughLayerFB, XrResult> xrPassthroughLayerPauseFB_funcPtr;

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
        => xrPassthroughLayerResumeFB_funcPtr(layer);
    private delegate* unmanaged<XrPassthroughLayerFB, XrResult> xrPassthroughLayerResumeFB_funcPtr;

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
        => xrPassthroughLayerSetStyleFB_funcPtr(layer, style);
    private delegate* unmanaged<XrPassthroughLayerFB, XrPassthroughStyleFB*, XrResult> xrPassthroughLayerSetStyleFB_funcPtr;

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
        => xrCreateGeometryInstanceFB_funcPtr(session, createInfo, outGeometryInstance);
    private delegate* unmanaged<XrSession, XrGeometryInstanceCreateInfoFB*, XrGeometryInstanceFB*, XrResult> xrCreateGeometryInstanceFB_funcPtr;

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
        => xrDestroyGeometryInstanceFB_funcPtr(instance);
    private delegate* unmanaged<XrGeometryInstanceFB, XrResult> xrDestroyGeometryInstanceFB_funcPtr;

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
        => xrGeometryInstanceSetTransformFB_funcPtr(instance, transformation);
    private delegate* unmanaged<XrGeometryInstanceFB, XrGeometryInstanceTransformFB*, XrResult> xrGeometryInstanceSetTransformFB_funcPtr;

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
        => xrEnumerateRenderModelPathsFB_funcPtr(session, pathCapacityInput, pathCountOutput, paths);
    private delegate* unmanaged<XrSession, uint, uint*, XrRenderModelPathInfoFB*, XrResult> xrEnumerateRenderModelPathsFB_funcPtr;

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
        => xrGetRenderModelPropertiesFB_funcPtr(session, path, properties);
    private delegate* unmanaged<XrSession, ulong, XrRenderModelPropertiesFB*, XrResult> xrGetRenderModelPropertiesFB_funcPtr;

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
        => xrLoadRenderModelFB_funcPtr(session, info, buffer);
    private delegate* unmanaged<XrSession, XrRenderModelLoadInfoFB*, XrRenderModelBufferFB*, XrResult> xrLoadRenderModelFB_funcPtr;

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
        => xrSetEnvironmentDepthEstimationVARJO_funcPtr(session, enabled);
    private delegate* unmanaged<XrSession, XrBool32, XrResult> xrSetEnvironmentDepthEstimationVARJO_funcPtr;

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
        => xrSetMarkerTrackingVARJO_funcPtr(session, enabled);
    private delegate* unmanaged<XrSession, XrBool32, XrResult> xrSetMarkerTrackingVARJO_funcPtr;

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
        => xrSetMarkerTrackingTimeoutVARJO_funcPtr(session, markerId, timeout);
    private delegate* unmanaged<XrSession, ulong, long, XrResult> xrSetMarkerTrackingTimeoutVARJO_funcPtr;

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
        => xrSetMarkerTrackingPredictionVARJO_funcPtr(session, markerId, enable);
    private delegate* unmanaged<XrSession, ulong, XrBool32, XrResult> xrSetMarkerTrackingPredictionVARJO_funcPtr;

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
        => xrGetMarkerSizeVARJO_funcPtr(session, markerId, size);
    private delegate* unmanaged<XrSession, ulong, XrExtent2Df*, XrResult> xrGetMarkerSizeVARJO_funcPtr;

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
        => xrCreateMarkerSpaceVARJO_funcPtr(session, createInfo, space);
    private delegate* unmanaged<XrSession, XrMarkerSpaceCreateInfoVARJO*, XrSpace*, XrResult> xrCreateMarkerSpaceVARJO_funcPtr;

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
        => xrSetViewOffsetVARJO_funcPtr(session, offset);
    private delegate* unmanaged<XrSession, float, XrResult> xrSetViewOffsetVARJO_funcPtr;

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
        => xrCreateSpaceFromCoordinateFrameUIDML_funcPtr(session, createInfo, space);
    private delegate* unmanaged<XrSession, XrCoordinateSpaceCreateInfoML, XrSpace*, XrResult> xrCreateSpaceFromCoordinateFrameUIDML_funcPtr;

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
        => xrCreateSpatialAnchorStoreConnectionMSFT_funcPtr(session, spatialAnchorStore);
    private delegate* unmanaged<XrSession, XrSpatialAnchorStoreConnectionMSFT*, XrResult> xrCreateSpatialAnchorStoreConnectionMSFT_funcPtr;

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
        => xrDestroySpatialAnchorStoreConnectionMSFT_funcPtr(spatialAnchorStore);
    private delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrResult> xrDestroySpatialAnchorStoreConnectionMSFT_funcPtr;

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
        => xrPersistSpatialAnchorMSFT_funcPtr(spatialAnchorStore, spatialAnchorPersistenceInfo);
    private delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrSpatialAnchorPersistenceInfoMSFT*, XrResult> xrPersistSpatialAnchorMSFT_funcPtr;

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
        => xrEnumeratePersistedSpatialAnchorNamesMSFT_funcPtr(spatialAnchorStore, spatialAnchorNamesCapacityInput, spatialAnchorNamesCountOutput, persistedAnchorNames);
    private delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, uint, uint*, XrSpatialAnchorPersistenceNameMSFT*, XrResult> xrEnumeratePersistedSpatialAnchorNamesMSFT_funcPtr;

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
        => xrCreateSpatialAnchorFromPersistedNameMSFT_funcPtr(session, spatialAnchorCreateInfo, spatialAnchor);
    private delegate* unmanaged<XrSession, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT*, XrSpatialAnchorMSFT*, XrResult> xrCreateSpatialAnchorFromPersistedNameMSFT_funcPtr;

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
        => xrUnpersistSpatialAnchorMSFT_funcPtr(spatialAnchorStore, spatialAnchorPersistenceName);
    private delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrSpatialAnchorPersistenceNameMSFT*, XrResult> xrUnpersistSpatialAnchorMSFT_funcPtr;

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
        => xrClearSpatialAnchorStoreMSFT_funcPtr(spatialAnchorStore);
    private delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrResult> xrClearSpatialAnchorStoreMSFT_funcPtr;

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
        => xrQuerySpacesFB_funcPtr(session, info, requestId);
    private delegate* unmanaged<XrSession, XrSpaceQueryInfoBaseHeaderFB*, ulong*, XrResult> xrQuerySpacesFB_funcPtr;

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
        => xrRetrieveSpaceQueryResultsFB_funcPtr(session, requestId, results);
    private delegate* unmanaged<XrSession, ulong, XrSpaceQueryResultsFB*, XrResult> xrRetrieveSpaceQueryResultsFB_funcPtr;

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
        => xrSaveSpaceFB_funcPtr(session, info, requestId);
    private delegate* unmanaged<XrSession, XrSpaceSaveInfoFB*, ulong*, XrResult> xrSaveSpaceFB_funcPtr;

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
        => xrEraseSpaceFB_funcPtr(session, info, requestId);
    private delegate* unmanaged<XrSession, XrSpaceEraseInfoFB*, ulong*, XrResult> xrEraseSpaceFB_funcPtr;

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
        => xrGetAudioOutputDeviceGuidOculus_funcPtr(instance, buffer);
    private delegate* unmanaged<XrInstance, string, XrResult> xrGetAudioOutputDeviceGuidOculus_funcPtr;

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
        => xrGetAudioInputDeviceGuidOculus_funcPtr(instance, buffer);
    private delegate* unmanaged<XrInstance, string, XrResult> xrGetAudioInputDeviceGuidOculus_funcPtr;

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
        => xrShareSpacesFB_funcPtr(session, info, requestId);
    private delegate* unmanaged<XrSession, XrSpaceShareInfoFB*, ulong*, XrResult> xrShareSpacesFB_funcPtr;

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
        => xrGetSpaceBoundingBox2DFB_funcPtr(session, space, boundingBox2DOutput);
    private delegate* unmanaged<XrSession, XrSpace, XrRect2Df*, XrResult> xrGetSpaceBoundingBox2DFB_funcPtr;

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
        => xrGetSpaceBoundingBox3DFB_funcPtr(session, space, boundingBox3DOutput);
    private delegate* unmanaged<XrSession, XrSpace, XrRect3DfFB*, XrResult> xrGetSpaceBoundingBox3DFB_funcPtr;

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
        => xrGetSpaceSemanticLabelsFB_funcPtr(session, space, semanticLabelsOutput);
    private delegate* unmanaged<XrSession, XrSpace, XrSemanticLabelsFB*, XrResult> xrGetSpaceSemanticLabelsFB_funcPtr;

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
        => xrGetSpaceBoundary2DFB_funcPtr(session, space, boundary2DOutput);
    private delegate* unmanaged<XrSession, XrSpace, XrBoundary2DFB*, XrResult> xrGetSpaceBoundary2DFB_funcPtr;

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
        => xrGetSpaceRoomLayoutFB_funcPtr(session, space, roomLayoutOutput);
    private delegate* unmanaged<XrSession, XrSpace, XrRoomLayoutFB*, XrResult> xrGetSpaceRoomLayoutFB_funcPtr;

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
        => xrSetDigitalLensControlALMALENCE_funcPtr(session, digitalLensControl);
    private delegate* unmanaged<XrSession, XrDigitalLensControlALMALENCE*, XrResult> xrSetDigitalLensControlALMALENCE_funcPtr;

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
        => xrRequestSceneCaptureFB_funcPtr(session, info, requestId);
    private delegate* unmanaged<XrSession, XrSceneCaptureRequestInfoFB*, ulong*, XrResult> xrRequestSceneCaptureFB_funcPtr;

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
        => xrGetSpaceContainerFB_funcPtr(session, space, spaceContainerOutput);
    private delegate* unmanaged<XrSession, XrSpace, XrSpaceContainerFB*, XrResult> xrGetSpaceContainerFB_funcPtr;

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
        => xrGetFoveationEyeTrackedStateMETA_funcPtr(session, foveationState);
    private delegate* unmanaged<XrSession, XrFoveationEyeTrackedStateMETA*, XrResult> xrGetFoveationEyeTrackedStateMETA_funcPtr;

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
        => xrCreateFaceTrackerFB_funcPtr(session, createInfo, faceTracker);
    private delegate* unmanaged<XrSession, XrFaceTrackerCreateInfoFB*, XrFaceTrackerFB*, XrResult> xrCreateFaceTrackerFB_funcPtr;

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
        => xrDestroyFaceTrackerFB_funcPtr(faceTracker);
    private delegate* unmanaged<XrFaceTrackerFB, XrResult> xrDestroyFaceTrackerFB_funcPtr;

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
        => xrGetFaceExpressionWeightsFB_funcPtr(faceTracker, expressionInfo, expressionWeights);
    private delegate* unmanaged<XrFaceTrackerFB, XrFaceExpressionInfoFB*, XrFaceExpressionWeightsFB*, XrResult> xrGetFaceExpressionWeightsFB_funcPtr;

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
        => xrCreateEyeTrackerFB_funcPtr(session, createInfo, eyeTracker);
    private delegate* unmanaged<XrSession, XrEyeTrackerCreateInfoFB*, XrEyeTrackerFB*, XrResult> xrCreateEyeTrackerFB_funcPtr;

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
        => xrDestroyEyeTrackerFB_funcPtr(eyeTracker);
    private delegate* unmanaged<XrEyeTrackerFB, XrResult> xrDestroyEyeTrackerFB_funcPtr;

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
        => xrGetEyeGazesFB_funcPtr(eyeTracker, gazeInfo, eyeGazes);
    private delegate* unmanaged<XrEyeTrackerFB, XrEyeGazesInfoFB*, XrEyeGazesFB*, XrResult> xrGetEyeGazesFB_funcPtr;

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
        => xrPassthroughLayerSetKeyboardHandsIntensityFB_funcPtr(layer, intensity);
    private delegate* unmanaged<XrPassthroughLayerFB, XrPassthroughKeyboardHandsIntensityFB*, XrResult> xrPassthroughLayerSetKeyboardHandsIntensityFB_funcPtr;

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
        => xrGetDeviceSampleRateFB_funcPtr(session, hapticActionInfo, deviceSampleRate);
    private delegate* unmanaged<XrSession, XrHapticActionInfo*, XrDevicePcmSampleRateStateFB*, XrResult> xrGetDeviceSampleRateFB_funcPtr;

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
        => xrGetPassthroughPreferencesMETA_funcPtr(session, preferences);
    private delegate* unmanaged<XrSession, XrPassthroughPreferencesMETA*, XrResult> xrGetPassthroughPreferencesMETA_funcPtr;

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
        => xrCreateVirtualKeyboardMETA_funcPtr(session, createInfo, keyboard);
    private delegate* unmanaged<XrSession, XrVirtualKeyboardCreateInfoMETA*, XrVirtualKeyboardMETA*, XrResult> xrCreateVirtualKeyboardMETA_funcPtr;

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
        => xrDestroyVirtualKeyboardMETA_funcPtr(keyboard);
    private delegate* unmanaged<XrVirtualKeyboardMETA, XrResult> xrDestroyVirtualKeyboardMETA_funcPtr;

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
        => xrCreateVirtualKeyboardSpaceMETA_funcPtr(session, keyboard, createInfo, keyboardSpace);
    private delegate* unmanaged<XrSession, XrVirtualKeyboardMETA, XrVirtualKeyboardSpaceCreateInfoMETA*, XrSpace*, XrResult> xrCreateVirtualKeyboardSpaceMETA_funcPtr;

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
        => xrSuggestVirtualKeyboardLocationMETA_funcPtr(keyboard, locationInfo);
    private delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardLocationInfoMETA*, XrResult> xrSuggestVirtualKeyboardLocationMETA_funcPtr;

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
        => xrGetVirtualKeyboardScaleMETA_funcPtr(keyboard, scale);
    private delegate* unmanaged<XrVirtualKeyboardMETA, float*, XrResult> xrGetVirtualKeyboardScaleMETA_funcPtr;

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
        => xrSetVirtualKeyboardModelVisibilityMETA_funcPtr(keyboard, modelVisibility);
    private delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardModelVisibilitySetInfoMETA*, XrResult> xrSetVirtualKeyboardModelVisibilityMETA_funcPtr;

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
        => xrGetVirtualKeyboardModelAnimationStatesMETA_funcPtr(keyboard, animationStates);
    private delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardModelAnimationStatesMETA*, XrResult> xrGetVirtualKeyboardModelAnimationStatesMETA_funcPtr;

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
        => xrGetVirtualKeyboardDirtyTexturesMETA_funcPtr(keyboard, textureIdCapacityInput, textureIdCountOutput, textureIds);
    private delegate* unmanaged<XrVirtualKeyboardMETA, uint, uint*, ulong*, XrResult> xrGetVirtualKeyboardDirtyTexturesMETA_funcPtr;

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
        => xrGetVirtualKeyboardTextureDataMETA_funcPtr(keyboard, textureId, textureData);
    private delegate* unmanaged<XrVirtualKeyboardMETA, ulong, XrVirtualKeyboardTextureDataMETA*, XrResult> xrGetVirtualKeyboardTextureDataMETA_funcPtr;

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
        => xrSendVirtualKeyboardInputMETA_funcPtr(keyboard, info, interactorRootPose);
    private delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardInputInfoMETA*, XrPosef*, XrResult> xrSendVirtualKeyboardInputMETA_funcPtr;

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
        => xrChangeVirtualKeyboardTextContextMETA_funcPtr(keyboard, changeInfo);
    private delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardTextContextChangeInfoMETA*, XrResult> xrChangeVirtualKeyboardTextContextMETA_funcPtr;

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
        => xrEnumerateExternalCamerasOCULUS_funcPtr(session, cameraCapacityInput, cameraCountOutput, cameras);
    private delegate* unmanaged<XrSession, uint, uint*, XrExternalCameraOCULUS*, XrResult> xrEnumerateExternalCamerasOCULUS_funcPtr;

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
        => xrEnumeratePerformanceMetricsCounterPathsMETA_funcPtr(instance, counterPathCapacityInput, counterPathCountOutput, counterPaths);
    private delegate* unmanaged<XrInstance, uint, uint*, ulong*, XrResult> xrEnumeratePerformanceMetricsCounterPathsMETA_funcPtr;

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
        => xrSetPerformanceMetricsStateMETA_funcPtr(session, state);
    private delegate* unmanaged<XrSession, XrPerformanceMetricsStateMETA*, XrResult> xrSetPerformanceMetricsStateMETA_funcPtr;

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
        => xrGetPerformanceMetricsStateMETA_funcPtr(session, state);
    private delegate* unmanaged<XrSession, XrPerformanceMetricsStateMETA*, XrResult> xrGetPerformanceMetricsStateMETA_funcPtr;

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
        => xrQueryPerformanceMetricsCounterMETA_funcPtr(session, counterPath, counter);
    private delegate* unmanaged<XrSession, ulong, XrPerformanceMetricsCounterMETA*, XrResult> xrQueryPerformanceMetricsCounterMETA_funcPtr;

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
        => xrSaveSpaceListFB_funcPtr(session, info, requestId);
    private delegate* unmanaged<XrSession, XrSpaceListSaveInfoFB*, ulong*, XrResult> xrSaveSpaceListFB_funcPtr;

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
        => xrCreateSpaceUserFB_funcPtr(session, info, user);
    private delegate* unmanaged<XrSession, XrSpaceUserCreateInfoFB*, XrSpaceUserFB*, XrResult> xrCreateSpaceUserFB_funcPtr;

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
        => xrGetSpaceUserIdFB_funcPtr(user, userId);
    private delegate* unmanaged<XrSpaceUserFB, ulong*, XrResult> xrGetSpaceUserIdFB_funcPtr;

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
        => xrDestroySpaceUserFB_funcPtr(user);
    private delegate* unmanaged<XrSpaceUserFB, XrResult> xrDestroySpaceUserFB_funcPtr;

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
        => xrCreatePassthroughColorLutMETA_funcPtr(passthrough, createInfo, colorLut);
    private delegate* unmanaged<XrPassthroughFB, XrPassthroughColorLutCreateInfoMETA*, XrPassthroughColorLutMETA*, XrResult> xrCreatePassthroughColorLutMETA_funcPtr;

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
        => xrDestroyPassthroughColorLutMETA_funcPtr(colorLut);
    private delegate* unmanaged<XrPassthroughColorLutMETA, XrResult> xrDestroyPassthroughColorLutMETA_funcPtr;

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
        => xrUpdatePassthroughColorLutMETA_funcPtr(colorLut, updateInfo);
    private delegate* unmanaged<XrPassthroughColorLutMETA, XrPassthroughColorLutUpdateInfoMETA*, XrResult> xrUpdatePassthroughColorLutMETA_funcPtr;

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
        => xrSetTrackingOptimizationSettingsHintQCOM_funcPtr(session, domain, hint);
    private delegate* unmanaged<XrSession, XrTrackingOptimizationSettingsDomainQCOM, XrTrackingOptimizationSettingsHintQCOM, XrResult> xrSetTrackingOptimizationSettingsHintQCOM_funcPtr;

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
        => xrCreatePassthroughHTC_funcPtr(session, createInfo, passthrough);
    private delegate* unmanaged<XrSession, XrPassthroughCreateInfoHTC*, XrPassthroughHTC*, XrResult> xrCreatePassthroughHTC_funcPtr;

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
        => xrDestroyPassthroughHTC_funcPtr(passthrough);
    private delegate* unmanaged<XrPassthroughHTC, XrResult> xrDestroyPassthroughHTC_funcPtr;

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
        => xrApplyFoveationHTC_funcPtr(session, applyInfo);
    private delegate* unmanaged<XrSession, XrFoveationApplyInfoHTC*, XrResult> xrApplyFoveationHTC_funcPtr;

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
        => xrApplyForceFeedbackCurlMNDX_funcPtr(handTracker, locations);
    private delegate* unmanaged<XrHandTrackerEXT, XrForceFeedbackCurlApplyLocationsMNDX*, XrResult> xrApplyForceFeedbackCurlMNDX_funcPtr;

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
        => xrCreatePlaneDetectorEXT_funcPtr(session, createInfo, planeDetector);
    private delegate* unmanaged<XrSession, XrPlaneDetectorCreateInfoEXT*, XrPlaneDetectorEXT*, XrResult> xrCreatePlaneDetectorEXT_funcPtr;

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
        => xrDestroyPlaneDetectorEXT_funcPtr(planeDetector);
    private delegate* unmanaged<XrPlaneDetectorEXT, XrResult> xrDestroyPlaneDetectorEXT_funcPtr;

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
        => xrBeginPlaneDetectionEXT_funcPtr(planeDetector, beginInfo);
    private delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectorBeginInfoEXT*, XrResult> xrBeginPlaneDetectionEXT_funcPtr;

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
        => xrGetPlaneDetectionStateEXT_funcPtr(planeDetector, state);
    private delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectionStateEXT*, XrResult> xrGetPlaneDetectionStateEXT_funcPtr;

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
        => xrGetPlaneDetectionsEXT_funcPtr(planeDetector, info, locations);
    private delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectorGetInfoEXT*, XrPlaneDetectorLocationsEXT*, XrResult> xrGetPlaneDetectionsEXT_funcPtr;

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
        => xrGetPlanePolygonBufferEXT_funcPtr(planeDetector, planeId, polygonBufferIndex, polygonBuffer);
    private delegate* unmanaged<XrPlaneDetectorEXT, ulong, uint, XrPlaneDetectorPolygonBufferEXT*, XrResult> xrGetPlanePolygonBufferEXT_funcPtr;

    public void LoadFunctionPointers()
    {
        if (HasExtensionEnabled("XR_KHR_android_thread_settings"u8))
        {
            xrSetAndroidApplicationThreadKHR_funcPtr = (delegate* unmanaged<XrSession, XrAndroidThreadTypeKHR, uint, XrResult>)GetFunctionPointer("xrSetAndroidApplicationThreadKHR"u8);
        }
        if (HasExtensionEnabled("XR_KHR_android_surface_swapchain"u8))
        {
            xrCreateSwapchainAndroidSurfaceKHR_funcPtr = (delegate* unmanaged<XrSession, XrSwapchainCreateInfo*, XrSwapchain*, nint*, XrResult>)GetFunctionPointer("xrCreateSwapchainAndroidSurfaceKHR"u8);
        }
        if (HasExtensionEnabled("XR_EXT_performance_settings"u8))
        {
            xrPerfSettingsSetPerformanceLevelEXT_funcPtr = (delegate* unmanaged<XrSession, XrPerfSettingsDomainEXT, XrPerfSettingsLevelEXT, XrResult>)GetFunctionPointer("xrPerfSettingsSetPerformanceLevelEXT"u8);
        }
        if (HasExtensionEnabled("XR_EXT_thermal_query"u8))
        {
            xrThermalGetTemperatureTrendEXT_funcPtr = (delegate* unmanaged<XrSession, XrPerfSettingsDomainEXT, XrPerfSettingsNotificationLevelEXT*, float*, float*, XrResult>)GetFunctionPointer("xrThermalGetTemperatureTrendEXT"u8);
        }
        if (HasExtensionEnabled("XR_EXT_debug_utils"u8))
        {
            xrSetDebugUtilsObjectNameEXT_funcPtr = (delegate* unmanaged<XrInstance, XrDebugUtilsObjectNameInfoEXT*, XrResult>)GetFunctionPointer("xrSetDebugUtilsObjectNameEXT"u8);
            xrCreateDebugUtilsMessengerEXT_funcPtr = (delegate* unmanaged<XrInstance, XrDebugUtilsMessengerCreateInfoEXT*, XrDebugUtilsMessengerEXT*, XrResult>)GetFunctionPointer("xrCreateDebugUtilsMessengerEXT"u8);
            xrDestroyDebugUtilsMessengerEXT_funcPtr = (delegate* unmanaged<XrDebugUtilsMessengerEXT, XrResult>)GetFunctionPointer("xrDestroyDebugUtilsMessengerEXT"u8);
            xrSubmitDebugUtilsMessageEXT_funcPtr = (delegate* unmanaged<XrInstance, ulong, ulong, XrDebugUtilsMessengerCallbackDataEXT*, XrResult>)GetFunctionPointer("xrSubmitDebugUtilsMessageEXT"u8);
            xrSessionBeginDebugUtilsLabelRegionEXT_funcPtr = (delegate* unmanaged<XrSession, XrDebugUtilsLabelEXT*, XrResult>)GetFunctionPointer("xrSessionBeginDebugUtilsLabelRegionEXT"u8);
            xrSessionEndDebugUtilsLabelRegionEXT_funcPtr = (delegate* unmanaged<XrSession, XrResult>)GetFunctionPointer("xrSessionEndDebugUtilsLabelRegionEXT"u8);
            xrSessionInsertDebugUtilsLabelEXT_funcPtr = (delegate* unmanaged<XrSession, XrDebugUtilsLabelEXT*, XrResult>)GetFunctionPointer("xrSessionInsertDebugUtilsLabelEXT"u8);
        }
        if (HasExtensionEnabled("XR_KHR_opengl_enable"u8))
        {
            xrGetOpenGLGraphicsRequirementsKHR_funcPtr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsOpenGLKHR*, XrResult>)GetFunctionPointer("xrGetOpenGLGraphicsRequirementsKHR"u8);
        }
        if (HasExtensionEnabled("XR_KHR_opengl_es_enable"u8))
        {
            xrGetOpenGLESGraphicsRequirementsKHR_funcPtr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsOpenGLESKHR*, XrResult>)GetFunctionPointer("xrGetOpenGLESGraphicsRequirementsKHR"u8);
        }
        if (HasExtensionEnabled("XR_KHR_vulkan_enable"u8))
        {
            xrGetVulkanInstanceExtensionsKHR_funcPtr = (delegate* unmanaged<XrInstance, ulong, uint, uint*, byte*, XrResult>)GetFunctionPointer("xrGetVulkanInstanceExtensionsKHR"u8);
            xrGetVulkanDeviceExtensionsKHR_funcPtr = (delegate* unmanaged<XrInstance, ulong, uint, uint*, byte*, XrResult>)GetFunctionPointer("xrGetVulkanDeviceExtensionsKHR"u8);
            xrGetVulkanGraphicsDeviceKHR_funcPtr = (delegate* unmanaged<XrInstance, ulong, nint, nint*, XrResult>)GetFunctionPointer("xrGetVulkanGraphicsDeviceKHR"u8);
            xrGetVulkanGraphicsRequirementsKHR_funcPtr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsVulkanKHR*, XrResult>)GetFunctionPointer("xrGetVulkanGraphicsRequirementsKHR"u8);
        }
        if (HasExtensionEnabled("XR_KHR_D3D11_enable"u8))
        {
            xrGetD3D11GraphicsRequirementsKHR_funcPtr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsD3D11KHR*, XrResult>)GetFunctionPointer("xrGetD3D11GraphicsRequirementsKHR"u8);
        }
        if (HasExtensionEnabled("XR_KHR_D3D12_enable"u8))
        {
            xrGetD3D12GraphicsRequirementsKHR_funcPtr = (delegate* unmanaged<XrInstance, ulong, XrGraphicsRequirementsD3D12KHR*, XrResult>)GetFunctionPointer("xrGetD3D12GraphicsRequirementsKHR"u8);
        }
        if (HasExtensionEnabled("XR_KHR_visibility_mask"u8))
        {
            xrGetVisibilityMaskKHR_funcPtr = (delegate* unmanaged<XrSession, XrViewConfigurationType, uint, XrVisibilityMaskTypeKHR, XrVisibilityMaskKHR*, XrResult>)GetFunctionPointer("xrGetVisibilityMaskKHR"u8);
        }
        if (HasExtensionEnabled("XR_KHR_win32_convert_performance_counter_time"u8))
        {
            xrConvertWin32PerformanceCounterToTimeKHR_funcPtr = (delegate* unmanaged<XrInstance, nint*, long*, XrResult>)GetFunctionPointer("xrConvertWin32PerformanceCounterToTimeKHR"u8);
            xrConvertTimeToWin32PerformanceCounterKHR_funcPtr = (delegate* unmanaged<XrInstance, long, nint*, XrResult>)GetFunctionPointer("xrConvertTimeToWin32PerformanceCounterKHR"u8);
        }
        if (HasExtensionEnabled("XR_KHR_convert_timespec_time"u8))
        {
            xrConvertTimespecTimeToTimeKHR_funcPtr = (delegate* unmanaged<XrInstance, nint*, long*, XrResult>)GetFunctionPointer("xrConvertTimespecTimeToTimeKHR"u8);
            xrConvertTimeToTimespecTimeKHR_funcPtr = (delegate* unmanaged<XrInstance, long, nint*, XrResult>)GetFunctionPointer("xrConvertTimeToTimespecTimeKHR"u8);
        }
        if (HasExtensionEnabled("XR_MSFT_spatial_anchor"u8))
        {
            xrCreateSpatialAnchorMSFT_funcPtr = (delegate* unmanaged<XrSession, XrSpatialAnchorCreateInfoMSFT*, XrSpatialAnchorMSFT*, XrResult>)GetFunctionPointer("xrCreateSpatialAnchorMSFT"u8);
            xrCreateSpatialAnchorSpaceMSFT_funcPtr = (delegate* unmanaged<XrSession, XrSpatialAnchorSpaceCreateInfoMSFT*, XrSpace*, XrResult>)GetFunctionPointer("xrCreateSpatialAnchorSpaceMSFT"u8);
            xrDestroySpatialAnchorMSFT_funcPtr = (delegate* unmanaged<XrSpatialAnchorMSFT, XrResult>)GetFunctionPointer("xrDestroySpatialAnchorMSFT"u8);
        }
        if (HasExtensionEnabled("XR_EXT_conformance_automation"u8))
        {
            xrSetInputDeviceActiveEXT_funcPtr = (delegate* unmanaged<XrSession, ulong, ulong, XrBool32, XrResult>)GetFunctionPointer("xrSetInputDeviceActiveEXT"u8);
            xrSetInputDeviceStateBoolEXT_funcPtr = (delegate* unmanaged<XrSession, ulong, ulong, XrBool32, XrResult>)GetFunctionPointer("xrSetInputDeviceStateBoolEXT"u8);
            xrSetInputDeviceStateFloatEXT_funcPtr = (delegate* unmanaged<XrSession, ulong, ulong, float, XrResult>)GetFunctionPointer("xrSetInputDeviceStateFloatEXT"u8);
            xrSetInputDeviceStateVector2fEXT_funcPtr = (delegate* unmanaged<XrSession, ulong, ulong, XrVector2f, XrResult>)GetFunctionPointer("xrSetInputDeviceStateVector2fEXT"u8);
            xrSetInputDeviceLocationEXT_funcPtr = (delegate* unmanaged<XrSession, ulong, ulong, XrSpace, XrPosef, XrResult>)GetFunctionPointer("xrSetInputDeviceLocationEXT"u8);
        }
        if (HasExtensionEnabled("XR_MSFT_spatial_graph_bridge"u8))
        {
            xrCreateSpatialGraphNodeSpaceMSFT_funcPtr = (delegate* unmanaged<XrSession, XrSpatialGraphNodeSpaceCreateInfoMSFT*, XrSpace*, XrResult>)GetFunctionPointer("xrCreateSpatialGraphNodeSpaceMSFT"u8);
            xrTryCreateSpatialGraphStaticNodeBindingMSFT_funcPtr = (delegate* unmanaged<XrSession, XrSpatialGraphStaticNodeBindingCreateInfoMSFT*, XrSpatialGraphNodeBindingMSFT*, XrResult>)GetFunctionPointer("xrTryCreateSpatialGraphStaticNodeBindingMSFT"u8);
            xrDestroySpatialGraphNodeBindingMSFT_funcPtr = (delegate* unmanaged<XrSpatialGraphNodeBindingMSFT, XrResult>)GetFunctionPointer("xrDestroySpatialGraphNodeBindingMSFT"u8);
            xrGetSpatialGraphNodeBindingPropertiesMSFT_funcPtr = (delegate* unmanaged<XrSpatialGraphNodeBindingMSFT, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT*, XrSpatialGraphNodeBindingPropertiesMSFT*, XrResult>)GetFunctionPointer("xrGetSpatialGraphNodeBindingPropertiesMSFT"u8);
        }
        if (HasExtensionEnabled("XR_EXT_hand_tracking"u8))
        {
            xrCreateHandTrackerEXT_funcPtr = (delegate* unmanaged<XrSession, XrHandTrackerCreateInfoEXT*, XrHandTrackerEXT*, XrResult>)GetFunctionPointer("xrCreateHandTrackerEXT"u8);
            xrDestroyHandTrackerEXT_funcPtr = (delegate* unmanaged<XrHandTrackerEXT, XrResult>)GetFunctionPointer("xrDestroyHandTrackerEXT"u8);
            xrLocateHandJointsEXT_funcPtr = (delegate* unmanaged<XrHandTrackerEXT, XrHandJointsLocateInfoEXT*, XrHandJointLocationsEXT*, XrResult>)GetFunctionPointer("xrLocateHandJointsEXT"u8);
        }
        if (HasExtensionEnabled("XR_MSFT_hand_tracking_mesh"u8))
        {
            xrCreateHandMeshSpaceMSFT_funcPtr = (delegate* unmanaged<XrHandTrackerEXT, XrHandMeshSpaceCreateInfoMSFT*, XrSpace*, XrResult>)GetFunctionPointer("xrCreateHandMeshSpaceMSFT"u8);
            xrUpdateHandMeshMSFT_funcPtr = (delegate* unmanaged<XrHandTrackerEXT, XrHandMeshUpdateInfoMSFT*, XrHandMeshMSFT*, XrResult>)GetFunctionPointer("xrUpdateHandMeshMSFT"u8);
        }
        if (HasExtensionEnabled("XR_MSFT_controller_model"u8))
        {
            xrGetControllerModelKeyMSFT_funcPtr = (delegate* unmanaged<XrSession, ulong, XrControllerModelKeyStateMSFT*, XrResult>)GetFunctionPointer("xrGetControllerModelKeyMSFT"u8);
            xrLoadControllerModelMSFT_funcPtr = (delegate* unmanaged<XrSession, ulong, uint, uint*, byte*, XrResult>)GetFunctionPointer("xrLoadControllerModelMSFT"u8);
            xrGetControllerModelPropertiesMSFT_funcPtr = (delegate* unmanaged<XrSession, ulong, XrControllerModelPropertiesMSFT*, XrResult>)GetFunctionPointer("xrGetControllerModelPropertiesMSFT"u8);
            xrGetControllerModelStateMSFT_funcPtr = (delegate* unmanaged<XrSession, ulong, XrControllerModelStateMSFT*, XrResult>)GetFunctionPointer("xrGetControllerModelStateMSFT"u8);
        }
        if (HasExtensionEnabled("XR_MSFT_perception_anchor_interop"u8))
        {
            xrCreateSpatialAnchorFromPerceptionAnchorMSFT_funcPtr = (delegate* unmanaged<XrSession, nint*, XrSpatialAnchorMSFT*, XrResult>)GetFunctionPointer("xrCreateSpatialAnchorFromPerceptionAnchorMSFT"u8);
            xrTryGetPerceptionAnchorFromSpatialAnchorMSFT_funcPtr = (delegate* unmanaged<XrSession, XrSpatialAnchorMSFT, nint**, XrResult>)GetFunctionPointer("xrTryGetPerceptionAnchorFromSpatialAnchorMSFT"u8);
        }
        if (HasExtensionEnabled("XR_MSFT_composition_layer_reprojection"u8))
        {
            xrEnumerateReprojectionModesMSFT_funcPtr = (delegate* unmanaged<XrInstance, ulong, XrViewConfigurationType, uint, uint*, XrReprojectionModeMSFT*, XrResult>)GetFunctionPointer("xrEnumerateReprojectionModesMSFT"u8);
        }
        if (HasExtensionEnabled("XR_FB_swapchain_update_state"u8))
        {
            xrUpdateSwapchainFB_funcPtr = (delegate* unmanaged<XrSwapchain, XrSwapchainStateBaseHeaderFB*, XrResult>)GetFunctionPointer("xrUpdateSwapchainFB"u8);
            xrGetSwapchainStateFB_funcPtr = (delegate* unmanaged<XrSwapchain, XrSwapchainStateBaseHeaderFB*, XrResult>)GetFunctionPointer("xrGetSwapchainStateFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_body_tracking"u8))
        {
            xrCreateBodyTrackerFB_funcPtr = (delegate* unmanaged<XrSession, XrBodyTrackerCreateInfoFB*, XrBodyTrackerFB*, XrResult>)GetFunctionPointer("xrCreateBodyTrackerFB"u8);
            xrDestroyBodyTrackerFB_funcPtr = (delegate* unmanaged<XrBodyTrackerFB, XrResult>)GetFunctionPointer("xrDestroyBodyTrackerFB"u8);
            xrLocateBodyJointsFB_funcPtr = (delegate* unmanaged<XrBodyTrackerFB, XrBodyJointsLocateInfoFB*, XrBodyJointLocationsFB*, XrResult>)GetFunctionPointer("xrLocateBodyJointsFB"u8);
            xrGetBodySkeletonFB_funcPtr = (delegate* unmanaged<XrBodyTrackerFB, XrBodySkeletonFB*, XrResult>)GetFunctionPointer("xrGetBodySkeletonFB"u8);
        }
        if (HasExtensionEnabled("XR_KHR_loader_init"u8))
        {
            xrInitializeLoaderKHR_funcPtr = (delegate* unmanaged<XrLoaderInitInfoBaseHeaderKHR*, XrResult>)GetFunctionPointer("xrInitializeLoaderKHR"u8);
        }
        if (HasExtensionEnabled("XR_KHR_vulkan_enable2"u8))
        {
            xrCreateVulkanInstanceKHR_funcPtr = (delegate* unmanaged<XrInstance, XrVulkanInstanceCreateInfoKHR*, nint*, nint*, XrResult>)GetFunctionPointer("xrCreateVulkanInstanceKHR"u8);
            xrCreateVulkanDeviceKHR_funcPtr = (delegate* unmanaged<XrInstance, XrVulkanDeviceCreateInfoKHR*, nint*, nint*, XrResult>)GetFunctionPointer("xrCreateVulkanDeviceKHR"u8);
            xrGetVulkanGraphicsDevice2KHR_funcPtr = (delegate* unmanaged<XrInstance, XrVulkanGraphicsDeviceGetInfoKHR*, nint*, XrResult>)GetFunctionPointer("xrGetVulkanGraphicsDevice2KHR"u8);
        }
        if (HasExtensionEnabled("XR_MSFT_scene_understanding"u8))
        {
            xrEnumerateSceneComputeFeaturesMSFT_funcPtr = (delegate* unmanaged<XrInstance, ulong, uint, uint*, XrSceneComputeFeatureMSFT*, XrResult>)GetFunctionPointer("xrEnumerateSceneComputeFeaturesMSFT"u8);
            xrCreateSceneObserverMSFT_funcPtr = (delegate* unmanaged<XrSession, XrSceneObserverCreateInfoMSFT*, XrSceneObserverMSFT*, XrResult>)GetFunctionPointer("xrCreateSceneObserverMSFT"u8);
            xrDestroySceneObserverMSFT_funcPtr = (delegate* unmanaged<XrSceneObserverMSFT, XrResult>)GetFunctionPointer("xrDestroySceneObserverMSFT"u8);
            xrCreateSceneMSFT_funcPtr = (delegate* unmanaged<XrSceneObserverMSFT, XrSceneCreateInfoMSFT*, XrSceneMSFT*, XrResult>)GetFunctionPointer("xrCreateSceneMSFT"u8);
            xrDestroySceneMSFT_funcPtr = (delegate* unmanaged<XrSceneMSFT, XrResult>)GetFunctionPointer("xrDestroySceneMSFT"u8);
            xrComputeNewSceneMSFT_funcPtr = (delegate* unmanaged<XrSceneObserverMSFT, XrNewSceneComputeInfoMSFT*, XrResult>)GetFunctionPointer("xrComputeNewSceneMSFT"u8);
            xrGetSceneComputeStateMSFT_funcPtr = (delegate* unmanaged<XrSceneObserverMSFT, XrSceneComputeStateMSFT*, XrResult>)GetFunctionPointer("xrGetSceneComputeStateMSFT"u8);
            xrGetSceneComponentsMSFT_funcPtr = (delegate* unmanaged<XrSceneMSFT, XrSceneComponentsGetInfoMSFT*, XrSceneComponentsMSFT*, XrResult>)GetFunctionPointer("xrGetSceneComponentsMSFT"u8);
            xrLocateSceneComponentsMSFT_funcPtr = (delegate* unmanaged<XrSceneMSFT, XrSceneComponentsLocateInfoMSFT*, XrSceneComponentLocationsMSFT*, XrResult>)GetFunctionPointer("xrLocateSceneComponentsMSFT"u8);
            xrGetSceneMeshBuffersMSFT_funcPtr = (delegate* unmanaged<XrSceneMSFT, XrSceneMeshBuffersGetInfoMSFT*, XrSceneMeshBuffersMSFT*, XrResult>)GetFunctionPointer("xrGetSceneMeshBuffersMSFT"u8);
        }
        if (HasExtensionEnabled("XR_MSFT_scene_understanding_serialization"u8))
        {
            xrDeserializeSceneMSFT_funcPtr = (delegate* unmanaged<XrSceneObserverMSFT, XrSceneDeserializeInfoMSFT*, XrResult>)GetFunctionPointer("xrDeserializeSceneMSFT"u8);
            xrGetSerializedSceneFragmentDataMSFT_funcPtr = (delegate* unmanaged<XrSceneMSFT, XrSerializedSceneFragmentDataGetInfoMSFT*, uint, uint*, byte*, XrResult>)GetFunctionPointer("xrGetSerializedSceneFragmentDataMSFT"u8);
        }
        if (HasExtensionEnabled("XR_FB_display_refresh_rate"u8))
        {
            xrEnumerateDisplayRefreshRatesFB_funcPtr = (delegate* unmanaged<XrSession, uint, uint*, float*, XrResult>)GetFunctionPointer("xrEnumerateDisplayRefreshRatesFB"u8);
            xrGetDisplayRefreshRateFB_funcPtr = (delegate* unmanaged<XrSession, float*, XrResult>)GetFunctionPointer("xrGetDisplayRefreshRateFB"u8);
            xrRequestDisplayRefreshRateFB_funcPtr = (delegate* unmanaged<XrSession, float, XrResult>)GetFunctionPointer("xrRequestDisplayRefreshRateFB"u8);
        }
        if (HasExtensionEnabled("XR_HTCX_vive_tracker_interaction"u8))
        {
            xrEnumerateViveTrackerPathsHTCX_funcPtr = (delegate* unmanaged<XrInstance, uint, uint*, XrViveTrackerPathsHTCX*, XrResult>)GetFunctionPointer("xrEnumerateViveTrackerPathsHTCX"u8);
        }
        if (HasExtensionEnabled("XR_HTC_facial_tracking"u8))
        {
            xrCreateFacialTrackerHTC_funcPtr = (delegate* unmanaged<XrSession, XrFacialTrackerCreateInfoHTC*, XrFacialTrackerHTC*, XrResult>)GetFunctionPointer("xrCreateFacialTrackerHTC"u8);
            xrDestroyFacialTrackerHTC_funcPtr = (delegate* unmanaged<XrFacialTrackerHTC, XrResult>)GetFunctionPointer("xrDestroyFacialTrackerHTC"u8);
            xrGetFacialExpressionsHTC_funcPtr = (delegate* unmanaged<XrFacialTrackerHTC, XrFacialExpressionsHTC*, XrResult>)GetFunctionPointer("xrGetFacialExpressionsHTC"u8);
        }
        if (HasExtensionEnabled("XR_FB_color_space"u8))
        {
            xrEnumerateColorSpacesFB_funcPtr = (delegate* unmanaged<XrSession, uint, uint*, XrColorSpaceFB*, XrResult>)GetFunctionPointer("xrEnumerateColorSpacesFB"u8);
            xrSetColorSpaceFB_funcPtr = (delegate* unmanaged<XrSession, XrColorSpaceFB, XrResult>)GetFunctionPointer("xrSetColorSpaceFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_hand_tracking_mesh"u8))
        {
            xrGetHandMeshFB_funcPtr = (delegate* unmanaged<XrHandTrackerEXT, XrHandTrackingMeshFB*, XrResult>)GetFunctionPointer("xrGetHandMeshFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_spatial_entity"u8))
        {
            xrCreateSpatialAnchorFB_funcPtr = (delegate* unmanaged<XrSession, XrSpatialAnchorCreateInfoFB*, ulong*, XrResult>)GetFunctionPointer("xrCreateSpatialAnchorFB"u8);
            xrGetSpaceUuidFB_funcPtr = (delegate* unmanaged<XrSpace, XrUuidEXT*, XrResult>)GetFunctionPointer("xrGetSpaceUuidFB"u8);
            xrEnumerateSpaceSupportedComponentsFB_funcPtr = (delegate* unmanaged<XrSpace, uint, uint*, XrSpaceComponentTypeFB*, XrResult>)GetFunctionPointer("xrEnumerateSpaceSupportedComponentsFB"u8);
            xrSetSpaceComponentStatusFB_funcPtr = (delegate* unmanaged<XrSpace, XrSpaceComponentStatusSetInfoFB*, ulong*, XrResult>)GetFunctionPointer("xrSetSpaceComponentStatusFB"u8);
            xrGetSpaceComponentStatusFB_funcPtr = (delegate* unmanaged<XrSpace, XrSpaceComponentTypeFB, XrSpaceComponentStatusFB*, XrResult>)GetFunctionPointer("xrGetSpaceComponentStatusFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_foveation"u8))
        {
            xrCreateFoveationProfileFB_funcPtr = (delegate* unmanaged<XrSession, XrFoveationProfileCreateInfoFB*, XrFoveationProfileFB*, XrResult>)GetFunctionPointer("xrCreateFoveationProfileFB"u8);
            xrDestroyFoveationProfileFB_funcPtr = (delegate* unmanaged<XrFoveationProfileFB, XrResult>)GetFunctionPointer("xrDestroyFoveationProfileFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_keyboard_tracking"u8))
        {
            xrQuerySystemTrackedKeyboardFB_funcPtr = (delegate* unmanaged<XrSession, XrKeyboardTrackingQueryFB*, XrKeyboardTrackingDescriptionFB*, XrResult>)GetFunctionPointer("xrQuerySystemTrackedKeyboardFB"u8);
            xrCreateKeyboardSpaceFB_funcPtr = (delegate* unmanaged<XrSession, XrKeyboardSpaceCreateInfoFB*, XrSpace*, XrResult>)GetFunctionPointer("xrCreateKeyboardSpaceFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_triangle_mesh"u8))
        {
            xrCreateTriangleMeshFB_funcPtr = (delegate* unmanaged<XrSession, XrTriangleMeshCreateInfoFB*, XrTriangleMeshFB*, XrResult>)GetFunctionPointer("xrCreateTriangleMeshFB"u8);
            xrDestroyTriangleMeshFB_funcPtr = (delegate* unmanaged<XrTriangleMeshFB, XrResult>)GetFunctionPointer("xrDestroyTriangleMeshFB"u8);
            xrTriangleMeshGetVertexBufferFB_funcPtr = (delegate* unmanaged<XrTriangleMeshFB, XrVector3f**, XrResult>)GetFunctionPointer("xrTriangleMeshGetVertexBufferFB"u8);
            xrTriangleMeshGetIndexBufferFB_funcPtr = (delegate* unmanaged<XrTriangleMeshFB, uint**, XrResult>)GetFunctionPointer("xrTriangleMeshGetIndexBufferFB"u8);
            xrTriangleMeshBeginUpdateFB_funcPtr = (delegate* unmanaged<XrTriangleMeshFB, XrResult>)GetFunctionPointer("xrTriangleMeshBeginUpdateFB"u8);
            xrTriangleMeshEndUpdateFB_funcPtr = (delegate* unmanaged<XrTriangleMeshFB, uint, uint, XrResult>)GetFunctionPointer("xrTriangleMeshEndUpdateFB"u8);
            xrTriangleMeshBeginVertexBufferUpdateFB_funcPtr = (delegate* unmanaged<XrTriangleMeshFB, uint*, XrResult>)GetFunctionPointer("xrTriangleMeshBeginVertexBufferUpdateFB"u8);
            xrTriangleMeshEndVertexBufferUpdateFB_funcPtr = (delegate* unmanaged<XrTriangleMeshFB, XrResult>)GetFunctionPointer("xrTriangleMeshEndVertexBufferUpdateFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_passthrough"u8))
        {
            xrCreatePassthroughFB_funcPtr = (delegate* unmanaged<XrSession, XrPassthroughCreateInfoFB*, XrPassthroughFB*, XrResult>)GetFunctionPointer("xrCreatePassthroughFB"u8);
            xrDestroyPassthroughFB_funcPtr = (delegate* unmanaged<XrPassthroughFB, XrResult>)GetFunctionPointer("xrDestroyPassthroughFB"u8);
            xrPassthroughStartFB_funcPtr = (delegate* unmanaged<XrPassthroughFB, XrResult>)GetFunctionPointer("xrPassthroughStartFB"u8);
            xrPassthroughPauseFB_funcPtr = (delegate* unmanaged<XrPassthroughFB, XrResult>)GetFunctionPointer("xrPassthroughPauseFB"u8);
            xrCreatePassthroughLayerFB_funcPtr = (delegate* unmanaged<XrSession, XrPassthroughLayerCreateInfoFB*, XrPassthroughLayerFB*, XrResult>)GetFunctionPointer("xrCreatePassthroughLayerFB"u8);
            xrDestroyPassthroughLayerFB_funcPtr = (delegate* unmanaged<XrPassthroughLayerFB, XrResult>)GetFunctionPointer("xrDestroyPassthroughLayerFB"u8);
            xrPassthroughLayerPauseFB_funcPtr = (delegate* unmanaged<XrPassthroughLayerFB, XrResult>)GetFunctionPointer("xrPassthroughLayerPauseFB"u8);
            xrPassthroughLayerResumeFB_funcPtr = (delegate* unmanaged<XrPassthroughLayerFB, XrResult>)GetFunctionPointer("xrPassthroughLayerResumeFB"u8);
            xrPassthroughLayerSetStyleFB_funcPtr = (delegate* unmanaged<XrPassthroughLayerFB, XrPassthroughStyleFB*, XrResult>)GetFunctionPointer("xrPassthroughLayerSetStyleFB"u8);
            xrCreateGeometryInstanceFB_funcPtr = (delegate* unmanaged<XrSession, XrGeometryInstanceCreateInfoFB*, XrGeometryInstanceFB*, XrResult>)GetFunctionPointer("xrCreateGeometryInstanceFB"u8);
            xrDestroyGeometryInstanceFB_funcPtr = (delegate* unmanaged<XrGeometryInstanceFB, XrResult>)GetFunctionPointer("xrDestroyGeometryInstanceFB"u8);
            xrGeometryInstanceSetTransformFB_funcPtr = (delegate* unmanaged<XrGeometryInstanceFB, XrGeometryInstanceTransformFB*, XrResult>)GetFunctionPointer("xrGeometryInstanceSetTransformFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_render_model"u8))
        {
            xrEnumerateRenderModelPathsFB_funcPtr = (delegate* unmanaged<XrSession, uint, uint*, XrRenderModelPathInfoFB*, XrResult>)GetFunctionPointer("xrEnumerateRenderModelPathsFB"u8);
            xrGetRenderModelPropertiesFB_funcPtr = (delegate* unmanaged<XrSession, ulong, XrRenderModelPropertiesFB*, XrResult>)GetFunctionPointer("xrGetRenderModelPropertiesFB"u8);
            xrLoadRenderModelFB_funcPtr = (delegate* unmanaged<XrSession, XrRenderModelLoadInfoFB*, XrRenderModelBufferFB*, XrResult>)GetFunctionPointer("xrLoadRenderModelFB"u8);
        }
        if (HasExtensionEnabled("XR_VARJO_environment_depth_estimation"u8))
        {
            xrSetEnvironmentDepthEstimationVARJO_funcPtr = (delegate* unmanaged<XrSession, XrBool32, XrResult>)GetFunctionPointer("xrSetEnvironmentDepthEstimationVARJO"u8);
        }
        if (HasExtensionEnabled("XR_VARJO_marker_tracking"u8))
        {
            xrSetMarkerTrackingVARJO_funcPtr = (delegate* unmanaged<XrSession, XrBool32, XrResult>)GetFunctionPointer("xrSetMarkerTrackingVARJO"u8);
            xrSetMarkerTrackingTimeoutVARJO_funcPtr = (delegate* unmanaged<XrSession, ulong, long, XrResult>)GetFunctionPointer("xrSetMarkerTrackingTimeoutVARJO"u8);
            xrSetMarkerTrackingPredictionVARJO_funcPtr = (delegate* unmanaged<XrSession, ulong, XrBool32, XrResult>)GetFunctionPointer("xrSetMarkerTrackingPredictionVARJO"u8);
            xrGetMarkerSizeVARJO_funcPtr = (delegate* unmanaged<XrSession, ulong, XrExtent2Df*, XrResult>)GetFunctionPointer("xrGetMarkerSizeVARJO"u8);
            xrCreateMarkerSpaceVARJO_funcPtr = (delegate* unmanaged<XrSession, XrMarkerSpaceCreateInfoVARJO*, XrSpace*, XrResult>)GetFunctionPointer("xrCreateMarkerSpaceVARJO"u8);
        }
        if (HasExtensionEnabled("XR_VARJO_view_offset"u8))
        {
            xrSetViewOffsetVARJO_funcPtr = (delegate* unmanaged<XrSession, float, XrResult>)GetFunctionPointer("xrSetViewOffsetVARJO"u8);
        }
        if (HasExtensionEnabled("XR_ML_compat"u8))
        {
            xrCreateSpaceFromCoordinateFrameUIDML_funcPtr = (delegate* unmanaged<XrSession, XrCoordinateSpaceCreateInfoML, XrSpace*, XrResult>)GetFunctionPointer("xrCreateSpaceFromCoordinateFrameUIDML"u8);
        }
        if (HasExtensionEnabled("XR_MSFT_spatial_anchor_persistence"u8))
        {
            xrCreateSpatialAnchorStoreConnectionMSFT_funcPtr = (delegate* unmanaged<XrSession, XrSpatialAnchorStoreConnectionMSFT*, XrResult>)GetFunctionPointer("xrCreateSpatialAnchorStoreConnectionMSFT"u8);
            xrDestroySpatialAnchorStoreConnectionMSFT_funcPtr = (delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrResult>)GetFunctionPointer("xrDestroySpatialAnchorStoreConnectionMSFT"u8);
            xrPersistSpatialAnchorMSFT_funcPtr = (delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrSpatialAnchorPersistenceInfoMSFT*, XrResult>)GetFunctionPointer("xrPersistSpatialAnchorMSFT"u8);
            xrEnumeratePersistedSpatialAnchorNamesMSFT_funcPtr = (delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, uint, uint*, XrSpatialAnchorPersistenceNameMSFT*, XrResult>)GetFunctionPointer("xrEnumeratePersistedSpatialAnchorNamesMSFT"u8);
            xrCreateSpatialAnchorFromPersistedNameMSFT_funcPtr = (delegate* unmanaged<XrSession, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT*, XrSpatialAnchorMSFT*, XrResult>)GetFunctionPointer("xrCreateSpatialAnchorFromPersistedNameMSFT"u8);
            xrUnpersistSpatialAnchorMSFT_funcPtr = (delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrSpatialAnchorPersistenceNameMSFT*, XrResult>)GetFunctionPointer("xrUnpersistSpatialAnchorMSFT"u8);
            xrClearSpatialAnchorStoreMSFT_funcPtr = (delegate* unmanaged<XrSpatialAnchorStoreConnectionMSFT, XrResult>)GetFunctionPointer("xrClearSpatialAnchorStoreMSFT"u8);
        }
        if (HasExtensionEnabled("XR_FB_spatial_entity_query"u8))
        {
            xrQuerySpacesFB_funcPtr = (delegate* unmanaged<XrSession, XrSpaceQueryInfoBaseHeaderFB*, ulong*, XrResult>)GetFunctionPointer("xrQuerySpacesFB"u8);
            xrRetrieveSpaceQueryResultsFB_funcPtr = (delegate* unmanaged<XrSession, ulong, XrSpaceQueryResultsFB*, XrResult>)GetFunctionPointer("xrRetrieveSpaceQueryResultsFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_spatial_entity_storage"u8))
        {
            xrSaveSpaceFB_funcPtr = (delegate* unmanaged<XrSession, XrSpaceSaveInfoFB*, ulong*, XrResult>)GetFunctionPointer("xrSaveSpaceFB"u8);
            xrEraseSpaceFB_funcPtr = (delegate* unmanaged<XrSession, XrSpaceEraseInfoFB*, ulong*, XrResult>)GetFunctionPointer("xrEraseSpaceFB"u8);
        }
        if (HasExtensionEnabled("XR_OCULUS_audio_device_guid"u8))
        {
            xrGetAudioOutputDeviceGuidOculus_funcPtr = (delegate* unmanaged<XrInstance, string, XrResult>)GetFunctionPointer("xrGetAudioOutputDeviceGuidOculus"u8);
            xrGetAudioInputDeviceGuidOculus_funcPtr = (delegate* unmanaged<XrInstance, string, XrResult>)GetFunctionPointer("xrGetAudioInputDeviceGuidOculus"u8);
        }
        if (HasExtensionEnabled("XR_FB_spatial_entity_sharing"u8))
        {
            xrShareSpacesFB_funcPtr = (delegate* unmanaged<XrSession, XrSpaceShareInfoFB*, ulong*, XrResult>)GetFunctionPointer("xrShareSpacesFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_scene"u8))
        {
            xrGetSpaceBoundingBox2DFB_funcPtr = (delegate* unmanaged<XrSession, XrSpace, XrRect2Df*, XrResult>)GetFunctionPointer("xrGetSpaceBoundingBox2DFB"u8);
            xrGetSpaceBoundingBox3DFB_funcPtr = (delegate* unmanaged<XrSession, XrSpace, XrRect3DfFB*, XrResult>)GetFunctionPointer("xrGetSpaceBoundingBox3DFB"u8);
            xrGetSpaceSemanticLabelsFB_funcPtr = (delegate* unmanaged<XrSession, XrSpace, XrSemanticLabelsFB*, XrResult>)GetFunctionPointer("xrGetSpaceSemanticLabelsFB"u8);
            xrGetSpaceBoundary2DFB_funcPtr = (delegate* unmanaged<XrSession, XrSpace, XrBoundary2DFB*, XrResult>)GetFunctionPointer("xrGetSpaceBoundary2DFB"u8);
            xrGetSpaceRoomLayoutFB_funcPtr = (delegate* unmanaged<XrSession, XrSpace, XrRoomLayoutFB*, XrResult>)GetFunctionPointer("xrGetSpaceRoomLayoutFB"u8);
        }
        if (HasExtensionEnabled("XR_ALMALENCE_digital_lens_control"u8))
        {
            xrSetDigitalLensControlALMALENCE_funcPtr = (delegate* unmanaged<XrSession, XrDigitalLensControlALMALENCE*, XrResult>)GetFunctionPointer("xrSetDigitalLensControlALMALENCE"u8);
        }
        if (HasExtensionEnabled("XR_FB_scene_capture"u8))
        {
            xrRequestSceneCaptureFB_funcPtr = (delegate* unmanaged<XrSession, XrSceneCaptureRequestInfoFB*, ulong*, XrResult>)GetFunctionPointer("xrRequestSceneCaptureFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_spatial_entity_container"u8))
        {
            xrGetSpaceContainerFB_funcPtr = (delegate* unmanaged<XrSession, XrSpace, XrSpaceContainerFB*, XrResult>)GetFunctionPointer("xrGetSpaceContainerFB"u8);
        }
        if (HasExtensionEnabled("XR_META_foveation_eye_tracked"u8))
        {
            xrGetFoveationEyeTrackedStateMETA_funcPtr = (delegate* unmanaged<XrSession, XrFoveationEyeTrackedStateMETA*, XrResult>)GetFunctionPointer("xrGetFoveationEyeTrackedStateMETA"u8);
        }
        if (HasExtensionEnabled("XR_FB_face_tracking"u8))
        {
            xrCreateFaceTrackerFB_funcPtr = (delegate* unmanaged<XrSession, XrFaceTrackerCreateInfoFB*, XrFaceTrackerFB*, XrResult>)GetFunctionPointer("xrCreateFaceTrackerFB"u8);
            xrDestroyFaceTrackerFB_funcPtr = (delegate* unmanaged<XrFaceTrackerFB, XrResult>)GetFunctionPointer("xrDestroyFaceTrackerFB"u8);
            xrGetFaceExpressionWeightsFB_funcPtr = (delegate* unmanaged<XrFaceTrackerFB, XrFaceExpressionInfoFB*, XrFaceExpressionWeightsFB*, XrResult>)GetFunctionPointer("xrGetFaceExpressionWeightsFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_eye_tracking_social"u8))
        {
            xrCreateEyeTrackerFB_funcPtr = (delegate* unmanaged<XrSession, XrEyeTrackerCreateInfoFB*, XrEyeTrackerFB*, XrResult>)GetFunctionPointer("xrCreateEyeTrackerFB"u8);
            xrDestroyEyeTrackerFB_funcPtr = (delegate* unmanaged<XrEyeTrackerFB, XrResult>)GetFunctionPointer("xrDestroyEyeTrackerFB"u8);
            xrGetEyeGazesFB_funcPtr = (delegate* unmanaged<XrEyeTrackerFB, XrEyeGazesInfoFB*, XrEyeGazesFB*, XrResult>)GetFunctionPointer("xrGetEyeGazesFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_passthrough_keyboard_hands"u8))
        {
            xrPassthroughLayerSetKeyboardHandsIntensityFB_funcPtr = (delegate* unmanaged<XrPassthroughLayerFB, XrPassthroughKeyboardHandsIntensityFB*, XrResult>)GetFunctionPointer("xrPassthroughLayerSetKeyboardHandsIntensityFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_haptic_pcm"u8))
        {
            xrGetDeviceSampleRateFB_funcPtr = (delegate* unmanaged<XrSession, XrHapticActionInfo*, XrDevicePcmSampleRateStateFB*, XrResult>)GetFunctionPointer("xrGetDeviceSampleRateFB"u8);
        }
        if (HasExtensionEnabled("XR_META_passthrough_preferences"u8))
        {
            xrGetPassthroughPreferencesMETA_funcPtr = (delegate* unmanaged<XrSession, XrPassthroughPreferencesMETA*, XrResult>)GetFunctionPointer("xrGetPassthroughPreferencesMETA"u8);
        }
        if (HasExtensionEnabled("XR_META_virtual_keyboard"u8))
        {
            xrCreateVirtualKeyboardMETA_funcPtr = (delegate* unmanaged<XrSession, XrVirtualKeyboardCreateInfoMETA*, XrVirtualKeyboardMETA*, XrResult>)GetFunctionPointer("xrCreateVirtualKeyboardMETA"u8);
            xrDestroyVirtualKeyboardMETA_funcPtr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrResult>)GetFunctionPointer("xrDestroyVirtualKeyboardMETA"u8);
            xrCreateVirtualKeyboardSpaceMETA_funcPtr = (delegate* unmanaged<XrSession, XrVirtualKeyboardMETA, XrVirtualKeyboardSpaceCreateInfoMETA*, XrSpace*, XrResult>)GetFunctionPointer("xrCreateVirtualKeyboardSpaceMETA"u8);
            xrSuggestVirtualKeyboardLocationMETA_funcPtr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardLocationInfoMETA*, XrResult>)GetFunctionPointer("xrSuggestVirtualKeyboardLocationMETA"u8);
            xrGetVirtualKeyboardScaleMETA_funcPtr = (delegate* unmanaged<XrVirtualKeyboardMETA, float*, XrResult>)GetFunctionPointer("xrGetVirtualKeyboardScaleMETA"u8);
            xrSetVirtualKeyboardModelVisibilityMETA_funcPtr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardModelVisibilitySetInfoMETA*, XrResult>)GetFunctionPointer("xrSetVirtualKeyboardModelVisibilityMETA"u8);
            xrGetVirtualKeyboardModelAnimationStatesMETA_funcPtr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardModelAnimationStatesMETA*, XrResult>)GetFunctionPointer("xrGetVirtualKeyboardModelAnimationStatesMETA"u8);
            xrGetVirtualKeyboardDirtyTexturesMETA_funcPtr = (delegate* unmanaged<XrVirtualKeyboardMETA, uint, uint*, ulong*, XrResult>)GetFunctionPointer("xrGetVirtualKeyboardDirtyTexturesMETA"u8);
            xrGetVirtualKeyboardTextureDataMETA_funcPtr = (delegate* unmanaged<XrVirtualKeyboardMETA, ulong, XrVirtualKeyboardTextureDataMETA*, XrResult>)GetFunctionPointer("xrGetVirtualKeyboardTextureDataMETA"u8);
            xrSendVirtualKeyboardInputMETA_funcPtr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardInputInfoMETA*, XrPosef*, XrResult>)GetFunctionPointer("xrSendVirtualKeyboardInputMETA"u8);
            xrChangeVirtualKeyboardTextContextMETA_funcPtr = (delegate* unmanaged<XrVirtualKeyboardMETA, XrVirtualKeyboardTextContextChangeInfoMETA*, XrResult>)GetFunctionPointer("xrChangeVirtualKeyboardTextContextMETA"u8);
        }
        if (HasExtensionEnabled("XR_OCULUS_external_camera"u8))
        {
            xrEnumerateExternalCamerasOCULUS_funcPtr = (delegate* unmanaged<XrSession, uint, uint*, XrExternalCameraOCULUS*, XrResult>)GetFunctionPointer("xrEnumerateExternalCamerasOCULUS"u8);
        }
        if (HasExtensionEnabled("XR_META_performance_metrics"u8))
        {
            xrEnumeratePerformanceMetricsCounterPathsMETA_funcPtr = (delegate* unmanaged<XrInstance, uint, uint*, ulong*, XrResult>)GetFunctionPointer("xrEnumeratePerformanceMetricsCounterPathsMETA"u8);
            xrSetPerformanceMetricsStateMETA_funcPtr = (delegate* unmanaged<XrSession, XrPerformanceMetricsStateMETA*, XrResult>)GetFunctionPointer("xrSetPerformanceMetricsStateMETA"u8);
            xrGetPerformanceMetricsStateMETA_funcPtr = (delegate* unmanaged<XrSession, XrPerformanceMetricsStateMETA*, XrResult>)GetFunctionPointer("xrGetPerformanceMetricsStateMETA"u8);
            xrQueryPerformanceMetricsCounterMETA_funcPtr = (delegate* unmanaged<XrSession, ulong, XrPerformanceMetricsCounterMETA*, XrResult>)GetFunctionPointer("xrQueryPerformanceMetricsCounterMETA"u8);
        }
        if (HasExtensionEnabled("XR_FB_spatial_entity_storage_batch"u8))
        {
            xrSaveSpaceListFB_funcPtr = (delegate* unmanaged<XrSession, XrSpaceListSaveInfoFB*, ulong*, XrResult>)GetFunctionPointer("xrSaveSpaceListFB"u8);
        }
        if (HasExtensionEnabled("XR_FB_spatial_entity_user"u8))
        {
            xrCreateSpaceUserFB_funcPtr = (delegate* unmanaged<XrSession, XrSpaceUserCreateInfoFB*, XrSpaceUserFB*, XrResult>)GetFunctionPointer("xrCreateSpaceUserFB"u8);
            xrGetSpaceUserIdFB_funcPtr = (delegate* unmanaged<XrSpaceUserFB, ulong*, XrResult>)GetFunctionPointer("xrGetSpaceUserIdFB"u8);
            xrDestroySpaceUserFB_funcPtr = (delegate* unmanaged<XrSpaceUserFB, XrResult>)GetFunctionPointer("xrDestroySpaceUserFB"u8);
        }
        if (HasExtensionEnabled("XR_META_passthrough_color_lut"u8))
        {
            xrCreatePassthroughColorLutMETA_funcPtr = (delegate* unmanaged<XrPassthroughFB, XrPassthroughColorLutCreateInfoMETA*, XrPassthroughColorLutMETA*, XrResult>)GetFunctionPointer("xrCreatePassthroughColorLutMETA"u8);
            xrDestroyPassthroughColorLutMETA_funcPtr = (delegate* unmanaged<XrPassthroughColorLutMETA, XrResult>)GetFunctionPointer("xrDestroyPassthroughColorLutMETA"u8);
            xrUpdatePassthroughColorLutMETA_funcPtr = (delegate* unmanaged<XrPassthroughColorLutMETA, XrPassthroughColorLutUpdateInfoMETA*, XrResult>)GetFunctionPointer("xrUpdatePassthroughColorLutMETA"u8);
        }
        if (HasExtensionEnabled("XR_QCOM_tracking_optimization_settings"u8))
        {
            xrSetTrackingOptimizationSettingsHintQCOM_funcPtr = (delegate* unmanaged<XrSession, XrTrackingOptimizationSettingsDomainQCOM, XrTrackingOptimizationSettingsHintQCOM, XrResult>)GetFunctionPointer("xrSetTrackingOptimizationSettingsHintQCOM"u8);
        }
        if (HasExtensionEnabled("XR_HTC_passthrough"u8))
        {
            xrCreatePassthroughHTC_funcPtr = (delegate* unmanaged<XrSession, XrPassthroughCreateInfoHTC*, XrPassthroughHTC*, XrResult>)GetFunctionPointer("xrCreatePassthroughHTC"u8);
            xrDestroyPassthroughHTC_funcPtr = (delegate* unmanaged<XrPassthroughHTC, XrResult>)GetFunctionPointer("xrDestroyPassthroughHTC"u8);
        }
        if (HasExtensionEnabled("XR_HTC_foveation"u8))
        {
            xrApplyFoveationHTC_funcPtr = (delegate* unmanaged<XrSession, XrFoveationApplyInfoHTC*, XrResult>)GetFunctionPointer("xrApplyFoveationHTC"u8);
        }
        if (HasExtensionEnabled("XR_MNDX_force_feedback_curl"u8))
        {
            xrApplyForceFeedbackCurlMNDX_funcPtr = (delegate* unmanaged<XrHandTrackerEXT, XrForceFeedbackCurlApplyLocationsMNDX*, XrResult>)GetFunctionPointer("xrApplyForceFeedbackCurlMNDX"u8);
        }
        if (HasExtensionEnabled("XR_EXT_plane_detection"u8))
        {
            xrCreatePlaneDetectorEXT_funcPtr = (delegate* unmanaged<XrSession, XrPlaneDetectorCreateInfoEXT*, XrPlaneDetectorEXT*, XrResult>)GetFunctionPointer("xrCreatePlaneDetectorEXT"u8);
            xrDestroyPlaneDetectorEXT_funcPtr = (delegate* unmanaged<XrPlaneDetectorEXT, XrResult>)GetFunctionPointer("xrDestroyPlaneDetectorEXT"u8);
            xrBeginPlaneDetectionEXT_funcPtr = (delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectorBeginInfoEXT*, XrResult>)GetFunctionPointer("xrBeginPlaneDetectionEXT"u8);
            xrGetPlaneDetectionStateEXT_funcPtr = (delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectionStateEXT*, XrResult>)GetFunctionPointer("xrGetPlaneDetectionStateEXT"u8);
            xrGetPlaneDetectionsEXT_funcPtr = (delegate* unmanaged<XrPlaneDetectorEXT, XrPlaneDetectorGetInfoEXT*, XrPlaneDetectorLocationsEXT*, XrResult>)GetFunctionPointer("xrGetPlaneDetectionsEXT"u8);
            xrGetPlanePolygonBufferEXT_funcPtr = (delegate* unmanaged<XrPlaneDetectorEXT, ulong, uint, XrPlaneDetectorPolygonBufferEXT*, XrResult>)GetFunctionPointer("xrGetPlanePolygonBufferEXT"u8);
        }
    }
#pragma warning restore CA1822 // Mark members as static
}