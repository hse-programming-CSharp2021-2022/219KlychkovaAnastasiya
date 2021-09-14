using System;

class Program
{
    public static bool Check(double x,double y,double z)
    {
        if (x + y > z)
            return true;
        else return false;
    }
    static void Main(string[] args)
    {
        do
        {
            double a, b, c;
            Console.WriteLine("Введите стороны треугольника");
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            string s = Check(a, b, c) && Check(a, c, b) && Check(b, c, a) ? "Треугольник существует" : "Треугольника не существует";
            Console.WriteLine(s);
            Console.WriteLine("Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу.");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

