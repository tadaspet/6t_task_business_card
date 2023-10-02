namespace _05.Accessibillity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tadas", "Petruitis", 1987);

            //person.Name = "Test";
            ////person.Years = 1987;  // imposible to set years because property is private
            //person.SetYears(1987);
            //Console.WriteLine(person.Name + " " + person.GetYears());

            //Console.WriteLine(person.GetUserData());
        }
    }
}