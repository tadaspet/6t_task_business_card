using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._16.Advanced._10.Bankomatas
{
    internal class Transaction : LoginUser
    {
        //internal double ActiveBalance { get; set; } 
        internal int TransCount { get; set; }
        internal double DeductAmount { get; set; }
        internal double MaxAmount { get; } = 1000;
        internal Account UserInfo { get; set; }
        internal List<TransactionData> TransactionData { get; set; } = new List<TransactionData>();
        public Transaction(LoginUser user) : base(user)
        {
            UserInfo = user.Account;
        }
        public void TransLeft()
        {
            List<TransactionData> transToday = TransactionData.Where(t => t.Time.Date == DateTime.Today.Date).ToList();

            double deducted = 0;
            foreach (TransactionData data in transToday)
            {

                deducted += data.Amount;
            }
            DeductAmount = -1 * deducted;
            TransCount = transToday.Count;
        }
        public void ReduceBalance()
        {
            Console.WriteLine("Please enter amount to withdraw:");
            string inPut = Console.ReadLine();
            bool cashTrue = double.TryParse(inPut, out double amount);
            if (cashTrue && amount <= MaxAmount && (DeductAmount + amount) <= MaxAmount && TransCount <= 9)
            {
                Console.WriteLine("Transfer was succesful.");
                UserInfo.Balance -= amount;
                TransactionData.Add(
                    new TransactionData
                    {
                        Time = DateTime.Now,
                        Amount = -1 * amount,
                    }
                    );
                TransLeft();
            }
            else if (cashTrue && amount > MaxAmount)
            {
                Console.WriteLine($"Your withdraw amount is above {MaxAmount} limit.");
            }
            else if (cashTrue && (DeductAmount + amount) > MaxAmount)
            {
                Console.WriteLine($"The withdraw maximum amount left for today: {MaxAmount - DeductAmount} Euros.");
            }
            else if (cashTrue && TransCount > 9)
            {
                Console.WriteLine("The number of withdrawal per day has been exceeded.");
            }
            else
            {
                Console.WriteLine("You did not enter money amount.");
            }

        }

    }
}
