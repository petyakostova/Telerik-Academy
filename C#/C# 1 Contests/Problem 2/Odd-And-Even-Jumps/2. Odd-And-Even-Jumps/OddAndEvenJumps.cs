using System;

class OddAndEvenJumps
{
    static void Main()
    {
        // String.Split() returns array
        string[] unprocessedInput = Console.ReadLine()
            .ToLower()                                                              // lowercase
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        // transform it into one string without intervals
        string input = string.Join("", unprocessedInput); 

        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        long oddResult = 0;
        long evenResult = 0;
        int currentJumpPos = 1;

        // Odd characters
        for (int i = 0; i < input.Length; i += 2)
        {
            long currentSymbolCode = input[i];
            if (currentJumpPos == oddJump)
            {
                oddResult *= currentSymbolCode;
                currentJumpPos = 1; // reset the counter
            }
            else
            {
                oddResult += currentSymbolCode;
                currentJumpPos++;
            }
        }

        currentJumpPos = 1; // reset the counter, for the even positions

        // Even characters
        for (int i = 1; i < input.Length; i += 2)
        {
            long currentSymbolCode = input[i];
            if (currentJumpPos == evenJump)
            {
                evenResult *= currentSymbolCode;
                currentJumpPos = 1;
            }
            else
            {
                evenResult += currentSymbolCode;
                currentJumpPos++;
            }
        }

        Console.WriteLine("Odd: {0:X}", oddResult); 
        Console.WriteLine("Even: {0:X}", evenResult);
    }
}