using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Abstractions
{
    public abstract class Vehicle
    {
        public int WheelCount { get; set; }
        public string Brand { get; set; }   
        public DateOnly CreationDate { get; set; }
        public Vehicle(int wheelCount, string brand, DateOnly creationDate) 
        {
            WheelCount = wheelCount;
            Brand = brand;
            CreationDate = creationDate;
        }
        public abstract void GetVehicleInfo();
    }

}
