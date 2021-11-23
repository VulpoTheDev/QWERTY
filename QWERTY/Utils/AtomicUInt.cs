using System.Runtime.CompilerServices;
using System.Threading;

namespace Qwerty.Utils;

public struct AtomicUInt {
    private uint _value;

    public uint Value {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set => Interlocked.Exchange(ref _value, value);
    }

    public AtomicUInt(uint value) {
        _value = 0;
    }

    #region Implicit Conversions

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator uint(AtomicUInt value) => value.Value;

    #endregion // ^ Implicit Conversions
}