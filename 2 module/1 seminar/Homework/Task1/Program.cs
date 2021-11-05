using System;

namespace Task1
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point() : this(0, 0) { } // конструктор умолчания
        // СВОЙСТВО RO
        public double Ro
        {
            get { return Math.Sqrt(Y * Y + X * X); }
        }
        // СВОЙСТВО FI
        public double Fi
        {
            get
            {
                if (X > 0 && Y >= 0)
                    return Math.Atan(Y / X);
                if (X > 0 && Y < 0)
                    return Math.Atan(Y / X) + 2 * Math.PI;
                if (X < 0)
                    return Math.Atan(Y / X) + Math.PI;
                if (Y > 0 && X == 0)
                    return Math.PI / 2;
                if (Y < 0 && X == 0)
                    return 3 * Math.PI / 2;
                return 0;
            }
        }
        
        public override string ToString()
        {
            string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
            return string.Format(maket, X, Y, Ro, Fi); ;
        }

        public double Distance()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }

    class Program
    {
        static int comp(Point x, Point y)
        {
            if (x.Distance() > y.Distance())
                return 1;
            else if (x.Distance() < y.Distance())
                return -1;
            else return 0;
        }

        static void Main(string[] args)
        {
            Point[] points = new Point[3];
            points[0] = new Point(3, 4);
            Console.WriteLine(points[0]);
            points[1] = new Point(0, 3);
            Console.WriteLine(points[1]);
            points[2] = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                points[2].X = x; points[2].Y = y;
                Array.Sort(points, comp);
                foreach (var i in points)
                    Console.WriteLine(i);
            } while (x != 0 | y != 0);
        }
    }
}
