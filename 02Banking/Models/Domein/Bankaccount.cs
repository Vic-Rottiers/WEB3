using System;

namespace _02Banking.Models.Domein
{
    class Bankaccount
    {
        #region properties
        public decimal Balance { get; private set; }
        public string AccountNumber { get; }
        #endregion

        #region constructor
        public Bankaccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }
        #endregion

        #region public methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion

    }
}
