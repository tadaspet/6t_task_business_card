using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Accessibillity
{
    internal class Person
    {
        private int Years { get; set; }
        private string Name { get; set; }
        private string LastName { get; set; }
        public Person(string name, string lastName, int years) 
        {
            Years = years;
            Name = name;
            LastName = lastName;
        }

        private string GetIntials()
        {
            return Name[0] + "" + LastName[0];
        }
        public string GetUserData()
        {
            string initials = GetIntials();
            return $"{Name} {LastName}___{initials}___{Years}";
        }
        public void SetYears(int years)
        {
            Years = years;
        }
        public int GetYears()
        {
            return Years;
        }
    }
}
