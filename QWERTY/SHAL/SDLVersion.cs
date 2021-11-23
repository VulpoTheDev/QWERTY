using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_version.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    [Import(ModuleName, "SDL_GetVersion")]
    public static readonly delegate* unmanaged<Version*, void> GetVersion = null!;

    [Import(ModuleName, "SDL_GetRevision")]
    public static readonly delegate* unmanaged<void*> GetRevision = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct Version {
        public byte Major;
        public byte Minor;
        public byte Patch;
    }
}