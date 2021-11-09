using System;

namespace Cinderella
{
    public abstract class Something
    {

    }

    public class Lentil : Something
    {
        private double weight;
        public double Weight
        {
            get
            {
                return weight;
            }
        }
        public Lentil()
        {
            Random rnd = new Random();
            weight = rnd.Next(2) + rnd.NextDouble();
        }
    }

    public class Ashes: Something
    {
        private double volume;
        public double Volume
        {
            get
            {
                return volume;
            }
        }
        public Ashes()
        {
            Random rnd = new Random();
            volume = rnd.NextDouble();
        }
    }
}
