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
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 2; j <= 14; j++)
            {
                for (int k = 2; k <= 14; k++)
                {
                    for (int m = 2; m <= 14; m++)
                    {
                        int currentHandStrength = i + j + k + m;
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