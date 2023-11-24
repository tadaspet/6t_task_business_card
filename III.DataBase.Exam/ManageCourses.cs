using III.DataBase.Exam.DataBase.Models;
using System.Text.RegularExpressions;
using static III.DataBase.Exam.Program;

namespace III.DataBase.Exam
{
    public class ManageCourses
    {
        public string ReadInputCourseName()
        {
            Console.WriteLine("Enter Course Name (5-100 characters):");
            string inPut = Console.ReadLine();
            return inPut;
        }
        public string ValidationNewCourseName(dbContext dbCont, string courseName, out bool isNew)
        {
            List<string> courseAllNames = dbCont.Courses.Select(f => f.CourseName).ToList();
            if (courseName.Length > 5 && courseName.Length < 101 && !courseAllNames.Contains(courseName))
            {
                isNew = true;
                return courseName;
            }
            else
            {
                isNew = false;
                return null;
            }
        }
        public string ValidationExistingCourseName(dbContext dbCont, string courseName, out bool isValid)
        {
            List<string> courseAllNames = dbCont.Courses.Select(f => f.CourseName).ToList();
            if (courseName.Length > 5 && courseName.Length < 101 && courseAllNames.Contains(courseName))
            {
                isValid = true;
                return courseName;
            }
            else
            {
                isValid = false;
                return null;
            }
        }
        public string ReadInputCourseTime()
        {
            Console.WriteLine("Enter Course time (format 24:00):");
            string inPut = Console.ReadLine();
            return inPut;
        }
        public string ValidationTime(string time, out bool isValid)
        {
            Regex regex = new Regex("^([01]?[0-9]|2[0-3]):[0-5][0-9]$");
            if (regex.IsMatch(time))
            {
                isValid = true;
                return time;
            }
            else
            {
                isValid = false;
                return null;
            }
        }
        public string ReadInputCredits()
        {
            Console.WriteLine("Enter Credit amount (2 digits):");
            string inPut = Console.ReadLine();
            return inPut;
        }
        public int ValidationCredits(string amount, out bool isValid)
        {
            int amountCheck =0;
            isValid = int.TryParse(amount, out amountCheck) && amountCheck > 0 && amountCheck <100;
            if (isValid)
            {
                isValid = true;
                return amountCheck;
            }
            else
            {
                isValid = false;
                return 0;
            }
        }
        public void CreateNewCourseForDepartment(dbContext dbContext, ManageFaculties facultyInfo)
        {
            facultyInfo.PrintAllFaculties(dbContext);

            //Validate and get Faculty Code
            var facCode = "";
            bool check = false;
            while (!check)
            {
                facCode = facultyInfo.ValidationExistFacultyCode(dbContext, facultyInfo.ReadInputFacultyCode(), out check);
            }
            //Validate and get Course Name
            bool nameCheck = false;
            string name = "";
            while (!nameCheck)
            {
                name = ValidationNewCourseName(dbContext, ReadInputCourseName(), out nameCheck);
            }
            //Validate and get Course Time
            bool timeCheck = false;
            string time = "";
            while (!timeCheck)
            {
                time = ValidationTime(ReadInputCourseTime(), out timeCheck);
            }
            //Validate and get Course Credits
            bool creditCheck = false;
            int credits = 0;
            while (!creditCheck)
            {
                credits = ValidationCredits(ReadInputCredits(), out creditCheck);
            }

            //Find faculty information by Code
            var faculty = dbContext.Faculties.FirstOrDefault(x => x.FacultyCode == facCode);

            //Create Course object and assign Faculty
            var newCourse = new Course
            {
                CourseName = name,
                Time = time,
                Credits = credits,
                Faculties = new List<Faculty> { faculty },
            };

            //Write changes to the database
            dbContext.Courses.Add(newCourse);
            dbContext.SaveChanges();

        }
        public void PrintAllCoursesAtUniversity(dbContext dbContext)
        {
            List<Course> courseList = dbContext.Courses.ToList();
            int count = 1;
            if(courseList.Count > 0)
            {
                Console.WriteLine("The course list:");
                foreach (var course in courseList)
                {
                    Console.WriteLine($"{count}. {course.CourseName},".ToString().PadRight(30) + $"\tTime - {course.Time}");
                    count++;
                }
            }
            else { Console.WriteLine("There are no courses at University."); }

        }
        public List<Course> SelectCourses(dbContext dbContext, ManageCourses courseInfo)
        {
            List<Course> includeCourses = new List<Course>();
            var navigation = new Navigation();
            do
            {
                Console.WriteLine("Please choose Course Name for faculty assignement:");
                courseInfo.PrintAllCoursesAtUniversity(dbContext);
                bool isValidName = false;
                string courseName = courseInfo.ValidationExistingCourseName(dbContext, courseInfo.ReadInputCourseName(), out isValidName);
                if (isValidName)
                {
                    var facultyCourse = dbContext.Courses.FirstOrDefault(n => n.CourseName == courseName);
                    includeCourses.Add(facultyCourse);
                }
                else { Console.WriteLine("Ivalid input!"); }
            } while (navigation.MenuChoice());
            return includeCourses;
        }
        public void IncludeCoursesToExistingDepartment(dbContext dbContext, ManageFaculties facultyInfo)
        {
            facultyInfo.PrintAllFaculties(dbContext);
            //Validate and get existing Faculty Code
            var facCode = "";
            bool checkFacultCode = false;
            while (!checkFacultCode)
            {
                facCode = facultyInfo.ValidationExistFacultyCode(dbContext, facultyInfo.ReadInputFacultyCode(), out checkFacultCode);
            }
            //Get Faculty information by the Code
            var faculty = dbContext.Faculties.FirstOrDefault(c => c.FacultyCode == facCode);

            //Get Course selection from user
            var courseInfo = new ManageCourses();
            var courseList = SelectCourses(dbContext, courseInfo);

            //Insert to faculty each course
            courseList.ForEach(c => faculty.Courses.Add(c));
            //Save changes to Database
            dbContext.SaveChanges();
            Console.WriteLine($"Courses added to the {faculty.FacultyName}");
        }
    }
}