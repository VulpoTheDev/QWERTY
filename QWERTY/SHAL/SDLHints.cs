using System.Runtime.CompilerServices;
using System.Text;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_hints.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 26/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public static class HintName {
        public const string AccelerometerAsJoystick = "SDL_ACCELEROMETER_AS_JOYSTICK";
        public const string AllowAltTabWhileGrabbed = "SDL_ALLOW_ALT_TAB_WHILE_GRABBED";
        public const string AllowTopMost = "SDL_ALLOW_TOPMOST";

        public const string AndroidApkExpansionMainFileVersion = "SDL_ANDROID_APK_EXPANSION_MAIN_FILE_VERSION";
        public const string AndroidBlockOnPause = "SDL_ANDROID_BLOCK_ON_PAUSE";
        public const string AndroidTrapBackButton = "SDL_ANDROID_TRAP_BACK_BUTTON";

        public const string AppName = "SDL_APP_NAME";

        public const string AppleTvControllerUiEvents = "SDL_APPLE_TV_CONTROLLER_UI_EVENTS";
        public const string AppleTvRemoteAllowRotation = "SDL_APPLE_TV_REMOTE_ALLOW_ROTATION";

        public const string AudioCategory = "SDL_AUDIO_CATEGORY";
        public const string AudioDeviceAppName = "SDL_AUDIO_DEVICE_APP_NAME";
        public const string AudioDeviceStreamName = "SDL_AUDIO_DEVICE_STREAM_NAME";
        public const string AudioDeviceStreamRole = "SDL_AUDIO_DEVICE_STREAM_ROLE";
        public const string AudioResamplingMode = "SDL_AUDIO_RESAMPLING_MODE";

        public const string AutoUpdateJoysticks = "SDL_AUTO_UPDATE_JOYSTICKS";
        public const string AutoUpdateSensors = "SDL_AUTO_UPDATE_SENSORS";

        public const string BmpSaveLegacyFormat = "SDL_BMP_SAVE_LEGACY_FORMAT";

        public const string DisplayUsableBounds = "SDL_DISPLAY_USABLE_BOUNDS";

        public const string EmscriptenAsyncify = "SDL_EMSCRIPTEN_ASYNCIFY";
        public const string EmscriptenKeyboardElement = "SDL_EMSCRIPTEN_KEYBOARD_ELEMENT";

        public const string EnableSteamControllers = "SDL_ENABLE_STEAM_CONTROLLERS";

        public const string EventLogging = "SDL_EVENT_LOGGING";

        public const string FrameBufferAcceleration = "SDL_FRAMEBUFFER_ACCELERATION";

        public const string GameControllerConfig = "SDL_GAMECONTROLLERCONFIG";
        public const string GameControllerConfigFile = "SDL_GAMECONTROLLERCONFIG_FILE";
        public const string GameControllerType = "SDL_GAMECONTROLLERTYPE";
        public const string GameControllerIgnoreDevices = "SDL_GAMECONTROLLER_IGNORE_DEVICES";
        public const string GameControllerIgnoreDevicesExcept = "SDL_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT";
        public const string GameControllerUseButtonLabels = "SDL_GAMECONTROLLER_USE_BUTTON_LABELS";

        public const string GrabKeyboard = "SDL_GRAB_KEYBOARD";

        public const string ImeInternalEditing = "SDL_IME_INTERNAL_EDITING";
        public const string ImeShowUi = "SDL_IME_SHOW_UI";
        public const string ReturnKeyHidesIme = "SDL_RETURN_KEY_HIDES_IME";

        public const string IosIdleTimerDisabled = "SDL_IOS_IDLE_TIMER_DISABLED";
        public const string IosHideHomeIndicator = "SDL_IOS_HIDE_HOME_INDICATOR";
        public const string IosOrientations = "SDL_IOS_ORIENTATIONS";

        public const string JoystickAllowBackgroundEvents = "SDL_JOYSTICK_ALLOW_BACKGROUND_EVENTS";
        public const string JoystickHidApi = "SDL_JOYSTICK_HIDAPI";
        public const string JoystickHidApiGameCube = "SDL_JOYSTICK_HIDAPI_GAMECUBE";
        public const string JoystickHidApiJoyCons = "SDL_JOYSTICK_HIDAPI_JOY_CONS";
        public const string JoystickHidApiLuna = "SDL_JOYSTICK_HIDAPI_LUNA";
        public const string JoystickHidApiPs4 = "SDL_JOYSTICK_HIDAPI_PS4";
        public const string JoystickHidApiPs4Rumble = "SDL_JOYSTICK_HIDAPI_PS4_RUMBLE";
        public const string JoystickHidApiPs5 = "SDL_JOYSTICK_HIDAPI_PS5";
        public const string JoystickHidApiPs5PlayerLed = "SDL_JOYSTICK_HIDAPI_PS5_PLAYER_LED";
        public const string JoystickHidApiPs5Rumble = "SDL_JOYSTICK_HIDAPI_PS5_RUMBLE";
        public const string JoystickHidApiStadia = "SDL_JOYSTICK_HIDAPI_STADIA";
        public const string JoystickHidApiSteam = "SDL_JOYSTICK_HIDAPI_STEAM";
        public const string JoystickHidApiSwitch = "SDL_JOYSTICK_HIDAPI_SWITCH";
        public const string JoystickHidApiSwitchHomeLed = "SDL_JOYSTICK_HIDAPI_SWITCH_HOME_LED";
        public const string JoystickHidApiXbox = "SDL_JOYSTICK_HIDAPI_XBOX";
        public const string JoystickHidApiRawInput = "SDL_JOYSTICK_RAWINPUT";
        public const string JoystickRawInputCorrelateXInput = "SDL_JOYSTICK_RAWINPUT_CORRELATE_XINPUT";
        public const string JoystickThread = "SDL_JOYSTICK_THREAD";

        public const string KmsDrmRequireDrmMaster = "SDL_KMSDRM_REQUIRE_DRM_MASTER";

        public const string LinuxJoystickDeadZones = "SDL_LINUX_JOYSTICK_DEADZONES";

        public const string MacBackgroundApp = "SDL_MAC_BACKGROUND_APP";
        public const string MacCtrlClickEmulateRightClick = "SDL_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK";

        public const string MouseDoubleClickRadius = "SDL_MOUSE_DOUBLE_CLICK_RADIUS";
        public const string MouseDoubleClickTime = "SDL_MOUSE_DOUBLE_CLICK_TIME";
        public const string MouseFocusClickThrough = "SDL_MOUSE_FOCUS_CLICKTHROUGH";
        public const string MouseNormalSpeedScale = "SDL_MOUSE_NORMAL_SPEED_SCALE";
        public const string MouseRelativeModeWarp = "SDL_MOUSE_RELATIVE_MODE_WARP";
        public const string MouseRelativeScaling = "SDL_MOUSE_RELATIVE_SCALING";
        public const string MouseRelativeSpeedScale = "SDL_MOUSE_RELATIVE_SPEED_SCALE";
        public const string MouseTouchEvents = "SDL_MOUSE_TOUCH_EVENTS";

        public const string NoSignalHandlers = "SDL_NO_SIGNAL_HANDLERS";

        public const string OpenGlEsDriver = "SDL_OPENGL_ES_DRIVER";

        public const string PreferredLocales = "SDL_PREFERRED_LOCALES";

        public const string QtWaylandContentOrientation = "SDL_QTWAYLAND_CONTENT_ORIENTATION";
        public const string QtWaylandWindowFlags = "SDL_QTWAYLAND_WINDOW_FLAGS";

        public const string RenderBatching = "SDL_RENDER_BATCHING";
        public const string RenderDirect3D11Debug = "SDL_RENDER_DIRECT3D11_DEBUG";
        public const string RenderDirect3DThreadSafe = "SDL_RENDER_DIRECT3D_THREADSAFE";
        public const string RenderDriver = "SDL_RENDER_DRIVER";
        public const string RenderLogicalSizeMode = "SDL_RENDER_LOGICAL_SIZE_MODE";
        public const string RenderOpenGlShaders = "SDL_RENDER_OPENGL_SHADERS";
        public const string RenderScaleQuality = "SDL_RENDER_SCALE_QUALITY";
        public const string RenderVSync = "SDL_RENDER_VSYNC";

        public const string RpiVideoLayer = "SDL_RPI_VIDEO_LAYER";

        public const string ScreenSaverInhibitActivityName = "SDL_SCREENSAVER_INHIBIT_ACTIVITY_NAME";

        public const string ThreadForceRealtimeTimeCritical = "SDL_THREAD_FORCE_REALTIME_TIME_CRITICAL";
        public const string ThreadPriorityPolicy = "SDL_THREAD_PRIORITY_POLICY";
        public const string ThreadStackSize = "SDL_THREAD_STACK_SIZE";

        public const string TimerResolution = "SDL_TIMER_RESOLUTION";

        public const string TouchMouseEvents = "SDL_TOUCH_MOUSE_EVENTS";

        public const string TvRemoteAsJoystick = "SDL_TV_REMOTE_AS_JOYSTICK";

        public const string VideoAllowScreenSaver = "SDL_VIDEO_ALLOW_SCREENSAVER";
        public const string VideoDoubleBuffer = "SDL_VIDEO_DOUBLE_BUFFER";
        public const string VideoEglAllowTransparency = "SDL_VIDEO_EGL_ALLOW_TRANSPARENCY";
        public const string VideoExternalContext = "SDL_VIDEO_EXTERNAL_CONTEXT";
        public const string VideoHighDpiDisabled = "SDL_VIDEO_HIGHDPI_DISABLED";
        public const string VideoMacFullscreenSpaces = "SDL_VIDEO_MAC_FULLSCREEN_SPACES";
        public const string VideoMinimizeOnFocusLoss = "SDL_VIDEO_MINIMIZE_ON_FOCUS_LOSS";
        public const string VideoWaylandAllowLibDecor = "SDL_VIDEO_WAYLAND_ALLOW_LIBDECOR";
        public const string VideoWindowSharePixelFormat = "SDL_VIDEO_WINDOW_SHARE_PIXEL_FORMAT";
        public const string VideoWinD3DCompiler = "SDL_VIDEO_WIN_D3DCOMPILER";
        public const string VideoX11ForceEgl = "SDL_VIDEO_X11_FORCE_EGL";
        public const string VideoX11NetWmBypassCompositor = "SDL_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR";
        public const string VideoX11NetWmPing = "SDL_VIDEO_X11_NET_WM_PING";
        public const string VideoX11WindowVisualizer = "SDL_VIDEO_X11_WINDOW_VISUALID";
        public const string VideoX11Xinerama = "SDL_VIDEO_X11_XINERAMA";
        public const string VideoX11Xrandr = "SDL_VIDEO_X11_XRANDR";
        public const string VideoX11XVidMode = "SDL_VIDEO_X11_XVIDMODE";

        public const string WaveFactChunk = "SDL_WAVE_FACT_CHUNK";
        public const string WaveRiffChunkSize = "SDL_WAVE_RIFF_CHUNK_SIZE";
        public const string WaveTruncation = "SDL_WAVE_TRUNCATION";

        public const string WindowsDisableThreadNaming = "SDL_WINDOWS_DISABLE_THREAD_NAMING";
        public const string WindowsEnableMessageLoop = "SDL_WINDOWS_ENABLE_MESSAGELOOP";
        public const string WindowsForceMutexCriticalSections = "SDL_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS";
        public const string WindowsForceSemaphoreKernel = "SDL_WINDOWS_FORCE_SEMAPHORE_KERNEL";
        public const string WindowsIntResourceIcon = "SDL_WINDOWS_INTRESOURCE_ICON";
        public const string WindowsIntResourceIconSmall = "SDL_WINDOWS_INTRESOURCE_ICON_SMALL";
        public const string WindowsNoCloseOnAltF4 = "SDL_WINDOWS_NO_CLOSE_ON_ALT_F4";
        public const string WindowsUseD3D9Ex = "SDL_WINDOWS_USE_D3D9EX";

        public const string WindowFrameUsableWhileCursorHidden = "SDL_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN";

        public const string WinRtHandleBackButton = "SDL_WINRT_HANDLE_BACK_BUTTON";
        public const string WinRtPrivacyPolicyLabel = "SDL_WINRT_PRIVACY_POLICY_LABEL";
        public const string WinRtPrivacyPolicyUrl = "SDL_WINRT_PRIVACY_POLICY_URL";

        public const string X11ForceOverrideRedirect = "SDL_X11_FORCE_OVERRIDE_REDIRECT";

        public const string XInputUseOldJoystickMapping = "SDL_XINPUT_USE_OLD_JOYSTICK_MAPPING";
    }

    public enum HintPriority {
        Default,
        Normal,
        Override
    }

    [Import(ModuleName, "SDL_SetHintWithPriority")]
    public static readonly delegate* unmanaged<void*, void*, HintPriority, bool> SetWithPriority = null!;

    [Import(ModuleName, "SDL_SetHint")]
    public static readonly delegate* unmanaged<void*, void*, bool> Set = null!;

    [Import(ModuleName, "SDL_GetHint")]
    public static readonly delegate* unmanaged<void*, void*> Get = null!;

    [Import(ModuleName, "SDL_GetHintBoolean")]
    public static readonly delegate* unmanaged<void*, bool, bool> GetBoolean = null!;

    [Import(ModuleName, "SDL_AddHintCallback")]
    public static readonly delegate* unmanaged<void*, delegate*<void*, void*, void*, void*, void>, void*, void> AddCallback = null!;

    [Import(ModuleName, "SDL_DelHintCallback")]
    public static readonly delegate* unmanaged<void*, delegate*<void*, void*, void*, void*, void>, void*, void> DelCallback = null!;

    [Import(ModuleName, "SDL_ClearHints")]
    public static readonly delegate* unmanaged<void> Clear = null!;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool SetWithPriorityMarshaled(string attribute, string value, HintPriority priority) {
        fixed (byte* pAttribute = Encoding.UTF8.GetBytes(attribute)) {
            fixed (byte* pValue = Encoding.UTF8.GetBytes(value)) {
                return SetWithPriority(pAttribute, pValue, priority);
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool SetMarshaled(string attribute, string value) {
        fixed (byte* pAttribute = Encoding.UTF8.GetBytes(attribute)) {
            fixed (byte* pValue = Encoding.UTF8.GetBytes(value)) {
                return Set(pAttribute, pValue);
            }
        }
    }
}