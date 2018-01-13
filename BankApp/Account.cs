using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{

    public enum TypeOfAccount
    {
        Checking,
        Savings,
        CD,
        Loan
    }


    /// <summary>
    /// This is about a bank account
    /// </summary>
    public class Account
    {
        #region Properties
        [Key]
        public int AccountNumber { get; private set; }
        [StringLength(100, ErrorMessage = "Email address should be of 100 characters or less.")]
        [Required]
        public string EmailAddress { get; set; }
        public string AccountName { get; set; }
        [Required]
        public TypeOfAccount AccountType { get; set; }
        public decimal Balance { get; private set; }
        #endregion

        #region Constructor (name should be the same as the class name)
        public Account()
        {
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
