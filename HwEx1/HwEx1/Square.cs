using System;
namespace HwEx1
{
    public class Square
    {
        public int x;
        public int y;
        public string color;
        private double lengthSide;
        public double LengthSide
        {
            get { return lengthSide; }
            set
            {
                if (value > 0)
                    lengthSide = value;
            }
        }




        public Square()
        {
            Console.WriteLine("a new square is born now!!!!");
        }
        public void Print()
        {
            Console.WriteLine("position on the X axis is :" + x);
            Console.WriteLine("position on the Y axis is :" + y);
            Console.WriteLine("the color of the square is :" + color);
            Console.WriteLine("the length side of the square is :" + lengthSide);
            Console.WriteLine($"the area of the square is :{ Area()}");
            Console.WriteLine($"the Perimeter of the square is :{ Perimeter()}");

        }
        public double Area()
        {
            return lengthSide * lengthSide;

        }
        public double Perimeter()
        {
            return lengthSide*4;

        }
    }
}
