using System;
using System.Collections.Generic;
using System.Linq;
using Vending_Machine.Data;

namespace Vending_Machine.Models
{
    public class VendingMachine : IVendingMachine
    {
        private static readonly Product[] productArray = CreateProducts.CreateProductArray();
        private static int[] depositPool = new int[0];
        private static readonly int[] accaptableDenominations = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        public void AddCurrency(int denominationAmount)
        {
            for (int i = 0; i < accaptableDenominations.Length; i++)
            {
                if (denominationAmount == accaptableDenominations[i])
                {
                    depositPool = UpdateDepositPool.ArrangeDepositPool((depositPool.Sum() + denominationAmount), accaptableDenominations);
                    break;
                }
                else if(i+1 == accaptableDenominations.Length)
                {
                    throw new IndexOutOfRangeException("Not an acceptable denomination");
                }
            }
        }

        public Product RequestProduct(int productNumber)
        {
            if (productNumber <= productArray.Length && productNumber > 0)
            {
                if (GetBalance() > productArray[productNumber - 1].Price)
                {
                    depositPool = UpdateDepositPool.ArrangeDepositPool((depositPool.Sum() - productArray[productNumber - 1].Price), accaptableDenominations);
                    return productArray[productNumber - 1];
                }
                else
                {
                    throw new ArgumentException("You can´t afford this product");
                }
            }
            else
            {
                throw new IndexOutOfRangeException("The product you have selected does not exist");
            }
        }

        public int[] EndSession()
        {
            int[] changeToCustomer = depositPool;

            int[] emptydepositPool = new int[0];
            depositPool = emptydepositPool;
            IdSequencer.Reset();

            return changeToCustomer;
        }

        public string GetDescription(int productNumber)
        {
            if (productNumber <= productArray.Length && productNumber > 0)
            {
                return productArray[productNumber - 1].ShowInfo();
            }
            else
            {
                throw new IndexOutOfRangeException("The product you have selected does not exist");
            }
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
                productsNameList.Add($"Number: {product.ProductId} {product.Name}");
            }
            string[] productsName = productsNameList.ToArray();

            return productsName;
        }

        public Product[] GetProductsArray()
        {
            return productArray;
        }
    }
}
