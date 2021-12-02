using System.Drawing;
using OpenTK.Graphics;

namespace Qwerty;

/// <summary>
/// A base interface for all texture objects in the game.
/// Also extends <see cref="IDisposable"/>.
/// </summary>
public interface ITexture : IDisposable {
    /// <summary>
    /// The size of this texture in texels.
    /// </summary>
    Size Size { get; }

    /// <summary>
    /// The internal OpenGL handle of this texture.
    /// </summary>
    TextureHandle Handle { get; }
}