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
            string expectedInfo1 = $"\tProduct Nr: {productArray[1].ProductId}\n\tJuice\n\tPrice: 20kr\n\tSize: 25cl\n\tCalories: 150\n\tContains fruit meat";
            string expectedInfo2 = $"\tProduct Nr: {productArray[4].ProductId}\n\tPizza\n\tPrice: 35kr\n\tSize: 70g\n\tCalories: 450\n\tContains meat, Gluten";
            string expectedInfo3 = $"\tProduct Nr: {productArray[7].ProductId}\n\tChips bag\n\tPrice: 25kr\n\tSize: 100g\n\tCalories: 600\n\t";
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
