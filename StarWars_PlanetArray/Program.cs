using System;
using System.Collections.Generic;

namespace StarWars_PlanetArray
{/*   * STEP 3: Create a static method named ConvertPlanets() that takes in one parameter: an array of planets
  *     // This method will convert the array of planets into a list of planets in the reverse order
  *     // Return the List
  *     */
    class Program
    {
        static void AddPlanetsToArray(string[] planetArray)
        {
            for (int i = 0; i < planetArray.Length; i++)
            {
                Console.Write($"Please enter the name of planet {i+1}/{planetArray.Length}: ");
                planetArray[i] = Console.ReadLine();
            }
        }

        static void PrintPlanetsInArray(string[] planetArray)
        {
            foreach (string planet in planetArray)
            {
                Console.WriteLine(planet);
            }
        }

        static List<string> ConvertPlanetArrayToList(string[] planetArray)
        {
            List<string> planetList = new List<string>();

            for (int i = (planetArray.Length - 1); i >= 0; i--)
            {
                planetList.Add(planetArray[i]);
            }

            return planetList;
        }

        static void PrintPlanetList(List<string> myPlanetList)
        {
            foreach (string planet in myPlanetList) // Note: myPlanetList (or whatever you call the variable) won't appear in FOREACH until you name the argument in the method
            {
                Console.WriteLine(planet);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("How many Star Wars planets would you like to enter? Please enter a number ranging from 1-10: ");
            int numberOfPlanets = int.Parse(Console.ReadLine());

            while (numberOfPlanets < 1 || numberOfPlanets > 10)
            {
                Console.Write("That is not a valid number of planets. Please enter a number ranging from 1-10: ");
                numberOfPlanets = int.Parse(Console.ReadLine());
            }

            string[] planetArray = new string[numberOfPlanets];

            AddPlanetsToArray(planetArray);

            Console.WriteLine("\nHere are the planets you entered in their original order (array): ");
            PrintPlanetsInArray(planetArray);

            Console.WriteLine("\nHere are the planets in reverse order (list): ");
            PrintPlanetList(ConvertPlanetArrayToList(planetArray));
        }
    }
}
