using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._16.Advanced._10.Bankomatas
{
    internal class Transaction : LoginUser
    {
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
        public bool ReduceBalance()
        {
            Console.WriteLine("Possible bills: 200, 100, 50, 20, 10" +
                "\nPlease enter amount to withdraw:");
            string inPut = Console.ReadLine();
            bool cashTrue = int.TryParse(inPut, out int amount);
            string billAnswer;
            bool billCheck = BillCheck(amount, out billAnswer);
            if (cashTrue && amount > 0 && billCheck)
            {
                if (amount <= MaxAmount && (DeductAmount + amount) <= MaxAmount && TransCount <= 9)
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
                    Console.WriteLine($"\nPlease take your money:\n{billAnswer}");
                }
                else if (amount > MaxAmount)
                {
                    Console.WriteLine($"Your withdraw amount is above {MaxAmount} limit.");
                }
                else if ((DeductAmount + amount) > MaxAmount)
                {
                    Console.WriteLine($"The withdraw maximum amount left for today: {MaxAmount - DeductAmount} Euros.");
                }
                else if (TransCount > 9)
                {
                    Console.WriteLine("The number of withdrawal per day has been exceeded.");
                }
                return true;
            }
            else if (!cashTrue)
            {
                Console.WriteLine("Only numbers are accepted.");
            }
            else if (amount < 0)
            {
                Console.WriteLine("Impossible to withdraw negative amount.");
            }
            else if ( amount <20 )
            {
                Console.WriteLine("The Amount is too small to withdraw.");
            }

            else if (!billCheck)
            {
                Console.WriteLine("The amount does not split in to bills.");
            }
            return false;
        }
        public bool BillCheck(int amount, out string moneyBills)
        {
            Dictionary<int,int> bills = new Dictionary<int, int>() {
                {200,0 }, {100,0}, {50,0}, {20,0}, {10,0 }
            };
            StringBuilder newBills = new StringBuilder();
            int tempSum = amount;
            if(amount % 10 ==0)
            {
                foreach (var bill in bills.Keys.ToList())
                {
                    if (tempSum / bill > 0)
                    {
                        int count = tempSum / bill;
                        tempSum -= bill * count;
                        newBills.Append(count + " bills of " + bill + " Eur.\n");
                    }
                }
                moneyBills = newBills.ToString();
                return true;
            }
            else 
            {
                moneyBills = "";
                return false; 
            }
        }
    }
}
