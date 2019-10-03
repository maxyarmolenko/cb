using System;

namespace ReverseOrderApp
{
    class Program
    {
        static void Main()
        {
            var array = CreateAndInitArray(10);
            Console.WriteLine("Display on the screen CreateAndInitArray");
            Display(array);
            Console.WriteLine();
            var array1 = InvertArray(array);
            Console.WriteLine("Display on the screen InvertArray");
            Display(array1);
        }

        static int [] InvertArray(int[] array)
        {
            var n = array.Length;
            var array1 = new int [n];
            for (int i = 0; i < array.Length; i++)
            {
                array1 [i] = array[n-1];
                n--;
            }
            return array1;
        }
         static int [] CreateAndInitArray(int v)
        {
            var array = new int [v];
            for (int i = 0; i < v; i++)
            {
                array[i] = i;
            }
            return array;
        }
         static void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine (array [i]);
            }
            Console.ReadKey();
        }
    }
}

