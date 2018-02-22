using System;
namespace miniTest
{
    public class Gloves:ClothingItem
    {
        public Gloves()
        {
        }

        public override bool Func1(Weather str)
        {
            if (str == Weather.spring || str == Weather.sun)
            { return true; }
            if (str == Weather.rain || str == Weather.cluds)
            { return false; }
            return false;
        }
        public override string toString()
        {
            string bol = base.toString();
            return $"{bol}";

        }
    }
}
