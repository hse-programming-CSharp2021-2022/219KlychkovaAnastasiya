using System;

namespace Task2
{
    class Program
    {
        public static double Sum(int n)
        {
            double sum=0;
            for(int i = 0; i < n; i++)
            {
                sum+=
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int k;
            int.TryParse(Console.ReadLine(), out k);
            Console.WriteLine("n\nsum");
            for(int n = 1; n <= k; n++)
            {
                Console.WriteLine(n + "\n" + Sum(n));
            }
        }
    }
}
