using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int count = 0;
        char[] glas = { 'а','о','у','э','и','я','ы','ё','ю','е','А','О','У','Э','И','Я','Ы','Ё','Е','Ю'};
        StringBuilder word = new("");
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ')
            {
                if (word.Length!=0 && Array.IndexOf(glas,word[0])!=-1)
                    count++;
                word.Clear();
            }
            else
                word.Append(input[i]);
        }
        if (Array.IndexOf(glas, word[0]) != -1)
            count++;
        Console.WriteLine(count);
    }
}


