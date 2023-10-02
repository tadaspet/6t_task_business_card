using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._15.Advanced._9.ContinuationInterfacesIComparers
{
    internal class Cat : IAnimal, IMammal
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public int ChildrenAmount { get; set; }
        public Cat(string name, string food, int childrenAmount)
        {
            Name = name;
            Food = food;
            ChildrenAmount = childrenAmount;
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} favorite food: {Food}");
        }
        public void GiveBirth()
        {
            Console.WriteLine($"{Name} gave birth to {ChildrenAmount}");
        }
    }
}

