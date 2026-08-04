using System;

namespace PhysicsSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Motion Simulation - Projectile");
            Console.Write("Initial speed (m/s): ");
            double speed = double.Parse(Console.ReadLine() ?? "50");
            Console.Write("Launch angle (degrees): ");
            double angleDegrees = double.Parse(Console.ReadLine() ?? "45");
            Console.Write("Time step (s): ");
            double dt = double.Parse(Console.ReadLine() ?? "0.01");

            double angle = angleDegrees * Math.PI / 180.0;
            double vx = speed * Math.Cos(angle);
            double vy = speed * Math.Sin(angle);
            double x = 0.0;
            double y = 0.0;
            double g = 9.81;

            Console.WriteLine();
            Console.WriteLine("Time\tX\tY\tVx\tVy");
            
            double time = 0.0;
            while (y >= 0.0)
            {
                Console.WriteLine($"{time:F2}\t{x:F2}\t{y:F2}\t{vx:F2}\t{vy:F2}");
                x += vx * dt;
                y += vy * dt;
                vy -= g * dt;
                time += dt;

                if (y < 0)
                {
                    y = 0;
                    Console.WriteLine($"{time:F2}\t{x:F2}\t{y:F2}\t{vx:F2}\t{vy:F2}");
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Range: {x:F2} m");
            Console.WriteLine($"Flight time: {time:F2} s");
        }
    }
}



//written and developed by Gorb/Gorlubian