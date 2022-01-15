using System;

namespace Task1
{
    delegate int Cast(double number);
    class Program
    {
        public static int M1(double num)
        {
            int r = (int)num;
            return r % 2 == 0 ? r : r + 1;
        }
        public static int M2(double num)
        {
            if (num > 0)
            {
                int count = 0;
                if (num >= 1)
                    while (num >= 10)
                    {
                        count++;
                        num /= 10;
                    }
                else
                    while (num < 1)
                    {
                        count--;
                        num *= 10;
                    }
                return count;
            }
            else return 0;
        }
        static void Main(string[] args)
        {
            Cast cast1 = delegate (double num)
            {
                int r = (int)num;
                return r % 2 == 0 ? r : r + 1;
            };

            //Определение. Стандартным видом числа b называют его запись в виде а*10^n , где
            //1 <= a < 10 и n -целое число. Число n называется порядком числа b
            Cast cast2 = delegate (double num)
            {
                if (num > 0)
                {
                    int count = 0;
                    if (num >= 1)
                        while (num >= 10)
                        {
                            count++;
                            num /= 10;
                        }
                    else
                        while (num < 1)
                        {
                            count--;
                            num *= 10;
                        }
                    return count;
                }
                else return 0;
            };

            //тестирование
            Console.WriteLine(cast1(3.2));
            Console.WriteLine(cast2(2600.4));
            Console.WriteLine(cast2(0.01));
            Console.WriteLine(cast2(0.34));
            Console.WriteLine();

            Cast jointCast = cast1 + cast2;
            Console.WriteLine(jointCast(1.5));
            Console.WriteLine();

            // замена на лямбда-выражения
            cast1 = num =>
            {
                int r = (int)num;
                return r % 2 == 0 ? r : r + 1;
            };
            cast2 = num =>
            {
                if (num > 0)
                {
                    int count = 0;
                    if (num >= 1)
                        while (num >= 10)
                        {
                            count++;
                            num /= 10;
                        }
                    else
                        while (num < 1)
                        {
                            count--;
                            num *= 10;
                        }
                    return count;
                }
                else return 0;
            };

            //использование Invoke для вызова делегата
            Console.WriteLine(jointCast?.Invoke(1.5));
            Console.WriteLine();

            jointCast -= num =>
            {
                int r = (int)num;
                return r % 2 == 0 ? r : r + 1;
            };
            foreach (Cast d in jointCast.GetInvocationList())
                Console.WriteLine(d?.Invoke(1.5));
            Console.WriteLine();

            // с помощью методов
            cast1 = M1;
            cast2 = M2;
            jointCast = cast1 + cast2;
            jointCast -= M1;
            foreach (Cast d in jointCast.GetInvocationList())
                Console.WriteLine(d?.Invoke(1.5));
        }
    }
}
