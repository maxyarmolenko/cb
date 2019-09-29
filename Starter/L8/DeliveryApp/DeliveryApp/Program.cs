using System;
using System.Diagnostics.Eventing.Reader;

namespace DeliveryApp
{
    class Program
    {
        static int Factorial (int fact)
        {
            if (fact == 0)
              return 1;

            int res = Factorial(fact - 1);
            return res * fact;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter quantity of clients");
            int clientsQuantity;
            int.TryParse(Console.ReadLine(), out clientsQuantity);
            int result = Factorial(clientsQuantity);
            Console.WriteLine("Max quantity of  products delivery for one good is {0}", result );
            Console.ReadLine();
        }
    }
}
