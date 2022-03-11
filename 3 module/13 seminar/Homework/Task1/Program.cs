using System;
using System.Collections;
namespace Task1
{
    class Fibbonacci
    {
        int first = 1;
        int second = 1;
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

    class TriangleNums
    {
        public IEnumerable NextElement(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return 0.5 * i * (i + 1);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fib = new Fibbonacci();
            var tr = new TriangleNums();
            int m = 10;
            double[] sum = new double[10];
            int i=0;
            foreach(var el in fib.NextElement(m))
            {
                Console.WriteLine(el);
                sum[i] = (int)el;
                i++;
            }
            Console.WriteLine("****");
            i = 0;
            foreach (var el in tr.NextElement(m))
            {
                Console.WriteLine(el);
                sum[i] += (double)el;
                i++;
            }
            Console.WriteLine("Result:");
            foreach (var el in sum)
                Console.WriteLine(el);
        }
    }
}
