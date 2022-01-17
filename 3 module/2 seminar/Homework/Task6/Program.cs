using System;

namespace Task6
{
    class Program
    {
        static int Comp(Plant left,Plant right)
        {
            if (left.Photosensitivity % 2 == 0 && right.Photosensitivity % 2 != 0)
                return -1;
            else if (left.Photosensitivity % 2 != 0 && right.Photosensitivity % 2 == 0)
                return 1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            int n;
            while(!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("ошибка!");
            }
            Plant[] plants = new Plant[n];
            Random rnd = new Random();
            for(int i = 0; i < plants.Length; i++)
            {
                plants[i] = new Plant(rnd.Next(25, 100)+Math.Round(rnd.NextDouble(),2), rnd.Next(100) + Math.Round(rnd.NextDouble(), 2), rnd.Next(80) + Math.Round(rnd.NextDouble(), 2));
            }
            Action<Plant> d1 = x => Console.WriteLine(x.ToString());
            Array.ForEach(plants, d1);
            Console.WriteLine();

            Comparison<Plant> d2 = delegate (Plant left, Plant right)
            {
                if (left.Growth > right.Growth)
                    return -1;
                else if (left.Growth < right.Growth)
                    return 1;
                else
                    return 0;
            };
            Array.Sort(plants, d2);
            Array.ForEach(plants, d1);
            Console.WriteLine();

            Comparison<Plant> d3 = (l, r) =>
            {
                if (l.Frostresistance > r.Frostresistance)
                    return 1;
                else if (l.Frostresistance < r.Frostresistance)
                    return -1;
                else
                    return 0;
            };
            Array.Sort(plants, d3);
            Array.ForEach(plants, d1);
            Console.WriteLine();

            Array.Sort(plants, Comp);
            Array.ForEach(plants, d1);
            Console.WriteLine();

            Converter<Plant, Plant> d4 = x =>
            {
                if (x.Frostresistance % 2 == 0)
                    x.Frostresistance /= 3;
                else
                    x.Frostresistance /= 2;
                return x;
            };
            Plant[] plants2 = Array.ConvertAll(plants, d4);
            Array.ForEach(plants2, d1);
            Console.WriteLine();
        }
    }
}
