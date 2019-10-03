using System;

namespace IntVariablesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;

            x += y - (x++ * z);
            Console.WriteLine("Result of the 1st operation = {0}", x);

            z = --x - y * 5;
            Console.WriteLine("Result of the 2nd operation = {0}", z);

            y /= x + 5 % z;
            Console.WriteLine("Result of the 3rd operation = {0}", y);

            z = x++ + y * 5;
            Console.WriteLine("Result of the 4th operation = {0}", z);

            x = y - x++ * z;
            Console.WriteLine("Result of the 5th operation = {0}", x);

            Console.ReadKey();
        }
    }
    }
