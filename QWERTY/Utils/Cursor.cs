using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Qwerty.SHAL;

namespace Qwerty.Utils;

public sealed unsafe class Cursor : IDisposable {
    [AttributeUsage(AttributeTargets.Property)]
    private sealed class BuiltIn : Attribute {
        public readonly SDL.SystemCursor Type;

        public BuiltIn(SDL.SystemCursor type) {
            Type = type;
        }
    }

    [BuiltIn(SDL.SystemCursor.Arrow)]
    public static Cursor Arrow {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    [BuiltIn(SDL.SystemCursor.IBeam)]
    public static Cursor Beam {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    [BuiltIn(SDL.SystemCursor.Wait)]
    public static Cursor Wait {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    [BuiltIn(SDL.SystemCursor.CrossHair)]
    public static Cursor CrossHair {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    [BuiltIn(SDL.SystemCursor.WaitArrow)]
    public static Cursor WaitArrow {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    [BuiltIn(SDL.SystemCursor.SizeNwse)]
    public static Cursor SizeNwse {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    [BuiltIn(SDL.SystemCursor.SizeNesw)]
    public static Cursor SizeNesw {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    [BuiltIn(SDL.SystemCursor.SizeWe)]
    public static Cursor SizeWe {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    [BuiltIn(SDL.SystemCursor.SizeNs)]
    public static Cursor SizeNs {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    [BuiltIn(SDL.SystemCursor.SizeAll)]
    public static Cursor SizeAll {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    [BuiltIn(SDL.SystemCursor.No)]
    public static Cursor None {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    [BuiltIn(SDL.SystemCursor.Hand)]
    public static Cursor Hand {
        get;
        [UsedImplicitly]
        private set;
    } = null!;

    private static readonly List<Cursor> _Cursors = new();
    private static Cursor? _Default;

    private bool _isDisposed;
    private readonly void* _handle;

    private Cursor(void* handle) {
        _handle = handle;
    }

    ~Cursor() {
        Dispose();
    }

    public void Dispose() {
        if (_isDisposed) return;
        SDL.FreeCursor(_handle);
        _isDisposed = true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Show() => SDL.SetCursor(_handle);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Reset() => Default().Show();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Cursor Default() {
        if (_Default == null) {
            var handle = SDL.GetDefaultCursor();
            if (handle == null) SDL.ThrowCurrentError();
            _Default = new Cursor(handle);
        }

        return _Default;
    }

    internal static void LoadCursors() {
        foreach (var prop in typeof(Cursor).GetProperties()) {
            var method = prop.SetMethod;
            if (method == null || !method.IsStatic || prop.PropertyType != typeof(Cursor)) continue;

            var attrib = prop.GetCustomAttribute<BuiltIn>();
            if (attrib == null) continue;

            var cursorHandle = SDL.CreateSystemCursor(attrib.Type);
            if (cursorHandle == null) throw new("Could not load system cursor");

            var cursor = new Cursor(cursorHandle);
            prop.SetValue(null, cursor);
            _Cursors.Add(cursor);
        }
    }

    internal static void UnloadCursors() {
        foreach (var cursor in _Cursors) {
            cursor.Dispose();
        }
    }
}