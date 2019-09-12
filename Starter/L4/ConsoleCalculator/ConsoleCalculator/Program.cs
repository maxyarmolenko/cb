using System;
using System.Diagnostics;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int operand2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter the sign of the arithmetic operation");
            string sign  = Console.ReadLine();
            int result =0;
            int.TryParse(sign, out result);
            switch (sign)
            {
                case "-":
                {
                    result = operand1 - operand2;
                        Console.WriteLine("Arithmetic operation = {0}", result);
                    break;
                }
                case "+":
                {
                    result = operand1 + operand2;
                    Console.WriteLine("arithmetic operation = {0}", result);
                    break;
                }
                case "*":
                {
                    result = operand1 * operand2;
                    Console.WriteLine("arithmetic operation = {0}", result);
                    break;
                }
                case "/":
                {
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                        Console.WriteLine("arithmetic operation = {0}", result);
                    }
                    else
                    {
                        Console.WriteLine("Divide by 0 is forbidden");
                    }
                    break;
                }

            }
                   Console.ReadKey();
        }          
    }
}
 