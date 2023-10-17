﻿using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Veldrid.OpenXR.Native;

namespace Evergine.Bindings.OpenXR
{
    public abstract class NativeLibrary : IDisposable
    {
        private readonly string libraryName;
        private readonly IntPtr libraryHandle;
        internal XrInstance instance;

        public IntPtr NativeHandle => libraryHandle;

        public NativeLibrary(string libraryName)
        {
            this.libraryName = libraryName;
            libraryHandle = LoadLibrary(this.libraryName);
            if (libraryHandle == IntPtr.Zero)
            {
                throw new InvalidOperationException("Could not load " + libraryName);
            }
        }

        protected abstract IntPtr LoadLibrary(string libraryName);
        protected abstract void FreeLibrary(IntPtr libraryHandle);
        protected abstract IntPtr LoadFunction(string functionName);

        public unsafe void LoadFunction<T>(string name, out T field)
        {
            IntPtr funcPtr = LoadFunction(name);
            IntPtr namePtr = Marshal.StringToHGlobalAnsi(name);
            if (funcPtr == IntPtr.Zero)                
                OpenXRNative.xrGetInstanceProcAddr(instance, (byte*)namePtr, new IntPtr(&funcPtr));
            Marshal.FreeHGlobal(namePtr);

            if (funcPtr != IntPtr.Zero)
                field = Marshal.GetDelegateForFunctionPointer<T>(funcPtr);
            else
            {
                field = default;
                //Debug.WriteLine($" ===> Error loading function {name}");
            }
        }

        public void Dispose()
        {
            FreeLibrary(libraryHandle);
        }

        public static NativeLibrary Load(string libraryName)
        {
            if (OperatingSystemHelper.IsOSPlatform(OperatingSystemHelper.PlatformType.Windows))
            {
                return new WindowsNativeLibrary(libraryName);
            }
            else if (OperatingSystemHelper.IsOSPlatform(OperatingSystemHelper.PlatformType.Android)
                || OperatingSystemHelper.IsOSPlatform(OperatingSystemHelper.PlatformType.Linux)
                || OperatingSystemHelper.IsOSPlatform(OperatingSystemHelper.PlatformType.MacOS))
            {
                return new UnixNativeLibrary(libraryName);
            }
            else
            {
                throw new PlatformNotSupportedException("Cannot load native libraries on this platform: " + RuntimeInformation.OSDescription);
            }
        }

        private class WindowsNativeLibrary : NativeLibrary
        {
            public WindowsNativeLibrary(string libraryName) : base(libraryName)
            {
            }

            protected override IntPtr LoadLibrary(string libraryName)
            {
                return Kernel32.LoadLibrary(libraryName);
            }

            protected override void FreeLibrary(IntPtr libraryHandle)
            {
                Kernel32.FreeLibrary(libraryHandle);
            }

            protected override IntPtr LoadFunction(string functionName)
            {
                Debug.WriteLine("Loading " + functionName);
                return Kernel32.GetProcAddress(NativeHandle, functionName);
            }
        }

        private class UnixNativeLibrary : NativeLibrary
        {
            public UnixNativeLibrary(string libraryName) : base(libraryName)
            {
            }

            protected override IntPtr LoadLibrary(string libraryName)
            {
                Libdl.dlerror();
                IntPtr handle = Libdl.dlopen(libraryName, Libdl.RTLD_NOW);
                if (handle == IntPtr.Zero && !Path.IsPathRooted(libraryName))
                {
                    string baseDir = AppContext.BaseDirectory;
                    if (!string.IsNullOrWhiteSpace(baseDir))
                    {
                        string localPath = Path.Combine(baseDir, libraryName);
                        handle = Libdl.dlopen(localPath, Libdl.RTLD_NOW);
                    }
                }

                return handle;
            }

            protected override void FreeLibrary(IntPtr libraryHandle)
            {
                _ = Libdl.dlclose(libraryHandle);
            }

            protected override IntPtr LoadFunction(string functionName)
            {
                return Libdl.dlsym(NativeHandle, functionName);
            }
        }
    }
}
