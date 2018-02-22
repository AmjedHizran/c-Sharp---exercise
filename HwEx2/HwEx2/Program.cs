using System;

namespace HwEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calc.GetSub(2, 4)); 
            Console.WriteLine(Calc.GetSub(2, 4,5));
            Console.WriteLine(Calc.GetSub(2.5, 4.3));
        }
    }
}
