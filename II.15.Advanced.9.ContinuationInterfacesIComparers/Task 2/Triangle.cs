using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Triangle : IPolygon
    {
        public int LineLength { get; set; }
        public Triangle(int line) 
        {
            LineLength = line;
        }
        public double GetArea()
        {
            double area = Math.Pow(3,0.5) / 4 * Math.Pow(LineLength, 2);
            return area;
        }
    }
}
