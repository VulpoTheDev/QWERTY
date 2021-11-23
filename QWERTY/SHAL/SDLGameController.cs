using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_gamecontroller.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum ControllerAxis {
        Invalid = -1,
        LeftX,
        LeftY,
        RightX,
        RightY,
        TriggerLeft,
        TriggerRight
    }

    public enum ControllerBindType {
        None,
        Button,
        Axis,
        Hat
    }

    public enum ControllerButton {
        Invalid = -1,
        A,
        B,
        X,
        Y,
        Back,
        Guide,
        Start,
        LeftStick,
        RightStick,
        LeftShoulder,
        RightShoulder,
        DPadUp,
        DPadDown,
        DPadLeft,
        DPadRight,
        Misc,
        Paddle1,
        Paddle2,
        Paddle3,
        Paddle4,
        Touchpad
    }

    public enum ControllerType {
        Unknown,
        Xbox360,
        XboxOne,
        Ps3,
        Ps4,
        SwitchPro,
        Virtual,
        Ps5,
        Luna,
        Stadia
    }

    [Import(ModuleName, "SDL_GameControllerAddMappingsFromRW")]
    public static readonly delegate* unmanaged<RwOps*, int, int> GameControllerAddMappingsFromRW = null!;

    [Import(ModuleName, "SDL_GameControllerAddMapping")]
    public static readonly delegate* unmanaged<void*, int> GameControllerAddMapping = null!;

    [Import(ModuleName, "SDL_GameControllerNumMappings")]
    public static readonly delegate* unmanaged<int> GameControllerNumMappings = null!;

    [Import(ModuleName, "SDL_GameControllerMappingForIndex")]
    public static readonly delegate* unmanaged<int, void*> GameControllerMappingForIndex = null!;

    [Import(ModuleName, "SDL_GameControllerMappingForGUID")]
    public static readonly delegate* unmanaged<JoyGUID, void*> GameControllerMappingForGUID = null!;

    [Import(ModuleName, "SDL_GameControllerMapping")]
    public static readonly delegate* unmanaged<void*, void*> GameControllerMapping = null!;

    [Import(ModuleName, "SDL_IsGameController")]
    public static readonly delegate* unmanaged<int, bool> IsGameController = null!;

    [Import(ModuleName, "SDL_GameControllerNameForIndex")]
    public static readonly delegate* unmanaged<int, void*> GameControllerNameForIndex = null!;

    [Import(ModuleName, "SDL_GameControllerTypeForIndex")]
    public static readonly delegate* unmanaged<int, ControllerType> GameControllerTypeForIndex = null!;

    [Import(ModuleName, "SDL_GameControllerMappingForDeviceIndex")]
    public static readonly delegate* unmanaged<int, void*> GameControllerMappingForDeviceIndex = null!;

    [Import(ModuleName, "SDL_GameControllerOpen")]
    public static readonly delegate* unmanaged<int, void*> GameControllerOpen = null!;

    [Import(ModuleName, "SDL_GameControllerFromInstanceID")]
    public static readonly delegate* unmanaged<int, void*> GameControllerFromInstanceID = null!;

    [Import(ModuleName, "SDL_GameControllerFromPlayerIndex")]
    public static readonly delegate* unmanaged<int, void*> GameControllerFromPlayerIndex = null!;

    [Import(ModuleName, "SDL_GameControllerName")]
    public static readonly delegate* unmanaged<void*, void*> GameControllerName = null!;

    [Import(ModuleName, "SDL_GameControllerGetType")]
    public static readonly delegate* unmanaged<void*, ControllerType> GameControllerGetType = null!;

    [Import(ModuleName, "SDL_GameControllerGetPlayerIndex")]
    public static readonly delegate* unmanaged<void*, int> GameControllerGetPlayerIndex = null!;

    [Import(ModuleName, "SDL_GameControllerSetPlayerIndex")]
    public static readonly delegate* unmanaged<void*, int, void> GameControllerSetPlayerIndex = null!;

    [Import(ModuleName, "SDL_GameControllerGetVendor")]
    public static readonly delegate* unmanaged<void*, ushort> GameControllerGetVendor = null!;

    [Import(ModuleName, "SDL_GameControllerGetProduct")]
    public static readonly delegate* unmanaged<void*, ushort> GameControllerGetProduct = null!;

    [Import(ModuleName, "SDL_GameControllerGetProductVersion")]
    public static readonly delegate* unmanaged<void*, ushort> GameControllerGetProductVersion = null!;

    [Import(ModuleName, "SDL_GameControllerGetSerial")]
    public static readonly delegate* unmanaged<void*, void*> GameControllerGetSerial = null!;

    [Import(ModuleName, "SDL_GameControllerGetAttached")]
    public static readonly delegate* unmanaged<void*, bool> GameControllerGetAttached = null!;

    [Import(ModuleName, "SDL_GameControllerGetJoystick")]
    public static readonly delegate* unmanaged<void*, void*> GameControllerGetJoystick = null!;

    [Import(ModuleName, "SDL_GameControllerEventState")]
    public static readonly delegate* unmanaged<int, int> GameControllerEventState = null!;

    [Import(ModuleName, "SDL_GameControllerUpdate")]
    public static readonly delegate* unmanaged<void> GameControllerUpdate = null!;

    [Import(ModuleName, "SDL_GameControllerGetAxisFromString")]
    public static readonly delegate* unmanaged<void*, ControllerAxis> GameControllerGetAxisFromString = null!;

    [Import(ModuleName, "SDL_GameControllerGetStringForAxis")]
    public static readonly delegate* unmanaged<ControllerAxis, void*> GameControllerGetStringForAxis = null!;

    [Import(ModuleName, "SDL_GameControllerGetBindForAxis")]
    public static readonly delegate* unmanaged<void*, ControllerAxis, ControllerButtonBind> GameControllerGetBindForAxis = null!;

    [Import(ModuleName, "SDL_GameControllerHasAxis")]
    public static readonly delegate* unmanaged<void*, ControllerAxis, bool> GameControllerHasAxis = null!;

    [Import(ModuleName, "SDL_GameControllerGetAxis")]
    public static readonly delegate* unmanaged<void*, ControllerAxis, short> GameControllerGetAxis = null!;

    [Import(ModuleName, "SDL_GameControllerGetButtonFromString")]
    public static readonly delegate* unmanaged<void*, ControllerButton> GameControllerGetButtonFromString = null!;

    [Import(ModuleName, "SDL_GameControllerGetStringForButton")]
    public static readonly delegate* unmanaged<ControllerButton, void*> GameControllerGetStringForButton = null!;

    [Import(ModuleName, "SDL_GameControllerGetBindForButton")]
    public static readonly delegate* unmanaged<void*, ControllerButton, ControllerButtonBind> GameControllerGetBindForButton = null!;

    [Import(ModuleName, "SDL_GameControllerHasButton")]
    public static readonly delegate* unmanaged<void*, ControllerButton, bool> GameControllerHasButton = null!;

    [Import(ModuleName, "SDL_GameControllerGetButton")]
    public static readonly delegate* unmanaged<void*, ControllerButton, byte> GameControllerGetButton = null!;

    [Import(ModuleName, "SDL_GameControllerGetNumTouchpads")]
    public static readonly delegate* unmanaged<void*, int> GameControllerGetNumTouchpads = null!;

    [Import(ModuleName, "SDL_GameControllerGetNumTouchpadFingers")]
    public static readonly delegate* unmanaged<void*, int, int> GameControllerGetNumTouchpadFingers = null!;

    [Import(ModuleName, "SDL_GameControllerGetTouchpadFinger")]
    public static readonly delegate* unmanaged<void*, int, int, byte*, float*, float*, float*, int> GameControllerGetTouchpadFinger = null!;

    [Import(ModuleName, "SDL_GameControllerHasSensor")]
    public static readonly delegate* unmanaged<void*, SensorType, bool> GameControllerHasSensor = null!;

    [Import(ModuleName, "SDL_GameControllerSetSensorEnabled")]
    public static readonly delegate* unmanaged<void*, SensorType, bool, int> GameControllerSetSensorEnabled = null!;

    [Import(ModuleName, "SDL_GameControllerIsSensorEnabled")]
    public static readonly delegate* unmanaged<void*, SensorType, bool> GameControllerIsSensorEnabled = null!;

    [Import(ModuleName, "SDL_GameControllerGetSensorDataRate")]
    public static readonly delegate* unmanaged<void*, SensorType, float> GameControllerGetSensorDataRate = null!;

    [Import(ModuleName, "SDL_GameControllerGetSensorData")]
    public static readonly delegate* unmanaged<void*, SensorType, float*, int, int> GameControllerGetSensorData = null!;

    [Import(ModuleName, "SDL_GameControllerRumble")]
    public static readonly delegate* unmanaged<void*, ushort, ushort, uint, int> GameControllerRumble = null!;

    [Import(ModuleName, "SDL_GameControllerRumbleTriggers")]
    public static readonly delegate* unmanaged<void*, ushort, ushort, uint, int> GameControllerRumbleTriggers = null!;

    [Import(ModuleName, "SDL_GameControllerHasLED")]
    public static readonly delegate* unmanaged<void*, bool> GameControllerHasLED = null!;

    [Import(ModuleName, "SDL_GameControllerSetLED")]
    public static readonly delegate* unmanaged<void*, byte, byte, byte, int> GameControllerSetLED = null!;

    [Import(ModuleName, "SDL_GameControllerSendEffect")]
    public static readonly delegate* unmanaged<void*, void*, int, int> GameControllerSendEffect = null!;

    [Import(ModuleName, "SDL_GameControllerClose")]
    public static readonly delegate* unmanaged<void*, void> GameControllerClose = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct ControllerButtonBind {
        public ControllerBindType Type;
        public int Value1;
        public int Value2;
    }
}