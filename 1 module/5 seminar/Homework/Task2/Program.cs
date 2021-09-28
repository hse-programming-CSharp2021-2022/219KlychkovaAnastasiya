using System;

class Program
{
    public static bool Shift(ref char ch)
    {
        int num = (int)ch;
        if (num < 97 || num > 122)
            return false;
        else
        {
            for (int i = 0; i < 4; i++)
                num++;
            ch = (char)num;
            return true;
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Введите символ: ");
        char.TryParse(Console.ReadLine(), out char ch);
        if (Shift(ref ch))
            Console.WriteLine(ch);
        else
            Console.WriteLine("Ошибка!");
    }
}
