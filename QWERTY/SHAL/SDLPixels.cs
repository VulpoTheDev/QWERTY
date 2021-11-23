using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_pixels.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum PixelFormatArrayOrder {
        None,
        Rgb,
        Rgba,
        Argb,
        Bgr,
        Bgra,
        Abgr
    }

    public enum PixelFormatBitmapOrder {
        None,
        O4321,
        O1234
    }

    public enum PixelFormatPackedLayout {
        None,
        L332,
        L4444,
        L1555,
        L5551,
        L565,
        L8888,
        L2101010,
        L1010102
    }

    public enum PixelFormatPackedOrder {
        None,
        Xrgb,
        Rgbx,
        Argb,
        Rgba,
        Xbgr,
        Bgrx,
        Abgr,
        Bgra
    }

    public enum PixelFormatType {
        Unknown,
        Index1,
        Index4,
        Index8,
        Packed8,
        Packed16,
        Packed32,
        ArrayU8,
        ArrayU16,
        ArrayU32,
        ArrayF16,
        ArrayF32
    }

    public static class PackedPixelFormat {
        public static readonly uint Unknown = 0x0000_0000;

        public static readonly uint Index1Lsb = DefinePixelFormat(PixelFormatType.Index1, PixelFormatBitmapOrder.O4321, 0, 1, 0);
        public static readonly uint Index1Msb = DefinePixelFormat(PixelFormatType.Index1, PixelFormatBitmapOrder.O1234, 0, 1, 0);
        public static readonly uint Index4Lsb = DefinePixelFormat(PixelFormatType.Index4, PixelFormatBitmapOrder.O4321, 0, 4, 0);
        public static readonly uint Index4Msb = DefinePixelFormat(PixelFormatType.Index4, PixelFormatBitmapOrder.O1234, 0, 4, 0);
        public static readonly uint Index8 = DefinePixelFormat(PixelFormatType.Index8, 0, 0, 8, 1);

        public static readonly uint Rgb332 = DefinePackedPixelFormat(PixelFormatType.Packed8, PixelFormatPackedOrder.Xrgb, PixelFormatPackedLayout.L332, 8, 1);
        public static readonly uint Rgb444 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Xrgb, PixelFormatPackedLayout.L4444, 12, 2);
        public static readonly uint Rgb555 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Xrgb, PixelFormatPackedLayout.L1555, 15, 2);
        public static readonly uint Bgr555 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Xbgr, PixelFormatPackedLayout.L1555, 15, 2);
        public static readonly uint Argb4444 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Argb, PixelFormatPackedLayout.L4444, 16, 2);
        public static readonly uint Rgba4444 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Rgba, PixelFormatPackedLayout.L4444, 16, 2);
        public static readonly uint Abgr4444 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Abgr, PixelFormatPackedLayout.L4444, 16, 2);
        public static readonly uint Bgra4444 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Bgra, PixelFormatPackedLayout.L4444, 16, 2);
        public static readonly uint Argb1555 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Argb, PixelFormatPackedLayout.L1555, 16, 2);
        public static readonly uint Rgba5551 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Rgba, PixelFormatPackedLayout.L5551, 16, 2);
        public static readonly uint Abgr1555 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Abgr, PixelFormatPackedLayout.L1555, 16, 2);
        public static readonly uint Bgra5551 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Bgra, PixelFormatPackedLayout.L5551, 16, 2);
        public static readonly uint Rgb565 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Xrgb, PixelFormatPackedLayout.L565, 16, 2);
        public static readonly uint Bgr565 = DefinePackedPixelFormat(PixelFormatType.Packed16, PixelFormatPackedOrder.Xbgr, PixelFormatPackedLayout.L565, 16, 2);
        public static readonly uint Rgb888 = DefinePackedPixelFormat(PixelFormatType.Packed32, PixelFormatPackedOrder.Xrgb, PixelFormatPackedLayout.L8888, 24, 4);
        public static readonly uint Rgbx8888 = DefinePackedPixelFormat(PixelFormatType.Packed32, PixelFormatPackedOrder.Rgbx, PixelFormatPackedLayout.L8888, 24, 4);
        public static readonly uint Bgr888 = DefinePackedPixelFormat(PixelFormatType.Packed32, PixelFormatPackedOrder.Xbgr, PixelFormatPackedLayout.L8888, 24, 4);
        public static readonly uint Bgrx8888 = DefinePackedPixelFormat(PixelFormatType.Packed32, PixelFormatPackedOrder.Bgrx, PixelFormatPackedLayout.L8888, 24, 4);
        public static readonly uint Argb8888 = DefinePackedPixelFormat(PixelFormatType.Packed32, PixelFormatPackedOrder.Argb, PixelFormatPackedLayout.L8888, 32, 4);
        public static readonly uint Rgba8888 = DefinePackedPixelFormat(PixelFormatType.Packed32, PixelFormatPackedOrder.Rgba, PixelFormatPackedLayout.L8888, 32, 4);
        public static readonly uint Abgr8888 = DefinePackedPixelFormat(PixelFormatType.Packed32, PixelFormatPackedOrder.Abgr, PixelFormatPackedLayout.L8888, 32, 4);
        public static readonly uint Bgra8888 = DefinePackedPixelFormat(PixelFormatType.Packed32, PixelFormatPackedOrder.Bgra, PixelFormatPackedLayout.L8888, 32, 4);
        public static readonly uint Argb2101010 = DefinePackedPixelFormat(PixelFormatType.Packed32, PixelFormatPackedOrder.Argb, PixelFormatPackedLayout.L2101010, 32, 4);

        public static readonly uint Rgb24 = DefineArrayPixelFormat(PixelFormatType.ArrayU8, PixelFormatArrayOrder.Rgb, 0, 24, 3);
        public static readonly uint Bgr24 = DefineArrayPixelFormat(PixelFormatType.ArrayU8, PixelFormatArrayOrder.Bgr, 0, 24, 3);

        // The string constants passed to the DefinePixelFormatFcc method
        // should under no circumstances be modified or "cleaned up" - they
        // have a fixed width of 4 bytes (8 bytes before conversion) and spaces
        // have a meaning too!
        public static readonly uint Yv12 = DefinePixelFormatFcc("YV12");
        public static readonly uint Iyuv = DefinePixelFormatFcc("IYUV");
        public static readonly uint Yuy2 = DefinePixelFormatFcc("YUY2");
        public static readonly uint Uyvy = DefinePixelFormatFcc("UYVY");
        public static readonly uint Yvyu = DefinePixelFormatFcc("YVUY");
        public static readonly uint Nv12 = DefinePixelFormatFcc("NV12");
        public static readonly uint Nv21 = DefinePixelFormatFcc("NV21");
        public static readonly uint ExternalOes = DefinePixelFormatFcc("OES ");

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint DefinePixelFormat(PixelFormatType type, PixelFormatBitmapOrder order, PixelFormatPackedLayout layout, byte bits, byte bytes) {
            return (uint) ((1 << 28) | ((byte) type << 24) | ((byte) order << 20) | ((byte) layout << 16) | bits << 8 | bytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint DefinePackedPixelFormat(PixelFormatType type, PixelFormatPackedOrder order, PixelFormatPackedLayout layout, byte bits, byte bytes) {
            return (uint) ((1 << 28) | ((byte) type << 24) | ((byte) order << 20) | ((byte) layout << 16) | bits << 8 | bytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint DefineArrayPixelFormat(PixelFormatType type, PixelFormatArrayOrder order, PixelFormatPackedLayout layout, byte bits, byte bytes) {
            return (uint) ((1 << 28) | ((byte) type << 24) | ((byte) order << 20) | ((byte) layout << 16) | bits << 8 | bytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static uint DefinePixelFormatFcc(string s) {
            var bytes = Encoding.UTF8.GetBytes(s);
            if (bytes.Length != 4) throw new("Invalid pixel format");
            return (uint) (bytes[0] | bytes[1] << 8 | bytes[2] << 16 | bytes[3] << 24);
        }
    }

    [Import(ModuleName, "SDL_GetPixelFormatName")]
    public static readonly delegate* unmanaged<uint, void*> GetPixelFormatName = null!;

    [Import(ModuleName, "SDL_PixelFormatEnumToMasks")]
    public static readonly delegate* unmanaged<uint, int*, uint*, uint*, uint*, uint*, bool> PixelFormatEnumToMasks = null!;

    [Import(ModuleName, "SDL_MasksToPixelFormatEnum")]
    public static readonly delegate* unmanaged<int, uint, uint, uint, uint, uint> MasksToPixelFormatEnum = null!;

    [Import(ModuleName, "SDL_AllocFormat")]
    public static readonly delegate* unmanaged<uint, PixelFormat*> AllocFormat = null!;

    [Import(ModuleName, "SDL_FreeFormat")]
    public static readonly delegate* unmanaged<PixelFormat*, void> FreeFormat = null!;

    [Import(ModuleName, "SDL_AllocPalette")]
    public static readonly delegate* unmanaged<int, PixelFormatPalette*> AllocPalette = null!;

    [Import(ModuleName, "SDL_SetPixelFormatPalette")]
    public static readonly delegate* unmanaged<PixelFormat*, PixelFormatPalette*, int> SetPixelFormatPalette = null!;

    [Import(ModuleName, "SDL_SetPaletteColors")]
    public static readonly delegate* unmanaged<PixelFormatPalette*, Color*, int, int, int> SetPaletteColors = null!;

    [Import(ModuleName, "SDL_FreePalette")]
    public static readonly delegate* unmanaged<PixelFormatPalette*, void> FreePalette = null!;

    [Import(ModuleName, "SDL_MapRGB")]
    public static readonly delegate* unmanaged<PixelFormat*, byte, byte, byte, uint> MapRGB = null!;

    [Import(ModuleName, "SDL_MapRGBA")]
    public static readonly delegate* unmanaged<PixelFormat*, byte, byte, byte, byte, uint> MapRGBA = null!;

    [Import(ModuleName, "SDL_GetRGB")]
    public static readonly delegate* unmanaged<uint, PixelFormat*, byte*, byte*, byte*, void> GetRGB = null!;

    [Import(ModuleName, "SDL_GetRGBA")]
    public static readonly delegate* unmanaged<uint, PixelFormat*, byte*, byte*, byte*, byte*, void> GetRGBA = null!;

    [Import(ModuleName, "SDL_CalculateGammaRamp")]
    public static readonly delegate* unmanaged<float, ushort*, void> CalculateGammaRamp = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct Color {
        public byte R;
        public byte G;
        public byte B;
        public byte A;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PixelFormatPalette {
        public int NumColors;
        public Color* Colors;
        public uint Version;
        public int RefCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PixelFormat {
        public uint PackedFormat;
        public PixelFormatPalette* Palette;
        public byte BitsPerPixel;
        public byte BytesPerPixel;
        private fixed byte _Padding[2];
        public uint RMask;
        public uint GMask;
        public uint BMask;
        public uint AMask;
        public byte RLoss;
        public byte GLoss;
        public byte BLoss;
        public byte ALoss;
        public byte RShift;
        public byte GShift;
        public byte BShift;
        public byte AShift;
        public int RefCount;
        public PixelFormat* Next;
    }
}