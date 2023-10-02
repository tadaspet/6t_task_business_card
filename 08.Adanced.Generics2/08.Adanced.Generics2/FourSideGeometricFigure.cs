using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Adanced.Generics2
{
    internal class FourSideGeometricFigure
    {
        public string Name { get; set; }    
        public double Base { get; set; }
        public double Height { get; set; }

        public FourSideGeometricFigure(string name, double baseSize, double height)
        {
            Name = name;
            Base = baseSize;
            Height = height;
        }
        public double GetArea()
        {
            return Base*Height;
        }
        public override string ToString()
        {
            return $"Name: {Name}\tBase: {Base}\tHeight: {Height}";
        }
    }
}
