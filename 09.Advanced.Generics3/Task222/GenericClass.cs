using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task222
{
    internal class GenericClass<T> : Validation<T>
    {
        public List<T> MainList { get; set; } = new List<T>();

        public void PrintList()
        {
            int count = 1;
            foreach (var item in MainList)
            {
                Console.WriteLine($"{count}. {item}");
                count++;
            }
        }
        public T[] ConverToArray()
        {
            T[] newArray = MainList.ToArray();
            return newArray;
        }
        public void AddToOneValueList(T value)
        {
            if (ValidCheck(value))
            {
                MainList.Add(value);
            }
            else
            {
                throw new ArgumentException(nameof(AddToOneValueList));
            }
        }
        public void AddListToList(List<T> list)
        {
            if (ValidCheckList(list))
            {
                MainList.AddRange(list);
            }
            else
            {
                throw new ArgumentException(nameof(AddListToList));
            }
        }
        public void RemoveElementFromList(T value)
        {
            if (ValidCheck(value) && MainList.Contains(value))
            {
                MainList.Remove(value);
            }
            else
            {
                throw new ArgumentException(nameof(RemoveElementFromList));
            }
        }
        public void RemoveIndexFromList(int index)
        {
            if (MainList.Count > index && index > 0)
            {
                MainList.RemoveAt(index);
            }
            else
            {
                throw new ArgumentException(nameof(RemoveIndexFromList));
            }
        }
        public void RemoveSameItemsFromList(T value)
        {
            if (MainList.Contains(value) && ValidCheck(value))
            {
                MainList.RemoveAll(x => x.Equals(value));
            }
            else
            {
                throw new ArgumentException(nameof(RemoveIndexFromList));
            }
        }
    }
}
