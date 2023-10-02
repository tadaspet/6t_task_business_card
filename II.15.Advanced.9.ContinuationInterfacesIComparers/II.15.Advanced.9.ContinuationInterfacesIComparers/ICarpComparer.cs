using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._15.Advanced._9.ContinuationInterfacesIComparers
{
    internal class ICarpComparer : IComparer<Carp>
    {
        public int Compare(Carp? x, Carp? y)
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
            else if (x.SwimDepth > y.SwimDepth)
            {
                return 1;
            }
            else if (y.SwimDepth < x.SwimDepth)
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
