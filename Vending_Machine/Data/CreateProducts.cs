using System.Collections.Generic;
using Vending_Machine.Models;
using Vending_Machine.Models.DrinkClasses;
using Vending_Machine.Models.FoodClasses;
using Vending_Machine.Models.SnackClasses;

namespace Vending_Machine.Data
{
    public class CreateProducts
    {
        public static Product[] CreateProductArray()
        {
            Product cola = new Cola(IdSequencer.NextProductId());
            Product[] productArray = new Product[]
            {
                cola,
                new Juice(IdSequencer.NextProductId()),
                new Water(IdSequencer.NextProductId()),

                new Burger(IdSequencer.NextProductId()),
                new Pizza(IdSequencer.NextProductId()),
                new Sandwich(IdSequencer.NextProductId()),

                new Candy(IdSequencer.NextProductId()),
                new Chips(IdSequencer.NextProductId()),
                new Peanuts(IdSequencer.NextProductId())
            };

            //List<Product> productList = new List<Product>();
            //List<string> productNameList = new List<string>
            //{
            //    "Cola","Juice","Water","Burger","Pizza","Sandwich","Candy","Chips","Peanuts"
            //};

            //foreach (var item in productNameList)
            //{
            //    productList.Add(new item(IdSequencer.NextProductId()));
            //}

            //Product[] productArray = productList.ToArray();

            return productArray;
        }
    }
}
