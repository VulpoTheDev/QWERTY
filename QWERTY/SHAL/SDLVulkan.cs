using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_vulkan.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    [Import(ModuleName, "SDL_Vulkan_LoadLibrary")]
    public static readonly delegate* unmanaged<void*, int> LoadVkLibrary = null!;

    [Import(ModuleName, "SDL_Vulkan_GetVkGetInstanceProcAddr")]
    public static readonly delegate* unmanaged<void*> GetVkInstanceProcAddr = null!;

    [Import(ModuleName, "SDL_Vulkan_UnloadLibrary")]
    public static readonly delegate* unmanaged<void> UnloadVkLibrary = null!;

    [Import(ModuleName, "SDL_Vulkan_GetInstanceExtensions")]
    public static readonly delegate* unmanaged<void*, uint*, void**, bool> GetVkInstanceExtensions = null!;

    [Import(ModuleName, "SDL_Vulkan_CreateSurface")]
    public static readonly delegate* unmanaged<void*, void*, void**, bool> CreateVkSurface = null!;

    [Import(ModuleName, "SDL_Vulkan_GetDrawableSize")]
    public static readonly delegate* unmanaged<void*, int*, int*, void> GetDrawableVkSize = null!;
}