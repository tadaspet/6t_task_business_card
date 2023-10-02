using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Extensions
    {
        public static bool IsPositive(this int num)
        {
            return num > 0;
        }
        public static bool IsEven(this int num)
        {
            return (num % 2 == 0);
        }
        public static bool IsGreater(this int num, int num2) 
        {
            return num2 > num;
        }
        public static bool ContainsSpaces(this string str)
        {
            return str.Contains(" ");
        }
        public static string MakeEmail(this string name, string birth, string domain)
        {
            return name+birth+domain;
        }
        public static T FindAndReturnEqual<T>(this List<T> list, T value)
        {
            if (list.Contains(value))
            {
                return value;
            }
            else return default(T);
        }
        public static List<T> EveryOtherWord<T>(this List<T> list)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i+=2)
            {
                result.Add(list[i]);
            }
            return result;
        }
    }
}
