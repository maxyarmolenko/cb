using System;

namespace DefinitionNumbersAppBySwitchSolution
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number from 0 till 100");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (number >= 0 && number < 15) result = 1;
            if (number >= 15 && number < 36) result = 2;
            if (number >= 36 && number < 51) result = 3;
            if (number >= 50 && number < 101) result = 4;
            if (number < 0 || number > 100) result = 5;
            switch (result)
            {
                case 1:
                {
                    Console.WriteLine("You entered a number = {0}. It's  numerical range from 0 to 14", number);
                    break;
                }
                case 2:
                {
                    Console.WriteLine("You entered a number = {0}. It's a numerical range from 15 to 35", number);
                    break;
                }
                case 3:
                {
                    Console.WriteLine("You entered a number = {0}. It's a numerical range from 36 to 50", number);
                    break;
                }
                case 4:
                {
                    Console.WriteLine("You entered a number = {0}. It's a numerical range from 50 to 100", number);
                    break;
                }
                case 5:
                {
                    Console.WriteLine(
                        "You entered a number = {0}. It's not included in the numerical range from 0 to 100", number);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
