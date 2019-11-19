using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Models
{
    public class Drink : Product
    {
        protected string bottleSize;
        
        public Drink() : base()
        {
            bottleSize = "0 ml";
        }

        //public override string ShowInfo()
        //{
        //    //Fixa för ny info
        //    return ($"Product Id: {productId.ToString()}\n{name}\nPrice: {price.ToString()}\nCalories: {calories.ToString()}\nAllergens: {allergens}");
        //}

    }
}
