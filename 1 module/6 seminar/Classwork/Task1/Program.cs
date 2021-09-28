using System;


class Program
{
    static void Main(string[] args)
    {
        uint number;
        uint.TryParse(Console.ReadLine(),out number);
        for(int i = 9; i >= 0; i--)
        {
            uint copy = number;
            while (copy > 0)
            {
                if (copy % 10 == i)
                    Console.Write(i);
                copy /= 10;
            }
        }
    }
}

