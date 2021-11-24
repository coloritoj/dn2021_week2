using System;
using System.Collections.Generic;

namespace ShoppingList_ExtendedExercises
{/*----- WHAT WILL THE APPLICATION DO? -----
  * Display at least 8 names and prices.
  * Ask the user to enter an item name.
  *     // If that item exists, display that item and price and add that item and its price to the users order (JEFF SAID TO NOT ADD THE PRICE YET)
  *     // If that item doesn't exist, display an error and re-prompt the user (display the menu again if you'd like).
  * After adding one to the order, ask if they want to add another. If so, repeat. Note: User can add an item more than once; we're not keeping track of quantity at this point.
  * When they are done adding items, display a list of all items ordered with prices in columns.
  * Display the sum price of the items ordered.
  * 
  * ----- BUILD SPECIFICATIONS -----
  * 2 POINTS: Application uses a Dictionary<string, decimal> to keep track of the menu of items. You can code it with literals. Points are for instantiation and initialization. --- COMPLETE
  * Use a List<string> for the shopping list and store the name of the items the customer ordered. Application takes item name input and...
  *     // 1 POINT: Responds if that item doesn't exist --- COMPLETE
  *     // 1 POINT: If the item does exist, it adds its name and price to the relevant list --- COMPLETE
  * 1 POINT: Application asks user if they want to quit or continue, and loops appropriately --- COMPLETE
  * 2 POINTS: Application displays list of items with their prices --- COMPLETE
  * 1 POINT: Application displays the correct total price (sum) for the list --- COMPLETE
  *     // To determine the sum:Loop through the shopping list's List collection, obtain the name, and lookup the name's price in the Menu Dictionary
  * 
  * ----- EXTENDED CHALLENGES -----
  * 1 POINT: Implement a menu system so the user can enter just a letter or number for the item. --- COMPLETE
  * 1 POINT: Display the most and least expensive item ordered. --- COMPLETE
  * 1 POINT: Display the items ordered in order of price --- DID NOT COMPLETE
  */


    class Program
    {
        static bool ItemExists(Dictionary<string, decimal> menu, string name)
        {
            if (menu.ContainsKey(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string FindLowestPricedItem(List<string> cart)
        {
            if (cart.Contains("Apple"))
            {
                return "Apple";
            }
            else if (cart.Contains("Banana"))
            {
                return "Banana";
            }
            else if (cart.Contains("Carrot"))
            {
                return "Carrot";
            }
            else if (cart.Contains("Eggs"))
            {
                return "Eggs";
            }
            else if (cart.Contains("Gatorade"))
            {
                return "Gatorade";
            }
            else if (cart.Contains("Dill Pickle"))
            {
                return "Dill Pickle";
            }
            else if (cart.Contains("Ham"))
            {
                return "Ham";
            }
            else
            {
                return "Fruit Basket";
            }
        }

        static string FindHighestPricedItem(List<string> cart)
        {
            if (cart.Contains("Fruit Basket"))
            {
                return "Fruit Basket";
            }
            else if (cart.Contains("Ham"))
            {
                return "Ham";
            }
            else if (cart.Contains("Dill Pickle"))
            {
                return "Dill Pickle";
            }
            else if (cart.Contains("Gatorade"))
            {
                return "Gatorate";
            }
            else if (cart.Contains("Eggs"))
            {
                return "Eggs";
            }
            else if (cart.Contains("Carrot"))
            {
                return "Carrot";
            }
            else if (cart.Contains("Banana"))
            {
                return "Banana";
            }
            else
            {
                return "Apple";
            }
        }

        static string SwitchStatement(string entry)
        {
            switch (entry)
            {
                case "A":
                    entry = "Apple";
                    break;
                case "1":
                    entry = "Apple";
                    break;
                case "B":
                    entry = "Banana";
                    break;
                case "2":
                    entry = "Banana";
                    break;
                case "C":
                    entry = "Carrot";
                    break;
                case "3":
                    entry = "Carrot";
                    break;
                case "D":
                    entry = "Dill Pickle";
                    break;
                case "4":
                    entry = "Dill Pickle";
                    break;
                case "E":
                    entry = "Eggs";
                    break;
                case "5":
                    entry = "Eggs";
                    break;
                case "F":
                    entry = "Fruit Basket";
                    break;
                case "6":
                    entry = "Fruist Basket";
                    break;
                case "G":
                    entry = "Gatorade";
                    break;
                case "7":
                    entry = "Gatorade";
                    break;
                case "H":
                    entry = "Ham";
                    break;
                case "8":
                    entry = "Ham";
                    break;
            }
            return entry;
        }

        static void Main(string[] args)
        {
            Dictionary<string, decimal> storeMenu = new Dictionary<string, decimal>();
            storeMenu["Apple"] = 1.00m;
            storeMenu["Banana"] = 1.19m;
            storeMenu["Carrot"] = 1.37m;
            storeMenu["Dill Pickle"] = 2.99m;
            storeMenu["Eggs"] = 1.50m;
            storeMenu["Fruit Basket"] = 8.75m;
            storeMenu["Gatorade"] = 1.99m;
            storeMenu["Ham"] = 5.62m;

            List<string> shoppingCart = new List<string>();

            Console.WriteLine("Here is the store's menu: ");
            foreach (var pair in storeMenu)
            {
                Console.WriteLine($"{pair.Key}: ${pair.Value}");
            }

            Console.Write("\nWould you like a list of shortcuts for entering your items? (yes/no): ");
            string entry = Console.ReadLine();

            if (entry == "yes")
            {
                Console.WriteLine("\nHere are the list of shortcuts: ");
                Console.WriteLine("Apple = A or 1");
                Console.WriteLine("Banana = B or 2");
                Console.WriteLine("Carrot = C or 3");
                Console.WriteLine("Dill Pickle = D or 4");
                Console.WriteLine("Eggs = E or 5");
                Console.WriteLine("Fruit Basket = F or 6");
                Console.WriteLine("Gatorade = G or 7");
                Console.WriteLine("Ham = H or 8");
            }

            bool goAgain = true;
            do
            {
                Console.Write("\nWhat would you like to add to the shopping cart?: ");
                string shoppingCartEntry = Console.ReadLine();

                shoppingCartEntry = SwitchStatement(shoppingCartEntry);

                if (ItemExists(storeMenu, shoppingCartEntry))
                {
                    shoppingCart.Add(shoppingCartEntry);
                    Console.WriteLine($"You have added {shoppingCartEntry} to your shopping cart.");
                }
                else
                {
                    Console.WriteLine("That is not a valid entry.");
                }

                Console.Write("Would you like to add another item to the shopping cart? (yes/no): ");
                string addMore = Console.ReadLine();
                if (addMore == "yes")
                {
                    goAgain = true;
                }
                else
                {
                    goAgain = false;
                }
            } while (goAgain == true);

            decimal totalPrice = 0;
            Console.WriteLine("\nHere is what you've added to your shopping cart: ");
            foreach (string item in shoppingCart)
            {
                Console.WriteLine($"{item}: ${storeMenu[item]}"); // Check array demo 2 if you wanna see how to space things correctly
                totalPrice += storeMenu[item];
            }

            string highestItem = FindHighestPricedItem(shoppingCart);
            string lowestItem = FindLowestPricedItem(shoppingCart);

            Console.WriteLine($"Your total price comes to: ${totalPrice}");
            Console.WriteLine($"Your highest priced item is: {highestItem}");
            Console.WriteLine($"Your lowest priced item is: {lowestItem}");
        }
    }
}
