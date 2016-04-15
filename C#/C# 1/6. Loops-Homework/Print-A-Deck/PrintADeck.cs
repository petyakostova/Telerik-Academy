/* 4. Print a Deck of 52 Cards - using Array
   Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the classical notation (like 5 of spades♠, A of hearts♥, 9 of clubs♣; and K of diamonds♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
   Input: On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.
   Output: The output should follow the format bellow(assume our input is 5): 2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds 3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds ... 5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds
   Constraints: The input character will always be a valid card sign.  */

using System;

class PrintADeck
{
    static void Main()
    {
        string sign = Console.ReadLine();

        int n = 0;
        switch (sign)
        {
            case "J":
                n = 11;
                break;
            case "Q":
                n = 12;
                break;
            case "K":
                n = 13;
                break;
            case "A":
                n = 14;
                break;
            default:
                n = int.Parse(sign);
                break;
        }

        string[] deck = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        for (int i = 0; i <= n - 2; i++)
        {
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", deck[i]);
        }

    }
}