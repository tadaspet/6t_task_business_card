using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace _14.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List material
            //List<int> numbers = new List<int>();
            ////List<int> = new List<int> { 1, 2, 5, 4 };
            //numbers.Add(1);
            //numbers.Add(6);
            //numbers.Add(5);
            //numbers.Add(4);

            //Console.WriteLine("Initial list:");
            //int numbersCount = numbers.Count;
            //for (int i = 0; i < numbersCount; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int firstElement = numbers[0]; // take out first element value

            //numbers.Remove(5); // exclude element by value

            //Console.WriteLine("Excluded value 5");
            //int numbersCount2 = numbers.Count;
            //for (int i = 0; i < numbersCount2; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            ////int numbersCount = numbers.Count; // Element count 3

            //Console.WriteLine("Sorted list:");
            //numbers.Sort();  // sorting list by increasing value

            //for (int i = 0; i < numbersCount2; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Task 11
            //List<string> newList11 = new List<string>();
            //newList11.Add("Pasauli");
            //newList11.Add("Labas");
            //newList11.Add("Geras");
            //newList11.Add("Vakaras");
            //PrintListString(newList11);
            //Console.WriteLine("Length of the strings:");
            //List<int> intsLength = new List<int>();
            //StringLength(newList11, out intsLength);
            //PrintIntString(intsLength);
            #endregion

            #region Task 12
            //List<int> newList12;
            //int average;
            //CreateListOf50Integers(out newList12);
            //AvaregeOfTheIntegerList(newList12, out average);
            //Console.WriteLine($"List average is: {average}");
            //Console.WriteLine("The list:");
            //PrintIntString(newList12 );
            #endregion

            #region Task 13
            //Console.WriteLine("How many numbers will randomised in the list:");
            //int count = Convert.ToInt32(Console.ReadLine());
            //List<int> listStart13;
            //List<int> updatedList13;
            //CreateListOfIntegers(count, out listStart13);
            //Console.WriteLine("Current list is priting:");
            //PrintIntString(listStart13);
            //NumbersListMoreThan10(listStart13, out updatedList13);
            //Console.WriteLine("New List printing:");
            //PrintIntString(updatedList13);
            #endregion

            #region Task 21
            //Console.WriteLine("--------Task 21-------");
            //List<string> listString = new List<string> { "Greitis", "Asfaltas", "Sviesos", "Padangos", "Elektra" };
            //Console.WriteLine("Current list printing:");
            //PrintListString(listString);
            //List<string> updatedString = new List<string>();
            //StringNamesSum(listString, out updatedString);
            //Console.WriteLine("Priting List with even character no sum:");
            //PrintListString(updatedString);
            #endregion

            #region Task 22
            //Console.WriteLine("--------Task 22-------");
            //Console.WriteLine("How many numbers should be factorialized:");
            //int count = Convert.ToInt32(Console.ReadLine());
            //List<int> newIntList = new List<int>();
            //CreateListOfIntegers(count, out newIntList);
            //Console.WriteLine("Priting current list:");
            //PrintIntString(newIntList);
            //List<int> fakIntList = new List<int>();
            //ReturnListValuesFactorial(newIntList, out fakIntList);
            //Console.WriteLine("Priting faktorial list:");
            //PrintIntString(fakIntList);
            #endregion

            #region Task 23
            //Console.WriteLine("--------Task 23-------");
            //List<string> listString = new List<string> { "Greitis", "Asfaltas", "Sviesos", "Padangos", "Elektra" };
            //Console.WriteLine("Current list printing:");
            //PrintListString(listString);
            //List<string> updatedString = new List<string>();
            //List<int> numberSum = new List<int>();
            //ReturnListStringOfPrimeStringSum(listString, out updatedString, out numberSum);
            //Console.WriteLine("Priting ASCII word sums:");
            //PrintIntString(numberSum);
            //Console.WriteLine("Priting List of prime words:");
            //PrintListString(updatedString);

            #endregion
        }
        public static void PrintListString(List<string> texts11)
        {
            for (int i = 0;i < texts11.Count;i++)
            {
                Console.WriteLine(texts11[i]);
            }
        }
        public static void PrintIntString(List<int> intList)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine($"No {i+1}: {intList[i]}");
            }
        }
        public static void StringLength(List<string> texts11, out List<int> lengthString)
        {
            lengthString = new List<int>();
            for(int i = 0;i<texts11.Count ; i++)
            {
                lengthString.Add(texts11[i].Length); 
            }
        }
        public static void CreateListOf50Integers(out List <int> newList12)
        {
            newList12 = new List<int>();
            for (int i = 0; i < 50 ;i++)
            {
                Random random = new Random();
                newList12.Add(random.Next(i,150));
                //Console.WriteLine($"No {i+1} = {newList12[i]}");
            }
            newList12.Sort();
        }
        public static void CreateListOfIntegers(int count, out List<int> newList12)
        {
            newList12 = new List<int>();
            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                newList12.Add(random.Next(1, i+10));
            }
            newList12.Sort();
        }
        public static void AvaregeOfTheIntegerList(List <int> newList, out int average)
        {
            int count = newList.Count;
            int sum = 0;
            for (int i = 0; i < count ; i++)
            {
                sum += newList[i];
            }
            average = sum / count;
        }
        public static void NumbersListMoreThan10(List<int> newList13, out List<int> updatedList13)
        {
            updatedList13 = new List<int>();
            int count = newList13.Count;
            for (int i = 0;i<count;i++)
            {
                if (newList13[i] > 10)
                {
                    updatedList13.Add(newList13[i]);

                }
            }
        }
        public static void StringNamesSum(List<string> newList, out List<string> updatedList)
        {
            updatedList = new List<string>();
            for (int i = 0;i < newList.Count(); i++)
            {
                int charInt = 0;
                foreach (char c in newList[i])
                {
                    charInt += (int)c;
                }
                if (charInt % 2 == 0)
                {
                    updatedList.Add(newList[i]);
                }
            }
        }
        public static void ReturnListValuesFactorial(List<int> faktorial, out List<int> newIntfakt)
        {
            int fakt=1;
            newIntfakt = new List<int>();
            for (int i = 0; i < faktorial.Count; i++)
            {
                for (int j = 1; j <= faktorial[i]; j++)
                {
                    fakt *= j;
                }
                newIntfakt.Add(fakt);
                fakt = 1;
            }
        }
        public static void ReturnListStringOfPrimeStringSum(List<string> texts, out List<string> updatedList, out List<int> numberSum)
        {
            int rootNo;
            updatedList = new List<string>();
            numberSum = new List<int>();
            for (int i = 0; i < texts.Count(); i++)
            {
                int check1 = 0;
                int charInt = 0;
                foreach (char c in texts[i])
                {
                    charInt += (int)c;
                }
                numberSum.Add(charInt);
                if ((charInt % 2 != 0))
                {
                    rootNo = (int)Math.Floor(Math.Sqrt(charInt));
                    for (int k = 3; k < rootNo; k += 2)
                    {
                        if (charInt % k == 0)
                        {
                            check1++;
                        }
                    }
                }
                if (check1 == 0 && charInt % 2 !=0)
                {
                    updatedList.Add(texts[i]);
                }
                else
                {
                    updatedList.Add("NOT PRIME");
                }

            }
        }
    }
}