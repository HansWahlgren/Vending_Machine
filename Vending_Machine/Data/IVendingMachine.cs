using Vending_Machine.Models;
using Vending_Machine.Models.DrinkClasses;
using System.Linq;

namespace Vending_Machine.Data
{
    interface IVendingMachine
    {
        private static int[] depositPool = new int[0];
        public static void AddCurrency(int denominationAmount) 
        { 

        }

        public static Product RequestProduct(int productNumber) 
        {
            Product placeHolder = new Cola(0);
            return placeHolder;
        }

        public int[] EndSession() 
        {
            int[] placeHolder = new int[0];
            return placeHolder;
        }
        public string GetDescription(int productNumber) 
        {
            return "Placeholder";
        }

        public int GetBalance() 
        {
            return depositPool.Sum();
        }

        public string[] GetProducts() 
        {
            string[] placeHolder = new string[0];
            return placeHolder;
        }
    }
}
