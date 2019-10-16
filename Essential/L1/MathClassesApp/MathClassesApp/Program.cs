using System;
using System.Runtime.CompilerServices;

namespace MathClassesApp
{
    class Point
    {
        private int point1;
        private int point2;
        private string name;

        public int GetPoint1
        {
            get { return point1; }
        }
        public int GetPoint2
        {
            get { return point2; }
        }
        public string GetPoint3
        {
            get { return name; }
        }

        public Point (int point1, int point2)
        {
            this.point1 = point1;
            this.point2 = point2;
           
        }
    }

    abstract class Figure
    {
        Point PointA = new Point (2, 4);
        Point PointB = new Point(6, 10);
        Point PointC = new Point(5, 8);
        Point PointD = new Point(12, 8);
        Point PointE = new Point(14, 12);

        public double LengthSide (Point A, Point B)
        {
            double result = Math.Sqrt(Math.Pow(PointA) + Math.Pow(PointB));                    // √(xb - xa)2 + (yb - ya)2
            return  result;
        }

        public void PerimeterCalculator()
        {
            double result = ()
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
