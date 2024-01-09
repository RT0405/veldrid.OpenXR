using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Veldrid.OpenXR.Native;
public static unsafe partial class OpenXRNative
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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetInstanceProcAddr(XrInstance instance, byte* name, void** function);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrEnumerateApiLayerProperties(uint propertyCapacityInput, uint* propertyCountOutput, XrApiLayerProperties* properties);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrEnumerateInstanceExtensionProperties(byte* layerName, uint propertyCapacityInput, uint* propertyCountOutput, XrExtensionProperties* properties);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [LibraryImport(LoaderName, EntryPoint = "xrCreateInstance")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    private static partial XrResult xrCreateInstanceNative(XrInstanceCreateInfo* createInfo, XrInstance* instance);
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
    public static XrResult xrCreateInstance(XrInstanceCreateInfo* createInfo, XrInstance* instance)
    {
        XrResult result = xrCreateInstanceNative(createInfo, instance);
        if(result == XrResult.XR_SUCCESS)
            Instance = new(*instance, *createInfo);
        return result;
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [LibraryImport(LoaderName, EntryPoint = "xrDestroyInstance")]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    private static partial XrResult xrDestroyInstanceNative(XrInstance instance);
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    public static XrResult xrDestroyInstance(XrInstance instance)
    {
        XrResult result = xrDestroyInstanceNative(instance);
        if(Instance?.XrInstance == instance)
            Instance = null;
        return result;
    }
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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetInstanceProperties(XrInstance instance, XrInstanceProperties* instanceProperties);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrPollEvent(XrInstance instance, XrEventDataBuffer* eventData);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrResultToString(XrInstance instance, XrResult value, byte buffer);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrStructureTypeToString(XrInstance instance, XrStructureType value, byte buffer);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetSystem(XrInstance instance, XrSystemGetInfo* getInfo, ulong* systemId);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetSystemProperties(XrInstance instance, ulong systemId, XrSystemProperties* properties);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrEnumerateEnvironmentBlendModes(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint environmentBlendModeCapacityInput, uint* environmentBlendModeCountOutput, XrEnvironmentBlendMode* environmentBlendModes);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrCreateSession(XrInstance instance, XrSessionCreateInfo* createInfo, XrSession* session);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrDestroySession(XrSession session);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrEnumerateReferenceSpaces(XrSession session, uint spaceCapacityInput, uint* spaceCountOutput, XrReferenceSpaceType* spaces);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrCreateReferenceSpace(XrSession session, XrReferenceSpaceCreateInfo* createInfo, XrSpace* space);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetReferenceSpaceBoundsRect(XrSession session, XrReferenceSpaceType referenceSpaceType, XrExtent2Df* bounds);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrCreateActionSpace(XrSession session, XrActionSpaceCreateInfo* createInfo, XrSpace* space);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrLocateSpace(XrSpace space, XrSpace baseSpace, long time, XrSpaceLocation* location);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrDestroySpace(XrSpace space);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrEnumerateViewConfigurations(XrInstance instance, ulong systemId, uint viewConfigurationTypeCapacityInput, uint* viewConfigurationTypeCountOutput, XrViewConfigurationType* viewConfigurationTypes);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetViewConfigurationProperties(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, XrViewConfigurationProperties* configurationProperties);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrEnumerateViewConfigurationViews(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint viewCapacityInput, uint* viewCountOutput, XrViewConfigurationView* views);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrEnumerateSwapchainFormats(XrSession session, uint formatCapacityInput, uint* formatCountOutput, long* formats);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrCreateSwapchain(XrSession session, XrSwapchainCreateInfo* createInfo, XrSwapchain* swapchain);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrDestroySwapchain(XrSwapchain swapchain);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrEnumerateSwapchainImages(XrSwapchain swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrAcquireSwapchainImage(XrSwapchain swapchain, XrSwapchainImageAcquireInfo* acquireInfo, uint* index);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrWaitSwapchainImage(XrSwapchain swapchain, XrSwapchainImageWaitInfo* waitInfo);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrReleaseSwapchainImage(XrSwapchain swapchain, XrSwapchainImageReleaseInfo* releaseInfo);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrBeginSession(XrSession session, XrSessionBeginInfo* beginInfo);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrEndSession(XrSession session);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrRequestExitSession(XrSession session);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrWaitFrame(XrSession session, XrFrameWaitInfo* frameWaitInfo, XrFrameState* frameState);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrBeginFrame(XrSession session, XrFrameBeginInfo* frameBeginInfo);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrEndFrame(XrSession session, XrFrameEndInfo* frameEndInfo);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrLocateViews(XrSession session, XrViewLocateInfo* viewLocateInfo, XrViewState* viewState, uint viewCapacityInput, uint* viewCountOutput, XrView* views);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrStringToPath(XrInstance instance, byte* pathString, ulong* path);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrPathToString(XrInstance instance, ulong path, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrCreateActionSet(XrInstance instance, XrActionSetCreateInfo* createInfo, XrActionSet* actionSet);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrDestroyActionSet(XrActionSet actionSet);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrCreateAction(XrActionSet actionSet, XrActionCreateInfo* createInfo, XrAction* action);

    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrDestroyAction(XrAction action);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrSuggestInteractionProfileBindings(XrInstance instance, XrInteractionProfileSuggestedBinding* suggestedBindings);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrAttachSessionActionSets(XrSession session, XrSessionActionSetsAttachInfo* attachInfo);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetCurrentInteractionProfile(XrSession session, ulong topLevelUserPath, XrInteractionProfileState* interactionProfile);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetActionStateBoolean(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateBoolean* state);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetActionStateFloat(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateFloat* state);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetActionStateVector2f(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateVector2f* state);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetActionStatePose(XrSession session, XrActionStateGetInfo* getInfo, XrActionStatePose* state);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrSyncActions(XrSession session, XrActionsSyncInfo* syncInfo);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrEnumerateBoundSourcesForAction(XrSession session, XrBoundSourcesForActionEnumerateInfo* enumerateInfo, uint sourceCapacityInput, uint* sourceCountOutput, ulong* sources);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrGetInputSourceLocalizedName(XrSession session, XrInputSourceLocalizedNameGetInfo* getInfo, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrApplyHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo, XrHapticBaseHeader* hapticFeedback);

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
    [LibraryImport(LoaderName)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    public static partial XrResult xrStopHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo);

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
    public static XrResult xrSetAndroidApplicationThreadKHR(XrSession session, XrAndroidThreadTypeKHR threadType, uint threadId)
        => Instance.xrSetAndroidApplicationThreadKHR(session, threadType, threadId);

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
    public static XrResult xrCreateSwapchainAndroidSurfaceKHR(XrSession session, XrSwapchainCreateInfo* info, XrSwapchain* swapchain, nint* surface)
        => Instance.xrCreateSwapchainAndroidSurfaceKHR(session, info, swapchain, surface);

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
    public static XrResult xrPerfSettingsSetPerformanceLevelEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsLevelEXT level)
        => Instance.xrPerfSettingsSetPerformanceLevelEXT(session, domain, level);

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
    public static XrResult xrThermalGetTemperatureTrendEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsNotificationLevelEXT* notificationLevel, float* tempHeadroom, float* tempSlope)
        => Instance.xrThermalGetTemperatureTrendEXT(session, domain, notificationLevel, tempHeadroom, tempSlope);

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
    public static XrResult xrSetDebugUtilsObjectNameEXT(XrInstance instance, XrDebugUtilsObjectNameInfoEXT* nameInfo)
        => Instance.xrSetDebugUtilsObjectNameEXT(instance, nameInfo);

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
    public static XrResult xrCreateDebugUtilsMessengerEXT(XrInstance instance, XrDebugUtilsMessengerCreateInfoEXT* createInfo, XrDebugUtilsMessengerEXT* messenger)
        => Instance.xrCreateDebugUtilsMessengerEXT(instance, createInfo, messenger);

    /// <summary> Requires XR extension "XR_EXT_debug_utils" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static XrResult xrDestroyDebugUtilsMessengerEXT(XrDebugUtilsMessengerEXT messenger)
        => Instance.xrDestroyDebugUtilsMessengerEXT(messenger);

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
    public static XrResult xrSubmitDebugUtilsMessageEXT(XrInstance instance, ulong messageSeverity, ulong messageTypes, XrDebugUtilsMessengerCallbackDataEXT* callbackData)
        => Instance.xrSubmitDebugUtilsMessageEXT(instance, messageSeverity, messageTypes, callbackData);

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
    public static XrResult xrSessionBeginDebugUtilsLabelRegionEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo)
        => Instance.xrSessionBeginDebugUtilsLabelRegionEXT(session, labelInfo);

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
    public static XrResult xrSessionEndDebugUtilsLabelRegionEXT(XrSession session)
        => Instance.xrSessionEndDebugUtilsLabelRegionEXT(session);

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
    public static XrResult xrSessionInsertDebugUtilsLabelEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo)
        => Instance.xrSessionInsertDebugUtilsLabelEXT(session, labelInfo);

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
    public static XrResult xrGetOpenGLGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLKHR* graphicsRequirements)
        => Instance.xrGetOpenGLGraphicsRequirementsKHR(instance, systemId, graphicsRequirements);

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
    public static XrResult xrGetOpenGLESGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLESKHR* graphicsRequirements)
        => Instance.xrGetOpenGLESGraphicsRequirementsKHR(instance, systemId, graphicsRequirements);

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
    public static XrResult xrGetVulkanInstanceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        => Instance.xrGetVulkanInstanceExtensionsKHR(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);

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
    public static XrResult xrGetVulkanDeviceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        => Instance.xrGetVulkanDeviceExtensionsKHR(instance, systemId, bufferCapacityInput, bufferCountOutput, buffer);

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
    public static XrResult xrGetVulkanGraphicsDeviceKHR(XrInstance instance, ulong systemId, nint vkInstance, nint* vkPhysicalDevice)
        => Instance.xrGetVulkanGraphicsDeviceKHR(instance, systemId, vkInstance, vkPhysicalDevice);

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
    public static XrResult xrGetVulkanGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsVulkanKHR* graphicsRequirements)
        => Instance.xrGetVulkanGraphicsRequirementsKHR(instance, systemId, graphicsRequirements);

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
    public static XrResult xrGetD3D11GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D11KHR* graphicsRequirements)
        => Instance.xrGetD3D11GraphicsRequirementsKHR(instance, systemId, graphicsRequirements);

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
    public static XrResult xrGetD3D12GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D12KHR* graphicsRequirements)
        => Instance.xrGetD3D12GraphicsRequirementsKHR(instance, systemId, graphicsRequirements);

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
    public static XrResult xrGetVisibilityMaskKHR(XrSession session, XrViewConfigurationType viewConfigurationType, uint viewIndex, XrVisibilityMaskTypeKHR visibilityMaskType, XrVisibilityMaskKHR* visibilityMask)
        => Instance.xrGetVisibilityMaskKHR(session, viewConfigurationType, viewIndex, visibilityMaskType, visibilityMask);

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
    public static XrResult xrConvertWin32PerformanceCounterToTimeKHR(XrInstance instance, nint* performanceCounter, long* time)
        => Instance.xrConvertWin32PerformanceCounterToTimeKHR(instance, performanceCounter, time);

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
    public static XrResult xrConvertTimeToWin32PerformanceCounterKHR(XrInstance instance, long time, nint* performanceCounter)
        => Instance.xrConvertTimeToWin32PerformanceCounterKHR(instance, time, performanceCounter);

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
    public static XrResult xrConvertTimespecTimeToTimeKHR(XrInstance instance, nint* timespecTime, long* time)
        => Instance.xrConvertTimespecTimeToTimeKHR(instance, timespecTime, time);

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
    public static XrResult xrConvertTimeToTimespecTimeKHR(XrInstance instance, long time, nint* timespecTime)
        => Instance.xrConvertTimeToTimespecTimeKHR(instance, time, timespecTime);

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
    public static XrResult xrCreateSpatialAnchorMSFT(XrSession session, XrSpatialAnchorCreateInfoMSFT* createInfo, XrSpatialAnchorMSFT* anchor)
        => Instance.xrCreateSpatialAnchorMSFT(session, createInfo, anchor);

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
    public static XrResult xrCreateSpatialAnchorSpaceMSFT(XrSession session, XrSpatialAnchorSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        => Instance.xrCreateSpatialAnchorSpaceMSFT(session, createInfo, space);

    /// <summary> Requires XR extension "XR_MSFT_spatial_anchor" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static XrResult xrDestroySpatialAnchorMSFT(XrSpatialAnchorMSFT anchor)
        => Instance.xrDestroySpatialAnchorMSFT(anchor);

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
    public static XrResult xrSetInputDeviceActiveEXT(XrSession session, ulong interactionProfile, ulong topLevelPath, XrBool32 isActive)
        => Instance.xrSetInputDeviceActiveEXT(session, interactionProfile, topLevelPath, isActive);

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
    public static XrResult xrSetInputDeviceStateBoolEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrBool32 state)
        => Instance.xrSetInputDeviceStateBoolEXT(session, topLevelPath, inputSourcePath, state);

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
    public static XrResult xrSetInputDeviceStateFloatEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, float state)
        => Instance.xrSetInputDeviceStateFloatEXT(session, topLevelPath, inputSourcePath, state);

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
    public static XrResult xrSetInputDeviceStateVector2fEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrVector2f state)
        => Instance.xrSetInputDeviceStateVector2fEXT(session, topLevelPath, inputSourcePath, state);

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
    public static XrResult xrSetInputDeviceLocationEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrSpace space, XrPosef pose)
        => Instance.xrSetInputDeviceLocationEXT(session, topLevelPath, inputSourcePath, space, pose);

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
    public static XrResult xrCreateSpatialGraphNodeSpaceMSFT(XrSession session, XrSpatialGraphNodeSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        => Instance.xrCreateSpatialGraphNodeSpaceMSFT(session, createInfo, space);

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
    public static XrResult xrTryCreateSpatialGraphStaticNodeBindingMSFT(XrSession session, XrSpatialGraphStaticNodeBindingCreateInfoMSFT* createInfo, XrSpatialGraphNodeBindingMSFT* nodeBinding)
        => Instance.xrTryCreateSpatialGraphStaticNodeBindingMSFT(session, createInfo, nodeBinding);

    /// <summary> Requires XR extension "XR_MSFT_spatial_graph_bridge" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static XrResult xrDestroySpatialGraphNodeBindingMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding)
        => Instance.xrDestroySpatialGraphNodeBindingMSFT(nodeBinding);

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
    public static XrResult xrGetSpatialGraphNodeBindingPropertiesMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT* getInfo, XrSpatialGraphNodeBindingPropertiesMSFT* properties)
        => Instance.xrGetSpatialGraphNodeBindingPropertiesMSFT(nodeBinding, getInfo, properties);

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
    public static XrResult xrCreateHandTrackerEXT(XrSession session, XrHandTrackerCreateInfoEXT* createInfo, XrHandTrackerEXT* handTracker)
        => Instance.xrCreateHandTrackerEXT(session, createInfo, handTracker);

    /// <summary> Requires XR extension "XR_EXT_hand_tracking" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static XrResult xrDestroyHandTrackerEXT(XrHandTrackerEXT handTracker)
        => Instance.xrDestroyHandTrackerEXT(handTracker);

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
    public static XrResult xrLocateHandJointsEXT(XrHandTrackerEXT handTracker, XrHandJointsLocateInfoEXT* locateInfo, XrHandJointLocationsEXT* locations)
        => Instance.xrLocateHandJointsEXT(handTracker, locateInfo, locations);

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
    public static XrResult xrCreateHandMeshSpaceMSFT(XrHandTrackerEXT handTracker, XrHandMeshSpaceCreateInfoMSFT* createInfo, XrSpace* space)
        => Instance.xrCreateHandMeshSpaceMSFT(handTracker, createInfo, space);

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
    public static XrResult xrUpdateHandMeshMSFT(XrHandTrackerEXT handTracker, XrHandMeshUpdateInfoMSFT* updateInfo, XrHandMeshMSFT* handMesh)
        => Instance.xrUpdateHandMeshMSFT(handTracker, updateInfo, handMesh);

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
    public static XrResult xrGetControllerModelKeyMSFT(XrSession session, ulong topLevelUserPath, XrControllerModelKeyStateMSFT* controllerModelKeyState)
        => Instance.xrGetControllerModelKeyMSFT(session, topLevelUserPath, controllerModelKeyState);

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
    public static XrResult xrLoadControllerModelMSFT(XrSession session, ulong modelKey, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer)
        => Instance.xrLoadControllerModelMSFT(session, modelKey, bufferCapacityInput, bufferCountOutput, buffer);

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
    public static XrResult xrGetControllerModelPropertiesMSFT(XrSession session, ulong modelKey, XrControllerModelPropertiesMSFT* properties)
        => Instance.xrGetControllerModelPropertiesMSFT(session, modelKey, properties);

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
    public static XrResult xrGetControllerModelStateMSFT(XrSession session, ulong modelKey, XrControllerModelStateMSFT* state)
        => Instance.xrGetControllerModelStateMSFT(session, modelKey, state);

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
    public static XrResult xrCreateSpatialAnchorFromPerceptionAnchorMSFT(XrSession session, nint* perceptionAnchor, XrSpatialAnchorMSFT* anchor)
        => Instance.xrCreateSpatialAnchorFromPerceptionAnchorMSFT(session, perceptionAnchor, anchor);

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
    public static XrResult xrTryGetPerceptionAnchorFromSpatialAnchorMSFT(XrSession session, XrSpatialAnchorMSFT anchor, nint** perceptionAnchor)
        => Instance.xrTryGetPerceptionAnchorFromSpatialAnchorMSFT(session, anchor, perceptionAnchor);

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
    public static XrResult xrEnumerateReprojectionModesMSFT(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint modeCapacityInput, uint* modeCountOutput, XrReprojectionModeMSFT* modes)
        => Instance.xrEnumerateReprojectionModesMSFT(instance, systemId, viewConfigurationType, modeCapacityInput, modeCountOutput, modes);

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
    public static XrResult xrUpdateSwapchainFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state)
        => Instance.xrUpdateSwapchainFB(swapchain, state);

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
    public static XrResult xrGetSwapchainStateFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state)
        => Instance.xrGetSwapchainStateFB(swapchain, state);

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
    public static XrResult xrCreateBodyTrackerFB(XrSession session, XrBodyTrackerCreateInfoFB* createInfo, XrBodyTrackerFB* bodyTracker)
        => Instance.xrCreateBodyTrackerFB(session, createInfo, bodyTracker);

    /// <summary> Requires XR extension "XR_FB_body_tracking" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static XrResult xrDestroyBodyTrackerFB(XrBodyTrackerFB bodyTracker)
        => Instance.xrDestroyBodyTrackerFB(bodyTracker);

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
    public static XrResult xrLocateBodyJointsFB(XrBodyTrackerFB bodyTracker, XrBodyJointsLocateInfoFB* locateInfo, XrBodyJointLocationsFB* locations)
        => Instance.xrLocateBodyJointsFB(bodyTracker, locateInfo, locations);

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
    public static XrResult xrGetBodySkeletonFB(XrBodyTrackerFB bodyTracker, XrBodySkeletonFB* skeleton)
        => Instance.xrGetBodySkeletonFB(bodyTracker, skeleton);

    /// <summary> Requires XR extension "XR_KHR_loader_init" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_VALIDATION_FAILURE"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static XrResult xrInitializeLoaderKHR(XrLoaderInitInfoBaseHeaderKHR* loaderInitInfo)
        => Instance.xrInitializeLoaderKHR(loaderInitInfo);

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
    public static XrResult xrCreateVulkanInstanceKHR(XrInstance instance, XrVulkanInstanceCreateInfoKHR* createInfo, nint* vulkanInstance, nint* vulkanResult)
        => Instance.xrCreateVulkanInstanceKHR(instance, createInfo, vulkanInstance, vulkanResult);

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
    public static XrResult xrCreateVulkanDeviceKHR(XrInstance instance, XrVulkanDeviceCreateInfoKHR* createInfo, nint* vulkanDevice, nint* vulkanResult)
        => Instance.xrCreateVulkanDeviceKHR(instance, createInfo, vulkanDevice, vulkanResult);

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
    public static XrResult xrGetVulkanGraphicsDevice2KHR(XrInstance instance, XrVulkanGraphicsDeviceGetInfoKHR* getInfo, nint* vulkanPhysicalDevice)
        => Instance.xrGetVulkanGraphicsDevice2KHR(instance, getInfo, vulkanPhysicalDevice);

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
    public static XrResult xrEnumerateSceneComputeFeaturesMSFT(XrInstance instance, ulong systemId, uint featureCapacityInput, uint* featureCountOutput, XrSceneComputeFeatureMSFT* features)
        => Instance.xrEnumerateSceneComputeFeaturesMSFT(instance, systemId, featureCapacityInput, featureCountOutput, features);

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
    public static XrResult xrCreateSceneObserverMSFT(XrSession session, XrSceneObserverCreateInfoMSFT* createInfo, XrSceneObserverMSFT* sceneObserver)
        => Instance.xrCreateSceneObserverMSFT(session, createInfo, sceneObserver);

    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static XrResult xrDestroySceneObserverMSFT(XrSceneObserverMSFT sceneObserver)
        => Instance.xrDestroySceneObserverMSFT(sceneObserver);

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
    public static XrResult xrCreateSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneCreateInfoMSFT* createInfo, XrSceneMSFT* scene)
        => Instance.xrCreateSceneMSFT(sceneObserver, createInfo, scene);

    /// <summary> Requires XR extension "XR_MSFT_scene_understanding" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static XrResult xrDestroySceneMSFT(XrSceneMSFT scene)
        => Instance.xrDestroySceneMSFT(scene);

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
    public static XrResult xrComputeNewSceneMSFT(XrSceneObserverMSFT sceneObserver, XrNewSceneComputeInfoMSFT* computeInfo)
        => Instance.xrComputeNewSceneMSFT(sceneObserver, computeInfo);

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
    public static XrResult xrGetSceneComputeStateMSFT(XrSceneObserverMSFT sceneObserver, XrSceneComputeStateMSFT* state)
        => Instance.xrGetSceneComputeStateMSFT(sceneObserver, state);

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
    public static XrResult xrGetSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsGetInfoMSFT* getInfo, XrSceneComponentsMSFT* components)
        => Instance.xrGetSceneComponentsMSFT(scene, getInfo, components);

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
    public static XrResult xrLocateSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsLocateInfoMSFT* locateInfo, XrSceneComponentLocationsMSFT* locations)
        => Instance.xrLocateSceneComponentsMSFT(scene, locateInfo, locations);

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
    public static XrResult xrGetSceneMeshBuffersMSFT(XrSceneMSFT scene, XrSceneMeshBuffersGetInfoMSFT* getInfo, XrSceneMeshBuffersMSFT* buffers)
        => Instance.xrGetSceneMeshBuffersMSFT(scene, getInfo, buffers);

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
    public static XrResult xrDeserializeSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneDeserializeInfoMSFT* deserializeInfo)
        => Instance.xrDeserializeSceneMSFT(sceneObserver, deserializeInfo);

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
    public static XrResult xrGetSerializedSceneFragmentDataMSFT(XrSceneMSFT scene, XrSerializedSceneFragmentDataGetInfoMSFT* getInfo, uint countInput, uint* readOutput, byte* buffer)
        => Instance.xrGetSerializedSceneFragmentDataMSFT(scene, getInfo, countInput, readOutput, buffer);

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
    public static XrResult xrEnumerateDisplayRefreshRatesFB(XrSession session, uint displayRefreshRateCapacityInput, uint* displayRefreshRateCountOutput, float* displayRefreshRates)
        => Instance.xrEnumerateDisplayRefreshRatesFB(session, displayRefreshRateCapacityInput, displayRefreshRateCountOutput, displayRefreshRates);

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
    public static XrResult xrGetDisplayRefreshRateFB(XrSession session, float* displayRefreshRate)
        => Instance.xrGetDisplayRefreshRateFB(session, displayRefreshRate);

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
    public static XrResult xrRequestDisplayRefreshRateFB(XrSession session, float displayRefreshRate)
        => Instance.xrRequestDisplayRefreshRateFB(session, displayRefreshRate);

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
    public static XrResult xrEnumerateViveTrackerPathsHTCX(XrInstance instance, uint pathCapacityInput, uint* pathCountOutput, XrViveTrackerPathsHTCX* paths)
        => Instance.xrEnumerateViveTrackerPathsHTCX(instance, pathCapacityInput, pathCountOutput, paths);

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
    public static XrResult xrCreateFacialTrackerHTC(XrSession session, XrFacialTrackerCreateInfoHTC* createInfo, XrFacialTrackerHTC* facialTracker)
        => Instance.xrCreateFacialTrackerHTC(session, createInfo, facialTracker);

    /// <summary> Requires XR extension "XR_HTC_facial_tracking" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static XrResult xrDestroyFacialTrackerHTC(XrFacialTrackerHTC facialTracker)
        => Instance.xrDestroyFacialTrackerHTC(facialTracker);

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
    public static XrResult xrGetFacialExpressionsHTC(XrFacialTrackerHTC facialTracker, XrFacialExpressionsHTC* facialExpressions)
        => Instance.xrGetFacialExpressionsHTC(facialTracker, facialExpressions);

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
    public static XrResult xrEnumerateColorSpacesFB(XrSession session, uint colorSpaceCapacityInput, uint* colorSpaceCountOutput, XrColorSpaceFB* colorSpaces)
        => Instance.xrEnumerateColorSpacesFB(session, colorSpaceCapacityInput, colorSpaceCountOutput, colorSpaces);

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
    public static XrResult xrSetColorSpaceFB(XrSession session, XrColorSpaceFB colorSpace)
        => Instance.xrSetColorSpaceFB(session, colorSpace);

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
    public static XrResult xrGetHandMeshFB(XrHandTrackerEXT handTracker, XrHandTrackingMeshFB* mesh)
        => Instance.xrGetHandMeshFB(handTracker, mesh);

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
    public static XrResult xrCreateSpatialAnchorFB(XrSession session, XrSpatialAnchorCreateInfoFB* info, ulong* requestId)
        => Instance.xrCreateSpatialAnchorFB(session, info, requestId);

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
    public static XrResult xrGetSpaceUuidFB(XrSpace space, XrUuidEXT* uuid)
        => Instance.xrGetSpaceUuidFB(space, uuid);

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
    public static XrResult xrEnumerateSpaceSupportedComponentsFB(XrSpace space, uint componentTypeCapacityInput, uint* componentTypeCountOutput, XrSpaceComponentTypeFB* componentTypes)
        => Instance.xrEnumerateSpaceSupportedComponentsFB(space, componentTypeCapacityInput, componentTypeCountOutput, componentTypes);

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
    public static XrResult xrSetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentStatusSetInfoFB* info, ulong* requestId)
        => Instance.xrSetSpaceComponentStatusFB(space, info, requestId);

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
    public static XrResult xrGetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentTypeFB componentType, XrSpaceComponentStatusFB* status)
        => Instance.xrGetSpaceComponentStatusFB(space, componentType, status);

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
    public static XrResult xrCreateFoveationProfileFB(XrSession session, XrFoveationProfileCreateInfoFB* createInfo, XrFoveationProfileFB* profile)
        => Instance.xrCreateFoveationProfileFB(session, createInfo, profile);

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
    public static XrResult xrDestroyFoveationProfileFB(XrFoveationProfileFB profile)
        => Instance.xrDestroyFoveationProfileFB(profile);

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
    public static XrResult xrQuerySystemTrackedKeyboardFB(XrSession session, XrKeyboardTrackingQueryFB* queryInfo, XrKeyboardTrackingDescriptionFB* keyboard)
        => Instance.xrQuerySystemTrackedKeyboardFB(session, queryInfo, keyboard);

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
    public static XrResult xrCreateKeyboardSpaceFB(XrSession session, XrKeyboardSpaceCreateInfoFB* createInfo, XrSpace* keyboardSpace)
        => Instance.xrCreateKeyboardSpaceFB(session, createInfo, keyboardSpace);

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
    public static XrResult xrCreateTriangleMeshFB(XrSession session, XrTriangleMeshCreateInfoFB* createInfo, XrTriangleMeshFB* outTriangleMesh)
        => Instance.xrCreateTriangleMeshFB(session, createInfo, outTriangleMesh);

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
    public static XrResult xrDestroyTriangleMeshFB(XrTriangleMeshFB mesh)
        => Instance.xrDestroyTriangleMeshFB(mesh);

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
    public static XrResult xrTriangleMeshGetVertexBufferFB(XrTriangleMeshFB mesh, XrVector3f** outVertexBuffer)
        => Instance.xrTriangleMeshGetVertexBufferFB(mesh, outVertexBuffer);

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
    public static XrResult xrTriangleMeshGetIndexBufferFB(XrTriangleMeshFB mesh, uint** outIndexBuffer)
        => Instance.xrTriangleMeshGetIndexBufferFB(mesh, outIndexBuffer);

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
    public static XrResult xrTriangleMeshBeginUpdateFB(XrTriangleMeshFB mesh)
        => Instance.xrTriangleMeshBeginUpdateFB(mesh);

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
    public static XrResult xrTriangleMeshEndUpdateFB(XrTriangleMeshFB mesh, uint vertexCount, uint triangleCount)
        => Instance.xrTriangleMeshEndUpdateFB(mesh, vertexCount, triangleCount);

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
    public static XrResult xrTriangleMeshBeginVertexBufferUpdateFB(XrTriangleMeshFB mesh, uint* outVertexCount)
        => Instance.xrTriangleMeshBeginVertexBufferUpdateFB(mesh, outVertexCount);

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
    public static XrResult xrTriangleMeshEndVertexBufferUpdateFB(XrTriangleMeshFB mesh)
        => Instance.xrTriangleMeshEndVertexBufferUpdateFB(mesh);

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
    public static XrResult xrCreatePassthroughFB(XrSession session, XrPassthroughCreateInfoFB* createInfo, XrPassthroughFB* outPassthrough)
        => Instance.xrCreatePassthroughFB(session, createInfo, outPassthrough);

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
    public static XrResult xrDestroyPassthroughFB(XrPassthroughFB passthrough)
        => Instance.xrDestroyPassthroughFB(passthrough);

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
    public static XrResult xrPassthroughStartFB(XrPassthroughFB passthrough)
        => Instance.xrPassthroughStartFB(passthrough);

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
    public static XrResult xrPassthroughPauseFB(XrPassthroughFB passthrough)
        => Instance.xrPassthroughPauseFB(passthrough);

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
    public static XrResult xrCreatePassthroughLayerFB(XrSession session, XrPassthroughLayerCreateInfoFB* createInfo, XrPassthroughLayerFB* outLayer)
        => Instance.xrCreatePassthroughLayerFB(session, createInfo, outLayer);

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
    public static XrResult xrDestroyPassthroughLayerFB(XrPassthroughLayerFB layer)
        => Instance.xrDestroyPassthroughLayerFB(layer);

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
    public static XrResult xrPassthroughLayerPauseFB(XrPassthroughLayerFB layer)
        => Instance.xrPassthroughLayerPauseFB(layer);

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
    public static XrResult xrPassthroughLayerResumeFB(XrPassthroughLayerFB layer)
        => Instance.xrPassthroughLayerResumeFB(layer);

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
    public static XrResult xrPassthroughLayerSetStyleFB(XrPassthroughLayerFB layer, XrPassthroughStyleFB* style)
        => Instance.xrPassthroughLayerSetStyleFB(layer, style);

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
    public static XrResult xrCreateGeometryInstanceFB(XrSession session, XrGeometryInstanceCreateInfoFB* createInfo, XrGeometryInstanceFB* outGeometryInstance)
        => Instance.xrCreateGeometryInstanceFB(session, createInfo, outGeometryInstance);

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
    public static XrResult xrDestroyGeometryInstanceFB(XrGeometryInstanceFB instance)
        => Instance.xrDestroyGeometryInstanceFB(instance);

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
    public static XrResult xrGeometryInstanceSetTransformFB(XrGeometryInstanceFB instance, XrGeometryInstanceTransformFB* transformation)
        => Instance.xrGeometryInstanceSetTransformFB(instance, transformation);

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
    public static XrResult xrEnumerateRenderModelPathsFB(XrSession session, uint pathCapacityInput, uint* pathCountOutput, XrRenderModelPathInfoFB* paths)
        => Instance.xrEnumerateRenderModelPathsFB(session, pathCapacityInput, pathCountOutput, paths);

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
    public static XrResult xrGetRenderModelPropertiesFB(XrSession session, ulong path, XrRenderModelPropertiesFB* properties)
        => Instance.xrGetRenderModelPropertiesFB(session, path, properties);

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
    public static XrResult xrLoadRenderModelFB(XrSession session, XrRenderModelLoadInfoFB* info, XrRenderModelBufferFB* buffer)
        => Instance.xrLoadRenderModelFB(session, info, buffer);

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
    public static XrResult xrSetEnvironmentDepthEstimationVARJO(XrSession session, XrBool32 enabled)
        => Instance.xrSetEnvironmentDepthEstimationVARJO(session, enabled);

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
    public static XrResult xrSetMarkerTrackingVARJO(XrSession session, XrBool32 enabled)
        => Instance.xrSetMarkerTrackingVARJO(session, enabled);

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
    public static XrResult xrSetMarkerTrackingTimeoutVARJO(XrSession session, ulong markerId, long timeout)
        => Instance.xrSetMarkerTrackingTimeoutVARJO(session, markerId, timeout);

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
    public static XrResult xrSetMarkerTrackingPredictionVARJO(XrSession session, ulong markerId, XrBool32 enable)
        => Instance.xrSetMarkerTrackingPredictionVARJO(session, markerId, enable);

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
    public static XrResult xrGetMarkerSizeVARJO(XrSession session, ulong markerId, XrExtent2Df* size)
        => Instance.xrGetMarkerSizeVARJO(session, markerId, size);

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
    public static XrResult xrCreateMarkerSpaceVARJO(XrSession session, XrMarkerSpaceCreateInfoVARJO* createInfo, XrSpace* space)
        => Instance.xrCreateMarkerSpaceVARJO(session, createInfo, space);

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
    public static XrResult xrSetViewOffsetVARJO(XrSession session, float offset)
        => Instance.xrSetViewOffsetVARJO(session, offset);

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
    public static XrResult xrCreateSpaceFromCoordinateFrameUIDML(XrSession session, XrCoordinateSpaceCreateInfoML createInfo, XrSpace* space)
        => Instance.xrCreateSpaceFromCoordinateFrameUIDML(session, createInfo, space);

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
    public static XrResult xrCreateSpatialAnchorStoreConnectionMSFT(XrSession session, XrSpatialAnchorStoreConnectionMSFT* spatialAnchorStore)
        => Instance.xrCreateSpatialAnchorStoreConnectionMSFT(session, spatialAnchorStore);

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
    public static XrResult xrDestroySpatialAnchorStoreConnectionMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore)
        => Instance.xrDestroySpatialAnchorStoreConnectionMSFT(spatialAnchorStore);

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
    public static XrResult xrPersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceInfoMSFT* spatialAnchorPersistenceInfo)
        => Instance.xrPersistSpatialAnchorMSFT(spatialAnchorStore, spatialAnchorPersistenceInfo);

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
    public static XrResult xrEnumeratePersistedSpatialAnchorNamesMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, uint spatialAnchorNamesCapacityInput, uint* spatialAnchorNamesCountOutput, XrSpatialAnchorPersistenceNameMSFT* persistedAnchorNames)
        => Instance.xrEnumeratePersistedSpatialAnchorNamesMSFT(spatialAnchorStore, spatialAnchorNamesCapacityInput, spatialAnchorNamesCountOutput, persistedAnchorNames);

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
    public static XrResult xrCreateSpatialAnchorFromPersistedNameMSFT(XrSession session, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, XrSpatialAnchorMSFT* spatialAnchor)
        => Instance.xrCreateSpatialAnchorFromPersistedNameMSFT(session, spatialAnchorCreateInfo, spatialAnchor);

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
    public static XrResult xrUnpersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorPersistenceName)
        => Instance.xrUnpersistSpatialAnchorMSFT(spatialAnchorStore, spatialAnchorPersistenceName);

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
    public static XrResult xrClearSpatialAnchorStoreMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore)
        => Instance.xrClearSpatialAnchorStoreMSFT(spatialAnchorStore);

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
    public static XrResult xrQuerySpacesFB(XrSession session, XrSpaceQueryInfoBaseHeaderFB* info, ulong* requestId)
        => Instance.xrQuerySpacesFB(session, info, requestId);

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
    public static XrResult xrRetrieveSpaceQueryResultsFB(XrSession session, ulong requestId, XrSpaceQueryResultsFB* results)
        => Instance.xrRetrieveSpaceQueryResultsFB(session, requestId, results);

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
    public static XrResult xrSaveSpaceFB(XrSession session, XrSpaceSaveInfoFB* info, ulong* requestId)
        => Instance.xrSaveSpaceFB(session, info, requestId);

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
    public static XrResult xrEraseSpaceFB(XrSession session, XrSpaceEraseInfoFB* info, ulong* requestId)
        => Instance.xrEraseSpaceFB(session, info, requestId);

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
    public static XrResult xrGetAudioOutputDeviceGuidOculus(XrInstance instance, void* buffer)
        => Instance.xrGetAudioOutputDeviceGuidOculus(instance, buffer);

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
    public static XrResult xrGetAudioInputDeviceGuidOculus(XrInstance instance, void* buffer)
        => Instance.xrGetAudioInputDeviceGuidOculus(instance, buffer);

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
    public static XrResult xrShareSpacesFB(XrSession session, XrSpaceShareInfoFB* info, ulong* requestId)
        => Instance.xrShareSpacesFB(session, info, requestId);

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
    public static XrResult xrGetSpaceBoundingBox2DFB(XrSession session, XrSpace space, XrRect2Df* boundingBox2DOutput)
        => Instance.xrGetSpaceBoundingBox2DFB(session, space, boundingBox2DOutput);

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
    public static XrResult xrGetSpaceBoundingBox3DFB(XrSession session, XrSpace space, XrRect3DfFB* boundingBox3DOutput)
        => Instance.xrGetSpaceBoundingBox3DFB(session, space, boundingBox3DOutput);

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
    public static XrResult xrGetSpaceSemanticLabelsFB(XrSession session, XrSpace space, XrSemanticLabelsFB* semanticLabelsOutput)
        => Instance.xrGetSpaceSemanticLabelsFB(session, space, semanticLabelsOutput);

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
    public static XrResult xrGetSpaceBoundary2DFB(XrSession session, XrSpace space, XrBoundary2DFB* boundary2DOutput)
        => Instance.xrGetSpaceBoundary2DFB(session, space, boundary2DOutput);

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
    public static XrResult xrGetSpaceRoomLayoutFB(XrSession session, XrSpace space, XrRoomLayoutFB* roomLayoutOutput)
        => Instance.xrGetSpaceRoomLayoutFB(session, space, roomLayoutOutput);

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
    public static XrResult xrSetDigitalLensControlALMALENCE(XrSession session, XrDigitalLensControlALMALENCE* digitalLensControl)
        => Instance.xrSetDigitalLensControlALMALENCE(session, digitalLensControl);

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
    public static XrResult xrRequestSceneCaptureFB(XrSession session, XrSceneCaptureRequestInfoFB* info, ulong* requestId)
        => Instance.xrRequestSceneCaptureFB(session, info, requestId);

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
    public static XrResult xrGetSpaceContainerFB(XrSession session, XrSpace space, XrSpaceContainerFB* spaceContainerOutput)
        => Instance.xrGetSpaceContainerFB(session, space, spaceContainerOutput);

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
    public static XrResult xrGetFoveationEyeTrackedStateMETA(XrSession session, XrFoveationEyeTrackedStateMETA* foveationState)
        => Instance.xrGetFoveationEyeTrackedStateMETA(session, foveationState);

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
    public static XrResult xrCreateFaceTrackerFB(XrSession session, XrFaceTrackerCreateInfoFB* createInfo, XrFaceTrackerFB* faceTracker)
        => Instance.xrCreateFaceTrackerFB(session, createInfo, faceTracker);

    /// <summary> Requires XR extension "XR_FB_face_tracking" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static XrResult xrDestroyFaceTrackerFB(XrFaceTrackerFB faceTracker)
        => Instance.xrDestroyFaceTrackerFB(faceTracker);

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
    public static XrResult xrGetFaceExpressionWeightsFB(XrFaceTrackerFB faceTracker, XrFaceExpressionInfoFB* expressionInfo, XrFaceExpressionWeightsFB* expressionWeights)
        => Instance.xrGetFaceExpressionWeightsFB(faceTracker, expressionInfo, expressionWeights);

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
    public static XrResult xrCreateEyeTrackerFB(XrSession session, XrEyeTrackerCreateInfoFB* createInfo, XrEyeTrackerFB* eyeTracker)
        => Instance.xrCreateEyeTrackerFB(session, createInfo, eyeTracker);

    /// <summary> Requires XR extension "XR_FB_eye_tracking_social" </summary>
    /// <returns>
    ///       Success Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_SUCCESS"/>
    /// <br/> Error Codes:
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_FUNCTION_UNSUPPORTED"/>
    /// <br/> ⠀⠀<see cref="XrResult.XR_ERROR_HANDLE_INVALID"/>
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static XrResult xrDestroyEyeTrackerFB(XrEyeTrackerFB eyeTracker)
        => Instance.xrDestroyEyeTrackerFB(eyeTracker);

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
    public static XrResult xrGetEyeGazesFB(XrEyeTrackerFB eyeTracker, XrEyeGazesInfoFB* gazeInfo, XrEyeGazesFB* eyeGazes)
        => Instance.xrGetEyeGazesFB(eyeTracker, gazeInfo, eyeGazes);

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
    public static XrResult xrPassthroughLayerSetKeyboardHandsIntensityFB(XrPassthroughLayerFB layer, XrPassthroughKeyboardHandsIntensityFB* intensity)
        => Instance.xrPassthroughLayerSetKeyboardHandsIntensityFB(layer, intensity);

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
    public static XrResult xrGetDeviceSampleRateFB(XrSession session, XrHapticActionInfo* hapticActionInfo, XrDevicePcmSampleRateStateFB* deviceSampleRate)
        => Instance.xrGetDeviceSampleRateFB(session, hapticActionInfo, deviceSampleRate);

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
    public static XrResult xrGetPassthroughPreferencesMETA(XrSession session, XrPassthroughPreferencesMETA* preferences)
        => Instance.xrGetPassthroughPreferencesMETA(session, preferences);

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
    public static XrResult xrCreateVirtualKeyboardMETA(XrSession session, XrVirtualKeyboardCreateInfoMETA* createInfo, XrVirtualKeyboardMETA* keyboard)
        => Instance.xrCreateVirtualKeyboardMETA(session, createInfo, keyboard);

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
    public static XrResult xrDestroyVirtualKeyboardMETA(XrVirtualKeyboardMETA keyboard)
        => Instance.xrDestroyVirtualKeyboardMETA(keyboard);

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
    public static XrResult xrCreateVirtualKeyboardSpaceMETA(XrSession session, XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardSpaceCreateInfoMETA* createInfo, XrSpace* keyboardSpace)
        => Instance.xrCreateVirtualKeyboardSpaceMETA(session, keyboard, createInfo, keyboardSpace);

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
    public static XrResult xrSuggestVirtualKeyboardLocationMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardLocationInfoMETA* locationInfo)
        => Instance.xrSuggestVirtualKeyboardLocationMETA(keyboard, locationInfo);

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
    public static XrResult xrGetVirtualKeyboardScaleMETA(XrVirtualKeyboardMETA keyboard, float* scale)
        => Instance.xrGetVirtualKeyboardScaleMETA(keyboard, scale);

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
    public static XrResult xrSetVirtualKeyboardModelVisibilityMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelVisibilitySetInfoMETA* modelVisibility)
        => Instance.xrSetVirtualKeyboardModelVisibilityMETA(keyboard, modelVisibility);

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
    public static XrResult xrGetVirtualKeyboardModelAnimationStatesMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelAnimationStatesMETA* animationStates)
        => Instance.xrGetVirtualKeyboardModelAnimationStatesMETA(keyboard, animationStates);

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
    public static XrResult xrGetVirtualKeyboardDirtyTexturesMETA(XrVirtualKeyboardMETA keyboard, uint textureIdCapacityInput, uint* textureIdCountOutput, ulong* textureIds)
        => Instance.xrGetVirtualKeyboardDirtyTexturesMETA(keyboard, textureIdCapacityInput, textureIdCountOutput, textureIds);

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
    public static XrResult xrGetVirtualKeyboardTextureDataMETA(XrVirtualKeyboardMETA keyboard, ulong textureId, XrVirtualKeyboardTextureDataMETA* textureData)
        => Instance.xrGetVirtualKeyboardTextureDataMETA(keyboard, textureId, textureData);

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
    public static XrResult xrSendVirtualKeyboardInputMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardInputInfoMETA* info, XrPosef* interactorRootPose)
        => Instance.xrSendVirtualKeyboardInputMETA(keyboard, info, interactorRootPose);

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
    public static XrResult xrChangeVirtualKeyboardTextContextMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardTextContextChangeInfoMETA* changeInfo)
        => Instance.xrChangeVirtualKeyboardTextContextMETA(keyboard, changeInfo);

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
    public static XrResult xrEnumerateExternalCamerasOCULUS(XrSession session, uint cameraCapacityInput, uint* cameraCountOutput, XrExternalCameraOCULUS* cameras)
        => Instance.xrEnumerateExternalCamerasOCULUS(session, cameraCapacityInput, cameraCountOutput, cameras);

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
    public static XrResult xrEnumeratePerformanceMetricsCounterPathsMETA(XrInstance instance, uint counterPathCapacityInput, uint* counterPathCountOutput, ulong* counterPaths)
        => Instance.xrEnumeratePerformanceMetricsCounterPathsMETA(instance, counterPathCapacityInput, counterPathCountOutput, counterPaths);

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
    public static XrResult xrSetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state)
        => Instance.xrSetPerformanceMetricsStateMETA(session, state);

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
    public static XrResult xrGetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state)
        => Instance.xrGetPerformanceMetricsStateMETA(session, state);

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
    public static XrResult xrQueryPerformanceMetricsCounterMETA(XrSession session, ulong counterPath, XrPerformanceMetricsCounterMETA* counter)
        => Instance.xrQueryPerformanceMetricsCounterMETA(session, counterPath, counter);

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
    public static XrResult xrSaveSpaceListFB(XrSession session, XrSpaceListSaveInfoFB* info, ulong* requestId)
        => Instance.xrSaveSpaceListFB(session, info, requestId);

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
    public static XrResult xrCreateSpaceUserFB(XrSession session, XrSpaceUserCreateInfoFB* info, XrSpaceUserFB* user)
        => Instance.xrCreateSpaceUserFB(session, info, user);

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
    public static XrResult xrGetSpaceUserIdFB(XrSpaceUserFB user, ulong* userId)
        => Instance.xrGetSpaceUserIdFB(user, userId);

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
    public static XrResult xrDestroySpaceUserFB(XrSpaceUserFB user)
        => Instance.xrDestroySpaceUserFB(user);

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
    public static XrResult xrCreatePassthroughColorLutMETA(XrPassthroughFB passthrough, XrPassthroughColorLutCreateInfoMETA* createInfo, XrPassthroughColorLutMETA* colorLut)
        => Instance.xrCreatePassthroughColorLutMETA(passthrough, createInfo, colorLut);

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
    public static XrResult xrDestroyPassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut)
        => Instance.xrDestroyPassthroughColorLutMETA(colorLut);

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
    public static XrResult xrUpdatePassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut, XrPassthroughColorLutUpdateInfoMETA* updateInfo)
        => Instance.xrUpdatePassthroughColorLutMETA(colorLut, updateInfo);

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
    public static XrResult xrSetTrackingOptimizationSettingsHintQCOM(XrSession session, XrTrackingOptimizationSettingsDomainQCOM domain, XrTrackingOptimizationSettingsHintQCOM hint)
        => Instance.xrSetTrackingOptimizationSettingsHintQCOM(session, domain, hint);

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
    public static XrResult xrCreatePassthroughHTC(XrSession session, XrPassthroughCreateInfoHTC* createInfo, XrPassthroughHTC* passthrough)
        => Instance.xrCreatePassthroughHTC(session, createInfo, passthrough);

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
    public static XrResult xrDestroyPassthroughHTC(XrPassthroughHTC passthrough)
        => Instance.xrDestroyPassthroughHTC(passthrough);

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
    public static XrResult xrApplyFoveationHTC(XrSession session, XrFoveationApplyInfoHTC* applyInfo)
        => Instance.xrApplyFoveationHTC(session, applyInfo);

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
    public static XrResult xrApplyForceFeedbackCurlMNDX(XrHandTrackerEXT handTracker, XrForceFeedbackCurlApplyLocationsMNDX* locations)
        => Instance.xrApplyForceFeedbackCurlMNDX(handTracker, locations);

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
    public static XrResult xrCreatePlaneDetectorEXT(XrSession session, XrPlaneDetectorCreateInfoEXT* createInfo, XrPlaneDetectorEXT* planeDetector)
        => Instance.xrCreatePlaneDetectorEXT(session, createInfo, planeDetector);

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
    public static XrResult xrDestroyPlaneDetectorEXT(XrPlaneDetectorEXT planeDetector)
        => Instance.xrDestroyPlaneDetectorEXT(planeDetector);

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
    public static XrResult xrBeginPlaneDetectionEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorBeginInfoEXT* beginInfo)
        => Instance.xrBeginPlaneDetectionEXT(planeDetector, beginInfo);

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
    public static XrResult xrGetPlaneDetectionStateEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectionStateEXT* state)
        => Instance.xrGetPlaneDetectionStateEXT(planeDetector, state);

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
    public static XrResult xrGetPlaneDetectionsEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorGetInfoEXT* info, XrPlaneDetectorLocationsEXT* locations)
        => Instance.xrGetPlaneDetectionsEXT(planeDetector, info, locations);

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
    public static XrResult xrGetPlanePolygonBufferEXT(XrPlaneDetectorEXT planeDetector, ulong planeId, uint polygonBufferIndex, XrPlaneDetectorPolygonBufferEXT* polygonBuffer)
        => Instance.xrGetPlanePolygonBufferEXT(planeDetector, planeId, polygonBufferIndex, polygonBuffer);

}