﻿namespace Vending_Machine.Models.DrinkClasses
{
    public class Juice : Drink
    {
        public Juice(int productId) : base(productId)
        {
            base.Name = "Juice";
            base.Price = 20;
            base.bottleSize = "25cl";
            base.calories = 150;
            base.warning = "Contains fruit meat";
        }
    }
}
