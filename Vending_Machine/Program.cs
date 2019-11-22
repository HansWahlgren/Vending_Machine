using System;
using System.Text;
using System.Collections.Generic;
using Vending_Machine.Data;
using Vending_Machine.Models;
using Vending_Machine.Models.DrinkClasses;
using Vending_Machine.Models.FoodClasses;
using Vending_Machine.Models.SnackClasses;

namespace Vending_Machine
{
    class Program
    {
        private static readonly VendingMachine vendingMachine = new VendingMachine();
        private static List<Product> boughtProduct = new List<Product>();
        private static int moneyPool = 0;
        
        static void Main(string[] args)
        {
            bool keepAlive = true;

            while(keepAlive)
            {
                Console.Clear();
                Console.WriteLine("\n\tPress: 1 to put in money\n\tPress: 2 to sort by type\n\tPress: 3 to get more details about a product\n" +
                    "\tPress: 4 to buy a product\n\tPress: 5 to use your bought products\n\tPress: 0 to exit the vending machine\n");
                Console.WriteLine($"\tMoneypool: {moneyPool}\n\n\tAvailable products:");
                foreach (var product in vendingMachine.GetProducts())
                {
                    Console.WriteLine("\t" + product);
                }

                ConsoleKey userInput = Console.ReadKey(true).Key;
                switch (userInput)
                {
                    case ConsoleKey.D1:
                        AddCurrency();
                        moneyPool = vendingMachine.GetBalance();
                        break;
                    case ConsoleKey.D2:
                        //Sort by type
                        break;
                    case ConsoleKey.D3:
                        //More details about product
                        break;
                    case ConsoleKey.D4:
                       //Buy product
                        break;
                    case ConsoleKey.D5:
                        //use bought product
                        break;
                    case ConsoleKey.D0:
                        //Exit Vending machine
                        break;
                    default:
                        
                        break;
                }
            }
        }

        static void AddCurrency()
        {
            Console.WriteLine("\tPut in a denomination into the machine");
            try
            {
                int userCurrency = int.Parse(Console.ReadLine());
                vendingMachine.AddCurrency(userCurrency);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine("\t" + exception.Message);
                System.Threading.Thread.Sleep(1500);
            }
            catch
            {
                Console.WriteLine("\tThe machine can only read numbers");
                System.Threading.Thread.Sleep(1500);
            }
        }
    }
}
