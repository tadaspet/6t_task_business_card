using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Abstractions
{
    internal class Square : GeometricShape
    {
        public Square(double baseLine, double heightLine) : base(baseLine,heightLine)
        {
        }
        public override void GetArea()
        {
            Console.WriteLine($"Square area: {BaseLine*HeightLine}"); 
        }
        public override void GetPerimeter()
        {
            Console.WriteLine($"Square perimeter: {2*BaseLine + 2* HeightLine}"); 
        }
    }
}
