using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Models
{
    public class Product
    {
        public readonly int productId;
        protected int price;
        protected int calories;
        protected string allergens;
        protected string name;

        public Product(/*int productId*/)
        {
            //this.productId = productId;
            price = 0;
            calories = 0;
            allergens = "None";
            name = "No product avaliable";
        }

        public virtual string ShowInfo()
        {
            //Fixa för ny info
            return ($"Product Id: {productId.ToString()}\n{name}\nPrice: {price.ToString()}\nCalories: {calories.ToString()}\nAllergens: {allergens}");
        }

        public virtual void Consume()
        {
            //Fixa för olika typer
            Console.WriteLine("You have consumed the product");
        }
    }
}