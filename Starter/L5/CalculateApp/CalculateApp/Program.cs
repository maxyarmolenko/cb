using System;

namespace CalculateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            Console.WriteLine("Результат выполнения математических операций");
            Console.WriteLine("firstOperation = {0}", x += y >> x++ * z);
            Console.WriteLine("secondOperation = {0}", z = ++x & y * 5);
            Console.WriteLine("thirdOperation = {0}", y /= x + 5 | z);
            Console.WriteLine("forthOperation = {0}", z = x++ & y * 5);
            Console.WriteLine("fifthOperation = {0}", x = y << x++ ^ z);
            Console.ReadKey();
        }
    }
}
