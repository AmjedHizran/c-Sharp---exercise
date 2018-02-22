using System;


namespace HwRandomChar
{
    class Program
    {
        static void Main(string[] args)
        {
            int rand;
            getRandom(out rand);
        }

        static void getRandom(out int rand)
        {
            Random rnd = new Random();
            rand = rnd.Next(0, 128);

            char c11 = (char)rand;

            Console.WriteLine("the rndom number is:" + rand);
            Console.WriteLine("number:" + rand + " represents the character : " + c11);

        }
    }
}