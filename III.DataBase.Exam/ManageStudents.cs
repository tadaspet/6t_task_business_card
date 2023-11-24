using III.DataBase.Exam.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace III.DataBase.Exam
{
    public class ManageStudents 
    {
        public string ReadStudentCode()
        {
            Console.WriteLine("Enter Student Code (8 digits):");
            string inPut = Console.ReadLine();
            return inPut;
        }
        public int ValidationNewStudentCode(dbContext dbCont, string studCode, out bool isNew)
        {
            List<int> stuAllIds = dbCont.Students.Select(x => x.StudentCode).ToList();
            int parseID = 0;
            isNew = studCode != null && int.TryParse(studCode, out parseID) && studCode.Length == 8 && !stuAllIds.Contains(parseID);
            if (isNew)
            {
                isNew = true;
                return parseID;
            }
            else
            {
                isNew = false;
                return parseID;
            }
        }
        public int ValidationExistsStudentCode(dbContext dbCont, string studCode, out bool isValid)
        {
            List<int> stuAllIds = dbCont.Students.Select(x => x.StudentCode).ToList();
            int parseID = 0;
            isValid = studCode != null && int.TryParse(studCode, out parseID) && studCode.Length == 8 && stuAllIds.Contains(parseID);
            if (isValid)
            {
                isValid = true;
                return parseID;
            }
            else
            {
                isValid = false;
                return parseID;
            }
        }
        public string ReadInputStudentName()
        {
            Console.WriteLine("Enter Student Name (2-50 letters):");
            string inPut = Console.ReadLine();
            return inPut;
        }
        public string ValidationStudentName(string name, out bool isValid)
        {
            string testText = "";
            if (name.Length > 1 && name.Length < 51)
            {
                foreach (char c in name)
                {
                    if (char.IsLetter(c))
                    {
                        testText += c;
                    }
                }
                if (name.Length == testText.Length)
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
            else
            {
                isValid = false;
                return null;
            }
        }
        public string ReadInputStudentSurName()
        {
            Console.WriteLine("Enter Student Surname (2-50 letters):");
            string inPut = Console.ReadLine();
            return inPut;
        }
        public string ValidationStudentSurName(string surName, out bool isValid)
        {
            string testText = "";
            if (surName.Length > 1 && surName.Length < 51)
            {
                foreach (char c in surName)
                {
                    if (char.IsLetter(c))
                    {
                        testText += c;
                    }
                }
                if (surName.Length == testText.Length)
                {
                    isValid = true;
                    return surName;
                }
                else
                {
                    isValid = false;
                    return null;
                }
            }
            else
            {
                isValid = false;
                return null;
            }
        }
        public void PrintFaculties(dbContext dbCont)
        {
            List<Faculty> facultyList = dbCont.Faculties.ToList();
            if(facultyList.Count > 0)
            {
                Console.WriteLine("Faculties:\n");
                foreach (Faculty faculty in facultyList)
                {
                    Console.WriteLine($"{faculty.FacultyCode} - {faculty.FacultyName}");
                }
            }
            else { Console.WriteLine("No faculties in the system."); }
        }
        public string ReadInputStudentEmail()
        {
            Console.WriteLine("Enter Student email:");
            string inPut = Console.ReadLine();
            return inPut;
        }
        public string ValidationEmail(string email, out bool isValid)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                Regex regex = new Regex(@"^([\w\.-]+)@([\w-]+)((\.(\w){2,3})+)$");
                if(regex.IsMatch(email))
                {
                    isValid = true;
                    return email;
                }
                else
                {
                    isValid = false;
                    return null;
                }
            }
            else
            {
                isValid = false;
                return null;
            }
        }
        public void PrintStudentCourses(dbContext dbCont)
        {
            //Validate and get existing Student Codes
            bool codeCheck = false;
            int studentCode = 0;
            while (!codeCheck)
            {
                studentCode = ValidationExistsStudentCode(dbCont, ReadStudentCode(), out codeCheck);
            }

            //select student information
            var student = dbCont.Students.Include(x => x.Faculty).FirstOrDefault(x => x.StudentCode == studentCode);

            //Select Student by Code
            var courses = dbCont.Students
                .Where(x => x.StudentCode == studentCode)
                .SelectMany(c => c.Courses).ToList();

            //Print Courses table
            Console.WriteLine($"\nStudent - {student.Name} {student.Surname}\nFaculty - {student.Faculty.FacultyName}\nCourses & Credits:");
            int count =1;
            foreach (Course course in courses)
            {
                Console.WriteLine($"{count}. {course.CourseName}, credits - {course.Credits}");
                count++;
            }
        }
        public void CreateNewStudentAssignFacultyandCourses(dbContext dbContext, ManageFaculties facultyInfo)
        {
            facultyInfo.PrintAllFaculties(dbContext);
            //Validate Faculty code if exists
            var facCode = "";
            bool check = false;
            while (!check)
            {
                facCode = facultyInfo.ValidationExistFacultyCode(dbContext, facultyInfo.ReadInputFacultyCode(), out check);
            }

            //Validate and get Student Code to be unique
            bool codeCheck = false;
            int code = 0;
            while(!codeCheck)
            {
                code = ValidationNewStudentCode(dbContext, ReadStudentCode(), out codeCheck);
            }

            //Validate & get student Name format
            bool nameCheck = false;
            string name = "";
            while (!nameCheck)
            {
                name = ValidationStudentName(ReadInputStudentName(), out nameCheck);
            }

            //Valid & get student Surname format
            bool surNameCheck = false;
            string surName = "";
            while (!surNameCheck)
            {
                surName = ValidationStudentSurName(ReadInputStudentSurName(), out surNameCheck);
            }

            //Validate & get email format
            bool emailCheck = false;
            string email = "";
            while (!emailCheck)
            {
                email = ValidationEmail(ReadInputStudentEmail(), out emailCheck);
            }

            //Get Faculty information by the Code
            var faculty = dbContext.Faculties.FirstOrDefault(x => x.FacultyCode == facCode);

            //Get Courses from the Faculty 
            var courses = dbContext.Courses.Where(c => c.Faculties.Any(f => f.FacultyCode == facCode)).ToList();

            //Create Student object
            var newStud = new Student
            {
                StudentCode = code,
                Name = name,
                Surname = surName,
                Email = email,
                Faculty = faculty,
                Courses = courses,
            };

            //Insert to Database
            dbContext.Add(newStud);
            dbContext.SaveChanges();
        }
        public void PrintAllStudentsAtUniversity(dbContext dbContext)
        {
            var studentList = dbContext.Students.ToList();
            int count = 1;
            if (studentList.Count > 0)
            {
                Console.WriteLine("The student list:");
                foreach (var student in studentList)
                {
                    Console.WriteLine($"{count}. {student.StudentCode}, {student.Name} {student.Surname}");
                    count++;
                }
            }
            else { Console.WriteLine("There are no students at University."); }
            Console.WriteLine("\n");
        }
        public List<Student> SelectStudents(dbContext dbContext, ManageStudents studentInfo)
        {
            List<Student> relocateStudents = new List<Student>();
            var navigation = new Navigation();
            //Gather list of students by the code
            do
            {
                Console.WriteLine("Please choose Student Code for faculty assignement:");
                //Show All Stundets
                studentInfo.PrintAllStudentsAtUniversity(dbContext);
                bool isValidCode = false;
                //Validate and get Student Code
                int studentCode = studentInfo.ValidationExistsStudentCode(dbContext, studentInfo.ReadStudentCode(), out isValidCode);
                if (isValidCode)
                {
                    var facultyStudent = dbContext.Students.FirstOrDefault(n => n.StudentCode == studentCode);
                    relocateStudents.Add(facultyStudent);
                }
                else { Console.WriteLine("Ivalid input!"); }
            } while (navigation.MenuChoice());
            return relocateStudents;
        }
        public List<Student> SelectStudentsForTransfer(dbContext dbContext, ManageStudents studentInfo)
        {
            PrintAllStudentsAtUniversity(dbContext);
            List<Student> relocateStudents = new List<Student>();
            var navigation = new Navigation();
            //Gather list of students by the code
            do
            {
                Console.WriteLine("Please choose Student Code for faculty assignement:");
                bool isValidCode = false;
                //Validate and get Student Code
                int studentCode = studentInfo.ValidationExistsStudentCode(dbContext, studentInfo.ReadStudentCode(), out isValidCode);
                if (isValidCode)
                {
                    var facultyStudent = dbContext.Students.Include(c => c.Courses).FirstOrDefault(n => n.StudentCode == studentCode);
                    relocateStudents.Add(facultyStudent);
                }
                else { Console.WriteLine("Ivalid input!"); }
            } while (navigation.MenuChoice());
            return relocateStudents;
        }
        public void IncludeStudentsToExistingDepartment(dbContext dbContext, ManageFaculties facultyInfo)
        {
            //validate Faculty by Code
            var facCode = "";
            bool checkFacultCode = false;
            while (!checkFacultCode)
            {
                facCode = facultyInfo.ValidationExistFacultyCode(dbContext, facultyInfo.ReadInputFacultyCode(), out checkFacultCode);
            }
            var faculty = dbContext.Faculties.Include(f => f.Courses).Include(s=>s.Students).FirstOrDefault(c => c.FacultyCode == facCode);

            //get students
            var studentInfo = new ManageStudents();
            var studentList = SelectStudentsForTransfer(dbContext, studentInfo);

            //change and save student courses
            foreach(var student in studentList)
            {
                student.Courses.Clear();
                student.Courses = faculty.Courses.ToList();
                faculty.Students.Add(student);
            }
            dbContext.SaveChanges();
            Console.WriteLine($"Students added to the {faculty.FacultyName} with it's courses.");
        }
    }
}

