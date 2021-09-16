using System;

namespace Task2
{
    class Program
    {
        public static void F1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * i);
            }
        }
        public static void F2()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i * i);
                i++;
            }
        }
        public static void F3()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i * i);
                i++;
            } while (i <= 10);
        }
        static void Main(string[] args)
        {
            F1();
            F2();
            F3();
        }
    }
}
