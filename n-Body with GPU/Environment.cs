using System;
using System.Collections.Generic;
using System.Text;

namespace n_Body_with_GPU
{
    class Environment
    {
        const double G = 0.00000001;

        public Particle[] particles;

        public Environment(int particleAmount)
        {
            particles = new Particle[particleAmount];

            Random rng = new Random();

            for (int i = 0; i < particleAmount; i++)
            {
                particles[i] = new Particle(rng.NextDouble(), rng.NextDouble(), rng.NextDouble());
            }

            //particles[particleAmount] = new Particle(0.5, 0.5, 500);
        }

        public void Move()
        {
            for (int i = 0; i < particles.Length; i++)
            {
                particles[i].Move();
            }
        }

        public void Attract()
        {
            /*Parallel.For(0, particles.Length, i =>
            {
                double sumX = 0, sumY = 0;
                for (int j = 0; j < particles.Length; j++)
                {
                    if (i == j)
                        continue;

                    double distanceX = particles[j].x - particles[i].x;
                    double distanceY = particles[j].y - particles[i].y;
                    double dist = Math.Pow(distanceX * distanceX + distanceY * distanceY, 1.5);

                    sumX += G * particles[j].mass * distanceX / (dist + 0.00001);
                    sumY += G * particles[j].mass * distanceY / (dist + 0.00001);
                }

                particles[i].vx += sumX;
                particles[i].vy += sumY;
            });*/
        }
    }
}
