using System;

namespace Veldrid.OpenXR.Native;
#pragma warning disable IDE0250 // Make struct 'readonly'
public partial struct XrInstance : IEquatable<XrInstance>
{
    public readonly ulong Handle;
    public XrInstance(ulong existingHandle) { Handle = existingHandle; }
    public static XrInstance Null => new(0);
    public static implicit operator XrInstance(ulong handle) => new(handle);
    public static bool operator ==(XrInstance left, XrInstance right) => left.Handle == right.Handle;
    public static bool operator !=(XrInstance left, XrInstance right) => left.Handle != right.Handle;
    public static bool operator ==(XrInstance left, ulong right) => left.Handle == right;
    public static bool operator !=(XrInstance left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrInstance h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrInstance h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrSession : IEquatable<XrSession>
{
    public readonly ulong Handle;
    public XrSession(ulong existingHandle) { Handle = existingHandle; }
    public static XrSession Null => new(0);
    public static implicit operator XrSession(ulong handle) => new(handle);
    public static bool operator ==(XrSession left, XrSession right) => left.Handle == right.Handle;
    public static bool operator !=(XrSession left, XrSession right) => left.Handle != right.Handle;
    public static bool operator ==(XrSession left, ulong right) => left.Handle == right;
    public static bool operator !=(XrSession left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrSession h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrSession h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrActionSet : IEquatable<XrActionSet>
{
    public readonly ulong Handle;
    public XrActionSet(ulong existingHandle) { Handle = existingHandle; }
    public static XrActionSet Null => new(0);
    public static implicit operator XrActionSet(ulong handle) => new(handle);
    public static bool operator ==(XrActionSet left, XrActionSet right) => left.Handle == right.Handle;
    public static bool operator !=(XrActionSet left, XrActionSet right) => left.Handle != right.Handle;
    public static bool operator ==(XrActionSet left, ulong right) => left.Handle == right;
    public static bool operator !=(XrActionSet left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrActionSet h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrActionSet h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrAction : IEquatable<XrAction>
{
    public readonly ulong Handle;
    public XrAction(ulong existingHandle) { Handle = existingHandle; }
    public static XrAction Null => new(0);
    public static implicit operator XrAction(ulong handle) => new(handle);
    public static bool operator ==(XrAction left, XrAction right) => left.Handle == right.Handle;
    public static bool operator !=(XrAction left, XrAction right) => left.Handle != right.Handle;
    public static bool operator ==(XrAction left, ulong right) => left.Handle == right;
    public static bool operator !=(XrAction left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrAction h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrAction h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrSwapchain : IEquatable<XrSwapchain>
{
    public readonly ulong Handle;
    public XrSwapchain(ulong existingHandle) { Handle = existingHandle; }
    public static XrSwapchain Null => new(0);
    public static implicit operator XrSwapchain(ulong handle) => new(handle);
    public static bool operator ==(XrSwapchain left, XrSwapchain right) => left.Handle == right.Handle;
    public static bool operator !=(XrSwapchain left, XrSwapchain right) => left.Handle != right.Handle;
    public static bool operator ==(XrSwapchain left, ulong right) => left.Handle == right;
    public static bool operator !=(XrSwapchain left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrSwapchain h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrSwapchain h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrSpace : IEquatable<XrSpace>
{
    public readonly ulong Handle;
    public XrSpace(ulong existingHandle) { Handle = existingHandle; }
    public static XrSpace Null => new(0);
    public static implicit operator XrSpace(ulong handle) => new(handle);
    public static bool operator ==(XrSpace left, XrSpace right) => left.Handle == right.Handle;
    public static bool operator !=(XrSpace left, XrSpace right) => left.Handle != right.Handle;
    public static bool operator ==(XrSpace left, ulong right) => left.Handle == right;
    public static bool operator !=(XrSpace left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrSpace h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrSpace h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrDebugUtilsMessengerEXT : IEquatable<XrDebugUtilsMessengerEXT>
{
    public readonly ulong Handle;
    public XrDebugUtilsMessengerEXT(ulong existingHandle) { Handle = existingHandle; }
    public static XrDebugUtilsMessengerEXT Null => new(0);
    public static implicit operator XrDebugUtilsMessengerEXT(ulong handle) => new(handle);
    public static bool operator ==(XrDebugUtilsMessengerEXT left, XrDebugUtilsMessengerEXT right) => left.Handle == right.Handle;
    public static bool operator !=(XrDebugUtilsMessengerEXT left, XrDebugUtilsMessengerEXT right) => left.Handle != right.Handle;
    public static bool operator ==(XrDebugUtilsMessengerEXT left, ulong right) => left.Handle == right;
    public static bool operator !=(XrDebugUtilsMessengerEXT left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrDebugUtilsMessengerEXT h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrDebugUtilsMessengerEXT h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrSpatialAnchorMSFT : IEquatable<XrSpatialAnchorMSFT>
{
    public readonly ulong Handle;
    public XrSpatialAnchorMSFT(ulong existingHandle) { Handle = existingHandle; }
    public static XrSpatialAnchorMSFT Null => new(0);
    public static implicit operator XrSpatialAnchorMSFT(ulong handle) => new(handle);
    public static bool operator ==(XrSpatialAnchorMSFT left, XrSpatialAnchorMSFT right) => left.Handle == right.Handle;
    public static bool operator !=(XrSpatialAnchorMSFT left, XrSpatialAnchorMSFT right) => left.Handle != right.Handle;
    public static bool operator ==(XrSpatialAnchorMSFT left, ulong right) => left.Handle == right;
    public static bool operator !=(XrSpatialAnchorMSFT left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrSpatialAnchorMSFT h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrSpatialAnchorMSFT h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrHandTrackerEXT : IEquatable<XrHandTrackerEXT>
{
    public readonly ulong Handle;
    public XrHandTrackerEXT(ulong existingHandle) { Handle = existingHandle; }
    public static XrHandTrackerEXT Null => new(0);
    public static implicit operator XrHandTrackerEXT(ulong handle) => new(handle);
    public static bool operator ==(XrHandTrackerEXT left, XrHandTrackerEXT right) => left.Handle == right.Handle;
    public static bool operator !=(XrHandTrackerEXT left, XrHandTrackerEXT right) => left.Handle != right.Handle;
    public static bool operator ==(XrHandTrackerEXT left, ulong right) => left.Handle == right;
    public static bool operator !=(XrHandTrackerEXT left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrHandTrackerEXT h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrHandTrackerEXT h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrFoveationProfileFB : IEquatable<XrFoveationProfileFB>
{
    public readonly ulong Handle;
    public XrFoveationProfileFB(ulong existingHandle) { Handle = existingHandle; }
    public static XrFoveationProfileFB Null => new(0);
    public static implicit operator XrFoveationProfileFB(ulong handle) => new(handle);
    public static bool operator ==(XrFoveationProfileFB left, XrFoveationProfileFB right) => left.Handle == right.Handle;
    public static bool operator !=(XrFoveationProfileFB left, XrFoveationProfileFB right) => left.Handle != right.Handle;
    public static bool operator ==(XrFoveationProfileFB left, ulong right) => left.Handle == right;
    public static bool operator !=(XrFoveationProfileFB left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrFoveationProfileFB h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrFoveationProfileFB h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrTriangleMeshFB : IEquatable<XrTriangleMeshFB>
{
    public readonly ulong Handle;
    public XrTriangleMeshFB(ulong existingHandle) { Handle = existingHandle; }
    public static XrTriangleMeshFB Null => new(0);
    public static implicit operator XrTriangleMeshFB(ulong handle) => new(handle);
    public static bool operator ==(XrTriangleMeshFB left, XrTriangleMeshFB right) => left.Handle == right.Handle;
    public static bool operator !=(XrTriangleMeshFB left, XrTriangleMeshFB right) => left.Handle != right.Handle;
    public static bool operator ==(XrTriangleMeshFB left, ulong right) => left.Handle == right;
    public static bool operator !=(XrTriangleMeshFB left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrTriangleMeshFB h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrTriangleMeshFB h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrPassthroughFB : IEquatable<XrPassthroughFB>
{
    public readonly ulong Handle;
    public XrPassthroughFB(ulong existingHandle) { Handle = existingHandle; }
    public static XrPassthroughFB Null => new(0);
    public static implicit operator XrPassthroughFB(ulong handle) => new(handle);
    public static bool operator ==(XrPassthroughFB left, XrPassthroughFB right) => left.Handle == right.Handle;
    public static bool operator !=(XrPassthroughFB left, XrPassthroughFB right) => left.Handle != right.Handle;
    public static bool operator ==(XrPassthroughFB left, ulong right) => left.Handle == right;
    public static bool operator !=(XrPassthroughFB left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrPassthroughFB h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrPassthroughFB h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrPassthroughLayerFB : IEquatable<XrPassthroughLayerFB>
{
    public readonly ulong Handle;
    public XrPassthroughLayerFB(ulong existingHandle) { Handle = existingHandle; }
    public static XrPassthroughLayerFB Null => new(0);
    public static implicit operator XrPassthroughLayerFB(ulong handle) => new(handle);
    public static bool operator ==(XrPassthroughLayerFB left, XrPassthroughLayerFB right) => left.Handle == right.Handle;
    public static bool operator !=(XrPassthroughLayerFB left, XrPassthroughLayerFB right) => left.Handle != right.Handle;
    public static bool operator ==(XrPassthroughLayerFB left, ulong right) => left.Handle == right;
    public static bool operator !=(XrPassthroughLayerFB left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrPassthroughLayerFB h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrPassthroughLayerFB h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrGeometryInstanceFB : IEquatable<XrGeometryInstanceFB>
{
    public readonly ulong Handle;
    public XrGeometryInstanceFB(ulong existingHandle) { Handle = existingHandle; }
    public static XrGeometryInstanceFB Null => new(0);
    public static implicit operator XrGeometryInstanceFB(ulong handle) => new(handle);
    public static bool operator ==(XrGeometryInstanceFB left, XrGeometryInstanceFB right) => left.Handle == right.Handle;
    public static bool operator !=(XrGeometryInstanceFB left, XrGeometryInstanceFB right) => left.Handle != right.Handle;
    public static bool operator ==(XrGeometryInstanceFB left, ulong right) => left.Handle == right;
    public static bool operator !=(XrGeometryInstanceFB left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrGeometryInstanceFB h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrGeometryInstanceFB h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrFacialTrackerHTC : IEquatable<XrFacialTrackerHTC>
{
    public readonly ulong Handle;
    public XrFacialTrackerHTC(ulong existingHandle) { Handle = existingHandle; }
    public static XrFacialTrackerHTC Null => new(0);
    public static implicit operator XrFacialTrackerHTC(ulong handle) => new(handle);
    public static bool operator ==(XrFacialTrackerHTC left, XrFacialTrackerHTC right) => left.Handle == right.Handle;
    public static bool operator !=(XrFacialTrackerHTC left, XrFacialTrackerHTC right) => left.Handle != right.Handle;
    public static bool operator ==(XrFacialTrackerHTC left, ulong right) => left.Handle == right;
    public static bool operator !=(XrFacialTrackerHTC left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrFacialTrackerHTC h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrFacialTrackerHTC h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrPassthroughHTC : IEquatable<XrPassthroughHTC>
{
    public readonly ulong Handle;
    public XrPassthroughHTC(ulong existingHandle) { Handle = existingHandle; }
    public static XrPassthroughHTC Null => new(0);
    public static implicit operator XrPassthroughHTC(ulong handle) => new(handle);
    public static bool operator ==(XrPassthroughHTC left, XrPassthroughHTC right) => left.Handle == right.Handle;
    public static bool operator !=(XrPassthroughHTC left, XrPassthroughHTC right) => left.Handle != right.Handle;
    public static bool operator ==(XrPassthroughHTC left, ulong right) => left.Handle == right;
    public static bool operator !=(XrPassthroughHTC left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrPassthroughHTC h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrPassthroughHTC h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrFaceTrackerFB : IEquatable<XrFaceTrackerFB>
{
    public readonly ulong Handle;
    public XrFaceTrackerFB(ulong existingHandle) { Handle = existingHandle; }
    public static XrFaceTrackerFB Null => new(0);
    public static implicit operator XrFaceTrackerFB(ulong handle) => new(handle);
    public static bool operator ==(XrFaceTrackerFB left, XrFaceTrackerFB right) => left.Handle == right.Handle;
    public static bool operator !=(XrFaceTrackerFB left, XrFaceTrackerFB right) => left.Handle != right.Handle;
    public static bool operator ==(XrFaceTrackerFB left, ulong right) => left.Handle == right;
    public static bool operator !=(XrFaceTrackerFB left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrFaceTrackerFB h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrFaceTrackerFB h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrBodyTrackerFB : IEquatable<XrBodyTrackerFB>
{
    public readonly ulong Handle;
    public XrBodyTrackerFB(ulong existingHandle) { Handle = existingHandle; }
    public static XrBodyTrackerFB Null => new(0);
    public static implicit operator XrBodyTrackerFB(ulong handle) => new(handle);
    public static bool operator ==(XrBodyTrackerFB left, XrBodyTrackerFB right) => left.Handle == right.Handle;
    public static bool operator !=(XrBodyTrackerFB left, XrBodyTrackerFB right) => left.Handle != right.Handle;
    public static bool operator ==(XrBodyTrackerFB left, ulong right) => left.Handle == right;
    public static bool operator !=(XrBodyTrackerFB left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrBodyTrackerFB h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrBodyTrackerFB h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrEyeTrackerFB : IEquatable<XrEyeTrackerFB>
{
    public readonly ulong Handle;
    public XrEyeTrackerFB(ulong existingHandle) { Handle = existingHandle; }
    public static XrEyeTrackerFB Null => new(0);
    public static implicit operator XrEyeTrackerFB(ulong handle) => new(handle);
    public static bool operator ==(XrEyeTrackerFB left, XrEyeTrackerFB right) => left.Handle == right.Handle;
    public static bool operator !=(XrEyeTrackerFB left, XrEyeTrackerFB right) => left.Handle != right.Handle;
    public static bool operator ==(XrEyeTrackerFB left, ulong right) => left.Handle == right;
    public static bool operator !=(XrEyeTrackerFB left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrEyeTrackerFB h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrEyeTrackerFB h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrSpaceUserFB : IEquatable<XrSpaceUserFB>
{
    public readonly ulong Handle;
    public XrSpaceUserFB(ulong existingHandle) { Handle = existingHandle; }
    public static XrSpaceUserFB Null => new(0);
    public static implicit operator XrSpaceUserFB(ulong handle) => new(handle);
    public static bool operator ==(XrSpaceUserFB left, XrSpaceUserFB right) => left.Handle == right.Handle;
    public static bool operator !=(XrSpaceUserFB left, XrSpaceUserFB right) => left.Handle != right.Handle;
    public static bool operator ==(XrSpaceUserFB left, ulong right) => left.Handle == right;
    public static bool operator !=(XrSpaceUserFB left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrSpaceUserFB h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrSpaceUserFB h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrPassthroughColorLutMETA : IEquatable<XrPassthroughColorLutMETA>
{
    public readonly ulong Handle;
    public XrPassthroughColorLutMETA(ulong existingHandle) { Handle = existingHandle; }
    public static XrPassthroughColorLutMETA Null => new(0);
    public static implicit operator XrPassthroughColorLutMETA(ulong handle) => new(handle);
    public static bool operator ==(XrPassthroughColorLutMETA left, XrPassthroughColorLutMETA right) => left.Handle == right.Handle;
    public static bool operator !=(XrPassthroughColorLutMETA left, XrPassthroughColorLutMETA right) => left.Handle != right.Handle;
    public static bool operator ==(XrPassthroughColorLutMETA left, ulong right) => left.Handle == right;
    public static bool operator !=(XrPassthroughColorLutMETA left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrPassthroughColorLutMETA h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrPassthroughColorLutMETA h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrPlaneDetectorEXT : IEquatable<XrPlaneDetectorEXT>
{
    public readonly ulong Handle;
    public XrPlaneDetectorEXT(ulong existingHandle) { Handle = existingHandle; }
    public static XrPlaneDetectorEXT Null => new(0);
    public static implicit operator XrPlaneDetectorEXT(ulong handle) => new(handle);
    public static bool operator ==(XrPlaneDetectorEXT left, XrPlaneDetectorEXT right) => left.Handle == right.Handle;
    public static bool operator !=(XrPlaneDetectorEXT left, XrPlaneDetectorEXT right) => left.Handle != right.Handle;
    public static bool operator ==(XrPlaneDetectorEXT left, ulong right) => left.Handle == right;
    public static bool operator !=(XrPlaneDetectorEXT left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrPlaneDetectorEXT h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrPlaneDetectorEXT h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrVirtualKeyboardMETA : IEquatable<XrVirtualKeyboardMETA>
{
    public readonly ulong Handle;
    public XrVirtualKeyboardMETA(ulong existingHandle) { Handle = existingHandle; }
    public static XrVirtualKeyboardMETA Null => new(0);
    public static implicit operator XrVirtualKeyboardMETA(ulong handle) => new(handle);
    public static bool operator ==(XrVirtualKeyboardMETA left, XrVirtualKeyboardMETA right) => left.Handle == right.Handle;
    public static bool operator !=(XrVirtualKeyboardMETA left, XrVirtualKeyboardMETA right) => left.Handle != right.Handle;
    public static bool operator ==(XrVirtualKeyboardMETA left, ulong right) => left.Handle == right;
    public static bool operator !=(XrVirtualKeyboardMETA left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrVirtualKeyboardMETA h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrVirtualKeyboardMETA h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrSpatialGraphNodeBindingMSFT : IEquatable<XrSpatialGraphNodeBindingMSFT>
{
    public readonly ulong Handle;
    public XrSpatialGraphNodeBindingMSFT(ulong existingHandle) { Handle = existingHandle; }
    public static XrSpatialGraphNodeBindingMSFT Null => new(0);
    public static implicit operator XrSpatialGraphNodeBindingMSFT(ulong handle) => new(handle);
    public static bool operator ==(XrSpatialGraphNodeBindingMSFT left, XrSpatialGraphNodeBindingMSFT right) => left.Handle == right.Handle;
    public static bool operator !=(XrSpatialGraphNodeBindingMSFT left, XrSpatialGraphNodeBindingMSFT right) => left.Handle != right.Handle;
    public static bool operator ==(XrSpatialGraphNodeBindingMSFT left, ulong right) => left.Handle == right;
    public static bool operator !=(XrSpatialGraphNodeBindingMSFT left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrSpatialGraphNodeBindingMSFT h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrSpatialGraphNodeBindingMSFT h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrSceneObserverMSFT : IEquatable<XrSceneObserverMSFT>
{
    public readonly ulong Handle;
    public XrSceneObserverMSFT(ulong existingHandle) { Handle = existingHandle; }
    public static XrSceneObserverMSFT Null => new(0);
    public static implicit operator XrSceneObserverMSFT(ulong handle) => new(handle);
    public static bool operator ==(XrSceneObserverMSFT left, XrSceneObserverMSFT right) => left.Handle == right.Handle;
    public static bool operator !=(XrSceneObserverMSFT left, XrSceneObserverMSFT right) => left.Handle != right.Handle;
    public static bool operator ==(XrSceneObserverMSFT left, ulong right) => left.Handle == right;
    public static bool operator !=(XrSceneObserverMSFT left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrSceneObserverMSFT h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrSceneObserverMSFT h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrSceneMSFT : IEquatable<XrSceneMSFT>
{
    public readonly ulong Handle;
    public XrSceneMSFT(ulong existingHandle) { Handle = existingHandle; }
    public static XrSceneMSFT Null => new(0);
    public static implicit operator XrSceneMSFT(ulong handle) => new(handle);
    public static bool operator ==(XrSceneMSFT left, XrSceneMSFT right) => left.Handle == right.Handle;
    public static bool operator !=(XrSceneMSFT left, XrSceneMSFT right) => left.Handle != right.Handle;
    public static bool operator ==(XrSceneMSFT left, ulong right) => left.Handle == right;
    public static bool operator !=(XrSceneMSFT left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrSceneMSFT h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrSceneMSFT h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

public partial struct XrSpatialAnchorStoreConnectionMSFT : IEquatable<XrSpatialAnchorStoreConnectionMSFT>
{
    public readonly ulong Handle;
    public XrSpatialAnchorStoreConnectionMSFT(ulong existingHandle) { Handle = existingHandle; }
    public static XrSpatialAnchorStoreConnectionMSFT Null => new(0);
    public static implicit operator XrSpatialAnchorStoreConnectionMSFT(ulong handle) => new(handle);
    public static bool operator ==(XrSpatialAnchorStoreConnectionMSFT left, XrSpatialAnchorStoreConnectionMSFT right) => left.Handle == right.Handle;
    public static bool operator !=(XrSpatialAnchorStoreConnectionMSFT left, XrSpatialAnchorStoreConnectionMSFT right) => left.Handle != right.Handle;
    public static bool operator ==(XrSpatialAnchorStoreConnectionMSFT left, ulong right) => left.Handle == right;
    public static bool operator !=(XrSpatialAnchorStoreConnectionMSFT left, ulong right) => left.Handle != right;
    public readonly bool Equals(XrSpatialAnchorStoreConnectionMSFT h) => Handle == h.Handle;
    public readonly override bool Equals(object o) => o is XrSpatialAnchorStoreConnectionMSFT h && Equals(h);
    public readonly override int GetHashCode() => Handle.GetHashCode();
}

#pragma warning restore IDE0250 // Make struct 'readonly'