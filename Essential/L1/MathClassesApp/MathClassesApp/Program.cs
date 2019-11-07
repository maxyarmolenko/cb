using System;
using MathClassesApp;

namespace MathClassesApp
{
    
    }

    class Program
    {
        static public void Main(string[] args)
    {
        Figure Figure = new Figure(new Point(2, 2, "A"), new Point(3, 3, "B"), new Point(11, 11, "C"), new Point(3, 3, "B"));
       
        
        Console.Write("{0}, P = ", Figure.Type);
        Figure.PerimeterCalculator();

            Console.ReadKey();
      }
    }
 