using System;

namespace BonusAccrualApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стаж сотрудника для рассчета премии");
            string line = Console.ReadLine();
            int result;
            int.TryParse(line, out result);
            if (result < 5)
            {
                Console.WriteLine("Премия составляет 10% от зарплаты");
            }
            if (result >= 5 && result < 10)
            {
                Console.WriteLine("Премия составляет 15% от зарплаты");
            }
            if (result >= 10 && result < 15)
            {
                Console.WriteLine("Премия составляет 25% от зарплаты");
            }
            if (result >= 15 && result < 20)
            {
                Console.WriteLine("Премия составляет 35% от зарплаты");
            }
            if (result >= 20 && result < 25)
            {
                Console.WriteLine("Премия составляет 45% от зарплаты");
            }
            if (result >= 25)
            {
                Console.WriteLine("Премия составляет 50% от зарплаты");
            }
            Console.ReadKey();
        }
    }
}
