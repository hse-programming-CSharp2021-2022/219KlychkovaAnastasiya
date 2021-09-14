using System;
class Program
{
    static void Main()
    {
        int code;
        int.TryParse(Console.ReadLine(), out code);
        char a = (char)code;
        Console.WriteLine(a);
    }
}
