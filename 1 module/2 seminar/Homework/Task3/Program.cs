using System;

namespace Task3
{
    class Program
    {
        public static double Dis(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            return d;
        }
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            do { 
                Console.WriteLine("Введите a");
                double.TryParse(Console.ReadLine(),out a);
                Console.WriteLine("Введите b");
                double.TryParse(Console.ReadLine(), out b);
                Console.WriteLine("Введите c");
                double.TryParse(Console.ReadLine(), out c);

                d = Dis(a,b,c);
                x1 = d > 0 ? ((-b) + Math.Sqrt(d)) / (2 * a) : (d == 0 ? -(b / (2 * a)) : double.NaN);
                x2 = d > 0 ? ((-b) - Math.Sqrt(d)) / (2 * a) : (d == 0 ? x1 :double.NaN);
                string str = d > 0 ? $"x1 = {x1}\nx2 = {x2}":(d==0 ? "x1 = x2 = " + x1 : "Действительных корней уравнения не существует");
                Console.WriteLine(str);
                Console.WriteLine("Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
