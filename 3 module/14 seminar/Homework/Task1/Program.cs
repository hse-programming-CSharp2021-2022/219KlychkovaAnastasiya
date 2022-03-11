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
                numbers[i] = rnd.Next(-1000, 1001);
            foreach (var number in numbers)
                Console.Write(number + " ");
            Console.WriteLine();
            //1.Составить LINQ - выражение, формирующее коллекцию их квадратов.
            var z1 = from num in numbers select num * num;
            foreach (int number in z1)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("*******");

            //2.Составить LINQ - выражение, выбирающее только положительные двузначные числа.
            var z2 = from num in numbers where num > 0 && (int)Math.Log10(num) == 1 select num;
            foreach (int number in z2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("*******");

            //3.Составить LINQ - выражение, выбирающее только чётные числа и сортирующее их по убыванию.
            var z3 = from num in numbers where num % 2 == 0 orderby num descending select num;
            foreach (int number in z3)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("*******");
            //4.Составить LINQ - выражение, группирующее числа по порядку(сотни, десятки, единицы)
            var z4 = from num in numbers group num by (int)Math.Log10(Math.Abs(num)) into newN select newN;
            foreach (var nums in z4)
            {
                Console.WriteLine("------");
                foreach (var num in nums)
                {
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("*******");
        }
    }
}
