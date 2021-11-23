using System.Runtime.CompilerServices;
using System.Threading;

namespace Qwerty.Utils;

public struct AtomicInt {
    private int _value;

    public int Value {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set => Interlocked.Exchange(ref _value, value);
    }

    public AtomicInt(int value) {
        _value = 0;
    }

    #region Implicit Conversions

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator int(AtomicInt value) => value.Value;

    #endregion // ^ Implicit Conversions
}