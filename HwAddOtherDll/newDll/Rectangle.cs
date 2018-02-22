using System;
using HwAddOtherDll;

namespace newDll
{

    public class Rectangle : Shape, IDrawable
    {

        public double Width
        {
            get;
            set;
        }
        public double Height
        {
            get;
            set;
        }
        public Rectangle(double width, double height) : base(width,height, "black")
        {
            Width = width;
            Height = height;
        }

        public override double CalcScope()
        {
            double result;
            result = (Width * 2) + (Height * 2);
            return result;
        }

        public override double CalcSpace()
        {
            double result;
            result = Width * Height;
            return result;
        }

        public override string Print()
        {
            return base.Print() + $"the width is:{Width}\nthe height is:{Height}\n";
        }

        public void Draw()
        {
            for (int row = 1; row <= Height; row++)
            {
                for (int column = 1; column <= Width; column++)
                {
                    Console.Write(" *");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}

    
    


