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
            Assert.Equal("Coca Cola", cocaCola.Name);
            Assert.Equal("Hamburger", hamburger.Name);
            Assert.Equal("Mixed Candy bag", candybag.Name);
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
            string expectedInfo1 = $"\tProduct Nr: {id1}\n\tJuice\n\tPrice: 20kr\n\tSize: 25cl\n\tCalories: 150\n\tContains fruit meat";
            string expectedInfo2 = $"\tProduct Nr: {id2}\n\tPizza\n\tPrice: 35kr\n\tSize: 70g\n\tCalories: 450\n\tContains meat, Gluten";
            string expectedInfo3 = $"\tProduct Nr: {id3}\n\tChips bag\n\tPrice: 25kr\n\tSize: 100g\n\tCalories: 600\n\t";

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

