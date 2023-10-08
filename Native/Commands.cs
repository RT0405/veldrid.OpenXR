using System.Runtime.InteropServices;
//using static Veldrid.OpenXR.Native.OperatingSystemHelper;

namespace Veldrid.OpenXR.Native;
public static unsafe partial class OpenXRNative
{
    private const string dllName = "openxr_loader";
    private const CallingConvention callConv = CallingConvention.StdCall;

    //private static readonly NativeLibrary nativeLib;

    //static OpenXRNative()
    //{
    //    nativeLib = LoadNativeLibrary();
    //    LoadFuncionPointers();
    //}

    //private static NativeLibrary LoadNativeLibrary()
    //{
    //    return NativeLibrary.Load(GetOpenXRName());
    //}

    //private static string GetOpenXRName()
    //{
    //    if (IsOSPlatform(PlatformType.Windows))
    //    {
    //        return "openxr_loader.dll";
    //    }
    //    else if (IsOSPlatform(PlatformType.Android))
    //    {
    //        // Android
    //        return "libopenxr_loader.so";
    //    }
    //    else if (IsOSPlatform(PlatformType.Linux))
    //    {
    //        // Desktop Linux
    //        return "libopenxr_loader.so.1";
    //    }
    //    else
    //    {
    //        throw new PlatformNotSupportedException();
    //    }
    //}
}