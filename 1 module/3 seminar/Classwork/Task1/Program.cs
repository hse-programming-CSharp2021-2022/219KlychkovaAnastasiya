using System;

class Program
{
    public static bool Function1(bool p, bool q)
    {
        return !(p & q) & !(p | !q);
    }
    public static void Function2(bool p, bool q, out bool res)
    {
        res= !(p & q) & !(p | !q);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Function1(true, true));
        Console.WriteLine(Function1(true, false));
        Console.WriteLine(Function1(false, true));
        Console.WriteLine(Function1(true, false));
        Console.WriteLine();
        bool res;
        Function2(true, true, out res);
        Console.WriteLine(res);
        Function2(true, false, out res);
        Console.WriteLine(res);
        Function2(false, true, out res);
        Console.WriteLine(res);
        Function2(false, false, out res);
        Console.WriteLine(res);
    }
}


