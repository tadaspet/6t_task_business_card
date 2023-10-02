using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Advanced.Generics
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Human(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
