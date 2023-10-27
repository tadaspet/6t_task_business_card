using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class Car : IVehicle
    {
        public string Model { get; set; }
        public int Fuel { get; set; }
        private int TankSize { get; set; } = 80;

        public void Drive()
        {
            if (Fuel <= 0)
            {
                Console.WriteLine("Car can NOT drive");
            }
            else { Console.WriteLine("Car can drive."); }
        }
        public void Refuel(int fuel)
        {
            if (fuel <= 0) 
            {
                Console.WriteLine("Refuel is negative, it is impossible to refil");
            }
            else if (fuel + Fuel > TankSize)
            {
                Fuel = TankSize;
                Console.WriteLine("Tank is filled to maximum amount.");
            }
            else
            {
                Fuel += fuel;
                Console.WriteLine($"Refilled fuel amount is {Fuel}.");
            }
        }

    }
}
