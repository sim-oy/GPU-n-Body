using System;
using System.Collections.Generic;
using System.Text;
using GLFW;
using static OpenGL.GL;
using System.Numerics;

namespace n_Body_with_GPU
{
    static class DisplayWindow
    {
        const int WINDOW_WIDTH = 500;
        const int WINDOW_HEIGHT = 500;

        public static Window Window { get; set; }
        public static Vector2 WindowSize { get; set; }

        private static void PrepareContext()
        {
            // Set some common hints for the OpenGL profile creation
            Glfw.WindowHint(Hint.ClientApi, ClientApi.OpenGL);
            Glfw.WindowHint(Hint.ContextVersionMajor, 3);
            Glfw.WindowHint(Hint.ContextVersionMinor, 3);
            Glfw.WindowHint(Hint.OpenglProfile, Profile.Core);
            Glfw.WindowHint(Hint.Doublebuffer, true);
            Glfw.WindowHint(Hint.Decorated, true);
        }

        public static void CreateWindow()
        {
            WindowSize = new Vector2(WINDOW_WIDTH, WINDOW_HEIGHT);

            Glfw.Init();

            PrepareContext();

            // Create window, make the OpenGL context current on the thread, and import graphics functions
            Window = Glfw.CreateWindow(WINDOW_WIDTH, WINDOW_HEIGHT, "N-Body simulation", Monitor.None, Window.None);

            if (Window == Window.None)
            {
                return;
            }

            // Center window
            var screen = Glfw.PrimaryMonitor.WorkArea;
            var x = (screen.Width - WINDOW_WIDTH) / 2;
            var y = (screen.Height - WINDOW_HEIGHT) / 2;
            Glfw.SetWindowPosition(Window, x, y);

            Glfw.MakeContextCurrent(Window);
            Import(Glfw.GetProcAddress);

            glViewport(0, 0, WINDOW_WIDTH, WINDOW_HEIGHT);
            Glfw.SwapInterval(0); //Vsync off
        }

        public static void CloseWindow()
        {
            Glfw.Terminate();
        }
    }
}
