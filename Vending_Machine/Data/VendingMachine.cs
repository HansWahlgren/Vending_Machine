using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Vending_Machine.Models;
using Vending_Machine.Data;
using Vending_Machine.Models.DrinkClasses;
using Vending_Machine.Models.FoodClasses;
using Vending_Machine.Models.SnackClasses;

namespace Vending_Machine.Data
{
    public class VendingMachine : IVendingMachine
    {
        private static Product[] productArray = CreateProducts.CreateProductArray();
        private static int[] depositPool = new int[0];

        public static void AddCurrency(int denominationAmount)
        {
            depositPool = UpdateDepositPool.ArrangeDepositPool(depositPool.Sum() + denominationAmount);
        }

        public static Product RequestProduct(int productNumber)
        {
            Product placeHolder = new Cola(0);
            return placeHolder;
        }

        public static int[] EndSession()
        {
            int[] placeHolder = new int[0];
            return placeHolder;
        }

        public static string GetDescription(int productNumber)
        {
            return "Placeholder";
        }

        public static int GetBalance()
        {
            return depositPool.Sum();
        }

        public static string[] GetProducts()
        {
            string[] placeHolder = new string[0];
            return placeHolder;
        }
    }
}
