using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine("Приветствую вас, {0}!", name);
        Console.WriteLine("Нажмите ENTER для завершения!");
        Console.ReadLine();
    }
}

