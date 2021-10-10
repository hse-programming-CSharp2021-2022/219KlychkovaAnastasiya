using System;

class Program
{
    public static int Comp1(int x,int y)
    {
        if (x % 2 == 0 && y % 2 != 0)
            return -1;
        else if (x % 2 == y % 2)
            return 0;
        else return 1;
    }

    public static int Count(int x)
    {
        int c = 0;
        while (x > 0)
        {
            c++;
            x /= 10;
        }
        return c;
    }

    public static int Comp2(int x, int y)
    {
        if (Count(x) > Count(y))
            return 1;
        else if (Count(x) < Count(y))
            return -1;
        else return 0;
    }
    public static int Sum(int x)
    {
        int s = 0;
        while (x > 0)
        {
            s += x % 10; ;
            x /= 10;
        }
        return s;
    }
    public static int Comp3(int x, int y)
    {
        if (Sum(x) > Sum(y))
            return 1;
        else if (Sum(x) < Sum(y))
            return -1;
        else return 0;
    }
    static void Main(string[] args)
    {
        int n;
        int.TryParse(Console.ReadLine(),out n);

        int[] a = new int[n];
        Random rand = new Random();
        for(int i = 0; i < n; i++)
        {
            a[i] = rand.Next(1001);
        }
        Array.Sort(a, Comp1);
        Array.ForEach(a, el => Console.Write(el + " "));
        Console.WriteLine();
        Array.Sort(a, Comp2);
        Array.ForEach(a, el => Console.Write(el + " "));
        Console.WriteLine();
        Array.Sort(a, Comp3);
        Array.ForEach(a, el => Console.Write(el + " "));
    }
}
