using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Object_Orentiad_Programing
{
    public class Bank
    {
        public Account Account1 { get; set; }
        public DateTime DateTime { get; set; }
        public string BankName { get; set; }
        public Bank(string bankName)
        {
            BankName = "Revolut";
        }
    }
}
