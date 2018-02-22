using System;
using System.Collections.Generic;
using System.Linq;

namespace HwEvents_and_Collections
{
    public delegate void MyDelegate(int num);
    class Program
    {
        /////////////void Main
        static void Main(string[] args)
        {
            var rnd = new Random();

            List<MyDelegate> delegateList = new List<MyDelegate>() { SumOfDigits, EvenOrNot, IsPrime, BiggestDigit, NumberOfDigits };

            for (int i = 0; i < delegateList.LongCount(); i++)
            {
                delegateList[i](rnd.Next(100, 10001));
            }
        }

        ///////////////SumOfDigits
        static void SumOfDigits(int num)
        {
            List<int> DigitList = new List<int>();
            int Cout = 0, sourceNum = num;

            while (num != 0)
            {
                Cout = (num % 10);
                DigitList.Add(Cout);
                num /= 10;
            }
            Console.WriteLine($"the sum of digit of number:{sourceNum} is :" + DigitList.Sum());
        }

        ////////////////is even or not
        static void EvenOrNot(int num)
        {
            if (num % 2 == 0)

                Console.WriteLine($"the number: {num} is even");
            else
                Console.WriteLine($"the number: {num} not an even number");
        }

        ////////////////is prime or not
        static void IsPrime(int n)
        {
            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                Console.WriteLine($"the number: {n} not prime");
            else if (n < 4 || n < 9)
                Console.WriteLine($"the number: {n} is prime");
            else
            {
                for (int i = 5; i <= (int)Math.Sqrt(n); i += 6)
                {
                    if ((n % i == 0) || (n % (i + 2) == 0))
                        Console.WriteLine($"the number: {n} not prime");
                }
                Console.WriteLine($"the number: {n} is prime");
            }
        }

        ////////////////the biggest digit
        static void BiggestDigit(int num)
        {
            List<int> DigitList = new List<int>();
            int Cout = 0,sourceNum = num;
            while (num != 0)
            {
                Cout = (num % 10);
                DigitList.Add(Cout);
                num /= 10;
            }
            Console.WriteLine($"the biggest digit in the number: {sourceNum} is:" + DigitList.Max());
        }


        ////////////////the Number Of Digits
        static void NumberOfDigits(int num)
        {
            List<int> DigitList = new List<int>();
            int Cout = 0,sourceNum = num;
            while (num != 0)
            {
                Cout = (num % 10);
                DigitList.Add(Cout);
                num /= 10;
            }
            Console.WriteLine($"number of digits on the number: {sourceNum} is:" + DigitList.Count());
        }
    }
}

