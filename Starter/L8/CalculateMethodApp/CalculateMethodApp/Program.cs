using System;
namespace CalculateMethodApp
{
    class Program
    {
        static void Calculate(int number1, int number2, int number3)
        {
          number1 = number1 / 5;
          number2 = number2 / 5;
          number3 = number3 / 5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1st integer value");
            int val1;
            int.TryParse(Console.ReadLine(), out val1);
            Console.WriteLine("Please enter 2nd integer value");
            int val2;
            int.TryParse(Console.ReadLine(), out val2);
            Console.WriteLine("Please enter 3rd integer value");
            int val3;
            int.TryParse(Console.ReadLine(), out val3);
            Calculate(val1, val2, val3);
            Console.WriteLine("Divide by 5 for the 1st value = {0}", val1);
            Console.WriteLine("Divide by 5 for the 2nd value = {0}", val2);
            Console.WriteLine("Divide by 5 for the 3rd value = {0}", val3);
            Console.ReadKey();
        }
    }
}
