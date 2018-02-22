using System;
namespace miniTest
{
    public abstract class ClothingItem
    {
        public string typeOfFabric { get; set; }
        public int measure { get; set; }
        public Weather wethr { get; set; }

        public ClothingItem()
        {
        }

        public virtual bool Func1(Weather str)
        {
            if (str == Weather.spring || str == Weather.sun)
            { return true; }
            if (str == Weather.rain || str == Weather.cluds)
            { return false;}
            return false;
        }

        public virtual string toString()
        {   
            return $"typeOfFabric:{typeOfFabric}\nmeasure:{measure}\nWeather:{wethr}";

        }
    }
}
