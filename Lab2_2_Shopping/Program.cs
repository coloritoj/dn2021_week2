using System;
using System.Collections.Generic;

namespace Lab2_2_Shopping
{
    class Program
    {

        static void PrintMenu(Dictionary<string, decimal> menu) // Jeff's recommendation: Name the argument variable based on what the variable represents (in this case, a menu)
        {
            Console.WriteLine("Welcome to the Store");
            foreach (var pair in menu)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }

        static void PrintCart(List<string> cart, Dictionary<string, decimal> menu) // We take in the dictionary as an argument too so we can pull the price from {menu[item]}
        {
            decimal sum = 0.00m;
            Console.WriteLine("Here are your items: ");
            foreach (string item in cart)
            {
                Console.WriteLine($"{item} price {menu[item]}");
                // sum = sum + menu[item]
                sum += menu[item];
            }
            Console.WriteLine($"Your total is {sum}.");
        }

        static void Main(string[] args)
        {
            /*
             * Our data model:
             * 
             * 1. A dictionary mapping an item name (string) to a price (decimal)
             * 2. A list containing items (string the shopper is going to purchase (i.e.: the cart or basket)
             * 
             * 
             * 
             */

            Dictionary<string, decimal> menu = new Dictionary<string, decimal>(); // The dictionary MATCHES a string to a decimal (this is how you say it)
            List<string> cart = new List<string>();

            // Add some items to the menu
            menu["Milk"] = 2.00m; // Here we are hard-coding the values. In the "real world" these values would be pulled from a database.
            menu["Bread"] = 3.00m;
            menu["Coffee"] = 7.00m;
            menu["Banana"] = 0.50m;
            menu["Apple"] = 0.75m;

            PrintMenu(menu);

            // Let's add one item to the cart
            // cart.Add("Milk");
            // cart.Add("Apple");
            // cart.Add("Apple");
            // Commenting these out to test if we can ask the user to add an item to the cart

            bool doneAdding = false;
            while (!doneAdding)
            {
                Console.WriteLine("What would you like to buy?");
                string entry = Console.ReadLine();

                if (menu.ContainsKey(entry))
                {
                    Console.WriteLine($"A(n) {entry} has been added to your cart for {menu[entry]}");
                    cart.Add(entry);
                }
                else
                {
                    Console.WriteLine("We don't have that.");
                    PrintMenu(menu);
                }

                Console.WriteLine("Would you like to add another item?");
                entry = Console.ReadLine();
                if (entry == "N" || entry == "n")
                {
                    doneAdding = true;
                }

            }


            PrintCart(cart, menu); // Can click the little lightbulb for Visual Studio to create a method

        }


    }
}
