using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._16.Advanced._10.Bankomatas
{
    internal class ViewTransactions : Transaction
    {
        public List<TransactionData> Log { get; set; } = new List<TransactionData>();

        public ViewTransactions(Transaction action) : base(action)
        {
            Log = action.TransactionData;
        }
        public List<TransactionData> FindLastTransactions()
        {
            List<TransactionData> listFiltered = Log.Where(t => t.Time.Date == DateTime.Today.Date).
                OrderByDescending(t => t.Time).ToList();
            return listFiltered;
        }
        public void ShowTransactions()
        {
            List<TransactionData> listF = FindLastTransactions();
            int transCount;
            double total = 0;
            if (listF.Count == 0)
            {
                Console.WriteLine("There is no transaction records yet.");
            }
            else if (listF.Count >= 5)
            {
                transCount = 5;
                Console.WriteLine("The last 5 transactions.");
                Console.WriteLine("No" + "Time".PadLeft(24) + "Amount".PadLeft(12));
                for (int i = 0; i < transCount; i++)
                {
                    Console.WriteLine((i + 1) + $"{listF[i].Time}".PadLeft(25) + $"{listF[i].Amount}".PadLeft(12));
                    total += listF[i].Amount;
                }
                Console.WriteLine($"\n" +
                    $"Total: {total}".PadLeft(38));
            }
            else
            {
                transCount = listF.Count;
                Console.WriteLine("The last 5 transactions.");
                Console.WriteLine("No" + "Time".PadLeft(24) + "Amount".PadLeft(12));
                for (int i = 0; i < transCount; i++)
                {
                    Console.WriteLine((i + 1) + $"{listF[i].Time}".PadLeft(25) + $"{listF[i].Amount}".PadLeft(12));
                    total += listF[i].Amount;
                }
                Console.WriteLine($"\n" +
                    $"Total: {total}".PadLeft(38));
            }

        }
    }
}
