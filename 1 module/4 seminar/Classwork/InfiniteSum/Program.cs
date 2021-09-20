using System;
class Program
{
    static void Main(string[] args)
    {
        float sum1=0;
        double sum2=0;
        float prevSum;
        double prevSum2;
        int i = 1;
        do
        {
            prevSum = sum1;
            sum1 = 1 / (float)(i * (i + 1) * (i + 2));
            i++;
        } while (prevSum < sum1);
        Console.WriteLine(sum1);
        do
        {
            prevSum2 = sum2;
            sum2 = 1 / (double)(i * (i + 1) * (i + 2));
            i++;
        } while (prevSum2 < sum2);
        Console.WriteLine(sum2);
    }
}
