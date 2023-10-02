using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._15.Advanced._9.ContinuationInterfacesIComparers
{
    internal class ICompareDog : IComparer<Dog>
    {
        public int Compare(Dog? x, Dog? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            else if (x == null)
            {
                return -1;
            }
            else if (y == null)
            {
                return 1;
            }
            else if (x.ChildrenAmount > y.ChildrenAmount)
            {
                return 1;
            }
            else if (y.ChildrenAmount < x.ChildrenAmount)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
