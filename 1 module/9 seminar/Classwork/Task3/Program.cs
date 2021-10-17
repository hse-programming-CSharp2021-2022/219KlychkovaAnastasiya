using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        // input = String.Join(" ", input.Split(" ", StringSplitOptions.RemoveEmptyEntries));
        // Не знаю, является ли это "однопроходным" алгоритмом, поэтому решу еше другим способом:
        StringBuilder word = new("");
        StringBuilder result = new("");
        for ( int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                if (word.Length != 0)
                    word.Append(" ");
                result.Append(word);
                word.Clear();
            }
            else
                word.Append(input[i]);
        }
        if (word.Length != 0)
            word.Append(" ");
        result.Append(word);
        Console.WriteLine(result);
    }
}

