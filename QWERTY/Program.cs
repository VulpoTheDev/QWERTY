using NLog;
using NLog.Config;
using NLog.Targets;
using Qwerty.SHAL;

namespace Qwerty;

internal static unsafe class Program {
    public static Logger Logger { get; private set; }

    public static GameWindow Window { get; private set; }

    public static void Main(string[] args) {
        // Create logger configuration and set it in the global log manager
        var config = new LoggingConfiguration();
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, new ConsoleTarget("console"));
        config.AddRule(LogLevel.Info, LogLevel.Fatal, new FileTarget("file") {FileName = "latest.log"});
        LogManager.Configuration = config;
        // Create the game's logger
        Logger = LogManager.GetLogger("QWERTY");

        // 1 = True; Force Enables Double Buffer
        SDL.GlSetAttribute(SDL.GlAttribute.DoubleBuffer, 1);
        
        // Force each color channel to be 8 bits so we have a 32 bit colors
        SDL.GlSetAttribute(SDL.GlAttribute.RedSize, 8);
        SDL.GlSetAttribute(SDL.GlAttribute.GreenSize, 8);
        SDL.GlSetAttribute(SDL.GlAttribute.BlueSize, 8);
        SDL.GlSetAttribute(SDL.GlAttribute.AlphaSize, 8);
        
        // OPENGL Version (OpenGL 4.6 Core)
        SDL.GlSetAttribute(SDL.GlAttribute.ContextProfileMask, (int)SDL.GlProfile.Core);
        SDL.GlSetAttribute(SDL.GlAttribute.ContextMajorVersion, 4);
        SDL.GlSetAttribute(SDL.GlAttribute.ContextMinorVersion, 6);

        SDL.Validate(SDL.Init(SDL.InitFlag.Events | SDL.InitFlag.Video));
        Window = new GameWindow();
        Window.Show();
        Window.Dispose();
        SDL.Quit();
    }
}