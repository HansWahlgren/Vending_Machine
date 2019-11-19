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

        public override string ShowInfo()
        {
            return ($"Product Id: {productId.ToString()}\n{name}\nPrice: {price.ToString()}kr\nSize: {bottleSize}" +
                $"\nCalories: {calories.ToString()}\n{warning}");
        }

        public override string Consume()
        {
            return ("You quickly drink up the cold refreshing bottle");
        }
    }
}
