using System;
using System.Globalization;

namespace PiandENumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.141592653d;
            string value = pi.ToString(CultureInfo.CurrentCulture);
            Console.WriteLine(value);
            Console.ReadKey();

            double e = 2.7182818284590452d;
            decimal e1 = 0.12345678901234567890123456789012345M;
            var format = $"{e1:#,#.#####################################}";

            string d = e.ToString(CultureInfo.InvariantCulture);
            Console.WriteLine(d);
            Console.WriteLine(format); // выведет два знака после запятой
            Console.WriteLine("{0:0.00000000000000000}", e1); // выведет два знака после запятой
            Console.ReadKey();
        }
    }
}
