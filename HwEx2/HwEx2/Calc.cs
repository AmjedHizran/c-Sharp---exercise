using System;
namespace HwEx2
{
    public static class Calc
    {
        static Calc()
        {
            DateTime date1 = new DateTime();
            date1 = DateTime.UtcNow;
            Console.WriteLine("static Calc ctor");
            Console.WriteLine(date1);
        }

        public static int GetSub(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int GetSub(int num1, int num2,int num3)
        {
            return num1 + num2 + num3;
        }

        public static double GetSub(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
