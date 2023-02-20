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
        private Account? acc;

        [TestInitialize()]
        public void CreateDefaultAccount()
        {
            acc = new Account("Steve");
        }

        // All 7 method tests are listed below, each with
        // 2 data rows for extra testing

        [TestMethod()]
        [DataRow(23.48)]
        [DataRow(1000000000.07)]
        public void Deposit_PositiveAmount_AddToBalance(double amount)
        {
            acc.Deposit(amount);

            Assert.AreEqual(amount, acc.Balance);
        }

        [TestMethod()]
        [DataRow(2.34)]
        [DataRow(0.01)]
        public void Deposit_PositiveAmount_DoesNewBalanceGetReturned(double amount)
        {
            // AAA - Arrange Act Assert
            // Arrange
            double depositAmount = amount;
            double expectedReturn = amount;

            // Act
            double returnValue = acc.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedReturn, returnValue);
        }

        [TestMethod()]
        [DataRow(-1)]
        [DataRow(0)]
        public void Deposit_ZeroOrLess_ThrowsArgumentException(double invalidDepositAmount)
        {
            // Arrange
            // Nothing to add

            // Assert => Act
            Assert.ThrowsException<ArgumentOutOfRangeException>
                (() => acc.Deposit(invalidDepositAmount));
        }

        [TestMethod()]
        [DataRow(0.02, 0.01)]
        [DataRow(5.67, 3)]
        public void Withdraw_PositiveAmount_DecreasesBalance(double deposit, double withdraw)
        {
            double expectedBalance = deposit - withdraw;

            acc.Deposit(deposit);
            acc.Withdraw(withdraw);

            double finalBalance = acc.Balance;

            Assert.AreEqual(expectedBalance, finalBalance);
        }

        [TestMethod()]
        [DataRow(200, 100)]
        [DataRow(35, 20)]
        public void Withdraw_PositiveAmount_ReturnsUpdatedBalance(double deposit, double withdraw)
        {
            acc.Deposit(deposit);
            double returnedBalance = acc.Withdraw(withdraw);

            double expectedBalance = acc.Balance;

            Assert.AreEqual(expectedBalance, returnedBalance);
        }

        [TestMethod()]
        [DataRow(-1000.01)]
        [DataRow(-1)]
        public void Withdraw_ZeroOrLess_ThrowsArgumentOutOfRangeException(double invalidAmount)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>
                (() => acc.Withdraw(invalidAmount));
        }

        [TestMethod()]
        [DataRow(30)]
        [DataRow(15)]
        public void Withdraw_MoreThanAvailableBalance_ThrowsArgumentException(double amount)
        {
            Assert.ThrowsException<ArgumentException>
                (() => acc.Withdraw(amount));
        }

        [TestMethod()]
        public void Owner_SetAsNull_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>
                (() => acc.Owner = null);
        }

        [TestMethod()]
        public void Owner_SetAsWhiteSpaceOrEmptyString_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>
                (() => acc.Owner = String.Empty);
            Assert.ThrowsException<ArgumentException>
                (() => acc.Owner = "    ");
        }

        [TestMethod()]
        [DataRow("Bean Dip")]
        [DataRow("TwentyCharacter Name")]
        public void Owner_SetAsUpTo20Characters_SetsSuccessfully(string ownerName)
        {
            acc.Owner = ownerName;

            Assert.AreEqual(ownerName, acc.Owner);
        }

        [TestMethod()]
        [DataRow("Diddle the 14th")]
        [DataRow("TwentyFourCharacter Name")]
        public void Owner_InvalidOwnerName_ThrowsArgumentException(string ownerName)
        {
            Assert.ThrowsException<ArgumentException>
                (() => acc.Owner = ownerName);
        }
    }
}