using System;
using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_surface.h.<br></br>
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
    public enum SurfaceFlag {
        PreAlloc = 0x0000_0001,
        RleAccel = 0x0000_0002,
        DontFree = 0x0000_0004,
        SimdAligned = 0x0000_0008
    }

    public enum YuvConversionMode {
        Jpeg,
        Bt601,
        Bt709,
        Automatic
    }

    [Import(ModuleName, "SDL_CreateRGBSurface")]
    public static readonly delegate* unmanaged<SurfaceFlag, int, int, int, uint, uint, uint, uint, Surface*> CreateRgbSurface = null!;

    [Import(ModuleName, "SDL_CreateRGBSurfaceWithFormat")]
    public static readonly delegate* unmanaged<SurfaceFlag, int, int, int, uint, Surface*> CreateRgbSurfaceWithFormat = null!;

    [Import(ModuleName, "SDL_CreateRGBSurfaceFrom")]
    public static readonly delegate* unmanaged<void*, int, int, int, int, uint, uint, uint, uint, Surface*> CreateRgbSurfaceFrom = null!;

    [Import(ModuleName, "SDL_CreateRGBSurfaceWithFormatFrom")]
    public static readonly delegate* unmanaged<void*, int, int, int, int, uint, Surface*> CreateRgbSurfaceWithFormatFrom = null!;

    [Import(ModuleName, "SDL_FreeSurface")]
    public static readonly delegate* unmanaged<Surface*, void> FreeSurface = null!;

    [Import(ModuleName, "SDL_SetSurfacePalette")]
    public static readonly delegate* unmanaged<Surface*, PixelFormatPalette*, int> SetSurfacePalette = null!;

    [Import(ModuleName, "SDL_LockSurface")]
    public static readonly delegate* unmanaged<Surface*, int> LockSurface = null!;

    [Import(ModuleName, "SDL_UnlockSurface")]
    public static readonly delegate* unmanaged<Surface*, void> UnlockSurface = null!;

    [Import(ModuleName, "SDL_LoadBMP_RW")]
    public static readonly delegate* unmanaged<RwOps*, int, Surface*> LoadBmpRw = null!;

    [Import(ModuleName, "SDL_SaveBMP_RW")]
    public static readonly delegate* unmanaged<Surface*, RwOps*, int, int> SaveBmpRw = null!;

    [Import(ModuleName, "SDL_SetSurfaceRLE")]
    public static readonly delegate* unmanaged<Surface*, int, int> SetSurfaceRle = null!;

    [Import(ModuleName, "SDL_HasSurfaceRLE")]
    public static readonly delegate* unmanaged<Surface*, bool> HasSurfaceRle = null!;

    [Import(ModuleName, "SDL_SetColorKey")]
    public static readonly delegate* unmanaged<Surface*, int, uint, int> SetColorKey = null!;

    [Import(ModuleName, "SDL_HasColorKey")]
    public static readonly delegate* unmanaged<Surface*, bool> HasColorKey = null!;

    [Import(ModuleName, "SDL_GetColorKey")]
    public static readonly delegate* unmanaged<Surface*, uint*, int> GetColorKey = null!;

    [Import(ModuleName, "SDL_SetSurfaceColorMod")]
    public static readonly delegate* unmanaged<Surface*, byte, byte, byte, int> SetSurfaceColorMod = null!;

    [Import(ModuleName, "SDL_GetSurfaceColorMod")]
    public static readonly delegate* unmanaged<Surface*, byte*, byte*, byte*, int> GetSurfaceColorMod = null!;

    [Import(ModuleName, "SDL_SetSurfaceAlphaMod")]
    public static readonly delegate* unmanaged<Surface*, byte, int> SetSurfaceAlphaMod = null!;

    [Import(ModuleName, "SDL_GetSurfaceAlphaMod")]
    public static readonly delegate* unmanaged<Surface*, byte*, int> GetSurfaceAlphaMod = null!;

    [Import(ModuleName, "SDL_SetSurfaceBlendMode")]
    public static readonly delegate* unmanaged<Surface*, BlendMode, int> SetSurfaceBlendMode = null!;

    [Import(ModuleName, "SDL_GetSurfaceBlendMode")]
    public static readonly delegate* unmanaged<Surface*, BlendMode*, int> GetSurfaceBlendMode = null!;

    [Import(ModuleName, "SDL_SetClipRect")]
    public static readonly delegate* unmanaged<Surface*, Rect*, bool> SetClipRect = null!;

    [Import(ModuleName, "SDL_GetClipRect")]
    public static readonly delegate* unmanaged<Surface*, Rect*, bool> GetClipRect = null!;

    [Import(ModuleName, "SDL_DuplicateSurface")]
    public static readonly delegate* unmanaged<Surface*, Surface*> DuplicateSurface = null!;

    [Import(ModuleName, "SDL_ConvertSurface")]
    public static readonly delegate* unmanaged<Surface*, PixelFormat*, uint, Surface*> ConvertSurface = null!;

    [Import(ModuleName, "SDL_ConvertSurfaceFormat")]
    public static readonly delegate* unmanaged<Surface*, uint, uint, Surface*> ConvertSurfaceFormat = null!;

    [Import(ModuleName, "SDL_ConvertPixels")]
    public static readonly delegate* unmanaged<int, int, uint, void*, int, uint, void*, int, int> ConvertPixels = null!;

    [Import(ModuleName, "SDL_FillRect")]
    public static readonly delegate* unmanaged<Surface*, Rect*, uint, int> FillRect = null!;

    [Import(ModuleName, "SDL_FillRects")]
    public static readonly delegate* unmanaged<Surface*, Rect*, int, uint, int> FillRects = null!;

    [Import(ModuleName, "SDL_UpperBlit")]
    public static readonly delegate* unmanaged<Surface*, Rect*, Surface*, Rect*, int> UpperBlit = null!;

    [Import(ModuleName, "SDL_LowerBlit")]
    public static readonly delegate* unmanaged<Surface*, Rect*, Surface*, Rect*, int> LowerBlit = null!;

    [Import(ModuleName, "SDL_SoftStretch")]
    public static readonly delegate* unmanaged<Surface*, Rect*, Surface*, Rect*, int> SoftStretch = null!;

    [Import(ModuleName, "SDL_SoftStretchLinear")]
    public static readonly delegate* unmanaged<Surface*, Rect*, Surface*, Rect*, int> SoftStretchLinear = null!;

    [Import(ModuleName, "SDL_UpperBlitScaled")]
    public static readonly delegate* unmanaged<Surface*, Rect*, Surface*, Rect*, int> UpperBlitScaled = null!;

    [Import(ModuleName, "SDL_LowerBlitScaled")]
    public static readonly delegate* unmanaged<Surface*, Rect*, Surface*, Rect*, int> LowerBlitScaled = null!;

    [Import(ModuleName, "SDL_SetYUVConversionMode")]
    public static readonly delegate* unmanaged<YuvConversionMode, void> SetYuvConversionMode = null!;

    [Import(ModuleName, "SDL_GetYUVConversionMode")]
    public static readonly delegate* unmanaged<YuvConversionMode> GetYuvConversionMode = null!;

    [Import(ModuleName, "SDL_GetYUVConversionModeForResolution")]
    public static readonly delegate* unmanaged<int, int, YuvConversionMode> GetYuvConversionModeForResolution = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct Surface {
        public SurfaceFlag Flags;
        public PixelFormat* Format;
        public int Width;
        public int Height;
        public int Pitch;
        public void* Pixels;
        public void* UserData;
        public int Locked;
        public void* ListBlitMap;
        public Rect ClipRect;
        public void* Map;
        public int RefCount;
    }
}