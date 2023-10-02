using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Object_Orentiad_Programing
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public Address Address { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(double height) : this()
        {
            Height = height;
        }
        public Person()
        {
        }
    }
}
