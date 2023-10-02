using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Advanced.Generics
{
    internal class Task311<T1, T2>
    {
        public void ShowValues<T1, T2>(T1 value1, T2 value2)
        {
            if (value1 == null)
            {
                throw new ArgumentNullException(nameof(value1));
            }
            else if (value2 == null)
            {
                throw new ArgumentNullException(nameof(value2));
            }
            if (value1 != null &&  value2 != null)
            {
                Console.WriteLine($"T1 value: {value1} ; type: {value1.GetType().Name}");
                Console.WriteLine($"T2 value: {value2} ; type: {value2.GetType().Name}");
            }
        }
    }
}
