using System;

class Program
{
    public static void Print(char[] mas)
    {
        foreach (var i in mas)
            Console.Write(i + " ");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int k);
        char[] arr = new char[k];
        Random rand = new Random();
        for(int i = 0; i < k; i++)
        {
            arr[i] = (char)rand.Next('A', 'Z' + 1);
        }
        Print(arr);
        char[] copy = new char[k];
        Array.Copy(arr, copy,k);

        Array.Sort(copy);
        Print(copy);

        Array.Reverse(copy);
        Print(copy);
    }
}
