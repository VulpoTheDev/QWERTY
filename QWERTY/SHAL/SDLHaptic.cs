using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_haptic.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum HapticDirEncoding : byte {
        Polar,
        Cartesian,
        Spherical,
        SteeringAxis
    }

    public enum HapticType : ushort {
        Constant = 1 << 0,
        Sine = 1 << 1,
        LeftRight = 1 << 2,
        Triangle = 1 << 3,
        SawToothUp = 1 << 4,
        SawToothDown = 1 << 5,
        Ramp = 1 << 6,
        Spring = 1 << 7,
        Damper = 1 << 8,
        Inertia = 1 << 9,
        Friction = 1 << 10,
        Custom = 1 << 11,
        Gain = 1 << 12,
        AutoCenter = 1 << 13,
        Status = 1 << 14,
        Pause = 1 << 15
    }

    public const uint HapticInfinity = 4294967295U;

    [Import(ModuleName, "SDL_NumHaptics")]
    public static readonly delegate* unmanaged<int> NumHaptics = null!;

    [Import(ModuleName, "SDL_HapticName")]
    public static readonly delegate* unmanaged<int, void*> HapticName = null!;

    [Import(ModuleName, "SDL_HapticOpen")]
    public static readonly delegate* unmanaged<int, void*> HapticOpen = null!;

    [Import(ModuleName, "SDL_HapticOpened")]
    public static readonly delegate* unmanaged<int, int> HapticOpened = null!;

    [Import(ModuleName, "SDL_HapticIndex")]
    public static readonly delegate* unmanaged<void*, int> HapticIndex = null!;

    [Import(ModuleName, "SDL_MouseIsHaptic")]
    public static readonly delegate* unmanaged<int> MouseIsHaptic = null!;

    [Import(ModuleName, "SDL_HapticOpenFromMouse")]
    public static readonly delegate* unmanaged<void*> HapticOpenFromMouse = null!;

    [Import(ModuleName, "SDL_JoystickIsHaptic")]
    public static readonly delegate* unmanaged<void*, int> JoystickIsHaptic = null!;

    [Import(ModuleName, "SDL_HapticOpenFromJoystick")]
    public static readonly delegate* unmanaged<void*, void*> HapticOpenFromJoystick = null!;

    [Import(ModuleName, "SDL_HapticClose")]
    public static readonly delegate* unmanaged<void*, void> HapticClose = null!;

    [Import(ModuleName, "SDL_HapticNumEffects")]
    public static readonly delegate* unmanaged<void*, int> HapticNumEffects = null!;

    [Import(ModuleName, "SDL_HapticNumEffectsPlaying")]
    public static readonly delegate* unmanaged<void*, int> HapticNumEffectsPlaying = null!;

    [Import(ModuleName, "SDL_HapticQuery")]
    public static readonly delegate* unmanaged<void*, uint> HapticQuery = null!;

    [Import(ModuleName, "SDL_HapticNumAxes")]
    public static readonly delegate* unmanaged<void*, int> HapticNumAxes = null!;

    [Import(ModuleName, "SDL_HapticEffectSupported")]
    public static readonly delegate* unmanaged<void*, HapticEffect*, int> HapticEffectSupported = null!;

    [Import(ModuleName, "SDL_HapticNewEffect")]
    public static readonly delegate* unmanaged<void*, HapticEffect*, int> HapticNewEffect = null!;

    [Import(ModuleName, "SDL_HapticUpdateEffect")]
    public static readonly delegate* unmanaged<void*, int, HapticEffect*, int> HapticUpdateEffect = null!;

    [Import(ModuleName, "SDL_HapticRunEffect")]
    public static readonly delegate* unmanaged<void*, int, uint, int> HapticRunEffect = null!;

    [Import(ModuleName, "SDL_HapticStopEffect")]
    public static readonly delegate* unmanaged<void*, int, int> HapticStopEffect = null!;

    [Import(ModuleName, "SDL_HapticDestroyEffect")]
    public static readonly delegate* unmanaged<void*, int, void> HapticDestroyEffect = null!;

    [Import(ModuleName, "SDL_HapticGetEffectStatus")]
    public static readonly delegate* unmanaged<void*, int, int> HapticGetEffectStatus = null!;

    [Import(ModuleName, "SDL_HapticSetGain")]
    public static readonly delegate* unmanaged<void*, int, int> HapticSetGain = null!;

    [Import(ModuleName, "SDL_HapticSetAutocenter")]
    public static readonly delegate* unmanaged<void*, int, int> HapticSetAutoCenter = null!;

    [Import(ModuleName, "SDL_HapticPause")]
    public static readonly delegate* unmanaged<void*, int> HapticPause = null!;

    [Import(ModuleName, "SDL_HapticUnpause")]
    public static readonly delegate* unmanaged<void*, int> HapticUnpause = null!;

    [Import(ModuleName, "SDL_HapticStopAll")]
    public static readonly delegate* unmanaged<void*, int> HapticStopAll = null!;

    [Import(ModuleName, "SDL_HapticRumbleSupported")]
    public static readonly delegate* unmanaged<void*, int> HapticRumbleSupported = null!;

    [Import(ModuleName, "SDL_HapticRumbleInit")]
    public static readonly delegate* unmanaged<void*, int> HapticRumbleInit = null!;

    [Import(ModuleName, "SDL_HapticRumblePlay")]
    public static readonly delegate* unmanaged<void*, float, uint, int> HapticRumblePlay = null!;

    [Import(ModuleName, "SDL_HapticRumbleStop")]
    public static readonly delegate* unmanaged<void*, int> HapticRumbleStop = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct HapticDirection {
        public HapticDirEncoding Type;
        public fixed int Dir[3];
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HapticConstant {
        public HapticType Type;
        public HapticDirection Direction;
        public uint Length;
        public ushort Delay;
        public ushort Button;
        public ushort Interval;
        public short Level;
        public ushort AttLength;
        public ushort AttLevel;
        public ushort FadeLength;
        public ushort FadeLevel;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HapticPeriodic {
        public HapticType Type;
        public HapticDirection Direction;
        public uint Length;
        public ushort Delay;
        public ushort Button;
        public ushort Interval;
        public ushort Period;
        public short Mag;
        public short Offset;
        public ushort Phase;
        public ushort AttLength;
        public ushort AttLevel;
        public ushort FadeLength;
        public ushort FadeLevel;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HapticCondition {
        public HapticType Type;
        public HapticDirection Direction;
        public uint Length;
        public ushort Delay;
        public ushort Button;
        public ushort Interval;
        public fixed ushort RightSat[3];
        public fixed ushort LeftSat[3];
        public fixed short RightCoeff[3];
        public fixed short LeftCoeff[3];
        public fixed ushort DeadBand[3];
        public fixed short Center[3];
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HapticRamp {
        public HapticType Type;
        public HapticDirection Direction;
        public uint Length;
        public ushort Delay;
        public ushort Button;
        public ushort Interval;
        public short Start;
        public short End;
        public ushort AttLength;
        public ushort AttLevel;
        public ushort FadeLength;
        public ushort FadeLevel;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HapticLeftRight {
        public HapticType Type;
        public uint Length;
        public ushort LargeMag;
        public ushort SmallMag;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct HapticCustom {
        public HapticType Type;
        public HapticDirection Direction;
        public uint Length;
        public ushort Delay;
        public ushort Button;
        public ushort Interval;
        public byte Channels;
        public ushort Period;
        public ushort Samples;
        public ushort* Data;
        public ushort AttLength;
        public ushort AttLevel;
        public ushort FadeLength;
        public ushort FadeLevel;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HapticEffect {
        [FieldOffset(0)]
        public HapticType Type;

        [FieldOffset(0)]
        public HapticConstant Constant;

        [FieldOffset(0)]
        public HapticPeriodic Periodic;

        [FieldOffset(0)]
        public HapticCondition Condition;

        [FieldOffset(0)]
        public HapticRamp Ramp;

        [FieldOffset(0)]
        public HapticLeftRight LeftRight;

        [FieldOffset(0)]
        public HapticCustom Custom;
    }
}