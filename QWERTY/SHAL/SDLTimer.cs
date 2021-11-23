using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_timer.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    [Import(ModuleName, "SDL_GetTicks")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<uint> GetTicks = null!;

    [Import(ModuleName, "SDL_GetPerformanceCounter")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<ulong> GetPerformanceCounter = null!;

    [Import(ModuleName, "SDL_GetPerformanceFrequency")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<ulong> GetPerformanceFrequency = null!;

    [Import(ModuleName, "SDL_Delay")]
    public static readonly delegate* unmanaged<uint, void> Delay = null!;

    [Import(ModuleName, "SDL_AddTimer")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<uint, delegate* unmanaged<uint, void*, uint>, void*, int> AddTimer = null!;

    [Import(ModuleName, "SDL_RemoveTimer")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<int, bool> RemoveTimer = null!;
}