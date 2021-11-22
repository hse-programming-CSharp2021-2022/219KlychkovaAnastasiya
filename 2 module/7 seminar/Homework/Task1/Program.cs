using System;
using System.Text;
namespace Task1
{
    class Program
    {
        static Random rnd = new Random();
        private static string CreateName()
        {
            StringBuilder name = new StringBuilder(((char)rnd.Next('A', 'Z' + 1)).ToString());
            for (int i = 0; i < rnd.Next(2, 11); i++)
            {
                name.Append(rnd.Next(2) == 0 ? (char)rnd.Next('A', 'Z' + 1) : (char)rnd.Next('a', 'z' + 1));
            }
            return name.ToString();
        }
        private static double CreateSpeed() => rnd.Next(10, 17) + rnd.NextDouble();
        static void Main(string[] args)
        {
            do
            {
                int n;
                do
                {
                    Console.Write("Введите количество существ: ");
                } while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 100);
                Creature[] creatures = new Creature[n];

                for (int i = 0; i < n; i++)
                {
                    int probability = rnd.Next(10) + 1;
                    if (probability <= 4)
                        creatures[i] = new Dwarf(CreateName(), CreateSpeed(), rnd.Next(-50, 51));
                    else if (probability <= 8)
                        creatures[i] = new Elf(CreateName(), CreateSpeed());
                    else creatures[i] = new Creature(CreateName(), CreateSpeed());
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(creatures[i]);
                    if (creatures[i] is Dwarf)
                        Dwarf.MakeNewStaff();
                }
                Console.WriteLine("Для выхода из программы введите ESC, для повторения решения – любую другую клавишу.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
