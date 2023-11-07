using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._19.Advanced.Exam
{
    public class UINavigation
    {
        public enum UserChoice
        {
            GoBack,
            Continue
        }
        //public enum UIMenu
        //{
        //    Tables = 1,
        //    Menu = 2,
        //    Quit = 3,
        //}
        public UserChoice MenuChoice()
        {
            Console.WriteLine("\n\nPress 'q' to finish order or press any button to add additional order.");
            string check = Console.ReadLine();
            if (check == "q")
            {
                return UserChoice.GoBack;
            }
            else
            {
                return UserChoice.Continue;
            }
        }
        public void PrintMainInterface()
        {
            Console.Clear();
            Console.WriteLine("Please enter number to make action:" +
                "\n1. View Menu" +
                "\n2. View Tables" +
                "\n3. Manage Tables" +
                "\n4. Quit");
        }
        public void PrintSubInterface(int tableNo)
        {
            Console.Clear();
            Console.WriteLine($"Please choose action number for table {tableNo} and press enter:" +
                "\n1. Add Order" +
                "\n2. Create Receipt" +
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
