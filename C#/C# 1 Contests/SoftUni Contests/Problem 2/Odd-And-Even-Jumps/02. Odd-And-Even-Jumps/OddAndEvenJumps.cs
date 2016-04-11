using System;

class OddAndEvenJumps
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower().Replace(" ", "");
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        int counter = 1;    //we count from 1, not from 0
        long oddResult = 0;

        // Odd characters (we count from 1, not from 0)
        for (int i = 0; i < input.Length; i += 2)
        {
            if (counter == oddJump)
            {
                oddResult *= input[i];
                counter = 1; // reset the counter
            }
            else
            {
                oddResult += input[i];
                counter++;
            }
        }

        counter = 1; // reset the counter, for the even positions
        long evenResult = 0;

        // Even characters (we count from 1, not from 0)
        for (int i = 1; i < input.Length; i += 2)
        {
            if (counter == evenJump)
            {
                evenResult *= input[i];
                counter = 1; // reset the counter
            }
            else
            {
                evenResult += input[i];
                counter++;
            }
        }

        Console.WriteLine("Odd: {0:X}", oddResult);
        Console.WriteLine("Even: {0:X}", evenResult);
    }
}