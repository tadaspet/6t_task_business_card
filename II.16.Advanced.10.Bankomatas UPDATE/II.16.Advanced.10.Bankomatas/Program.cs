using System;
using System.Text;

namespace II._16.Advanced._10.Bankomatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardCheck cardCheck = new CardCheck();
            cardCheck.ShowAccounts();
            cardCheck.CheckGuide(cardCheck.GetGuid());

            LoginUser newUser = new LoginUser(cardCheck);
            newUser.PassCheck(newUser.ReadPINCode());

            Transaction withdraw = new Transaction(newUser);
            ViewTransactions records = new ViewTransactions(withdraw);

            var menu = new Menu();

            CardBalance userBalance = new CardBalance(newUser);
            userBalance.ShowBalanceFirstTime(); /// do NOT duplicate similar methods

            int selection = 0;
            do
            {
                selection = menu.ActionMenu();
                switch (selection)
                {
                    case 1:
                        {
                            bool repeat = false;
                            while (!repeat)
                            {
                                Console.Clear();
                                repeat = withdraw.ReduceBalance(withdraw.ReadWithDrawAmount());
                            }
                            menu.Return();
                            break;
                        }
                    case 2:
                        {
                            userBalance.ShowBalance();
                            menu.Return();
                            break;
                        }
                    case 3:
                        {
                            records.ShowTransactions();
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