using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ClassMethods
{
    public class NumbersContainer
    {
        public List<int> Numbers { get; set; } = new List<int>();
        public void AddNumbers(int numbers)
        {
            Numbers.Add(numbers);
        }
        public void PrintNumbers(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
