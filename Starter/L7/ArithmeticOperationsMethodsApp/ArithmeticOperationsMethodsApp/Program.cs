using System;
using System.Reflection.Emit;

namespace ArithmeticOperationsMethodsApp
{
    class Program
    {
        static void Add(ref int a, ref int b)
        {
            int result = 0;
            result = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, result);
            Console.ReadKey();
        }
        static void Sub(ref int a, ref int b)
        {
            int result = 0;
            result = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, result);
            Console.ReadKey();
        }
        static void Mul(ref int a, ref int b)
        {
            int result = 0;
            result = a * b;
            Console.WriteLine("{0} * {1} = {2}", a, b, result);
            Console.ReadKey();
        }
        static void Div(ref int a, ref int b)
        {
            int result = 0;
            if (b == 0)
            {
               Console.WriteLine("Attempt to divide by 0");    
            }
            result = a / b;
            {
             Console.WriteLine("{0} / {1} = {2}", a, b, result);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter the 1st number");
            string operand1 = Console.ReadLine();
            int number1 = Int32.Parse(operand1);
            Console.WriteLine("Please enter the 2d number");
            string operand2 = Console.ReadLine();
            int number2 = Int32.Parse(operand2);
            Console.WriteLine("Please enter arithmetic sign");
            string operand3 = Console.ReadLine();
            Char number3 = Char.Parse(operand3);
            if (number3 == '+')
            {
                Add(ref number1, ref number2); 
            }
            if (number3 == '-')
            {
                Sub(ref number1, ref number2);
            }
            if (number3 == '*')
            {
                Mul(ref number1, ref number2);
            }
            if (number3 == '/')
            {
                Div(ref number1, ref number2);
            }
            else
            {
                Console.WriteLine("You entered incorrect arithmetic sign");
            }
            Console.ReadKey();
        }
    }
}
