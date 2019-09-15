using System;

namespace RectangleOfStarsApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Rectangle of stars");
            int line = 0;
            while (line < 10)
            {
                int star;
                for (star = 0; star < 50; star++)
                {
                    Console.Write("*");
                }
                line++;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
