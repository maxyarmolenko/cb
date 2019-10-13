using System;
namespace RectangleClassApp
{
    class Rectangle 
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        
        static double AreaCalculator(double side1, double side2)
        {
            double area = side1 * side2;
            return area;
        }

        static double PerimeterCalculator(double side1, double side2)
        {
            double perimeter = (side1 + side2) * 2;
            return perimeter;
        }

        public double GetArea()
        {
            return AreaCalculator(side1, side2);
        }

        public double GetPerimeter()
        {
            return PerimeterCalculator(side1, side2);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the 1st side of the rectangle");
            double side1;
            double.TryParse(Console.ReadLine(), out side1);

            Console.WriteLine("Please enter the length of the 2nd side of the rectangle");
            double side2;
            double.TryParse(Console.ReadLine(), out side2);

            Rectangle sizes = new Rectangle(side1, side2);
            Console.WriteLine("side1 = {0}, side2 = {1}", side1, side2);
            
            Console.WriteLine($"Rectangle area = {sizes.GetArea()}");
            Console.WriteLine($"Rectangle perimeter = {sizes.GetPerimeter()}");
            Console.ReadKey();
        }

    }

}
