using System;
class Program
{
    public static int Comp(int[] x, int[] y)
    {
        if (x.Length < y.Length)
            return 1;
        else if (x.Length > y.Length)
            return -1;
        else
            return 0;
    }

    static void Main(string[] args)
    {
        int n;
        int.TryParse(Console.ReadLine(), out n);
        int[][] a = new int[n][];
        Random rand = new Random();
        for (int i = 0; i < n; i++,Console.WriteLine())
        {
            int l = rand.Next(5, 16);
            a[i] = new int[l];
            for(int j = 0; j < l; j++)
            {
                a[i][j] = rand.Next(-10, 11);
                Console.Write(a[i][j] + " ");
            }
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            Array.Sort(a[i], (x, y) => y.CompareTo(x));
        }
        Array.Sort(a, Comp);
        for(int i = 0; i < n; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
                Console.Write(a[i][j] + " ");
            Console.WriteLine();
        }
    }
}

