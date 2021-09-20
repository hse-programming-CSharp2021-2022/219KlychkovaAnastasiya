using System;

class Program
{
    public static int Min3(int a, int b, int c)
    {
        if (a < b && a < c)
            return a;
        else if (b < c && b < a)
            return b;
        else
            return c;
    }
    static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Введите номера аудиторий: ");
        int.TryParse(Console.ReadLine(), out a);
        int.TryParse(Console.ReadLine(), out b);
        int.TryParse(Console.ReadLine(), out c);
        a %= 100;
        b %= 100;
        c %= 100;
        Console.WriteLine(Min3(a, b, c));
    }
}

