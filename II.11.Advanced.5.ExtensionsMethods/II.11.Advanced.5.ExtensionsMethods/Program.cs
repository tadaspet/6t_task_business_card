namespace II._11.Advanced._5.ExtensionsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("Tadas", "Petruitis");
            Console.WriteLine(employee.Age);            //instace
            Employee.Nationality = "Lithuanian";        //statinis nustatymas nes pagal klase
            Console.WriteLine(Employee.Nationality);    //

            var myString = "Sveiki, kaip gyvante?";
            var wordsCount = MyExtensions.WordCount(myString);
            var wordsCount2 = myString.WordCount();
            Console.WriteLine(wordsCount);
            Console.WriteLine(wordsCount2);
            Console.WriteLine(employee.IsAdult());
        }
    }
}