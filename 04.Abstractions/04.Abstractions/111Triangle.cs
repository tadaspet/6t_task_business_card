using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Abstractions
{
    internal class Triangle : GeometricShape
    {
        public Triangle(double baseLine, double heightLine) : base (baseLine, heightLine) 
        {
        }
        public override void GetArea()
        {
            Console.WriteLine($"Triangle area: {0.5 * BaseLine * HeightLine}"); 
        }
        public override void GetPerimeter()
        {
            Console.WriteLine($"Triangle perimeter: {BaseLine + HeightLine*2}");
        }
    }
}
