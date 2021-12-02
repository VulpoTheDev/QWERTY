using OpenTK.Graphics.OpenGL;

namespace Qwerty.Shader;

public class LazyUniformCache : IUniformCache {
    private readonly Dictionary<string, int> _locations = new();
    private readonly IShaderProgram _program;

    public LazyUniformCache(IShaderProgram program) {
        _program = program;
    }

    public unsafe void Set<T>(string name, params T[] value) where T : unmanaged {
        // Gets the type of T
        var valueType = typeof(T);
        var numValues = value.Length;

        // Checks the numValues and see is not below 0 nor above 4 otherwise throw an tantrum (Exception)
        if (numValues is < 1 or > 4) {
            throw new Exception("Invalid number of values");
        }

        // Get the Location of the name
        var location = GetLocation(name);

        // Weird fucked up pointer magic
        fixed (T* pValue = &value[0]) {
            // Check if the valueType is an int
            if (valueType == typeof(int)) {
                // number of values being passed
                switch (numValues) {
                    case 1:
                        GL.Uniform1i(location, *(int*) pValue);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
            else throw new Exception("Invalid value type");
        }
    }

    public bool Contains(string name) {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Checks and returns the location of the name
    /// </summary>
    /// <param name="name">name your checking</param>
    /// <returns>The location</returns>
    private int GetLocation(string name) {
        if (_locations.ContainsKey(name)) {
            return _locations[name];
        }

        var location = GL.GetUniformLocation(_program.Handle, name);
        _locations[name] = location;
        return location;
    }
}