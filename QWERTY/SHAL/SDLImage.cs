using System;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_image.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public static unsafe class SDLImage {
    [Flags]
    public enum InitFlags {
        Jpg = 0x0000_0001,
        Png = 0x0000_0002,
        Tif = 0x0000_0004,
        Webp = 0x0000_0008,
        Everything = Jpg | Png | Tif | Webp
    }

    private const string ModuleName = "sdl2-image";

    private static readonly LibraryLoader _Loader = new(ModuleName, () => {
        if (SystemInfo.IsWindows) return new[] {"SDL2_image.dll"};
        return SystemInfo.IsOSX ? new[] {"libsdl2_image.dylib"} : new[] {"libSDL2_image-2.0.so.0", "libSDL2_image-2.0.so"};
    });

    [Import(ModuleName, "IMG_Linked_Version")]
    public static readonly delegate* unmanaged<SDL.Version*> LinkedVersion = null!;

    [Import(ModuleName, "IMG_Init")]
    public static readonly delegate* unmanaged<InitFlags, int> Init = null!;

    [Import(ModuleName, "IMG_Quit")]
    public static readonly delegate* unmanaged<void> Quit = null!;

    [Import(ModuleName, "IMG_LoadTyped_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int, void*, SDL.Surface*> LoadTypedRw = null!;

    [Import(ModuleName, "IMG_Load")]
    public static readonly delegate* unmanaged<void*, SDL.Surface*> Load = null!;

    [Import(ModuleName, "IMG_Load_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int, SDL.Surface*> LoadRw = null!;

    [Import(ModuleName, "IMG_LoadTexture")]
    public static readonly delegate* unmanaged<void*, void*> LoadTexture = null!;

    [Import(ModuleName, "IMG_LoadTexture_RW")]
    public static readonly delegate* unmanaged<void*, SDL.RwOps*, int, void*> LoadTextureRw = null!;

    [Import(ModuleName, "IMG_LoadTextureTyped_RW")]
    public static readonly delegate* unmanaged<void*, SDL.RwOps*, int, void*, void*> LoadTextureTypedRw = null!;

    [Import(ModuleName, "IMG_isICO")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsIco = null!;

    [Import(ModuleName, "IMG_isCUR")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsCur = null!;

    [Import(ModuleName, "IMG_isBMP")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsBmp = null!;

    [Import(ModuleName, "IMG_isGIF")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsGif = null!;

    [Import(ModuleName, "IMG_isJPG")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsJpg = null!;

    [Import(ModuleName, "IMG_isLBM")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsLbm = null!;

    [Import(ModuleName, "IMG_isPCX")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsPcx = null!;

    [Import(ModuleName, "IMG_isPNG")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsPng = null!;

    [Import(ModuleName, "IMG_isPNM")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsPnm = null!;

    [Import(ModuleName, "IMG_isSVG")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsSvg = null!;

    [Import(ModuleName, "IMG_isTIF")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsTif = null!;

    [Import(ModuleName, "IMG_isXCF")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsXcf = null!;

    [Import(ModuleName, "IMG_isXPM")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsXpm = null!;

    [Import(ModuleName, "IMG_isXV")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsXv = null!;

    [Import(ModuleName, "IMG_isWEBP")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int> IsWebp = null!;

    [Import(ModuleName, "IMG_LoadICO_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadIcoRw = null!;

    [Import(ModuleName, "IMG_LoadCUR_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadCurRw = null!;

    [Import(ModuleName, "IMG_LoadBMP_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadBmpRw = null!;

    [Import(ModuleName, "IMG_LoadGIF_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadGifRw = null!;

    [Import(ModuleName, "IMG_LoadJPG_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadJpgRw = null!;

    [Import(ModuleName, "IMG_LoadLBM_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadLbmRw = null!;

    [Import(ModuleName, "IMG_LoadPCX_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadPcxRw = null!;

    [Import(ModuleName, "IMG_LoadPNG_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadPngRw = null!;

    [Import(ModuleName, "IMG_LoadPNM_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadPnmRw = null!;

    [Import(ModuleName, "IMG_LoadSVG_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadSvgRw = null!;

    [Import(ModuleName, "IMG_LoadTGA_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadTgaRw = null!;

    [Import(ModuleName, "IMG_LoadTIF_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadTifRw = null!;

    [Import(ModuleName, "IMG_LoadXCF_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadXcfRw = null!;

    [Import(ModuleName, "IMG_LoadXPM_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadXpmRw = null!;

    [Import(ModuleName, "IMG_LoadXV_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadXvRw = null!;

    [Import(ModuleName, "IMG_LoadWEBP_RW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, SDL.Surface*> LoadWebpRw = null!;

    [Import(ModuleName, "IMG_ReadXPMFromArray")]
    public static readonly delegate* unmanaged<byte**, SDL.Surface*> ReadXpmFromArray = null!;

    [Import(ModuleName, "IMG_SavePNG")]
    public static readonly delegate* unmanaged<SDL.Surface*, void*, int> SavePng = null!;

    [Import(ModuleName, "IMG_SavePNG_RW")]
    public static readonly delegate* unmanaged<SDL.Surface*, SDL.RwOps*, int, int> SavePngRw = null!;

    [Import(ModuleName, "IMG_SaveJPG")]
    public static readonly delegate* unmanaged<SDL.Surface*, void*, int, int> SaveJpg = null!;

    [Import(ModuleName, "IMG_SaveJPG_RW")]
    public static readonly delegate* unmanaged<SDL.Surface*, SDL.RwOps*, int, int, int> SaveJpgRw = null!;

    //[Import(ModuleName, "IMG_LoadAnimation")]
    //public static readonly delegate* unmanaged<void*, Animation*> LoadAnimation = null!;

    //[Import(ModuleName, "IMG_LoadAnimation_RW")]
    //public static readonly delegate* unmanaged<SDL.RwOps*, int, Animation*> LoadAnimationRw = null!;

    //[Import(ModuleName, "IMG_LoadAnimationTyped_RW")]
    //public static readonly delegate* unmanaged<SDL.RwOps*, int, void*, Animation*> LoadAnimationTypedRw = null!;

    //[Import(ModuleName, "IMG_FreeAnimation")]
    //public static readonly delegate* unmanaged<Animation*, void> FreeAnimation = null!;

    //[Import(ModuleName, "IMG_LoadGIFAnimation_RW")]
    //public static readonly delegate* unmanaged<SDL.RwOps*, Animation*> LoadGifAnimationRw = null!;

    static SDLImage() {
        _Loader.LoadFunctionsFor(typeof(SDLImage));
    }

    //[StructLayout(LayoutKind.Sequential)]
    //public struct Animation {
    //    public int Width;
    //    public int height;
    //    public int Count;
    //    public SDL.Surface** Frames;
    //    public int* Delays;
    //}
}