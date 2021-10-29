using System;

namespace Task1
{
    class RegularPolygon
    {
        public double Radius { get; set; }
        public int SideNumber { get; set; }
        public RegularPolygon(int num = 0, double r = 0)
        {
            Radius = r;
            SideNumber = num;
        }

        public double Perimeter
        {
            get { return Math.Round(SideNumber * 2 * Radius * Math.Tan(Math.PI / SideNumber), 5); }
        }

        public double Square
        {
            get { return 0.5 * Perimeter * Radius; }
        }

        public string PolygonData() => $"Количество сторон: {SideNumber}\nРадиус вписанной окружности: {Radius}\nПериметр: {Perimeter}\nПлощадь: {Square}";

    }

    class Program
    {
        static int MaxSqare(RegularPolygon[] polygons)
        {
            int max = 0;
            for (int i = 1; i < polygons.Length; i++)
                if (polygons[i].Square > polygons[max].Square)
                    max = i;
            return max;
        }

        static int MinSqare(RegularPolygon[] polygons)
        {
            int min = 0;
            for (int i = 1; i < polygons.Length; i++)
                if (polygons[i].Square < polygons[min].Square)
                    min = i;
            return min;
        }

        static void Output(RegularPolygon[] polygons)
        {
            Console.WriteLine();
            for (int i = 0; i < polygons.Length; i++)
            {
                Console.WriteLine($"Сведения о {i + 1}-ом многоугольнике:");
                Console.Write($"Количество сторон: {polygons[i].SideNumber}\nРадиус вписанной окружности: {polygons[i].Radius}\nПериметр: {polygons[i].Perimeter}\n");
                if (i == MaxSqare(polygons))
                    Console.ForegroundColor = ConsoleColor.Green;
                if (i == MinSqare(polygons))
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Площадь: {polygons[i].Square}\n");
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            RegularPolygon polygon = new RegularPolygon();
            Console.WriteLine("По умолчанию: ");
            Console.WriteLine(polygon.PolygonData() + "\n");
            double r;
            int num;

            do Console.Write("Введите число сторон: ");
            while (!int.TryParse(Console.ReadLine(), out num) || num < 3);
            do Console.Write("Введите радиус: ");
            while (!double.TryParse(Console.ReadLine(), out r) || r < 0);
            polygon = new RegularPolygon(num, r);
            Console.WriteLine("Сведения о многоугольнике:");
            Console.WriteLine(polygon.PolygonData() + "\n");

            //Задания 1-3
            //int n;
            //do Console.Write("Введите количество элементов в массиве: ");
            //while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            //RegularPolygon[] polygons = new RegularPolygon[n];
            //for (int i = 0; i < n; i++)
            //{
            //    do Console.Write($"Введите число сторон {i+1}-го многоугольника: ");
            //    while (!int.TryParse(Console.ReadLine(), out num) || num < 3);
            //    do Console.Write($"Введите радиус {i+1}-го многоугольника: ");
            //    while (!double.TryParse(Console.ReadLine(), out r) || r < 0);
            //    polygons[i] = new RegularPolygon(num, r);
            //}
            //Output(polygons)

            //Задание 4
            int i = 0;
            RegularPolygon[] polygons = new RegularPolygon[i];
            do
            {
                i++;
                Array.Resize(ref polygons, i);
                do Console.Write($"Введите число сторон {i}-го многоугольника: ");
                while (!int.TryParse(Console.ReadLine(), out num) || (num < 3 && num != 0));
                do Console.Write($"Введите радиус {i}-го многоугольника: ");
                while (!double.TryParse(Console.ReadLine(), out r) || r < 0);
                polygons[i - 1] = new RegularPolygon(num, r);
                Output(polygons);
            } while (!(r == 0 && num == 0));

        }
    }
}