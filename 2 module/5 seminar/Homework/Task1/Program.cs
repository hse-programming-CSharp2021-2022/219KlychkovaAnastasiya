using System;
using Task04Lib_Shape;
namespace Task1
{
    class Program
    {
        static int Comp1(Shape left,Shape right)
        {
            if (left is Circle && (right is Cylinder || right is Sphere))
                return -1;
            if ((left is Cylinder || left is Sphere) && right is Circle)
                return 1;
            if (left is Cylinder && right is Sphere)
                return -1;
            if (left is Sphere && right is Cylinder)
                return 1;
            else return 0;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int N1 = rnd.Next(3, 6);
            int N2 = rnd.Next(3, 6);
            int N3 = rnd.Next(3, 6);

            Shape[] figures = new Shape[N1 + N2 + N3];
            for(int i = 0; i < N1; i++)
            {
                figures[i] = new Circle(rnd.Next(10)+1);
            }
            for (int i = 0; i < N2; i++)
            {
                figures[i+N1] = new Cylinder(rnd.Next(10)+1, rnd.Next(10)+1);
            }
            for (int i = 0; i < N3; i++)
            {
                figures[i+N1+N2] = new Sphere(rnd.Next(10)+1);
            }
            // Перемешаем массив
            for (int i = figures.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                var temp = figures[j];
                figures[j] = figures[i];
                figures[i] = temp;
            }

            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine($"Area of figure {i + 1}: {figures[i].Area()}");
            }
            Console.WriteLine();
            for(int i = 0; i < figures.Length; i++)
            {
                if (figures[i] is Circle)
                    Console.WriteLine($"Площадь круга: {figures[i].Area()}");
                else if (figures[i] is Cylinder)
                    Console.WriteLine($"Площадь цилиндра: {figures[i].Area()}");
                else if (figures[i] is Sphere)
                    Console.WriteLine($"Площадь шара: {figures[i].Area()}");
            }
            Console.WriteLine("\nОтсортированный массив: ");
            Array.Sort(figures, Comp1);
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] is Circle)
                    Console.WriteLine($"Площадь круга: {figures[i].Area()}");
                else if (figures[i] is Cylinder)
                    Console.WriteLine($"Площадь цилиндра: {figures[i].Area()}");
                else if (figures[i] is Sphere)
                    Console.WriteLine($"Площадь шара: {figures[i].Area()}");
            }
        }
    }
}
