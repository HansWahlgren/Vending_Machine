using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Models;

namespace Vending_Machine.Data
{
    public class SortByType
    {
        public static void SortByProductType(VendingMachine vendingMachine)
        {
            Console.Clear();
            Console.WriteLine("\n\tSort by:\n\t1: Drinks\n\t2: Food\n\t3: Snacks\n\t0: to exit");
            var allProducts = vendingMachine.GetProducts();

            bool keepAlive = true;

            while (keepAlive)
            {
                ConsoleKey userInput = Console.ReadKey(true).Key;
                switch (userInput)
                {
                    case ConsoleKey.D1:
                        foreach (var product in allProducts)
                        {
                            if (product is Drink)
                            {
                                Console.WriteLine("Drink");
                            }
                        }
                        break;

                    case ConsoleKey.D2:
                        foreach (var product in allProducts)
                        {
                            if (product is Food)
                            {
                                Console.WriteLine("Food");
                            }
                        }
                        break;

                    case ConsoleKey.D3:
                        foreach (var product in allProducts)
                        {
                            if (product is Snack)
                            {
                                Console.WriteLine("Snack");
                            }
                        }
                        break;

                    case ConsoleKey.D0:
                        keepAlive = false;
                        break;

                    default:

                        break;
                }
            }
        }
    }
}
