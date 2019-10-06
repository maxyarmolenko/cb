using System;
namespace MyReverseAndSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
           var a = GetArray(10);
           var array = ReverseArray(a);
           DisplayArray(array);

           Console.WriteLine("Please enter an array element position");
           int index;
           int.TryParse(Console.ReadLine(), out index);

           Console.WriteLine("Please enter the number of elements in the array");
            int count;
           Int32.TryParse(Console.ReadLine(), out count);
           var sub = SubArray(a, index, count);
           DisplayArray(sub);

        }

        private static int[] GetArray(int a)
        {
           var array = new int[a];
            for (int i = 0; i < a; i++)
            {
                array[i] = i;
            }
            return array;
        }

        private static int[] ReverseArray(int[] a)
        {
            var b = a.Length;
            var invertArray = new int[b];
            for (int i = 0; i < a.Length; i++)
            {
                invertArray [i] = a[b - 1];
                b--;
            }


            return invertArray;
        }

        private static int[] SubArray (int[] array, int index, int count)
        {
            var length = 0;
            var sub = new int [count];
            for (int i = 0; i < sub.Length; i++)
            {
                if (array.Length > index)
                {
                   sub[length] = array[index];
                }

                else
                {
                    sub[length] = 1;
                }

                index++;
                length++; 
            }

            return sub;
        }

        private static void DisplayArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
    }
