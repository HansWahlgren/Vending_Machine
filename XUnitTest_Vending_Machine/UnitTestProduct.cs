using System;
using Xunit;
using Vending_Machine.Data;
using Vending_Machine.Models.DrinkClasses;
using Vending_Machine.Models.FoodClasses;
using Vending_Machine.Models.SnackClasses;

namespace XUnitTest_Vending_Machine
{
    public class UnitTestProduct
    {
        [Fact]
        public void CreateProductOk()
        {
            //Arrange
            int id1 = IdSequencer.NextProductId();
            int id2 = IdSequencer.NextProductId();
            int id3 = IdSequencer.NextProductId();

            //Act
            Cola cocaCola = new Cola(id1);
            Burger hamburger = new Burger(id2);
            Candy candybag = new Candy(id3);

            //Assert
            Assert.Equal(id1, cocaCola.ProductId);
            Assert.Equal(id2, hamburger.ProductId);
            Assert.Equal(id3, candybag.ProductId);
        }

        [Fact]
        public void ShowInfoOk()
        {
            //Arrange
            int id1 = IdSequencer.NextProductId();
            int id2 = IdSequencer.NextProductId();
            int id3 = IdSequencer.NextProductId();
            Juice product1 = new Juice(id1);
            Pizza product2 = new Pizza(id2);
            Chips product3 = new Chips(id3);
            string expectedInfo1 = $"Product Id: {id1}\nJuice\nPrice: 20kr\nSize: 25cl\nCalories: 150\nContains fruit meat";
            string expectedInfo2 = $"Product Id: {id2}\nPizza\nPrice: 35kr\nSize: 70g\nCalories: 450\nContains meat, Gluten";
            string expectedInfo3 = $"Product Id: {id3}\nChips bag\nPrice: 25kr\nSize: 100g\nCalories: 600\n";

            //Act
            string juiceInformation = product1.ShowInfo();
            string pizzaInformation = product2.ShowInfo();
            string chipsInformation = product3.ShowInfo();

            //Assert
            Assert.Equal(expectedInfo1, juiceInformation);
            Assert.Equal(expectedInfo2, pizzaInformation);
            Assert.Equal(expectedInfo3, chipsInformation);
        }

        [Fact]
        public void ShowConsumeOk()
        {
            //Arrange
            string expectedMessage1 = "You quickly drink up the cold refreshing bottle";
            string expectedMessage2 = "With great hunger you devour your meal fast";
            string expectedMessage3 = "You quietly eat up everything in your bag of snacks";
            Water product1 = new Water(IdSequencer.NextProductId());
            Sandwich product2 = new Sandwich(IdSequencer.NextProductId());
            Peanuts product3 = new Peanuts(IdSequencer.NextProductId());

            //Act
            string drinkConsume = product1.Consume();
            string eatFoodConsume = product2.Consume();
            string eatSnackConsume = product3.Consume();

            //Assert
            Assert.Equal(expectedMessage1, drinkConsume);
            Assert.Equal(expectedMessage2, eatFoodConsume);
            Assert.Equal(expectedMessage3, eatSnackConsume);
        }
    }
}

