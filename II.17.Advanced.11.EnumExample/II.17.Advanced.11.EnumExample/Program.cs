using static II._17.Advanced._11.EnumExample.EnumExample;

namespace II._17.Advanced._11.EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(DayOfWeek.Monday);
            Console.WriteLine((int)DayOfWeek.Tuesday);
            Console.WriteLine((int)DayOfWeek.Sunday);
            DayOfWeek today;
            today = DayOfWeek.Sunday;
            string todayString = "SundayL";

            int muneChoice = int.Parse(Console.ReadLine()) + 1;

            switch((DaysOfWeek)muneChoice)
            {
                case (DaysOfWeek)DayOfWeek.Sunday:
                    Console.WriteLine("Today is Sunday");
                    break; 
                case (DaysOfWeek)DayOfWeek.Monday:
                    break; 
                case (DaysOfWeek)DayOfWeek.Tuesday:
                default: 
                    break;
            }
        }
    }
}