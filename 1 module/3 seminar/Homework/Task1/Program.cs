using System;

class Program
{
    public static bool G(double x, double y)
    {
        if (x > y && x > 0 && x * x + y * y <= 4)
            return true;
        else
            return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты (x,y): ");

        Console.WriteLine(G);
    }
}

