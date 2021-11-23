using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_gesture.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    [Import(ModuleName, "SDL_RecordGesture")]
    public static readonly delegate* unmanaged<long, int> RecordGesture = null!;

    [Import(ModuleName, "SDL_SaveAllDollarTemplates")]
    public static readonly delegate* unmanaged<RwOps*, int> SaveAllDollarTemplates = null!;

    [Import(ModuleName, "SDL_SaveDollarTemplate")]
    public static readonly delegate* unmanaged<long, RwOps*, int> SaveDollarTemplate = null!;

    [Import(ModuleName, "SDL_LoadDollarTemplates")]
    public static readonly delegate* unmanaged<long, RwOps*, int> LoadDollarTemplates = null!;
}