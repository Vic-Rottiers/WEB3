using System;
using System.Collections.Generic;
using System.Text;

namespace _02Banking.Models.Domein
{
    class Transaction
    {
        #region Properties
        public decimal Amount { get; }
        public DateTime DateOfTrans { get; }
        public TransactionType TransactionType { get; set; }
        public bool isDeposit { get { return TransactionType == TransactionType.Deposit; } }
        #endregion

        #region Constructor
        public Transaction(decimal amount, TransactionType type)
        {
            Amount = amount;

        }
        #endregion
    }
}
