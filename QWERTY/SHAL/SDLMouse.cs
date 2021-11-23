using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_mouse.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum SystemCursor {
        Arrow,
        IBeam,
        Wait,
        CrossHair,
        WaitArrow,
        SizeNwse,
        SizeNesw,
        SizeWe,
        SizeNs,
        SizeAll,
        No,
        Hand
    }

    public enum MouseWheelDirection {
        Normal,
        Flipped
    }

    [Import(ModuleName, "SDL_GetMouseFocus")]
    public static readonly delegate* unmanaged<void*> GetMouseFocus = null!;

    [Import(ModuleName, "SDL_GetMouseState")]
    public static readonly delegate* unmanaged<int*, int*, uint> GetMouseState = null!;

    [Import(ModuleName, "SDL_GetGlobalMouseState")]
    public static readonly delegate* unmanaged<int*, int*, uint> GetGlobalMouseState = null!;

    [Import(ModuleName, "SDL_GetRelativeMouseState")]
    public static readonly delegate* unmanaged<int*, int*, uint> GetRelativeMouseState = null!;

    [Import(ModuleName, "SDL_WarpMouseInWindow")]
    public static readonly delegate* unmanaged<void*, int, int, void> WarpMouseInWindow = null!;

    [Import(ModuleName, "SDL_WarpMouseGlobal")]
    public static readonly delegate* unmanaged<int, int, int> WarpMouseGlobal = null!;

    [Import(ModuleName, "SDL_SetRelativeMouseMode")]
    public static readonly delegate* unmanaged<bool, int> SetRelativeMouseMode = null!;

    [Import(ModuleName, "SDL_CaptureMouse")]
    public static readonly delegate* unmanaged<bool, int> CaptureMouse = null!;

    [Import(ModuleName, "SDL_GetRelativeMouseMode")]
    public static readonly delegate* unmanaged<bool> GetRelativeMouseMode = null!;

    [Import(ModuleName, "SDL_CreateCursor")]
    public static readonly delegate* unmanaged<byte*, byte*, int, int, int, int, void*> CreateCursor = null!;

    [Import(ModuleName, "SDL_CreateColorCursor")]
    public static readonly delegate* unmanaged<void*, int, int, void*> CreateColorCursor = null!;

    [Import(ModuleName, "SDL_CreateSystemCursor")]
    public static readonly delegate* unmanaged<SystemCursor, void*> CreateSystemCursor = null!;

    [Import(ModuleName, "SDL_SetCursor")]
    public static readonly delegate* unmanaged<void*, void> SetCursor = null!;

    [Import(ModuleName, "SDL_GetCursor")]
    public static readonly delegate* unmanaged<void*> GetCursor = null!;

    [Import(ModuleName, "SDL_GetDefaultCursor")]
    public static readonly delegate* unmanaged<void*> GetDefaultCursor = null!;

    [Import(ModuleName, "SDL_FreeCursor")]
    public static readonly delegate* unmanaged<void*, void> FreeCursor = null!;

    [Import(ModuleName, "SDL_ShowCursor")]
    public static readonly delegate* unmanaged<int, int> ShowCursor = null!;
}