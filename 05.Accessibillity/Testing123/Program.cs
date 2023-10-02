using Task111;

namespace Testing123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 11 - 14
            Person person = new Person("Tadas",35);
            //person.PrintInfo(); //does not print because metod is protected
            Console.WriteLine(person.PrintName());
            Student student = new Student("Rapolas",19, "Stud123");
            Console.WriteLine($"Student ID: {student.GetStudentId()}");

            Teacher teacher = new Teacher("Kornelijus", 56, "Physics");
            teacher.GetSubject();
            #endregion
        }
    }
}