using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_keyboard.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    [Import(ModuleName, "SDL_GetKeyboardFocus")]
    public static readonly delegate* unmanaged<void*> GetKeyboardFocus = null!;

    [Import(ModuleName, "SDL_GetKeyboardState")]
    public static readonly delegate* unmanaged<int*, byte*> GetKeyboardState = null!;

    [Import(ModuleName, "SDL_GetModState")]
    public static readonly delegate* unmanaged<KeyMod> GetModState = null!;

    [Import(ModuleName, "SDL_SetModState")]
    public static readonly delegate* unmanaged<KeyMod, void> SetModState = null!;

    [Import(ModuleName, "SDL_GetKeyFromScancode")]
    public static readonly delegate* unmanaged<ScanCode, Key> GetKeyFromScancode = null!;

    [Import(ModuleName, "SDL_GetScancodeFromKey")]
    public static readonly delegate* unmanaged<Key, ScanCode> GetScancodeFromKey = null!;

    [Import(ModuleName, "SDL_GetScancodeName")]
    public static readonly delegate* unmanaged<ScanCode, void*> GetScancodeName = null!;

    [Import(ModuleName, "SDL_GetScancodeFromName")]
    public static readonly delegate* unmanaged<void*, ScanCode> GetScancodeFromName = null!;

    [Import(ModuleName, "SDL_GetKeyName")]
    public static readonly delegate* unmanaged<Key, void*> GetKeyName = null!;

    [Import(ModuleName, "SDL_GetKeyFromName")]
    public static readonly delegate* unmanaged<void*, Key> GetKeyFromName = null!;

    [Import(ModuleName, "SDL_StartTextInput")]
    public static readonly delegate* unmanaged<void> StartTextInput = null!;

    [Import(ModuleName, "SDL_IsTextInputActive")]
    public static readonly delegate* unmanaged<bool> IsTextInputActive = null!;

    [Import(ModuleName, "SDL_StopTextInput")]
    public static readonly delegate* unmanaged<void> StopTextInput = null!;

    [Import(ModuleName, "SDL_SetTextInputRect")]
    public static readonly delegate* unmanaged<Rect*, void> SetTextInputRect = null!;

    [Import(ModuleName, "SDL_HasScreenKeyboardSupport")]
    public static readonly delegate* unmanaged<bool> HasScreenKeyboardSupport = null!;

    [Import(ModuleName, "SDL_IsScreenKeyboardShown")]
    public static readonly delegate* unmanaged<void*, bool> IsScreenKeyboardShown = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct KeySym {
        public ScanCode ScanCode;
        public Key Key;
        public KeyMod Mod;
        private readonly uint _Unused;
    }
}