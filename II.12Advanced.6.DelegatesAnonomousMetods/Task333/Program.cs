using System;

namespace Task333
{
    internal class Program
    {
        public delegate bool Filter(Person person);
        static void Main(string[] args)
        {

            List<Person> list = new List<Person> 
            { 
                new Person("Jonas Keras",35),
                new Person("Valius Pirtikas",17),
                new Person("Steponas Ralys",20),
                new Person("Valerijus Okinas",13),
                new Person("Tadas Kintas",65),
            };

            //var children = new Filter(IsChild);

            DisplayPeople("Children", list, delegate(Person person) 
            {
                if (person.Age < 18)
                {
                    return true;
                }
                else { return false; }
            });
            Console.WriteLine("---------------\n");
            DisplayPeople("Adult", list, delegate (Person person)
            {
                if (person.Age >= 18)
                {
                    return true;
                }
                else { return false; }
            });
            Console.WriteLine("---------------\n");
            DisplayPeople("Senior", list, delegate(Person person)
            {
                if (person.Age >= 65)
                {
                    return true;
                }
                else { return false; }
            });
        }
        public static bool IsChild(Person person)
        {
            if (person.Age < 18)
            {
                return true;
            }
            else { return false; }
        }
        public static bool IsAdult(Person person)
        {
            if (person.Age >= 18)
            {
                return true;
            }
            else { return false; }
        }
        public static bool IsSenior(Person person)
        {
            if (person.Age >= 18)
            {
                return true;
            }
            else { return false; }
        }
        public static void DisplayPeople(string title, List<Person> list, Filter filter)
        {
            int count = 1;
            foreach(Person person in list)
            {
                Console.WriteLine($"{title}: {person.Name} {person.Age}, {filter(person)}");
                count++;
            }
        }
    }
}