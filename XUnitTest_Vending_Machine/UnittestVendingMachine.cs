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
            int forthdenomination = 100;
            int fifthdenomination = 50;
            int sixthdenomination = 20;
            
            int expectedAmount = 2270;

            //Act
            VendingMachine.AddCurrency(firstdenomination);
            VendingMachine.AddCurrency(seconddenomination);
            VendingMachine.AddCurrency(thirddenomination);
            VendingMachine.AddCurrency(thirddenomination);
            VendingMachine.AddCurrency(thirddenomination);
            VendingMachine.AddCurrency(forthdenomination);
            VendingMachine.AddCurrency(fifthdenomination);
            VendingMachine.AddCurrency(sixthdenomination);
            int moneyPoolAmount = VendingMachine.GetBalance();

            //Assert
            Assert.Equal(expectedAmount, moneyPoolAmount);
        }

        [Fact]
        public void RequestProductOk()
        {
            //Arrange
            string expectedName1 = "Sandwich";
            string expectedName2 = "Chips bag";
            string expectedInfo = "Product Nr: 2\nJuice\nPrice: 20kr\nSize: 25cl\nCalories: 150\nContains fruit meat";

            //Act
            Product product1 = VendingMachine.RequestProduct(6);
            Product product2 = VendingMachine.RequestProduct(8);
            Product product3 = VendingMachine.RequestProduct(2);
            string productInformation = product3.ShowInfo();

            //Assert
            Assert.Equal(expectedName1, product1.Name);
            Assert.Equal(expectedName2, product2.Name);
            Assert.Equal(expectedInfo, productInformation);
        }

        [Fact]
        public void EndSessionOk()
        {
            //Arrange
            int firstdenomination = 500;
            int seconddenomination = 200;
            int thirddenomination = 100;
            int forthdenomination = 50;
            int fifthdenomination = 5;
            int sixthdenomination = 2;
            int[] expectedChangeToCustomer = { 1000, 100, 50, 10, 5, 1 };

            VendingMachine.AddCurrency(firstdenomination);
            VendingMachine.AddCurrency(seconddenomination);
            VendingMachine.AddCurrency(seconddenomination);
            VendingMachine.AddCurrency(thirddenomination);
            VendingMachine.AddCurrency(thirddenomination);
            VendingMachine.AddCurrency(forthdenomination);
            VendingMachine.AddCurrency(fifthdenomination);
            VendingMachine.AddCurrency(fifthdenomination);
            VendingMachine.AddCurrency(sixthdenomination);
            VendingMachine.AddCurrency(sixthdenomination);
            VendingMachine.AddCurrency(sixthdenomination);

            int moneyPoolAmount = VendingMachine.GetBalance();

            //Act
            int[] changeToCustomer = VendingMachine.EndSession();
            int newMoneyPoolAmount = VendingMachine.GetBalance();

            //Assert
            Assert.Equal(moneyPoolAmount, changeToCustomer.Sum());
            Assert.Equal(0, newMoneyPoolAmount);
            Assert.Equal(expectedChangeToCustomer, changeToCustomer);
        }

        [Fact]
        public void GetDescriptionOk()
        {
            //Arrange
            string expectedInfo1 = "Product Nr: 2\nJuice\nPrice: 20kr\nSize: 25cl\nCalories: 150\nContains fruit meat";
            string expectedInfo2 = "Product Nr: 5\nPizza\nPrice: 35kr\nSize: 70g\nCalories: 450\nContains meat, Gluten";
            string expectedInfo3 = "Product Nr: 8\nChips bag\nPrice: 25kr\nSize: 100g\nCalories: 600\n";

            //Act
            string productInformation1 = VendingMachine.GetDescription(2);
            string productInformation2 = VendingMachine.GetDescription(5);
            string productInformation3 = VendingMachine.GetDescription(8);

            //Assert
            Assert.Equal(expectedInfo1, productInformation1);
            Assert.Equal(expectedInfo2, productInformation2);
            Assert.Equal(expectedInfo3, productInformation3);
        }

        [Fact]
        public void GetProductsOk()
        {
            //Arrange
            string[] expectedproductsName = 
            {
                "Number: 1 Coca Cola\n",
                "Number: 2 Juice\n",
                "Number: 3 Water\n",
                "Number: 4 Hamburger\n",
                "Number: 5 Pizza\n",
                "Number: 6 Sandwich\n",
                "Number: 7 Mixed Candy bag\n",
                "Number: 8 Chips bag\n",
                "Number: 9 Peanuts bag\n",
            };

            //Act
            string[] productsName = VendingMachine.GetProducts();

            //Assert
            Assert.Equal(expectedproductsName, productsName);
        }
    }
}
