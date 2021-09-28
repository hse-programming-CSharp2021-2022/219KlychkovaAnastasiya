using System;

class Program
{
    public static void NodNok(uint a,uint b,out uint nod,out uint nok)
    {
        uint copyA=a, copyB=b;
        while (copyA != copyB)
        {
            if (copyA > copyB)
                copyA -= copyB;
            else
                copyB -= copyA;
        }
        nod = copyA;
        nok = a * b / nod;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите a: ");
        uint.TryParse(Console.ReadLine(), out uint a);
        Console.WriteLine("Введите b: ");
        uint.TryParse(Console.ReadLine(), out uint b);
        NodNok(a, b, out uint nod, out uint nok);
        Console.WriteLine("НОД: " + nod);
        Console.WriteLine("НОК: " + nok);
    }
}
