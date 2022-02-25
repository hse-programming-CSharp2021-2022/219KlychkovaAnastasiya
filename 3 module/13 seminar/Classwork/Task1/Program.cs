using System;
using System.Collections;
namespace Task1
{
    class Fibbonacci
    {
        int curr=0;
        int next=1;
        public IEnumerable NextElement(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return x0;
                int s = x0 + x1;
                x0 = x1;
                x1 = s;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
