using System;

public class JaggedArrays
{
    static void Main()
    {
        int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
        int[] sizes = new int[3];   // размерите на колоните пазим в масив sizes
        int[] offsets = new int[3]; // до кой индекс сме запълнили назъбения масив (т.е. кой е следващият, който можем да запълним) пазим в масива offsets

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

        // след като се създали назъбения масив с различните размености спрямо числата, трябва да ги обиколим и да запишем числата
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
            foreach (var num in numbersByRemainder[row])    // за всяко число на текущия ред обхождаме с foreach
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
