using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace III.DataBase.Exam
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var dbCont = new dbContext();

            var studentInfo = new ManageStudents();
            var facultyInfo = new ManageFaculties();
            var courseInfo = new ManageCourses();

            var navigation = new Navigation();
            int menuOption = 0;
            const int mainMenuMax = 4;
            const int courseMenu = 3;
            do
            {
                navigation.PrintMainInterface();
                menuOption = navigation.ActionMainMenu(mainMenuMax);
                switch (menuOption)
                {
                    case 1:
                        {
                            navigation.PrintFacultyInterface();
                            int facultyOption = navigation.ActionMainMenu(mainMenuMax);
                            switch (facultyOption)
                            {
                                case 1:
                                    {
                                        facultyInfo.CreateNewDepartment(dbCont, studentInfo, courseInfo);
                                        navigation.Return();
                                    }
                                    break;
                                case 2:
                                    {
                                        facultyInfo.PrintAllFacultyStudentList(dbCont);
                                        navigation.Return();
                                    }
                                    break;
                                case 3:
                                    {
                                        facultyInfo.PrintAllFacultyCoursesList(dbCont);
                                        navigation.Return();
                                    }
                                    break;
                                case 4:
                                    {
                                        menuOption = 1;
                                    }
                                    break;
                            }
                        }
                        break;
                    case 2:
                        {
                            navigation.PrintStudentInterface();
                            int studentOption = navigation.ActionMainMenu(mainMenuMax);
                            switch (studentOption)
                            {
                                case 1:
                                    {
                                        studentInfo.CreateNewStudentAssignFacultyandCourses(dbCont, facultyInfo);
                                        Console.WriteLine("Studen was created and has all courses of Faculty.");
                                        navigation.Return();
                                    }
                                    break;
                                case 2:
                                    {
                                        facultyInfo.PrintAllFaculties(dbCont);
                                        studentInfo.IncludeStudentsToExistingDepartment(dbCont, facultyInfo);
                                        navigation.Return();
                                    }
                                    break;
                                case 3:
                                    {
                                        studentInfo.PrintAllStudentsAtUniversity(dbCont);
                                        studentInfo.PrintStudentCourses(dbCont);
                                        navigation.Return();
                                    }
                                    break;
                                case 4:
                                    {
                                        menuOption = 1;
                                    }
                                    break;
                            }
                        }
                        break;
                    case 3:
                        {
                            navigation.PrintCourseInterface();
                            int courseOption = navigation.ActionMainMenu(courseMenu);
                            switch (courseOption)
                            {
                                case 1:
                                    {
                                        courseInfo.CreateNewCourseForDepartment(dbCont, facultyInfo);
                                        navigation.Return();
                                    }
                                    break;
                                case 2:
                                    {
                                        courseInfo.IncludeCoursesToExistingDepartment(dbCont, facultyInfo);
                                        navigation.Return();
                                    }
                                    break;
                                case 3:
                                    {
                                        menuOption = 1;
                                    }
                                    break;
                            }
                        }
                        break;
                    case 4:
                        {
                            navigation.Quit();
                        }
                        break;
                }
            } while(menuOption > 0 && menuOption <= mainMenuMax);

        }

    }
}

