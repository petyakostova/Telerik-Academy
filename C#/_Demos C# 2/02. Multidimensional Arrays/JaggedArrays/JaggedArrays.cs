using System;

public class JaggedArrays
{
    static void Main()
    {
        int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
        int[] sizes = new int[3];   // the sizes of the cols keep in array sizes
        int[] offsets = new int[3]; // to which index is filled the jagged array (who is the next we can fill)

        // Calculate the sizes for each reminder (0, 1 and 2)
        foreach (var number in numbers)
        {
            int remainder = number % 3;
            sizes[remainder]++;
        }

        // Calculate the list of numbers for each reminder (0, 1 and 2)        
        var numberOfZeroRemainders = sizes[0];
        var numberOfOneRemainders = sizes[1];
        var numberOfTwoRemainders = sizes[2];
        int[][] numbersByRemainder = new int[3][] 
        { 
            new int[numberOfZeroRemainders], 
            new int[numberOfOneRemainders], 
            new int[numberOfTwoRemainders] 
        };

        // after creating the jagged array with different sizes, must iterate through numbers and white them
        foreach (var number in numbers)
        {
            int remainder = number % 3;
            int index = offsets[remainder];
            numbersByRemainder[remainder][index] = number;
            offsets[remainder]++;
        }

        // Print the result jagged array
        for (int row = 0; row < numbersByRemainder.GetLength(0); row++)
        {
            foreach (var num in numbersByRemainder[row])    // for each number on the current line
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

    }
}
