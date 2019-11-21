using Xunit;
using Vending_Machine.Models;
using Vending_Machine.Data;

namespace XUnitTest_Vending_Machine
{
    public class UnitTestCreateProduct
    {
        [Fact]
        public void CreateProductArrayOk()
        {
            //Arrange
            Product[] productArray;
            string expectedDrinkMessage = "You quickly drink up the cold refreshing bottle";

            //Act
            productArray = CreateProducts.CreateProductArray();
            string expectedInfo1 = $"Product Nr: {productArray[1].ProductId}\nJuice\nPrice: 20kr\nSize: 25cl\nCalories: 150\nContains fruit meat";
            string expectedInfo2 = $"Product Nr: {productArray[4].ProductId}\nPizza\nPrice: 35kr\nSize: 70g\nCalories: 450\nContains meat, Gluten";
            string expectedInfo3 = $"Product Nr: {productArray[7].ProductId}\nChips bag\nPrice: 25kr\nSize: 100g\nCalories: 600\n";
            string juiceInformation = productArray[1].ShowInfo();
            string pizzaInformation = productArray[4].ShowInfo();
            string chipsInformation = productArray[7].ShowInfo();
            string drinkConsume = productArray[2].Consume();

            //Assert
            Assert.Equal(9,productArray.Length);
            Assert.Equal(expectedInfo1, juiceInformation);
            Assert.Equal(expectedInfo2, pizzaInformation);
            Assert.Equal(expectedInfo3, chipsInformation);
            Assert.Equal(expectedDrinkMessage, drinkConsume);
        }
    }
}
