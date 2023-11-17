using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace II._16.Advanced._10.Bankomatas
{
    internal class CardCheck : BankInformation
    {
        //public List<Account> CardHolder { get; set; }
        public Account UserInfo { get; set; } 

        //public CardCheck(BankInformation bankinformation)
        //{
        //    CardHolder = bankinformation.Accounts;
        //}

        public void ShowAccounts()
        {
            var accounts = new AccountDataBase();
            List<Account> list = accounts.Accounts.ToList();
            Console.WriteLine("Verified card list:");
            list.ForEach(x => Console.WriteLine(x.Id));
        }
        public string GetGuid()
        {
            Console.WriteLine("\nPlease enter your Card Number:");
            return Console.ReadLine();
        }
        public void CheckGuide(string userGuid)
        {
            var accounts = new AccountDataBase();
            bool check = accounts.Accounts.Any(x => x.Id == userGuid);
            if (check)
            {
                Console.Clear();
                Console.WriteLine("Your card was accepted.");
                var account = accounts.Accounts.FirstOrDefault(x => x.Id == userGuid);
                UserInfo = account;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Your card was not accepted." +
                    "\nGood Bye!");
                Environment.Exit(0);
            }
        }

    }
}
