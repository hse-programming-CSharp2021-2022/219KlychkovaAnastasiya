using System;

namespace Task1
{
    class Point
    {
        double x;
        double y;
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get => x; private set => x = value; }
        public double Y { get => y; private set => y = value; }
        public static double Distance(Point point1, Point point2) => Math.Sqrt(Math.Pow(point1.x - point2.x, 2) + Math.Pow(point1.y - point2.y, 2));
    }
    class TriangleComp
    {
        Point point1;
        Point point2;
        Point point3;

        double side1;
        double side2;
        double side3;

        //public TriangleComp(double x1, double y1, double x2, double y2, double x3, double y3)
        public TriangleComp(Point p1, Point p2, Point p3)
        {
            //point1 = new Point(x1, y1);
            //point2 = new Point(x2, y2);
            //point3 = new Point(x3, y3);
            point1 = p1;
            point2 = p2;
            point3 = p3;

            side1 = Point.Distance(point1, point2);
            side2 = Point.Distance(point2, point3);
            side3 = Point.Distance(point3, point1);
        }
        public double Square
        {
            get
            {
                double p = (side1 + side2 + side3) / 2;
                return Math.Round(Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)),3);
            }
        }
        private double sign(Point p1, Point p2, Point p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }
        public bool PointInTriangle(Point pt)
        {
            double d1, d2, d3;
            bool has_neg, has_pos;
            d1 = sign(pt, point1, point2);
            d2 = sign(pt, point2, point3);
            d3 = sign(pt, point3, point1);
            has_neg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            has_pos = (d1 > 0) || (d2 > 0) || (d3 > 0);
            return !(has_neg && has_pos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TriangleComp tc = new TriangleComp(new Point(0, 0), new Point(0, 3), new Point(5, 0));
            Console.WriteLine(tc.Square + " " + tc.PointInTriangle(new Point(1, 1)));
        }
    }
}
