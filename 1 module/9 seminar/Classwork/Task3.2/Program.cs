using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int count = 0;
        StringBuilder word = new("");
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                if (word.Length > 4)
                    count++;
                word.Clear();
            }
            else
                word.Append(input[i]);
        }
        if (word.Length > 4)
            count++;
        Console.WriteLine(count);
    }
}

