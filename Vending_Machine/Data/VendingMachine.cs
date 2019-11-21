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
        private static readonly Product[] productArray = CreateProducts.CreateProductArray();
        private static int[] depositPool = new int[0];

        public static void AddCurrency(int denominationAmount)
        {
            depositPool = UpdateDepositPool.ArrangeDepositPool(depositPool.Sum() + denominationAmount);
        }

        public static Product RequestProduct(int productNumber)
        {
            int productArrayId = 0;
            for (int i = 0; i < productArray.Length; i++)
            {
                if (productArray[i].ProductId == productNumber)
                {
                    productArrayId = i;
                }
            }
            return productArray[productArrayId];
            //return productArray[productNumber-1];
        }

        public static int[] EndSession()
        {
            int[] changeToCustomer = depositPool;

            int[] emptydepositPool = new int[0];
            depositPool = emptydepositPool;

            return changeToCustomer;
        }

        public static string GetDescription(int productNumber)
        {
            string productInformation = "";
            foreach (var product in productArray)
            {
                if (product.ProductId == productNumber)
                {
                    productInformation = product.ShowInfo();
                }
            }
            return productInformation;
        }

        public static int GetBalance()
        {
            return depositPool.Sum();
        }

        public static string[] GetProducts()
        {
            List<String> productsNameList = new List<String>();
            foreach (var product in productArray)
            {
                productsNameList.Add($"Number: {product.ProductId} {product.Name}");
            }
            string[] productsName = productsNameList.ToArray();

            return productsName;
        }
    }
}
