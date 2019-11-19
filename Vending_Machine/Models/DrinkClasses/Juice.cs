using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models.DrinkClasses
{
    public class Juice : Drink
    {
        public Juice(int productId) : base()
        {
            base.productId = productId;
            base.name = "Juice";
            base.price = 20;
            base.bottleSize = "25cl";
            base.calories = 150;
            base.warning = "Contains fruit meat";
        }
    }
}
