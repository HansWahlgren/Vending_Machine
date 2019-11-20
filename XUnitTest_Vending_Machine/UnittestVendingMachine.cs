using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using Vending_Machine.Models;
using Vending_Machine.Data;
using Vending_Machine.Models.DrinkClasses;
using Vending_Machine.Models.FoodClasses;
using Vending_Machine.Models.SnackClasses;

namespace XUnitTest_Vending_Machine
{
    public class UnittestVendingMachine
    {
        [Fact]
        public void AddCurrencyandGetBalanceOk()
        {
            //Arrange
            int firstdenomination = 1000;
            int seconddenomination = 500;
            int thirddenomination = 200;
            int forthdenomination = 200;
            int fifthdenomination = 200;
            int sixthdenomination = 100;
            int seventhdenomination = 50;
            int eighthdenomination = 20;
            int expectedAmount = 2270;

            //Act
            VendingMachine.AddCurrency(firstdenomination);
            VendingMachine.AddCurrency(seconddenomination);
            VendingMachine.AddCurrency(thirddenomination);
            VendingMachine.AddCurrency(forthdenomination);
            VendingMachine.AddCurrency(fifthdenomination);
            VendingMachine.AddCurrency(sixthdenomination);
            VendingMachine.AddCurrency(seventhdenomination);
            VendingMachine.AddCurrency(eighthdenomination);
            int moneyPoolAmount = VendingMachine.GetBalance();

            //Assert
            Assert.Equal(expectedAmount, moneyPoolAmount);
        }
    }
}
