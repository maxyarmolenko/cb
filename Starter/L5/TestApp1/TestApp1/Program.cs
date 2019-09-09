using System;
using System.Linq;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int doubleExpo = 0;
            Console.WriteLine("Введите число для проверки!");
                int one_bit = Convert.ToInt32(Console.ReadLine());
                doubleExpo = one_bit & (one_bit-1);
                if (doubleExpo == 0)
                {
                  Console.WriteLine("Число - степень двойки!");
                }
                else
                {
                    Console.WriteLine("Число - не степень двойки!");
                }
                Console.ReadKey();
        }
    }
}
