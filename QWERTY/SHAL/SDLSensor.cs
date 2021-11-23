using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_sensor.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    public enum SensorType {
        Invalid = -0x0000_0001,
        Unknown,
        Accel,
        Gyro
    }

    public const float StandardGravity = 9.80665F;

    [Import(ModuleName, "SDL_LockSensors")]
    public static readonly delegate* unmanaged<void> LockSensors = null!;

    [Import(ModuleName, "SDL_UnlockSensors")]
    public static readonly delegate* unmanaged<void> UnlockSensors = null!;

    [Import(ModuleName, "SDL_NumSensors")]
    public static readonly delegate* unmanaged<int> NumSensors = null!;

    [Import(ModuleName, "SDL_SensorGetDeviceName")]
    public static readonly delegate* unmanaged<int, void*> SensorGetDeviceName = null!;

    [Import(ModuleName, "SDL_SensorGetDeviceType")]
    public static readonly delegate* unmanaged<int, SensorType> SensorGetDeviceType = null!;

    [Import(ModuleName, "SDL_SensorGetDeviceNonPortableType")]
    public static readonly delegate* unmanaged<int, int> SensorGetDeviceNonPortableType = null!;

    [Import(ModuleName, "SDL_SensorGetDeviceInstanceID")]
    public static readonly delegate* unmanaged<int, long> SensorGetDeviceInstanceId = null!;

    [Import(ModuleName, "SDL_SensorOpen")]
    public static readonly delegate* unmanaged<int, void*> SensorOpen = null!;

    [Import(ModuleName, "SDL_SensorFromInstanceID")]
    public static readonly delegate* unmanaged<long, void*> SensorFromInstanceId = null!;

    [Import(ModuleName, "SDL_SensorGetName")]
    public static readonly delegate* unmanaged<void*, void*> SensorGetName = null!;

    [Import(ModuleName, "SDL_SensorGetType")]
    public static readonly delegate* unmanaged<void*, SensorType> SensorGetType = null!;

    [Import(ModuleName, "SDL_SensorGetNonPortableType")]
    public static readonly delegate* unmanaged<void*, int> SensorGetNonPortableType = null!;

    [Import(ModuleName, "SDL_SensorGetInstanceID")]
    public static readonly delegate* unmanaged<void*, long> SensorGetInstanceId = null!;

    [Import(ModuleName, "SDL_SensorGetData")]
    public static readonly delegate* unmanaged<void*, float*, int, int> SensorGetData = null!;

    [Import(ModuleName, "SDL_SensorClose")]
    public static readonly delegate* unmanaged<void*, void> SensorClose = null!;

    [Import(ModuleName, "SDL_SensorUpdate")]
    public static readonly delegate* unmanaged<void> SensorUpdate = null!;
}