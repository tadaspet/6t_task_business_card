using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._15.Advanced._9.ContinuationInterfacesIComparers
{
    internal class Dog : IAnimal, IMammal, IComparable<Dog>
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public int ChildrenAmount { get; set; }
        public Dog(string name, string food, int childrenAmount) 
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
        public int CompareTo(Dog? other)
        {
            if ( other == null )
            {
                return 1;
            }
            else
            {
                return Name.CompareTo(other.Name);
            }
        }
    }
}
