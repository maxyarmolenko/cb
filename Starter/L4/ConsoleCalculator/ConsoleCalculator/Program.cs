using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter 1st number");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int operand2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter the sign of the arithmetic operation");
            string sign  = Console.ReadLine();
            int result =0;
            switch (sign)
            {
                case "-":
                {
                    result = operand1 - operand2;
                    break;
                }
                case "+":
                {
                    result = operand1 + operand2;
                    break;
                }
                case "*":
                {
                    result = operand1 * operand2;
                    break;
                }
                case "/":
                {
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                    }
                    else
                    {
                        Console.WriteLine("Divide by 0 is forbidden");
                    }
                    break;
                }
                case "%":
                {
                    if (operand2 != 0)
                    {
                        result = operand1 % operand2;
                    }
                    else
                    {
                        Console.WriteLine("Divide by 0 is forbidden");
                    }
                    break;
                }
                default:
                {
                    Console.WriteLine("Nonexistent sign! Please enter another\n");
                    break;
                }
            }
            Console.WriteLine($"Arithmetic operation = {result}");
            Console.ReadKey();
        }          
    }
}
 