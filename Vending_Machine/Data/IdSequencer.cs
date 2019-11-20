﻿namespace Vending_Machine.Data
{
    public class IdSequencer
    {
        private static int productId = 0;

        public static int NextProductId()
        {
            return ++productId;
        }
        public static void Reset()
        {
            productId = 0;
        }
    }
}
