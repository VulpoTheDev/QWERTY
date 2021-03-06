using System.Drawing;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using Qwerty.SHAL;
using Qwerty.Utils;

namespace Qwerty;

public unsafe class GameWindow : IDisposable {
    // This is to make sure this thing doesn't kill itself lmao
    private bool _isDisposed;
    // Void = Blind Type (Unknowoned Type)'s with Address
    private void* _handle;
    // Is the game still running? (should the main loop continue to be executed?)
    private bool _isRunning;
    // The structure which provides frame timing and a delta time value for physics
    private FrameTimer _frameTimer = new();
    // A pointer to the current OpenGL context
    private void* _glContext;
    // A test texture
    private SimpleTexture _texture;

    public GameWindow() {
        // Allocate stack memory for the given string, and copy the contents of the given string into said memory
        fixed(byte* pTitle = Encoding.UTF8.GetBytes("QWERTY")) {
            // Create a new native window with the given title (C-equiv. const char*), x-pos, y-pos, width, height and
            // the window flags. We want our window to be hidden initially while things are still being initialized,
            // and we also want the window to be associated with a new OpenGL context.
            _handle = SDL.CreateWindow(pTitle, (int)SDL.WindowPosCenter, (int)SDL.WindowPosCenter, 1200, 800, SDL.WindowFlag.Shown | SDL.WindowFlag.OpenGl);
        }
        
        // Make sure our window handle is not null, otherwise throw the current SDL error as an exception
        SDL.Validate(_handle != null);
        // Create a new OpenGL context for the current window
        _glContext = SDL.GlCreateContext(_handle);
        // Make sure our OpenGL context was created
        SDL.Validate(_glContext != null);
        // Load the OpenGL bindings from the current GL context, making all GL functions usable
        GLLoader.LoadBindings(new BindingsContextImpl());

        _texture = new SimpleTexture(new Size(32, 32));
    }

    // Method that runs when the Game Window gets Garbage Collected
    ~GameWindow() {
        Dispose();
    }
    
    // Called to make the window visible after initializing it's internals
    public void Show() {
        // Set the running state to true before we enter our outer main loop
        _isRunning = true;
        // Define a width and height variable for the area of the window
        // we want to render to, that is the entire area of the window minus
        // title bar and border(s).
        int vpWidth;
        int vpHeight;
        SDL.GlGetDrawableSize(_handle, &vpWidth, &vpHeight);
        // Set up the OpenGL viewport with the size we just retrieved.
        GL.Viewport(0, 0, vpWidth, vpHeight);

        GL.ClearColor(0F, 0F, 0F, 1F);
        // As the game is running...
        while(_isRunning) {
            // We define an unpopulated event on the stack..
            SDL.Event currentEvent;
            // While we have events to process..
            // (..take the address of currentEvent and populate it with data)
            while(SDL.PollEvent(&currentEvent) > 0) {
                // Switch on the event type of the current event being processed
                switch(currentEvent.Type) {
                    // If we have a quit event, break the outer most loop by
                    // setting _isRunning to false.
                    case SDL.EventType.Quit:
                        _isRunning = false;
                        break;
                }
            }

            // Let the frame timer know we began rendering a new frame
            _frameTimer.StartFrame();
            // Clear the back buffer to the clear color
            GL.Clear(ClearBufferMask.ColorBufferBit);
            // Render the actual scene
            Render(_frameTimer.DeltaTime);
            // Define a display mode on the stack..
            SDL.DisplayMode displayMode;
            // ..and populate it with data frm the current window's display mode.
            SDL.Validate(SDL.GetWindowDisplayMode(_handle, &displayMode));
            // Let the frame timer know we're done rendering the new frame.
            _frameTimer.EndFrame(displayMode.RefreshRate);
            // Swap back- and front-buffer, so we get to see the next frame!
            SDL.GlSwapWindow(_handle);
        }
    }

    private void Render(float deltaTime) {

    }

    // Runs when the Program's Main Function gets terminated
    public void Dispose() {
        // Guard to make sure the Window doesn't kill itself.. again
        if(_isDisposed) return;
        _texture.Dispose();
        SDL.GlDeleteContext(_glContext); // Destroy the window's OpenGL context
        SDL.DestroyWindow(_handle); // Destroy the native window instance to free memory
        _isDisposed = true;
    }

    // TODO: document this when we go into GL
    private class BindingsContextImpl : IBindingsContext {
        public IntPtr GetProcAddress(string procName) {
            fixed(byte* pProcName = Encoding.UTF8.GetBytes(procName)) {
                return new IntPtr(SDL.GlGetProcAddress(pProcName));
            }
        }
    }
}