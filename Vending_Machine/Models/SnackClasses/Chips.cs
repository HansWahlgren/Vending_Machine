using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models.SnackClasses
{
    public class Chips : Snack
    {
        public Chips(int productId) : base()
        {
            base.productId = productId;
            base.name = "Chips bag";
            base.price = 25;
            base.bagSize = "100g";
            base.calories = 600;
            base.warning = "";
        }
    }
}
