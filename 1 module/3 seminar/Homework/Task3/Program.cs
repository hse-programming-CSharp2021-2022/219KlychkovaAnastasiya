using System;

class Program
{
    public static double G(double x)
    {
        if (x <= 0.5)
            return Math.Sin(Math.PI / 2);
        else
            return Math.Sin(Math.PI * (x - 1) / 2);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите x: ");
        double x;
        double.TryParse(Console.ReadLine(), out x);
        Console.WriteLine(G(x));
    }
}

