using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;

namespace ArrayMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of array elements");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Please click Enter button to show initializated array elements");
            int [] array = new int [n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine($"The biggest value of this array is {array [n-1]}");
            Console.WriteLine($"The smallest value of this array is {array[0]}");
            Console.Write($"The sum of all array elements is ");
            double sum = 0;
            for (int counter=0; counter < array.Length; counter++)
            {
                sum += counter;
            }

            Console.WriteLine(sum);
            Console.WriteLine($"The average of all array elements is {sum / array.Length}");
            
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                        Console.Write($"Odd array value - {array[i]}; ");
                }
            Console.ReadLine();

        }
    }
}
