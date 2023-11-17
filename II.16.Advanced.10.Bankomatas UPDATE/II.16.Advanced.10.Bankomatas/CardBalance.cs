using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._16.Advanced._10.Bankomatas
{
    internal class CardBalance : LoginUser
    {
        public Account User { get; set; }
        public bool Access { get; set; }

        public CardBalance(LoginUser user) : base(user)
        {
            User = user.Account;
            Access = user.Password;
        }
        public void ShowBalance()
        {
            if (Access)
            {
                Console.Clear();
                Console.WriteLine($"Your account No: {User.Id}" +
                    $"\nBalance: {User.Balance} Euros.");
            }
            else
            {
                Console.WriteLine("The card is blocked!");
                Environment.Exit(0);
            }
        }
        public void ShowBalanceFirstTime()
        {
            if (Access)
            {
                Console.Clear();
                Console.WriteLine($"Your account No: {User.Id}" +
                    $"\nBalance: {User.Balance} Euros.");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("The card is blocked!");
                Environment.Exit(0);
            }
        }
    }
}
