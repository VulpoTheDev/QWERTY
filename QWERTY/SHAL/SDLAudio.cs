using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_audio.h.<br></br>
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
    public enum AudioDeviceFlag {
        AllowFrequencyChange,
        AllowFormatChange,
        AllowChannelsChange,
        AllowSamplesChange,
        AllowAnyChange = AllowFrequencyChange | AllowFormatChange | AllowChannelsChange | AllowSamplesChange
    }

    public enum AudioFormatFlag : ushort {
        Unsigned8 = 0x0008,
        Signed8 = 0x8008,
        Unsigned16Lsb = 0x0010,
        Signed16Lsb = 0x8010,
        Unsigned16Msb = 0x1010,
        Signed16Msb = 0x9010,
        Signed32Lsb = 0x8020,
        Signed32Msb = 0x9020,
        Float32Lsb = 0x8120,
        Float32Msb = 0x9120
    }

    public enum AudioStatus {
        Stopped,
        Playing,
        Paused
    }

    private const ushort MaskBitSize = 0xFF;
    private const ushort MaskDataType = 1 << 8;
    private const ushort MaskEndian = 1 << 12;
    private const ushort MaskSigned = 1 << 15;

    private const int MaxNumFilters = 9;

    [Import(ModuleName, "SDL_GetNumAudioDrivers")]
    public static readonly delegate* unmanaged<int> GetNumAudioDrivers = null!;

    [Import(ModuleName, "SDL_GetAudioDriver")]
    public static readonly delegate* unmanaged<int, void*> GetAudioDriver = null!;

    [Import(ModuleName, "SDL_AudioInit")]
    public static readonly delegate* unmanaged<void*, int> AudioInit = null!;

    [Import(ModuleName, "SDL_AudioQuit")]
    public static readonly delegate* unmanaged<void> AudioQuit = null!;

    [Import(ModuleName, "SDL_GetCurrentAudioDriver")]
    public static readonly delegate* unmanaged<void*> GetCurrentAudioDriver = null!;

    [Import(ModuleName, "SDL_OpenAudio")]
    public static readonly delegate* unmanaged<AudioSpec*, AudioSpec*, int> OpenAudio = null!;

    [Import(ModuleName, "SDL_GetNumAudioDevices")]
    public static readonly delegate* unmanaged<int, int> GetNumAudioDevices = null!;

    [Import(ModuleName, "SDL_GetAudioDeviceName")]
    public static readonly delegate* unmanaged<int, int, void*> GetAudioDeviceName = null!;

    [Import(ModuleName, "SDL_GetAudioDeviceSpec")]
    public static readonly delegate* unmanaged<int, int, AudioSpec*, int> GetAudioDeviceSpec = null!;

    [Import(ModuleName, "SDL_OpenAudioDevice")]
    public static readonly delegate* unmanaged<void*, int, AudioSpec*, AudioSpec*, int, uint> OpenAudioDevice = null!;

    [Import(ModuleName, "SDL_GetAudioStatus")]
    public static readonly delegate* unmanaged<AudioStatus> GetAudioStatus = null!;

    [Import(ModuleName, "SDL_GetAudioDeviceStatus")]
    public static readonly delegate* unmanaged<uint, AudioStatus> GetAudioDeviceStatus = null!;

    [Import(ModuleName, "SDL_PauseAudio")]
    public static readonly delegate* unmanaged<int, void> PauseAudio = null!;

    [Import(ModuleName, "SDL_PauseAudioDevice")]
    public static readonly delegate* unmanaged<uint, int, void> PauseAudioDevice = null!;

    [Import(ModuleName, "SDL_LoadWAV_RW")]
    public static readonly delegate* unmanaged<RwOps*, int, AudioSpec*, byte**, uint*, AudioSpec*> LoadWAV_RW = null!;

    [Import(ModuleName, "SDL_FreeWAV")]
    public static readonly delegate* unmanaged<byte*, void> FreeWAV = null!;

    [Import(ModuleName, "SDL_BuildAudioCVT")]
    public static readonly delegate* unmanaged<AudioConverter*, ushort, byte, int, ushort, byte, int, int> BuildAudioCVT = null!;

    [Import(ModuleName, "SDL_ConvertAudio")]
    public static readonly delegate* unmanaged<AudioConverter*, int> ConvertAudio = null!;

    [Import(ModuleName, "SDL_NewAudioStream")]
    public static readonly delegate* unmanaged<ushort, byte, int, ushort, byte, int, void*> NewAudioStream = null!;

    [Import(ModuleName, "SDL_AudioStreamPut")]
    public static readonly delegate* unmanaged<void*, void*, int, int> AudioStreamPut = null!;

    [Import(ModuleName, "SDL_AudioStreamGet")]
    public static readonly delegate* unmanaged<void*, void*, int, int> AudioStreamGet = null!;

    [Import(ModuleName, "SDL_AudioStreamAvailable")]
    public static readonly delegate* unmanaged<void*, int> AudioStreamAvailable = null!;

    [Import(ModuleName, "SDL_AudioStreamFlush")]
    public static readonly delegate* unmanaged<void*, int> AudioStreamFlush = null!;

    [Import(ModuleName, "SDL_AudioStreamClear")]
    public static readonly delegate* unmanaged<void*, void> AudioStreamClear = null!;

    [Import(ModuleName, "SDL_FreeAudioStream")]
    public static readonly delegate* unmanaged<void*, void> FreeAudioStream = null!;

    [Import(ModuleName, "SDL_MixAudio")]
    public static readonly delegate* unmanaged<byte*, byte*, uint, int, void> MixAudio = null!;

    [Import(ModuleName, "SDL_MixAudioFormat")]
    public static readonly delegate* unmanaged<byte*, byte*, ushort, uint, int, void> MixAudioFormat = null!;

    [Import(ModuleName, "SDL_QueueAudio")]
    public static readonly delegate* unmanaged<uint, void*, uint, int> QueueAudio = null!;

    [Import(ModuleName, "SDL_DequeueAudio")]
    public static readonly delegate* unmanaged<uint, void*, uint, uint> DequeueAudio = null!;

    [Import(ModuleName, "SDL_GetQueuedAudioSize")]
    public static readonly delegate* unmanaged<uint, uint> GetQueuedAudioSize = null!;

    [Import(ModuleName, "SDL_ClearQueuedAudio")]
    public static readonly delegate* unmanaged<uint, void> ClearQueuedAudio = null!;

    [Import(ModuleName, "SDL_LockAudio")]
    public static readonly delegate* unmanaged<void> LockAudio = null!;

    [Import(ModuleName, "SDL_LockAudioDevice")]
    public static readonly delegate* unmanaged<uint, void> LockAudioDevice = null!;

    [Import(ModuleName, "SDL_UnlockAudio")]
    public static readonly delegate* unmanaged<void> UnlockAudio = null!;

    [Import(ModuleName, "SDL_UnlockAudioDevice")]
    public static readonly delegate* unmanaged<uint, void> UnlockAudioDevice = null!;

    [Import(ModuleName, "SDL_CloseAudio")]
    public static readonly delegate* unmanaged<void> CloseAudio = null!;

    [Import(ModuleName, "SDL_CloseAudioDevice")]
    public static readonly delegate* unmanaged<uint, void> CloseAudioDevice = null!;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GetBitSize(ushort x) {
        return (ushort) (x & MaskBitSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsFloat(ushort x) {
        return (x & MaskDataType) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsBigEndian(ushort x) {
        return (x & MaskEndian) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsSigned(ushort x) {
        return (x & MaskSigned) != 0;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AudioSpec {
        public int Freq;
        public ushort Format;
        public byte Channels;
        public byte Silence;
        public ushort Samples;
        private readonly ushort _Padding0;
        public uint Size;
        public delegate* unmanaged<void*, byte*, int, void> Callback;
        public void* UserData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AudioConverter {
        public int Needed;
        public ushort SrcFormat;
        public ushort DstFormat;
        public double RateIncr;
        public byte* Buffer;
        public int Length;
        public int LengthCvt;
        public int LengthMult;
        public double LengthRatio;
        public delegate* unmanaged<AudioConverter*, ushort>* Filters;
        public int FilterIndex;
    }
}