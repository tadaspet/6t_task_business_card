using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Abstractions 
{
    internal class Dog : Animal
    {
        public bool IsServiceDog { get; set; }
        public Dog(double weight, string name, bool isServiceDog) : base(weight, name)
        {
            IsServiceDog = isServiceDog;
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Woof woof!");
        }
    }
}
