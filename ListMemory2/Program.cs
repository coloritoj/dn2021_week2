using System;
using System.Collections.Generic;

namespace ListMemory2
{
    class Program
    {

        static void Modify(List<string> myList)
        {
            myList.Add("Frank");
            // myList.Clear();
            // myList.Add("All done")
            // Adding these lines above would clear the list and then add "All done" to the list. It would "destroy" the original list written below in main. The "All done" line is all that would remain.
        }

        static void TestInt(int n)
        {
            n++;
            Console.WriteLine(n);
        }

        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Fred");
            names.Add("Sally");

            Modify(names); // The ADDRESS gets copied into myList from within the function(ABOVE) -- still points to the location of the same list. A change to the Modify function will still change the original list. They are still the same.

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int x = 10;
            TestInt(x); // The reason 11 is here is because it's pointing to the TestInt function memory
            Console.WriteLine(x); // The reason 10 is here is because it's pointing to the Main function memory
        }
    }
}
