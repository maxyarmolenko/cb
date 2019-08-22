using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 4, b = 5;
            int sum = a +b;
            Console.WriteLine(sum);

            byte c = 5, d = 10;
            int difference = d - c;
            Console.WriteLine(difference);

            byte e = 3, f = 12;
            int multiplication = d * c;
            Console.WriteLine(multiplication);

            byte g = 2, h = 9;
            int division = h / g, remainder = h % g;
            Console.WriteLine(division);

            Console.WriteLine(remainder);

            double i = 3, j = 4;
            double result = Math.Pow(i, j);
            Console.WriteLine(result);

            double k = 16;
            double sqrtresult = Math.Sqrt(k);
            Console.WriteLine(sqrtresult);

            Console.ReadKey();
        }
    }
}
