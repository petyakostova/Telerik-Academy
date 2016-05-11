/*  Problem 2. Maximal sum
    Write a program that reads a rectangular matrix of size N x M and 
    finds in it the square 3 x 3 that has maximal sum of its elements. Print that sum.
    Input: 
            On the first line you will receive the numbers N and M separated by a single space
            On the next N lines there will be M numbers separated with spaces - the elements of the matrix
    Output: Print the maximal sum of 3 x 3 square
    Constraints: 3 <= N, M <= 1024. Numbers in the matrix will be in the interval [ -1000, 1000 ]
    Sample tests:
                    Input       Output          Input 	            Output
                    3 3         41              5 5                 19
                    4 3 5                       1 1 3 3 5
                    2 6 4                       -6 -7 2 -3 -1
                    8 2 7                       3 0 -4 5 9
                                                7 -7 0 1 0
                                                -7 -6 -4 -4 9 	                    */

using System;

class Program
{
    static void Main()
    {
        // Read the matrix dimensions
        string[] sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(sizes[0]);
        int cols = int.Parse(sizes[1]);

        // Create (Allocate) the matrix
        int[,] matrix = new int[rows, cols];

        // Enter the matrix elements
        for (int row = 0; row < rows; row++)
        {
            string[] inputRows = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(inputRows[col]);
            }
        }

        // Find the maximal sum platform of size 3 x 3
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // Print the best platform
        //Console.WriteLine("  {0} {1} {2}", 
        //    matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        //Console.WriteLine("  {0} {1} {2}", 
        //    matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        //Console.WriteLine("  {0} {1} {2}", 
        //    matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);

        // Output
        Console.WriteLine(bestSum);
    }

}