using OpenTK.Graphics;

namespace Qwerty.Shader;

public interface IShaderProgram {
    ProgramHandle Handle { get; }
    /// <summary>
    /// Binds the Shaders as the Active Shader Program
    /// </summary>
    void Use();
    /// <summary>
    /// Releases (Unbinds) the shader program
    /// </summary>
    void Release();
}