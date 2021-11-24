using System;
using System.Collections.Generic; // type using space sys tab dot col tab dot g tab

namespace ListMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(); // Technically speaking, names isn't holding a list, it's holding an ADDRESS to a list in global variable storage

            names.Add("Fred");
            names.Add("Sally");

            List<string> more;
            more = names;

            Console.WriteLine(more[0]); // Prints/references "Fred"

            more[0] = "Frank";

            Console.WriteLine(names[0]); // Prints/refrences "Frank" -- even though we have two variables, they are pointing to the same list. Any changes to one list will change the other list as well.

            names.Add("Harold");

            Console.WriteLine("Print out the list names points to: ");

            foreach (string word in names)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Print out the list more points to: ");
            foreach (string word in more)
            {
                Console.WriteLine(word);
            }
        }
    }
}
