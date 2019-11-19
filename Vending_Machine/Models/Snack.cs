using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Models
{
    public class Snack : Product
    {
        protected string bagSize;
        public Snack() : base()
        {
            bagSize = "0 g";
        }

        public override string ShowInfo()
        {
            return ($"Product Id: {productId.ToString()}\n{name}\nPrice: {price.ToString()}kr\nSize: {bagSize}" +
                $"\nCalories: {calories.ToString()}\n{warning}");
        }

        public override string Consume()
        {
            return ("You quietly eat up everything in your bag of snacks");
        }
    }
}
