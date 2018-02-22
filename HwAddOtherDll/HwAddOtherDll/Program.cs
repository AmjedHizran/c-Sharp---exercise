using System;
using newDll;
namespace HwAddOtherDll
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r1 = new Rectangle(10,5);
            Square s1 = new Square(10);

            r1.Draw();
            Console.WriteLine($"the scope is:{r1.CalcScope()}");
            Console.WriteLine($"the area is:{r1.CalcSpace()}");
            Console.WriteLine(r1.Print());

            s1.Draw();
            Console.WriteLine($"the scope is:{r1.CalcScope()}");
            Console.WriteLine($"the area is:{r1.CalcSpace()}");
            Console.WriteLine(s1.Print());
         
        }
    }
}
