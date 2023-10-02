using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Adanced.Generics2
{
    internal class Generator<T>
    {
        public void Show(T value)
        {
            Console.WriteLine($"Value: {value}");
        }
    }
}
