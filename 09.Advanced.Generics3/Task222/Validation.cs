using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task222
{
    public class Validation<T>
    {
        public bool ValidCheck(T value)
        {
            bool answer = false;
            if (value == null)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }
            return answer;
        }
        public bool ValidCheckList(List<T> list)
        {
            bool answer = false;
            if (list == null)
            {
                answer = false;
            }
            else
            {
                answer = true;
            }
            return answer;
        }
    }
}
