using System;
using System.Collections.Generic;
using Vending_Machine.Models;

namespace Vending_Machine.Data
{
    public class HandleProduct
    {
        public static void RequestProduct(VendingMachine vendingMachine, List<Product> boughtProducts)
        {
            try
            {
                Console.WriteLine("\n\tPress the product id of the product you want to buy");
                boughtProducts.Add(vendingMachine.RequestProduct(int.Parse(Console.ReadLine())));
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine($"\t{exception.Message}");
                System.Threading.Thread.Sleep(1500);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine($"\t{exception.Message}");
                System.Threading.Thread.Sleep(1500);
            }
        }

        public static void UseProduct(List<Product> boughtProducts)
        {
            
            Console.Clear();
            if (boughtProducts.Count > 0)
            {
                Console.WriteLine("\n\tProducts you have bought:\n");
                foreach (var product in boughtProducts)
                {
                    Console.WriteLine($"\tId: {product.ProductId} {product.Name}");
                }

                Console.WriteLine("\n\n\tPress the id number of the product you want to consume");
                int userChoice = int.Parse(Console.ReadLine());
                Console.Clear();

                for (int i = 0; i < boughtProducts.Count; i++)
                {
                    if (userChoice == boughtProducts[i].ProductId)
                    {
                        Console.WriteLine($"\n\t{boughtProducts[i].Consume()}");
                        boughtProducts.RemoveAt(i);
                        break;
                    }
                    else if (i + 1 == boughtProducts.Count)
                    {
                        Console.WriteLine("\n\tYou have not bought the product with that id");
                    }
                }
            }

            else
            {
                Console.WriteLine("\n\tYou have not bought any products yet");
            }
            System.Threading.Thread.Sleep(2000);
        }
    }
}
