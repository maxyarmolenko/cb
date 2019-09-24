using System;
namespace ProductDeliveryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of customers to whom the manufacturer have to deliver the product");
            var counter = Convert.ToInt32(Console.ReadLine());
           int factorial = 1;
           do
            {
                factorial *= counter--;
            }
            while (counter > 0);
            Console.WriteLine("Maximum number of delivery options, {0}", factorial);
            Console.ReadKey();
        }
    }
}
