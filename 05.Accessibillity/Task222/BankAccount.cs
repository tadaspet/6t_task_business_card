using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task222
{
    internal class BankAccount
    {
        private double Balance { get; set; }
        public BankAccount (double balance)
        {
            Balance = balance;
        }
        protected double CurrentBalance ()
        {
            return Balance;
        }
        protected double WithDrawBalance(double amount)
        {
            Balance = Balance - amount;
            return Balance;
        }
        public void GetBalance()
        {
            Console.WriteLine(CurrentBalance());
        }
    }
}
