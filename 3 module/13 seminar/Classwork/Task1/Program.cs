using System;
using System.Collections;
namespace Task1
{
    class Fibbonacci
    {
        int first=1;
        int second=1;
        public IEnumerable NextElement(int n)
        {
            int curr = first;
            int next = second;
            for (int i = 0; i < n; i++)
            {
                yield return curr;
                int sum = curr + next;
                curr = next;
                next = sum;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fib = new Fibbonacci();
            foreach (var el in fib.NextElement(5))
                Console.WriteLine(el);
            Console.WriteLine("***");
            foreach(var el in fib.NextElement(10))
                Console.WriteLine(el);
        }
    }
}
