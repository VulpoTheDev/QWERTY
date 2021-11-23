using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_shape.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum ShapeMode {
        Default,
        BinarizeAlpha,
        ReverseBinarizeAlpha,
        ColorKey
    }

    [Import(ModuleName, "SDL_CreateShapedWindow")]
    public static readonly delegate* unmanaged<void*, uint, uint, uint, uint, uint, void*> CreateShapedWindow = null!;

    [Import(ModuleName, "SDL_IsShapedWindow")]
    public static readonly delegate* unmanaged<void*, bool> IsShapedWindow = null!;

    [Import(ModuleName, "SDL_SetWindowShape")]
    public static readonly delegate* unmanaged<void*, Surface*, ShapeModeSpec*, int> SetWindowShape = null!;

    [Import(ModuleName, "SDL_GetShapedWindowMode")]
    public static readonly delegate* unmanaged<void*, ShapeModeSpec*, int> GetShapedWindowMode = null!;

    [StructLayout(LayoutKind.Explicit)]
    public struct ShapeParams {
        [FieldOffset(0)]
        public byte BinarizationCutoff;

        [FieldOffset(0)]
        public Color ColorKey;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ShapeModeSpec {
        public ShapeMode Mode;
        public ShapeParams Params;
    }
}