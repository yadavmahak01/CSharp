using System;
 
namespace OOPs_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Mahak", 20000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(5000, DateTime.Now, "Shopping");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(1000, DateTime.Now, "Gift");
            Console.WriteLine(account.Balance);

            // Test for a negative balance
            try
            {
                account.MakeWithdrawal(750000, DateTime.Now, "Not allowed");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception ");
                
            }

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}