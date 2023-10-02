using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Abstractions
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Vehicle> Vechicles { get; set; } = new List<Vehicle>();
        public Random VechicleNo { get; set; } = new Random();
        public Human(string name, int age, List<Vehicle> vehicles)
        {
            Name = name;
            Age = age;
            Vechicles = vehicles;
        }

        public void CurrentVehicle()
        {
            int randomNo = VechicleNo.Next(1,Vechicles.Count);
            Console.WriteLine($"Human: {Name}" +
                $"\nAge: {Age}");
            Vechicles[randomNo].GetVehicleInfo();
        }
    }
}
