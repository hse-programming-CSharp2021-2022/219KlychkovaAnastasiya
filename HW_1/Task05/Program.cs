using System;
class Program
{
    static void Main()
    {
        double k1, k2, g;
        double.TryParse(Console.ReadLine(), out k1);
        double.TryParse(Console.ReadLine(), out k2);
        g = Math.Sqrt(k1 * k1 + k2 * k2);
        Console.WriteLine(g);
    }
}
