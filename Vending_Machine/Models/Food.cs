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
    }
}
