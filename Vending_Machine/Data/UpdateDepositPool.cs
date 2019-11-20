using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Data
{
    public class UpdateDepositPool
    {
        private static readonly int[] accaptableDenominations = { 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        public static int[] ArrangeDepositPool(int totalAmount)
        {
            List<int> depositPoolList = new List<int>();
            while (totalAmount > 0)
            {
                foreach (var denomination in accaptableDenominations)
                {
                    if(denomination < totalAmount || denomination == totalAmount)
                    {
                        depositPoolList.Add(denomination);
                        totalAmount -= denomination;
                        break;
                    }
                }
            }
            int[] depositPoolArray = depositPoolList.ToArray();
            return depositPoolArray;
        }
    }
}
