using System;


class Program
{
    static void Main(string[] args)
    {
        int n = 100;
        int[] arr = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
            arr[i] = i + 1;

        for (int i = n - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);
            int tmp = arr[j];
            arr[j] = arr[i];
            arr[i] = tmp;
        }

        Array.Resize(ref arr, 99);
        int s = 0;
        foreach (int i in arr)
            s += i;
        Console.WriteLine(5050 - s);
    }
}

