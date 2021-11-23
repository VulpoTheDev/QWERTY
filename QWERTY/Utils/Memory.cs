using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Qwerty.Utils;

public static unsafe class Memory {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte* StringToHGlobalUTF8(string s) {
        var size = (nuint) s.Length + 1;
        var memory = CAlloc<byte>(size);

        fixed (byte* data = Encoding.UTF8.GetBytes(s)) {
            Copy(memory, data, size);
        }

        return memory;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* MAlloc<T>(nuint size)
        where T : unmanaged {
        return (T*) SystemLibrary.MAlloc(size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* CAlloc<T>(nuint size)
        where T : unmanaged {
        return (T*) SystemLibrary.CAlloc(size / (nuint) sizeof(T), (nuint) sizeof(T));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* ReAlloc<T>(T* mem, nuint size)
        where T : unmanaged {
        return (T*) SystemLibrary.ReAlloc(mem, size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Free(void* mem) {
        SystemLibrary.Free(mem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* Copy<T>(T* dst, T* src, nuint size)
        where T : unmanaged {
        return (T*) SystemLibrary.MemCpy(dst, src, size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* Set<T>(T* mem, byte value, nuint size)
        where T : unmanaged {
        return (T*) SystemLibrary.MemSet(mem, value, size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T* Move<T>(T* dst, T* src, nuint size)
        where T : unmanaged {
        return (T*) SystemLibrary.MemMove(dst, src, size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CopyFromArray<T>(ref T[] array, T* memory, nuint srcOffset = 0, nuint dstOffset = 0, nint length = -1)
        where T : unmanaged {
        if (memory == null) return;
        var numElements = length == -1 ? array.Length : length;

        fixed (T* pArray = array) {
            var pDst = (byte*) memory + dstOffset;
            var pSrc = (byte*) pArray + srcOffset;
            SystemLibrary.MemCpy(pDst, pSrc, (nuint) (numElements * sizeof(T)));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CopyFromSpan<T>(ref Span<T> span, T* memory, nuint srcOffset = 0, nuint dstOffset = 0, nint length = -1)
        where T : unmanaged {
        if (memory == null) return;
        var numElements = length == -1 ? span.Length : length;

        fixed (T* pSpan = span) {
            var pDst = (byte*) memory + dstOffset;
            var pSrc = (byte*) pSpan + srcOffset;
            SystemLibrary.MemCpy(pDst, pSrc, (nuint) (numElements * sizeof(T)));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CopyToArray<T>(T* memory, ref T[] array, nuint srcOffset = 0, nuint dstOffset = 0, nint length = -1)
        where T : unmanaged {
        if (memory == null) return;
        var numElements = length == -1 ? array.Length : length;

        fixed (T* pArray = array) {
            var pDst = (byte*) pArray + dstOffset;
            var pSrc = (byte*) memory + srcOffset;
            SystemLibrary.MemCpy(pDst, pSrc, (nuint) (numElements * sizeof(T)));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CopyToSpan<T>(T* memory, ref Span<T> span, nuint srcOffset = 0, nuint dstOffset = 0, nint length = -1)
        where T : unmanaged {
        if (memory == null) return;
        var numElements = length == -1 ? span.Length : length;

        fixed (T* pSpan = span) {
            var pDst = (byte*) pSpan + dstOffset;
            var pSrc = (byte*) memory + srcOffset;
            SystemLibrary.MemCpy(pDst, pSrc, (nuint) (numElements * sizeof(T)));
        }
    }
}