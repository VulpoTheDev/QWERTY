using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_metal.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    [Import(ModuleName, "SDL_Metal_CreateView")]
    public static readonly delegate* unmanaged<void*, void*> CreateView = null!;

    [Import(ModuleName, "SDL_Metal_DestroyView")]
    public static readonly delegate* unmanaged<void*, void> DestroyView = null!;

    [Import(ModuleName, "SDL_Metal_GetLayer")]
    public static readonly delegate* unmanaged<void*, void*> GetLayer = null!;

    [Import(ModuleName, "SDL_Metal_GetDrawableSize")]
    public static readonly delegate* unmanaged<void*, int*, int*, void> GetDrawableSize = null!;
}