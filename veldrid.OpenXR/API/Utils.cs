using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Veldrid.OpenXR;
internal static class Utils
{
    internal struct autoMarshalDispose : IDisposable
    {
        public IntPtr ptr;
        public autoMarshalDispose(IntPtr intPtr)
        {
            ptr = intPtr;
        }
        public void Dispose()
        {
            if (ptr != IntPtr.Zero)
                Marshal.FreeHGlobal(ptr);
            ptr = IntPtr.Zero;
        }
    }
}