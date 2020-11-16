using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {   // create bank account instance
            var account = new BankAccount("Noel", 1000);
            Console.WriteLine($"Account { account.Number } was created for { account.Owner } with ${ account.Balance } initial balance.");
            // call withdrawal method
            account.MakeWithdrawal(500, DateTime.Now, "Rent Payment");
            Console.WriteLine(account.Balance);
            // call deposit method
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance); 
            // call account history method
            Console.WriteLine(account.GetAccountHistory());

            // Test that the initial balances must be positive.
            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
    
            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
