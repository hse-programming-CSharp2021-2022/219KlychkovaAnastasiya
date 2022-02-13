using System;
using System.Text;

namespace Task1
{
    struct Person : IComparable<Person>
    {
        string name;
        string lastname;
        int age;
        public Person(string n,string lastn ,int a)
        {
            name = n;
            lastname = lastn;
            if (a >= 0)
                age = a;
            else
                throw new ArgumentOutOfRangeException("Age can't be less than 0");
        }
        int IComparable<Person>.CompareTo(Person other)=> age.CompareTo(other.age);

        public override string ToString()
        {
            return $"Name: {name}\tLastname: {lastname}\tAge: {age}";
        }
    }
    class Program
    {
        static string RandString(int length)
        {
            Random rnd = new();
            StringBuilder str = new();
            str.Append((char)rnd.Next(65, 91));
            for(int i = 0; i < length-1; i++)
            {
                str.Append((char)rnd.Next(97, 122));
            }
            return str.ToString();
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите количество героев: ");
            while (!int.TryParse(Console.ReadLine(), out n)) ;
            Person[] characters = new Person[n];

            Random rnd = new();
            for(int i = 0; i < n; i++)
            {
                characters[i] = new Person(RandString(rnd.Next(3, 6)), RandString(rnd.Next(3, 10)), rnd.Next(101));
            }

            Array.ForEach(characters, x => Console.WriteLine(x));
            Array.Sort(characters);
            Console.WriteLine("***");
            Array.ForEach(characters, x => Console.WriteLine(x));
        }
    }
}
