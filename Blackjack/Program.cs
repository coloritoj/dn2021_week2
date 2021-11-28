using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static int TranslateCard(string card)
        {
            int cardValue = 0;
            if (card == "Ace of Spades" || card == "Ace of Hearts" || card == "Ace of Clubs" || card == "Ace of Diamonds")
            {
                cardValue = 1;
            }
            else if (card == "2 of Spades" || card == "2 of Hearts" || card == "2 of Clubs" || card == "2 of Diamonds")
            {
                cardValue = 2;
            }
            else if (card == "3 of Spades" || card == "3 of Hearts" || card == "3 of Clubs" || card == "3 of Diamonds")
            {
                cardValue = 3;
            }
            else if (card == "4 of Spades" || card == "4 of Hearts" || card == "4 of Clubs" || card == "4 of Diamonds")
            {
                cardValue = 4;
            }
            else if (card == "5 of Spades" || card == "5 of Hearts" || card == "5 of Clubs" || card == "5 of Diamonds")
            {
                cardValue = 5;
            }
            else if (card == "6 of Spades" || card == "6 of Hearts" || card == "6 of Clubs" || card == "6 of Diamonds")
            {
                cardValue = 6;
            }
            else if (card == "7 of Spades" || card == "7 of Hearts" || card == "7 of Clubs" || card == "7 of Diamonds")
            {
                cardValue = 7;
            }
            else if (card == "8 of Spades" || card == "8 of Hearts" || card == "8 of Clubs" || card == "8 of Diamonds")
            {
                cardValue = 8;
            }
            else if (card == "9 of Spades" || card == "9 of Hearts" || card == "9 of Clubs" || card == "9 of Diamonds")
            {
                cardValue = 9;
            }
            else if (card == "10 of Spades" || card == "10 of Hearts" || card == "10 of Clubs" || card == "10 of Diamonds")
            {
                cardValue = 10;
            }
            else if (card == "Jack of Spades" || card == "Jack of Hearts" || card == "Jack of Clubs" || card == "Jack of Diamonds")
            {
                cardValue = 10;
            }
            else if (card == "Queen of Spades" || card == "Queen of Hearts" || card == "Queen of Clubs" || card == "Queen of Diamonds")
            {
                cardValue = 10;
            }
            else if (card == "King of Spades" || card == "King of Hearts" || card == "King of Clubs" || card == "King of Diamonds")
            {
                cardValue = 10;
            }
            return cardValue;
        }

        static List<string> CreateListFromArray(string[] shoeCards)
        {
            List<string> myCards = new List<string>();

            for (int i = 0; i < shoeCards.Length; i++)
            {
                myCards.Add(shoeCards[i]);
            }

            return myCards;
        }


        static void Main(string[] args)
        {
            Random randomCard = new Random();

            Console.Write("How much is your starting bankroll?: $");
            int bankroll = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your bankroll is ${bankroll}.00");

            Console.Write("\nHow much would you like to wager?: $");
            int wager = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your wager is ${wager}.00");
            Console.Write($"Your remaining bankroll is ${bankroll - wager}.00");

            string[] arrayOfCards = new string[] {
                "Ace of Spades", "Ace of Hearts", "Ace of Clubs", "Ace of Diamonds",
                "2 of Spades", "2 of Hearts", "2 of Clubs", "2 of Diamonds",
                "3 of Spades", "3 of Hearts", "3 of Clubs", "3 of Diamonds",
                "4 of Spades", "4 of Hearts", "4 of Clubs", "4 of Diamonds",
                "5 of Spades", "5 of Hearts", "5 of Clubs", "5 of Diamonds",
                "6 of Spades", "6 of Hearts", "6 of Clubs", "6 of Diamonds",
                "7 of Spades", "7 of Hearts", "7 of Clubs", "7 of Diamonds",
                "8 of Spades", "8 of Hearts", "8 of Clubs", "8 of Diamonds",
                "9 of Spades", "9 of Hearts", "9 of Clubs", "9 of Diamonds",
                "10 of Spades", "10 of Hearts", "10 of Clubs", "10 of Diamonds",
                "Jack of Spades", "Jack of Hearts", "Jack of Clubs", "Jack of Diamonds",
                "Queen of Spades", "Queen of Hearts", "Queen of Clubs", "Queen of Diamonds",
                "King of Spades", "King of Hearts", "King of Clubs", "King of Diamonds"
                };

            List<string> shoeCardsList = CreateListFromArray(arrayOfCards);

            int positionOfCard = randomCard.Next(shoeCardsList.Count - 1);
            string playerCardOne = shoeCardsList[positionOfCard];
            int valueCardOne = TranslateCard(playerCardOne);
            shoeCardsList.Remove(shoeCardsList[positionOfCard]);

            positionOfCard = randomCard.Next(shoeCardsList.Count - 1);
            string dealerDownCard = shoeCardsList[positionOfCard];
            int dealerValueCardOne = TranslateCard(dealerDownCard);
            shoeCardsList.Remove(shoeCardsList[positionOfCard]);

            positionOfCard = randomCard.Next(shoeCardsList.Count - 1);
            string playerCardTwo = shoeCardsList[positionOfCard];
            int valueCardTwo = TranslateCard(playerCardTwo);
            shoeCardsList.Remove(shoeCardsList[positionOfCard]);

            positionOfCard = randomCard.Next(shoeCardsList.Count - 1);
            string dealerUpCard = shoeCardsList[positionOfCard];
            int dealerValueCardTwo = TranslateCard(dealerUpCard);
            shoeCardsList.Remove(shoeCardsList[positionOfCard]);

            int sumOfPlayersHand = valueCardOne + valueCardTwo;
            int sumOfDealersHand = dealerValueCardOne + dealerValueCardTwo;


            Console.WriteLine($"\n\nYour first card is: {playerCardOne}");
            Console.WriteLine($"Your second card is: {playerCardTwo}");
            Console.WriteLine($"The value of your hand is: {sumOfPlayersHand}");
            Console.WriteLine($"\nThe dealer's upcard is: {dealerUpCard}");
            Console.WriteLine($"The current value of the dealer's hand is: {dealerValueCardTwo}");

            Console.Write("What would you like to do? (STAND, HIT, DD): ");
            string playerDecision = Console.ReadLine().ToLower();
            string dealerNextCard = "";
            int dealerValueNextCard = 0;
            int amountWon = 0;


            if (playerDecision == "stand")
            {
                Console.WriteLine("You decided to STAND");
                Console.WriteLine($"The dealer's downcard is {dealerDownCard}");
                Console.WriteLine($"The dealer's current total is {sumOfDealersHand}");

                while (sumOfDealersHand <= 16)
                {
                    positionOfCard = randomCard.Next(shoeCardsList.Count - 1);
                    dealerNextCard = shoeCardsList[positionOfCard];
                    dealerValueNextCard = TranslateCard(dealerNextCard);
                    shoeCardsList.Remove(shoeCardsList[positionOfCard]);
                    sumOfDealersHand += dealerValueNextCard;

                    Console.WriteLine($"The dealer drew another card and pulled a {dealerNextCard}");
                    Console.WriteLine($"The current value of the dealer's hand is: {sumOfDealersHand}");
                }

                if (sumOfDealersHand >= 17 && sumOfDealersHand <= 21)
                {
                    Console.WriteLine($"The dealer ended their hand with a value of {sumOfDealersHand}");
                }
                else
                {
                    Console.WriteLine("The dealer busted!");
                }

                if (sumOfPlayersHand > sumOfDealersHand)
                {
                    amountWon = wager * 2;
                    bankroll += amountWon;
                    Console.WriteLine($"Your hand was higher than the dealer's. YOU WIN ${amountWon}.00!");
                    Console.WriteLine($"Your bankroll is now ${bankroll}.00");
                }
                else if (sumOfDealersHand > 21)
                {
                    amountWon = wager * 2;
                    bankroll += amountWon;
                    Console.WriteLine($"The dealer busted. YOU WIN ${amountWon}.00!");
                    Console.WriteLine($"Your bankroll is now ${bankroll}.00");
                }
                else if (sumOfPlayersHand == sumOfDealersHand)
                {
                    Console.WriteLine("You PUSH!");
                }
                else
                {
                    Console.WriteLine("You LOSE!");
                }
            }
            else if (playerDecision == "hit")
            {
                Console.WriteLine("You decided to HIT");
            }
            else if (playerDecision == "dd")
            {
                Console.WriteLine("You decided to DOUBLE DOWN");
            }

            Console.WriteLine("\nThe cards remaining are...");
            foreach (string card in shoeCardsList)
            {
                Console.WriteLine(card);
            }

        }
    }
}
