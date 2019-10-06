using System;
namespace ArrayLengthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = GetArray(10);
            DisplayArray(array);
            Console.WriteLine();
            var inc = IncreaseArrayLength(array);
            DisplayArray(inc);
            Console.ReadKey();
        }

        static int[] GetArray(int a)
        {
            var array = new int[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = i;
            }

            return array;
        }

        static int[] IncreaseArrayLength(int [] array)
        {
            var a = array.Length + 1;
            var increase = new int[a];
            for (int i = 0; i < a; i++)
            {
                increase[i] = i;
            }

            return increase;
        }

        static void DisplayArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
              
            }

        }
    }
}
