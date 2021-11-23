using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_rect.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    [Import(ModuleName, "SDL_HasIntersection")]
    public static readonly delegate* unmanaged<Rect*, Rect*, bool> HasIntersection = null!;

    [Import(ModuleName, "SDL_IntersectRect")]
    public static readonly delegate* unmanaged<Rect*, Rect*, bool> IntersectRect = null!;

    [Import(ModuleName, "SDL_UnionRect")]
    public static readonly delegate* unmanaged<Rect*, Rect*, Rect*, void> UnionRect = null!;

    [Import(ModuleName, "SDL_EnclosePoints")]
    public static readonly delegate* unmanaged<Point*, int, Rect*, Rect*, bool> EnclosePoints = null!;

    [Import(ModuleName, "SDL_IntersectRectAndLine")]
    public static readonly delegate* unmanaged<Rect*, int*, int*, int*, int*, bool> IntersectRectAndLine = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct Point {
        public int X;
        public int Y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FPoint {
        public float X;
        public float Y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Rect {
        public int X;
        public int Y;
        public int W;
        public int H;

        public Rect(int x, int y, int w, int h) {
            X = x;
            Y = y;
            W = w;
            H = h;
        }

        #region Implicit Conversions

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Rect(Rectangle r) => new(r.X, r.Y, r.Width, r.Height);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Rectangle(Rect r) => new(r.X, r.Y, r.W, r.H);

        #endregion // ^ Implicit Conversions
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FRect {
        public float X;
        public float Y;
        public float W;
        public float H;
    }
}