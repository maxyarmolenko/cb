using System;

namespace DefinitionNumbersApp
{
    class Program
    {
        static void Main()
        {
         Console.WriteLine("Enter number from 0 till 100");
         int number = Convert.ToInt32(Console.ReadLine());
         if (number >= 0 && number < 15)
         {
             Console.WriteLine("You entered a number = {0}. It's  numerical range from 0 to 14", number);
         }
         if (number >= 15 && number < 36)
         {
             Console.WriteLine("You entered a number = {0}. It's a numerical range from 15 to 35", number);
         }
         if (number >= 36 && number < 51)
         {
             Console.WriteLine("You entered a number = {0}. It's a numerical range from 36 to 50", number);
         }
         if (number >= 50 && number < 101)
         {
             Console.WriteLine("You entered a number = {0}. It's a numerical range from 50 to 100", number);
         }
         else if (number < 0 || number > 100)
         {
             Console.WriteLine("You entered a number = {0}. It's not included in the numerical range from 0 to 100", number);
         }
         Console.ReadKey();
        }
    }
}
