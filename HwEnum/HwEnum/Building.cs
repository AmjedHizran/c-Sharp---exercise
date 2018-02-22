using System;
namespace HwEnum
{
    public abstract class Building
    {
        public int NumOfFloors{ get; set; }
        public bool IsThereElevator{ get; set; }

        public Building(int numOfFloors,bool isThereElevator )
        {
            NumOfFloors = numOfFloors;
            IsThereElevator = isThereElevator;
        }

        public virtual string GetDetails()
        {
            return $"NumOfFloors:{NumOfFloors}\nIsThereElevator:{IsThereElevator}";
            
        }

    }
}
