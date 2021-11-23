using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_touch.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum TouchType {
        INVALID = -0x0000_0001,
        DIRECT,
        INDIRECT_ABSOLUTE,
        INDIRECT_RELATIVE
    }

    [Import(ModuleName, "SDL_GetNumTouchDevices")]
    public static readonly delegate* unmanaged<int> GetNumTouchDevices = null!;

    [Import(ModuleName, "SDL_GetTouchDevice")]
    public static readonly delegate* unmanaged<int, long> GetTouchDevice = null!;

    [Import(ModuleName, "SDL_GetTouchDeviceType")]
    public static readonly delegate* unmanaged<long, TouchType> GetTouchDeviceType = null!;

    [Import(ModuleName, "SDL_GetNumTouchFingers")]
    public static readonly delegate* unmanaged<long, int> GetNumTouchFingers = null!;

    [Import(ModuleName, "SDL_GetTouchFinger")]
    public static readonly delegate* unmanaged<long, int, TouchFinger*> GetTouchFinger = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct TouchFinger {
        public long Id;
        public float X;
        public float Y;
        public float Pressure;
    }
}