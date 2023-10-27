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
            List<TransactionData> listFiltered = Log.Where(t => t.Time.Date == DateTime.Today.Date).ToList();
            return listFiltered;
        }
        public void ShowTransactions()
        {
            List<TransactionData> listF = FindLastTransactions();
            int transCount;
            if (listF.Count >= 5)
            {
                transCount = 5;
            }
            else
            {
                transCount = listF.Count;
            }
            Console.WriteLine("No" + "Amount".PadLeft(15) + "Time".PadLeft(30));
            for (int i = 0; i < transCount; i++)
            {
                Console.WriteLine((i + 1) + $"{listF[i].Amount}".PadLeft(16) + $"{listF[i].Time}".PadLeft(30));
            }
        }
    }
}
