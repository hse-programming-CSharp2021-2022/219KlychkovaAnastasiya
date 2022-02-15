using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("Alphabet.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                long len = fileStream.Length;
                if (len < 3)
                {
                    fileStream.Seek(len, SeekOrigin.Begin);
                    byte bt = (byte)('A' + len);
                    fileStream.WriteByte(bt);
                }
                fileStream.Seek(0, SeekOrigin.Begin);
                int next = 0;
                while (next != -1)
                {
                    next = fileStream.ReadByte();
                    byte[] read = { (byte)next };
                    if (next != -1)
                        Console.Write(System.Text.Encoding.Default.GetString(read) + " ");
                }
            }
        }
    }
}
