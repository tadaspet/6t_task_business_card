using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III.DataBase.Exam
{
    public class Navigation
    {

        public bool MenuChoice()
        {
            Console.WriteLine("\n\nPress 'q' to finish, or press any key to continue.");
            string check = Console.ReadLine();
            if (check == "q")
            {
                Console.Clear();
                return false;
            }
            else
            {
                Console.Clear();
                return true;
            }
        }
        public void PrintMainInterface()
        {
            Console.Clear();
            Console.WriteLine("Please enter number to make action:" +
                "\n1. Manage Faculty" +
                "\n2. Manage Students" +
                "\n3. Manage Courses" +
                "\n4. Quit");
        }
        public void PrintFacultyInterface()
        {
            Console.Clear();
            Console.WriteLine("Please enter number to make action:" +
                "\n1. Create Faculty" +
                "\n2. Students List by Faculty" +
                "\n3. Courses List by Faculty" +
                "\n4. Return");
        }
        public void PrintStudentInterface()
        {
            Console.Clear();
            Console.WriteLine("Please enter number to make action:" +
                "\n1. Create new Student & assign To Faculty" +
                "\n2. Transfer Stundent to new Faculty" +
                "\n3. Show Student Courses" +
                "\n4. Return");
        }
        public void PrintCourseInterface()
        {
            Console.Clear();
            Console.WriteLine("Please enter number to make action:" +
                "\n1. Create new Course & assign To Faculty" +
                "\n2. Assing existing Course to new Faculty" +
                "\n3. Return");
        }
        public int ActionMainMenu(int maxInput)
        {
            string menuInput = Console.ReadLine();
            bool menuCheck = int.TryParse(menuInput, out int menuOption);
            while (menuOption > maxInput || menuOption < 1 || !menuCheck)
            {
                Console.WriteLine($"\nWrong input, numbers from 1 to {maxInput} are only accepted.");
                Console.Write("Please re-enter menu choice:");
                string secondTry = Console.ReadLine();
                menuCheck = int.TryParse(secondTry, out menuOption);
            }
            Console.Clear();
            return menuOption;
        }
        public void Return()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\nPress any key to return back:");
            Console.ReadKey();
            Console.Clear();
        }
        public void Quit()
        {
            Console.WriteLine("Good Bye.");
            Environment.Exit(0);
        }
    }
}

