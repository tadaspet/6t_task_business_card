using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Abstractions
{
    internal class Motorcycle : Vehicle
    {
        public bool HasHelmet { get; set; }
        public Motorcycle(int wheelcount, string brand, DateOnly creationDate, bool hasHelmet) : base(wheelcount, brand, creationDate)
        {
            HasHelmet = hasHelmet;
        }
        public override void GetVehicleInfo()
        {
            Console.WriteLine($"Motorcicle:" +
            $"\nWheels: {WheelCount}" +
            $"\nBrand: {Brand}" +
            $"\nCreatation Date: {CreationDate}" +
            $"\nHelmet required: {HasHelmet}" +
            $"\n---------------------------------");
        }
    }
}
