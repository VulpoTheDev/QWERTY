using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from the SDL2_gfx library.<br></br>
/// For documentation, please refer to <a href="https://www.ferzkopp.net/Software/SDL2_gfx/Docs/html/index.html" target="_blank">the official documentation.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 12/10/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public static unsafe class SDLGraphics {
    private const string ModuleName = "sdl2-gfx";

    private static readonly LibraryLoader _Loader = new(ModuleName, () => {
        if (SystemInfo.IsWindows) return new[] {"SDL2_gfx.dll"};
        return SystemInfo.IsOSX ? new[] {"libSDL2_gfx.dylib"} : new[] {"libSDL2_gfx-1.0.so.0", "libSDL2_gfx-1.0.so"};
    });

    static SDLGraphics() {
        _Loader.LoadFunctionsFor(typeof(SDLGraphics));
    }

    [Import(ModuleName, "pixelColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, uint, int> PixelColor = null!;

    [Import(ModuleName, "pixelRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, byte, byte, byte, byte, int> PixelRgba = null!;

    [Import(ModuleName, "hlineColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, uint, int> HLineColor = null!;

    [Import(ModuleName, "hlineRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, byte, byte, byte, byte, int> HLineRgba = null!;

    [Import(ModuleName, "vlineColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, uint, int> VLineColor = null!;

    [Import(ModuleName, "vlineRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, byte, byte, byte, byte, int> VLineRgba = null!;

    [Import(ModuleName, "rectangleColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, uint, int> RectangleColor = null!;

    [Import(ModuleName, "rectangleRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, byte, byte, byte, byte, int> RectangleRgba = null!;

    [Import(ModuleName, "roundedRectangleColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, uint, int> RoundedRectangleColor = null!;

    [Import(ModuleName, "roundedRectangleRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, byte, byte, byte, byte, int> RoundedRectangleRgba = null!;

    [Import(ModuleName, "boxColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, uint, int> BoxColor = null!;

    [Import(ModuleName, "boxRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, byte, byte, byte, byte, int> BoxRgba = null!;

    [Import(ModuleName, "roundedBoxColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, uint, int> RoundedBoxColor = null!;

    [Import(ModuleName, "roundedBoxRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, byte, byte, byte, byte, int> RoundedBoxRgba = null!;

    [Import(ModuleName, "lineColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, uint, int> LineColor = null!;

    [Import(ModuleName, "lineRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, byte, byte, byte, byte, int> LineRgba = null!;

    [Import(ModuleName, "aalineColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, uint, int> AaLineColor = null!;

    [Import(ModuleName, "aalineRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, byte, byte, byte, byte, int> AaLineRgba = null!;

    [Import(ModuleName, "thickLineColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, byte, uint, int> ThickLineColor = null!;

    [Import(ModuleName, "thickLineRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, byte, byte, byte, byte, byte, int> ThickLineRgba = null!;

    [Import(ModuleName, "circleColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, uint, int> CircleColor = null!;

    [Import(ModuleName, "circleRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, byte, byte, byte, byte, int> CircleRgba = null!;

    [Import(ModuleName, "arcColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, uint, int> ArcColor = null!;

    [Import(ModuleName, "arcRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, byte, byte, byte, byte, int> ArcRgba = null!;

    [Import(ModuleName, "aacircleColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, uint, int> AaCircleColor = null!;

    [Import(ModuleName, "aacircleRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, byte, byte, byte, byte, int> AaCircleRgba = null!;

    [Import(ModuleName, "filledCircleColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, uint, int> FilledCircleColor = null!;

    [Import(ModuleName, "filledCircleRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, byte, byte, byte, byte, int> FilledCircleRgba = null!;

    [Import(ModuleName, "ellipseColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, uint, int> EllipseColor = null!;

    [Import(ModuleName, "ellipseRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, byte, byte, byte, int> EllipseRgba = null!;

    [Import(ModuleName, "aaellipseColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, uint, int> AaEllipseColor = null!;

    [Import(ModuleName, "aaellipseRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, byte, byte, byte, byte, int> AaEllipseRgba = null!;

    [Import(ModuleName, "filledEllipseColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, uint, int> FilledEllipseColor = null!;

    [Import(ModuleName, "filledEllipseRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, byte, byte, byte, byte, int> FilledEllipseRgba = null!;

    [Import(ModuleName, "pieColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, uint, int> PieColor = null!;

    [Import(ModuleName, "pieRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, byte, byte, byte, byte, int> PieRgba = null!;

    [Import(ModuleName, "filledPieColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, uint, int> FilledPieColor = null!;

    [Import(ModuleName, "filledPieRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, byte, byte, byte, byte, int> FilledPieRgba = null!;

    [Import(ModuleName, "trigonColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, short, uint, int> TrigonColor = null!;

    [Import(ModuleName, "trigonRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, short, byte, byte, byte, byte, int> TrigonRgba = null!;

    [Import(ModuleName, "aatrigonColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, short, uint, int> AaTrigonColor = null!;

    [Import(ModuleName, "aatrigonRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, short, byte, byte, byte, byte, int> AaTrigonRgba = null!;

    [Import(ModuleName, "filledTrigonColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, short, uint, int> FilledTrigonColor = null!;

    [Import(ModuleName, "filledTrigonRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short, short, short, short, short, short, byte, byte, byte, byte, int> FilledTrigonRgba = null!;

    [Import(ModuleName, "polygonColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short*, short*, int, uint, int> PolygonColor = null!;

    [Import(ModuleName, "polygonRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short*, short*, int, byte, byte, byte, byte, int> PolygonRgba = null!;

    [Import(ModuleName, "aapolygonColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short*, short*, int, uint, int> AaPolygonColor = null!;

    [Import(ModuleName, "aapolygonRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short*, short*, int, byte, byte, byte, byte, int> AaPolygonRgba = null!;

    [Import(ModuleName, "filledPolygonColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short*, short*, int, uint, int> FilledPolygonColor = null!;

    [Import(ModuleName, "filledPolygonRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short*, short*, int, byte, byte, byte, byte, int> FilledPolygonRgba = null!;

    [Import(ModuleName, "bezierColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short*, short*, int, int, uint, int> BezierColor = null!;

    [Import(ModuleName, "bezierRGBA")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short*, short*, int, int, byte, byte, byte, byte, int> BezierRgba = null!;

    [Import(ModuleName, "texturedPolygon")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, short*, short*, int, SDL.Surface*, int, int, int> TexturedPolygon = null!;
}