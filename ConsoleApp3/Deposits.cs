using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Deposit:BankAccount
    {
        //Properties
        public decimal DepositAmount
        {
            get;set;
        }

        public String DepositedBy
        {
            get; set;
        }

        public DateTime DepositedOn
        {
            get; set;
        }

        public bool DoDeposit()
        {
            return true;
        }
        
    }

    public class Withdraw:BankAccount
    {
        //Properties
        public decimal WithdrawAmount
        {
            get; set;
        }

        public String WithdrawnBy
        {
            get; set;
        }

        public DateTime WithdrawnOn
        {
            get; set;
        }

        public bool DoWithdraw()
        {
            return true;
        }
    }

    public class BankAccount
    {
        //Properties
        public decimal Amount
        {
            get; set;
        }        

        public String BranchId
        {
            get; set;
        }

        public string BankAccountId { get; set; }
        public string BankAccountName { get; set; }
       
        public double GetAccountBalance(string bankAccountId)
        {
            return 100;
        }

        public virtual double SetAccountBalance(string bankAccountId, double amount, string action = "Deposit")
        {
            double bankBalance = 10000;
            if (action == "Deposit")
                bankBalance += amount;
            else if (action == "Withdraw")
                bankBalance -= amount;
            return bankBalance;
        }

    }

    public class BankAdvancedOperations : BankAccount
    {
        public override double SetAccountBalance(string bankAccountId, double amount, string action = "Deposit")
        {
            //Do some advanced actions
            return 100;
        }
    }
}
