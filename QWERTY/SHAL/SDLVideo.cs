using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_video.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum DisplayEventId : byte {
        None,
        Orientation,
        Connected,
        Disconnected
    }

    public enum DisplayOrientation {
        Unknown,
        Landscape,
        LandscapeFlipped,
        Portrait,
        PortraitFlipped
    }

    //public enum WindowFlashOp { - not available with current stable packages
    //    Cancel,
    //    Briefly,
    //    UntilFocused
    //}

    public enum GlAttribute {
        RedSize,
        GreenSize,
        BlueSize,
        AlphaSize,
        BufferSize,
        DoubleBuffer,
        DepthSize,
        StencilSize,
        AccumRedSize,
        AccumGreenSize,
        AccumBlueSize,
        AccumAlphaSize,
        Stereo,
        MultiSampleBuffer,
        MultiSampleSamples,
        AcceleratedVisual,
        RetainedBacking,
        ContextMajorVersion,
        ContextMinorVersion,
        ContextEgl,
        ContextFlags,
        ContextProfileMask,
        ShareWithCurrentContext,
        FramebufferSrgbCapable,
        ContextReleaseBehaviour,
        ContextResetNotification,
        ContextNoError
    }

    [Flags]
    public enum GlContextFlag {
        Debug = 0x0000_0001,
        ForwardCompatible = 0x0000_0002,
        RobustAccess = 0x0000_0004,
        ResetIsolation = 0x0000_0008
    }

    public enum GlContextReleaseFlag {
        None = 0x0000_0000,
        Flush = 0x0000_0001
    }

    public enum GlContextResetNotification {
        NoNotification = 0x0000_0000,
        LoseContext = 0x0000_0001
    }

    [Flags]
    public enum GlProfile {
        Core = 0x0000_0001,
        Compat = 0x0000_0002,
        Es = 0x0000_0004
    }

    public enum HitTestResult {
        Normal,
        Draggable,
        ResizeTopLeft,
        ResizeTop,
        ResizeTopRight,
        ResizeRight,
        ResizeBottomRight,
        ResizeBottom,
        ResizeBottomLeft,
        ResizeLeft
    }

    public enum WindowEventId : byte {
        None,
        Shown,
        Hidden,
        Exposed,
        Moved,
        Resized,
        SizeChanged,
        Minimized,
        Maximized,
        Restored,
        Enter,
        Leave,
        FocusGained,
        FocusLost,
        Close,
        TakeFocus,
        HitTest
    }

    [Flags]
    public enum WindowFlag {
        Fullscreen = 0x0000_0001,
        OpenGl = 0x0000_0002,
        Shown = 0x0000_0004,
        Hidden = 0x0000_0008,
        Borderless = 0x0000_0010,
        Resizable = 0x0000_0020,
        Minimized = 0x0000_0040,
        Maximized = 0x0000_0080,
        MouseGrabbed = 0x0000_0100,
        InputFocus = 0x0000_0200,
        MouseFocus = 0x0000_0400,
        FullscreenDesktop = Fullscreen | 0x0000_1000,
        Foreign = 0x0000_0800,
        AllowHighDpi = 0x0000_2000,
        MouseCapture = 0x0000_4000,
        AlwaysOnTop = 0x0000_8000,
        SkipTaskbar = 0x0001_0000,
        Utility = 0x0002_0000,
        Tooltip = 0x0004_0000,
        PopupMenu = 0x0008_0000,
        KeyboardGrabbed = 0x0010_0000,
        Vulkan = 0x1000_0000,
        Metal = 0x2000_0000
    }

    public const uint WindowPosUndefinedMask = 0x1FFF_0000U;
    public const uint WindowPosUndefined = WindowPosUndefinedMask; // Just here for 1:1 convenience

    public const uint WindowPosCenterMask = 0x2FFF_0000U;
    public const uint WindowPosCenter = WindowPosCenterMask; // Just here for 1:1 convenience

    // Some functions are commented out because they are not available in the
    // core-compatible version/build of SDL2 (- or at least what i think to be
    // the core-compatible version/build..).

    [Import(ModuleName, "SDL_GetNumVideoDrivers")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<int> GetNumVideoDrivers = null!;

    [Import(ModuleName, "SDL_GetVideoDriver")]
    public static readonly delegate* unmanaged<int, void*> GetVideoDriver = null!;

    [Import(ModuleName, "SDL_VideoInit")]
    public static readonly delegate* unmanaged<void*, int> VideoInit = null!;

    [Import(ModuleName, "SDL_VideoQuit")]
    public static readonly delegate* unmanaged<void> VideoQuit = null!;

    [Import(ModuleName, "SDL_GetCurrentVideoDriver")]
    public static readonly delegate* unmanaged<void*> GetCurrentVideoDriver = null!;

    [Import(ModuleName, "SDL_GetNumVideoDisplays")]
    public static readonly delegate* unmanaged<int> GetNumVideoDisplays = null!;

    [Import(ModuleName, "SDL_GetDisplayName")]
    public static readonly delegate* unmanaged<int, void*> GetDisplayName = null!;

    [Import(ModuleName, "SDL_GetDisplayBounds")]
    public static readonly delegate* unmanaged<int, Rect*, int> GetDisplayBounds = null!;

    [Import(ModuleName, "SDL_GetDisplayUsableBounds")]
    public static readonly delegate* unmanaged<int, Rect*, int> GetDisplayUsableBounds = null!;

    [Import(ModuleName, "SDL_GetDisplayDPI")]
    public static readonly delegate* unmanaged<int, float*, float*, float*, int> GetDisplayDpi = null!;

    [Import(ModuleName, "SDL_GetDisplayOrientation")]
    public static readonly delegate* unmanaged<int, DisplayOrientation> GetDisplayOrientation = null!;

    [Import(ModuleName, "SDL_GetNumDisplayModes")]
    public static readonly delegate* unmanaged<int, int> GetNumDisplayModes = null!;

    [Import(ModuleName, "SDL_GetDisplayMode")]
    public static readonly delegate* unmanaged<int, int, DisplayMode*, int> GetDisplayMode = null!;

    [Import(ModuleName, "SDL_GetDesktopDisplayMode")]
    public static readonly delegate* unmanaged<int, DisplayMode*, int> GetDesktopDisplayMode = null!;

    [Import(ModuleName, "SDL_GetCurrentDisplayMode")]
    public static readonly delegate* unmanaged<int, DisplayMode*, int> GetCurrentDisplayMode = null!;

    [Import(ModuleName, "SDL_GetClosestDisplayMode")]
    public static readonly delegate* unmanaged<int, DisplayMode*, DisplayMode*, DisplayMode*> GetClosestDisplayMode = null!;

    [Import(ModuleName, "SDL_GetWindowDisplayIndex")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int> GetWindowDisplayIndex = null!;

    [Import(ModuleName, "SDL_SetWindowDisplayMode")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, DisplayMode*, int> SetWindowDisplayMode = null!;

    [Import(ModuleName, "SDL_GetWindowDisplayMode")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, DisplayMode*, int> GetWindowDisplayMode = null!;

    [Import(ModuleName, "SDL_GetWindowPixelFormat")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, uint> GetWindowPixelFormat = null!;

    [Import(ModuleName, "SDL_CreateWindow")]
    public static readonly delegate* unmanaged<void*, int, int, int, int, WindowFlag, void*> CreateWindow = null!;

    [Import(ModuleName, "SDL_CreateWindowFrom")]
    public static readonly delegate* unmanaged<void*, void*> CreateWindowFrom = null!;

    [Import(ModuleName, "SDL_GetWindowID")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, uint> GetWindowId = null!;

    [Import(ModuleName, "SDL_GetWindowFromID")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<uint, void*> GetWindowFromId = null!;

    [Import(ModuleName, "SDL_GetWindowFlags")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, uint> GetWindowFlags = null!;

    [Import(ModuleName, "SDL_SetWindowTitle")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void*, void> SetWindowTitle = null!;

    [Import(ModuleName, "SDL_GetWindowTitle")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void*> GetWindowTitle = null!;

    [Import(ModuleName, "SDL_SetWindowIcon")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, Surface*, void> SetWindowIcon = null!;

    [Import(ModuleName, "SDL_SetWindowData")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void*, void*, void*> SetWindowData = null!;

    [Import(ModuleName, "SDL_GetWindowData")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void*, void*> GetWindowData = null!;

    [Import(ModuleName, "SDL_SetWindowPosition")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int, int, void> SetWindowPosition = null!;

    [Import(ModuleName, "SDL_GetWindowPosition")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int*, int*, void> GetWindowPosition = null!;

    [Import(ModuleName, "SDL_SetWindowSize")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int, int, void> SetWindowSize = null!;

    [Import(ModuleName, "SDL_GetWindowSize")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int*, int*, void> GetWindowSize = null!;

    [Import(ModuleName, "SDL_GetWindowBordersSize")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int*, int*, int*, int*, int> GetWindowBordersSize = null!;

    [Import(ModuleName, "SDL_SetWindowMinimumSize")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int, int, void> SetWindowMinimumSize = null!;

    [Import(ModuleName, "SDL_GetWindowMinimumSize")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int*, int*, void> GetWindowMinimumSize = null!;

    [Import(ModuleName, "SDL_SetWindowMaximumSize")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int, int, void> SetWindowMaximumSize = null!;

    [Import(ModuleName, "SDL_GetWindowMaximumSize")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int*, int*, void> GetWindowMaximumSize = null!;

    [Import(ModuleName, "SDL_SetWindowBordered")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, bool, void> SetWindowBordered = null!;

    [Import(ModuleName, "SDL_SetWindowResizable")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, bool, void> SetWindowResizable = null!;

    //[Import(ModuleName, "SDL_SetWindowAlwaysOnTop")]
    //public static readonly delegate* unmanaged<void*, bool, void> SetWindowAlwaysOnTop = null!;

    [Import(ModuleName, "SDL_ShowWindow")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void> ShowWindow = null!;

    [Import(ModuleName, "SDL_HideWindow")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void> HideWindow = null!;

    [Import(ModuleName, "SDL_RaiseWindow")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void> RaiseWindow = null!;

    [Import(ModuleName, "SDL_MaximizeWindow")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void> MaximizeWindow = null!;

    [Import(ModuleName, "SDL_MinimizeWindow")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void> MinimizeWindow = null!;

    [Import(ModuleName, "SDL_RestoreWindow")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void> RestoreWindow = null!;

    [Import(ModuleName, "SDL_SetWindowFullscreen")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, uint, int> SetWindowFullscreen = null!;

    [Import(ModuleName, "SDL_GetWindowSurface")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, Surface*> GetWindowSurface = null!;

    [Import(ModuleName, "SDL_UpdateWindowSurface")]
    public static readonly delegate* unmanaged<void*, int> UpdateWindowSurface = null!;

    [Import(ModuleName, "SDL_UpdateWindowSurfaceRects")]
    public static readonly delegate* unmanaged<void*, Rect*, int, int> UpdateWindowSurfaceRects = null!;

    [Import(ModuleName, "SDL_SetWindowGrab")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, bool, void> SetWindowGrab = null!;

    //[Import(ModuleName, "SDL_SetWindowKeyboardGrab")]
    //public static readonly delegate* unmanaged<void*, bool, void> SetWindowKeyboardGrab = null!;

    //[Import(ModuleName, "SDL_SetWindowMouseGrab")]
    //public static readonly delegate* unmanaged<void*, bool, void> SetWindowMouseGrab = null!;

    [Import(ModuleName, "SDL_GetWindowGrab")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, bool> GetWindowGrab = null!;

    //[Import(ModuleName, "SDL_GetWindowKeyboardGrab")]
    //public static readonly delegate* unmanaged<void*, bool> GetWindowKeyboardGrab = null!;

    //[Import(ModuleName, "SDL_GetWindowMouseGrab")]
    //public static readonly delegate* unmanaged<void*, bool> GetWindowMouseGrab = null!;

    [Import(ModuleName, "SDL_GetGrabbedWindow")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*> GetGrabbedWindow = null!;

    [Import(ModuleName, "SDL_SetWindowBrightness")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, float, int> SetWindowBrightness = null!;

    [Import(ModuleName, "SDL_GetWindowBrightness")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, float> GetWindowBrightness = null!;

    [Import(ModuleName, "SDL_SetWindowOpacity")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, float, int> SetWindowOpacity = null!;

    [Import(ModuleName, "SDL_GetWindowOpacity")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, float*, int> GetWindowOpacity = null!;

    [Import(ModuleName, "SDL_SetWindowModalFor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void*, int> SetWindowModalFor = null!;

    [Import(ModuleName, "SDL_SetWindowInputFocus")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int> SetWindowInputFocus = null!;

    [Import(ModuleName, "SDL_SetWindowGammaRamp")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, ushort*, ushort*, ushort*, int> SetWindowGammaRamp = null!;

    [Import(ModuleName, "SDL_GetWindowGammaRamp")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, ushort*, ushort*, ushort*, int> GetWindowGammaRamp = null!;

    [Import(ModuleName, "SDL_SetWindowHitTest")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, delegate* unmanaged<void*, Point*, void*, HitTestResult>, void*, int> SetWindowHitTest = null!;

    //[Import(ModuleName, "SDL_FlashWindow")]
    //public static readonly delegate* unmanaged<void*, FlashOp, int> FlashWindow = null!;

    [Import(ModuleName, "SDL_DestroyWindow")]
    public static readonly delegate* unmanaged<void*, void> DestroyWindow = null!;

    [Import(ModuleName, "SDL_IsScreenSaverEnabled")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<bool> IsScreenSaverEnabled = null!;

    [Import(ModuleName, "SDL_EnableScreenSaver")]
    public static readonly delegate* unmanaged<void> EnableScreenSaver = null!;

    [Import(ModuleName, "SDL_DisableScreenSaver")]
    public static readonly delegate* unmanaged<void> DisableScreenSaver = null!;

    [Import(ModuleName, "SDL_GL_LoadLibrary")]
    public static readonly delegate* unmanaged<void*, int> GlLoadLibrary = null!;

    [Import(ModuleName, "SDL_GL_GetProcAddress")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void*> GlGetProcAddress = null!;

    [Import(ModuleName, "SDL_GL_UnloadLibrary")]
    public static readonly delegate* unmanaged<void> GlUnloadLibrary = null!;

    [Import(ModuleName, "SDL_GL_ExtensionSupported")]
    public static readonly delegate* unmanaged<void*, bool> GlExtensionSupported = null!;

    [Import(ModuleName, "SDL_GL_ResetAttributes")]
    public static readonly delegate* unmanaged<void> GlResetAttributes = null!;

    [Import(ModuleName, "SDL_GL_SetAttribute")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<GlAttribute, int, int> GlSetAttribute = null!;

    [Import(ModuleName, "SDL_GL_GetAttribute")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<GlAttribute, int*, int> GlGetAttribute = null!;

    [Import(ModuleName, "SDL_GL_CreateContext")]
    public static readonly delegate* unmanaged<void*, void*> GlCreateContext = null!;

    [Import(ModuleName, "SDL_GL_MakeCurrent")]
    public static readonly delegate* unmanaged<void*, void*, int> GlMakeCurrent = null!;

    [Import(ModuleName, "SDL_GL_GetCurrentWindow")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*> GlGetCurrentWindow = null!;

    [Import(ModuleName, "SDL_GL_GetCurrentContext")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*> GlGetCurrentContext = null!;

    [Import(ModuleName, "SDL_GL_GetDrawableSize")]
    public static readonly delegate* unmanaged<void*, int*, int*, void> GlGetDrawableSize = null!;

    [Import(ModuleName, "SDL_GL_SetSwapInterval")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<int, int> GlSetSwapInterval = null!;

    [Import(ModuleName, "SDL_GL_GetSwapInterval")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<int> GlGetSwapInterval = null!;

    [Import(ModuleName, "SDL_GL_SwapWindow")]
    public static readonly delegate* unmanaged<void*, void> GlSwapWindow = null!;

    [Import(ModuleName, "SDL_GL_DeleteContext")]
    public static readonly delegate* unmanaged<void*, void> GlDeleteContext = null!;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GetUndefinedWindowPos(uint displayIdx) => displayIdx | WindowPosUndefinedMask;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint GetCenterWindowPos(uint displayIdx) => displayIdx | WindowPosCenterMask;

    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayMode {
        public uint Format;
        public int Width;
        public int Height;
        public int RefreshRate;
        private readonly void* _DriverData;
    }
}