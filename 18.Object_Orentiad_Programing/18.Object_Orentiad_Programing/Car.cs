using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Object_Orentiad_Programing
{
    public class Car
    {
        public string Brand { get; set; }
        public int Doors { get; set; }
        public double MaxSpeed { get; set; }
        public DateTime CreationDate { get; set; }
        public Engine Engine { get; set; }
        public List<Wheel> Wheels { get; set; }

        public Car()
        {
            //Doors = 5;
            CreationDate = DateTime.Now;
        }
        public Car(string brand) : this()
        {
            Brand = brand;
            CreationDate = DateTime.Now;
            Engine = new Engine();
           
        }
    }
}
