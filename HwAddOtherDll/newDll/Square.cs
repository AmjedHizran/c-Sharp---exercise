using System;
using HwAddOtherDll;

namespace newDll
{
    public class Square : Shape, IDrawable
    {

        public double SideLength { get; set; }

        public Square(double sideLength) : base(sideLength,sideLength,"red")
        {
            SideLength = sideLength;
        }

        public override string Print()
        {
            return base.Print() + $"the side length is:{SideLength}";
        }
        public override double CalcScope()
        {
            double result;
            result = SideLength * 4;
            return result;
        }

        public override double CalcSpace()
        {
            double result;
            result = SideLength * SideLength;
            return result;
        }

        public void Draw()
        {
            for (int row = 1; row <= SideLength; row++)
            {
                for (int column = 1; column <= SideLength; column++)
                {
                 Console.Write(" *");
                }
                 Console.Write("\n");
            }
           
        }

    
    }
}
