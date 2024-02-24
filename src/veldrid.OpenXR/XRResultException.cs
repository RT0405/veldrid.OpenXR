using Veldrid.OpenXR.Native;

namespace Veldrid.OpenXR
{
    public class XRResultException : Exception
    {
        public readonly XrResult Result;
        public XRResultException(XrResult result, string message = null) : base(message)
        {
            Result = result;
        }
    }
}
