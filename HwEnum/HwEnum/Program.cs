using System;

namespace HwEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            Building[] arrBuilding = new Hotel[5]
            {
                new Hotel() {
                    NumOfFloors=5,
                    IsThereElevator=true,
                    NumOfRooms = 50,
                    NumOfRoomsOccupied = 25,
                    Countries = Country.Holland,
                    Services = new Service[]{Service.Breakfast,Service.Spa,Service.SwimmingPool}},
                new Hotel() { 
                    NumOfFloors=4,
                    IsThereElevator=true,
                    NumOfRooms = 40,
                    NumOfRoomsOccupied = 20,
                    Countries = Country.Germany,
                    Services = new Service[]{Service.Gym,Service.Lunch,Service.SwimmingPool}},
                new Hotel() { 
                    NumOfFloors=3,
                    IsThereElevator=true,
                    NumOfRooms = 30,
                    NumOfRoomsOccupied = 15,
                    Countries = Country.Switzerland,
                    Services = new Service[]{Service.SwimmingPool,Service.Spa,Service.Gym}},
                new Hotel() { 
                    NumOfFloors=2,
                    IsThereElevator=false,
                    NumOfRooms = 20,
                    NumOfRoomsOccupied = 10,
                    Countries = Country.Italy,
                    Services = new Service[]{Service.SeaView,Service.Breakfast,Service.Lunch}},
                new Hotel() { 
                    NumOfFloors=1,
                    IsThereElevator=false,
                    NumOfRooms = 10,
                    NumOfRoomsOccupied = 5,
                    Countries = Country.Romania,
                    Services = new Service[]{Service.Gym,Service.Spa,Service.SwimmingPool}}};



            for (int i = 0; i < arrBuilding.Length; i++)
            {
                Console.WriteLine(arrBuilding[i].GetDetails());
            }
        }

    }
}
