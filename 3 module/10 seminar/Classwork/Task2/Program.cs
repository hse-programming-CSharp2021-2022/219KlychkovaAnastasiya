using System;

namespace Task2
{
    struct Person
    {
        public string name;
        public string surname;
        public int age;
        public Person(string n, string s, int a)
        {
            name = n;
            surname = s;
            age = a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new("Vasya", "Ivanov", 30);
            Person p2 = new("Dima", "Petrov", 20);
            Person p3 = new("Masha", "Kukushkina", 15);
            Queue<Person> queue = new();
            queue.Enqueue(p1);
            queue.Enqueue(p2);
            queue.Enqueue(p3);
            Console.WriteLine(queue.Size);
            Console.WriteLine(queue.Dequeue().name);
            Console.WriteLine(queue.Dequeue().name);
            Console.WriteLine(queue.Dequeue().name);
            Console.WriteLine(queue.IsEmpty);
        }
    }
}
