using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class CarComparer : IComparer<Car>
    {
        public int Compare(Car? x, Car? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            else if (x == null)
            {
                return -1;
            }
            else if ( y == null)
            {
                return 1;
            }
            else if (x.Fuel > y.Fuel)
            {
                return -1;
            }
            else if (y.Fuel < x.Fuel) 
            { 
                return 1; 
            }
            else
            {
                return 0;
            }
        }
    }
}
