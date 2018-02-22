using System;
namespace miniTest
{
    public class SunHat:ClothingItem
    {
        public SunHat()
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
