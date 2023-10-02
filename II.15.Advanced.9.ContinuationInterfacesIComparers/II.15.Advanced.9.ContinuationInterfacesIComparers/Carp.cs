using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._15.Advanced._9.ContinuationInterfacesIComparers
{
    internal class Carp : IAnimal, IFish
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public int SwimDepth { get; set; }
        public Carp(string name, string food, int swimDepth)
        {
            Name = name;
            Food = food;
            SwimDepth = swimDepth;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} favorite food: {Food}");
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming at {SwimDepth} meters depth.");
        }
    }
}
