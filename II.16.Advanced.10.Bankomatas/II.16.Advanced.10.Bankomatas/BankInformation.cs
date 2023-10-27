using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace II._16.Advanced._10.Bankomatas
{
    internal class BankInformation : Account
    {
        public List<Account> Accounts { get; set; } 

        public static void GenerateBankInfo()
        {
            var random = new Random();
            using (var writer = new StreamWriter("BankInformation.txt"))
            {
                int accountNo = 25;
                for (int i = 0; i < accountNo; i++)
                {
                    writer.Write(Guid.NewGuid() + " " + random.Next(200, 10000) +
                        " " + random.Next(1000, 9999) + "\n");
                }
            }
        }
        public List<Account> BankInfoList()
        {
            GenerateBankInfo();
            var accounts = new List<Account>();
            string line = "";
            using (var reader = new StreamReader("BankInformation.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    var separate = line.Split(' ');
                    if (separate.Length == 3)
                    {
                        var account = new Account
                        {
                            GuidNo = separate[0],
                            Balance = double.Parse(separate[1]),
                            PinNo = int.Parse(separate[2]),
                        };
                        accounts.Add(account);
                    }
                }
            }
            Accounts = accounts;
            return accounts;
        }
    }
}
