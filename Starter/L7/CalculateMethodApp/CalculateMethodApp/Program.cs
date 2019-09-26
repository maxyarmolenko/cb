using System;
namespace CalculateMethodApp
{
    class Program
    {
        static void Calculate(ref int a, ref int b, ref int c, out int average)
        {
            average = (a + b + c) / 3;
        }
        static void Main()
        {
            Console.WriteLine("Enter the first number");
            string number1 = Console.ReadLine();
            int firstNumber = Int32.Parse(number1);
            Console.WriteLine("Enter the second number");
            string number2 = Console.ReadLine();
            int secondNumber = Int32.Parse(number2);
            Console.WriteLine("Enter the third number");
            string number3 = Console.ReadLine();
            int thirdNumber = Int32.Parse(number3);
            int average = 0;
            Calculate(ref firstNumber, ref secondNumber, ref thirdNumber, out average); 
            Console.WriteLine("{0} and {1} and {2} = {3}", firstNumber, secondNumber, thirdNumber, average);
            Console.ReadKey();
        }
    }
}
