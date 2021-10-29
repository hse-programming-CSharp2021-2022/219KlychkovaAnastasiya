using System;

namespace Task1
{
    class MyComplex
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public MyComplex(double xre = 0, double xim = 0)
        { Re = xre; Im = xim; }
        public static MyComplex operator ++(MyComplex mc)
        { return new MyComplex(mc.Re++, mc.Im++); }
        public static MyComplex operator --(MyComplex mc)
        { return new MyComplex(mc.Re - 1, mc.Im - 1); }
        public double Mod() { return Math.Abs(Re * Re + Im * Im); }
        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }
        public static MyComplex operator + (MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re + b.Re, a.Im + b.Im);
        }
        public static MyComplex operator - (MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re - b.Re, a.Im - b.Im);
        }
        public static MyComplex operator * (MyComplex a, MyComplex b)
        {
            return new MyComplex(a.Re * b.Re - a.Im * b.Im, a.Im *b.Re + a.Re *b.Im );
        }
        public static MyComplex operator / (MyComplex a, MyComplex b)
        {
            return new MyComplex((a.Re * b.Re + a.Im * b.Im)/(b.Re *b.Re + b.Im *b.Im) , (a.Im * b.Re - a.Re * b.Im)/(b.Re *b.Re + b.Im *b.Im));
        }
        public override string ToString()
        {
            return $"{Re} + {Im}i";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            double re, im;
            do Console.Write("Введите действительную часть числа a: ");
            while (!double.TryParse(Console.ReadLine(), out re));
            do Console.Write("Введите мнимую часть числа a: ");
            while (!double.TryParse(Console.ReadLine(), out im));
            MyComplex c1 = new MyComplex(re,im);

            do Console.Write("Введите действительную часть числа b: ");
            while (!double.TryParse(Console.ReadLine(), out re));
            do Console.Write("Введите мнимую часть числа b: ");
            while (!double.TryParse(Console.ReadLine(), out im));
            MyComplex c2 = new MyComplex(re, im);

            Console.WriteLine("\nЧисло a: " + c1);
            Console.WriteLine("Число b: " + c2);
            Console.WriteLine("a + b = " + (c1 + c2));
            Console.WriteLine("a - b = " + (c1 - c2));
            Console.WriteLine("a * b = " + (c1 * c2));
            Console.WriteLine("a / b = " + (c1 / c2));
        }
    }
}
