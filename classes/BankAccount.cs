using System;
using System.Collections.Generic;

namespace classes
{
  public class BankAccount
  {
    // variables we are using in class 
    // create list, by creating new instance of transactions
    private List<Transaction> allTransactions = new List<Transaction>();
    private static int accountNumberSeed = 1234567890;
    public string Number { get; }
    public string Owner { get; set; }
    // get here becomes a function to update balance on each call 
    public decimal Balance 
    { 
      get 
      {
        decimal balance = 0;
        foreach(var num in allTransactions)
        {
          balance += num.Amount;
        }
        return balance;
      }
    }
    // constructor - same name as class
    public BankAccount(string name, decimal initialBalance) 
    {
      // properties of constructor
      this.Number = accountNumberSeed.ToString();
      accountNumberSeed++;

      this.Owner = name;
      // call method for initial deposit when creating new bank account
      MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
    }
    public void MakeDeposit(decimal amount, DateTime date, string note) 
    {
      // make sure deposit isn't negative, throw exception
      if(amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
      }
      // create new instance of transaction
      var deposit = new Transaction(amount, date, note);
      // add to transactions list
      allTransactions.Add(deposit);

    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    { 
      // check if withdrawal is negative
      if (amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
      }
      // check if withdrawal makes balance negative
      if (Balance - amount < 0)
      {
        throw new InvalidOperationException("Not sufficient funds for this withdrawal");
      }
      // create new instance of transaction, and add negative amount
      var withdrawal = new Transaction(-amount, date, note);
      allTransactions.Add(withdrawal);
    }
    
    public string GetAccountHistory()
    { // string builder formats a string one line per transaction
      var report = new System.Text.StringBuilder();

      decimal balance = 0;
      // inserts tab between characters HEADER
      report.AppendLine("Date\t\tAmount\tBalance\tNote");
      // loop through transactions list
      foreach(var num in allTransactions)
      {
        // increment count
        balance += num.Amount;
        // add line to report ROWS
        report.AppendLine($"{num.Date.ToShortDateString()}\t{num.Amount}\t{balance}\t{num.Notes}");
      }
      // return report, convert to string
      return report.ToString();
    }
   
  }
}