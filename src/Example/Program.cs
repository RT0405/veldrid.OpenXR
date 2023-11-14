using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Veldrid;
using Veldrid.OpenXR;
using Veldrid.OpenXR.Native;
using Vulkan;
using static Veldrid.OpenXR.Native.OpenXRNative;

namespace TLE_A2;
public static partial class Program
{
    internal static GraphicsDevice graphicsDevice;
    internal static CommandList commandList;

    internal static DeviceBuffer ProjectionMatrixBuffer;
    internal static DeviceBuffer ObjectMatrixBuffer;
    internal static ResourceLayout ProjectionMatrixResourceLayout;
    internal static ResourceSet ProjectionMatrixResourceSet;

    private static XrInstance xrInstance;
    private static XrSession xrSession;
    private static ulong xrSystemID;
    private static XrSpace xrSpace;

    private static XrView[] xrViews;
    private static XrViewConfigurationView xrConfigViews;
    private static XrDebugUtilsMessengerEXT xrDebugMessenger;

    internal static OutputDescription swapchainDesc;
    internal static readonly List<IDisposable> disposables = new();

    private static bool quit;
    private const GraphicsBackend ChosenBackend = GraphicsBackend.Vulkan;
    public static void Crash(string message, int exitcode = -1)
    {
        Console.WriteLine();
        Console.WriteLine(message);
        Console.WriteLine("press any key to exit...");
        { }
        Environment.Exit(exitcode);
    }
    public static T[] Populate<T>(this T[] arr, T value)
    {
        for(int i = 0; i < arr.Length; i++)
            arr[i] = value;
        return arr;
    }
    private static void CreateResources()
    {
        GraphicsDevice gd = graphicsDevice;

        ProjectionMatrixBuffer = gd.ResourceFactory.CreateBuffer(new BufferDescription(64, BufferUsage.UniformBuffer));
        disposables.Add(ProjectionMatrixBuffer);
        ObjectMatrixBuffer = graphicsDevice.ResourceFactory.CreateBuffer(new BufferDescription(64, BufferUsage.UniformBuffer));
        disposables.Add(ObjectMatrixBuffer);

        ProjectionMatrixResourceLayout = graphicsDevice.ResourceFactory.CreateResourceLayout(
            new ResourceLayoutDescription(
                new ResourceLayoutElementDescription("ProjectionMatrixBuffer", ResourceKind.UniformBuffer, ShaderStages.Vertex),
                new ResourceLayoutElementDescription("ObjectMatrixBuffer", ResourceKind.UniformBuffer, ShaderStages.Vertex)));
        disposables.Add(ProjectionMatrixResourceLayout);

        ProjectionMatrixResourceSet = graphicsDevice.ResourceFactory.CreateResourceSet(new ResourceSetDescription(
                ProjectionMatrixResourceLayout,
                ProjectionMatrixBuffer,
                ObjectMatrixBuffer));
        disposables.Add(ProjectionMatrixResourceSet);
    }
    private static unsafe void Main()
    {
        if(!OpenXRUtils.IsBackendSupported(ChosenBackend))
            throw OpenXRUtils.NewInvalidBackendException("Unable To Start Program", ChosenBackend);
        ConsoleLineProgress progIndicator = new();
        /*progIndicator.Start("Getting Available Api Layers");
        uint apiCount = 0;
        xrEnumerateApiLayerProperties(0, &apiCount, null);
        XrApiLayerProperties[] apis = new XrApiLayerProperties[apiCount].Populate(new() { type = XrStructureType.XR_TYPE_API_LAYER_PROPERTIES });
        fixed(XrApiLayerProperties* ptr = apis)
        {
            xrEnumerateApiLayerProperties(apiCount, &apiCount, ptr);
            Console.WriteLine($"OpenXR Api Layers Available: {apiCount}");
            for(int i = 0; i < apiCount; i++)
                Console.WriteLine($"  {Marshal.PtrToStringUTF8((IntPtr)ptr[i].layerName)}");
        }
        progIndicator.Complete();

        progIndicator.Start("Getting Available XR Extensions");
        uint extCount = 0;
        xrEnumerateInstanceExtensionProperties(null, 0, &extCount, null);
        XrExtensionProperties[] exts = new XrExtensionProperties[extCount].Populate(new() { type = XrStructureType.XR_TYPE_EXTENSION_PROPERTIES });
        fixed(XrExtensionProperties* ptr = exts)
        {
            xrEnumerateInstanceExtensionProperties(null, extCount, &extCount, ptr);
            Console.WriteLine($"OpenXR Extensions Available: {extCount}");
            for(int i = 0; i < extCount; i++)
                Console.WriteLine($"  {Marshal.PtrToStringUTF8((IntPtr)ptr[i].extensionName)}");
        }
        progIndicator.Complete();//*/

        progIndicator.Start("Creating XR Instance");
        CreateXRInstance();
        progIndicator.Start("Creating XR Debug Messenger");
        CreateXRDebugMessenger();
        progIndicator.Start("Creating XR Debug Messenger");
        GetXRSystem();
        progIndicator.Complete();

        progIndicator.Start("Creating Graphics Device");
        GraphicsDeviceOptions options = new()
        {
            Debug = true,
            HasMainSwapchain = false,
            PreferStandardClipSpaceYDirection = true,
            PreferDepthRangeZeroToOne = true,
            ResourceBindingModel = ResourceBindingModel.Default,
        };
        graphicsDevice = OpenXRUtils.CreateGraphicsDevice(xrInstance, xrSystemID, options, ChosenBackend, out XrResult r, out string m);
        progIndicator.Complete($"result: {r} message: {m}");
        if(graphicsDevice == null || r != XrResult.XR_SUCCESS)
            throw new XRResultException(r, m);

        progIndicator.Start("Creating Graphics Resources");
        CreateResources();
        progIndicator.Complete();

        progIndicator.Start("Creating XR Session");
        xrSession = OpenXRUtils.CreateXRSession(xrInstance, xrSystemID, graphicsDevice);
        progIndicator.Complete();

        progIndicator.Start("Aqquiring Swapchains");
        (XRSwapchain left, XRSwapchain right) = OpenXRUtils.AqquireSwapchainsStereo(xrInstance, xrSystemID, xrSession, graphicsDevice, PixelFormat.D32_Float_S8_UInt);
        XRSwapchain[] swapchains = { left, right };
        disposables.Add(left);
        disposables.Add(right);
        progIndicator.Complete();

        progIndicator.Start("Setting Output Description");
        swapchainDesc = new(new OutputAttachmentDescription(left.depthFormat), new OutputAttachmentDescription(left.colorFormat));
        progIndicator.Complete();

        progIndicator.Start("Creating XrSpace");
        XrSpace xrSpace = CreateSpace();
        progIndicator.Complete();

        progIndicator.Start("Creating CommandList");
        commandList = graphicsDevice.ResourceFactory.CreateCommandList();
        progIndicator.Complete();

        Console.WriteLine("Starting Main Loop");
        bool running = false;
        XrEventDataBuffer eventData;
        ConsoleSpace frameDebugSpace = new(8);
        while(!quit)
        {
            eventData.type = XrStructureType.XR_TYPE_EVENT_DATA_BUFFER;
            frameDebugSpace.Clear();
            progIndicator.Start("calling xrPollEvent", frameDebugSpace.top + frameDebugSpace.line++);
            XrResult result = xrPollEvent(xrInstance, &eventData);
            progIndicator.Complete($"result: {result} eventData type: {eventData.type}");
            if(result == XrResult.XR_EVENT_UNAVAILABLE)
            {
                if(running)
                {
                    XrFrameWaitInfo frameWaitInfo = XrFrameWaitInfo.New();

                    XrFrameState frameState = XrFrameState.New();

                    progIndicator.Start("calling xrWaitFrame", frameDebugSpace.top + frameDebugSpace.line++);
                    result = xrWaitFrame(xrSession, &frameWaitInfo, &frameState);
                    progIndicator.Complete($"result: {result}");
                    frameDebugSpace.WriteLine($"FrameState.shouldRender: {frameState.shouldRender}");
                    frameDebugSpace.WriteLine($"FrameState.predictedDisplayTime: {frameState.predictedDisplayTime}");
                    frameDebugSpace.WriteLine($"FrameState.predictedDisplayPeriod: {frameState.predictedDisplayPeriod}");
                    if(result != XrResult.XR_SUCCESS)
                    {
                        Console.WriteLine("Failed to wait for frame: " + result);
                        break;
                    }

                    quit = !Render(xrSpace, frameState.predictedDisplayTime, swapchains, frameState.shouldRender);
                }
            }
            else if(result != XrResult.XR_SUCCESS)
            {
                Console.WriteLine("Failed to poll events: " + result);
                break;
            }
            else
            {
                switch(eventData.type)
                {
                    default:
                        Console.WriteLine("Unknown event type received: " + eventData.type);
                        break;
                    case XrStructureType.XR_TYPE_EVENT_DATA_EVENTS_LOST:
                        Console.WriteLine("Event queue overflowed and events were lost.");
                        break;
                    case XrStructureType.XR_TYPE_EVENT_DATA_INSTANCE_LOSS_PENDING:
                        Console.WriteLine("OpenXR instance is shutting down.");
                        quit = true;
                        break;
                    case XrStructureType.XR_TYPE_EVENT_DATA_INTERACTION_PROFILE_CHANGED:
                        Console.WriteLine("The interaction profile has changed.");
                        break;
                    case XrStructureType.XR_TYPE_EVENT_DATA_REFERENCE_SPACE_CHANGE_PENDING:
                        Console.WriteLine("The reference space is changing.");
                        break;
                    case XrStructureType.XR_TYPE_EVENT_DATA_SESSION_STATE_CHANGED:
                    {
                        var e = (XrEventDataSessionStateChanged*)&eventData;
                        Console.WriteLine($"{e->state}");
                        switch(e->state)
                        {
                            default:
                            case XrSessionState.XR_SESSION_STATE_UNKNOWN:
                                //case XR_SESSION_STATE_MAX_ENUM:
                                Console.WriteLine("Unknown session state entered: " + e->state);
                                break;
                            case XrSessionState.XR_SESSION_STATE_IDLE:
                                running = false;
                                break;
                            case XrSessionState.XR_SESSION_STATE_READY:
                            {
                                XrSessionBeginInfo sessionBeginInfo = new()
                                {
                                    type = XrStructureType.XR_TYPE_SESSION_BEGIN_INFO,
                                    primaryViewConfigurationType = XrViewConfigurationType.XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO
                                };

                                progIndicator.Start("calling xrBeginSession");
                                result = xrBeginSession(xrSession, &sessionBeginInfo);
                                progIndicator.Complete($"result: {result}");

                                if(result != XrResult.XR_SUCCESS)
                                    Console.WriteLine("Failed to begin session: " + result);

                                running = true;
                                break;
                            }
                            case XrSessionState.XR_SESSION_STATE_SYNCHRONIZED:
                            case XrSessionState.XR_SESSION_STATE_VISIBLE:
                            case XrSessionState.XR_SESSION_STATE_FOCUSED:
                                running = true;
                                break;
                            case XrSessionState.XR_SESSION_STATE_STOPPING:
                                result = xrEndSession(xrSession);
                                if(result != XrResult.XR_SUCCESS)
                                    Console.WriteLine("Failed to end session: " + result);
                                break;
                            case XrSessionState.XR_SESSION_STATE_LOSS_PENDING:
                                Console.WriteLine("OpenXR session is shutting down.");
                                quit = true;
                                break;
                            case XrSessionState.XR_SESSION_STATE_EXITING:
                                Console.WriteLine("OpenXR runtime requested shutdown.");
                                quit = true;
                                break;
                        }
                        break;
                    }
                }
            }
        }

        Console.WriteLine("Main Loop Exited, Disposing Objects");

        graphicsDevice.WaitForIdle();
        for(int i = disposables.Count - 1; i >= 0; i--)
        {
            disposables[i].Dispose();
            disposables.RemoveAt(i);
        }

        left.Dispose();
        right.Dispose();

        commandList.Dispose();

        xrDestroySpace(xrSpace);

        graphicsDevice.WaitForIdle();

        xrDestroySession(xrSession);

        graphicsDevice.Dispose();

        DestroyXRDebugMessenger();
        DestroyXRInstance();
    }
    private static unsafe void CreateXRInstance()
    {

        Span<XrExtensionProperties> requiredExtensions = ChosenBackend == GraphicsBackend.Vulkan ?
            stackalloc XrExtensionProperties[]
            {
            (XrExtensionProperties)XRExtensionDescriptor.XR_EXT_DEBUG_UTILS,
            (XrExtensionProperties)XRExtensionDescriptor.XR_KHR_VULKAN_ENABLE,
            (XrExtensionProperties)XRExtensionDescriptor.XR_KHR_VULKAN_ENABLE2,
        } :
            stackalloc XrExtensionProperties[]
            {
            (XrExtensionProperties)XRExtensionDescriptor.XR_EXT_DEBUG_UTILS,
            (XrExtensionProperties)XRExtensionDescriptor.XR_KHR_D3D11_ENABLE,
        };

        byte** enabledExtensionNames = stackalloc byte*[requiredExtensions.Length];
        fixed(XrExtensionProperties* requiredExtensionsPtr = requiredExtensions)
            for(int i = 0; i < requiredExtensions.Length; i++)
                enabledExtensionNames[i] = requiredExtensionsPtr[i].extensionName;

        Span<FixedUTF8String256> apiLayers = stackalloc FixedUTF8String256[]
        {
            //"XR_APILAYER_LUNARG_core_validation",
        };
        byte** apiLayerNames = stackalloc byte*[apiLayers.Length];
        fixed(FixedUTF8String256* apiLayersPtr = apiLayers)
            for(int i = 0; i < apiLayers.Length; i++)
                apiLayerNames[i] = apiLayersPtr[i].bytes;
        if(apiLayers.Length == 0) apiLayerNames = null;

        XrInstanceCreateInfo instanceCreateInfo = new()
        {
            type = XrStructureType.XR_TYPE_INSTANCE_CREATE_INFO,
            next = null,
            createFlags = 0,
            applicationInfo = new()
            {
                apiVersion = OpenXRNative.XR_CURRENT_API_VERSION,
                applicationVersion = 1,
                engineVersion = 157,
            },
            enabledApiLayerCount = (uint)apiLayers.Length,
            enabledApiLayerNames = apiLayerNames,
            enabledExtensionCount = (uint)requiredExtensions.Length,
            enabledExtensionNames = enabledExtensionNames,
        };

        Encoding.UTF8.GetBytes("OpenXR Test Example\0", new Span<byte>(instanceCreateInfo.applicationInfo.applicationName, (int)OpenXRNative.XR_MAX_APPLICATION_NAME_SIZE));
        Encoding.UTF8.GetBytes("TempLabsEngine\0", new Span<byte>(instanceCreateInfo.applicationInfo.engineName, (int)OpenXRNative.XR_MAX_ENGINE_NAME_SIZE));

        XrInstance instance;
        XrResult result = xrCreateInstance(&instanceCreateInfo, &instance);
        if(result != XrResult.XR_SUCCESS)
            Crash("Failed to create OpenXR instance: " + result);
        Console.WriteLine(OpenXRNative.Instance);
        xrInstance = instance;
    }
    private unsafe struct FixedUTF8String256
    {
        public fixed byte bytes[256];
        public FixedUTF8String256(string value)
        {
            fixed(byte* bytesPtr = bytes)
                Encoding.UTF8.GetBytes("OpenXR Test Example\0", new Span<byte>(bytesPtr, 256));
        }
        public static implicit operator FixedUTF8String256(string value) => new(value + '\0');
    }
    private static void DestroyXRInstance()
    {
        xrDestroyInstance(xrInstance);
    }
    private static unsafe void CreateXRDebugMessenger()
    {
        XrDebugUtilsMessengerCreateInfoEXT debugMessengerCreateInfo = new()
        {
            type = XrStructureType.XR_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT,
            next = null,
            messageSeverities = (ulong)(
                XrDebugUtilsMessageSeverityFlagsEXT.XR_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT |
                XrDebugUtilsMessageSeverityFlagsEXT.XR_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT |
                XrDebugUtilsMessageSeverityFlagsEXT.XR_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT |
                XrDebugUtilsMessageSeverityFlagsEXT.XR_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT),
            messageTypes = (ulong)(
                XrDebugUtilsMessageTypeFlagsEXT.XR_DEBUG_UTILS_MESSAGE_TYPE_CONFORMANCE_BIT_EXT |
                XrDebugUtilsMessageTypeFlagsEXT.XR_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT |
                XrDebugUtilsMessageTypeFlagsEXT.XR_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT |
                XrDebugUtilsMessageTypeFlagsEXT.XR_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT),
            userCallback = Marshal.GetFunctionPointerForDelegate<XRDebugCallback>(DebugCallback),
            userData = null,
        };

        XrDebugUtilsMessengerEXT debugMessenger;
        XrResult result = xrCreateDebugUtilsMessengerEXT(xrInstance, &debugMessengerCreateInfo, &debugMessenger);
        if(result != XrResult.XR_SUCCESS)
            Crash("Failed to create OpenXR debug messenger: " + result);
        xrDebugMessenger = debugMessenger;
    }
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    unsafe delegate XrBool32 XRDebugCallback(XrDebugUtilsMessageSeverityFlagsEXT severity, XrDebugUtilsMessageTypeFlagsEXT type, XrDebugUtilsMessengerCallbackDataEXT* callbackData, void* userData);
    private static unsafe XrBool32 DebugCallback(XrDebugUtilsMessageSeverityFlagsEXT severity, XrDebugUtilsMessageTypeFlagsEXT type, XrDebugUtilsMessengerCallbackDataEXT* callbackData, void* userData)
    {
        Console.Write("OpenXR ");

        switch(type)
        {
            case XrDebugUtilsMessageTypeFlagsEXT.XR_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT:
                Console.Write("general ");
                break;
            case XrDebugUtilsMessageTypeFlagsEXT.XR_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT:
                Console.Write("validation ");
                break;
            case XrDebugUtilsMessageTypeFlagsEXT.XR_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT:
                Console.Write("performance ");
                break;
            case XrDebugUtilsMessageTypeFlagsEXT.XR_DEBUG_UTILS_MESSAGE_TYPE_CONFORMANCE_BIT_EXT:
                Console.Write("conformance ");
                break;
        }

        switch(severity)
        {
            case XrDebugUtilsMessageSeverityFlagsEXT.XR_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT:
                Console.Write("(verbose): ");
                break;
            case XrDebugUtilsMessageSeverityFlagsEXT.XR_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT:
                Console.Write("(info): ");
                break;
            case XrDebugUtilsMessageSeverityFlagsEXT.XR_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT:
                Console.Write("(warning): ");
                break;
            case XrDebugUtilsMessageSeverityFlagsEXT.XR_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT:
                Console.Write("(error): ");
                break;
        }
        Console.WriteLine();
        Console.Write(Marshal.PtrToStringUTF8((IntPtr)callbackData->message));
        Console.WriteLine();

        return XrBool32.False;
    }
    private static void DestroyXRDebugMessenger()
    {
        xrDestroyDebugUtilsMessengerEXT(xrDebugMessenger);
    }
    private static unsafe void GetXRSystem()
    {
        ulong systemID;

        XrSystemGetInfo systemGetInfo;
        systemGetInfo.type = XrStructureType.XR_TYPE_SYSTEM_GET_INFO;
        systemGetInfo.formFactor = XrFormFactor.XR_FORM_FACTOR_HEAD_MOUNTED_DISPLAY;

        XrResult result = xrGetSystem(xrInstance, &systemGetInfo, &systemID);

        if(result != XrResult.XR_SUCCESS)
            Crash("Failed to get system: " + result);

        xrSystemID = systemID;
    }
    private static unsafe XrSpace CreateSpace()
    {
        XrReferenceSpaceCreateInfo spaceCreateInfo = new()
        {
            type = XrStructureType.XR_TYPE_REFERENCE_SPACE_CREATE_INFO,
            referenceSpaceType = XrReferenceSpaceType.XR_REFERENCE_SPACE_TYPE_STAGE,
            poseInReferenceSpace = XrPosef.Identity
        };

        XrSpace space;
        XrResult result = xrCreateReferenceSpace(xrSession, &spaceCreateInfo, &space);

        if(result != XrResult.XR_SUCCESS)
        {
            Console.WriteLine("Failed to create space: " + result);
            return XrSpace.Null;
        }

        return space;
    }
    private static unsafe bool Render(XrSpace space, long predictedDisplayTime, XRSwapchain[] swapchains, bool shouldRender)
    {
        XrFrameBeginInfo beginFrameInfo = XrFrameBeginInfo.New();

        XrResult result = xrBeginFrame(xrSession, &beginFrameInfo);

        if(result != XrResult.XR_SUCCESS)
        {
            Console.WriteLine("Failed to begin frame: " + result);
            return false;
        }

        XrViewLocateInfo viewLocateInfo = new()
        {
            type = XrStructureType.XR_TYPE_VIEW_LOCATE_INFO,
            viewConfigurationType = XrViewConfigurationType.XR_VIEW_CONFIGURATION_TYPE_PRIMARY_STEREO,
            displayTime = predictedDisplayTime,
            space = space
        };

        XrViewState viewState = XrViewState.New();

        uint viewCount = 2;
        XrView* views = stackalloc XrView[(int)viewCount];
        views[0].type = XrStructureType.XR_TYPE_VIEW;
        views[1].type = XrStructureType.XR_TYPE_VIEW;

        result = xrLocateViews(
            xrSession,
            &viewLocateInfo,
            &viewState,
            viewCount,
            &viewCount,
            views);

        if(result != XrResult.XR_SUCCESS)
        {
            Console.WriteLine("Failed to locate views: " + result);
            return false;
        }

        for(int i = 0; i < swapchains.Length; i++)
        {
            renderEye(
                views[i],
                swapchains[i]);
        }

        XrCompositionLayerProjectionView* projectedViews = stackalloc XrCompositionLayerProjectionView[2];

        for(int i = 0; i < 2; i++)
        {
            projectedViews[i].type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_PROJECTION_VIEW;
            projectedViews[i].pose = views[i].pose;
            projectedViews[i].fov = views[i].fov;
            projectedViews[i].subImage = new XrSwapchainSubImage()
            {
                swapchain = swapchains[i].Swapchain,
                imageRect = new XrRect2Di() { offset = new() { x = 0, y = 0 }, extent = new() { width = (int)swapchains[i].Width, height = (int)swapchains[i].Height } },
                imageArrayIndex = 0,
            };
        }

        XrCompositionLayerProjection layer = new()
        {
            type = XrStructureType.XR_TYPE_COMPOSITION_LAYER_PROJECTION,
            next = null,
            layerFlags = (ulong)XrCompositionLayerFlags.None,
            space = space,
            viewCount = 2,
            views = projectedViews
        };

        var pLayer = (XrCompositionLayerBaseHeader*)&layer;

        XrFrameEndInfo endFrameInfo = new()
        {
            type = XrStructureType.XR_TYPE_FRAME_END_INFO,
            next = null,
            displayTime = predictedDisplayTime,
            environmentBlendMode = XrEnvironmentBlendMode.XR_ENVIRONMENT_BLEND_MODE_OPAQUE,
            layerCount = 1,
            layers = &pLayer,
        };

        result = xrEndFrame(xrSession, &endFrameInfo);

        if(result != XrResult.XR_SUCCESS)
        {
            Console.WriteLine("Failed to end frame: " + result);
            return false;
        }

        return true;
        static bool renderEye(XrView view, XRSwapchain swapchain)
        {
            const float farDistance = 100;
            const float nearDistance = 100;
            swapchain.AqquireAndWaitNextFramebuffer(out Framebuffer framebuffer);

            commandList.Begin();
            commandList.SetFramebuffer(framebuffer);
            commandList.ClearColorTarget(0, RgbaFloat.Black);
            commandList.ClearDepthStencil(1);

            Matrix4x4 objectmatrix = Matrix4x4.Identity;// * Matrix4x4.CreateRotationX((float)timer.Elapsed.TotalSeconds);

            float angleWidth = MathF.Tan(view.fov.angleRight) - MathF.Tan(view.fov.angleLeft);
            float angleHeight = MathF.Tan(view.fov.angleDown) - MathF.Tan(view.fov.angleUp);

            Matrix4x4 projectionMatrix = new()
            {
                M11 = 2.0f / angleWidth,
                M31 = (MathF.Tan(view.fov.angleRight) + MathF.Tan(view.fov.angleLeft)) / angleWidth,
                M22 = 2.0f / angleHeight,
                M32 = (MathF.Tan(view.fov.angleUp) + MathF.Tan(view.fov.angleDown)) / angleHeight,
                M33 = -farDistance / (farDistance - nearDistance),
                M43 = -(farDistance * nearDistance) / (farDistance - nearDistance),
                M34 = -1
            };

            projectionMatrix = Matrix4x4.Transpose(projectionMatrix);

            Matrix4x4 viewMatrix = Matrix4x4.CreateTranslation(Unsafe.As<XrVector3f, Vector3>(ref view.pose.position)) * Matrix4x4.CreateFromQuaternion(Unsafe.As<XrQuaternionf, Quaternion>(ref view.pose.orientation));
            Matrix4x4 matrix = viewMatrix * projectionMatrix;
            commandList.UpdateBuffer(ProjectionMatrixBuffer, 0, matrix);

            MeshPrimitives.cube.Draw(Matrix4x4.CreateTranslation(objectPosition) * Matrix4x4.CreateFromQuaternion(objectRotation));

            commandList.End();
            graphicsDevice.SubmitCommands(commandList);
            //render

            swapchain.ReleaseFramebuffer();
            return true;
        }
    }
    private static Vector3 objectPosition;
    private static Quaternion objectRotation;
}
class ConsoleSpace
{
    public int top;
    public int line;
    public int size;
    public ConsoleSpace(int size)
    {
        Start(size);
    }
    public void Start(int size)
    {
        this.size = size;
        top = line = Console.CursorTop;
        line++;
        OverwriteLine(top, '-');
        OverwriteLine(top + size + 1, '-');

        Console.CursorTop = top + size + 2;
    }
    public void Clear()
    {
        line = 1;
        OverwriteLine(top, '-');
        for(int i = 0; i < size; i++)
            OverwriteLine(top + i, ' ');
        OverwriteLine(top + size + 1, '-');
    }
    private static void OverwriteLine(int line, char c)
    {
        (int cl, int ct) = Console.GetCursorPosition();
        Console.SetCursorPosition(0, line);
        Console.Write(new string(c, Console.WindowWidth));
        Console.SetCursorPosition(cl, ct);
    }
    public void WriteLine(string message)
    {
        (int cl, int ct) = Console.GetCursorPosition();
        Console.SetCursorPosition(0, top + line++);
        Console.Write(message);
        Console.SetCursorPosition(cl, ct);
    }
}
struct ConsoleLineReference
{
    readonly int line;
    public void Overwrite(string message)
    {
        int l = Console.CursorTop;
        Console.CursorTop = line;
        Console.WriteLine(message);
        Console.CursorTop = l;
    }
}
class ConsoleLineProgress
{
    int top;
    int left;
    readonly Timer timer;
    readonly Stopwatch stopwatch;
    bool isRunning;
    public ConsoleLineProgress()
    {
        timer = new Timer((o) =>
        {
            UpdatePostFix(Ms());
        }, null, Timeout.Infinite, Timeout.Infinite);
        stopwatch = new();
    }
    public void Start(string message) => Start(message, Console.CursorTop);
    public void Start(string message, int line)
    {
        if(isRunning)
            Complete();
        (int cl, int ct) = Console.GetCursorPosition();
        Console.SetCursorPosition(0, line);
        Console.Write(message + ": ");
        (left, top) = Console.GetCursorPosition();
        Console.WriteLine();
        Console.SetCursorPosition(cl, ct);
        timer.Change(0, 900);
        isRunning = true;
        stopwatch.Restart();
    }
    public void Complete(string completionStatus = "Success")
    {
        if(!isRunning)
            return;
        timer.Change(Timeout.Infinite, Timeout.Infinite);
        UpdatePostFix(completionStatus + ", " + Ms());
        isRunning = false;
        stopwatch.Stop();
    }
    private void UpdatePostFix(string postfix)
    {
        (int cl, int ct) = Console.GetCursorPosition();
        Console.SetCursorPosition(left, top);
        Console.Write(postfix);
        Console.SetCursorPosition(cl, ct);
    }
    public void Dispose()
    {
        timer.Dispose();
    }
    public string Ms()
    {
        long ms = stopwatch.ElapsedMilliseconds;
        return $"{ms / 1000}.{(ms % 1000 / 10).ToString().PadLeft(2, '0')}s";
    }
}