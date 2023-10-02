namespace Task222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(123);
            bankAccount.GetBalance();
            SavingsAccount savingsAccount = new SavingsAccount(300,20);

            Console.WriteLine(savingsAccount.CalculateInterest());

            CheckingAccount checking = new CheckingAccount(500,100);
            checking.WithDraw(101);
        }
    }
}