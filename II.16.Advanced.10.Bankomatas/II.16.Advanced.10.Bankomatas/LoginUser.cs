using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace II._16.Advanced._10.Bankomatas
{
    internal class LoginUser : CardCheck
    {
        internal Account Account { get; set; }
        internal bool Password { get; set; }

        public LoginUser(CardCheck cardCheck) : base(cardCheck) 
        {
            Account = cardCheck.UserInfo;
        }
        public string ReadPINCode()
        {
            Console.WriteLine("Please enter PIN code.\nYou have 3 tries.");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            string input = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;
            return input;
        }
        public bool PassCheck(string input)
        {
            int userPin;
            int countCheck = 1;
            bool goNext = false;
            while (int.TryParse(input,out userPin) || countCheck < 4)
            {
                if (userPin == Account.PinNo)
                {
                    Console.WriteLine("PIN code is correct.");
                    goNext = true;
                    break;
                }
                else if (countCheck <=2 ) 
                {
                    Console.Clear();
                    Console.Write("PIN code was ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("incorrect.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"\nYou have left {3-countCheck} tries, please re-enter code:");
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    input = Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                    goNext = false;
                }
                else 
                {
                    Console.WriteLine("Your card was blocked. Please contact your bank representatives.");
                    goNext = false;
                    Environment.Exit(0);
                    break;
                }
                countCheck++;
            }
            Password = goNext;
            return goNext;
        }
    }
}
