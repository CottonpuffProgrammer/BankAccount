using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void Deposit_PositiveAmount_AddToBalance()
        {
            Account acc = new Account("Steve");
            acc.Deposit(100);

            Assert.AreEqual(100, acc.Balance);
        }

        [TestMethod()]
        public void Deposit_PositiveAmount_DoesNewBalanceGetReturned()
        {
            // AAA - Arrange Act Assert
            // Arrange
            Account acc = new Account("Steve");
            double depositAmount = 100;
            double expectedReturn = 100;

            // Act
            double returnValue = acc.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedReturn, returnValue);
        }
    }
}