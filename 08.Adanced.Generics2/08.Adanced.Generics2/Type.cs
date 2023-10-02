using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Adanced.Generics2
{
    internal class Type<T1, T2>
    {
        public T1 Input1 { get; set; }
        public T2 Input2 { get; set;}
        public Type(T1 input1, T2 input2)
        {
            Input1 = input1;
            Input2 = input2;
        }
        public void GetType<T>(T value)
        {
            Console.WriteLine($"Type: {value.GetType()}");
        }
    }
}
