using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_joystick.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum JoyHat : byte {
        Centered = 0x00,
        Up = 0x01,
        Right = 0x02,
        Down = 0x04,
        Left = 0x08,
        RightUp = Right | Up,
        RightDown = Right | Down,
        LeftUp = Left | Up,
        LeftDown = Left | Down
    }

    public enum JoyPowerLevel {
        Unknown = -1,
        Empty,
        Low,
        Medium,
        Full,
        Wired
    }

    public enum JoyType {
        Unknown,
        GameController,
        Wheel,
        ArcadeStick,
        FlightStick,
        DancePad,
        Guitar,
        DrumKit,
        ArcadePad,
        Throttle
    }

    [Import(ModuleName, "SDL_LockJoysticks")]
    public static readonly delegate* unmanaged<void> LockJoysticks = null!;

    [Import(ModuleName, "SDL_UnlockJoysticks")]
    public static readonly delegate* unmanaged<void> UnlockJoysticks = null!;

    [Import(ModuleName, "SDL_NumJoysticks")]
    public static readonly delegate* unmanaged<int> NumJoysticks = null!;

    [Import(ModuleName, "SDL_JoystickNameForIndex")]
    public static readonly delegate* unmanaged<int, void*> JoystickNameForIndex = null!;

    [Import(ModuleName, "SDL_JoystickGetDevicePlayerIndex")]
    public static readonly delegate* unmanaged<int, int> JoystickGetDevicePlayerIndex = null!;

    [Import(ModuleName, "SDL_JoystickGetDeviceGUID")]
    public static readonly delegate* unmanaged<int, JoyGUID> JoystickGetDeviceGUID = null!;

    [Import(ModuleName, "SDL_JoystickGetDeviceVendor")]
    public static readonly delegate* unmanaged<int, ushort> JoystickGetDeviceVendor = null!;

    [Import(ModuleName, "SDL_JoystickGetDeviceProduct")]
    public static readonly delegate* unmanaged<int, ushort> JoystickGetDeviceProduct = null!;

    [Import(ModuleName, "SDL_JoystickGetDeviceProductVersion")]
    public static readonly delegate* unmanaged<int, ushort> JoystickGetDeviceProductVersion = null!;

    [Import(ModuleName, "SDL_JoystickGetDeviceType")]
    public static readonly delegate* unmanaged<int, JoyType> JoystickGetDeviceType = null!;

    [Import(ModuleName, "SDL_JoystickGetDeviceInstanceID")]
    public static readonly delegate* unmanaged<int, int> JoystickGetDeviceInstanceID = null!;

    [Import(ModuleName, "SDL_JoystickOpen")]
    public static readonly delegate* unmanaged<int, void*> JoystickOpen = null!;

    [Import(ModuleName, "SDL_JoystickFromInstanceID")]
    public static readonly delegate* unmanaged<int, void*> JoystickFromInstanceID = null!;

    [Import(ModuleName, "SDL_JoystickFromPlayerIndex")]
    public static readonly delegate* unmanaged<int, void*> JoystickFromPlayerIndex = null!;

    [Import(ModuleName, "SDL_JoystickAttachVirtual")]
    public static readonly delegate* unmanaged<JoyType, int, int, int, int> JoystickAttachVirtual = null!;

    [Import(ModuleName, "SDL_JoystickDetachVirtual")]
    public static readonly delegate* unmanaged<int, int> JoystickDetachVirtual = null!;

    [Import(ModuleName, "SDL_JoystickIsVirtual")]
    public static readonly delegate* unmanaged<int, bool> JoystickIsVirtual = null!;

    [Import(ModuleName, "SDL_JoystickSetVirtualAxis")]
    public static readonly delegate* unmanaged<void*, int, short, int> JoystickSetVirtualAxis = null!;

    [Import(ModuleName, "SDL_JoystickSetVirtualButton")]
    public static readonly delegate* unmanaged<void*, int, byte, int> JoystickSetVirtualButton = null!;

    [Import(ModuleName, "SDL_JoystickSetVirtualHat")]
    public static readonly delegate* unmanaged<void*, int, byte, int> JoystickSetVirtualHat = null!;

    [Import(ModuleName, "SDL_JoystickName")]
    public static readonly delegate* unmanaged<void*, void*> JoystickName = null!;

    [Import(ModuleName, "SDL_JoystickGetPlayerIndex")]
    public static readonly delegate* unmanaged<void*, int> JoystickGetPlayerIndex = null!;

    [Import(ModuleName, "SDL_JoystickSetPlayerIndex")]
    public static readonly delegate* unmanaged<void*, int, void> JoystickSetPlayerIndex = null!;

    [Import(ModuleName, "SDL_JoystickGetGUID")]
    public static readonly delegate* unmanaged<void*, JoyGUID> JoystickGetGUID = null!;

    [Import(ModuleName, "SDL_JoystickGetVendor")]
    public static readonly delegate* unmanaged<void*, ushort> JoystickGetVendor = null!;

    [Import(ModuleName, "SDL_JoystickGetProduct")]
    public static readonly delegate* unmanaged<void*, ushort> JoystickGetProduct = null!;

    [Import(ModuleName, "SDL_JoystickGetProductVersion")]
    public static readonly delegate* unmanaged<void*, ushort> JoystickGetProductVersion = null!;

    [Import(ModuleName, "SDL_JoystickGetSerial")]
    public static readonly delegate* unmanaged<void*, void*> JoystickGetSerial = null!;

    [Import(ModuleName, "SDL_JoystickGetType")]
    public static readonly delegate* unmanaged<void*, JoyType> JoystickGetType = null!;

    [Import(ModuleName, "SDL_JoystickGetGUIDString")]
    public static readonly delegate* unmanaged<JoyGUID, void*, int, void> JoystickGetGUIDString = null!;

    [Import(ModuleName, "SDL_JoystickGetGUIDFromString")]
    public static readonly delegate* unmanaged<void*, JoyGUID> JoystickGetGUIDFromString = null!;

    [Import(ModuleName, "SDL_JoystickGetAttached")]
    public static readonly delegate* unmanaged<void*, bool> JoystickGetAttached = null!;

    [Import(ModuleName, "SDL_JoystickInstanceID")]
    public static readonly delegate* unmanaged<void*, int> JoystickInstanceID = null!;

    [Import(ModuleName, "SDL_JoystickNumAxes")]
    public static readonly delegate* unmanaged<void*, int> JoystickNumAxes = null!;

    [Import(ModuleName, "SDL_JoystickNumBalls")]
    public static readonly delegate* unmanaged<void*, int> JoystickNumBalls = null!;

    [Import(ModuleName, "SDL_JoystickNumHats")]
    public static readonly delegate* unmanaged<void*, int> JoystickNumHats = null!;

    [Import(ModuleName, "SDL_JoystickNumButtons")]
    public static readonly delegate* unmanaged<void*, int> JoystickNumButtons = null!;

    [Import(ModuleName, "SDL_JoystickUpdate")]
    public static readonly delegate* unmanaged<void*, int> JoystickUpdate = null!;

    [Import(ModuleName, "SDL_JoystickEventState")]
    public static readonly delegate* unmanaged<int, int> JoystickEventState = null!;

    [Import(ModuleName, "SDL_JoystickGetAxis")]
    public static readonly delegate* unmanaged<void*, int, short> JoystickGetAxis = null!;

    [Import(ModuleName, "SDL_JoystickGetAxisInitialState")]
    public static readonly delegate* unmanaged<void*, int, short*, bool> JoystickGetAxisInitialState = null!;

    [Import(ModuleName, "SDL_JoystickGetHat")]
    public static readonly delegate* unmanaged<void*, int, byte> JoystickGetHat = null!;

    [Import(ModuleName, "SDL_JoystickGetBall")]
    public static readonly delegate* unmanaged<void*, int, int*, int*, int> JoystickGetBall = null!;

    [Import(ModuleName, "SDL_JoystickGetButton")]
    public static readonly delegate* unmanaged<void*, int, byte> JoystickGetButton = null!;

    [Import(ModuleName, "SDL_JoystickRumble")]
    public static readonly delegate* unmanaged<void*, ushort, ushort, uint, int> JoystickRumble = null!;

    [Import(ModuleName, "SDL_JoystickRumbleTriggers")]
    public static readonly delegate* unmanaged<void*, ushort, ushort, uint, int> JoystickRumbleTriggers = null!;

    [Import(ModuleName, "SDL_JoystickHasLED")]
    public static readonly delegate* unmanaged<void*, bool> JoystickHasLED = null!;

    [Import(ModuleName, "SDL_JoystickSetLED")]
    public static readonly delegate* unmanaged<void*, byte, byte, byte, int> JoystickSetLED = null!;

    [Import(ModuleName, "SDL_JoystickSendEffect")]
    public static readonly delegate* unmanaged<void*, void*, int, int> JoystickSendEffect = null!;

    [Import(ModuleName, "SDL_JoystickClose")]
    public static readonly delegate* unmanaged<void*, void> JoystickClose = null!;

    [Import(ModuleName, "SDL_JoystickCurrentPowerLevel")]
    public static readonly delegate* unmanaged<void*, JoyPowerLevel> JoystickCurrentPowerLevel = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct JoyGUID {
        public fixed byte Data[16];
    }
}