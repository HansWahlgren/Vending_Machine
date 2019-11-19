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
            Cola product1 = new Cola(id1);
            Burger product2 = new Burger(id2);
            Candy product3 = new Candy(id3);

            //Assert
            Assert.Equal(id1, product1.productId);
            Assert.Equal(id2, product2.productId);
            Assert.Equal(id3, product3.productId);
        }

        [Fact]
        public void ShowInfoOk()
        {
            //Arrange
            int id1 = IdSequencer.NextProductId();
            int id2 = IdSequencer.NextProductId();
            int id3 = IdSequencer.NextProductId();
            string expectedInfo1 = $"Product Id: {id1}\nJuice\nPrice: 20kr\nSize: 25cl\nCalories: 150\nContains fruit meat";
            string expectedInfo2 = $"Product Id: {id2}\nPizza\nPrice: 35kr\nSize: 70g\nCalories: 450\nContains meat, Gluten";
            string expectedInfo3 = $"Product Id: {id3}\nChips bag\nPrice: 25kr\nSize: 100g\nCalories: 600\n";

            //Act
            Juice product1 = new Juice(id1);
            Pizza product2 = new Pizza(id2);
            Chips product3 = new Chips(id3);

            //Assert
            Assert.Equal(expectedInfo1, product1.ShowInfo());
            Assert.Equal(expectedInfo2, product2.ShowInfo());
            Assert.Equal(expectedInfo2, product3.ShowInfo());
        }

        //[Fact]
        //public void ShowConsumeOk()
        //{
        //    //Arrange
        //    int id = IdSequencer.NextProductId();
        //    string expectedInfo = $"Product Id: {id}\nChips bag\nPrice: 25kr\nSize: 100\nCalories: 600\n";

        //    //Act
        //    new Juice(IdSequencer.NextProductId());
        //    new Pizza(IdSequencer.NextProductId());
        //    Chips product3 = new Chips(id);

        //    //Assert
        //    Assert.Equal(expectedInfo, product3.ShowInfo());
        //}
    }
}

