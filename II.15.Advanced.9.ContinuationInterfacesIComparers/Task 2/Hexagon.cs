using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Hexagon : IPolygon
    {
        public int LineLength { get; set; }
        public Hexagon(int lineLength)
        {
            LineLength = lineLength;
        }
        public double GetArea()
        {
            double area = 3 * Math.Pow(3, 0.5) * Math.Pow(LineLength, 2)/2;
            return area;
        }
    }
}
