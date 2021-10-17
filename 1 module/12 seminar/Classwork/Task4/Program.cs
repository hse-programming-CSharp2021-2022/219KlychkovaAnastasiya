using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int maxLength=0;
        string result="";
        foreach (Match mat in Regex.Matches(input, @"\d+"))
        {
            if (mat.Length > maxLength)
            {
                maxLength = mat.Length;
                result = mat.Value;
            }
        }
        Console.WriteLine(result);
    }
}