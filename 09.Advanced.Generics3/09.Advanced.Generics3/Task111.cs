using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task222;

namespace _09.Advanced.Generics3
{
    internal class ReadOnly<T> : Validation<T>
    {
        public readonly List<T> OnlyList;

        public ReadOnly(List<T> onlyList)
        {
            OnlyList = onlyList;
        }

        public void PrintList()
        {
            int count = 1;
            foreach (var item in OnlyList)
            {
                Console.WriteLine($"{count}. {item}");
                count++;
            }
        }
        public T[] ListToArray()
        {
            T[] newArray = OnlyList.ToArray();
            return newArray;
        }
        public T ReturnOneValue(T value)
        {
            if(ValidCheck(value))
            {
                int count = OnlyList.Count(x => x.Equals(value));
                if (count == 1)
                {
                    return value;
                }
                else
                {
                    throw new ArgumentException(nameof(ReturnOneValue));
                }
            }
            else
            {
                throw new ArgumentException(nameof(ReturnOneValue));
            }
        }
        public T ReturnMatch(T value)
        {
            if (ValidCheck(value))
            {
                int count = OnlyList.Count(x => x.Equals(value));
                if (count == 1)
                {
                    return value;
                }
                else if (count == 0)
                {
                    return default(T);
                }
                else
                {
                    throw new ArgumentException(nameof(ReturnMatch));
                }
            }
            else
            {
                throw new ArgumentException(nameof(ReturnMatch));
            }
        }
        public bool ReturnMatchCheck(T value)
        {
            if (ValidCheck(value))
            {
                if (!OnlyList.Contains(value))
                {
                    return false;
                }
                else { return true; }
            }
            else
            {
                throw new ArgumentException(nameof(ReturnMatchCheck));
            }
        }
    }
}
