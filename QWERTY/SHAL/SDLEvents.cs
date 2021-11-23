using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_events.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum EventAction {
        AddEvent,
        PeekEvent,
        GetEvent
    }

    public enum EventState {
        Quuery = -1,
        Ignore,
        Disable = 0,
        Enable
    }

    public enum EventType : uint {
        FirstEvent, // Not an actual event, this is padding!

        Quit = 0x0000_0100,
        AppTerminating,
        AppLowMemory,
        AppWillEnterBackground,
        AppDidEnterBackground,
        AppWillEnterForeground,
        AppDidEnterForeground,
        LocaleChanged,

        DisplayEvent = 0x0000_0150,

        WindowEvent = 0x0000_0200,
        SysWmEvent,

        KeyDown = 0x0000_0300,
        KeyUp,
        TextEditing,
        TextInput,
        KeyMapChanged,

        MouseMotion = 0x0000_0400,
        MouseButtonDown,
        MouseButtonUp,
        MouseWheel,

        JoyAxisMotion = 0x0000_0600,
        JoyBallMotion,
        JoyHatMotion,
        JoyButtonDown,
        JoyButtonUp,
        JoyDeviceAdded,
        JoyDeviceRemoved,

        ControllerAxisMotion = 0x0000_0650,
        ControllerButtonDown,
        ControllerButtonUp,
        ControllerDeviceAdded,
        ControllerDeviceRemoved,
        ControllerDeviceRemapped,
        ControllerTouchpadDown,
        ControllerTouchpadUp,
        ControllerSensorUpdate,

        FingerDown = 0x0000_0700,
        FingerUp,
        FingerMotion,

        DollarGesture = 0x0000_0800,
        DollarRecord,
        MultiGesture,

        ClipboardUpdate = 0x0000_0900,

        DropFile = 0x0000_1000,
        DropText,
        DropBegin,
        DropComplete,

        AudioDeviceAdded = 0x0000_1100,
        AudioDeviceRemoved,

        SensorUpdate = 0x0000_1200,

        RenderTargetsReset = 0x0000_2000,
        RenderDeviceReset,

        UserEvent = 0x0000_8000,

        LastEvent = 0x0000_FFFF // Not an actual event, this is padding!
    }

    public enum MouseButtonState : byte {
        PRESSED,
        RELEASED
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CommonEvent {
        public EventType Type;
        public uint TimeStamp;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayEvent {
        public EventType Type;
        public uint TimeStamp;
        public uint Display;
        public DisplayEventId Event;
        private readonly byte _Padding0;
        private readonly byte _Padding1;
        private readonly byte _Padding2;
        public int Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WindowEvent {
        public EventType Type;
        public uint TimeStamp;
        public uint WindowId;
        public WindowEventId Event;
        private readonly byte _Padding0;
        private readonly byte _Padding1;
        private readonly byte _Padding2;
        public int Data1;
        public int Data2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct KeyboardEvent {
        public EventType Type;
        public uint TimeStamp;
        public uint WindowId;
        public byte State;
        public byte Repeat;
        private readonly byte _Padding1;
        private readonly byte _Padding2;
        public KeySym KeySym;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TextEditingEvent {
        public EventType Type;
        public uint TimeStamp;
        public uint WindowId;
        public fixed byte Text[32];
        public int Start;
        public int Length;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TextInputEvent {
        public EventType Type;
        public uint TimeStamp;
        public uint WindowId;
        public fixed byte Text[32];
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MouseMotionEvent {
        public EventType Type;
        public uint TimeStamp;
        public uint WindowId;
        public uint Which;
        public uint State;
        public int X;
        public int Y;
        public int XRel;
        public int YRel;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MouseButtonEvent {
        public EventType Type;
        public uint TimeStamp;
        public uint WindowId;
        public uint Which;
        public byte Button;
        public MouseButtonState State;
        public byte Clicks;
        private readonly byte _Padding0;
        public int X;
        public int Y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MouseWheelEvent {
        public EventType Type;
        public uint TimeStamp;
        public uint WindowId;
        public uint Which;
        public int X;
        public int Y;
        public uint Direction;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JoyAxisEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
        public byte Axis;
        private readonly byte _Padding0;
        private readonly byte _Padding1;
        private readonly byte _Padding2;
        public short Value;
        private readonly ushort _Padding3;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JoyBallEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
        public byte Ball;
        private readonly byte _Padding0;
        private readonly byte _Padding1;
        private readonly byte _Padding2;
        public int XRel;
        public int YRel;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JoyHatEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
        public byte Hat;
        public byte Value;
        private readonly byte _Padding0;
        private readonly byte _Padding1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JoyButtonEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
        public byte Button;
        public byte State;
        private readonly byte _Padding0;
        private readonly byte _Padding1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct JoyDeviceEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ControllerAxisEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
        public byte Axis;
        private readonly byte _Padding0;
        private readonly byte _Padding1;
        private readonly byte _Padding2;
        public short Value;
        private readonly ushort _Padding3;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ControllerButtonEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
        public byte Button;
        public byte State;
        private readonly byte _Padding0;
        private readonly byte _Padding1;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ControllerDeviceEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ControllerTouchpadEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
        public int Touchpad;
        public int Finger;
        public float X;
        public float Y;
        public float Pressure;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ControllerSensorEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
        public int Sensor;
        public fixed float Data[3];
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AudioDeviceEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
        public byte IsCapture;
        private readonly byte _Padding0;
        private readonly byte _Padding1;
        private readonly byte _Padding2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TouchFingerEvent {
        public EventType Type;
        public uint TimeStamp;
        public long TouchId;
        public long FingerId;
        public float X;
        public float Y;
        public float DX;
        public float DY;
        public float Pressure;
        public uint WindowId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MultiGestureEvent {
        public EventType Type;
        public uint TimeStamp;
        public long TouchId;
        public float DTheta;
        public float DDist;
        public float X;
        public float Y;
        public ushort NumFingers;
        private readonly ushort _Padding0;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DollarGestureEvent {
        public EventType Type;
        public uint TimeStamp;
        public long TouchId;
        public long GestureId;
        public uint NumFingers;
        public float Error;
        public float X;
        public float Y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DropEvent {
        public EventType Type;
        public uint TimeStamp;
        public void* File;
        public uint WindowId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SensorEvent {
        public EventType Type;
        public uint TimeStamp;
        public int Which;
        public fixed float Data[6];
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct QuitEvent {
        public EventType Type;
        public uint TimeStamp;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct OsEvent {
        public EventType Type;
        public uint TimeStamp;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UserEvent {
        public EventType Type;
        public uint TimeStamp;
        public uint WindowId;
        public int Code;
        public void* Data1;
        public void* Data2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SysWmEvent {
        public EventType Type;
        public uint TimeStamp;
        public WmMessage* Message;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Event {
        [FieldOffset(0)]
        public EventType Type;

        [FieldOffset(4)]
        public uint TimeStamp;

        [FieldOffset(0)]
        public CommonEvent Common;

        [FieldOffset(0)]
        public DisplayEvent Display;

        [FieldOffset(0)]
        public WindowEvent Window;

        [FieldOffset(0)]
        public KeyboardEvent Keyboard;

        [FieldOffset(0)]
        public TextEditingEvent TextEditing;

        [FieldOffset(0)]
        public TextInputEvent TextInput;

        [FieldOffset(0)]
        public MouseMotionEvent MouseMotion;

        [FieldOffset(0)]
        public MouseButtonEvent MouseButton;

        [FieldOffset(0)]
        public MouseWheelEvent MouseWheel;

        [FieldOffset(0)]
        public JoyAxisEvent JoyAxis;

        [FieldOffset(0)]
        public JoyBallEvent JoyBall;

        [FieldOffset(0)]
        public JoyHatEvent JoyHat;

        [FieldOffset(0)]
        public JoyButtonEvent JoyButton;

        [FieldOffset(0)]
        public JoyDeviceEvent JoyDevice;

        [FieldOffset(0)]
        public ControllerAxisEvent ControllerAxis;

        [FieldOffset(0)]
        public ControllerButtonEvent ControllerButton;

        [FieldOffset(0)]
        public ControllerDeviceEvent ControllerDevice;

        [FieldOffset(0)]
        public ControllerTouchpadEvent ControllerTouchpad;

        [FieldOffset(0)]
        public ControllerSensorEvent ControllerSensor;

        [FieldOffset(0)]
        public AudioDeviceEvent AudioDevice;

        [FieldOffset(0)]
        public TouchFingerEvent TouchFinger;

        [FieldOffset(0)]
        public MultiGestureEvent MultiGesture;

        [FieldOffset(0)]
        public DollarGestureEvent DollarGesture;

        [FieldOffset(0)]
        public DropEvent Drop;

        [FieldOffset(0)]
        public SensorEvent Sensor;

        [FieldOffset(0)]
        public QuitEvent Quit;

        [FieldOffset(0)]
        public OsEvent Os;

        [FieldOffset(0)]
        public UserEvent User;

        [FieldOffset(0)]
        public SysWmEvent SysWm;

        [FieldOffset(0)]
        private fixed byte _Padding[52]; // We want to be on the safe-side of things!
    }

    [Import(ModuleName, "SDL_PumpEvents")]
    public static readonly delegate* unmanaged<void> PumpEvents = null!;

    [Import(ModuleName, "SDL_PeepEvents")]
    public static readonly delegate* unmanaged<Event*, int, EventAction, EventType, EventType, int> PeepEvents = null!;

    [Import(ModuleName, "SDL_HasEvent")]
    public static readonly delegate* unmanaged<uint, bool> HasEvent = null!;

    [Import(ModuleName, "SDL_HasEvents")]
    public static readonly delegate* unmanaged<uint, uint, bool> HasEvents = null!;

    [Import(ModuleName, "SDL_FlushEvent")]
    public static readonly delegate* unmanaged<uint, void> FlushEvent = null!;

    [Import(ModuleName, "SDL_FlushEvents")]
    public static readonly delegate* unmanaged<uint, uint, void> FlushEvents = null!;

    [Import(ModuleName, "SDL_PollEvent")]
    public static readonly delegate* unmanaged<Event*, int> PollEvent = null!;

    [Import(ModuleName, "SDL_WaitEvent")]
    public static readonly delegate* unmanaged<Event*, int> WaitEvent = null!;

    [Import(ModuleName, "SDL_WaitEventTimeout")]
    public static readonly delegate* unmanaged<Event*, int, int> WaitEventTimeout = null!;

    [Import(ModuleName, "SDL_PushEvent")]
    public static readonly delegate* unmanaged<Event*, int> PushEvent = null!;

    [Import(ModuleName, "SDL_SetEventFilter")]
    public static readonly delegate* unmanaged<delegate*<void*, Event*, int>, void*, void> SetEventFilter = null!;

    [Import(ModuleName, "SDL_GetEventFilter")]
    public static readonly delegate* unmanaged<delegate*<void*, Event*, int>*, void**, bool> GetEventFilter = null!;

    [Import(ModuleName, "SDL_AddEventWatch")]
    public static readonly delegate* unmanaged<delegate*<void*, Event*, int>, void*, void> AddEventWatch = null!;

    [Import(ModuleName, "SDL_DelEventWatch")]
    public static readonly delegate* unmanaged<delegate*<void*, Event*, int>, void*, void> DelEventWatch = null!;

    [Import(ModuleName, "SDL_FilterEvents")]
    public static readonly delegate* unmanaged<delegate*<void*, Event*, int>, void*, void> FilterEvents = null!;

    [Import(ModuleName, "SDL_EventState")]
    public static readonly delegate* unmanaged<uint, EventState, byte> GetEventState = null!;

    [Import(ModuleName, "SDL_RegisterEvents")]
    public static readonly delegate* unmanaged<int, uint> RegisterEvents = null!;
}