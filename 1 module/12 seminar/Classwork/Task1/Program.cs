using System;
using System.Linq;

class Program
{
    public static bool P(int n)
    {
        string s = n.ToString();
        for (int i = 0; i < s.Length / 2; i++)
            if (s[i] != s[s.Length - i - 1])
                return false;
        return true;
    }

    public static int DigitSum(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return sum;
    }

    public static int DigitCount(int n)
    {
        int count = 0;
        while (n > 0)
        {
            count++;
            n /= 10;
        }
        return count;
    }

    public static int DigitMax(int n)
    {
        int max = 0;
        while (n > 0)
        {
            if (n % 10 > max) max = n % 10;
            n /= 10;
        }
        return max;
    }

    static void Main(string[] args)
    {
        int.TryParse(Console.ReadLine(), out int n);
        int[] arr = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
            arr[i] = rnd.Next(1, 10001);
        foreach (var i in arr)
            Console.Write(i + " ");
        Console.WriteLine("\n");

        var sel1 = from t in arr where t >= 10 && t < 100 && t % 3 == 0 select t;
        foreach (var i in sel1)
            Console.Write(i + " ");
        Console.WriteLine("\n");

        var sel2 = from t in arr where P(t) orderby t select t;
        foreach (var i in sel2)
            Console.Write(i + " ");
        Console.WriteLine("\n");

        var sel3 = arr.OrderBy(t=>DigitSum(t)).ThenBy(t=>t);
        foreach (var i in sel3)
            Console.Write(i + " ");
        Console.WriteLine("\n");

        var sel4 = arr.Where(t => DigitCount(t)==4).Sum(t=>t);
        Console.Write(sel4);
        Console.WriteLine("\n");

        var sel5 = arr.Where(t => DigitCount(t) == 2).Min(t => t);
        Console.Write(sel5);
        Console.WriteLine("\n");

        var sel6 = from t in arr select DigitMax(t);
        foreach (var i in sel6)
            Console.Write(i + " ");
        Console.WriteLine("\n");
    }
}

