using Vending_Machine.Models;

namespace Vending_Machine.Data
{
    interface IVendingMachine
    {
        void AddCurrency(int denominationAmount);

        Product RequestProduct(int productNumber);

        int[] EndSession();

        string GetDescription(int productNumber);

        int GetBalance();

        string[] GetProducts();
    }
}
