using System;
using Vending_Machine.Models;

namespace Vending_Machine.Data
{
    public class SortByType
    {
        public static void SortByProductType(VendingMachine vendingMachine)
        {
            bool keepAlive = true;

            while (keepAlive)
            {
                Console.Clear();
                Console.WriteLine("\n\tSort by:\n\t1: Drinks\n\t2: Food\n\t3: Snacks\n\t0: to exit\n");
                ConsoleKey userInput = Console.ReadKey(true).Key;
                switch (userInput)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        foreach (var product in vendingMachine.productArray)
                        {
                            if (product is Drink)
                            {
                                Console.WriteLine($"\n{product.ShowInfo()}");
                            }
                        }
                        Console.WriteLine("\n\tPress anything to return previous screen");
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        foreach (var product in vendingMachine.productArray)
                        {
                            if (product is Food)
                            {
                                Console.WriteLine($"\n{product.ShowInfo()}");
                            }
                        }
                        Console.WriteLine("\n\tPress anything to return previous screen");
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        foreach (var product in vendingMachine.productArray)
                        {
                            if (product is Snack)
                            {
                                Console.WriteLine($"\n{product.ShowInfo()}");
                            }
                        }
                        Console.WriteLine("\n\tPress anything to return previous screen");
                        Console.ReadKey(true);
                        break;

                    case ConsoleKey.D0:
                        keepAlive = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("\n\tThat category does not exist");
                        Console.WriteLine("\tPress anything to return previous screen");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}
