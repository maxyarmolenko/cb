using System;
namespace VolumeCalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter cylinder radius");
            int radius;
            int.TryParse(Console.ReadLine(), out radius);

            Console.WriteLine("Please enter cylinder height");
            int height;
            int.TryParse(Console.ReadLine(), out height);

            const double pi = 3.1415;
            double v = pi * Math.Pow(radius, 2) * height;
            Console.WriteLine($"The volume of the cylinder = {v}");

            double s = 2 * pi * Math.Pow(radius, 2) + 2 * pi * Math.Pow(radius, 2);                                   
            Console.WriteLine($"Cylinder surface area = {s}");
            Console.ReadKey();
        }
    }
}
