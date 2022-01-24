using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Withdraw withdraw = new Withdraw();
            withdraw.SetAccountBalance(withdraw.BankAccountId, 900, action: "Withdraw");
        }
    }
}
