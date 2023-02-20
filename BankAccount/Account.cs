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
        /// Add a specified amount of money to the account,
        /// returns new balance
        /// </summary>
        /// <param name="amount"> The positive amount to deposit </param>
        /// <returns> The new balance after the deposit </returns>
        public double Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Deposit amount must be a non-zero positive number!");
            }

            Balance = Balance + amount;
            return Balance;
        }

        /// <summary>
        /// Withdraws an amount from the balance and
        /// returns the updated balance
        /// </summary>
        /// <param name="amount"> The positive amount to be 
        /// taken from the balance </param>
        public double Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentException("Withdraw amount cannot be greater than current balance!");
            }

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Withdraw amount must be a non-zero positive number!");
            }

            Balance = Balance - amount;
            return Balance;
        }
    }
}
