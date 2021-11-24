using System;
using System.Collections.Generic;

namespace ArrayListPractice
{
    class Program
    {

        static List<string> CreateList(string first, string second, string third)
        {
            List<string> result = new List<string>();
            result.Add(first);
            result.Add(second);
            result.Add(third);
            return result;
        }

        static void PrintList(List<string> myList)
        {
            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }
        }

        static string GetLast(List<string> myList)
        {
            int length = myList.Count;
            return myList[length - 1];
        }

        static string GetArrayLast(string[] myArray)
        {
            int length = myArray.Length; // For arrays we use "Length" - for lists we use "Count"
            return myArray[length - 1];
        }

        static void Plural(string[] myArray)
        {
            // Add an s to the end of each string in the array
            /* CAN'T USE FOREACH BECAUSE C# DOESN'T LET US CHANGE THE LOOP VARIABLE
            foreach (string word in myArray)
            {
                word = word + "s";
            }*/

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = myArray[i] + "s";
            }
        }

        static int Average(List<int> nums)
        {
            // Example: 3, 4, 5
            // 1. Add them up to get 12
            // 2. Divide by how many there are: 12 / 3 = 4

            int sum = 0;
            foreach (int item in nums)
            {
                sum += item;
            }
            return sum / nums.Count;
        }

        static void Main(string[] args)
        {
            List<string> words = CreateList("apple", "banana", "cranberry");
            PrintList(words);
            Console.WriteLine("\nLet's get the last item...");
            string last = GetLast(words);
            Console.WriteLine(last);

            Console.WriteLine("\nLet's get the last item from an array!");
            string[] moreWords = new string[] { "Fred", "Sally", "Julia" };
            string nameLast = GetArrayLast(moreWords);
            Console.WriteLine(nameLast);

            Console.WriteLine("\nPlurals:");
            Plural(moreWords);
            foreach (string name in moreWords)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nAverage!");
            List<int> myNumbers = new List<int>();
            myNumbers.Add(3);
            myNumbers.Add(4);
            myNumbers.Add(5);
            Console.WriteLine(Average(myNumbers));
        }
    }
}
