using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int.TryParse(Console.ReadLine(), out int n);
        int[] a = new int[n];
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"A[{i}] = ");
            int.TryParse(Console.ReadLine(), out a[i]);
        }
        int k = n;
        for (int i = 0; i < k-1; i++)
        {
            if ((a[i] + a[i + 1]) % 3 == 0)
            {
                a[i] = a[i] * a[i + 1];
                k--;
                for (int j = i + 1; j < k; j++)
                {
                    a[j] = a[j + 1];
                }
            }
        }
        int[] a2 = new int[k];
        for (int i = 0; i < k; i++)
        {
            a2[i] = a[i];
        }
        Console.WriteLine("Новый массив:");
        for (int i = 0; i < k; i++)
        {
            Console.Write(a2[i]+" ");
        }
        Console.WriteLine();
    }
}

