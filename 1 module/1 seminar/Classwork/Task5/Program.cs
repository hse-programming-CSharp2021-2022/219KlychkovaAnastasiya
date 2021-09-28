using System;

class Program
{
    static void Main(string[] args)
    {
        int x, y;
        int.TryParse(Console.ReadLine(), out x);
        int.TryParse(Console.ReadLine(), out y);
        Console.WriteLine(x - y);
        Console.WriteLine(x * y);
        Console.WriteLine(x / y);
        Console.WriteLine(x % y);
        Console.WriteLine(x << y);
        Console.WriteLine(x >> y);
    }
}

