using System;
using Delegate;

class Program
{
    
    static void Main(string[] args)
    {
        Car c = new Car();

   //עוריאל היצקנופה םושיר
       c.SpeedChanged += new SpeedDelegate(PrintSpeed);

        c.AddSpeed(16);
        c.AddSpeed(28);
        c.AddSpeed(52);
        c.AddSpeed(-10);
        c.AddSpeed(14);
        c.AddSpeed(55);

        Console.WriteLine();
    }
    static void PrintSpeed(int newSpeed)
    {
        Console.WriteLine(newSpeed);
    }
}