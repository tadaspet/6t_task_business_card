using Comparer;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Jonas",
                    Year = 1994,
                },
                new Student
                {
                    Id=3,
                    Name = "Petras",
                    Year = 1987,
                },
                new Student
                {
                    Id=2,
                    Name = "Saulius",
                    Year = 2001,
                }
            };

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine();

            students.Sort(new StudentComaparer());
            
            foreach(Student student in students)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.WriteLine("Compared by ID:");
            Console.WriteLine();

            

            students.Sort(new StudenCompareByID());

            students.ForEach( x => Console.WriteLine(x.Name));
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine();

            students.OrderByDescending(student => student.Id).ToList();
            Console.WriteLine("----------------");
            Console.WriteLine();

            students.ForEach(x => Console.WriteLine(x.Name));

        }
    }
}