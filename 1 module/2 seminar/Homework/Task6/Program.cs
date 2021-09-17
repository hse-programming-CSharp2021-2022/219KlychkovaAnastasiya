using System;
using System.Globalization;
class Program
{
    public static double Percent(double num, int p)
    {
        double res = num / 100 * p;
        return res;
    }
    static void Main(string[] args)
    {
        double budget;
        int per;
        do
        {
            Console.Write("Введите бюджет: ");
            double.TryParse(Console.ReadLine(), out budget);
            Console.Write("Введите процент, выделенный на компьютерные игры: ");
            int.TryParse(Console.ReadLine(), out per);
            Console.WriteLine(Percent(budget, per).ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу.");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

