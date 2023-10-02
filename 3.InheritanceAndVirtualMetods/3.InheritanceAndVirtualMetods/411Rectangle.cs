using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InheritanceAndVirtualMetods
{
    internal class Rectangle411 : Shape411
    {
        public string Arrow { get; set; }
        public override string Draw()
        {
            Arrow = "»»-----------►";
            return Arrow;
        }
    }
}
