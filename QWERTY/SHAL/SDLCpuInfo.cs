using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_cpuinfo.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    [Import(ModuleName, "SDL_GetCPUCount")]
    public static readonly delegate* unmanaged<int> GetCpuCount = null!;

    [Import(ModuleName, "SDL_GetCPUCacheLineSize")]
    public static readonly delegate* unmanaged<int> GetCpuCacheLineSize = null!;

    [Import(ModuleName, "SDL_HasRDTSC")]
    public static readonly delegate* unmanaged<bool> HasRdtsc = null!;

    [Import(ModuleName, "SDL_HasAltiVec")]
    public static readonly delegate* unmanaged<bool> HasAltiVec = null!;

    [Import(ModuleName, "SDL_HasMMX")]
    public static readonly delegate* unmanaged<bool> HasMmx = null!;

    [Import(ModuleName, "SDL_Has3DNow")]
    public static readonly delegate* unmanaged<bool> Has3dNow = null!;

    [Import(ModuleName, "SDL_HasSSE")]
    public static readonly delegate* unmanaged<bool> HasSse = null!;

    [Import(ModuleName, "SDL_HasSSE2")]
    public static readonly delegate* unmanaged<bool> HasSse2 = null!;

    [Import(ModuleName, "SDL_HasSSE3")]
    public static readonly delegate* unmanaged<bool> HasSse3 = null!;

    [Import(ModuleName, "SDL_HasSSE41")]
    public static readonly delegate* unmanaged<bool> HasSse41 = null!;

    [Import(ModuleName, "SDL_HasSSE42")]
    public static readonly delegate* unmanaged<bool> HasSse42 = null!;

    [Import(ModuleName, "SDL_HasAVX")]
    public static readonly delegate* unmanaged<bool> HasAvx = null!;

    [Import(ModuleName, "SDL_HasAVX2")]
    public static readonly delegate* unmanaged<bool> HasAvx2 = null!;

    [Import(ModuleName, "SDL_HasAVX512F")]
    public static readonly delegate* unmanaged<bool> HasAvx512F = null!;

    [Import(ModuleName, "SDL_HasARMSIMD")]
    public static readonly delegate* unmanaged<bool> HasArmSimd = null!;

    [Import(ModuleName, "SDL_HasNEON")]
    public static readonly delegate* unmanaged<bool> HasNeon = null!;

    [Import(ModuleName, "SDL_GetSystemRAM")]
    public static readonly delegate* unmanaged<int> GetSystemRam = null!;

    [Import(ModuleName, "SDL_SIMDGetAlignment")]
    public static readonly delegate* unmanaged<nuint> SimdGetAlignment = null!;

    [Import(ModuleName, "SDL_SIMDAlloc")]
    public static readonly delegate* unmanaged<ulong, void*> SimdAlloc = null!;

    [Import(ModuleName, "SDL_SIMDRealloc")]
    public static readonly delegate* unmanaged<void*, ulong, void*> SimdReAlloc = null!;

    [Import(ModuleName, "SDL_SIMDFree")]
    public static readonly delegate* unmanaged<void*, void> SimdFree = null!;
}