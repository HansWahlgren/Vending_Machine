using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Models.DrinkClasses
{
    public class Cola : Drink
    {
        public Cola(int productId) : base()
        {
            base.productId = productId;
            base.name = "Coca Cola";
            base.price = 22;
            base.bottleSize = "50cl";
            base.calories = 400;
            base.warning = "Contains carbonic acid";
        }
    }
}
