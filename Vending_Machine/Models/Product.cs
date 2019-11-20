using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Models
{
    public abstract class Product
    {
        protected int price;
        protected int calories;
        protected string name;
        protected string warning;
        public int ProductId { get; protected set; }

        public Product()
        {
            ProductId = 0;
            price = 0;
            calories = 0;
            warning = "None";
            name = "No product avaliable";
        }

        public abstract string ShowInfo();

        public abstract string Consume();
    }
}