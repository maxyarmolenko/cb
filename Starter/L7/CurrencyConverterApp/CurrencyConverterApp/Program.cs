using System;
namespace CurrencyConverterApp
{
    class Program
    {
        static void CurrencyConverterMethod(ref double quantity, ref double exchangeRates, out double result)
        {
            result = quantity * exchangeRates;
            Console.WriteLine("Amount of money in the chosen currency = {0}", result);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter amount of money");
            string operand1 = Console.ReadLine();
            double quantity = Double.Parse(operand1);
            Console.WriteLine("Please enter current rate of the selected currency");
            string operand2 = Console.ReadLine();
            double exchangeRates = Double.Parse(operand2);
            double result = 0;
            CurrencyConverterMethod(ref quantity, ref exchangeRates, out result);
        }
    }
}
