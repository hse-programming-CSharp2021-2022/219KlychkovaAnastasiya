using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string[] str = (Console.ReadLine()).Split(";",StringSplitOptions.RemoveEmptyEntries);
        char[] glas = { 'a', 'e', 'i', 'u', 'y', 'o', 'A', 'E', 'I', 'U', 'Y', 'O' };
        StringBuilder abr = new ("");
        for(int i = 0; i < str.Length; i++)
        {
            string[] words = str[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for(int j = 0; j < words.Length; j++)
            {
                int f = words[j].IndexOfAny(glas);
                abr.Append(Char.ToUpper(words[j][0])+words[j].Substring(1, f));
            }
            Console.WriteLine(abr);
            abr.Clear();
        }
    }
}

