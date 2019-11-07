using System;
namespace MathClassesApp
{
    class Point
    {
        private int x;
        private int y;
        private string name;

        public int Getx
        {
            get { return x; }
        }
        public int Gety
        {
            get { return y; }
        }
        public string Name
        {
            get { return name; }
        }

        public Point(int x, int y, string name)
        {
            this.x = y;
            this.y = y;
            this.name = name;
        }
    }
}
