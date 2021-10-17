using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        foreach (Match mat in Regex.Matches(input, @"\b[a-zA-Z]{4}\b")) 
        {
            Console.Write(mat.Value + "  ");
        }
    }
}

