using System;


class Program
{
    public static long Fact(int a)
    {
        long res = 1;
        for (int i = 2; i <= a; i++)
            res *= i;
        return res;
    }
    public static double Sum1(double x)
    {
        double curSum=0,prevSum;
        int i = 2,sign = 1;
        do
        {
            prevSum = curSum;
            curSum += sign * (Math.Pow(2, i - 1) * Math.Pow(x, i) / Fact(i));
            sign *= (-1);
            i += 2;
        } while (prevSum < curSum);
        return curSum;
    }
    public static double Sum2(double x)
    {
        double curSum = 0, prevSum;
        int i = 0;
        do
        {
            prevSum = curSum;
            curSum += Math.Pow(x, i) / Fact(i);
            i ++;
        } while (prevSum < curSum);
        return curSum;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите x: ");
        double.TryParse(Console.ReadLine(), out double x);
        Console.WriteLine(Sum1(x));
        Console.WriteLine(Sum2(x));
    }
}

