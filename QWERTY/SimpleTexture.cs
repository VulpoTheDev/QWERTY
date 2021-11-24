using System.Drawing;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Qwerty;

public unsafe struct SimpleTexture : ITexture {
    public Size Size { get; }
    public TextureHandle Handle { get; }

    public SimpleTexture(Size size) {
        Size = size;
        Handle = GL.GenTexture();
        if (Handle == TextureHandle.Zero) throw new("Could not allocate texture");
    }

    private void Init()
    {
        // Binds this texture as the current texture in GL
        // We use a 2-dimensional texture, so we specify that as well
        GL.BindTexture(TextureTarget.Texture2d, Handle);

        // Set the min- and mag-filter to nearest, so we get crisp pixels
        // on our sprite later on when rendering it. Anything apart from nearest,
        // will apply some type of image interpolation and introduce blur.
        GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
        GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);

        // S/T == U/V == X/Y for textures, or rather texels
        // If we overdraw, meaning a polygon (quad/sprite), that is bigger than the texture,
        // we want the texture to repeat endlesslessly to make it seemless for map tiles etc.
        GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
        GL.TexParameteri(TextureTarget.Texture2d, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);

        // Take the size of the texture and throw it onto the stack to re-use it
        var w = Size.Width;
        var h = Size.Height;

        // Calculate the byte-size of the memory we need to allocate for the texture
        // > width * height * number of channels
        // > Optimization: shift the result two bits to the left, two times, so we * 4
        var memory = stackalloc float[(w * h) << 2];
        // Copy the stack memory to our target texture's V-RAM
        GL.TexImage2D(TextureTarget.Texture2d, 0, (int)InternalFormat.Rgba32f, w, h, 0, PixelFormat.Rgba, PixelType.Float, memory);
        // Release/Unbinds the texture to free those limited Texture units
        GL.BindTexture(TextureTarget.Texture2d, TextureHandle.Zero);
    }

    public void Dispose() => GL.DeleteTexture(Handle);
}