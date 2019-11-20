using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models.DrinkClasses
{
    public class Water : Drink
    {
        public Water(int productId) : base()
        {
            base.ProductId = productId;
            base.name = "Water";
            base.price = 10;
            base.bottleSize = "33cl";
            base.calories = 50;
            base.warning = "";
        }
    }
}
