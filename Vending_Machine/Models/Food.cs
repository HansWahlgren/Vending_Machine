using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Models
{
    public class Food : Product
    {
        protected string foodSize;

        public Food() : base()
        {
            foodSize = "0 g";
        }

        public override string ShowInfo()
        {
            return ($"Product Id: {productId.ToString()}\n{name}\nPrice: {price.ToString()}kr\nSize: {foodSize}" +
                $"\nCalories: {calories.ToString()}\n{warning}");
        }

        public override void Consume()
        {
            Console.WriteLine("With great hunger you devour your meal fast");
        }
    }
}
