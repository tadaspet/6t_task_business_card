using System.Threading.Channels;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Console.WriteLine("-------------\nTask 1:");
            List<double> doublesList = new List<double> { 2.5, 4.5, 6.8, 7.0 };
            List<double> doubleList2 = doublesList.Select(x => x * x).ToList();
            PrintListDouble(doubleList2);
            #endregion

            #region Task2
            Console.WriteLine("\n-------------\nTask 2:");
            List<double> doublesList22 = new List<double> { -2.5, 4.5, -6.8, 7.0 };
            List<double> doubles22 = doublesList22.Where(x => x >0).ToList();
            PrintListDouble(doubles22);
            #endregion

            #region Task3
            Console.WriteLine("\n-------------\nTask 3:");
            List<int> intList33 = new List<int> { -2, 50, -16, 12, 3, -40,6 };
            List<int> intListResult33 = intList33.Where(x => x > 0 && x < 10).ToList();
            PrintListInt(intListResult33);
            #endregion

            #region Task4
            Console.WriteLine("\n-------------\nTask 4:");
            List<double> list44 = new List<double> { -2, 50, -16, 12, 3, -40, 6 };
            List<double> listResult44 = list44.OrderBy(x => x).ToList();
            PrintListDouble(listResult44);
            #endregion

            #region Task5
            Console.WriteLine("\n-------------\nTask 5:");
            List<double> list55 = new List<double> { -2, 50, -16, 12, 3, -40, 6 };
            List<double> listResult55 = list55.OrderByDescending(x => x).ToList();
            PrintListDouble(listResult55);
            #endregion

            #region Task6
            Console.WriteLine("\n-------------\nTask 6:");
            List<double> list66 = new List<double> { -2, 50, -16, 12, 3, -40, 6 };
            double Result66 = list66.Max(x => x);
            Console.WriteLine(Result66);
            #endregion


            #region Task7
            Console.WriteLine("\n-------------\nTask 7:");
            List<Person> personList = new List<Person> 
            {  
                new Person("Paulius Motiejunas", 47),
                new Person("Robertas javtokas", 21),
                new Person("Balius Jankunas", 41),
                new Person("Alius Maskoliunas", 48),
                new Person("Arturas Milkanis", 31)
            };
            List<string> nameList = personList.Select(person => person.Name).ToList();
            Console.WriteLine("Subtask 7.1:");
            nameList.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            List<int> ageList = personList.Select(age => age.Age).ToList();
            ageList.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nSubtask 7.2:");
            ageList.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nSubtask 7.3:");
            List<string> firstLetterA = nameList.Where(name => name[0]=='A').ToList();
            firstLetterA.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("\nSubtask 7.4:");
            List<Person> over40 = personList.Where(person => person.Age > 40).OrderBy(person => person.Name).ToList();
            over40.ForEach(person => Console.WriteLine(person.Age + " " + person.Name));

            #endregion





        }
        static void PrintListDouble(List<double> list)
        {
            foreach (var task in list)
            {
                Console.WriteLine(task);
            }
        }
        static void PrintListInt(List<int> list)
        {
            foreach (var task in list)
            {
                Console.WriteLine(task);
            }
        }
    }
}