using System;
class Program
{
    static void Main(string[] args)
    {
        double a;
        double delta;
        double sqare=0;
        double.TryParse(Console.ReadLine(), out a);
        double.TryParse(Console.ReadLine(), out delta);
        for(int i = 0; i < a / delta; i++)
        {
            sqare += ((i * delta) * (i * delta) + ((i + 1) * delta) * ((i + 1) * delta)) / 2 * delta;
        }
        if (a % delta != 0)
        {
            sqare += ((a - (a % delta)) * (a - (a % delta)) + a * a) / 2 * (a % delta);
        }
        Console.WriteLine(sqare);
    }
}
