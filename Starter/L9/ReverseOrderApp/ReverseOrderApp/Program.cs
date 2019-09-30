using System;
namespace ReverseOrderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte [] array = new byte[10] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine("Display array elements in order");
            for (int a = 0; a < array.Length; ++a)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("Display array elements in reverse order");

            for (int b = array.Length - 1; b >= 0; --b)
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
