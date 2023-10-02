using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InheritanceAndVirtualMetods
{
    internal class Circle411 : Shape411
    {
        public string CircleShape { get; set; }
        public override string Draw()
        {
            CircleShape = "( ^-^)_旦";
            return CircleShape;
        }
    }
}
