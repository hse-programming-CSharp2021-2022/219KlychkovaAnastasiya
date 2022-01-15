using System;
using System.Text;
using System.Text.RegularExpressions;
namespace Task3
{
    class Program
    {
        public static string RemoveDigits(string str) => Regex.Replace(str, @"\d", "");

        public static string RemoveSpaces(string str) => str.Replace(" ", "");

        delegate string ConvertRule(string str);
        static void Main(string[] args)
        {
            ConvertRule convert = new ConvertRule(RemoveDigits);
            convert += RemoveSpaces;

            string[] test = { "qwe123qwe", "asd asd asd23", "qwe 4569 0" };
            for (int i = 0; i < test.Length; i++)
            {
                foreach (ConvertRule r in convert.GetInvocationList())
                {
                    Console.WriteLine(test[i] + " -> " + r(test[i]));
                }
                Console.WriteLine();
            }
        }
    }
}
