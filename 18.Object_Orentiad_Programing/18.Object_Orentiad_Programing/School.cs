using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Object_Orentiad_Programing
{
    public class School
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Pupils { get; set; }
        public School(string name, string city, int pupils) 
        {
            Name = name;
            City = city;
            Pupils = pupils;
        }

    }
}
