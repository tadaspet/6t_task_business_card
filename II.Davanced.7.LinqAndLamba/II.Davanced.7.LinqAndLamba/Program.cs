namespace II.Davanced._7.LinqAndLamba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exmpale 1
            Func<int, int> multiplyByFive = (num) => num *5;
            Func<int, int> multiplyByFour = (num) =>
            {
                return num * 4;
            };

            int result = multiplyByFive(7);
            int result2 = multiplyByFour(7);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine("\n-------------\n");
            Func<int, int, int> multiply = (int num1, int num2) => num1 * num2;
            int result3 = multiply(5, 3);
            Console.WriteLine($"Anser: {result3}");

            //Func<string> funcWithoutParameters = () =>
            //{
            //    return "returning from func without parameters";
            //};
            Console.WriteLine("\n-------------\n");
            Func<string> funcWithoutParameters = () => "returning from func without parameters";
            Console.WriteLine(funcWithoutParameters());
            Console.WriteLine("\n-------------\n");
            Func<bool, string, DateTime, decimal> differentParameters = (arg1, arg2, arg3) => 1.78m;
            Console.WriteLine(differentParameters(false,"labas", DateTime.Now));
            Console.WriteLine("\n-------------\n");
            Func<int, bool> IsIntegerHigherThanTen = (num1) => num1 > 10;
            Console.WriteLine(IsIntegerHigherThanTen(11));
            Console.WriteLine("\n-------------\n");
            Func<int, int,bool> comparisonNumber = (num1, num2) => num1 > num2;
            Console.WriteLine(comparisonNumber(10,11));
            Console.WriteLine("\n-------------\n");
            Func<int, int, int> returnHigher = (num1, num2) =>
            {
                if (num1 > num2)
                {
                    return num1;
                }
                else { return num2; }
            };
            Console.WriteLine(returnHigher(12,11));
            #endregion

            #region Example 2
            Console.WriteLine("\n-------------\n");
            //Func<string, string> selector = str => str.ToUpper();

            string[] words = { "orange", "apple", "Article", "elephant" };

            //IEnumerable<string> wordsEnum = words.Select(selector);
            IEnumerable<string> wordsEnum = words.Select(str => str.ToUpper());

            foreach (string word in wordsEnum)
            {
                Console.WriteLine(word);
            }
            #endregion
        }
    }
}