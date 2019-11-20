using Vending_Machine.Models;

namespace Vending_Machine.Data
{
    interface IVendingMachine
    {
        public void AddCurrency(int denominationAmount);
        public Product RequestProduct(int productNumber);
        public int[] EndSession();
        public string GetDescription(int productNumber);
        public int GetBalance();
        public string[] GetProducts();
    }
}
