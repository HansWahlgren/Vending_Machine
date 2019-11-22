using System;
using System.Linq;
using Xunit;
using Vending_Machine.Models;

namespace XUnitTest_Vending_Machine
{
    public class UnittestVendingMachine
    {
        [Fact]
        public void AddCurrencyandGetBalanceOk()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            int firstdenomination = 1000;
            int seconddenomination = 500;
            int thirddenomination = 200;
            int forthdenomination = 100;
            int fifthdenomination = 50;
            int sixthdenomination = 20;
            
            int expectedAmount = 2270;

            //Act
            vendingMachine.AddCurrency(firstdenomination);
            vendingMachine.AddCurrency(seconddenomination);
            vendingMachine.AddCurrency(thirddenomination);
            vendingMachine.AddCurrency(thirddenomination);
            vendingMachine.AddCurrency(thirddenomination);
            vendingMachine.AddCurrency(forthdenomination);
            vendingMachine.AddCurrency(fifthdenomination);
            vendingMachine.AddCurrency(sixthdenomination);
            int moneyPoolAmount = vendingMachine.GetBalance();

            //Assert
            Assert.Equal(expectedAmount, moneyPoolAmount);
        }

        [Fact]
        public void RequestProductOk()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.AddCurrency(1000);
            string expectedName1 = "Sandwich";
            string expectedName2 = "Chips bag";
            string expectedInfo = "Product Nr: 2\nJuice\nPrice: 20kr\nSize: 25cl\nCalories: 150\nContains fruit meat";
            int expectedMoneyLeft = 925;

            //Act
            Product product1 = vendingMachine.RequestProduct(6);
            Product product2 = vendingMachine.RequestProduct(8);
            Product product3 = vendingMachine.RequestProduct(2);
            string productInformation = product3.ShowInfo();
            int moneyLeft = vendingMachine.GetBalance();

            //Assert
            Assert.Equal(expectedName1, product1.Name);
            Assert.Equal(expectedName2, product2.Name);
            Assert.Equal(expectedInfo, productInformation);
            Assert.Equal(expectedMoneyLeft, moneyLeft);
        }

        [Fact]
        public void RequestProductCannotAffordException()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            string expectedException = "You can´t afford this product";
            string ExceptionMessage = "";
            vendingMachine.EndSession();

            //Act
            try
            {
                Product product = vendingMachine.RequestProduct(6);
            }
            catch (ArgumentException exception)
            {
                ExceptionMessage = exception.Message;
            }

            //Assert
            Assert.Equal(expectedException, ExceptionMessage);
        }

        [Fact]
        public void RequestProductInvalidProductException()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.AddCurrency(1000);
            string expectedException = "The product you have selected does not exist";
            string ExceptionMessage = "";

            //Act
            try
            {
                Product product = vendingMachine.RequestProduct(16);
            }
            catch (IndexOutOfRangeException exception)
            {
                ExceptionMessage = exception.Message;
            }

            //Assert
            Assert.Equal(expectedException, ExceptionMessage);
        }

        [Fact]
        public void EndSessionOk()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            int firstdenomination = 500;
            int seconddenomination = 200;
            int thirddenomination = 100;
            int forthdenomination = 50;
            int fifthdenomination = 5;
            int sixthdenomination = 2;
            int[] expectedChangeToCustomer = { 1000, 100, 50, 10, 5, 1 };

            vendingMachine.AddCurrency(firstdenomination);
            vendingMachine.AddCurrency(seconddenomination);
            vendingMachine.AddCurrency(seconddenomination);
            vendingMachine.AddCurrency(thirddenomination);
            vendingMachine.AddCurrency(thirddenomination);
            vendingMachine.AddCurrency(forthdenomination);
            vendingMachine.AddCurrency(fifthdenomination);
            vendingMachine.AddCurrency(fifthdenomination);
            vendingMachine.AddCurrency(sixthdenomination);
            vendingMachine.AddCurrency(sixthdenomination);
            vendingMachine.AddCurrency(sixthdenomination);

            int moneyPoolAmount = vendingMachine.GetBalance();

            //Act
            int[] changeToCustomer = vendingMachine.EndSession();
            int newMoneyPoolAmount = vendingMachine.GetBalance();

            //Assert
            Assert.Equal(moneyPoolAmount, changeToCustomer.Sum());
            Assert.Equal(0, newMoneyPoolAmount);
            Assert.Equal(expectedChangeToCustomer, changeToCustomer);
        }

        [Fact]
        public void GetDescriptionOk()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            string expectedInfo1 = "Product Nr: 2\nJuice\nPrice: 20kr\nSize: 25cl\nCalories: 150\nContains fruit meat";
            string expectedInfo2 = "Product Nr: 5\nPizza\nPrice: 35kr\nSize: 70g\nCalories: 450\nContains meat, Gluten";
            string expectedInfo3 = "Product Nr: 8\nChips bag\nPrice: 25kr\nSize: 100g\nCalories: 600\n";

            //Act
            string productInformation1 = vendingMachine.GetDescription(2);
            string productInformation2 = vendingMachine.GetDescription(5);
            string productInformation3 = vendingMachine.GetDescription(8);

            //Assert
            Assert.Equal(expectedInfo1, productInformation1);
            Assert.Equal(expectedInfo2, productInformation2);
            Assert.Equal(expectedInfo3, productInformation3);
        }

        [Fact]
        public void GetDescriptionExceptionError()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            string expectedException = "The product you have selected does not exist";
            string ExceptionMessage = "";

            //Act
            try
            {
                string productInformation = vendingMachine.GetDescription(16);
            }
            catch(IndexOutOfRangeException exception)
            {
                ExceptionMessage = exception.Message;
            }

            //Assert
            Assert.Equal(expectedException, ExceptionMessage);
        }

        [Fact]
        public void GetProductsOk()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
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
            string[] productsName = vendingMachine.GetProducts();

            //Assert
            Assert.Equal(expectedproductsName, productsName);
        }
    }
}
