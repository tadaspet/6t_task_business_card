using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Advanced.Generics
{
    public class MySelfMadeList<T>
    {
        // Fields:
        private int index = 0;
        private int size = 10;
        // Properties:
        public T[] MyArray { get; set; }

        public MySelfMadeList() 
        {
            MyArray = new T[size];
        }
        public void AddElement(T elementToAdd)
        {
            if(CheckIfFull())
            {
                MyArray = IncreaseListSize();
            }
            if (elementToAdd != null)
            {
                MyArray[index] = elementToAdd;
                index++;
            }
            else
            {
                throw new ArgumentException(nameof(elementToAdd));
            }
        }
        private bool CheckIfFull()
        {
            if (index ==  size)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
        private T[] IncreaseListSize()
        {
            size += (size / 2);             // masyvo dydis 10 elementu // pridedama 50%
            var newArray = new T[size];     // sukuriamas naujas masyvas su 15 vietu
            MyArray.CopyTo(newArray, 0);    //perkopijuojamas masyvas senas masyvas i nauja
            return newArray;                //graziname naujo dydzio ir perkopijuota masyva
        }
        public void DeleteElement(T elementToRemove)
        {
            if (MyArray != null && MyArray.Contains(elementToRemove))
            {
                MyArray = RemovingElement(elementToRemove);
            }
            else
            {
                throw new ArgumentException(nameof(elementToRemove));
            }
        }
        private T[] RemovingElement(T elementToRemove)
        {
            int elementIndex = Array.IndexOf(MyArray, elementToRemove);
            var newArray1 = new T[MyArray .Length- 1];
            Array.Copy(MyArray,0, newArray1, 0, elementIndex);
            Array.Copy(MyArray, elementIndex+1, newArray1, elementIndex, MyArray.Length - elementIndex-1);
            return newArray1;
        }
    }
}
