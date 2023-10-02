using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InheritanceAndVirtualMetods
{
    //Square is child class
    internal class Square : Polygon //Parent class
    {
        public Square() 
        {
            NumberOfAngles = 4; //Properti is from the Parent Polygon class 
        }
        public Square(double size)
        {
            Size = size;
            NumberOfAngles = 4;
        }
        public double Size { get; set; }
        public override double GetPerimeter()
        {
            return Size*NumberOfAngles;
        }
    }
}
