using System;

namespace MathClassesApp
{
    class Figure
    {
        private Point[] point;

        private string type;
        public string Type
        {
            get { return type; }
        }
        public double LengthSide(Point a, Point b)
        {
            double lengthside =
                Math.Sqrt(Math.Pow(b.Gety - a.Gety , 2) + Math.Pow(b.Getx - a.Getx, 2));
            return lengthside;
        }
        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < point.Length - 1; i++)
            {
                perimeter += LengthSide(point[i], point [i+1]);
            }

            perimeter += LengthSide(point[point.Length - 1], point[0]);
            Console.WriteLine(perimeter);

            Console.ReadKey();
        }

        public Figure(Point point1, Point point2, Point point3)
        {
            point = new Point[3];
            point[0] = point1;
            point[1] = point2;
            point[2] = point3;
            type = "Triangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            point = new Point[4];
            point[0] = point1;
            point[1] = point2;
            point[2] = point3;
            point[3] = point4;
            type = "Rectangle";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            point = new Point[5];
            point[0] = point1;
            point[1] = point2;
            point[2] = point3;
            point[3] = point4;
            point[4] = point5;
            type = "Pentagon";
        }
    }
}

 