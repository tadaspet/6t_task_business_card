using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task322
{
    internal class Animal
    {
        public string AnimalName { get; set; }
        public Animal(string animalName)
        {
            AnimalName = animalName;
        }
        public virtual string MakeSound()
        {
            return "0";
        }

    }
}
