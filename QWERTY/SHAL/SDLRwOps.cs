using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_rwops.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum RwSeekOrigin {
        Set,
        Current,
        End
    }

    public enum RwType : uint {
        Unknown,
        WinFile,
        StdFile,
        JniFile,
        Memory,
        MemoryRo,
        VitaFile
    }

    [Import(ModuleName, "SDL_RWFromFile")]
    public static readonly delegate* unmanaged<void*, void*, RwOps*> RwFromFile = null!;

    [Import(ModuleName, "SDL_RWFromFP")]
    public static readonly delegate* unmanaged<void*, bool, RwOps*> RwFromFp = null!;

    [Import(ModuleName, "SDL_RWFromMem")]
    public static readonly delegate* unmanaged<void*, int, RwOps*> RwFromMem = null!;

    [Import(ModuleName, "SDL_RWFromConstMem")]
    public static readonly delegate* unmanaged<void*, int, RwOps*> RwFromConstMem = null!;

    [Import(ModuleName, "SDL_AllocRW")]
    public static readonly delegate* unmanaged<RwOps*> AllocRw = null!;

    [Import(ModuleName, "SDL_FreeRW")]
    public static readonly delegate* unmanaged<RwOps*, void> FreeRw = null!;

    [Import(ModuleName, "SDL_RWsize")]
    public static readonly delegate* unmanaged<RwOps*, long> RwSize = null!;

    [Import(ModuleName, "SDL_RWseek")]
    public static readonly delegate* unmanaged<RwOps*, long, RwSeekOrigin, long> RwSeek = null!;

    [Import(ModuleName, "SDL_RWtell")]
    public static readonly delegate* unmanaged<RwOps*, long> RwTell = null!;

    [Import(ModuleName, "SDL_RWread")]
    public static readonly delegate* unmanaged<RwOps*, void*, ulong, ulong, ulong> RwRead = null!;

    [Import(ModuleName, "SDL_RWwrite")]
    public static readonly delegate* unmanaged<RwOps*, void*, ulong, ulong, ulong> RwWrite = null!;

    [Import(ModuleName, "SDL_RWclose")]
    public static readonly delegate* unmanaged<RwOps*, int> RwClose = null!;

    [Import(ModuleName, "SDL_LoadFile_RW")]
    public static readonly delegate* unmanaged<RwOps*, ulong*, int, void*> LoadFileRw = null!;

    [Import(ModuleName, "SDL_LoadFile")]
    public static readonly delegate* unmanaged<void*, ulong*, void*> LoadFile = null!;

    [Import(ModuleName, "SDL_ReadU8")]
    public static readonly delegate* unmanaged<RwOps*, byte> ReadU8 = null!;

    [Import(ModuleName, "SDL_ReadLE16")]
    public static readonly delegate* unmanaged<RwOps*, ushort> ReadLe16 = null!;

    [Import(ModuleName, "SDL_ReadBE16")]
    public static readonly delegate* unmanaged<RwOps*, ushort> ReadBe16 = null!;

    [Import(ModuleName, "SDL_ReadLE32")]
    public static readonly delegate* unmanaged<RwOps*, uint> ReadLe32 = null!;

    [Import(ModuleName, "SDL_ReadBE32")]
    public static readonly delegate* unmanaged<RwOps*, uint> ReadBe32 = null!;

    [Import(ModuleName, "SDL_ReadLE64")]
    public static readonly delegate* unmanaged<RwOps*, ulong> ReadLe64 = null!;

    [Import(ModuleName, "SDL_ReadBE64")]
    public static readonly delegate* unmanaged<RwOps*, ulong> ReadBe64 = null!;

    [Import(ModuleName, "SDL_WriteU8")]
    public static readonly delegate* unmanaged<RwOps*, byte, ulong> WriteU8 = null!;

    [Import(ModuleName, "SDL_WriteLE16")]
    public static readonly delegate* unmanaged<RwOps*, ushort, ulong> WriteLe16 = null!;

    [Import(ModuleName, "SDL_WriteBE16")]
    public static readonly delegate* unmanaged<RwOps*, ushort, ulong> WriteBe16 = null!;

    [Import(ModuleName, "SDL_WriteLE32")]
    public static readonly delegate* unmanaged<RwOps*, uint, ulong> WriteLe32 = null!;

    [Import(ModuleName, "SDL_WriteBE32")]
    public static readonly delegate* unmanaged<RwOps*, uint, ulong> WriteBe32 = null!;

    [Import(ModuleName, "SDL_WriteLE64")]
    public static readonly delegate* unmanaged<RwOps*, ulong, ulong> WriteLe64 = null!;

    [Import(ModuleName, "SDL_WriteBE64")]
    public static readonly delegate* unmanaged<RwOps*, ulong, ulong> WriteBe64 = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct AndroidRwIo {
        public void* Asset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WindowsRwIoBuffer {
        public void* Data;
        public ulong Size;
        public ulong Left;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WindowsRwIo {
        public bool Append;
        public void* Handle;
        public WindowsRwIoBuffer Buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VitaRwIo {
        public int Handle;
        public void* Data;
        public ulong Size;
        public ulong Left;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct StdRwIo {
        public bool AutoClose;
        public void* Handle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryRwIo {
        public byte* Base;
        public byte* Here;
        public byte* Stop;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct UnknownRwIo {
        public void* Data1;
        public void* Data2;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RwIo {
        [FieldOffset(0)]
        public AndroidRwIo Android;

        [FieldOffset(0)]
        public WindowsRwIo Windows;

        [FieldOffset(0)]
        public VitaRwIo Vita;

        [FieldOffset(0)]
        public StdRwIo Std;

        [FieldOffset(0)]
        public MemoryRwIo Memory;

        [FieldOffset(0)]
        public UnknownRwIo Unknown;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RwOps {
        public delegate* unmanaged<RwOps*, long> GetSize;
        public delegate* unmanaged<RwOps*, long, int, long> Seek;
        public delegate* unmanaged<RwOps*, void*, ulong, ulong, ulong> Read;
        public delegate* unmanaged<RwOps*, void*, ulong, ulong, ulong> Write;
        public delegate* unmanaged<RwOps*, int> Close;
        private readonly uint _Type;
        private readonly RwIo _Io;
    }
}