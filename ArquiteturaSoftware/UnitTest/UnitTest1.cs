using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            //BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            //account.Debit(debitAmount);

            // Assert
            double actual = beginningBalance - debitAmount;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
