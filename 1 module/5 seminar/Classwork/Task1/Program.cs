using System;

namespace Task1
{
    class Program
    {
        public static void Sums(uint number,out uint SumEven, out uint SumOdd)
        {
            SumEven = 0;
            SumOdd = 0;
            int flag = 1;
            while (number > 0)
            {
                if (flag > 0)
                    SumEven += number % 10;
                else 
                    SumOdd+= number % 10;
                number /= 10;
                flag *= -1;
            }
        }
        static void Main(string[] args)
        {
            uint num;
            uint.TryParse(Console.ReadLine(), out num);
            Sums(num, out uint Sum1, out uint Sum2);
            Console.WriteLine($"Сумма четных {Sum1}");
            Console.WriteLine($"Сумма нечетных {Sum2}");
        }
    }
}
