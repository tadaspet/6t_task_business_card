using III.DataBase.Exam.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace III.DataBase.Exam
{
    public class  ManageFaculties
    {
        public string ReadInputFacultyCode()
        {
            Console.WriteLine("Enter Faculty Code (6 characters):");
            string inPut = Console.ReadLine();
            Console.WriteLine();
            return inPut;
        }
        public string ValidationNewFacultyCode(dbContext dbCont, string facultyCode, out bool isNew)
        {
            List<string> facultyNames = dbCont.Faculties.Select(f => f.FacultyCode).ToList();
            Regex regex = new Regex("^[a-zA-Z0-9]*$");
            if (facultyCode.Length == 6 && regex.IsMatch(facultyCode) && !facultyNames.Contains(facultyCode))
            {
                    isNew = true;
                    return facultyCode;
            }
            else
            {
                isNew = false;
                return null;
            }
        }
        public string ValidationExistFacultyCode(dbContext dbCont, string facultyCode, out bool isValid)
        {
            List<string> facultyNames = dbCont.Faculties.Select(f => f.FacultyCode).ToList();
            if (facultyNames.Contains(facultyCode))
            {
                isValid = true;
                return facultyCode;
            }
            else
            {
                isValid = false;
                return null;
            }
        }
        public int ReturnFacultyIDbyCode(dbContext dbCont, string facultyCode)
        {
            var faculty = dbCont.Faculties.FirstOrDefault(x => x.FacultyCode == facultyCode);
            if (faculty == null)
            {
                return faculty.FacultyId;
            }
            else
            {
                return 0;
            }
        }
        public string ReadInputFacultyName()
        {
            Console.WriteLine("Enter Faculty Name (3-100 characters):");
            string inPut = Console.ReadLine();
            return inPut;
        }
        public string ValidationNewFacultyName(dbContext dbCont, string facultyName, out bool isNew)
        {
            List<string> facultyNames = dbCont.Faculties.Select(f => f.FacultyName).ToList();
            if (facultyName.Length > 3 && facultyName.Length < 101 && !facultyNames.Contains(facultyName))
            {
                isNew = true;
                return facultyName;
            }                         
            else
            {
                isNew = false;
                return null;
            }
        }
        public string ReadInputDeanNameAndSurname()
        {
            Console.WriteLine("Enter Dean name and surname (5-100 letters):");
            string inPut = Console.ReadLine();
            return inPut;
        }
        public string ValidationDeanNameAndSurname(string name, out bool isValid)
        {
            Regex regex = new Regex("^[a-zA-Z ]*$");
            if (name.Length > 5 && name.Length < 101 && regex.IsMatch(name))
            {
                isValid = true;
                return name;
            }
            else
            {
                isValid = false;
                return null;
            }
        }
        public string ReadInputFacultyLocation()
        {
            Console.WriteLine("Enter Faculty addresss (5-200 letters):");
            string inPut = Console.ReadLine();
            return inPut;
        }
        public string ValidationFacultyLocation(string address, out bool isValid)
        {
            if (address.Length > 5 && address.Length < 201)
            {
                isValid = true;
                return address;
            }
            else
            {
                isValid = false;
                return null;
            }
        }
        public void PrintAllFacultyCoursesList(dbContext dbContext)
        {
            PrintAllFaculties(dbContext);
            Console.WriteLine();

            //Validate and get existing Faculty Code
            var facCode = "";
            bool checkFacultCode = false;
            while (!checkFacultCode)
            {
                facCode = ValidationExistFacultyCode(dbContext, ReadInputFacultyCode(), out checkFacultCode);
            }

            //Get Faculty Couses Student information by Faculty Code
            var faculty = dbContext.Faculties.Include(f=>f.Courses).ThenInclude(c => c.Students).FirstOrDefault(s => s.FacultyCode == facCode);

            //Print courses if any
            if (faculty.Courses.Count > 0)
            {
                //var faculty = dbContext.Faculties.FirstOrDefault(c => c.FacultyCode == facCode);
                Console.WriteLine($"Courses at {faculty.FacultyName}:\n");
                int count = 1;
                foreach (Course course in faculty.Courses)
                {
                    int studentCount = course.Students.Count( c => c.FacultyId == faculty.FacultyId );
                    Console.WriteLine($"{count}. {course.CourseName},".ToString().PadRight(30) + $"\tTime - {course.Time}, \tStudents - {studentCount}.");
                    count++;
                }
            }
            else { Console.WriteLine("The faculty does not have any courses."); }
        }
        public void PrintAllFacultyStudentList(dbContext dbContext)
        {
            //Validate and get existing Faculty Code
            PrintAllFaculties(dbContext);
            Console.WriteLine();
            var facCode = "";
            bool checkFacultCode = false;
            while (!checkFacultCode)
            {
                facCode = ValidationExistFacultyCode(dbContext, ReadInputFacultyCode(), out checkFacultCode);
            }
            //Get Faculty information by the Code
            var faculty = dbContext.Faculties.Include( f => f.Students).FirstOrDefault(c => c.FacultyCode == facCode);
            //Get all Students from the Faculty
            var students = faculty.Students.ToList();

            //Print student list if it has information
            if (students.Count > 0)
            {
                Console.WriteLine($"Students at {faculty.FacultyName}:\n");
                int count = 1;
                foreach (Student student in students)
                {
                    Console.WriteLine($"{count}. {student.StudentCode}, {student.Name} {student.Surname}, {student.Email}");
                    count++;
                }
            }
            else { Console.WriteLine("The faculty does not have any students."); }
        }
        public void PrintAllFaculties(dbContext dbContext)
        {
            //Get All Faculties to the list
            var faculties = dbContext.Faculties.Select(x=>x).ToList();

            //Print all Faculties frim the list if it has information
            if (faculties.Count > 0)
            {
                Console.WriteLine($"Faculties list:\n");
                int count = 1;
                foreach (Faculty faculty in faculties)
                {
                    Console.WriteLine($"{count}. {faculty.FacultyCode}, {faculty.FacultyName}");
                    count++;
                }
            }
            else { Console.WriteLine("The University does not have any faculties."); }
            Console.WriteLine();
        }
        public void CreateNewDepartment(dbContext dbContext,ManageStudents studentInfo,ManageCourses courseInfo)
        {

            //Read and validate Faculty Code
            var facCode = "";
            bool check = false;
            while (!check)
            {
                facCode = ValidationNewFacultyCode(dbContext, ReadInputFacultyCode(), out check);
            }

            //Read and validate Faculty Name
            bool nameCheck = false;
            string name = "";
            while (!nameCheck)
            {
                name = ValidationNewFacultyName(dbContext, ReadInputFacultyName(), out nameCheck);
            }

            //Read and validate Faculty Dean Name&Surname
            bool deanCheck = false;
            string dean = "";
            while (!deanCheck)
            {
                dean = ValidationDeanNameAndSurname(ReadInputDeanNameAndSurname(), out deanCheck);
            }

            //Read and validate Faculty Dean Name&Surname
            bool locationCheck = false;
            string location = "";
            while (!locationCheck)
            {
                location = ValidationFacultyLocation(ReadInputFacultyLocation(), out locationCheck);
            }

            //Get Course and Student List
            var includeCourses = courseInfo.SelectCourses(dbContext, courseInfo);
            var relocateStudents = studentInfo.SelectStudents(dbContext, studentInfo);

            //Create Faculty with validated Data and selected courses
            var facultyNew = new Faculty 
            {
                FacultyName = name,
                FacultyCode = facCode,
                Dean = dean,
                Location = location,
                Courses = includeCourses,
            };
            dbContext.Add(facultyNew);
            dbContext.SaveChanges();

            //Relocate students to department
            var facultyUpdate = dbContext.Faculties.FirstOrDefault(x => x.FacultyCode == facCode);
            relocateStudents.ForEach(s => { s.FacultyId = facultyUpdate.FacultyId; });
            dbContext.SaveChanges();
        }
    }
}

