using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace II._16.Advanced._10.Bankomatas
{
    public class BankInformation : Account
    {
        public List<Account> Accounts { get; set; } 

        // CREATION TXT FILE EACH TIME
        //public static void GenerateBankInfo()
        //{
        //    var random = new Random();
        //    using (var writer = new StreamWriter("BankInformation.txt"))
        //    {
        //        int accountNo = 15;
        //        for (int i = 0; i < accountNo; i++)
        //        {
        //            writer.Write(Guid.NewGuid() + " " + random.Next(200, 5000) +
        //                " " + random.Next(1000, 9999) + "\n");
        //        }
        //    }
        //}
        public List<Account> BankInfoList()
        {
            using var accountsDB = new AccountDataBase();
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
                            Id = separate[0],
                            Balance = double.Parse(separate[1]),
                            PinNo = int.Parse(separate[2]),
                        };
                        accounts.Add(account);
                        //accountsToDataB.Accounts.Add(account);
                        //accountsToDataB.SaveChanges();
                    }
                }
            }

            Accounts = accounts;
            return accounts;
        }
    }
}
