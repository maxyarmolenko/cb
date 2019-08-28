using System;
using System.Linq.Expressions;

namespace EnglishRussianTranslatorApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вас приветствует русско-английский переводчик!!!");
            Console.WriteLine("Введите пожалуйста слово на русском языке");

            string word = Console.ReadLine();
            switch (word)
            {
                case "солнечный":
                {
                    Console.WriteLine("sunny");
                    break;
                }
                case "дождь":
                {
                    Console.WriteLine("rain");
                    break;
                }
                case "холод":
                {
                    Console.WriteLine("cold");
                    break;
                }
                case "ветер":
                {
                    Console.WriteLine("wind");
                    break;
                }
                case "жара":
                {
                    Console.WriteLine("heat");
                    break;
                }
                case "лёгкий туман":
                {
                    Console.WriteLine("mist");
                    break;
                }
                case "туман":
                {
                    Console.WriteLine("fog");
                    break;
                }
                case "снег":
                {
                    Console.WriteLine("snow");
                    break;
                }
                case "прохладный":
                {
                    Console.WriteLine("cool");
                    break;
                }
                case "ливень":
                {
                    Console.WriteLine("shower");
                    break;
                }
                default:
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели несуществующее слово!!!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
