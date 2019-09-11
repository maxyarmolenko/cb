using System;

namespace TestApp2_1stWayOfSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для проверки  чисел на четность");
            string line = Console.ReadLine();
            byte number;
            byte.TryParse(line, out number);
            byte mask = 0x00;
            number = (byte) (number | mask);
            number = (byte)(number & mask);
            Console.WriteLine("Число является четным");
            Console.WriteLine("Число является нечетным");
            Console.ReadKey();
        }
    }
}
