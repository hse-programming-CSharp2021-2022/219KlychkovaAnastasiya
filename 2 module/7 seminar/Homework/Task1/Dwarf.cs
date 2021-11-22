using System;

namespace Task1
{
    class Dwarf:Creature
    {
        private int strength;
        private int Strength
        {
            set
            {
                if (value >= 1 && value <= 20)
                    strength = value;
                else
                {
                    Random rnd = new Random();
                    strength = rnd.Next(20) + 1;
                }
            }
            get
            {
                return strength;
            }
        }
        protected override string Run()
        {
            return base.Run() + $" My strength is {Strength}.";
        }
        public static void MakeNewStaff()
        {
            Console.WriteLine("I've created a new staff!");
        }
        public Dwarf(string name,double speed,int strength):base(name,speed)
        {
            Strength = strength;
        }
    }
}
