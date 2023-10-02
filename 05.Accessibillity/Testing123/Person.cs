using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task111
{
    internal class Person
    {
        protected string  Name { get; set; }   
        protected int Age { get; set; }

        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
        }
        protected string PrintInfo() //protected does not print in the main Program class
        {
            return $"Name: {Name}, Age: {Age}";
        }
        public string PrintName()
        {
            string info = PrintInfo();
            return info+"\nProtected information";
        }
    }
}
