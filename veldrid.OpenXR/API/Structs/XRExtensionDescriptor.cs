using System.Runtime.InteropServices;
using System.Text;
using Veldrid.OpenXR.Native;

namespace Veldrid.OpenXR;
internal struct XRExtensionDescriptor
{
    public string ExtensionName;
    public uint ExtensionVersion;
    public static unsafe explicit operator XrExtensionProperties(XRExtensionDescriptor extension)
    {
        XrExtensionProperties extProps = new()
        {
            type = XrStructureType.XR_TYPE_EXTENSION_PROPERTIES,
            extensionVersion = extension.ExtensionVersion,
            next = null
        };
        extProps.extensionName[Encoding.UTF8.GetBytes(extension.ExtensionName.AsSpan(), new Span<byte>(extProps.extensionName, (int)OpenXRNative.XR_MAX_EXTENSION_NAME_SIZE)) + 1] = 0;
        return extProps;
    }
    public static unsafe explicit operator XRExtensionDescriptor(XrExtensionProperties extension)
    {
        return new()
        {
            ExtensionName = Marshal.PtrToStringUTF8((IntPtr)extension.extensionName),
            ExtensionVersion = extension.extensionVersion
        };
    }
}