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

            Transaction withdraw = new Transaction(newUser);
            ViewTransactions records = new ViewTransactions(withdraw);
            
            var menu = new Menu();
            int selection = 0;
            do
            {
                selection = menu.ActionMenu();
                switch (selection)
                {
                    case 1:
                        {
                            userBalance.ShowBalance();
                            menu.Return();
                            break;
                        }
                    case 2:
                        {
                            records.ShowTransactions();
                            menu.Return();
                            break;
                        }
                    case 3:
                        {
                            withdraw.ReduceBalance();
                            menu.Return();
                            break;
                        }
                    case 4:
                        {
                            menu.Quit();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (selection > 0 && selection < 5);

        }
    }
}