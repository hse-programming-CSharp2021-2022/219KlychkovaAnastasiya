using System;

class Program
{ 
    public static double Pow(double x,int n)
    {
        for (int i = 1; i < n; i++)
            x *= x;
        return x;
    }
    static void Main(string[] args)
    {
        double x,f;
        do
        {
            do
            {
                Console.Write("Введите x: ");
            } while (!double.TryParse(Console.ReadLine(), out x));

            f = 12 * Pow(x, 4) + 9 * Pow(x, 3) + 3 * Pow(x, 2) + 2 * x - 4;
            Console.WriteLine(f);
            Console.WriteLine("Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу.");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

