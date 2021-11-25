using System;
using System.Collections.Generic;

namespace ExceptionDemo
{ // Jeff's opinion is that exception handling isn't very useful. People use them as a crutch. It's better to just fix the code (ex: validate input) than to throw exceptions/messages when they don't enter something correctly.
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Fred");
            names.Add("Sally");
            names.Add("Julia");

            /* Console.Write("Who is going next? Please enter a number: ");
            string entry = Console.ReadLine();

            int num = 0;
            try
            {
                num = int.Parse(entry);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hey that isn't a number!!");
            }


            try
            {
                Console.WriteLine(names[num]); // In Jeff's opinion, blindly calling names[num] is similar to getting a phishing email from an email that looks like your bank and entering your info without verifying if the bank is asking for it.
            }
            catch (Exception ex) // The ex here is a variable for Exception
            {
                // The following commented-out lines really aren't very user friendly.
                // Console.WriteLine("An error occurred!!!");
                // Console.WriteLine(ex.Message);
                Console.WriteLine($"Please enter a number between 0 and {names.Count - 1}");
            } 

            int num = 0;
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Write($"Who is going next? Please enter a number 0 and {names.Count -1}: ");
                string entry = Console.ReadLine();
                // int num = 0; -- Moving int num = 0 about the while loop
                if (int.TryParse(entry, out num) == false)      // TryParse is basically a bool. It returns True if the statement is true/works. It returns False if it doesn't. (It's taking the string ENTRY and the OUT means it's trying to put that STRING into an INT).
                {
                    Console.WriteLine("That isn't a number!");
                    Console.WriteLine("Please try again!");
                }
                else
                {
                    // Now we know it's a valid number. Now let's make sure it's inside the correct range.
                    if (num >= 0 && num < names.Count)
                    {
                        keepGoing = false;
                    }
                    else
                    {
                        Console.WriteLine($"Although that's a number, it's not in the correct range. Please enter between 0 and {names.Count - 1}.");
                    }

                }
            }
            Console.WriteLine($"Thank you! You entered {num}");




        }
    }
}
