using System;

namespace Task1
{
    class Elf:Creature
    {
        private int age;
        protected override string Run()
        {
            return base.Run() + $" My age is {age}.";
        }
        private static int RandAge()
        {
            Random rnd = new Random();
            return rnd.Next(100, 201);
        }
        
        public Elf(string name, double speed) : base(name, speed +(double)(RandAge()) / 77)
        {
            age = (int)((Speed - speed) * 77);
        }
    }
}
