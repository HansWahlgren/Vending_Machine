using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Models
{
    public abstract class Product
    {
        public int productId;
        protected int price;
        protected int calories;
        protected string name;
        protected string warning;

        public Product()
        {
            this.productId = 0;
            price = 0;
            calories = 0;
            warning = "None";
            name = "No product avaliable";
        }

        public abstract string ShowInfo();

        public abstract string Consume();
    }
}