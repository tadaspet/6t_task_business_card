using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._16.Advanced._10.Bankomatas
{
    internal class Menu
    {
        public int Selection { get; set; }
        public void Return()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Press any key to return back:");
            Console.ReadKey();
            Console.Clear();
        }

        public void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Please enter number to make action:" +
                "\n1. Check Balance." +
                "\n2. View transaction records." +
                "\n3. Withdraw." +
                "\n4. Quit.");
        }
        public int ActionMenu()
        {
            PrintMenu();
            string menuInput = Console.ReadLine();
            bool menuCheck = int.TryParse(menuInput, out int menuOption);
            while (menuOption > 4 || menuOption < 1 || !menuCheck)
            {
                Console.WriteLine("\nWrong input, numbers from 1 to 4 are only accepted."); 
                Console.Write("Please re-enter menu choice:");
                string secondTry = Console.ReadLine();
                menuCheck = int.TryParse(secondTry, out menuOption);
            }
            Console.Clear();
            Selection = menuOption;
            return menuOption;
        }
        public void Quit()
        {
            Console.WriteLine("Good Bye.");
            Environment.Exit(0);
        }
    }
}
