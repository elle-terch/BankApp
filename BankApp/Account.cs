using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{

    enum TypeOfAccount
    {
        Checking,
        Savings,
        CD,
        Loan
    }


    /// <summary>
    /// This is about a bank account
    /// </summary>
    class Account
    {
        #region static
        private static int lastAccountNumber = 0;
        #endregion

        #region Properties
        public int AccountNumber { get; private set; }
        public string EmailAddress { get; set; }
        public string AccountName { get; set; }
        public TypeOfAccount AccountType { get; set; }
        public decimal Balance { get; private set; }
        #endregion

        #region Constructor (name should be the same as the class name)
        public Account()
        {
            AccountNumber = ++lastAccountNumber;

        }

        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        /// <summary>
        /// Withdraw money into your account
        /// </summary>
        /// <param name="amount">Amount to be withdrawn</param>
        public void Withdrawal(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
