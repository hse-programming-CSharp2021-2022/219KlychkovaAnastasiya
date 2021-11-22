using System;

namespace Task1
{
    class Creature
    {
        protected string Name { get; private set; }
        protected double Speed { get; private set; }
        protected virtual string Run()
        {
            return $"I am running with a speed of {Math.Round(Speed,2)}.";
        }
        public override string ToString()
        {
            return Run()+ $" My name is {Name}.";
        }
        public Creature(string name, double speed)
        {
            Name = name;
            Speed = speed;
        }
    }
}
