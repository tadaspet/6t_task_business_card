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
        public List<Account> CardHolder { get; set; }
        public Account UserInfo { get; set; } 

        public CardCheck(BankInformation bankinformation)
        {
            CardHolder = bankinformation.Accounts;
        }

        public void ShowAccounts()
        {
            Console.WriteLine("Verified card list:");
            CardHolder.ForEach(x => Console.WriteLine(x.GuidNo));
        }
        public string GetGuid()
        {
            Console.WriteLine("\nPlease enter your Card Number:");
            return Console.ReadLine();
        }
        public void CheckGuide(string userGuid)
        {
            bool check = CardHolder.Any(x => x.GuidNo == userGuid);
            if (check)
            {
                Console.Clear();
                Console.WriteLine("Your card was accepted.");
                var account = CardHolder.FirstOrDefault(x => x.GuidNo == userGuid);
                UserInfo = account;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Your card was not accepted.");
                Environment.Exit(0);
            }
        }

    }
}
