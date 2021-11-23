using System;
using System.Runtime.InteropServices;
using Qwerty.Utils;

namespace Qwerty.SHAL;

/// <summary>
/// Low-level bindings to functions from SDL_render.h.<br></br>
/// For documentation, please refer to <a href="https://wiki.libsdl.org/CategoryAPI" target="_blank">the official SDL wiki.</a>
/// </summary>
/// <remarks>
/// <b>Authors:</b> Alexander Hinze<br></br>
/// <b>Created by:</b> Alexander Hinze<br></br>
/// <b>Created on:</b> 04/09/2021<br></br>
/// <b>Since:</b> 1.0.0.0
/// </remarks>
public sealed unsafe partial class SDL {
    [Flags]
    public enum RendererFlags {
        Software = 0x0000_0001,
        Accelerated = 0x0000_0002,
        PresentVSync = 0x0000_0004,
        TargetTexture = 0x0000_0008
    }

    public enum RendererFlip {
        None,
        Horizontal,
        Vertical
    }

    public enum RendererScaleMode {
        Nearest,
        Linear,
        Best
    }

    public enum RendererTextureAccess {
        Static,
        Streaming,
        Target
    }

    public enum RendererTextureModulate {
        None,
        Color,
        Alpha
    }

    [Import(ModuleName, "SDL_GetNumRenderDrivers")]
    public static readonly delegate* unmanaged<int> GetNumRenderDrivers = null!;

    [Import(ModuleName, "SDL_GetRenderDriverInfo")]
    public static readonly delegate* unmanaged<int, RendererInfo*, int> GetRenderDriverInfo = null!;

    [Import(ModuleName, "SDL_CreateWindowAndRenderer")]
    public static readonly delegate* unmanaged<int, int, RendererFlags, void**, void**, int> CreateWindowAndRenderer = null!;

    [Import(ModuleName, "SDL_CreateRenderer")]
    public static readonly delegate* unmanaged<void*, int, RendererFlags, void*> CreateRenderer = null!;

    [Import(ModuleName, "SDL_CreateSoftwareRenderer")]
    public static readonly delegate* unmanaged<Surface*, void*> CreateSoftwareRenderer = null!;

    [Import(ModuleName, "SDL_GetRenderer")]
    public static readonly delegate* unmanaged<void*, void*> GetRenderer = null!;

    [Import(ModuleName, "SDL_GetRendererInfo")]
    public static readonly delegate* unmanaged<void*, RendererInfo*, int> GetRendererInfo = null!;

    [Import(ModuleName, "SDL_GetRendererOutputSize")]
    public static readonly delegate* unmanaged<void*, int*, int*, int> GetRendererOutputSize = null!;

    [Import(ModuleName, "SDL_CreateTexture")]
    public static readonly delegate* unmanaged<void*, uint, RendererTextureAccess, int, int, void*> CreateTexture = null!;

    [Import(ModuleName, "SDL_CreateTextureFromSurface")]
    public static readonly delegate* unmanaged<void*, Surface*, void*> CreateTextureFromSurface = null!;

    [Import(ModuleName, "SDL_QueryTexture")]
    public static readonly delegate* unmanaged<void*, uint*, int*, int*, int*, int> QueryTexture = null!;

