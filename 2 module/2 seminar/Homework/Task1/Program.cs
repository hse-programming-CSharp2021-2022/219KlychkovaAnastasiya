using System;

namespace Task1
{
    public class ConsolePlate
    {
        char _plateChar; // символ
        ConsoleColor _plateColor = ConsoleColor.White; // цвет символа
        ConsoleColor _plateBackgroundColor = ConsoleColor.Black;
        // конструкторы
        public ConsolePlate()
        {
            _plateChar = 'A';
        }
        public ConsolePlate(char plateChar, ConsoleColor plateColor, ConsoleColor plateBackgroundColor)
        {
            this.PlateChar = plateChar; // используем свойства 
            this.PlateColor = plateColor;
            this.PlateBackgroundColor = plateBackgroundColor;
        }

        public ConsoleColor PlateBackgroundColor
        {
            get
            {
                return _plateBackgroundColor;
            }
            set
            {
                if (value != _plateColor)
                    _plateBackgroundColor = value;
                else
                    _plateBackgroundColor = value + 1;
            }
        }
        public char PlateChar
        {
            get
            {
                return _plateChar;
            }
            set
            {
                if (value < 65 || value>90)
                    _plateChar = 'A';
                else
                    _plateChar = value;
            }
        }

        public ConsoleColor PlateColor
        {
            get
            {
                return _plateColor;
            }
            set
            {
                _plateColor = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate x = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            ConsolePlate o = new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Magenta);
            int N;
            while (!int.TryParse(Console.ReadLine(), out N) || N < 2 || N > 35);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.ForegroundColor = x.PlateColor;
                        Console.BackgroundColor = x.PlateBackgroundColor;
                        Console.Write(x.PlateChar);
                    }
                    else
                    {
                        Console.ForegroundColor = o.PlateColor;
                        Console.BackgroundColor = o.PlateBackgroundColor;
                        Console.Write(o.PlateChar);
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
            
        }
    }
}
