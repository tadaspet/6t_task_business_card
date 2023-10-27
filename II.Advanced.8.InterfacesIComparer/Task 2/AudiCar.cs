using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class AudiCar : Car
    {
        public bool IsQuattro { get; set; }
        public AudiCar(bool quattro, string model, int fuel)
        {
            IsQuattro = quattro;
            Model = model;
            Fuel = fuel;
        }
    }
}
