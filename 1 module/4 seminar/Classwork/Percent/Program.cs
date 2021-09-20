using System;

class Program
{
    public static void Total(double k, double r, uint n)
    {
        Console.WriteLine("год\tсумма");
        for (int i = 1; i <= n; i++)
        {
            k = k * (1 + r / 100);
            Console.WriteLine(i + "\t" + k);
        }
    }
    static void Main(string[] args)
    {
        double k, r;
        uint n;
        double.TryParse(Console.ReadLine(), out k);
        double.TryParse(Console.ReadLine(), out r);
        uint.TryParse(Console.ReadLine(), out n);
        Total(k, r, n);
    }
}

