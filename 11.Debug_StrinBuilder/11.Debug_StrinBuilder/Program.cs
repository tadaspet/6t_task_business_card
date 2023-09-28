using System.Diagnostics;
using System.Text;
using System.Threading.Channels;

namespace _11.Debug_StrinBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Example of logging
            //Console.Write("Hello, Testing!");
            //Console.WriteLine();
            //string JonasJonaitis = GetFullName("Jonas", "Jonaitis");
            //PrintDanger("PIRMAS ATSPAUSDINIMAS");
            //string PetrasPetraitis = GetFullName("Petras", "Petraitis");
            //PrintDanger("ANTRAS ATSPAUSDINIMAS");
            //string GretaGretaite = GetFullName("Greta", "Gretaite");
            //PrintDanger("TRECIAS ATSPAUSDINIMAS");
            #endregion

            #region Task 1
            //Console.WriteLine("======Task 1======");
            //int a = 3;
            //int b = 5;
            //int c = 8;

            //int max = a;
            //if (b > max)
            //{
            //    max = b;
            //}
            //if (c > max)
            //{
            //    max = c;// klaida
            //}
            //Console.WriteLine("The maximum value is: " + max);
            //Console.WriteLine("=======END========");
            #endregion

            #region Task2
            //Console.WriteLine("======Task 2======");
            //string firstName = "John";
            //string lastName = "Doe";
            //string fullName = firstName + " " + lastName; // corrected code with space between name values
            ////PrintDanger(fullName);
            //Console.WriteLine("Full Name: " + fullName);
            //Console.WriteLine("=======END========");
            #endregion

            #region Task3 
            //Console.WriteLine("======Task 3======");
            //int counter = 0;
            //while (counter <= 10)
            //{
            //    Console.WriteLine("Count: " + counter);
            //    counter++; // corrected iteration should increase
            //}
            //Console.WriteLine("=======END========");
            #endregion

            #region Task4
            //Console.WriteLine("======Task 4======");
            //int i = 5;
            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--; // iteration should decrease in order to stay in the range.
            //}
            //Console.WriteLine("=======END========");
            #endregion

            #region Task5
            //Console.WriteLine("======Task 5======");
            //string name1 = "John";
            //string name2 = "John"; //firt letter should be capital
            //if (name1.Equals(name2))
            //{
            //    Console.WriteLine("Names are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("Names are different");
            //}
            //Console.WriteLine("=======END========");
            #endregion

            #region Example StringBuilder

            //StringBuilder stringBuilder = new StringBuilder();

            //stringBuilder.Append("Labas, ");
            //stringBuilder.Append("kaip sekasi? ");
            //stringBuilder.Append("Tikiuosi, kad viskas gerai!");

            //string result = stringBuilder.ToString();
            //Console.WriteLine(result);

            #endregion


            #region STOPWATCH Example
            //string text = "";
            //int iterations = 100000;

            ////First scenario: direct "string" manipulations
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //for (int i = 0; i < iterations; i++)
            //{
            //    text += "A";
            //}

            //stopwatch.Stop();
            //TimeSpan elapsedStringManipulation = stopwatch.Elapsed;

            //// second scenario: "StringBuilder" in use.
            //stopwatch.Reset();
            //stopwatch.Start();

            //StringBuilder stringBuilder = new StringBuilder();
            //for (int i = 0; i < iterations; i++)
            //{
            //    stringBuilder.Append("A");
            //}
            //string result = stringBuilder.ToString();

            //stopwatch.Stop();
            //TimeSpan elapsedStringBuilder = stopwatch.Elapsed;

            ////Output results

            //Console.WriteLine("Direct 'string' manipulations: " + elapsedStringManipulation);
            //Console.WriteLine("In us of 'StringBuilder' : " + elapsedStringBuilder);

            #endregion


            #region Task 6.1
            //Console.WriteLine("======Task 6.1======");
            //StringBuilder reversedText = new StringBuilder();
            //string inPut6 = Console.ReadLine();
            //char[] original = inPut6.ToCharArray();
            //StringBuilder secondCheck = new StringBuilder();
            //for (int i = (inPut6.Length - 1); i >= 0; i--)
            //{
            //    secondCheck.Append(original[i]);
            //}
            //Console.WriteLine("Starting line:" + inPut6);
            //Console.WriteLine("Reversed line:" + secondCheck.ToString());
            //Console.WriteLine("=======END========");
            #endregion

            #region Task 6.2
            //Console.WriteLine("======Task 6.2======");
            //string userLine = Console.ReadLine();
            //StringBuilder newStrigB = new StringBuilder();
            //string empty = "";
            //for (int i = 0; i <= userLine.Length-1; i++)
            //{
            //    if (!empty.Contains(userLine[i]))
            //    {
            //        empty += userLine[i];
            //        newStrigB.Append(userLine[i]);
            //    }
            //}
            //Console.WriteLine(newStrigB.ToString());
            //Console.WriteLine("=======END========");
            #endregion
        }

        public static string GetFullName(string firstName, string lastName)
        {
            Console.WriteLine("Registruotas naudotojas: " + firstName + " " + lastName);
            return firstName.Trim() + " " + lastName.Trim();
        }
        public static void PrintDanger (string text)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}