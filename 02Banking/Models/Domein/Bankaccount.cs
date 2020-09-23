using System;
using System.Collections;
using System.Collections.Generic;

namespace _02Banking.Models.Domein
{
    class Bankaccount
    {
        #region fields
        private readonly IList<Transaction> _transactions;

        #endregion
        #region properties
        public decimal Balance { get; private set; }
        public string AccountNumber { get; }
        public int NumberOfTransactions { get { return _transactions.Count; } }
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
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
        }
        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till)
        {
            IList<Transaction> transactions = new List<Transaction>();
            foreach (Transaction trans in _transactions)
            {
                if (trans.DateOfTrans >= from && trans.DateOfTrans <= till)
                {
                    transactions.Add(trans);
                }
            }
            return transactions; 
        }
        #endregion

    }
}
