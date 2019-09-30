using System;
namespace ReverseOrderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display array elements in order");
            int [] array = new int [10];
            for (int a = 0; a < array.Length; ++a)
            {
                array[a] = a;
                Console.WriteLine(array[a]);
            }
            array = ReverseArray (array);
            Console.WriteLine(array);
            
            Console.ReadKey();
        }
        static int[] ReverseArray(int[] array)
        {
            Console.WriteLine("Display array elements in reverse order");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            return array;
        }
    }
}
