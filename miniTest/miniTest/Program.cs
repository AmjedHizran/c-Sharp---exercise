using System;

namespace miniTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ClothingItem[] arrClothing=new ClothingItem[4];
            for (int i = 0; i < arrClothing.Length; i++)
            {
                if(i%2==0)
                {
                    arrClothing[i] = new Gloves(){typeOfFabric="synthetic",measure=5,wethr=Weather.rain}; 
                }
                else
                {
                    arrClothing[i] = new SunHat(){ typeOfFabric = "cotton", measure = 10 ,wethr=Weather.sun};
                }

            }

            for (int i = 0; i < arrClothing.Length; i++)
            {
                
                Console.WriteLine(arrClothing[i].Func1(arrClothing[i].wethr) ); 
                Console.WriteLine(arrClothing[i].toString());
            
            }


        }
    }
}
