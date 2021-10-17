using System;
using System.Text;
class Program
{
    public static string ConvertHex2Bin(string HexNumber)
    {
        string[] s = new string[]
        {
            "0000","0001","0010","0011","0100","0101","0110","0111",
            "1000","1001","1010","1011","1100","1101","1110","1111"
        };
        StringBuilder res = new("");
        foreach(var i in HexNumber)
        {
            if (i == 'A') res.Append(s[10]);
            else if (i == 'B') res.Append(s[11]);
            else if (i == 'C') res.Append(s[12]);
            else if (i == 'D') res.Append(s[13]);
            else if (i == 'E') res.Append(s[14]);
            else if (i == 'F') res.Append(s[15]);
            else res.Append(s[int.Parse(i.ToString())]);
        }
        return res.ToString();
    }
    static void Main(string[] args)
    {
        Console.WriteLine(ConvertHex2Bin(Console.ReadLine()));
    }
}

