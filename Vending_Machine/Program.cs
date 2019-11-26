using System;
using System.Linq;
using System.Collections.Generic;
using Vending_Machine.Data;
using Vending_Machine.Models;

namespace Vending_Machine
{
    class Program
    {
        private static readonly VendingMachine vendingMachine = new VendingMachine();
        private static readonly List<Product> boughtProducts = new List<Product>();
        private static int moneyPool = 0;
        
        static void Main(string[] args)
        {
            bool keepAlive = true;

            while(keepAlive)
            {
                Console.Clear();
                Console.WriteLine("\n\tPress: 1 to put in money\n\tPress: 2 to sort by type\n\tPress: 3 to get more details about a product\n" +
                    "\tPress: 4 to buy a product\n\tPress: 5 to use your bought products\n\tPress: 0 to exit the vending machine\n");
                Console.WriteLine($"\tBought products: {boughtProducts.Count}\n\n\tMoneypool: {moneyPool}\n\n\tAvailable products:");
                foreach (var product in vendingMachine.GetProducts())
                {
                    Console.WriteLine($"\t{product}");
                }

                try
                {
                    ConsoleKey userInput = Console.ReadKey(true).Key;
                    switch (userInput)
                    {
                        case ConsoleKey.D1:
                            AddCurrency();
                            moneyPool = vendingMachine.GetBalance();
                            break;
                        case ConsoleKey.D2:
                            SortByType.SortByProductType(vendingMachine);
                            break;
                        case ConsoleKey.D3:
                            ShowProductDescription.ShowDescription(vendingMachine);
                            break;
                        case ConsoleKey.D4:
                            HandleProduct.RequestProduct(vendingMachine, boughtProducts);
                            moneyPool = vendingMachine.GetBalance();
                            break;
                        case ConsoleKey.D5:
                            HandleProduct.UseProduct(boughtProducts);
                            break;
                        case ConsoleKey.D0:
                            ExitVendingMachine();
                            Environment.Exit(0);
                            break;
                        default:
                        
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("\n\tThe machine can only read numbers");
                    System.Threading.Thread.Sleep(1500);
                }
            }
        }

        static void AddCurrency()
        {
            Console.WriteLine("\n\tPut in a denomination into the machine");
            try
            {
                vendingMachine.AddCurrency(int.Parse(Console.ReadLine()));
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine($"\t{exception.Message}");
                System.Threading.Thread.Sleep(1500);
            }
        }

        static void ExitVendingMachine()
        {
            int[] changeBack = vendingMachine.EndSession();
            Console.Clear();
            Console.Write("\n\tYou exit the vending machine\n\tThe change you receive back are: ");
            foreach (var change in changeBack)
            {
                Console.Write($"{change}kr ");
            }
            Console.WriteLine($"\n\tFor a total amount of {changeBack.Sum()}kr");

            System.Threading.Thread.Sleep(4000);
            Environment.Exit(0);
        }
    }
}
