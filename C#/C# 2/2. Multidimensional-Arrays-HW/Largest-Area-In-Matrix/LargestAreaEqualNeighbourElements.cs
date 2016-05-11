/*  Problem 7. Largest area in matrix
    Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
    Input: On the first line you will receive the numbers N and M separated by a single space
    On the next N lines there will be M numbers separated with spaces - the elements of the matrix
    Output: Print the size of the largest area of equal neighbour elements
    Constraints: 3 <= N, M <= 1024
    Sample test:
                    Input 	        Output
                    5 6             13
                    1 3 2 2 2 4
                    3 3 3 2 4 4
                    4 3 1 2 3 3
                    4 3 1 3 3 1
                    4 3 3 3 1 1 	
   Hint: you can use the algorithm Depth-first search or Breadth-first search.  */

using System;

class LargestAreaEqualNeighbourElements
{
    static short answer = 0;
    static short absolutemax = 0;
    static short[,] matrix;

    static void Main()
    {
        // Read the matrix dimensions
        string[] sizes = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        short rows = short.Parse(sizes[0]);
        short cols = short.Parse(sizes[1]);

        // Create (Allocate) the matrix
        matrix = new short[rows, cols];

        // Enter the matrix elements
        for (short row = 0; row < rows; row++)
        {
            string[] inputRows = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (short col = 0; col < cols; col++)
            {
                matrix[row, col] = short.Parse(inputRows[col]);
            }
        }

        // Find the largest area of equal neighbour elements
        for (short i = 0; i < matrix.GetLength(0); i++)
        {
            for (short j = 0; j < matrix.GetLength(1); j++)
            {
                FindTheArea(i, j, matrix[i, j]);
                answer = 0;
            }
        }

        // Output
        Console.WriteLine(absolutemax);
    }

    private static void FindTheArea(short i, short j, short currelement)
    {
        //returns if we are out of the matrix or the element is not the same
        if ((currelement == 0) || (i < 0) || (i >= matrix.GetLength(0)) || (j < 0) || (j >= matrix.GetLength(1)))
        {
            return;
        }

        if (matrix[i, j] == currelement)
        {
            matrix[i, j] = 0;

            answer++;

            if (absolutemax < answer)
            {
                absolutemax = answer;
            }

            FindTheArea((short)(i + 1), j, currelement);

            FindTheArea((short)(i - 1), j, currelement);

            FindTheArea(i, (short)(j + 1), currelement);

            FindTheArea(i, (short)(j - 1), currelement);

            matrix[i, j] = currelement;
        }
    }

}