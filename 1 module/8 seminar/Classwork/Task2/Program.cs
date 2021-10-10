using System;
class Program
{
    public static void IntFracArray(double[] arr)
    {
        int[] b = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++)
            b[i] = (int)arr[i];
        for (int i = 0; i < arr.Length; i++)
            arr[i] =Math.Round(arr[i]-b[i],4);
        Array.Sort(b);
        Array.Sort(arr);
        Console.WriteLine("Целый массив:");
        Array.ForEach(b, el => Console.Write(el + " "));
        Console.WriteLine();
        Console.WriteLine("Дробный массив:");
        Array.ForEach(arr, el => Console.Write(el + " "));
    }
    static void Main(string[] args)
    {
        int n;
        int.TryParse(Console.ReadLine(), out n);

        double[] a = new double[n];

        Random rand = new Random();
        for(int i = 0; i < n; i++)
        {
            a[i] = Math.Round((rand.Next(-10, 10) + rand.NextDouble()),4);
        }
        Console.WriteLine("Исходный массив:");
        Array.ForEach(a, el => Console.Write(el + " "));
        Console.WriteLine();
        IntFracArray(a);
    }
}
