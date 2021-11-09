using System;
using Cinderella;
using System.Collections.Generic;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("N: ");
            } while (!int.TryParse(Console.ReadLine(), out N));
            Random rnd = new Random();
            Something[] sth = new Something[N];
            for(int i = 0; i < N; i++)
            {
                if (rnd.Next(2) == 0)
                    sth[i] = new Lentil();
                else
                    sth[i] = new Ashes();
                Console.WriteLine(sth[i]);
            }
            List<Lentil> l = new List<Lentil>();
            List<Ashes> a = new List<Ashes>();
            for(int i = 0; i < N; i++)
            {
                if (sth[i] is Lentil)
                    l.Add((Lentil)sth[i]);
                else
                    a.Add((Ashes)sth[i]);
            }
            foreach (var i in l)
                Console.WriteLine(i + " " + i.Weight);
            foreach (var i in a)
                Console.WriteLine(i + " " + i.Volume);
        }
    }
}
