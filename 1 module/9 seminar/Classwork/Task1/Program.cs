using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string[] str = (Console.ReadLine()).Split(";",StringSplitOptions.RemoveEmptyEntries);
        char[] glas = { 'a', 'e', 'i', 'u', 'y', 'o', 'A', 'E', 'I', 'U', 'Y', 'O' };
        string abr = "";
        for(int i = 0; i < str.Length; i++)
        {
            string[] words = str[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for(int j = 0; j < words.Length; j++)
            {
                int f = words[j].IndexOfAny(glas);
                
                abr += words[j].Substring(0, f + 1);
            }
            Console.WriteLine(abr);
            abr = "";
        }
    }
}

