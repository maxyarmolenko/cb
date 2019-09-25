using System;
namespace TheSumNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number A");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number B");
            var b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            b--;
            if (a < b)
            {
                do
                {
                    sum += b;
                    b--;
                }
                while (b > a);
                Console.WriteLine("The sum of all numbers located between A and B numbers {0}", sum);
            }
            else
                Console.WriteLine("You entered incorrect number! Number A must be under then number B");
            Console.ReadKey();
        }
    }
}
