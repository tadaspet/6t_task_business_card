using System.Security.Cryptography;

namespace Teorijosegzaminas01022024v2
{
    internal class Program
    {
        public static void Main()
        {
            var integers = new List<int> { 1, 2, 3, 4 };
            var result = integers.Where(x => x == 1);
        }
    }

}
