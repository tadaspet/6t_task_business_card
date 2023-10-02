using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task322
{
    internal class Dog : Animal
    {
        private string DogSound { get; set; } = "Woof, woof!";
        public Dog(string name) : base(name) 
        {
        }
        public sealed override string MakeSound()
        {
            return DogSound;
        }
    }
}
