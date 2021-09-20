using System;

class Program
{
    public static int A(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m > 0 && n == 0) return A(m - 1, 1);
        else return A(m - 1, A(m, n - 1));
    }
    static void Main(string[] args)
    {
        int m, n;
        int.TryParse(Console.ReadLine(), out m);
        int.TryParse(Console.ReadLine(), out n);
        Console.WriteLine(A(m, n));
    }
}
