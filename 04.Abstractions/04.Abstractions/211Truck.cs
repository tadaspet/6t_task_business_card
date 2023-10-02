using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Abstractions
{
    internal class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }
        public Truck(int wheelcount, string brand, DateOnly creationDate, double loadCapacity) : base(wheelcount, brand, creationDate)
        {
            LoadCapacity = loadCapacity;
        }
        public override void GetVehicleInfo()
        {
            Console.WriteLine($"Truck:" +
                $"\nWheels: {WheelCount}" +
                $"\nBrand: {Brand}" +
                $"\nCreatation Date: {CreationDate}" +
                $"\nLoad capacity: {LoadCapacity} tons" +
                $"\n---------------------------------");
        }
    }
}
