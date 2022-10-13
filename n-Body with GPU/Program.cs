using System;
using System.Collections.Generic;
using System.Text;
using GLFW;
using static OpenGL.GL;
using System.Numerics;

namespace n_Body_with_GPU
{
    class Program
    {
        static void Main()
        {

            //Environment env = new Environment(2000);

            Initalize();

            DisplayWindow.CreateWindow();

            LoadContent();

            while (!Glfw.WindowShouldClose(DisplayWindow.Window))
            {
                Update();

                Glfw.PollEvents();

                Render();
            }

            DisplayWindow.CloseWindow();
        }




        private static void Initalize()
        {
        }

        private unsafe static void LoadContent()
        {
            string vertexShader = @"#version 330 core
                                    layout (location = 0) in vec2 aPosition;
                                    layout (location = 1) in vec3 aColor;
                                    out vec4 vertexColor;
    
                                    void main() 
                                    {
                                        vertexColor = vec4(aColor.rgb, 1.0);
                                        gl_Position = vec4(aPosition.xy, 0, 1.0);
                                    }";

            string fragmentShader = @"#version 330 core
                                    out vec4 FragColor;
                                    in vec4 vertexColor;

                                    void main() 
                                    {
                                        FragColor = vertexColor;
                                    }";



        }
        private static void Update()
        {
        }

        private static void Render()
        {
        }





        /*
        static void DrawEnvironment(Environment env)
        {
            DrawParticles(env);
        }

        static void DrawParticles(Environment env)
        {
            foreach (Particle particle in env.particles)
            {
                if (particle.x < 0 || particle.x >= 1.0 || particle.y < 0 || particle.y >= 1.0)
                    continue;

                int x = (int)(particle.x * WINDOW_WIDTH);
                int y = (int)(particle.y * WINDOW_HEIGHT);

                int index = (y * WINDOW_WIDTH + x) * 4;

                windowBuffer[index] = 255;
                windowBuffer[index + 1] = 255;
                windowBuffer[index + 2] = 255;
                windowBuffer[index + 3] = 255;
            }
        }*/

    }
}
