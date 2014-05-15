using System;
using System.Text;
//11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.
class Program
{
    static void Main()
    {
        string[] colors = new string[4] { "Spades", "Diamonds", "Hearts", "Clubs" };
        string[] cards = new string[13] { "Ace of", "Two of", "Three of", "Four of", "Five of", "Six of", "Seven of", "Eight of", "Nine of", "Ten of", "Jack of", "Queen of", "King of" };

        for (int color = 0; color < 4; color++)
        {
            for (int card = 0; card < 13; card++)
            {
                Console.WriteLine(cards[card] + " " + colors[color]);
            }
            Console.WriteLine();
        }
    }
}

