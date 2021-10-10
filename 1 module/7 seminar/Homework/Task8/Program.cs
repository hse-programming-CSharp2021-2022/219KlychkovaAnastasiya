using System;

class Program
{
    public static double[] MakeArray(int n)
    {
        double[] a = new double[n];
        for (int i = 0; i < n; i++)
            a[i] = i * (i + 1) / 2 % n;
        return a;
    }

    public static void Norm(ref double[] a)
    {
        double max= -1;
        for (int i = 0; i < a.Length; i++)
            if (Math.Abs(a[i]) > max)
                max = Math.Abs(a[i]);
        for (int i = 0; i < a.Length; i++)
            a[i] /= max;
    }

    public static void Print(double[] a)
    {
        foreach (double i in a)
            Console.Write("{0:F3} ",i);
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        int n;
        Console.Write("Введите количество элементов в массиве: ");
        int.TryParse(Console.ReadLine(), out n);
        double[] arr = MakeArray(n);
        Print(arr);
        Norm(ref arr);
        Print(arr);
    }
}

