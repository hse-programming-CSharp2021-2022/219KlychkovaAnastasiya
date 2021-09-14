using System;

class Program
{
    public static int Max(int x,int y)
    {
        if (x > y)
            return x;
        else
            return y;
    }
    public static int Min(int x, int y)
    {
        if (x < y)
            return x;
        else
            return y;
    }
    static void Main(string[] args)
    {
        int p;
        do {
            Console.Write("Введите трехзначное число: ");
            int.TryParse(Console.ReadLine(), out p);
            int res;
            int a, b, c;
            a = p % 10;
            b = p / 10 % 10;
            c = p / 100;
            res = Max(Max(a, b), c)*100;
            res +=(a+b+c- Max(Max(a, b), c)- Min(Min(a, b), c))*10;
            res += Min(Min(a, b), c);
            Console.WriteLine(res);
            Console.WriteLine("Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу.");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

