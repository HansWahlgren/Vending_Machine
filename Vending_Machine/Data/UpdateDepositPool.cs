using System.Collections.Generic;

namespace Vending_Machine.Data
{
    public class UpdateDepositPool
    {

        public static int[] ArrangeDepositPool(int totalAmount, int[] accaptableDenominations)
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
