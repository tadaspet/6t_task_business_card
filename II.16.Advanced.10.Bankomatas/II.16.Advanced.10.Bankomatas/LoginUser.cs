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
        public bool PassCheck()
        {
            Console.WriteLine("You have 3 tries to enter correct code\nPlease enter PIN code:");
            string input = Console.ReadLine();
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
                    Console.WriteLine($"PIN code was in correct." +
                        $"\nYou have left {3-countCheck} tries, please to re-enter code:");
                    input = Console.ReadLine();
                    goNext = false;
                }
                else 
                {
                    Console.WriteLine("Your card is blocked. Please contact your bank representatives");
                    goNext = false;
                    break;
                }
                countCheck++;
            }
            Password = goNext;
            return goNext;
        }
    }
}
