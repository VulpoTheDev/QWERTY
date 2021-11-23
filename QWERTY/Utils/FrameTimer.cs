using System.Runtime.CompilerServices;
using Qwerty.SHAL;

namespace Qwerty.Utils;

public unsafe struct FrameTimer {
    private uint _startTime;
    private uint _frameTime;

    public float DeltaTime {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _frameTime * 0.001F;
    }

    public FrameTimer() {
        _startTime = 0;
        _frameTime = 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void StartFrame() {
        _startTime = SDL.GetTicks();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void EndFrame(int refreshRate) {
        _frameTime = SDL.GetTicks() - _startTime;

        var targetTime = 1000 / refreshRate;

        if (_frameTime < targetTime) {
            SDL.Delay((uint) targetTime - _frameTime);
        }
    }
}