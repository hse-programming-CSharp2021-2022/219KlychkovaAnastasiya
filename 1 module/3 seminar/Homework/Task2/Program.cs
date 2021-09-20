using System;

class Program
{
    public static double G(double x, double y)
    {
        if (x < y && x > 0)
            return x + Math.Sin(y);
        else if (x > y && x < 0)
            return y - Math.Cos(x);
        else
            return 0.5 * x * y;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите x и y: ");
        double x, y;
        double.TryParse(Console.ReadLine(), out x);
        double.TryParse(Console.ReadLine(), out y);
        Console.WriteLine(G(x,y));
    }
}

