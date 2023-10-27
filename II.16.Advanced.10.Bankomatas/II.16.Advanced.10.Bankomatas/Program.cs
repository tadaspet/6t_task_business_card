using System;

namespace II._16.Advanced._10.Bankomatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankInformation createBank = new BankInformation();
            createBank.BankInfoList();
            CardCheck cardCheck = new CardCheck(createBank);
            cardCheck.ShowAccounts();
            cardCheck.CheckGuide(cardCheck.GetGuid());
            
            LoginUser newUser = new LoginUser(cardCheck);
            newUser.PassCheck();

            CardBalance userBalance = new CardBalance(newUser);
            userBalance.ShowBalance();





            Transaction withDraw = new Transaction(newUser);
            withDraw.TakeMoney();
            withDraw.TakeMoney();
            withDraw.TakeMoney();

            ViewTransactions view = new ViewTransactions(withDraw);
            view.ShowTransactions();
        }
    }
}