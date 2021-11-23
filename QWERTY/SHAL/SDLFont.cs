using System;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_ttf.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public static unsafe class SDLFont {
    public enum Hinting {
        Normal,
        Light,
        Mono,
        None,
        LightSubPixel
    }

    [Flags]
    public enum Style {
        Normal,
        Bold,
        Italic,
        Underline = 0x0000_0004,
        Strikethrough = 0x0000_0008
    }

    public enum UnicodeByteOrder {
        Native = 0x0000_FEFF,
        Swapped = 0x0000_FFFE
    }

    private const string ModuleName = "sdl2-ttf";

    private static readonly LibraryLoader _Loader = new(ModuleName, () => {
        if (SystemInfo.IsWindows) return new[] {"SDL2_ttf.dll"};
        return SystemInfo.IsOSX ? new[] {"libsdl2_ttf.dylib"} : new[] {"libSDL2_ttf-2.0.so.0", "libSDL2_ttf-2.0.so"};
    });

    [Import(ModuleName, "TTF_Linked_Version")]
    public static readonly delegate* unmanaged<SDL.Version*> LinkedVersion = null!;

    [Import(ModuleName, "TTF_ByteSwappedUNICODE")]
    public static readonly delegate* unmanaged<UnicodeByteOrder, void> ByteSwappedUnicode = null!;

    [Import(ModuleName, "TTF_Init")]
    public static readonly delegate* unmanaged<int> Init = null!;

    [Import(ModuleName, "TTF_OpenFont")]
    public static readonly delegate* unmanaged<void*, int, void*> OpenFont = null!;

    [Import(ModuleName, "TTF_OpenFontIndex")]
    public static readonly delegate* unmanaged<void*, int, long, void*> OpenFontIndex = null!;

    [Import(ModuleName, "TTF_OpenFontRW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int, int, void*> OpenFontRw = null!;

    [Import(ModuleName, "TTF_OpenFontIndexRW")]
    public static readonly delegate* unmanaged<SDL.RwOps*, int, int, long, void*> OpenFontIndexRw = null!;

    //[Import(ModuleName, "TTF_OpenFontDPI")]
    //public static readonly delegate* unmanaged<void*, int, uint, uint, void*> OpenFontDpi = null!;

    //[Import(ModuleName, "TTF_OpenFontIndexDPI")]
    //public static readonly delegate* unmanaged<void*, int, long, uint, uint, void*> OpenFontIndexDpi = null!;

    //[Import(ModuleName, "TTF_OpenFontDPIRW")]
    //public static readonly delegate* unmanaged<SDL.RwOps*, int, int, uint, uint, void*> OpenFontDpiRw = null!;

    //[Import(ModuleName, "TTF_OpenFontIndexDPIRW")]
    //public static readonly delegate* unmanaged<SDL.RwOps*, int, int, long, uint, uint, void*> OpenFontIndexDpiRw = null!;

    //[Import(ModuleName, "TTF_SetFontSize")]
    //public static readonly delegate* unmanaged<void*, int, int> SetFontSize = null!;

    //[Import(ModuleName, "TTF_SetFontSizeDPI")]
    //public static readonly delegate* unmanaged<void*, int, uint, uint, int> SetFontSizeDpi = null!;

    [Import(ModuleName, "TTF_GetFontStyle")]
    public static readonly delegate* unmanaged<void*, Style> GetFontStyle = null!;

    [Import(ModuleName, "TTF_SetFontStyle")]
    public static readonly delegate* unmanaged<void*, Style, void> SetFontStyle = null!;

    [Import(ModuleName, "TTF_GetFontOutline")]
    public static readonly delegate* unmanaged<void*, int> GetFontOutline = null!;

    [Import(ModuleName, "TTF_SetFontOutline")]
    public static readonly delegate* unmanaged<void*, int, void> SetFontOutline = null!;

    [Import(ModuleName, "TTF_GetFontHinting")]
    public static readonly delegate* unmanaged<void*, Hinting> GetFontHinting = null!;

    [Import(ModuleName, "TTF_SetFontHinting")]
    public static readonly delegate* unmanaged<void*, Hinting, void> SetFontHinting = null!;

    [Import(ModuleName, "TTF_FontHeight")]
    public static readonly delegate* unmanaged<void*, int> FontHeight = null!;

    [Import(ModuleName, "TTF_FontAscent")]
    public static readonly delegate* unmanaged<void*, int> FontAscent = null!;

    [Import(ModuleName, "TTF_FontDescent")]
    public static readonly delegate* unmanaged<void*, int> FontDescent = null!;

    [Import(ModuleName, "TTF_FontLineSkip")]
    public static readonly delegate* unmanaged<void*, int> FontLineSkip = null!;

    [Import(ModuleName, "TTF_GetFontKerning")]
    public static readonly delegate* unmanaged<void*, int> GetFontKerning = null!;

    [Import(ModuleName, "TTF_SetFontKerning")]
    public static readonly delegate* unmanaged<void*, int, void> SetFontKerning = null!;

    [Import(ModuleName, "TTF_FontFaces")]
    public static readonly delegate* unmanaged<void*, long> FontFaces = null!;

    [Import(ModuleName, "TTF_FontFaceIsFixedWidth")]
    public static readonly delegate* unmanaged<void*, int> FontFaceIsFixedWidth = null!;

    [Import(ModuleName, "TTF_FontFaceFamilyName")]
    public static readonly delegate* unmanaged<void*, void*> FontFaceFamilyName = null!;

    [Import(ModuleName, "TTF_FontFaceStyleName")]
    public static readonly delegate* unmanaged<void*, void*> FontFaceStyleName = null!;

    [Import(ModuleName, "TTF_GlyphIsProvided")]
    public static readonly delegate* unmanaged<void*, ushort, int> GlyphIsProvided = null!;

    //[Import(ModuleName, "TTF_GlyphIsProvided32")]
    //public static readonly delegate* unmanaged<void*, uint, int> GlyphIsProvided32 = null!;

    [Import(ModuleName, "TTF_GlyphMetrics")]
    public static readonly delegate* unmanaged<void*, ushort, int*, int*, int*, int*, int*, int> GlyphMetrics = null!;

    //[Import(ModuleName, "TTF_GlyphMetrics32")]
    //public static readonly delegate* unmanaged<void*, uint, int*, int*, int*, int*, int*, int> GlyphMetrics32 = null!;

    [Import(ModuleName, "TTF_SizeText")]
    public static readonly delegate* unmanaged<void*, void*, int*, int*, int> SizeText = null!;

    //[Import(ModuleName, "TTF_SizeTextUTF8")]
    //public static readonly delegate* unmanaged<void*, void*, int*, int*, int> SizeTextUtf8 = null!;

    //[Import(ModuleName, "TTF_SizeTextUNICODE")]
    //public static readonly delegate* unmanaged<void*, ushort*, int*, int*, int> SizeTextUnicode = null!;

    //[Import(ModuleName, "TTF_MeasureText")]
    //public static readonly delegate* unmanaged<void*, void*, int, int*, int*, int> MeasureText = null!;

    //[Import(ModuleName, "TTF_MeasureTextUTF8")]
    //public static readonly delegate* unmanaged<void*, void*, int, int*, int*, int> MeasureTextUtf8 = null!;

    //[Import(ModuleName, "TTF_MeasureTextUNICODE")]
    //public static readonly delegate* unmanaged<void*, ushort*, int, int*, int*, int> MeasureTextUnicode = null!;

    [Import(ModuleName, "TTF_RenderText_Solid")]
    public static readonly delegate* unmanaged<void*, void*, SDL.Color, SDL.Surface*> RenderTextSolid = null!;

    [Import(ModuleName, "TTF_RenderUTF8_Solid")]
    public static readonly delegate* unmanaged<void*, void*, SDL.Color, SDL.Surface*> RenderUtf8Solid = null!;

    [Import(ModuleName, "TTF_RenderUNICODE_Solid")]
    public static readonly delegate* unmanaged<void*, ushort*, SDL.Color, SDL.Surface*> RenderUnicodeSolid = null!;

    //[Import(ModuleName, "TTF_RenderText_Solid_Wrapped")]
    //public static readonly delegate* unmanaged<void*, void*, SDL.Color, uint, SDL.Surface*> RenderTextSolidWrapped = null!;

    //[Import(ModuleName, "TTF_RenderUTF8_Solid_Wrapped")]
    //public static readonly delegate* unmanaged<void*, void*, SDL.Color, uint, SDL.Surface*> RenderUtf8SolidWrapped = null!;

    //[Import(ModuleName, "TTF_RenderUNICODE_Solid_Wrapped")]
    //public static readonly delegate* unmanaged<void*, ushort*, SDL.Color, uint, SDL.Surface*> RenderUnicodeSolidWrapped = null!;

    [Import(ModuleName, "TTF_RenderGlyph_Solid")]
    public static readonly delegate* unmanaged<void*, ushort, SDL.Color, SDL.Surface*> RenderGlyphSolid = null!;

    //[Import(ModuleName, "TTF_RenderGlyph32_Solid")]
    //public static readonly delegate* unmanaged<void*, uint, SDL.Color, SDL.Surface*> RenderGlyph32Solid = null!;

    [Import(ModuleName, "TTF_RenderText_Shaded")]
    public static readonly delegate* unmanaged<void*, void*, SDL.Color, SDL.Color, SDL.Surface*> RenderTextShaded = null!;

    [Import(ModuleName, "TTF_RenderUTF8_Shaded")]
    public static readonly delegate* unmanaged<void*, void*, SDL.Color, SDL.Color, SDL.Surface*> RenderUtf8Shaded = null!;

    [Import(ModuleName, "TTF_RenderUNICODE_Shaded")]
    public static readonly delegate* unmanaged<void*, ushort*, SDL.Color, SDL.Color, SDL.Surface*> RenderUnicodeShaded = null!;

    //[Import(ModuleName, "TTF_RenderText_Shaded_Wrapped")]
    //public static readonly delegate* unmanaged<void*, void*, SDL.Color, SDL.Color, uint, SDL.Surface*> RenderTextShadedWrapped = null!;

    //[Import(ModuleName, "TTF_RenderUTF8_Shaded_Wrapped")]
    //public static readonly delegate* unmanaged<void*, void*, SDL.Color, SDL.Color, uint, SDL.Surface*> RenderUtf8ShadedWrapped = null!;

    //[Import(ModuleName, "TTF_RenderUNICODE_Shaded_Wrapped")]
    //public static readonly delegate* unmanaged<void*, ushort*, SDL.Color, SDL.Color, uint, SDL.Surface*> RenderUnicodeShadedWrapped = null!;

    [Import(ModuleName, "TTF_RenderGlyph_Shaded")]
    public static readonly delegate* unmanaged<void*, ushort, SDL.Color, SDL.Color, SDL.Surface*> RenderGlyphShaded = null!;

    //[Import(ModuleName, "TTF_RenderGlyph32_Shaded")]
    //public static readonly delegate* unmanaged<void*, uint, SDL.Color, SDL.Color, SDL.Surface*> RenderGlyph32Shaded = null!;

    [Import(ModuleName, "TTF_RenderText_Blended")]
    public static readonly delegate* unmanaged<void*, void*, SDL.Color, SDL.Surface*> RenderTextBlended = null!;

    [Import(ModuleName, "TTF_RenderUTF8_Blended")]
    public static readonly delegate* unmanaged<void*, void*, SDL.Color, SDL.Surface*> RenderUtf8Blended = null!;

    [Import(ModuleName, "TTF_RenderUNICODE_Blended")]
    public static readonly delegate* unmanaged<void*, ushort*, SDL.Color, SDL.Surface*> RenderUnicodeBlended = null!;

    //[Import(ModuleName, "TTF_RenderText_Blended_Wrapped")]
    //public static readonly delegate* unmanaged<void*, void*, SDL.Color, uint, SDL.Surface*> RenderTextBlendedWrapped = null!;

    //[Import(ModuleName, "TTF_RenderUTF8_Blended_Wrapped")]
    //public static readonly delegate* unmanaged<void*, void*, SDL.Color, uint, SDL.Surface*> RenderUtf8BlendedWrapped = null!;

    //[Import(ModuleName, "TTF_RenderUNICODE_Blended_Wrapped")]
    //public static readonly delegate* unmanaged<void*, ushort*, SDL.Color, uint, SDL.Surface*> RenderUnicodeBlendedWrapped = null!;

    [Import(ModuleName, "TTF_RenderGlyph_Blended")]
    public static readonly delegate* unmanaged<void*, ushort, SDL.Color, SDL.Surface*> RenderGlyphBlended = null!;

    //[Import(ModuleName, "TTF_RenderGlyph32_Blended")]
    //public static readonly delegate* unmanaged<void*, uint, SDL.Color, SDL.Surface*> RenderGlyph32Blended = null!;

    //[Import(ModuleName, "TTF_SetDirection")]
    //public static readonly delegate* unmanaged<int, int> SetDirection = null!;

    //[Import(ModuleName, "TTF_SetScript")]
    //public static readonly delegate* unmanaged<int, int> SetScript = null!;

    [Import(ModuleName, "TTF_CloseFont")]
    public static readonly delegate* unmanaged<void*, void> CloseFont = null!;

    [Import(ModuleName, "TTF_Quit")]
    public static readonly delegate* unmanaged<void> Quit = null!;

    [Import(ModuleName, "TTF_WasInit")]
    public static readonly delegate* unmanaged<int> WasInit = null!;

    [Import(ModuleName, "TTF_GetFontKerningSizeGlyphs")]
    public static readonly delegate* unmanaged<void*, ushort, ushort, int> GetFontKerningSizeGlyphs = null!;

    //[Import(ModuleName, "TTF_GetFontKerningSizeGlyphs32")]
    //public static readonly delegate* unmanaged<void*, uint, uint, int> GetFontKerningSizeGlyphs32 = null!;

    //[Import(ModuleName, "TTF_SetFontSDF")]
    //public static readonly delegate* unmanaged<void*, bool, int> SetFontSdf = null!;

    //[Import(ModuleName, "TTF_GetFontSDF")]
    //public static readonly delegate* unmanaged<void*, bool> GetFontSdf = null!;

    static SDLFont() {
        _Loader.LoadFunctionsFor(typeof(SDLFont));
    }
}