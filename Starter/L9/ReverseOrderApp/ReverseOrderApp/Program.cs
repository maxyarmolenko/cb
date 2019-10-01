using System;
namespace ReverseOrderApp
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            for (int a = 0; a < array.Length; a++)
            {
                array[a] = a * 1;
            }
          ReverseArray(array);
          DisplayArray(array);
            Console.ReadKey();
        }
        static int[] ReverseArray(int[] array)
        {

            for (int k = array.Length-1; k >= 0; k--)
            {
                array[k] = k * 1;
            }
           
            return array;
        }
        static void DisplayArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }
    }
}
