namespace Qwerty.Utils;

public static unsafe class SystemLibrary {
    private const string _ModuleName = "cstdlib";

    private static readonly LibraryLoader _Loader = new(_ModuleName, () => {
        if (SystemInfo.IsWindows) return new[] {"msvcrt.dll", "msvcrt140.dll"};
        return SystemInfo.IsOSX ? new[] {"libSystem.dylib"} : new[] {"libc.so.6", "libc.so"};
    });

    static SystemLibrary() {
        _Loader.LoadFunctionsFor(typeof(SystemLibrary));
    }

    [Import(_ModuleName, "malloc")]
    public static readonly delegate* unmanaged<nuint, void*> MAlloc = null!;

    [Import(_ModuleName, "calloc")]
    public static readonly delegate* unmanaged<nuint, nuint, void*> CAlloc = null!;

    [Import(_ModuleName, "realloc")]
    public static readonly delegate* unmanaged<void*, nuint, void*> ReAlloc = null!;

    [Import(_ModuleName, "free")]
    public static readonly delegate* unmanaged<void*, void> Free = null!;

    [Import(_ModuleName, "memcpy")]
    public static readonly delegate* unmanaged<void*, void*, nuint, void*> MemCpy = null!;

    [Import(_ModuleName, "memset")]
    public static readonly delegate* unmanaged<void*, int, nuint, void*> MemSet = null!;

    [Import(_ModuleName, "memmove")]
    public static readonly delegate* unmanaged<void*, void*, nuint, void*> MemMove = null!;

    [Import(_ModuleName, "strlen")]
    public static readonly delegate* unmanaged<void*, nuint> StrLen = null!;
}