using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InheritanceAndVirtualMetods
{
    internal class Car2 : Transport
    {
        public double Speed { get; set; }
        public override double MeasureSpee()
        {
            return Speed;
        }
    }
}
