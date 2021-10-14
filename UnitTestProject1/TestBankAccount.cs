using System;
using ConceptArchitect.Finance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TestBankAccount
    {
        [TestMethod]
            public void DepositSuccessfulTest()
            {
                int accNumber = 1;
                string name = "Anjali";
                string psswd = "ABC";
                double balance = 5000;
                double interest = 10;
                double amount = 5000.0;
                var bankAccount = new BankAccount(accNumber, name, psswd, balance, interest);
                var result = bankAccount.Deposit(amount);
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void DepositFailedTest()
            {
                int accNumber = 1;
                string name = "Anjali";
                string psswd = "ABC";
                double balance = 5000;
                double interest = 10;
                double amount = 0;
                var bankAccount = new BankAccount(accNumber, name, psswd, balance, interest);
                var result = bankAccount.Deposit(amount);
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void WithdrawFailedTest()
            {
                int accNumber = 1;
                string name = "Anjali";
                string psswd = "ABC";
                double balance = 5000;
                double interest = 10;
                double amount = 0;
                var bankAccount = new BankAccount(accNumber, name, psswd, balance, interest);
                var result = bankAccount.Withdraw(amount, psswd);
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void SuccessfulWithdrawTest()
            {
                int accNumber = 1;
                string name = "Anjali";
                string psswd = "ABC";
                double balance = 5000;
                double interest = 10;
                double amount = 1000;
                var bankAccount = new BankAccount(accNumber, name, psswd, balance, interest);
                var result = bankAccount.Withdraw(amount, psswd);
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void WrongPasswordTest()
            {
                 int accNumber = 1;
                 string name = "Anjali";
                 string psswd = "ABC";
                 double balance = 5000;
                 double interest = 10;
                 double amount = 1000;
                 var bankAccount = new BankAccount(accNumber, name, psswd, balance, interest);
                 var result = bankAccount.Withdraw(amount, "WrongPassword");
                  Assert.IsFalse(result);
            }
        }
}
