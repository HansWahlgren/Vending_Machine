using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Models;
using Vending_Machine.Data;
using Vending_Machine.Models.DrinkClasses;
using Vending_Machine.Models.FoodClasses;
using Vending_Machine.Models.SnackClasses;

namespace Vending_Machine.Data
{
    public class VendingMachine : IVendingMachine
    {
        public void AddCurrency(int denominationAmount)
        {

        }

        public Product RequestProduct(int productNumber)
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
            return 12345;
        }

        public string[] GetProducts()
        {
            string[] placeHolder = new string[0];
            return placeHolder;
        }
    }
}
