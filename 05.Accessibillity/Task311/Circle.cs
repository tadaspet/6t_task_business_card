using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task311
{
    internal class Circle : Shape
    {
        private double Radius { get; set; }
        public Circle ( double radius)
        {
            Radius = radius;
        }

        public sealed override double CalculateArea()
        {
            double area = Math.PI*Math.Pow(Radius,2);
            return area;
        }

    }
}
