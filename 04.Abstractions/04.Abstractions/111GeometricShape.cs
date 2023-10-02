using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Abstractions
{
    public abstract class GeometricShape
    {
        public double BaseLine { get; set; }
        public double HeightLine { get; set; }
        public GeometricShape(double baseLine, double heightLine)
        {
            BaseLine = baseLine;
            HeightLine = heightLine;
        }
        public abstract void GetArea();
        public abstract void GetPerimeter();
    }
}
