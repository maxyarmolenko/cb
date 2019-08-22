using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 4, b = 5;
            int sum = 0;
            sum = a + b;
            Console.WriteLine(sum);

            byte c = 5, d = 10;
            int difference = 0;
            difference = d - c;
            Console.WriteLine(difference);

            byte e = 3, f = 12;
            int multiplication = 0;
            multiplication = d * c;
            Console.WriteLine(multiplication);

            byte g = 2, h = 9;
            int division = 0, remainder = 0;
            division = h / g;
            Console.WriteLine(division);

            remainder = h % g;
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