    [Import(ModuleName, "SDL_SetTextureColorMod")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, byte, byte, byte, int> SetTextureColorMod = null!;

    [Import(ModuleName, "SDL_GetTextureColorMod")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, byte*, byte*, byte*, int> GetTextureColorMod = null!;

    [Import(ModuleName, "SDL_SetTextureAlphaMod")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, byte, int> SetTextureAlphaMod = null!;

    [Import(ModuleName, "SDL_GetTextureAlphaMod")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, byte*, int> GetTextureAlphaMod = null!;

    [Import(ModuleName, "SDL_SetTextureBlendMode")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, BlendMode, int> SetTextureBlendMode = null!;

    [Import(ModuleName, "SDL_GetTextureBlendMode")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, BlendMode*, int> GetTextureBlendMode = null!;

    [Import(ModuleName, "SDL_SetTextureScaleMode")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, RendererScaleMode, int> SetTextureScaleMode = null!;

    [Import(ModuleName, "SDL_GetTextureScaleMode")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, RendererScaleMode*, int> GetTextureScaleMode = null!;

    [Import(ModuleName, "SDL_UpdateTexture")]
    public static readonly delegate* unmanaged<void*, Rect*, void*, int, int> UpdateTexture = null!;

    [Import(ModuleName, "SDL_UpdateYUVTexture")]
    public static readonly delegate* unmanaged<void*, Rect*, byte*, int, byte*, int, byte*, int, int> UpdateYuvTexture = null!;

    [Import(ModuleName, "SDL_LockTexture")]
    public static readonly delegate* unmanaged<void*, Rect*, void**, int*, int> LockTexture = null!;

    [Import(ModuleName, "SDL_LockTextureToSurface")]
    public static readonly delegate* unmanaged<void*, Rect*, Surface**, int> LockTextureToSurface = null!;

    [Import(ModuleName, "SDL_UnlockTexture")]
    public static readonly delegate* unmanaged<void*, void> UnlockTexture = null!;

    [Import(ModuleName, "SDL_RenderTargetSupported")]
    public static readonly delegate* unmanaged<void*, bool> RenderTargetSupported = null!;

    [Import(ModuleName, "SDL_SetRenderTarget")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void*, int> SetRenderTarget = null!;

    [Import(ModuleName, "SDL_GetRenderTarget")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void*> GetRenderTarget = null!;

    [Import(ModuleName, "SDL_RenderSetLogicalSize")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int, int, int> RenderSetLogicalSize = null!;

    [Import(ModuleName, "SDL_RenderGetLogicalSize")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int*, int*, void> RenderGetLogicalSize = null!;

    [Import(ModuleName, "SDL_RenderSetIntegerScale")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, bool, int> RenderSetIntegerScale = null!;

    [Import(ModuleName, "SDL_RenderGetIntegerScale")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, bool> RenderGetIntegerScale = null!;

    [Import(ModuleName, "SDL_RenderSetViewport")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, Rect*, int> RenderSetViewport = null!;

    [Import(ModuleName, "SDL_RenderGetViewport")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, Rect*, void> RenderGetViewport = null!;

    [Import(ModuleName, "SDL_RenderSetClipRect")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, Rect*, int> RenderSetClipRect = null!;

    [Import(ModuleName, "SDL_RenderGetClipRect")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, Rect*, void> RenderGetClipRect = null!;

    [Import(ModuleName, "SDL_RenderIsClipEnabled")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, bool> RenderIsClipEnabled = null!;

    [Import(ModuleName, "SDL_RenderSetScale")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, float, float, int> RenderSetScale = null!;

    [Import(ModuleName, "SDL_RenderGetScale")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, float*, float*, void> RenderGetScale = null!;

    [Import(ModuleName, "SDL_SetRenderDrawColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, byte, byte, byte, byte, int> SetRenderDrawColor = null!;

    [Import(ModuleName, "SDL_GetRenderDrawColor")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, byte*, byte*, byte*, byte*, int> GetRenderDrawColor = null!;

    [Import(ModuleName, "SDL_SetRenderDrawBlendMode")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, BlendMode, int> SetRenderDrawBlendMode = null!;

    [Import(ModuleName, "SDL_GetRenderDrawBlendMode")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, BlendMode, int> GetRenderDrawBlendMode = null!;

    [Import(ModuleName, "SDL_RenderClear")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, int> RenderClear = null!;

    [Import(ModuleName, "SDL_RenderDrawPoint")]
    public static readonly delegate* unmanaged<void*, int, int, int> RenderDrawPoint = null!;

    [Import(ModuleName, "SDL_RenderDrawPoints")]
    public static readonly delegate* unmanaged<void*, Point*, int, int> RenderDrawPoints = null!;

    [Import(ModuleName, "SDL_RenderDrawLine")]
    public static readonly delegate* unmanaged<void*, int, int, int, int, int> RenderDrawLine = null!;

    [Import(ModuleName, "SDL_RenderDrawLines")]
    public static readonly delegate* unmanaged<void*, Point*, int, int> RenderDrawLines = null!;

    [Import(ModuleName, "SDL_RenderDrawRect")]
    public static readonly delegate* unmanaged<void*, Rect*, int> RenderDrawRect = null!;

    [Import(ModuleName, "SDL_RenderDrawRects")]
    public static readonly delegate* unmanaged<void*, Rect*, int, int> RenderDrawRects = null!;

    [Import(ModuleName, "SDL_RenderFillRect")]
    public static readonly delegate* unmanaged<void*, Rect*, int> RenderFillRect = null!;

    [Import(ModuleName, "SDL_RenderFillRects")]
    public static readonly delegate* unmanaged<void*, Rect*, int, int> RenderFillRects = null!;

    [Import(ModuleName, "SDL_RenderCopy")]
    public static readonly delegate* unmanaged<void*, void*, Rect*, Rect*, int> RenderCopy = null!;

    [Import(ModuleName, "SDL_RenderCopyEx")]
    public static readonly delegate* unmanaged<void*, void*, Rect*, Rect*, double, Point*, RendererFlip, int> RenderCopyEx = null!;

    [Import(ModuleName, "SDL_RenderDrawPointF")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, float, float, int> RenderDrawPointF = null!;

    [Import(ModuleName, "SDL_RenderDrawPointsF")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, FPoint*, int, int> RenderDrawPointsF = null!;

    [Import(ModuleName, "SDL_RenderDrawLineF")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, float, float, float, float, int> RenderDrawLineF = null!;

    [Import(ModuleName, "SDL_RenderDrawLinesF")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, FPoint*, int, int> RenderDrawLinesF = null!;

    [Import(ModuleName, "SDL_RenderDrawRectF")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, FRect*, int> RenderDrawRectF = null!;

    [Import(ModuleName, "SDL_RenderDrawRectsF")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, FRect*, int, int> RenderDrawRectsF = null!;

    [Import(ModuleName, "SDL_RenderFillRectF")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, FRect*, int> RenderFillRectF = null!;

    [Import(ModuleName, "SDL_RenderFillRectsF")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, FRect*, int, int> RenderFillRectsF = null!;

    [Import(ModuleName, "SDL_RenderCopyF")]
    public static readonly delegate* unmanaged<void*, void*, Rect*, FRect*, int> RenderCopyF = null!;

    [Import(ModuleName, "SDL_RenderCopyExF")]
    public static readonly delegate* unmanaged<void*, void*, Rect*, FRect*, double, FPoint*, RendererFlip, int> RenderCopyExF = null!;

    [Import(ModuleName, "SDL_RenderReadPixels")]
    public static readonly delegate* unmanaged<void*, Rect*, uint, void*, int, int> RenderReadPixels = null!;

    [Import(ModuleName, "SDL_RenderPresent")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void> RenderPresent = null!;

    [Import(ModuleName, "SDL_DestroyTexture")]
    public static readonly delegate* unmanaged<void*, void> DestroyTexture = null!;

    [Import(ModuleName, "SDL_DestroyRenderer")]
    public static readonly delegate* unmanaged<void*, void> DestroyRenderer = null!;

    [Import(ModuleName, "SDL_RenderFlush")]
    public static readonly delegate* unmanaged<void*, int> RenderFlush = null!;

    [Import(ModuleName, "SDL_GL_BindTexture")]
    public static readonly delegate* unmanaged<void*, float*, float*, int> GlBindTexture = null!;

    [Import(ModuleName, "SDL_GL_UnbindTexture")]
    public static readonly delegate* unmanaged<void*, int> GlUnbindTexture = null!;

    [Import(ModuleName, "SDL_RenderGetMetalLayer")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void*> RenderGetMetalLayer = null!;

    [Import(ModuleName, "SDL_RenderGetMetalCommandEncoder")]
    public static readonly delegate* unmanaged[SuppressGCTransition]<void*, void*> RenderGetMetalCommandEncoder = null!;

    [StructLayout(LayoutKind.Sequential)]
    public struct RendererInfo {
        public void* Name;
        public RendererFlags Flags;
        public uint NumTexFormats;
        public fixed uint TexFormats[16];
        public int MaxTexWidth;
        public int MaxTexHeight;
    }
}