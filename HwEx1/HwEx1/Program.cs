using System;

namespace HwEx1
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c1 = new Circle();
            Console.WriteLine("enter a number that represents a position on the X axis :");
            c1.x =  int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number that represents a position on the Y axis :");
            c1.y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the color of the circle :");
            c1.color = Console.ReadLine();
            Console.WriteLine("enter the radius of the circle :");
            c1.Radius = int.Parse(Console.ReadLine());
            Console.WriteLine("the details of the circle :");
            c1.Print();


            Square s1 = new Square();
            Console.WriteLine("enter a number that represents a position on the X axis :");
            s1.x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number that represents a position on the Y axis :");
            s1.y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the color of the Square :");
            s1.color = Console.ReadLine();
            Console.WriteLine("enter the length side of the Square :");
            s1.LengthSide = int.Parse(Console.ReadLine());
            Console.WriteLine("the details of the Square :");
            s1.Print();
        }
    }
}