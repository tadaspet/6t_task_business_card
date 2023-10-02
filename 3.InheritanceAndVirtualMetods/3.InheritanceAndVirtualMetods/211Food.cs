using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.InheritanceAndVirtualMetods
{
    internal class Food : Product
    {
        public  DateTime ExpirationTime { get; set; } = DateTime.Today;

    }
}
