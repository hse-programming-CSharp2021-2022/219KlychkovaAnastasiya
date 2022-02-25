using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        public static int[] numbers;
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            numbers = new int[n];
            Random rnd = new();
            for (int i = 0; i < n; i++)
                numbers[i] = rnd.Next(-10000, 10001);

            //1) Составить LINQ-выражение, формирующее коллекцию, содержащую их последние цифры.
            var z1 = from g in numbers
                     select Math.Abs(g) % 10;
            foreach (int digit in z1)
            {
                Console.WriteLine(digit);
            }
            Console.WriteLine("***");
            var z1_2 = numbers.Select(g => Math.Abs(g) % 10);
            foreach (int digit in z1_2)
            {
                Console.WriteLine(digit);
            }
            Console.WriteLine("\n\n");
            //2) Сгруппировать коллекцию по последней цифре.
            var z2 = from g in numbers
                     group g by Math.Abs(g) % 10 into newG
                     select newG;
            foreach (var digit in z2)
            {
                Console.WriteLine(digit.Key);
                foreach (var d in digit)
                {
                    Console.WriteLine(d);
                }
            }
            Console.WriteLine("***");
            var z2_2 = numbers.GroupBy(g => Math.Abs(g) % 10);
            foreach (var digit in z2_2)
            {
                Console.WriteLine(digit.Key);
                foreach (var d in digit)
                {
                    Console.WriteLine(d);
                }
            }
            Console.WriteLine("\n\n");

            //3) Составить запрос, формирующий коллекцию четных положительных чисел и выводит их количество
            var z3 = (from g in numbers
                      where g % 2 == 0 && g>0
                      select g).Count();
            Console.WriteLine("count "+ z3);
            Console.WriteLine("***");
            var z3_2 = numbers.Where(g => g % 2 == 0 && g > 0).Count();
            Console.WriteLine("count " + z3_2);
            Console.WriteLine("\n\n");

            //4) Составить запрос, находящий сумму всех четных чисел
            var z4 = (from g in numbers
                      where g % 2 == 0 
                      select g).Sum();
            Console.WriteLine("sum " + z4);
            Console.WriteLine("***");
            var z4_2 = numbers.Where(g => g % 2 == 0).Sum();
            Console.WriteLine("sum " + z4_2);
            Console.WriteLine("\n\n");

            //5) Составить запрос, который сортирует числа по 1 и по последней цифре числа
            var z5 = from g in numbers
                     orderby (int)(Math.Abs(g) / Math.Pow(10, (int)Math.Log10(Math.Abs(g)))), Math.Abs(g) % 10
                     select g;
            foreach (int number in z5)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("***");
            var z5_2 = numbers.OrderBy(g => (int)(Math.Abs(g) / Math.Pow(10, (int)Math.Log10(Math.Abs(g))))).ThenBy(g=>Math.Abs(g) % 10);
            foreach (int number in z5_2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
