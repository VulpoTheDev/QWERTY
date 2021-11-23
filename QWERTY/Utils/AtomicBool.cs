using System.Runtime.CompilerServices;
using System.Threading;

namespace Qwerty.Utils;

public struct AtomicBool {
    private int _value;

    public bool Value {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _value == 1;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set {
            if (value) Interlocked.Exchange(ref _value, 1);
            else Interlocked.Exchange(ref _value, 0);
        }
    }

    public AtomicBool(bool value) {
        _value = value ? 1 : 0;
    }

    #region Implicit Conversions

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator bool(AtomicBool value) => value._value == 1;

    #endregion // ^ Implicit Conversions
}