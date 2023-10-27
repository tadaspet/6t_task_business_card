using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class StudenCompareByID : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Id > y.Id)
            {
                return -1;
            }
            else if (x.Id < y.Id)
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
