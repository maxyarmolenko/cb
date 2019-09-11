using System;

namespace ParityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для проверки  чисел на четность");
            string line = Console.ReadLine();
            byte number;
            byte.TryParse(line, out number);
            bool check = CheckEven(number);
            if (check)
            {
                Console.WriteLine("Число является четным");
            }
            else 
            Console.WriteLine("Число является нечетным");
            Console.ReadKey();
        }

        private static bool CheckEven(byte number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            
            return false;
        }
        
    }
}
