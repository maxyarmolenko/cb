using System;
namespace OddNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number A");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number B");
            var b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                do
                {
                    b--;
                    if ((b % 2) != 0)
                        Console.WriteLine("Odd value located between A and B numbers {0}", b);
                }
                while (b > a);
            }
            else
                Console.WriteLine("You entered incorrect number! Number A must be under then number B");
            Console.ReadKey();
        }
    }
}
