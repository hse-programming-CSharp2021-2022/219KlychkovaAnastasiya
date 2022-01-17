using System;

namespace Task6
{
    class Plant
    {
        double growth;
        double photosensitivity;
        double frostresistance;
        public double Growth
        {
            get
            {
                return growth;
            }
            set
            {
                if (value >= 0)
                    growth = value;
                else
                    growth = 0;
            }
        }
        public double Photosensitivity
        {
            get
            {
                return photosensitivity;
            }
            set
            {
                if(value>=0 && value<=100)
                    photosensitivity = value;
                else
                {
                    if (value > 100)
                        photosensitivity = 100;
                    else
                        photosensitivity = 0;
                }
            }
        }
        public double Frostresistance
        {
            get
            {
                return frostresistance;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    frostresistance = value;
                else
                {
                    if (value > 100)
                        frostresistance = 100;
                    else
                        frostresistance = 0;
                }
            }
        }

        public Plant(double growth, double photosensitivity, double frostresistance)
        {
            Growth = growth;
            Photosensitivity = photosensitivity;
            Frostresistance = frostresistance;
        }
        public override string ToString()
        {
            return $"Growth: {growth}\tPhotosensitivity: {photosensitivity}\tFrostresistance: {frostresistance}";
        }
    }
}
