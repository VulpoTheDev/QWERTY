using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;

namespace Qwerty.Utils;

/// <summary>
/// A marker attribute for marking fields to inject native functions into.
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
[AttributeUsage(AttributeTargets.Field)]
public sealed class Import : Attribute {
    public readonly string? EntryPoint;
    public readonly string ModuleName;

    public Import(string moduleName, string? entryPoint = null) {
        ModuleName = moduleName;
        EntryPoint = entryPoint;
    }
}

/// <summary>
/// A simple cross-platform library loader for loading native libraries
/// with multiple names and retrieving/injecting their functions as unmanaged
/// delegate pointers to achieve the best possible performance.
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe class LibraryLoader : IDisposable {
    private bool _isDisposed;

    public readonly string ModuleName;
    public readonly string[] Names;
    public readonly IntPtr Handle;

    public LibraryLoader(string moduleName, Func<string[]> nameProvider) {
        ModuleName = moduleName;
        Names = nameProvider();
        Handle = TryLoadLibrary(Names);
        if (Handle == IntPtr.Zero) throw new Exception("Could not load native library");
    }

    ~LibraryLoader() {
        Dispose();
    }

    public void Dispose() {
        if (_isDisposed) return;
        NativeLibrary.Free(Handle);
        _isDisposed = true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void LoadFunctionsFor(Type type) {
        foreach (var field in type.GetFields()) {
            var attrib = field.GetCustomAttribute<Import>();
            if (attrib == null) continue;
            if (attrib.ModuleName != ModuleName) continue;
            if (!IsValidFunctionField(field)) continue;

            var functionName = attrib.EntryPoint ?? field.Name;
            var function = GetFunction(functionName);

            if (function == null) {
                Program.Logger.Error($"Cannot bind to {field} - no such function, skipping");
                continue;
            }

            field.SetValue(null, new IntPtr(function));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void* GetFunction(string name) {
        if (!NativeLibrary.TryGetExport(Handle, name, out var function)) return null;
        return function.ToPointer();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool IsValidFunctionField(FieldInfo field) {
        if (!field.IsPublic) {
            Program.Logger.Error($"Cannot bind to {field} - field must be public, skipping");
            return false;
        }

        if (!field.IsStatic) {
            Program.Logger.Error($"Cannot bind to {field} - field must be static, skipping");
            return false;
        }

        if (!field.IsInitOnly) {
            Program.Logger.Error($"Cannot bind to {field} - field must be readonly, skipping");
            return false;
        }

        return true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static IntPtr TryLoadLibrary(string[] names) {
        var assembly = Assembly.GetExecutingAssembly();

        foreach (var name in names) {
            if (!NativeLibrary.TryLoad(name, assembly, null, out var handle)) {
                Program.Logger.Info($"Library loader miss: {name}");
                continue;
            }

            Program.Logger.Info($"Library loader success: {name}");
            return handle;
        }

        return IntPtr.Zero;
    }
}