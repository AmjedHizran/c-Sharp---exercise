using System;
namespace HwEx1
{
    public class Circle
    {
        public static double PI { get; set; } = 3.14;
        public int x ;
        public int y ;
        public string color ;
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value>0)
                    radius = value;
            }
        }


        public Circle()
        {

                Console.WriteLine("a new circle is born now!!!!");
        }

        public void Print()
        {
            Console.WriteLine("position on the X axis is :" + x);
            Console.WriteLine("position on the Y axis is :"+y);
            Console.WriteLine("the color of the circle is :"+color);
            Console.WriteLine("the radius of the circle is :"+radius);
            Console.WriteLine($"the area of the circle is :{ Area()}");
            Console.WriteLine($"the Perimeter of the circle is :{ Perimeter()}");

        }
        public double Area()
        {
            return PI*Math.Pow(radius, 2);

        }
        public double Perimeter()
        {
            return 2*PI*radius;

        }
    }
}
