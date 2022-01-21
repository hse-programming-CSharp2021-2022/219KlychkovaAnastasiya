using System;

namespace Task1
{
    delegate void CoordChanged(Dot d);
    class Dot
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public event CoordChanged OnCoordChanged;
        public Dot(int x,int y)
        {
            X = x;
            Y = y;
        }
        public void DotFlow()
        {
            Random rnd = new Random();
            for(int i = 0; i < 10; i++)
            {
                X = rnd.Next(-10, 11);
                Y = rnd.Next(-10, 11);
                if (X < 0 && Y < 0)
                    OnCoordChanged?.Invoke(this);
            }
        }
    }
    class Program
    {
        static void PrintInfo(Dot dot)
        {
            Console.WriteLine($"X: {dot.X}\tY: {dot.Y}");
        }
        static void Main(string[] args)
        {
            Console.Write("x: ");
            int.TryParse(Console.ReadLine(), out int x);
            Console.Write("y: ");
            int.TryParse(Console.ReadLine(), out int y);
            Dot D = new Dot(x, y);
            D.OnCoordChanged += PrintInfo;
            D.DotFlow();
        }
    }
}
