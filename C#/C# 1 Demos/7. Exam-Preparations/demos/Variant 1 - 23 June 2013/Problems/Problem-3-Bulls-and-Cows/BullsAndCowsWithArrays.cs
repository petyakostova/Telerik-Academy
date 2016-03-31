using System;

class BullsAndCowsWithArrays
{
    static void Main()
    {
        string guessNum = Console.ReadLine();
        int targetBulls = int.Parse(Console.ReadLine());
        int targetCows = int.Parse(Console.ReadLine());

        bool solutionFound = false;

        // Check all possible 4-digit numbers
        for (int candidate = 1; candidate <= 9999; candidate++)
        {
            char[] digits = candidate.ToString().ToCharArray();
            if (digits.Length == 4 && digits[0] >= '1' &&
                digits[1] >= '1' && digits[2] >= '1' && digits[3] >= '1')
            {
                char[] guess = guessNum.ToCharArray();
                int bulls = 0;
                int cows = 0;
                
                // Count the bulls and mark them as unavailable
                for (int i = 0; i < guess.Length; i++)
                {
                    if (guess[i] == digits[i])
                    {
                        bulls++;
                        guess[i] = '*';
                        digits[i] = '@';
                    }
                }

                // Count the cows and mark them as unavailable
                for (int guessIndex = 0; guessIndex < guess.Length; guessIndex++)
                {
                    for (int digitsIndex = 0; digitsIndex < digits.Length; digitsIndex++)
                    {
                        if (guess[guessIndex] == digits[digitsIndex])
                        {
                            cows++;
                            guess[guessIndex] = '*';
                            digits[digitsIndex] = '@';
                        }
                    }
                }

                // Print the configuration if the bulls and cows match the target
                if (bulls == targetBulls && cows == targetCows)
                {
                    if (solutionFound)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(candidate);
                    solutionFound = true;
                }
            }
        }

        if (!solutionFound)
        {
            Console.WriteLine("No");
        }
    }
}
