using Vending_Machine.Models;
using Vending_Machine.Models.DrinkClasses;
using System.Linq;

namespace Vending_Machine.Data
{
    interface IVendingMachine
    {
        public void AddCurrency(int denominationAmount) {   }

        public object RequestProduct(int productNumber)
        {
            return new object();
        }

        public int[] EndSession() 
        {
            return new int[] { };
        }
        public static string GetDescription(int productNumber)
        {
            return "";
        }

        public static int GetBalance()
        {
            return new int();
        }

        public static string[] GetProducts() 
        {
            return new string[] { };
        }
    }
}
