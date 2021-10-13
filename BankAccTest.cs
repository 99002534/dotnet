using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConceptArchitect.Finance;

namespace BankAccountTest
{
    [TestClass]
    public class BankAccTest
    {
        [TestMethod]
        public void DepositCorrectTest()
        {
            double amt = 1000.0;
            int accountNum = 1234567;
            string name = "ganavi";
            string password = "password@123";
            double balance = 50000;
            double intrest = 9;
            var bankdetails = new BankAccount(accountNum, name, password, balance, intrest);
            var result = bankdetails.Deposit(amt);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DepositFailureTest()
        {
            double amt = 0.0;
            int accountNum = 1234567;
            string name = "ganavi";
            string password = "password@123";
            double balance = 50000;
            double intrest = 9;
            var bankdetails = new BankAccount(accountNum, name, password, balance, intrest);
            var result = bankdetails.Deposit(amt);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WithdrawSucessTest()
        {
            double amt = 1000.0;
            int accountNum = 1234567;
            string name = "ganavi";
            string password = "password@123";
            double balance = 50000;
            double intrest = 9;
            var bankdetails = new BankAccount(accountNum, name, password, balance, intrest);
            var result = bankdetails.Withdraw(amt, password);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void WithdrawFailureTest()
        {
            double amt = 60000;
            int accountNum = 1234567;
            string name = "ganavi";
            string password = "password@123";
            double balance = 50000;
            double intrest = 9;
            var bankdetails = new BankAccount(accountNum, name, password, balance, intrest);
            var result = bankdetails.Withdraw(amt, password);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void WithdrawWrongPasswordTest()
        {
            double amt = 1000.0;
            int accountNum = 1234567;
            string name = "ganavi";
            string password = "password@123";
            double balance = 50000;
            double intrest = 9;
            var bankdetails = new BankAccount(accountNum, name, password, balance, intrest);
            var result = bankdetails.Withdraw(amt, "WrongPassword");
            Assert.IsFalse(result);
        }
    }
}
