using System;
namespace HwEnum
{
    public class Hotel : Building
    {
        public int NumOfRooms { get; set; }
        public int NumOfRoomsOccupied { get; set; }
        public Country Countries { get; set; }
        public Service[] Services = new Service[3];


        public Hotel() : base(5, true)
        {
        }
  
        public override string GetDetails()
        {
            string str = base.GetDetails();
            return ($"{str}\nNumOfRooms:{NumOfRooms}\nNumOfRoomsOccupied:{NumOfRoomsOccupied}\nCountry:{Countries}\nServices:{Services[0]}+{Services[1]}+{Services[2]}\n");
        }


    }
}
