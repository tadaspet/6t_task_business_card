namespace II._12Advanced._6.DelegatesAnonomousMetods
{
    internal class Program
    {
        static readonly int GLobalNumber = 10;          //field
        private delegate int NumberChanger(int n);      //delegate
        private delegate string ReturnString(string firstName, string lastName, string age);
        private delegate int TwoIntSum(int num1, int num2);
        private delegate List<int> ListByStep(List<int> list, int step);
        private delegate string GetTypeInformation<T>(T value);
        static void Main(string[] args)
        {
            #region Examples 1
            //var numberChanger1 = new NumberChanger(AddNumber);
            //var numberChanger2 = new NumberChanger(SubtractNumber);

            NumberChanger numberChanger1 = delegate (int number)
            {
                return AddNumber(number);
            };

            NumberChanger numberChanger2 = delegate (int number)
            {
                return SubtractNumber(number);
            };

            Console.WriteLine(numberChanger1(5));
            Console.WriteLine(numberChanger2(6));
            //Console.WriteLine(AddNumber(5));
            //Console.WriteLine(SubtractNumber(6));
            #endregion


            #region Task1.1
            Console.WriteLine("\n-----------------");

            string firstName = "Tadas";
            string lastName = "Petruitis";
            string age = "35";

            //var stringInformation = new ReturnString(PersonInfo);

            ReturnString stringInformation = delegate (string fName, string lName, string age)
            {
                return PersonInfo(firstName, lastName, age);
            };

            Console.WriteLine(stringInformation(firstName,lastName,age));
            #endregion


            #region Task1.2
            Console.WriteLine("\n-----------------");

            int number1 = 5;
            int number2 = 6;
            var intsum = new TwoIntSum(IntNumbersSum);

            TwoIntSum intSum = delegate (int num, int num2)
            {
                return IntNumbersSum(number1, number2);
            }; 
                
            Console.WriteLine(intsum(number1,number2));
            #endregion

            #region Task1.3
            Console.WriteLine("\n-----------------");

            List<int> list = new List<int> { 2,4,6,8,10,12,14,16,18,20};
            int step = 4;
            //var listStep = new ListByStep(ListBySteps);

            ListByStep listStep = delegate (List<int> list, int num)
            {
                return ListBySteps(list, step);
            };

            foreach (var item in listStep(list, step))
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Task1.4
            Console.WriteLine("\n-----------------");

            int number3 = 5;
            //var stringIntType = new GetTypeInformation<int>(ReturnTType);
            GetTypeInformation<int> stringIntType = delegate (int value)
            {
                return ReturnTType(number3);
            };
            Console.WriteLine($"Int Type: {stringIntType(number3)}");


            string stringInfo3 = "Hello";
            //var stringStringType = new GetTypeInformation<string>(ReturnTType);
            GetTypeInformation<string> stringStringType = delegate (string value)
            {
                return ReturnTType(stringInfo3);
            };
            Console.WriteLine($"Int Type: {stringStringType(stringInfo3)}");

            List<List<float>> floatInfo = new List<List<float>> ();
            //var stringFloatType = new GetTypeInformation<List<List<float>>>(ReturnTType);
            GetTypeInformation<List<List<float>>> stringFloatType = delegate (List<List<float>> floatInfo)
            {
                return ReturnTType(floatInfo);
            };
            Console.WriteLine($"Int Type: {stringFloatType(floatInfo)}");
            #endregion

            Console.WriteLine("\n-----------------");


        }
        public static int AddNumber(int number)
        {
            return GLobalNumber + number;
        }
        public static int SubtractNumber(int number) 
        {
            return GLobalNumber - number;
        }
        public static string PersonInfo(string firstName , string lastName, string age)
        {
            string newString =($"Name: {firstName}," +
                $"\nLast Name: {lastName}," +
                $"\nAge: {age}.");
            return newString;
        }
        public static int IntNumbersSum(int number1, int number2)
        {
            return number1 + number2;
        }
        public static List<int> ListBySteps(List<int> list, int steps)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i+= steps) 
            {
                result.Add(list[i]);
            }
            return result;
        }
        public static string ReturnTType<T>(T value)
        {
            return value.GetType().ToString();
        }
    }
}