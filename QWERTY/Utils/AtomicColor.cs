using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Qwerty.Utils;

public struct AtomicColor {
    private uint _value;

    public uint Value {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _value;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set => Interlocked.Exchange(ref _value, value);
    }

    public AtomicColor(uint value) {
        _value = value;
    }

    public AtomicColor(Color color) : this((uint) color.ToArgb()) { }

    #region Implicit Conversions

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator uint(AtomicColor color) => color._value;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Color(AtomicColor color) => Color.FromArgb((int) color._value);

    #endregion // ^ Implicit Conversions
}