using System.Runtime.CompilerServices;

namespace Qwerty.Utils;

public struct Optional<T>
    where T : notnull {
    private T? _value;
    public bool HasValue { get; private set; }

    private Optional(bool _ = false) { // Dirty workaround, look into alternatives
        _value = default;
        HasValue = false;
    }

    public Optional(T value) {
        _value = value;
        HasValue = true;
    }

    public void Set(T value) {
        _value = value;
        HasValue = true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Optional<T_> Empty<T_>()
        where T_ : notnull => new();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator Optional<T>(T? value) => value == null ? Empty<T>() : new(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static implicit operator T?(Optional<T> opt) => opt._value;
}