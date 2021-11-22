using System;
using System.IO;
namespace Task1
{
    public class MyException : Exception
    { 
        public MyException() : base() { }
        public MyException(string message) : base(message) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1:
            int[] arr = new int[2];
            try
            {
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            // 2:
            string str = null;
            try
            {
                str.Split(" ");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }
            // 3:
            try
            {
                int[,] arr2 = new int[2,5];
                Array.Sort(arr2);
            }
            catch (RankException)
            {
                Console.WriteLine("RankException");
            }
            // 4:
            try
            {
                int.Parse("try");
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }
            // 5:
            int z = 0;
            int a;
            try
            {
                a = 10 / z;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }
            // 6:
            try
            {
                str = "aa";
                str.IndexOf("a", 3);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("ArgumentOutOfRangeException");
            }
            // 7:
            try
            {
                Directory.SetCurrentDirectory("qwertyuio");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("DirectoryNotFoundException");
            }
            // 8:
            try
            {
                object obj = 5;
                string s = (string)obj;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("InvalidCastException");
            }
            // 9:
            try
            {
                str = null;
                "str".IndexOf(str);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException");
            }
            // 10:
            try
            {
                Directory.GetLastAccessTime("<>/");
            }
            catch (IOException)
            {
                Console.WriteLine("IOException");
            }

            try
            {
                throw new MyException("Мое исключение");
            }
            catch (MyException my)
            {
                Console.WriteLine(my.Message);
            }
        }
    }
}
