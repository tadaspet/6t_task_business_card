namespace AnonomousDelegates
{
    internal class Program
    {
        private delegate int NumberChanger(int n);
        public delegate void NumberChanger2(int n);
        static void Main(string[] args)
        {
            #region Example 1
            Console.WriteLine("----------------\n");
            NumberChanger changer = delegate (int number)
            {
                return number + 5;
            };
            Console.WriteLine(changer(5));
            #endregion

            #region Example 2
            Console.WriteLine("\n----------------\n");
            int x = 5;
            NumberChanger changer2 = delegate (int number)
            {
                return number + x;
            };
            Console.WriteLine(changer2(5));
            #endregion

            #region Example 3
            Console.WriteLine("\n----------------\n");
            
            int x2 = 5;

            ExecuteNumberChangerWithValue(x2, delegate (int value)
            {
                Console.WriteLine(value);
            });

            #endregion
        }
        public static void ExecuteNumberChangerWithValue(int val, NumberChanger2 numberchanger3)
        {
            val += 10;
            numberchanger3(val);
        }
    }
}