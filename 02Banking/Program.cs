using _02Banking.Models.Domein;
using System;

namespace _02Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankaccount account = new Bankaccount("123-4567890-12");
            account.Deposit(200M);
            Console.WriteLine(WriteBalance(account));
            account.Withdraw(69M);
            Console.WriteLine(WriteBalance(account));

        }
        private static string WriteBalance(Bankaccount account)
        {
            return $"Balance is {account.Balance}";
        }
    }
}
