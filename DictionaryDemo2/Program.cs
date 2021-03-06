using System;
using System.Collections.Generic;

namespace DictionaryDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> temps = new Dictionary<string, int>();
            temps["Grand Rapids"] = 75;
            temps["Detroit"] = 75;
            temps["Columbus"] = 80;
            temps["Orlando"] = 95;

            foreach(var pair in temps)
            {
                Console.WriteLine($"{pair.Key} has temperature {pair.Value}");
            }

            Console.WriteLine("Grand Rapids:");
            Console.WriteLine(temps["Grand Rapids"]);

            Console.WriteLine("\nLet's get all the keys and loop through them");
            foreach(string key in temps.Keys)
            {
                Console.WriteLine($"This key is {key}");
                int theValue = temps[key];
                Console.WriteLine($"The temperature is {theValue}");
            }

            Console.Write("\nPlease enter a city: ");
            string entry = Console.ReadLine();
            if (temps.ContainsKey(entry))
            {
                Console.WriteLine($"The temperature at {entry} is {temps[entry]}");
            }
            else
            {
                Console.WriteLine("Sorry I don't know where that is.");
            }

            // For the lab, don't think of it as a Shopping LIST, think of it as a Shopping BASKET (what you are putting into it)
            // Ignore the part that says "Add the item and the price" to the users order. JUST add the ITEM to the list. (What will application do) (it's the sub-bullet under "ask the user to enter a name"). You will do this part later.
        }
    }
}
