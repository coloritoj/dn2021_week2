using System;

namespace ArrayDemo2
{
    class Program
    {
        static void PrintMenu(string[] theItems, decimal[] thePrices)
        {
            Console.WriteLine("Here is our menu:");
            for (int i = 0; i < theItems.Length; i++)
            {
                Console.WriteLine($"{theItems[i],-12}{thePrices[i],-6}");
            }
        }

        static int FindItem(string[] theItems, string search)
        {
            for (int i = 0; i < theItems.Length; i++)
            {
                if (theItems[i].ToLower() == search.ToLower())
                {
                    return i;
                }
            }
            return -1; // The reason we don't want to return 0 (if the "search" is not found in the array in the for loop above) is because it's the first item in the array
        }

        static bool GoAgain()
        {
            while (true)
            {

                Console.Write("Would you like to go again? (y/n)");
                string entry = Console.ReadLine();
                if (entry.ToLower() == "n")
                {
                    return false;
                }
                if (entry.ToLower() == "y")
                {
                    return true;
                }
                Console.WriteLine("I'm sorry but I don't know what that means.");
            }
        }

        static void Main(string[] args)
        {
            /*
             * 
             * 
             * Create a menu used at a coffee house
             * 
             *      Item                Price
             *      ----                -----
             *      Coffee              $2.00
             *      Espresso            $2.50
             *      Muffin              $3.50
             *      Croissant           $4.00
             * 
             */

            // For now we're creating two separate arrays
            string[] items = new string[] { "Coffee", "Espresso", "Muffin", "Croissant" };
            decimal[] prices = new decimal[] { 2.00m, 2.50m, 3.50m, 4.00m };




            do
            {
                PrintMenu(items, prices);

                Console.WriteLine("Please make a selection:");
                string entry = Console.ReadLine();
                int index = FindItem(items, entry);

                if (index > -1) // Means we got a valid index
                {
                    Console.WriteLine($"The price of {items[index]} is {prices[index]}");
                }
                else
                {
                    Console.WriteLine($"Sorry, we do not have {entry}.");
                }
            }
            while (GoAgain());


            // Use the GoAgain() function for the homework today. No need to reinvent the wheel. We have permission to copy that one. He doesn't want us worrying about the go again part.
        }
    }
}
