using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(); // When you first type list, click out and then click the lightbulb dropdown and select System.Collections.Generic
                                                     // Doing this step created/initialized an empty list.
                                                     // Lists are similar to arrays but are more powerful and more widely used.

            names.Add("Fred"); // This added "Fred" to the list.
            names.Add("Sally");

            Console.WriteLine(names[0]); // You call the list just like an array
            Console.WriteLine(names[1]);

            names.Add("Julia");
            Console.WriteLine(names[2]);

            Console.WriteLine(names.Contains("Fred")); // The .Contains returns a boolean
            Console.WriteLine(names.Contains("Pizza"));

            Console.WriteLine("Now let's remove Fred");
            names.Remove("Fred"); // Removed Fred and then shifted the list back
            Console.WriteLine(names[0]); // This is why Sally is printed (because she takes Fred's spot)

            Console.WriteLine("Let's remove by index rather than names");
            names.RemoveAt(1);
            Console.WriteLine(names[0]);
            // Console.WriteLine(names[1]); // Can't remove this one because it's gone!

            // Let's add a couple more things back in
            names.Add("Jack");
            names.Add("Allison");
            names.Add("Dylan");
            names.Add("Erica");

            Console.WriteLine("\nLet's loop through them using a for loop");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"We are inside the loop and our index is {i}.");
                Console.WriteLine($"{i} : {names[i]}");
            }

            Console.WriteLine("\nNow let's us a foreach loop"); // The thign to remember with foreach loops is that they don't contain an index. It is printing the string for each item in the list.
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
