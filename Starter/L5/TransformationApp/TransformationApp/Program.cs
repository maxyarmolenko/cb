using System;

namespace TransformationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Используя теорему Де Моргана, преобразовываем исходное выражение A | B, в эквивалентное выражение");
            bool A = true;
            bool B = false;
            if (A | B)
                Console.WriteLine("!(!A & !B) = {0}", !(!A & !B));
            Console.ReadKey();
        }
    }
}
