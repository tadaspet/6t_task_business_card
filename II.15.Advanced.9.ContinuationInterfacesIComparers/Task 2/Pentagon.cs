using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Pentagon : IPolygon
    {
        public int LineLength { get; set; }
        public Pentagon(int lineLength)
        {
            LineLength = lineLength;
        }
        public double GetArea()
        {
            double subCount = Math.Pow(5, 0.5) * 10 +25;
            double area = Math.Pow(LineLength, 2)*Math.Pow(subCount,0.5)/4;
            return area;
        }
    }
}
