using System;
using System.IO;
namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            using (BinaryWriter writer = new BinaryWriter(File.Open("Numbers.txt", FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < 10; i++)
                {
                    writer.Write(rnd.Next(1, 100));
                }
            }
        }
    }
}
