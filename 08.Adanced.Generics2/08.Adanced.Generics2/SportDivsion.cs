using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Adanced.Generics2
{
    internal class SportDivsion<T>
    {
        private List<T> DivisionLevel { get; set; }

        public void CreateDivsions(List<T> divisionLevel)
        {
            DivisionLevel = divisionLevel;        
        }
    }
}
