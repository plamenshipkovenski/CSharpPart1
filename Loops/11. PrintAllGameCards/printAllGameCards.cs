using System;
using System.Collections.Generic;

class PrintAllGameCards
{
    static void Main()
    {
        Console.Title = "print playing cards names";

        string[] suits = 
        {
            "spades",
            "hearts",
            "diamonds",
            "clubs",
        };

        string[] cardNames = 
        {
            "Two", 
            "Three", 
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Jack",
            "Queen",
            "King",
            "Ace",
        };

        int deckLength = 52;
        List<string> standartPokerDeck = new List<string>();

        for (int cardIndex = deckLength; cardIndex >= 0; cardIndex--)
        {
            string cardName = "";
            cardName = cardNames[cardIndex % cardNames.Length];

            for (int suitIndex = 0; suitIndex < suits.Length; suitIndex++)
            {
                string suit = "";
                suit = suits[suitIndex % suits.Length];
                standartPokerDeck.Add(cardName + " of " + suit);
            }
        }

        foreach (var card in standartPokerDeck)
        {
            Console.WriteLine(card);
        }
    }
}
