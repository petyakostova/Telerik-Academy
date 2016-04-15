/* 4. Print a Deck of 52 Cards - Using for Loops, switch and if-else
   Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the classical notation (like 5 of spades♠, A of hearts♥, 9 of clubs♣; and K of diamonds♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
   Input: On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.
   Output: The output should follow the format bellow(assume our input is 5): 2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds 3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds ... 5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds
   Constraints: The input character will always be a valid card sign.  */

using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        string sign = Console.ReadLine();

        int n;
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

        int count = 0;
        for (int card = 2; card <= n; card++)
        {
            for (int suit = 1; suit < 5; suit++)
            {
                switch (card)
                {
                    case 11:
                        Console.Write("J");
                        break;
                    case 12:
                        Console.Write("Q");
                        break;
                    case 13:
                        Console.Write("K");
                        break;
                    case 14:
                        Console.Write("A");
                        break;
                    default:
                        Console.Write("{0}", card);
                        break;
                }
                count++;

                // using text for the suits
                switch (suit)
                {
                    case 1: Console.Write(" of spades"); break;
                    case 2: Console.Write(" of clubs"); break;
                    case 3: Console.Write(" of hearts"); break;
                    case 4: Console.Write(" of diamonds"); break;
                }
                // other way: using the suit symbols instead of text
                //switch (suit)
                //{
                //    case 1: Console.Write("♠ "); break;
                //    case 2: Console.Write("♣ "); break;
                //    case 3: Console.Write("♥ "); break;
                //    case 4: Console.Write("♦ "); break;
                //}    

                if (count % 4 != 0)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

    }
}