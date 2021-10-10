using System;


class Program
{
    static void Main(string[] args)
    {
        int n, m;
        int.TryParse(Console.ReadLine(), out n);
        int.TryParse(Console.ReadLine(), out m);
        int[,] arr = new int[n, m];
        int x = 0;
        int y = 0;
        int dx = 1;
        int dy = 0;
        int test;
        for (int i = 0; i < arr.Length; i++) {
            arr[y, x] = i + 1;
            test = dx != 0 ? x + dx : y + dy;
            if (test < 0 || (x != 0 && test == m) || (dy != 0 && test == n) || arr[y + dy, x + dx] != 0) {
                int old_dx = dx;
                dx = -dy;
                dy = old_dx;
            }
            x += dx;
            y += dy;
        }
        for (int i = 0; i < n; i++, Console.WriteLine())
            for (int j = 0; j < m; j++)
                Console.Write("{0,3} ", arr[i, j]);
    }
}

