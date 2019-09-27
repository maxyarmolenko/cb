using System;
using System.Diagnostics.Eventing.Reader;

namespace DefiningNumberPropertiesApp
{
    class Program
    {
        static void PosOrNegNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Number is positive, {0}", number);
            }
            if (number < 0)
            {
                Console.WriteLine("Number is negative, {0}", number);
            }
            if (number == 0)
            {
                Console.WriteLine("Number isn't positive and negative, {0}", number);
            }
            Console.ReadKey();
        }
        private static void Primenumber(int number)
        {
            int checkNumber = 2;
            int remainder = 0;
            do
            {
                remainder = number % checkNumber;
                if (remainder != 0)
                    checkNumber++;    
            }
            while (remainder !=0);
            if (checkNumber == number)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
               Console.WriteLine("The number isn't prime");   
            }
            Console.ReadKey();
        }
        static void DivisionWithoutRemainder(int number)
        {
            if ((number % 2) == 0 && (number % 5) == 0 && (number % 3) == 0 && (number % 6) == 0 && (number % 9) == 0)
            {
                Console.WriteLine("The number is divisible by 2, 5, 3, 6, 9, {0}", number);
            }
            else
            {
                Console.WriteLine("The number isn't divisible by 2, 5, 3, 6, 9, {0}", number);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check");
            string operand1 = Console.ReadLine();
            int number = Int32.Parse(operand1);
            PosOrNegNumber(number);
            Primenumber(number);
            DivisionWithoutRemainder(number);
            Console.ReadKey();
        }
    }
}
