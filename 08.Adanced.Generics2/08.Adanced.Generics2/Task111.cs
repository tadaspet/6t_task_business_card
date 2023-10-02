using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Adanced.Generics2
{
    internal class Task111<T1, T2>
    {
        private T1 Value { get; set; }
        private T2 Value2 { get; set;}

        public void ShowFirstValue()
        {
            if (Value != null)
            {
                Console.WriteLine($"T1 value: {Value}");
            }
            else
            {
                throw new ArgumentException(nameof(ShowFirstValue));
            }
        }
        public void ShowSecondValue()
        {
            if (Value2 != null)
            {
                Console.WriteLine($"T2 value: {Value2}");
            }
            else
            {
                throw new ArgumentException(nameof(ShowFirstValue));
            }
        }
        public T1 ChangeFirstValue(T1 value)
        {
            return Value = value;
        }
        public T2 ChangeSecondValue(T2 value)
        {
            return Value2 = value;
        }
    }
}
