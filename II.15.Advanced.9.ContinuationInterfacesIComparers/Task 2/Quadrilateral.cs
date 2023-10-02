using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Quadrilateral : IPolygon
    {
        public int LineLength { get; set; } 
        public Quadrilateral(int lineLength) 
        {
            LineLength = lineLength;
        }
        public double GetArea()
        {
            double area = Math.Pow(LineLength, 2);
            return area;
        }
    }
}
