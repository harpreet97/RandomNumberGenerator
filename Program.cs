using System;
using System.Collections.Generic;


namespace randomnumbergeneration
{
    class Program
    {
        static List<string> cars = new List<string>{"Audi", "MAzda", "Toyota", "Nissan"};
        static List<string> drivers = new List<string>{"Bob", "Lisa", "Tim", "Simon", "Kevin"};
        static void Main(string[] args)
        {
            Console.WriteLine(DisplayDriver());
            Console.WriteLine(DisplayDriver());
            Console.WriteLine(DisplayDriver());

        }

        static int GenerateRandomNumber(List<string> myList){
            var rand = new Random();
            return rand.Next(1, myList.Count);

        }
        static string DisplayDriver(){

            var selectedCar = cars[GenerateRandomNumber(cars)];
            var selectedDriver = drivers[GenerateRandomNumber(drivers)];
            
            return $"{selectedDriver} is driving the {selectedCar}";
        }
    }
}
