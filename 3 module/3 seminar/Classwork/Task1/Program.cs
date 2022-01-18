using System;

namespace Task1
{
    delegate void SquareSizeChanged(double size);
    class Square
    {
        double x1;
        double y1;
        double x2;
        double y2;

        public event SquareSizeChanged OnSizeChanged;
        public double X1
        {
            get => x1;
            set
            {
                x1 = value;
                OnSizeChanged?.Invoke(Math.Abs(x2 - x1));
            }
        }
        public double X2
        {
            get => x2;
            set
            {
                x2 = value;
                OnSizeChanged?.Invoke(Math.Abs(x2 - x1));
            }
        }
        public double Y1
        {
            get => y1;
            set
            {
                y1 = value;
                OnSizeChanged?.Invoke(Math.Abs(y1-y2));
            }
        }
        public double Y2
        {
            get => y2;
            set
            {
                y2 = value;
                OnSizeChanged?.Invoke(Math.Abs(y1 - y2));
            }
        }
        public Square(double x1,double y1,double x2,double y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }
    }
    class Program
    {
        static void SquareConsoleInfo(double info)
        {
            Console.WriteLine("{0:F2}", info);
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int x1);
            int.TryParse(Console.ReadLine(), out int y1);
            int.TryParse(Console.ReadLine(), out int x2);
            int.TryParse(Console.ReadLine(), out int y2);

            Square S = new Square(x1, y1, x2, y2);

            S.OnSizeChanged += SquareConsoleInfo;

            Console.WriteLine("Измените координаты");
            do
            {
                int.TryParse(Console.ReadLine(), out x2);
                int.TryParse(Console.ReadLine(), out y2);
                S.X2 = x2;
                S.Y2 = y2;
            } while (!(x2 == 0 && y2 == 0));
        }
    }
}
