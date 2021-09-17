using System;

class Program
{
    public static string C(int x)
    {
        string str="";
        while (x > 0)
        {
            str += (x % 10);
            x /= 10;
        }
        return str;
    }
    static void Main(string[] args)
    {
        int x;
        string n;
        do
        {
            do
            {
                Console.Write("Введите четырехзначное число: ");
            } while (!int.TryParse(Console.ReadLine(), out x) || !(x / 10000 == 0) || x / 1000 == 0);
            n = C(x);
            Console.WriteLine(n);
            Console.WriteLine("Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу.");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

