using System;

namespace StudentDatabase_FINAL
{ 
 /* ----- DIRECTIONS -----
 * 
 * ----- WHAT WILL THE APPLICATION DO? -----
 * 2 POINTS: Create 3 arrays and fill them with student information. One with NAME, one with HOMETOWN, and one with FAVORITE FOOD. (3-15 datasets) --- COMPLETE
 * 1 POINT: Prompt the user to ask about a particular student BY NUMBER. Convert the input to an integer. as the index for the arrays. Print the student's name. --- COMPLETE
 * 1 POINT: Ask the user which category to display: HOMETOWN or FAVORITE FOOD. Then display the relevant information. --- COMPLETE
 * 1 POINT: Ask the user if they would like to learn about another student. --- COMPLETE
 * 
 * ----- BUILD SPECIFICATIONS -----
 * 1 POINT: Validate user number. Use an if statement to check if the number is out of range (i.e.: either less than 0 or greater than the maximum index of the arrays. IF so, display a friendly message and let the user try again.
 * 1 POINT: Validate category. Ask the user what information category to display: "Hometown" or "Favorite Food". Use an if statement to check that they entered either category name correctly. IF they entered an incorrect category, display a friendly message and re-ask the question. --- COMPLETE
 * 1 POINT: Array length. USe the first array's .Length property in your code instead of hardcoding it. --- COMPLETE
 * 
 * ----- HINTS ----
 * Make sure that all of the arrays are the same size.
 * Let the user enter a number from 1 up to and including the length of the array. To get the index, subtract 1 from the number they entered.
 * Make it easy for the user: tell them what information is available.
 * Try to use good grammar. Make your messages polite.
 * 
 * ----- EXTRA CHALLENGES -----
 * 1 POINT: Provide an option where the user can see a list of all students. --- COMPLETE
 * 2 POINTS: Allow the user to search by student name. --- DID NOT COMPLETE
 * 1 POINT: For the category names, allow uppercase and lowercase. Also, also allow a portion of the word such as "Food" instead of "Favorite Food". --- DID NOT COMPLETE
 */
    class Program
    {
        static bool GoAgain()
        {
            while (true)
            {

                Console.Write("Would you like to learn about another student? (yes/no): ");
                string entry = Console.ReadLine();
                if (entry.ToLower() == "no")
                {
                    return false;
                }
                if (entry.ToLower() == "yes")
                {
                    return true;
                }
                Console.WriteLine("I'm sorry but I don't know what that means.");
            }
        }

        static int ConvertStudentNumber(string[] studentNameArray, string number)
        {
            int numberEntered = Int32.Parse(number);
            if (numberEntered >= 0 && numberEntered <= studentNameArray.Length)
            {
                numberEntered = numberEntered - 1;
                return numberEntered;
            }
            else
            {
                numberEntered = -1;
                while (numberEntered == -1)
                {
                    Console.Write("That's an invalid number. Please enter a number between 1 and 5: ");
                    numberEntered = Int32.Parse(Console.ReadLine());
                    if (numberEntered >= 0 && numberEntered <= studentNameArray.Length)
                    {
                        numberEntered = numberEntered - 1;
                    }
                    else
                    {
                        numberEntered = -1;
                    }
                }
            } return numberEntered;
        }

        static bool ValidNextStep(string nextStep)
        {
            if (nextStep == "hometown")
            {
                return true;
            }
            else if (nextStep == "favorite food")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            string[] studentName = new string[] { "Audra", "Brad", "Chris", "Danielle", "Eva" };
            string[] studentHometown = new string[] { "Pittsburgh", "Detroit", "Houston", "Tampa", "Boston" };
            string[] studentFavoriteFood = new string[] { "Pizza", "Burgers", "Spaghetti", "Chicken", "Steak" };

            do
            {
                Console.Write("Would you like to see the names of the students? (yes/no): ");
                string displayNames = Console.ReadLine();

                if (displayNames == "yes")
                {
                    for (int i = 0; i < studentName.Length; i++)
                    {
                        Console.WriteLine($"Student {i + 1} is {studentName[i]}.");
                    }
                }

                Console.Write("Please enter a student number between 1 and 5: ");
                string numberEntered = Console.ReadLine();
                int studentNumber = ConvertStudentNumber(studentName, numberEntered);

                if (studentNumber == -1)
                {
                    Console.WriteLine("That's an invalid number. Please enter a number between 1 and 5: ");
                    while (studentNumber == -1)
                    {
                        numberEntered = Console.ReadLine();
                        studentNumber = ConvertStudentNumber(studentName, numberEntered);
                    }
                }
                else
                {
                    Console.WriteLine($"You selected {studentName[studentNumber]}.");
                    Console.Write($"What would you like to display next about {studentName[studentNumber]}? (Hometown/Favorite Food): ");
                    string nextStep = Console.ReadLine().ToLower();
                    bool nextEntryValid = ValidNextStep(nextStep);

                    while (nextEntryValid == false)
                    {
                        Console.Write("I'm sorry, but I do not understand what that means. Please enter 'Hometown' or 'Favorite Food': ");
                        nextStep = Console.ReadLine().ToLower();
                        nextEntryValid = ValidNextStep(nextStep);
                    }

                    if (nextEntryValid == true)
                    {
                        if (nextStep == "hometown")
                        {
                            Console.WriteLine($"{studentName[studentNumber]}'s hometown is {studentHometown[studentNumber]}.");
                        }
                        else
                        {
                            Console.WriteLine($"{studentName[studentNumber]}'s favorite food is {studentFavoriteFood[studentNumber]}.");
                        }
                    }
                }
            } while (GoAgain());          

        }
    }
}
