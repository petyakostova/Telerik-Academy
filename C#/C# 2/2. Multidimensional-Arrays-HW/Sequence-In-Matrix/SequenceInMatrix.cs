/*  Problem 3. Sequence in matrix
    We are given a matrix of strings of size N x M. 
    Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal. 
    Write a program that finds the longest sequence of equal strings in the matrix and prints its length.
    Input: 
            On the first line you will receive the numbers N and M separated by a single space
            On the next N lines there will be M strings separated with spaces - the strings in the matrix
    Output: Print the length of the longest sequence of equal equal strings in the matrix
    Constraints: 3 <= N, M <= 128            */

using System;

class SequenceInMatrix
{
    static readonly int[,] directions = { { 0, 1 }, { 1, 1 }, { -1, 1 }, { 1, 0 } };

    static void Main()
    {
        // Read the matrix dimensions
        string[] sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(sizes[0]);
        int cols = int.Parse(sizes[1]);

        // Create (Allocate) the matrix
        string[,] matrix = new string[rows, cols];

        // Enter the matrix elements
        for (int row = 0; row < rows; row++)
        {
            string[] inputRows = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = inputRows[col];
            }
        }
        
        // Find the longest sequence of equal strings in the matrix
        int bestLength = 0;
        string bestElement = string.Empty;
        FindLongestSequence(matrix, ref bestElement, ref bestLength);

        // The longest sequence of equal strings in the matrix
        //Console.WriteLine(string.Join(", ", Enumerable.Repeat(bestElement, bestLength)));

        // Output
        Console.WriteLine(bestLength);
    }

    /*A variable of a reference type does not contain its data directly; it contains a reference to its data. 
    When you pass a reference-type parameter by value, 
    it is possible to change the data pointed to by the reference, such as the value of a class member. */
    static void FindLongestSequence(string[,] matrix, ref string bestElement, ref int bestLength)
    {
        for (int row = 0; row < matrix.GetLongLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLongLength(1); col++)
            {
                int direction = -1;

                while (++direction < 4)
                {
                    int currRow = row + directions[direction, 0];
                    int currCol = col + directions[direction, 1];
                    int currentLength = 1;

                    while (IsTraversable(matrix, row, col, currRow, currCol))
                    {
                        currentLength++;

                        if (currentLength > bestLength)
                        {
                            bestLength = currentLength;
                            bestElement = matrix[row, col];
                        }

                        currRow += directions[direction, 0];
                        currCol += directions[direction, 1];
                    }
                }
            }
        }
    }

    static bool IsTraversable(string[,] matrix, int row, int col, int currRow, int currCol)
    {
        return currRow >= 0 && currRow < matrix.GetLongLength(0) &&
               currCol >= 0 && currCol < matrix.GetLongLength(1) &&
               matrix[currRow, currCol] == matrix[row, col];
    }
    
}