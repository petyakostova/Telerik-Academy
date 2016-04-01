using System;
using System.Numerics;

public class CardWarsBatka
{
    public static void Main()
    {
		// Global game counters
		BigInteger firstPlayerScore = 0;
        BigInteger secondPlayerScore = 0;
        int firstPlayerGamesWon = 0;
        int secondPlayerGamesWon = 0;
        bool theXCardDrawnByFirstPlayer = false;
        bool theXCardDrawnBySecondPlayer = false;

		int numberOfGames = int.Parse(Console.ReadLine());
		for (int i = 0; i < numberOfGames; i++)
        {
            // Current game counters
            int firstPlayerHandStrength = 0;
            int secondPlayerHandStrength = 0;

            // First player cards proccessor
            for (int j = 0; j < 3; j++)
            {
                string firstPlayerCard = Console.ReadLine();

                switch (firstPlayerCard)
                {
                    case "A": firstPlayerHandStrength += 1; 
                        break;
                    case "J": firstPlayerHandStrength += 11; 
                        break;
                    case "Q": firstPlayerHandStrength += 12; 
                        break;
                    case "K": firstPlayerHandStrength += 13; 
                        break;
                    case "Z": firstPlayerScore *= 2; 
                        break;
                    case "Y": firstPlayerScore -= 200; 
                        break;
                    case "X": theXCardDrawnByFirstPlayer = true; 
                        break;
                    default: firstPlayerHandStrength += 12 - int.Parse(firstPlayerCard);
                        break;
                }
            }

            // Second player cards proccessor
            for (int j = 0; j < 3; j++)
            {
                string secondPlayerCard = Console.ReadLine();

                switch (secondPlayerCard)
                {
                    case "A": secondPlayerHandStrength += 1; 
                        break;
                    case "J": secondPlayerHandStrength += 11; 
                        break;
                    case "Q": secondPlayerHandStrength += 12; 
                        break;
                    case "K": secondPlayerHandStrength += 13; 
                        break;
                    case "Z": secondPlayerScore *= 2; 
                        break;
                    case "Y": secondPlayerScore -= 200; 
                        break;
                    case "X": theXCardDrawnBySecondPlayer = true; 
                        break;
                    default: secondPlayerHandStrength += 12 - int.Parse(secondPlayerCard);
                        break;
                }
            }

            // Special cards check: process the "X" card
            if (theXCardDrawnByFirstPlayer && theXCardDrawnBySecondPlayer)
            {
                firstPlayerScore += 50;
                secondPlayerScore += 50;
            }
            else if (theXCardDrawnByFirstPlayer)
            {
                break;
            }
            else if (theXCardDrawnBySecondPlayer)
            {
                break;
            }

            // Calculate the winner
            if (firstPlayerHandStrength > secondPlayerHandStrength)
            {
                firstPlayerScore += firstPlayerHandStrength;
                firstPlayerGamesWon++;
            }
            else if (firstPlayerHandStrength < secondPlayerHandStrength)
            {
                secondPlayerScore += secondPlayerHandStrength;
                secondPlayerGamesWon++;
            }

            // Reset the counters for the next game
            firstPlayerHandStrength = 0;
            secondPlayerHandStrength = 0;
            theXCardDrawnByFirstPlayer = false;
            theXCardDrawnBySecondPlayer = false; 
        }

        // Print the results at the console
        if (theXCardDrawnByFirstPlayer)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
        }
        else if (theXCardDrawnBySecondPlayer)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
        }
        else if (firstPlayerScore > secondPlayerScore)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", firstPlayerScore);
            Console.WriteLine("Games won: {0}", firstPlayerGamesWon);
        }
        else if (firstPlayerScore < secondPlayerScore)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", secondPlayerScore);
            Console.WriteLine("Games won: {0}", secondPlayerGamesWon);
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", firstPlayerScore);
        }
    }
}
