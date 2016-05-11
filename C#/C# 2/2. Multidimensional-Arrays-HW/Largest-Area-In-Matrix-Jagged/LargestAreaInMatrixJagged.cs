// Without Diagonals => 100/ 100

using System;
using System.Linq;
using System.Collections;

class LargestAreaInMatrixJagged
{
    // Declare flags BitArray to be accessible in all methods
    static BitArray[] isChecked;

    static void Main()
    {
        // Read the matrix sizes
        short[] sizes = Console.ReadLine()
                               .Split(' ')
                               .Select(short.Parse)
                               .ToArray();

        // Read The Array
        int[][] jaggedMatrix = new int[sizes[0]][];

        //Initialize the bit array for each row
        isChecked = new BitArray[jaggedMatrix.Length];

        for (int row = 0; row < jaggedMatrix.Length; row++)
        {
            // Read Input row
            jaggedMatrix[row] = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();

            // Create flags for each element of the current input row
            isChecked[row] = new BitArray(jaggedMatrix[row].Length);
        }

        var MaxSequence = int.MinValue;

        // Check for each element not checked before
        for (int row = 0; row < jaggedMatrix.Length; row++)
        {
            for (int col = 0; col < jaggedMatrix[row].Length; col++)
            {
                int curSequence = 1;

                if (isChecked[row][col] == false)
                {
                    isChecked[row][col] = true;

                    // find sequence for current element
                    curSequence = CheckElement(row, col, curSequence, jaggedMatrix);
                }

                // check if the current sequence is larger
                MaxSequence = (curSequence > MaxSequence) ? curSequence : MaxSequence;
            }
        }

        // Output
        Console.WriteLine(MaxSequence);
    }

    // Get Sequence - Up, Down, Left, Right
    public static int CheckElement(int row, int col, int curSequence, int[][] toSearch)
    {
        // Check Down
        if (row + 1 < toSearch.Length)
        {
            if (toSearch[row + 1][col] == toSearch[row][col] && isChecked[row + 1][col] == false)
            {
                curSequence++;

                isChecked[row + 1][col] = true;

                curSequence = CheckElement(row + 1, col, curSequence, toSearch);
            }
        }

        // Check Right
        if (col + 1 < toSearch[row].Length)
        {
            if (toSearch[row][col + 1] == toSearch[row][col] && isChecked[row][col + 1] == false)
            {
                curSequence++;

                isChecked[row][col + 1] = true;

                curSequence = CheckElement(row, col + 1, curSequence, toSearch);
            }
        }

        // Check Up
        if (row - 1 >= 0)
        {
            if (toSearch[row - 1][col] == toSearch[row][col] && isChecked[row - 1][col] == false)
            {
                curSequence++;

                isChecked[row - 1][col] = true;

                curSequence = CheckElement(row - 1, col, curSequence, toSearch);
            }
        }

        // Check Left
        if (col - 1 >= 0)
        {
            if (toSearch[row][col - 1] == toSearch[row][col] && isChecked[row][col - 1] == false)
            {
                curSequence++;

                isChecked[row][col - 1] = true;

                curSequence = CheckElement(row, col - 1, curSequence, toSearch);
            }
        }

        // Return current sequence length
        return curSequence;
    }

}