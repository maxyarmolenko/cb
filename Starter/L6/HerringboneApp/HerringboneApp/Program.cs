using System;

namespace HerringboneApp
{
    class Program
    {
        static void Main()
        {
            int height = 7;
            int width = 5;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < 7; ++i)
            {
                for (int o = 0; o < 10; ++o)
                {
                    Console.Write(" ");
                }

                for (int j = -15; j < height; ++j)
                {
                    if (j > width && j < height)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
                --width;
                ++height;
            }

            {
                int height1 = 8;
                int width1 = 4;
                for (int i = -2; i < 7; ++i)
                {
                    for (int o = 0; o < 10; ++o)
                    {
                        Console.Write(" ");
                    }

                    for (int j = -15; j < height1; ++j)
                    {
                        if (j > width1 && j < height1)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }

                    Console.WriteLine();
                    --width1;
                    ++height1;
                }

                {
                    int height2 = 9;
                    int width2 = 3;
                    for (int i = -4; i < 7; ++i)
                    {
                        for (int o = 0; o < 10; ++o)
                        {
                            Console.Write(" ");
                        }

                        for (int j = -15; j < height2; ++j)
                        {
                            if (j > width2 && j < height2)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }

                        Console.WriteLine();
                        --width2;
                        ++height2;
                    }

                    for (int p = 0; p < 6; ++p)
                    {
                        for (int o = 0; o < 30; ++o)
                        {
                            Console.Write(" ");
                        }

                        for (int s = 0; s < 3; ++s)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }

                    Console.ReadKey();
                }

            }

        }

    }

}