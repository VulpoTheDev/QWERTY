using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Qwerty.Utils;

/// <summary>
/// A utility class for detecting the operating system among other things.
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public static class SystemInfo {
    public static bool IsWindows {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
    }

    public static bool IsUnixoid {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD);
    }

    public static bool IsOSX {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
    }
}