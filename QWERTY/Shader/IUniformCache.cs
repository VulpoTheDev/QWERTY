namespace Qwerty.Shader; 

/**
 * Contains functions to uniform variables when
 * using a <see cref="IShaderProgram"/>.
 */
public interface IUniformCache {
    /// <summary>
    /// Set a value in the uniform cache, or if the
    /// given name is not contained within the internal
    /// map, create a new cache entry.
    ///
    /// <code>where T : unmanaged</code> being a generic type
    /// constraint, meaning you can pass in any primitive-
    /// or value-type like int, float, bool etc. as well
    /// as unmanaged value-types like structures.
    ///
    /// <code>params</code> before an array parameter indicates
    /// that the given array has a variable length, and thus
    /// also needs to be placed at the end of the parameter list.
    /// > Needs to be the last parameter - always! (Except when
    /// it's the only parameter.)
    /// </summary>
    /// <param name="name">The name of the uniform. May not be empty nor duplicated.</param>
    /// <param name="value">The value of the uniform to be changed.</param>
    void Set<T>(string name, params T[] value) where T : unmanaged;

    /// <summary>
    /// Checks whether or not the given uniform entry
    /// is present within the internal map.
    /// </summary>
    /// <param name="name">The name of the uniform to be checked.</param>
    /// <returns>True if the given uniform name is present.</returns>
    bool Contains(string name);
}