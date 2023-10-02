using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task222
{
    internal class SavingsAccount : BankAccount
    {
        private double InterestRrate { get; set; }
        public SavingsAccount(double balance, double interest) : base(balance)
        {
            InterestRrate = interest;
        }

        public double CalculateInterest()
        {
            double increase = InterestRrate * CurrentBalance()/100 + CurrentBalance();
            return increase;
        }
    }
}
