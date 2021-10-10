using System;
class Program
{

    static void Main(string[] args)
    {
        int n = 100,j;
        int[] arr = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
            arr[i] = i + 1;

        for (int i = n - 1; i >= 1; i--)
        {
            j = rand.Next(i + 1);
            int tmp = arr[j];
            arr[j] = arr[i];
            arr[i] = tmp;
        }

        j = rand.Next(99);
        arr[99] = arr[j];

        bool[] num = new bool[101];
        for (int i = 0; i < n; i++)
        {
            if (num[arr[i]] == true)
            {
                Console.WriteLine("Число, повторяющееся дважды: " + arr[i]);
                break;
            }
            num[arr[i]] = true;
        }
    }
}



