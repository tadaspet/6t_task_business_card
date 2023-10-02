using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Abstractions
{
    public abstract class Animal
    {
        public double Weight { get; set; }
        public  string Name { get; set; }
        public Animal(double weight, string name) 
        { 
            Weight = weight;
            Name = name;
        }
        protected Animal(double weight) 
        {
            Weight = Weight;
        }
        public abstract void MakeNoise();
    }
}
