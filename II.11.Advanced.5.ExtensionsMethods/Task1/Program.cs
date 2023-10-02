namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 3;
            Console.WriteLine($"Number {number} is positive? {number.IsPositive()}");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Number {number} is even? {number.IsEven()}");
            int number2 = 1;
            Console.WriteLine("-----------------");
            Console.WriteLine($"Number {number2} is greater than {number}? {number.IsGreater(number2)}");
            Console.WriteLine("-----------------");
            string someText = "Ho ware you?";
            Console.WriteLine($"Does text '{someText}' contains spaces? {someText.ContainsSpaces()}");
            Console.WriteLine("-----------------");
            string name = "TadasPetruitis";
            Console.WriteLine($"Email: {name.MakeEmail("1987","@gmail.com")}");
            Console.WriteLine("-----------------");

            List<int> list = new List<int> { 1,2,3,4,5,6,7,8,9};
            int value1 = 10;
            Console.WriteLine($"List searched for {value1} value and found: {list.FindAndReturnEqual(value1)}.");

            List<string> list2 = new List<string> { "alb", "bla", "lab","bal", "abl", "lba" };
            string value2 = "a";
            Console.WriteLine($"List searched for {value2} value and found: {list2.FindAndReturnEqual(value2)}.");

            List<int> listInt = list.EveryOtherWord();
            foreach( int item in listInt )
            {
                Console.WriteLine(item);
            }

            List<string> listString = list2.EveryOtherWord();
            foreach (var item in listString)
            {
                Console.WriteLine(item);
            }


        }
    }
}