using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task222
{
    internal class CheckingAccount : BankAccount
    {
        private double OverDraftLimit { get; set; } = 100;
        public CheckingAccount(double overDraftLimit, double balance) : base(balance)
        {
            OverDraftLimit = overDraftLimit;
        }
        public void WithDraw(double amount)
        {
            if(CurrentBalance() < amount)
            {
                Console.WriteLine($"Balance is too low to withdraw {amount}");

            }
            else if (OverDraftLimit < amount) 
            {
                Console.WriteLine("Withdraw amount reached.");
            }
            else
            {
                double newBal = WithDrawBalance(amount);
                Console.WriteLine($"Current balance {newBal}");
            }
        }
    }
}
