using System;
using System.Collections.Generic;
using System.Linq;
using Vending_Machine.Models;

namespace Vending_Machine.Data
{
    public class VendingMachine : IVendingMachine
    {
        private static readonly Product[] productArray = CreateProducts.CreateProductArray();
        private static int[] depositPool = new int[0];
        private static readonly int[] accaptableDenominations = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        public void AddCurrency(int denominationAmount)
        {
            foreach (var denominationValue in accaptableDenominations)
            {
                if (denominationAmount == denominationValue)
                {
                    depositPool = UpdateDepositPool.ArrangeDepositPool((depositPool.Sum() + denominationAmount), accaptableDenominations);
                }
            }
        }

        public Product RequestProduct(int productNumber)
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
        }

        public int[] EndSession()
        {
            int[] changeToCustomer = depositPool;

            int[] emptydepositPool = new int[0];
            depositPool = emptydepositPool;

            return changeToCustomer;
        }

        public string GetDescription(int productNumber)
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

        public int GetBalance()
        {
            return depositPool.Sum();
        }

        public string[] GetProducts()
        {
            List<String> productsNameList = new List<String>();
            foreach (var product in productArray)
            {
                productsNameList.Add($"Number: {product.ProductId} {product.Name}\n");
            }
            string[] productsName = productsNameList.ToArray();

            return productsName;
        }
    }
}
