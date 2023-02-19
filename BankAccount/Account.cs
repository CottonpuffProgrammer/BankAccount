using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a single customer's bank account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Creates an account with a owner name and
        /// a balance of 0
        /// </summary>
        /// <param name="accOwner"> The customer full name 
        /// that owns the account </param>
        public Account(string accOwner)
        {
            Owner = accOwner;
        }

        /// <summary>
        /// The account holder's full name (first and last)
        /// </summary>
        public string? Owner { get; set; }

        /// <summary>
        /// The amount of money currently in the account
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// Add a specified amount of money to the account
        /// </summary>
        /// <param name="amount"> The positive amount to deposit </param>
        public void Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Withdraws an amount from the balance
        /// </summary>
        /// <param name="amount"> The positive amount to be 
        /// taken from the balance </param>
        public void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
