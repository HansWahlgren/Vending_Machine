using Xunit;
using Vending_Machine.Data;

namespace XUnitTest_Vending_Machine
{
    public class UnitTestUpdateDepositPool
    {
        [Fact]
        public void ArrangeDepositPoolOk()
        {
            //Arrange
            int moneyPool1 = 793;
            int moneyPool2 = 1680;
            int moneyPool3 = 3888;
            int moneyPool4 = 0;
            int[] expectedArray1 = { 500, 200, 50, 20, 20, 2, 1 };
            int[] expectedArray2 = { 1000, 500, 100, 50, 20, 10 };
            int[] expectedArray3 = { 1000, 1000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            //Act
            int[] depositPoolArray1 = UpdateDepositPool.ArrangeDepositPool(moneyPool1);
            int[] depositPoolArray2 = UpdateDepositPool.ArrangeDepositPool(moneyPool2);
            int[] depositPoolArray3 = UpdateDepositPool.ArrangeDepositPool(moneyPool3);
            int[] depositPoolArray4 = UpdateDepositPool.ArrangeDepositPool(moneyPool4);

            //Assert
            Assert.Equal(expectedArray1, depositPoolArray1);
            Assert.Equal(expectedArray2,depositPoolArray2);
            Assert.Equal(expectedArray3, depositPoolArray3);
            Assert.Empty(depositPoolArray4);
        }
    }
}
