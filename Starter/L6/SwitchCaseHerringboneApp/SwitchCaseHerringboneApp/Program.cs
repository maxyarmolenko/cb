using System;

namespace SwitchCaseHerringboneApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number of branches at the Christmas tree from 1 till 5");
            int branch;
            int.TryParse(Console.ReadLine(), out branch);
            int height = 7;
            int width = 5;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            switch (branch)
            {
                case 1:
                    {
                        {
                            int height2 = 7;
                            int width2 = 5;
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
                            break;
                        }
                    }

                case 2:
                    {

                        {
                            int height1 = 7;
                            int width1 = 5;
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
                                int height2 = 8;
                                int width2 = 4;
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
                                break;
                            }
                        }
                    }
                case 3:
                    {
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
                                break;
                            }
                        }
                    }

                case 4:
                    {
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
                            for (int i = -1; i < 7; ++i)
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
                                for (int i = -2; i < 7; ++i)
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

                                {
                                    int height3 = 10;
                                    int width3 = 2;
                                    for (int i = -4; i < 7; ++i)
                                    {
                                        for (int o = 0; o < 10; ++o)
                                        {
                                            Console.Write(" ");
                                        }

                                        for (int j = -15; j < height3; ++j)
                                        {
                                            if (j > width3 && j < height3)
                                                Console.Write("*");
                                            else
                                                Console.Write(" ");
                                        }

                                        Console.WriteLine();
                                        --width3;
                                        ++height3;
                                    }

                                    for (int p = 0; p < 8; ++p)
                                    {
                                        for (int o = 0; o < 30; ++o)
                                        {
                                            Console.Write(" ");
                                        }

                                        for (int s = 0; s < 4; ++s)
                                        {
                                            Console.Write("*");
                                        }

                                        Console.WriteLine();
                                    }

                                    Console.ReadKey();
                                    break;
                                }
                            }
                        }
                    }

                case 5:
                    {
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
                            for (int i = -1; i < 7; ++i)
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
                                for (int i = -2; i < 7; ++i)
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

                                {
                                    int height3 = 10;
                                    int width3 = 2;
                                    for (int i = -4; i < 7; ++i)
                                    {
                                        for (int o = 0; o < 10; ++o)
                                        {
                                            Console.Write(" ");
                                        }

                                        for (int j = -15; j < height3; ++j)
                                        {
                                            if (j > width3 && j < height3)
                                                Console.Write("*");
                                            else
                                                Console.Write(" ");
                                        }

                                        Console.WriteLine();
                                        --width3;
                                        ++height3;
                                    }

                                    {
                                        int height4 = 11;
                                        int width4 = 1;
                                        for (int i = -6; i < 7; ++i)
                                        {
                                            for (int o = 0; o < 10; ++o)
                                            {
                                                Console.Write(" ");
                                            }

                                            for (int j = -15; j < height4; ++j)
                                            {
                                                if (j > width4 && j < height4)
                                                    Console.Write("*");
                                                else
                                                    Console.Write(" ");
                                            }

                                            Console.WriteLine();
                                            --width4;
                                            ++height4;
                                        }

                                        for (int p = 0; p < 8; ++p)
                                        {
                                            for (int o = 0; o < 30; ++o)
                                            {
                                                Console.Write(" ");
                                            }

                                            for (int s = 0; s < 4; ++s)
                                            {
                                                Console.Write("*");
                                            }

                                            Console.WriteLine();
                                        }

                                        Console.ReadKey();
                                        break;
                                    }
                                }
                            }
                        }
                    }

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You entered a non-existent number! Please try again!!!");
                        Console.ReadKey();
                        break;
                    }

            }

        }

    }

}
