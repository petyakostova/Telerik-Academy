using System;

class Gambling
{
    static void Main()
    {
        double cash = double.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int strength = 0;

        string[] cards = input.Split(' ');  // split the input and put every card in array
        for (int i = 0; i < cards.Length; i++)
        {
            switch (cards[i])
            {
                case "J":
                    strength += 11;
                    break;
                case "Q":
                    strength += 12;
                    break;
                case "K":
                    strength += 13;
                    break;
                case "A":
                    strength += 14;
                    break;
                default:
                    strength += int.Parse(cards[i]);
                    break;
            }
        }

        double greaterHands = 0;
        int totalHands = 0;
        for (int card1 = 2; card1 <= 14; card1++)
        {
            for (int card2 = 2; card2 <= 14; card2++)
            {
                for (int card3 = 2; card3 <= 14; card3++)
                {
                    for (int card4 = 2; card4 <= 14; card4++)
                    {
                        int currentHandStrength = card1 + card2 + card3 + card4;
                        if (currentHandStrength > strength)
                        {
                            greaterHands++;
                        }
                        totalHands++;
                    }
                }
            }
        }

        double chance = greaterHands / totalHands;

        if (chance < 0.5)
        {
            Console.WriteLine("FOLD");
        }
        else
        {
            Console.WriteLine("DRAW");
        }

        Console.WriteLine("{0:0.00}", 2 * cash * chance);
    }
}