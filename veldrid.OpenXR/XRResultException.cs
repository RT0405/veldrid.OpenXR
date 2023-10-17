using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
