using System;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    [Flags]
    public enum InitFlag : uint {
        Timer = 0x0000_0001U,
        Audio = 0x0000_0010U,
        Video = 0x0000_0020U,
        Joystick = 0x0000_0200U,
        Haptic = 0x0000_1000U,
        GameController = 0x0000_2000U,
        Events = 0x0000_4000U,
        Sensor = 0x0000_8000U,
        NoParachute = 0x0010_0000U,

        Everything = Timer | Audio | Video | Joystick | Haptic | GameController | Events | Sensor
    }

    internal const string ModuleName = "sdl2";

    internal static LibraryLoader _Loader = new(ModuleName, () => {
        if (SystemInfo.IsWindows) return new[] {"SDL2.dll"};
        return SystemInfo.IsOSX ? new[] {"libSDL2.dylib", "libSDL2-2.0.0.dylib"} : new[] {"libSDL2-2.0.so.0", "libSDL2-2.0.so"};
    });

    [Import(ModuleName, "SDL_Init")]
    public static readonly delegate* unmanaged<InitFlag, int> Init = null!;

    [Import(ModuleName, "SDL_InitSubSystem")]
    public static readonly delegate* unmanaged<InitFlag, int> InitSubSystem = null!;

    [Import(ModuleName, "SDL_QuitSubSystem")]
    public static readonly delegate* unmanaged<InitFlag, void> QuitSubSystem = null!;

    [Import(ModuleName, "SDL_WasInit")]
    public static readonly delegate* unmanaged<InitFlag, uint> WasInit = null!;

    [Import(ModuleName, "SDL_Quit")]
    public static readonly delegate* unmanaged<void> Quit = null!;

    static SDL() {
        _Loader.LoadFunctionsFor(typeof(SDL));
    }
}