using System;
using System.Collections.Generic;
namespace Task1
{
    //class Point
    //{
    //    public double X { get; private set; }
    //    public double Y { get; private set; }
    //    public Point(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //    public double Distance(Point other) => Math.Sqrt(Math.Pow(this.X - other.X, 2) + Math.Pow(this.Y - other.Y, 2));
    //}
    struct Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Distance(Point other) => Math.Sqrt(Math.Pow(this.X - other.X, 2) + Math.Pow(this.Y - other.Y, 2));
    }
    //class Circle : IComparable<Circle>
    //{
    //    private double rad;
    //    public double Rad { get => rad; private set => rad = value; }
    //    public Point center;
    //    public Circle(double x, double y, double r)
    //    {
    //        center = new Point(x, y);
    //        Rad = r;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Center: ({center.X},{center.Y})\tRadius: {Rad}";
    //    }
    //    int IComparable<Circle>.CompareTo(Circle other)
    //    {
    //        double thisInfo = Rad * center.Distance(new Point(0, 0));
    //        double otherInfo = other.Rad * other.center.Distance(new Point(0, 0));
    //        if (otherInfo > thisInfo)
    //            return -1;
    //        else if (otherInfo < thisInfo)
    //            return 1;
    //        else
    //            return 0;
    //    }
    //}
    struct Circle : IComparable<Circle>
    {
        private double rad;
        public double Rad { get => rad; private set => rad = value; }
        public Point center;
        public Circle(double x, double y, double r)
        {
            center = new Point(x, y);
            rad = r;
        }
        public override string ToString()
        {
            return $"Center: ({center.X},{center.Y})\tRadius: {Rad}";
        }
        int IComparable<Circle>.CompareTo(Circle other)
        {
            double thisInfo = Rad * center.Distance(new Point(0, 0));
            double otherInfo = other.Rad * other.center.Distance(new Point(0, 0));
            if (otherInfo > thisInfo)
                return -1;
            else if (otherInfo < thisInfo)
                return 1;
            else
                return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Circle> circles = new();
            double[] info = Array.ConvertAll((Console.ReadLine()).Split(" ", StringSplitOptions.RemoveEmptyEntries), double.Parse);
            while (info[2] != 0)
            {
                circles.Add(new Circle(info[0], info[1], info[2]));
                info = Array.ConvertAll((Console.ReadLine()).Split(" "), double.Parse);
            }
            circles.ForEach(c => Console.WriteLine(c));
            //circles.Sort((l, r) =>
            //{
            //    double lInfo = l.Rad * l.center.Distance(new Point(0, 0));
            //    double rInfo = r.Rad * r.center.Distance(new Point(0, 0));
            //    if (rInfo > lInfo)
            //        return -1;
            //    else if (rInfo < lInfo)
            //        return 1;
            //    else
            //        return 0;
            //});
            circles.Sort();
            Console.WriteLine("****");
            circles.ForEach(c => Console.WriteLine(c));
        }
    }
}
