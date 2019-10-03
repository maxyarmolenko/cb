using System;

namespace AverageCalculationApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the 1st number");
            double a;
            double.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Please enter the 2nd number");
            double b;
            double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Please enter the 3rd number");
            double c;
            double.TryParse(Console.ReadLine(), out c);

            double average = (a + b + c) / 3;

            Console.Write($"The average value of the entered numbers is {average}");
            Console.ReadKey();
        }
    }
}
