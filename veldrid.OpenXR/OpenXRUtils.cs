using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Veldrid.OpenXR.Native;

namespace Veldrid.OpenXR;
public static class OpenXRUtils
{
    private static T[] Populate<T>(this T[] arr, T value)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = value;
        return arr;
    }
    public static unsafe XrResult CreateXRInstance(ReadOnlySpan<string> requiredExtensions, out XrInstance instance)
    {
        Unsafe.SkipInit(out instance);
        uint extCount = 0;
        XrResult r = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, 0, &extCount, null);
        if (r != XrResult.XR_SUCCESS) return r;

        XrExtensionProperties[] xrExts = new XrExtensionProperties[extCount].Populate(new() { type = XrStructureType.XR_TYPE_EXTENSION_PROPERTIES });

        byte** enabledExtensionNames = (byte**)Marshal.AllocHGlobal(sizeof(byte*) * requiredExtensions.Length);

        fixed (XrExtensionProperties* ptr = xrExts)
        {
            r = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, extCount, &extCount, ptr);
            if (r != XrResult.XR_SUCCESS)
            {
                free();
                return r;
            }
            for (int i = 0; i < requiredExtensions.Length; i++)
            {
                bool contains = false;
                for (int n = 0; n < xrExts.Length; n++)
                {
                    if (Marshal.PtrToStringUTF8((IntPtr)ptr[i].extensionName) == requiredExtensions[i])
                    {
                        contains = true;
                        break;
                    }
                }
                if (contains)
                    enabledExtensionNames[i] = ptr[i].extensionName;
                else
                {
                    free();
                    return XrResult.XR_ERROR_EXTENSION_NOT_PRESENT;
                }
            }
        }

        XrInstanceCreateInfo instanceCreateInfo = new()
        {
            type = XrStructureType.XR_TYPE_INSTANCE_CREATE_INFO,
            applicationInfo = new()
            {
                apiVersion = new XRVersion(1, 0, 30), 
            },
            createFlags = (ulong)XrInstanceCreateFlags.None,
            enabledExtensionCount = extCount,
            enabledExtensionNames = enabledExtensionNames,
        };

        fixed (XrInstance* instancePtr = &instance)
            OpenXRNative.xrCreateInstance(&instanceCreateInfo, instancePtr);

        void free()
        {
            if(enabledExtensionNames != null) Marshal.FreeHGlobal((IntPtr)enabledExtensionNames);
        }
        free();
        return r;
    }
    private struct autoMarshalDispose; IDisposable
    {
        IntPtr ptr;
    }
    public static unsafe XrResult GetAvailableExtensions(out XrExtensionProperties[] availableExtensions)
    {
        availableExtensions = null;
        uint extCount = 0;
        XrResult r = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, 0, &extCount, null);
        if (r != XrResult.XR_SUCCESS) return r;

        availableExtensions = new XrExtensionProperties[extCount].Populate(new() { type = XrStructureType.XR_TYPE_EXTENSION_PROPERTIES });
        fixed (XrExtensionProperties* ptr = availableExtensions)
            r = OpenXRNative.xrEnumerateInstanceExtensionProperties(null, extCount, &extCount, ptr);
        return r;
    }
}