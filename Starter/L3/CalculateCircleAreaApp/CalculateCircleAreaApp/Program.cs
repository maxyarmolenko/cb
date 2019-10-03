using System;
using System.Net.NetworkInformation;

namespace CalculateCircleAreaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141592;
            double r = 1.8;

            double circleArea =  pi * Math.Pow(r, 2);

            Console.WriteLine($"The area of the circle is {circleArea}");
            Console.ReadKey();
        }
    }
}
