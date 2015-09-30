using Inventory.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace InventoryUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        // unit test code
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            InventoriesController account = new InventoriesController("Mr. Bryan Walton", beginningBalance);
            
            // act
            account.Debit(debitAmount);

            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
