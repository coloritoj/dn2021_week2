using System;
using System.Collections.Generic;

namespace StarWars_Experiments
{/* ----- BUILD SPECIFICATIONS -----
  * 
  * STEP 1: Create a static method named AddStarWarsCharacters() that takes in a string[] --- COMPLETE
  *     // This method then searches for and returns the index of "Yoda". --- COMPLETE
  *     // If "Yoda" is not found in the array, return -1. --- COMPLETE
  *     
  * STEP 2: Create a static method named DeathStarCombat() that takes in a Dictionary<string, int> of Star Wars characters (key) and their attack values (value)
  *     // This method should return the name of the Jedi with the highest attack value.
  *     
  * STEP 3: Create a static method named ConvertPlanets() that takes in one parameter: an array of planets
  *     // This method will convert the array of planets into a list of planets in the reverse order
  *     // Return the List
  *     
  * STEP 4: Create a static method named AverageDroids() that takes in an integer List for droids
  *     // The method will search through the list and calculate the average of all even-numbered droids
  *     // Return the average
  *     // Hint: Create another list to store the even numbers in. What do you think an average will return?
  * 
  * STEP 5: Create a static method named TryToCatchDarthVader(). This method will take in a string as a parameter and parse that string as an integer.
  *     // Return "Vader Was Captured!" if the parse is successful
  *     // Return "Vader Got Away!" if FormatException is thrown.
  *     // Hint: Use a Try-Catch
  *     
  * When finished, push the project up to the repository on GitHub.
  */

    class Program
    {

        static Dictionary<string, int> GetJediStats()
        {
            Dictionary<string, int> jediStats = new Dictionary<string, int>();

            Console.Write("How many Jedi would you like to compare? Please enter a number between 1 and 5: ");
            int numberOfJedi = int.Parse(Console.ReadLine());

            while (numberOfJedi < 1 || numberOfJedi > 5)
            {
                Console.Write("That was not a valid number of Jedi. Please enter a number between 1 and 5: ");
                numberOfJedi = int.Parse(Console.ReadLine());
            }

            string jediName = "";
            int jediAttackPower = 0;

            for (int i = 0; i < numberOfJedi; i++)
            {
                Console.Write($"\nPlease enter the name of Jedi {i + 1 }/{numberOfJedi}: ");
                jediName = Console.ReadLine();
                Console.Write($"What is {jediName}'s attack power? Please enter a number between 1 and 100: ");
                jediAttackPower = int.Parse(Console.ReadLine());
                jediStats.Add(jediName, jediAttackPower);
            }
            return jediStats;
        }

        static void PrintJediStats(Dictionary<string, int> jediStats)
        {
            foreach (var pair in jediStats)
            {
                Console.WriteLine($"{pair.Key}'s attack power is {pair.Value}");
            }
        }

        static string FindStrongestJedi(Dictionary<string, int> jediStats)
        {
            int highestAttackPower = 0;
            string strongestJedi = "";
            foreach (var pair in jediStats)
            {
                if (pair.Value > highestAttackPower)
                {
                    highestAttackPower = pair.Value;
                    strongestJedi = $"\nThe most powerful Jedi in your list is {pair.Key} with {pair.Value} attack power";
                }
            }
            return strongestJedi;
        }

        static void Main(string[] args)
        {
            Dictionary<string, int> myJedi = GetJediStats();
            Console.WriteLine("\nHere is the information about your Jedi:");
            PrintJediStats(myJedi);
            Console.WriteLine(FindStrongestJedi(myJedi));
        }
    }
}
