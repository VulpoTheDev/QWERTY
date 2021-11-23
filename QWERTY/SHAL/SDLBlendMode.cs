using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_blendmode.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum BlendFactor {
        Zero = 0x0000_0001,
        One,
        SrcColor,
        OneMinusSrcColor,
        SrcAlpha,
        OneMinusSrcAlpha,
        DstColor,
        OneMinusDstColor,
        DstAlpha,
        OneMinusDstAlpha
    }

    public enum BlendMode {
        None,
        Blend,
        Add,
        Mod = 0x0000_0004,
        Mul = 0x0000_0008,
        Invalid = 0x7FFF_FFFF
    }

    public enum BlendOp {
        Add = 0x0000_0001,
        Subtract,
        RevSubtract,
        Minimum,
        Maximum
    }

    [Import(ModuleName, "SDL_ComposeCustomBlendMode")]
    public static readonly delegate* unmanaged<BlendFactor, BlendFactor, BlendOp, BlendFactor, BlendFactor, BlendOp, BlendMode> ComposeCustomBlendMode = null!;
}