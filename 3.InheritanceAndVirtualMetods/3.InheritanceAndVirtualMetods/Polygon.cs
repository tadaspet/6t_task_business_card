using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InheritanceAndVirtualMetods
{
    public class Polygon
    {
        public int NumberOfAngles { get; set; } 
        public Polygon() 
        {
        }
        public Polygon(int numberOfAngles)
        {
            NumberOfAngles = numberOfAngles;
        }
        public virtual double GetPerimeter()
        {
            return 0;
        }
    }
}
