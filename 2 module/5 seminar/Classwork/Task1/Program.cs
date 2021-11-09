using System;

namespace Task1
{
    abstract class Animal
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        abstract public string AnimalSound();
        abstract public string AnimalInfo();
    }
    class Dog : Animal
    {
        public Dog(string name,int age,bool train,string breed):base(name,age)
        {
            IsTrained = train;
            Breed = breed; 
        }
        public bool IsTrained { get; private set; }
        public string Breed { get; private set; }
        public override string AnimalSound()
        {
            return ("Гав-гав!");
        }
        public override string AnimalInfo()
        {
            return $"Имя: {Name}\nВозраст: {Age}\nЗвук: {AnimalSound()}\nДрессировка: {IsTrained}\nПорода: {Breed}";
        }
    }

    class Cow : Animal
    {
        public Cow(string name, int age, int milk) : base(name, age)
        {
            MilkPerDay = milk;
        }
        public int MilkPerDay { get; private set; }
        public override string AnimalSound()
        {
            return ("Мууу!");
        }
        public override string AnimalInfo()
        {
            return $"Имя: {Name}\nВозраст: {Age}\nЗвук: {AnimalSound()}\nМолоко в день: {MilkPerDay}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cow cow = new Cow("Мурка", 5, 10);
            Dog dog = new Dog("Дружок", 3, true, "Дворняга");
            Console.WriteLine(cow.AnimalInfo());
            Console.WriteLine();
            Console.WriteLine(dog.AnimalInfo());
        }
    }
}
