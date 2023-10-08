using System;
using System.Runtime.InteropServices;

namespace Veldrid.OpenXR.Native;
public static unsafe partial class OpenXRNative
{
#pragma warning disable CA1401 // P/Invokes should not be visible
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetInstanceProcAddr(XrInstance instance, byte* name, IntPtr function);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateApiLayerProperties(uint propertyCapacityInput, uint* propertyCountOutput, XrApiLayerProperties* properties);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateInstanceExtensionProperties(byte* layerName, uint propertyCapacityInput, uint* propertyCountOutput, XrExtensionProperties* properties);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateInstance(XrInstanceCreateInfo* createInfo, XrInstance* instance);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyInstance(XrInstance instance);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetInstanceProperties(XrInstance instance, XrInstanceProperties* instanceProperties);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPollEvent(XrInstance instance, XrEventDataBuffer* eventData);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrResultToString(XrInstance instance, XrResult value, byte buffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrStructureTypeToString(XrInstance instance, XrStructureType value, byte buffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSystem(XrInstance instance, XrSystemGetInfo* getInfo, ulong* systemId);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSystemProperties(XrInstance instance, ulong systemId, XrSystemProperties* properties);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateEnvironmentBlendModes(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint environmentBlendModeCapacityInput, uint* environmentBlendModeCountOutput, XrEnvironmentBlendMode* environmentBlendModes);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSession(XrInstance instance, XrSessionCreateInfo* createInfo, XrSession* session);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySession(XrSession session);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateReferenceSpaces(XrSession session, uint spaceCapacityInput, uint* spaceCountOutput, XrReferenceSpaceType* spaces);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateReferenceSpace(XrSession session, XrReferenceSpaceCreateInfo* createInfo, XrSpace* space);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetReferenceSpaceBoundsRect(XrSession session, XrReferenceSpaceType referenceSpaceType, XrExtent2Df* bounds);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateActionSpace(XrSession session, XrActionSpaceCreateInfo* createInfo, XrSpace* space);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLocateSpace(XrSpace space, XrSpace baseSpace, long time, XrSpaceLocation* location);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySpace(XrSpace space);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateViewConfigurations(XrInstance instance, ulong systemId, uint viewConfigurationTypeCapacityInput, uint* viewConfigurationTypeCountOutput, XrViewConfigurationType* viewConfigurationTypes);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetViewConfigurationProperties(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, XrViewConfigurationProperties* configurationProperties);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateViewConfigurationViews(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint viewCapacityInput, uint* viewCountOutput, XrViewConfigurationView* views);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateSwapchainFormats(XrSession session, uint formatCapacityInput, uint* formatCountOutput, long* formats);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSwapchain(XrSession session, XrSwapchainCreateInfo* createInfo, XrSwapchain* swapchain);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySwapchain(XrSwapchain swapchain);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateSwapchainImages(XrSwapchain swapchain, uint imageCapacityInput, uint* imageCountOutput, XrSwapchainImageBaseHeader* images);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrAcquireSwapchainImage(XrSwapchain swapchain, XrSwapchainImageAcquireInfo* acquireInfo, uint* index);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrWaitSwapchainImage(XrSwapchain swapchain, XrSwapchainImageWaitInfo* waitInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrReleaseSwapchainImage(XrSwapchain swapchain, XrSwapchainImageReleaseInfo* releaseInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrBeginSession(XrSession session, XrSessionBeginInfo* beginInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEndSession(XrSession session);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrRequestExitSession(XrSession session);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrWaitFrame(XrSession session, XrFrameWaitInfo* frameWaitInfo, XrFrameState* frameState);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrBeginFrame(XrSession session, XrFrameBeginInfo* frameBeginInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEndFrame(XrSession session, XrFrameEndInfo* frameEndInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLocateViews(XrSession session, XrViewLocateInfo* viewLocateInfo, XrViewState* viewState, uint viewCapacityInput, uint* viewCountOutput, XrView* views);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrStringToPath(XrInstance instance, byte* pathString, ulong* path);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPathToString(XrInstance instance, ulong path, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateActionSet(XrInstance instance, XrActionSetCreateInfo* createInfo, XrActionSet* actionSet);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyActionSet(XrActionSet actionSet);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateAction(XrActionSet actionSet, XrActionCreateInfo* createInfo, XrAction* action);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyAction(XrAction action);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSuggestInteractionProfileBindings(XrInstance instance, XrInteractionProfileSuggestedBinding* suggestedBindings);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrAttachSessionActionSets(XrSession session, XrSessionActionSetsAttachInfo* attachInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetCurrentInteractionProfile(XrSession session, ulong topLevelUserPath, XrInteractionProfileState* interactionProfile);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetActionStateBoolean(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateBoolean* state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetActionStateFloat(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateFloat* state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetActionStateVector2f(XrSession session, XrActionStateGetInfo* getInfo, XrActionStateVector2f* state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetActionStatePose(XrSession session, XrActionStateGetInfo* getInfo, XrActionStatePose* state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSyncActions(XrSession session, XrActionsSyncInfo* syncInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateBoundSourcesForAction(XrSession session, XrBoundSourcesForActionEnumerateInfo* enumerateInfo, uint sourceCapacityInput, uint* sourceCountOutput, ulong* sources);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetInputSourceLocalizedName(XrSession session, XrInputSourceLocalizedNameGetInfo* getInfo, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrApplyHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo, XrHapticBaseHeader* hapticFeedback);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrStopHapticFeedback(XrSession session, XrHapticActionInfo* hapticActionInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetAndroidApplicationThreadKHR(XrSession session, XrAndroidThreadTypeKHR threadType, uint threadId);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSwapchainAndroidSurfaceKHR(XrSession session, XrSwapchainCreateInfo* info, XrSwapchain* swapchain, IntPtr surface);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPerfSettingsSetPerformanceLevelEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsLevelEXT level);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrThermalGetTemperatureTrendEXT(XrSession session, XrPerfSettingsDomainEXT domain, XrPerfSettingsNotificationLevelEXT* notificationLevel, float* tempHeadroom, float* tempSlope);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetDebugUtilsObjectNameEXT(XrInstance instance, XrDebugUtilsObjectNameInfoEXT* nameInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateDebugUtilsMessengerEXT(XrInstance instance, XrDebugUtilsMessengerCreateInfoEXT* createInfo, XrDebugUtilsMessengerEXT* messenger);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyDebugUtilsMessengerEXT(XrDebugUtilsMessengerEXT messenger);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSubmitDebugUtilsMessageEXT(XrInstance instance, ulong messageSeverity, ulong messageTypes, XrDebugUtilsMessengerCallbackDataEXT* callbackData);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSessionBeginDebugUtilsLabelRegionEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSessionEndDebugUtilsLabelRegionEXT(XrSession session);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSessionInsertDebugUtilsLabelEXT(XrSession session, XrDebugUtilsLabelEXT* labelInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetOpenGLGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLKHR* graphicsRequirements);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetOpenGLESGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsOpenGLESKHR* graphicsRequirements);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVulkanInstanceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVulkanDeviceExtensionsKHR(XrInstance instance, ulong systemId, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVulkanGraphicsDeviceKHR(XrInstance instance, ulong systemId, IntPtr vkInstance, IntPtr vkPhysicalDevice);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVulkanGraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsVulkanKHR* graphicsRequirements);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetD3D11GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D11KHR* graphicsRequirements);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetD3D12GraphicsRequirementsKHR(XrInstance instance, ulong systemId, XrGraphicsRequirementsD3D12KHR* graphicsRequirements);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVisibilityMaskKHR(XrSession session, XrViewConfigurationType viewConfigurationType, uint viewIndex, XrVisibilityMaskTypeKHR visibilityMaskType, XrVisibilityMaskKHR* visibilityMask);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrConvertWin32PerformanceCounterToTimeKHR(XrInstance instance, IntPtr performanceCounter, long* time);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrConvertTimeToWin32PerformanceCounterKHR(XrInstance instance, long time, IntPtr performanceCounter);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrConvertTimespecTimeToTimeKHR(XrInstance instance, IntPtr timespecTime, long* time);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrConvertTimeToTimespecTimeKHR(XrInstance instance, long time, IntPtr timespecTime);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorMSFT(XrSession session, XrSpatialAnchorCreateInfoMSFT* createInfo, XrSpatialAnchorMSFT* anchor);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorSpaceMSFT(XrSession session, XrSpatialAnchorSpaceCreateInfoMSFT* createInfo, XrSpace* space);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySpatialAnchorMSFT(XrSpatialAnchorMSFT anchor);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetInputDeviceActiveEXT(XrSession session, ulong interactionProfile, ulong topLevelPath, XrBool32 isActive);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetInputDeviceStateBoolEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrBool32 state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetInputDeviceStateFloatEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, float state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetInputDeviceStateVector2fEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrVector2f state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetInputDeviceLocationEXT(XrSession session, ulong topLevelPath, ulong inputSourcePath, XrSpace space, XrPosef pose);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialGraphNodeSpaceMSFT(XrSession session, XrSpatialGraphNodeSpaceCreateInfoMSFT* createInfo, XrSpace* space);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTryCreateSpatialGraphStaticNodeBindingMSFT(XrSession session, XrSpatialGraphStaticNodeBindingCreateInfoMSFT* createInfo, XrSpatialGraphNodeBindingMSFT* nodeBinding);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySpatialGraphNodeBindingMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpatialGraphNodeBindingPropertiesMSFT(XrSpatialGraphNodeBindingMSFT nodeBinding, XrSpatialGraphNodeBindingPropertiesGetInfoMSFT* getInfo, XrSpatialGraphNodeBindingPropertiesMSFT* properties);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateHandTrackerEXT(XrSession session, XrHandTrackerCreateInfoEXT* createInfo, XrHandTrackerEXT* handTracker);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyHandTrackerEXT(XrHandTrackerEXT handTracker);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLocateHandJointsEXT(XrHandTrackerEXT handTracker, XrHandJointsLocateInfoEXT* locateInfo, XrHandJointLocationsEXT* locations);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateHandMeshSpaceMSFT(XrHandTrackerEXT handTracker, XrHandMeshSpaceCreateInfoMSFT* createInfo, XrSpace* space);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrUpdateHandMeshMSFT(XrHandTrackerEXT handTracker, XrHandMeshUpdateInfoMSFT* updateInfo, XrHandMeshMSFT* handMesh);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetControllerModelKeyMSFT(XrSession session, ulong topLevelUserPath, XrControllerModelKeyStateMSFT* controllerModelKeyState);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLoadControllerModelMSFT(XrSession session, ulong modelKey, uint bufferCapacityInput, uint* bufferCountOutput, byte* buffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetControllerModelPropertiesMSFT(XrSession session, ulong modelKey, XrControllerModelPropertiesMSFT* properties);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetControllerModelStateMSFT(XrSession session, ulong modelKey, XrControllerModelStateMSFT* state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorFromPerceptionAnchorMSFT(XrSession session, IntPtr perceptionAnchor, XrSpatialAnchorMSFT* anchor);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTryGetPerceptionAnchorFromSpatialAnchorMSFT(XrSession session, XrSpatialAnchorMSFT anchor, IntPtr perceptionAnchor);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateReprojectionModesMSFT(XrInstance instance, ulong systemId, XrViewConfigurationType viewConfigurationType, uint modeCapacityInput, uint* modeCountOutput, XrReprojectionModeMSFT* modes);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrUpdateSwapchainFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSwapchainStateFB(XrSwapchain swapchain, XrSwapchainStateBaseHeaderFB* state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateBodyTrackerFB(XrSession session, XrBodyTrackerCreateInfoFB* createInfo, XrBodyTrackerFB* bodyTracker);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyBodyTrackerFB(XrBodyTrackerFB bodyTracker);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLocateBodyJointsFB(XrBodyTrackerFB bodyTracker, XrBodyJointsLocateInfoFB* locateInfo, XrBodyJointLocationsFB* locations);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetBodySkeletonFB(XrBodyTrackerFB bodyTracker, XrBodySkeletonFB* skeleton);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrInitializeLoaderKHR(XrLoaderInitInfoBaseHeaderKHR* loaderInitInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateVulkanInstanceKHR(XrInstance instance, XrVulkanInstanceCreateInfoKHR* createInfo, IntPtr vulkanInstance, IntPtr vulkanResult);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateVulkanDeviceKHR(XrInstance instance, XrVulkanDeviceCreateInfoKHR* createInfo, IntPtr vulkanDevice, IntPtr vulkanResult);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVulkanGraphicsDevice2KHR(XrInstance instance, XrVulkanGraphicsDeviceGetInfoKHR* getInfo, IntPtr vulkanPhysicalDevice);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateSceneComputeFeaturesMSFT(XrInstance instance, ulong systemId, uint featureCapacityInput, uint* featureCountOutput, XrSceneComputeFeatureMSFT* features);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSceneObserverMSFT(XrSession session, XrSceneObserverCreateInfoMSFT* createInfo, XrSceneObserverMSFT* sceneObserver);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySceneObserverMSFT(XrSceneObserverMSFT sceneObserver);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneCreateInfoMSFT* createInfo, XrSceneMSFT* scene);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySceneMSFT(XrSceneMSFT scene);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrComputeNewSceneMSFT(XrSceneObserverMSFT sceneObserver, XrNewSceneComputeInfoMSFT* computeInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSceneComputeStateMSFT(XrSceneObserverMSFT sceneObserver, XrSceneComputeStateMSFT* state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsGetInfoMSFT* getInfo, XrSceneComponentsMSFT* components);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLocateSceneComponentsMSFT(XrSceneMSFT scene, XrSceneComponentsLocateInfoMSFT* locateInfo, XrSceneComponentLocationsMSFT* locations);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSceneMeshBuffersMSFT(XrSceneMSFT scene, XrSceneMeshBuffersGetInfoMSFT* getInfo, XrSceneMeshBuffersMSFT* buffers);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDeserializeSceneMSFT(XrSceneObserverMSFT sceneObserver, XrSceneDeserializeInfoMSFT* deserializeInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSerializedSceneFragmentDataMSFT(XrSceneMSFT scene, XrSerializedSceneFragmentDataGetInfoMSFT* getInfo, uint countInput, uint* readOutput, byte* buffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateDisplayRefreshRatesFB(XrSession session, uint displayRefreshRateCapacityInput, uint* displayRefreshRateCountOutput, float* displayRefreshRates);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetDisplayRefreshRateFB(XrSession session, float* displayRefreshRate);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrRequestDisplayRefreshRateFB(XrSession session, float displayRefreshRate);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateViveTrackerPathsHTCX(XrInstance instance, uint pathCapacityInput, uint* pathCountOutput, XrViveTrackerPathsHTCX* paths);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateFacialTrackerHTC(XrSession session, XrFacialTrackerCreateInfoHTC* createInfo, XrFacialTrackerHTC* facialTracker);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyFacialTrackerHTC(XrFacialTrackerHTC facialTracker);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetFacialExpressionsHTC(XrFacialTrackerHTC facialTracker, XrFacialExpressionsHTC* facialExpressions);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateColorSpacesFB(XrSession session, uint colorSpaceCapacityInput, uint* colorSpaceCountOutput, XrColorSpaceFB* colorSpaces);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetColorSpaceFB(XrSession session, XrColorSpaceFB colorSpace);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetHandMeshFB(XrHandTrackerEXT handTracker, XrHandTrackingMeshFB* mesh);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorFB(XrSession session, XrSpatialAnchorCreateInfoFB* info, ulong* requestId);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceUuidFB(XrSpace space, XrUuidEXT* uuid);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateSpaceSupportedComponentsFB(XrSpace space, uint componentTypeCapacityInput, uint* componentTypeCountOutput, XrSpaceComponentTypeFB* componentTypes);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentStatusSetInfoFB* info, ulong* requestId);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceComponentStatusFB(XrSpace space, XrSpaceComponentTypeFB componentType, XrSpaceComponentStatusFB* status);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateFoveationProfileFB(XrSession session, XrFoveationProfileCreateInfoFB* createInfo, XrFoveationProfileFB* profile);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyFoveationProfileFB(XrFoveationProfileFB profile);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrQuerySystemTrackedKeyboardFB(XrSession session, XrKeyboardTrackingQueryFB* queryInfo, XrKeyboardTrackingDescriptionFB* keyboard);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateKeyboardSpaceFB(XrSession session, XrKeyboardSpaceCreateInfoFB* createInfo, XrSpace* keyboardSpace);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateTriangleMeshFB(XrSession session, XrTriangleMeshCreateInfoFB* createInfo, XrTriangleMeshFB* outTriangleMesh);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyTriangleMeshFB(XrTriangleMeshFB mesh);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshGetVertexBufferFB(XrTriangleMeshFB mesh, XrVector3f** outVertexBuffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshGetIndexBufferFB(XrTriangleMeshFB mesh, uint** outIndexBuffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshBeginUpdateFB(XrTriangleMeshFB mesh);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshEndUpdateFB(XrTriangleMeshFB mesh, uint vertexCount, uint triangleCount);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshBeginVertexBufferUpdateFB(XrTriangleMeshFB mesh, uint* outVertexCount);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrTriangleMeshEndVertexBufferUpdateFB(XrTriangleMeshFB mesh);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreatePassthroughFB(XrSession session, XrPassthroughCreateInfoFB* createInfo, XrPassthroughFB* outPassthrough);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyPassthroughFB(XrPassthroughFB passthrough);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughStartFB(XrPassthroughFB passthrough);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughPauseFB(XrPassthroughFB passthrough);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreatePassthroughLayerFB(XrSession session, XrPassthroughLayerCreateInfoFB* createInfo, XrPassthroughLayerFB* outLayer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyPassthroughLayerFB(XrPassthroughLayerFB layer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughLayerPauseFB(XrPassthroughLayerFB layer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughLayerResumeFB(XrPassthroughLayerFB layer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughLayerSetStyleFB(XrPassthroughLayerFB layer, XrPassthroughStyleFB* style);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateGeometryInstanceFB(XrSession session, XrGeometryInstanceCreateInfoFB* createInfo, XrGeometryInstanceFB* outGeometryInstance);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyGeometryInstanceFB(XrGeometryInstanceFB instance);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGeometryInstanceSetTransformFB(XrGeometryInstanceFB instance, XrGeometryInstanceTransformFB* transformation);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateRenderModelPathsFB(XrSession session, uint pathCapacityInput, uint* pathCountOutput, XrRenderModelPathInfoFB* paths);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetRenderModelPropertiesFB(XrSession session, ulong path, XrRenderModelPropertiesFB* properties);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrLoadRenderModelFB(XrSession session, XrRenderModelLoadInfoFB* info, XrRenderModelBufferFB* buffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetEnvironmentDepthEstimationVARJO(XrSession session, XrBool32 enabled);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetMarkerTrackingVARJO(XrSession session, XrBool32 enabled);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetMarkerTrackingTimeoutVARJO(XrSession session, ulong markerId, long timeout);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetMarkerTrackingPredictionVARJO(XrSession session, ulong markerId, XrBool32 enable);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetMarkerSizeVARJO(XrSession session, ulong markerId, XrExtent2Df* size);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateMarkerSpaceVARJO(XrSession session, XrMarkerSpaceCreateInfoVARJO* createInfo, XrSpace* space);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetViewOffsetVARJO(XrSession session, float offset);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpaceFromCoordinateFrameUIDML(XrSession session, XrCoordinateSpaceCreateInfoML createInfo, XrSpace* space);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorStoreConnectionMSFT(XrSession session, XrSpatialAnchorStoreConnectionMSFT* spatialAnchorStore);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySpatialAnchorStoreConnectionMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceInfoMSFT* spatialAnchorPersistenceInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumeratePersistedSpatialAnchorNamesMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, uint spatialAnchorNamesCapacityInput, uint* spatialAnchorNamesCountOutput, XrSpatialAnchorPersistenceNameMSFT* persistedAnchorNames);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpatialAnchorFromPersistedNameMSFT(XrSession session, XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, XrSpatialAnchorMSFT* spatialAnchor);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrUnpersistSpatialAnchorMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore, XrSpatialAnchorPersistenceNameMSFT* spatialAnchorPersistenceName);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrClearSpatialAnchorStoreMSFT(XrSpatialAnchorStoreConnectionMSFT spatialAnchorStore);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrQuerySpacesFB(XrSession session, XrSpaceQueryInfoBaseHeaderFB* info, ulong* requestId);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrRetrieveSpaceQueryResultsFB(XrSession session, ulong requestId, XrSpaceQueryResultsFB* results);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSaveSpaceFB(XrSession session, XrSpaceSaveInfoFB* info, ulong* requestId);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEraseSpaceFB(XrSession session, XrSpaceEraseInfoFB* info, ulong* requestId);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetAudioOutputDeviceGuidOculus(XrInstance instance, string buffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetAudioInputDeviceGuidOculus(XrInstance instance, string buffer);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrShareSpacesFB(XrSession session, XrSpaceShareInfoFB* info, ulong* requestId);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceBoundingBox2DFB(XrSession session, XrSpace space, XrRect2Df* boundingBox2DOutput);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceBoundingBox3DFB(XrSession session, XrSpace space, XrRect3DfFB* boundingBox3DOutput);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceSemanticLabelsFB(XrSession session, XrSpace space, XrSemanticLabelsFB* semanticLabelsOutput);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceBoundary2DFB(XrSession session, XrSpace space, XrBoundary2DFB* boundary2DOutput);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceRoomLayoutFB(XrSession session, XrSpace space, XrRoomLayoutFB* roomLayoutOutput);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetDigitalLensControlALMALENCE(XrSession session, XrDigitalLensControlALMALENCE* digitalLensControl);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrRequestSceneCaptureFB(XrSession session, XrSceneCaptureRequestInfoFB* info, ulong* requestId);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceContainerFB(XrSession session, XrSpace space, XrSpaceContainerFB* spaceContainerOutput);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetFoveationEyeTrackedStateMETA(XrSession session, XrFoveationEyeTrackedStateMETA* foveationState);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateFaceTrackerFB(XrSession session, XrFaceTrackerCreateInfoFB* createInfo, XrFaceTrackerFB* faceTracker);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyFaceTrackerFB(XrFaceTrackerFB faceTracker);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetFaceExpressionWeightsFB(XrFaceTrackerFB faceTracker, XrFaceExpressionInfoFB* expressionInfo, XrFaceExpressionWeightsFB* expressionWeights);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateEyeTrackerFB(XrSession session, XrEyeTrackerCreateInfoFB* createInfo, XrEyeTrackerFB* eyeTracker);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyEyeTrackerFB(XrEyeTrackerFB eyeTracker);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetEyeGazesFB(XrEyeTrackerFB eyeTracker, XrEyeGazesInfoFB* gazeInfo, XrEyeGazesFB* eyeGazes);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrPassthroughLayerSetKeyboardHandsIntensityFB(XrPassthroughLayerFB layer, XrPassthroughKeyboardHandsIntensityFB* intensity);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetDeviceSampleRateFB(XrSession session, XrHapticActionInfo* hapticActionInfo, XrDevicePcmSampleRateStateFB* deviceSampleRate);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetPassthroughPreferencesMETA(XrSession session, XrPassthroughPreferencesMETA* preferences);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateVirtualKeyboardMETA(XrSession session, XrVirtualKeyboardCreateInfoMETA* createInfo, XrVirtualKeyboardMETA* keyboard);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyVirtualKeyboardMETA(XrVirtualKeyboardMETA keyboard);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateVirtualKeyboardSpaceMETA(XrSession session, XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardSpaceCreateInfoMETA* createInfo, XrSpace* keyboardSpace);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSuggestVirtualKeyboardLocationMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardLocationInfoMETA* locationInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVirtualKeyboardScaleMETA(XrVirtualKeyboardMETA keyboard, float* scale);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetVirtualKeyboardModelVisibilityMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelVisibilitySetInfoMETA* modelVisibility);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVirtualKeyboardModelAnimationStatesMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardModelAnimationStatesMETA* animationStates);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVirtualKeyboardDirtyTexturesMETA(XrVirtualKeyboardMETA keyboard, uint textureIdCapacityInput, uint* textureIdCountOutput, ulong* textureIds);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetVirtualKeyboardTextureDataMETA(XrVirtualKeyboardMETA keyboard, ulong textureId, XrVirtualKeyboardTextureDataMETA* textureData);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSendVirtualKeyboardInputMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardInputInfoMETA* info, XrPosef* interactorRootPose);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrChangeVirtualKeyboardTextContextMETA(XrVirtualKeyboardMETA keyboard, XrVirtualKeyboardTextContextChangeInfoMETA* changeInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumerateExternalCamerasOCULUS(XrSession session, uint cameraCapacityInput, uint* cameraCountOutput, XrExternalCameraOCULUS* cameras);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrEnumeratePerformanceMetricsCounterPathsMETA(XrInstance instance, uint counterPathCapacityInput, uint* counterPathCountOutput, ulong* counterPaths);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetPerformanceMetricsStateMETA(XrSession session, XrPerformanceMetricsStateMETA* state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrQueryPerformanceMetricsCounterMETA(XrSession session, ulong counterPath, XrPerformanceMetricsCounterMETA* counter);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSaveSpaceListFB(XrSession session, XrSpaceListSaveInfoFB* info, ulong* requestId);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreateSpaceUserFB(XrSession session, XrSpaceUserCreateInfoFB* info, XrSpaceUserFB* user);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetSpaceUserIdFB(XrSpaceUserFB user, ulong* userId);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroySpaceUserFB(XrSpaceUserFB user);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreatePassthroughColorLutMETA(XrPassthroughFB passthrough, XrPassthroughColorLutCreateInfoMETA* createInfo, XrPassthroughColorLutMETA* colorLut);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyPassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrUpdatePassthroughColorLutMETA(XrPassthroughColorLutMETA colorLut, XrPassthroughColorLutUpdateInfoMETA* updateInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrSetTrackingOptimizationSettingsHintQCOM(XrSession session, XrTrackingOptimizationSettingsDomainQCOM domain, XrTrackingOptimizationSettingsHintQCOM hint);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreatePassthroughHTC(XrSession session, XrPassthroughCreateInfoHTC* createInfo, XrPassthroughHTC* passthrough);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyPassthroughHTC(XrPassthroughHTC passthrough);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrApplyFoveationHTC(XrSession session, XrFoveationApplyInfoHTC* applyInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrApplyForceFeedbackCurlMNDX(XrHandTrackerEXT handTracker, XrForceFeedbackCurlApplyLocationsMNDX* locations);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrCreatePlaneDetectorEXT(XrSession session, XrPlaneDetectorCreateInfoEXT* createInfo, XrPlaneDetectorEXT* planeDetector);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrDestroyPlaneDetectorEXT(XrPlaneDetectorEXT planeDetector);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrBeginPlaneDetectionEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorBeginInfoEXT* beginInfo);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetPlaneDetectionStateEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectionStateEXT* state);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetPlaneDetectionsEXT(XrPlaneDetectorEXT planeDetector, XrPlaneDetectorGetInfoEXT* info, XrPlaneDetectorLocationsEXT* locations);
    [DllImport(dllName, CallingConvention = callConv)]
    public static extern XrResult xrGetPlanePolygonBufferEXT(XrPlaneDetectorEXT planeDetector, ulong planeId, uint polygonBufferIndex, XrPlaneDetectorPolygonBufferEXT* polygonBuffer);
#pragma warning restore CA1401 // P/Invokes should not be visible
}