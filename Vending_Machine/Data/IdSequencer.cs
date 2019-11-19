using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Data
{
    public class IdSequencer
    {
        private static int productId = 0;

        public static int NextProductId()
        {
            return ++productId;
        }
    }
}
