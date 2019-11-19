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
    }
}
