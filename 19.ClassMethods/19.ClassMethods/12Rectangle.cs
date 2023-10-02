using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ClassMethods
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public void CalcArea(int width, int height)
        {
            Console.WriteLine($"Rectangle area: {width*height}");
        }
        public void CalcPerimeter(int width, int height)
        {
            Console.WriteLine($"Rectangle perimeter: {width * 2 + height * 2}");
        }
    }
}
