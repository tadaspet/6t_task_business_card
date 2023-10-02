using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Abstractions
{
    internal class Bus : Vehicle
    {
        public double SleepingSeats { get; set; }
        public Bus(int wheelcount, string brand, DateOnly creationDate, double sleepingSeats) : base(wheelcount, brand, creationDate)
        {
            SleepingSeats = sleepingSeats;  
        }
        public override void GetVehicleInfo()
        {
            Console.WriteLine($"Bus:" +
                $"\nWheels: {WheelCount}" +
                $"\nBrand: {Brand}" +
                $"\nCreatation Date: {CreationDate}" +
                $"\nSleeping Seats: {SleepingSeats}" +
                $"\n---------------------------------");
        }

    }
}
