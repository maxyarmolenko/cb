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
            Console.WriteLine();

            int a = 5;
            var oper = LengthOperations(array, a);
            DisplayArray(oper);
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

        private static int[] LengthOperations(int[] array, int value)
        {
            var a = array.Length + 1;
            var valueArray = new int[a];
            valueArray[0] = value;
            for (int i = 1; i < a; i++)
            {
                valueArray[i] = i-1;
            }

            return valueArray;
        }
    }
}
