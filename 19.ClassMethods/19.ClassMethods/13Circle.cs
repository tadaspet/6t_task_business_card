using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ClassMethods
{
    public class Circle
    {
        public double Radius { get; set; }
        public void CircleArea(double radius)
        {
            Console.WriteLine($"Circle with radius {radius} area: {Math.Round((Math.Pow(radius,2) *Math.PI),2)}");
        }
        public void CircleCircumfenrence(double radius)
        {
            Console.WriteLine($"Circle circumference with radius {radius} is: {Math.Round((2 * Math.PI * radius),2)}");
        }
    }
}
