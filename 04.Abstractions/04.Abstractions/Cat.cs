using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Abstractions
{
    internal class Cat : Animal
    {
        public bool IsDomestic { get; set; }
        public Cat(double weight, string name, bool isDomestic) : base(weight, name)
        {
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Meow meow!!"); ;
        }

    }
}
