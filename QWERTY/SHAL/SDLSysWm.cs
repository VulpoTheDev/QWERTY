using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_syswm.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum SysWmType {
        Unknown,
        Windows,
        X11,
        DirectFb,
        Cocoa,
        UiKit,
        Wayland,
        Mir, // This get's removed soon!
        WinRt,
        Android,
        Vivante,
        Os2,
        Haiku,
        KmsDrm
    }

    [Import(ModuleName, "SDL_GetWindowWMInfo")]
    public static readonly delegate* unmanaged<void*, WmInfo*, bool> GetWindowWmInfo = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct Win32WmMessageData {
        public void* Hwnd;
        public uint Msg;
        public short WParam; // is this right?
        public int LParam; // is this right?
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct X11WmMessageData {
        private readonly int _Dummy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DfbWmMessageData {
        private readonly int _Dummy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CocoaWmMessageData {
        private readonly int _Dummy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UiKitWmMessageData {
        private readonly int _Dummy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VivanteWmMessageData {
        private readonly int _Dummy;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Os2WmMessageData {
        public bool FFrame;
        public void* Hwnd;
        public ulong Msg;
        public short Mp1;
        public short Mp2;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct WmMessageData {
        [FieldOffset(0)]
        public Win32WmMessageData Windows;

        [FieldOffset(0)]
        public X11WmMessageData X11;

        [FieldOffset(0)]
        public DfbWmMessageData Dfb;

        [FieldOffset(0)]
        public CocoaWmMessageData Cocoa;

        [FieldOffset(0)]
        public UiKitWmMessageData UiKit;

        [FieldOffset(0)]
        public VivanteWmMessageData Vivante;

        [FieldOffset(0)]
        public Os2WmMessageData Os2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WmMessage {
        public Version Version;
        public SysWmType Type;
        public WmMessageData Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Win32WmInfoData {
        public void* Window;
        public void* DeviceCtx;
        public void* Instance;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WinRtWmInfoData {
        public void* Window;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct X11WmInfoData {
        public void* Display;
        public void* Window;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DfbWmInfoData {
        public void* FrameBuffer;
        public void* Window;
        public void* Surface;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CocoaWmInfoData {
        public void* Window;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UiKitWmInfoData {
        public void* Window;
        public uint FrameBuffer;
        public uint ColorBuffer;
        public uint ResFrameBuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WaylandWmInfoData {
        public void* Display;
        public void* Surface;
        public void* ShellSurface;
        public void* EglWindow;
        public void* XdgSurface;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AndroidWmInfoData {
        public void* Window;
        public void* Surface; // TODO: is this correct?
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Os2WmInfoData {
        public void* Hwnd;
        public void* HwndFrame;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VivanteWmInfoData {
        public void* Display; // TODO: are these right?
        public void* Window; // TODO: "
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct KmsDrmWmInfoData {
        public int DeviceIndex;
        public int DrmFd;
        public void* GbmDevice;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct WmInfoData {
        [FieldOffset(0)]
        public Win32WmInfoData Windows;

        [FieldOffset(0)]
        public WinRtWmInfoData WinRt;

        [FieldOffset(0)]
        public X11WmInfoData X11;

        [FieldOffset(0)]
        public DfbWmInfoData Dfb;

        [FieldOffset(0)]
        public CocoaWmInfoData Cocoa;

        [FieldOffset(0)]
        public UiKitWmInfoData UiKit;

        [FieldOffset(0)]
        public WaylandWmInfoData Wayland;

        [FieldOffset(0)]
        public AndroidWmInfoData Android;

        [FieldOffset(0)]
        public Os2WmInfoData Os2;

        [FieldOffset(0)]
        public VivanteWmInfoData Vivante;

        [FieldOffset(0)]
        public KmsDrmWmInfoData KmsDrm;

        [FieldOffset(0)]
        private fixed byte _Dummy[64];
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WmInfo {
        public Version Version;
        public SysWmType Type;
        public WmInfoData Data;
    }
}