using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Need to hit "escape" key to get out of the pre-populated word so that you can select the dropdown
            Dictionary<string, string> capitals = new Dictionary<string, string>(); // Don't forget the parenthesis afterwards!   // The <string, string> on the LEFT is known as the KEY. The <string, string> on the right is the VALUE.
            capitals["Michigan"] = "Lansing";
            capitals["Ohio"] = "Columbus";
            capitals["California"] = "Sacramento";
            capitals["Georgia"] = "Atlanta";

            Console.WriteLine("Let's print out a couple of these");
            Console.WriteLine(capitals["Ohio"]); // We are accessing the capital city (VALUE) based on the KEY which is the state
            Console.WriteLine(capitals["Georgia"]);

            Console.WriteLine("\nLet's use a foreach loop:");
            foreach (var pair in capitals) // If you hover your mouse over "var" it tells you what the TKey and TValue are
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }

            Console.WriteLine("\nLet's change MI capital to Detroit");
            capitals["Michigan"] = "Detroit"; // Replaces the value of Lansing with Detroit; it doesn't add a new value for Michigan
            foreach (var pair in capitals)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }

            Console.WriteLine("\nLet's add another");
            capitals["Indiana"] = "Indianapolis";
            foreach (var pair in capitals)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }
    }
}
