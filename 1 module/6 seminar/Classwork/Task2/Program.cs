using System;


class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[6];
        for (int i = 0; i < 6; i++)
        {
            int.TryParse(Console.ReadLine(), out a[i]);
        }
        int k = 6;
        for (int i = 0; i < k-1; i++)
        {
            if ((a[i] + a[i + 1]) % 3 == 0)
            {
                a[i] = a[i] * a[i + 1];
                for (int j = i + 1; j < k; j++)
                {
                    a[j] = a[j + 1];
                }
                k--;
            }
        }
        int[] a2 = new int[k];
        for (int i = 0; i < k; i++)
        {
            a2[i] = a[i];
        }
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine(a2[i]);
        }
    }
}

