using System;
using System.IO;
using System.Collections.Generic;
namespace Project2
{
    class Program
    {
        static readonly string path = @"D:\Документы\Programs\C#\219KlychkovaAnastasiya\3 module\11 seminar\Homework\Project1\bin\Debug\net5.0\Numbers.txt";
        static void Main(string[] args)
        {
            List<int> numbers = new();
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                while (reader.PeekChar() > -1)
                {
                    numbers.Add(reader.ReadInt32());
                    Console.Write(numbers[^1] + " ");
                }
                int.TryParse(Console.ReadLine(), out int n);
                if (n > 1 && n < 100)
                {
                    int min = 1000;
                    int ind = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (Math.Abs(n - numbers[i]) < min)
                        {
                            min = Math.Abs(n - numbers[i]);
                            ind = i;
                        }
                    }
                    numbers[ind] = n;
                }
            }
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < numbers.Count; i++)
                    writer.Write(numbers[i]);
            }
            numbers.Clear();
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                while (reader.PeekChar() > -1)
                {
                    numbers.Add(reader.ReadInt32());
                    Console.Write(numbers[^1] + " ");
                }
            }
        }
    }
}
