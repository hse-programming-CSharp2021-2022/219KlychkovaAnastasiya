﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        private static readonly Random Random = new Random();
        private static double Integral(Func<double, double> func, int a, int b, int n)
        {
            int correct = 0; int minX = a, maxX = b;
            int maxY = (int)Math.Max(func(a), func(b)) + 1;
            for (int i = 0; i < n; i++)
            {
                double x = Random.Next(minX, maxX) + Random.NextDouble();
                double y = Random.Next(0, maxY) + Random.NextDouble();
                if (y <= func(x)) { correct++; }
            }
            return (double)correct / n * (maxX - minX) * maxY;
        }
        private static double Integral2(Func<double, double> func, int a, int b, int n)
        {
            int correct = 0; int minX = a, maxX = b;
            int maxY = (int)Math.Max(func(a), func(b)) + 1;
            Task[] tasks = new Task[n];
            for (int i = 0; i < n; i++)
            {
                tasks[i]=new(() =>
                {
                    double x = Random.Next(minX, maxX) + Random.NextDouble();
                    double y = Random.Next(0, maxY) + Random.NextDouble();
                    if (y <= func(x)) { correct++; }
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} {x} {y} {correct}");
                });
                tasks[i].Start();
            }
            Task.WaitAll();
            return (double)correct / n * (maxX - minX) * maxY;
        }



        public static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Console.WriteLine("Integral");
            Console.WriteLine(Integral(x => x * x, 0, 4, (int)1e7));
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds * 1.0 / 1000);



            timer = Stopwatch.StartNew();
            Console.WriteLine("Integral");
            Task<double>[] t = {
               Task<double>.Run(() => Integral(x => x * x, 0, 1, (int)1e7)),
               Task<double>.Run(() => Integral(x => x * x, 1, 2, (int)1e7)),
               Task<double>.Run(() => Integral(x => x * x, 2, 3, (int)1e7)),
               Task<double>.Run(() => Integral(x => x * x, 3, 4, (int)1e7)) };

            Task.WaitAll(t);
            double res = 0;
            for (int i = 0; i < 4; i++)
            {
                res += t[i].Result;
            }
            Console.WriteLine(res);
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds * 1.0 / 1000);



            timer = Stopwatch.StartNew();
            Console.WriteLine("Integral");
            Console.WriteLine(Integral2(x => x * x, 0, 4, 5));
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds * 1.0 / 1000);
        }
    }
}

