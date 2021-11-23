using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_error.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum ErrorCode {
        NoMem,
        FRead,
        FWrite,
        FSeek,
        Unsupported,
        LastError
    }

    [Import(ModuleName, "SDL_SetError")]
    public static readonly delegate* unmanaged<void* /*, ... */, int> SetError = null!;

    [Import(ModuleName, "SDL_GetError")]
    public static readonly delegate* unmanaged<void*> GetError = null!;

    [Import(ModuleName, "SDL_GetErrorMsg")]
    public static readonly delegate* unmanaged<void*, int, void*> GetErrorMsg = null!;

    [Import(ModuleName, "SDL_ClearError")]
    public static readonly delegate* unmanaged<void> ClearError = null!;

    [Import(ModuleName, "SDL_Error")]
    public static readonly delegate* unmanaged<ErrorCode, int> Error = null!;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void ThrowCurrentError() {
        var pError = GetError();

        if (pError == null) {
            return;
        }

        var error = Marshal.PtrToStringUTF8(new IntPtr(pError));
        throw new(error);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Validate(bool result) {
        if (!result) {
            ThrowCurrentError();
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Validate(int result) {
        if (result != 0) {
            ThrowCurrentError();
        }
    }
}