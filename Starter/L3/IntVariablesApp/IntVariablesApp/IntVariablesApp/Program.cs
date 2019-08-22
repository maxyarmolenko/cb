using System;

namespace IntVariablesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            x += y - x++ * z;
            Console.WriteLine(x);
            z = --x – y * 5; }

        Console.WriteLine();
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
