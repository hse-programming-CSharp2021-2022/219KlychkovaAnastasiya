using System;


class Program
{
    public static double[] Sin1(int n,double x)
    {
        double[] sin = new double[n];
        sin[0] = x;
        for(int i = 1; i < n; i++)
        {
            sin[i] = sin[i - 1] * -x * x / 2 / i / (2 * i + 1);
        }
        return sin;
    }
    public static double SinX(double[] sin)
    {
        double sum = 0, oldSum;
        int i=0;
        do
        {
            oldSum = sum;
            sum += sin[i];
            i++;
        } while (oldSum < sum);
        return sum;
    }
    static void Main(string[] args)
    {
        int n;
        int.TryParse(Console.ReadLine(), out n);
        double x;
        double.TryParse(Console.ReadLine(), out x);
        double[] sin = Sin1(n, x);
        Console.WriteLine($"sin({x}) = {SinX(sin)}");
        Console.WriteLine($"sin({x}) = {Math.Sin(x)}");
    }
}

