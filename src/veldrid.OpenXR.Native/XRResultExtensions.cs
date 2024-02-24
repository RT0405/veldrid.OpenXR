using System.Runtime.CompilerServices;

namespace Veldrid.OpenXR.Native;

internal static class XRResultExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Succeeded(this XrResult result) => result == XrResult.XR_SUCCESS;
    public static bool Succeeded(this XrResult result, ReadOnlySpan<XrResult> validResults)
    {
        for (int i = 0; i < validResults.Length; i++)
            if (validResults[i] == result)
                return true;
        return false;
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Failed(this XrResult result) => result != XrResult.XR_SUCCESS;
    public static bool Failed(this XrResult result, ReadOnlySpan<XrResult> validResults)
    {
        for (int i = 0; i < validResults.Length; i++)
            if (validResults[i] == result)
                return false;
        return true;
    }
}