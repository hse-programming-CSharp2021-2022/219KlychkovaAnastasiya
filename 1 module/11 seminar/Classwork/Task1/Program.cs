using System;
using System.IO;
using System.Text;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data.txt";
            // Создаем файл с данными
            if (File.Exists(path))
            {
                // Сейчас данные для записи вбиты в коде
                int.TryParse(Console.ReadLine(), out int n);
                Random rnd = new Random();
                string createText = "";
                int c = 0;
                for (int i = 0; i < n; i++)
                {
                    createText += rnd.Next(10, 100).ToString() + " ";
                    c++;
                    if (c == 5)
                    {
                        createText += "\n";
                        c = 0;
                    }
                }
                File.WriteAllText(path, createText, Encoding.UTF8);
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToIntArray(stringValues);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                int[] even = new int[0];
                int[] odd = new int[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Array.Resize(ref even, even.Length + 1);
                        even[even.Length - 1] = i;
                    }
                    else
                    {
                        Array.Resize(ref odd, odd.Length + 1);
                        odd[odd.Length - 1] = i;
                    }
                }

                // TODO3: Заменяем все нечётные числа исходного массива нулями
                for (int i = 0; i < odd.Length; i++)
                    arr[odd[i]] = 0;
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
            }
        } // end of Main()
        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str)
        {
            int[] arr = null;
            if (str.Length != 0)
            {
                arr = new int[0];
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                } // end of foreach (string s in str)      
            }
            return arr;
        } // end of StringToIntArray()
    } // end of Program
}
