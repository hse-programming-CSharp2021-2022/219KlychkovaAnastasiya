using System;
class Program
{
    static void Main()
    {
        double u, r, i, p;
        double.TryParse(Console.ReadLine(), out u);
        double.TryParse(Console.ReadLine(), out r);
        i = u / r;
        p = u * u / r;
        Console.WriteLine("I = " + i);
        Console.WriteLine("P = " + p);
    }
}
