using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InheritanceAndVirtualMetods
{
    internal class Manager322 : Employee322
    {
        public string NameManger { get; set; }
        public override string Greeting()
        {
            return $"{NameManger}: Sveikinu prisijungus prie komandos!";
        }
    }
}
