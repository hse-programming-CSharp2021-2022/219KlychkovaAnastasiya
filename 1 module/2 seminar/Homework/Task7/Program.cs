using System;
class Program
{
    public static void IntFrac(double num, out int integer, out double fraction)
    {
        integer = (int)num;
        fraction = num - integer;
    }
    public static void Square(double num, out double root, out double power)
    {
        if (num >= 0)
            root = Math.Sqrt(num);
        else
            root = double.NaN;
        power = num * num;
    }
    static void Main(string[] args)
    {
        double number;
        do
        {
            Console.Write("Введите число: ");
        } while (!double.TryParse(Console.ReadLine(), out number));
        double fraction;
        int integer;
        double root;
        double power;
        do
        {
            IntFrac(number, out integer, out fraction);
            Console.WriteLine($"Целая часть:\t{integer}\nДробная часть:\t{fraction}");
            Square(number, out root, out power);
            Console.WriteLine($"Квадрат:\t{power}");
            if (root != double.NaN)
                Console.WriteLine($"Корень:\t{root}");
            else
                Console.WriteLine("Невозможно вычислить корень");
            Console.WriteLine("Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу.");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

