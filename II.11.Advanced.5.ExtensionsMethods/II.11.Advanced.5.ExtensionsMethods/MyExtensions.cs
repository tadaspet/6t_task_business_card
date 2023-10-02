using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._11.Advanced._5.ExtensionsMethods
{
    public static class MyExtensions
    {
       public static int WordCount(this string str) //Sveiki kaip gyvenate?
        {
            //"Sveiki" , "kaip", "gyvenate";
            var wordArray = str.Split(new char[] { ' ', '.', '?' },
                            StringSplitOptions.RemoveEmptyEntries).Length;
            return wordArray;
        }
        public static bool IsAdult (this Employee employee)
        {
            return employee.Age > 18;
        }
    }
}
