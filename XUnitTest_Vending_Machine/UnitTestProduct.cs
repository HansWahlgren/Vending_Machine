using System;
using Xunit;
using Vending_Machine.Data;
using Vending_Machine.Models;

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
            new Product(id1);
            Product product2 = new Product(id2);
            Product product3 = new Product(id3);

            //Assert
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
            string expectedInfo = "Product Id: 3\nNo product avaliable\nPrice: 0\nCalories: 0\nAllergens: None";

            //Act
            new Product(id1);
            new Product(id2);
            Product product3 = new Product(id3);

            //Assert
            Assert.Equal(expectedInfo, product3.ShowInfo());
        }
    }
}

