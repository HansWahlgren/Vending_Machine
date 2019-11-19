using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models.FoodClasses
{
    public class Pizza : Food
    {
        public Pizza(int productId) : base()
        {
            base.productId = productId;
            base.name = "Pizza";
            base.price = 35;
            base.foodSize = "70g";
            base.calories = 450;
            base.warning = "Contains meat, Gluten";
        }
    }
}
