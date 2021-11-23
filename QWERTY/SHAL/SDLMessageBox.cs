using System;
using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_messagebox.h.<br></br>
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
    public enum MbButtonFlag : uint {
        ReturnKey,
        EscapeKey
    }

    [Flags]
    public enum MbFlag : uint {
        Error,
        Warning,
        Information,
        ButtonsLtr,
        ButtonsRtl
    }

    [Import(ModuleName, "SDL_ShowMessageBox")]
    public static readonly delegate* unmanaged<MbData*, int*, int> ShowMessageBox = null!;

    [Import(ModuleName, "SDL_ShowSimpleMessageBox")]
    public static readonly delegate* unmanaged<MbFlag, void*, void*, void*, int> ShowSimpleMessageBox = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct MbButtonData {
        public MbButtonFlag Flags;
        public int ButtonId;
        public void* Text;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MbColor {
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MbColorScheme {
        public MbColor Background;
        public MbColor Text;
        public MbColor ButtonBorder;
        public MbColor ButtonBackground;
        public MbColor ButtonSelected;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MbData {
        public MbFlag Flags;
        public void* Window;
        public void* Title;
        public void* Message;
        public int NumButtons;
        public MbButtonData* Buttons;
        public MbColorScheme* ColorScheme;
    }
}