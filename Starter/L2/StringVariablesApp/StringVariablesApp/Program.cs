using System;

namespace StringVariablesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "\nмоя строка 1";
            Console.WriteLine(a);
            string b = "\tмоя строка 2";
            Console.WriteLine(b);
            string c = "\aмоя строка 3";
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
