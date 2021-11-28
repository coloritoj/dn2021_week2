using System;

namespace CasinoDiceRoller_Experiment
{
    class Program
    {
        static int RandomNumber(int diceSides)
        {
            Random randomNumber = new Random();
            int diceRoll = randomNumber.Next(1, diceSides + 1);
            return diceRoll;
        }

        static string SixSidedDiceMessage(int rollOne, int rollTwo)
        {
            string diceMessage = "";
            int sumOfRolls = rollOne + rollTwo;

            if (rollOne == 1 && rollTwo == 1)
            {
                diceMessage = "Snake Eyes \nCraps!";
            }
            else if ((rollOne == 1 && rollTwo == 2) || (rollOne == 2 && rollTwo == 1))
            {
                diceMessage = "Ace Deuce \nCraps!";
            }
            else if (rollOne == 6 && rollTwo == 6)
            {
                diceMessage = "Boxcars \nCraps!";
            }
            else if (sumOfRolls == 7 || sumOfRolls == 11)
            {
                diceMessage = "Win!";
            }
            else
            {
                diceMessage = "";
            }
            return diceMessage;
        }

        static string NonSixSidedDiceMessage(int rollOne, int rollTwo)
        {
            string nonSixDiceMessage = "";
            if (rollOne == 9 && rollTwo == 9)
            {
                nonSixDiceMessage = "You are going to Germany!";
            }
            else if (rollOne == 8 && rollTwo == 8)
            {
                nonSixDiceMessage = "You are going to Spain!";
            }
            else if (rollOne == 7 && rollTwo == 7)
            {
                nonSixDiceMessage = "You are going to Canada!";
            }
            else if (rollOne == 6 && rollTwo == 6)
            {
                nonSixDiceMessage = "You are going to Russia!";
            }
            else if (rollOne == 5 && rollTwo == 5)
            {
                nonSixDiceMessage = "You are going to China!";
            }
            else if (rollOne == 4 && rollTwo == 4)
            {
                nonSixDiceMessage = "You are going to Japan!";
            }
            else if (rollOne == 3 && rollTwo == 3)
            {
                nonSixDiceMessage = "You are going to Mexico!";
            }
            else if (rollOne == 2 && rollTwo == 2)
            {
                nonSixDiceMessage = "You are going to France!";
            }
            else if (rollOne == 1 && rollTwo == 1)
            {
                nonSixDiceMessage = "You are going to the USA!";
            }
            else
            {
                nonSixDiceMessage = "You aren't going anywhere";
            }
            return nonSixDiceMessage;
        }

        static void Main(string[] args)
        {
            string goAgain = "yes";

            do
            {
                Console.Write("How many sides does your dice have?: ");
                int diceSides = int.Parse(Console.ReadLine());
                Console.WriteLine($"Your dice has {diceSides} sides");

                int rollOne = RandomNumber(diceSides);
                int rollTwo = RandomNumber(diceSides);
                int sumOfRolls = rollOne + rollTwo;

                Console.WriteLine($"Dice 1 result: {rollOne}");
                Console.WriteLine($"Dice 2 result: {rollTwo}");
                Console.WriteLine($"The sum of your rolls: {sumOfRolls}");

                string message = "";

                if (diceSides == 6)
                {
                    message = SixSidedDiceMessage(rollOne, rollTwo);
                }
                else
                {
                    message = NonSixSidedDiceMessage(rollOne, rollTwo);
                }

                Console.WriteLine(message);
                Console.Write("\nWould you like to roll again? (yes/no): ");
                goAgain = Console.ReadLine().ToLower();
            } while (goAgain == "yes");

        }
    }
}

/* ---- WHAT WILL THE APPLICATION DO? -----
 * Asks user to enter the number of sides for a pair of dice
 * Prompts the user to roll the dice
 * "Rolls" two n-sided dice, displaying the results of each along with a total
 * For 6-sided dice, the application recognizes the following dice combinations and displays a message for each (it should not perform this for any other size):
 * ... Snake Eyes: Two 1s
 * ... Ace Deuce: A 1 and and 2
 * ... Box Cars: Two 6s
 * ... Win: Total of 7 or 11
 * ... Craps: Total of 2, 3, or 12 (will also generate another message)
 * Asks the user if they want to roll the dice again
 * 
 * ----- BUILD SPECIFICATIONS -----
 * Create a static Random variable so you only have one Random variable for the whole app
 * Create a static method to generate the random numbers
 * 2 POINTS: Proper method header
 * 1 PONT: Program generates random numbers validly within the user-specificed range
 * 1 POINT: Method returns meaningful value of proper type
 * Create a static method for six-sided dice that takes two dice values as parameters and returns a string for one of the valid combinations (e.g.: Snake Eyes) or an empty string if the dice don't match one of the combinations
 * Create a static method to implement output for difference dice combinations
 * 2 POINTS: Proper method header
 * 1 POINT: Method recognizes all specified cases correctly
 * 1 POINT: Displays properly to console
 * 
 * 1 POINT: Application takes all user input correctly
 * 1 POINT: Application loops properly
 * 
 * ----- HINTS -----
 * Use the Random class to generate a random number
 * Create only one instance of the Random class
 * 
 * ----- EXTRA CHALLENGES -----
 * Come up with a set of winning combinations for other dice besides 6
 */