using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Models;

namespace Vending_Machine.Data
{
    public class ShowProductDescription
    {
        public static void ShowDescription(VendingMachine vendingMachine)
        {
            Console.WriteLine("\n\tPress a product id to see more details about the product");
            try
            {
               string productDetails = vendingMachine.GetDescription(int.Parse(Console.ReadLine()));
                Console.Clear();
                Console.WriteLine($"\n{productDetails}\n\n\tPress anything to return to main screen");
                Console.ReadKey(true);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine($"\t{exception.Message}");
                System.Threading.Thread.Sleep(1500);
            }
        }
    }
}
