using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Advanced.Generics
{
    internal class Validation<T>
    {
        public static void Validate<T>(T param) 
        {
            if(param == null)
            {
                throw new ArgumentNullException("Invalid argument.");
            }

        }
    }
}
