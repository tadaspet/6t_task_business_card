using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class BmwCar : Car
    {
        public bool IsXDrive { get; set; }  
        public BmwCar(bool xdrive, string model, int fuel) 
        {
            IsXDrive = xdrive;
            Model = model;
            Fuel = fuel;
        }
    }
}
