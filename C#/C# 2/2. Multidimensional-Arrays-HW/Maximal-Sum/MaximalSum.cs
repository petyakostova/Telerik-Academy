/*  Problem 2. Maximal sum
    Write a program that reads a rectangular matrix of size N x M and 
    finds in it the square 3 x 3 that has maximal sum of its elements. Print that sum.
    Input: 
            On the first line you will receive the numbers N and M separated by a single space
            On the next N lines there will be M numbers separated with spaces - the elements of the matrix
    Output: Print the maximal sum of 3 x 3 square
    Constraints: 3 <= N, M <= 1024. Numbers in the matrix will be in the interval [ -1000, 1000 ]
    Sample tests:
                    Input 	    Output          Input 	            Output
                    3 3         41              5 5                 19
                    4 3 5                       1 1 3 3 5
                    2 6 4                       -6 -7 2 -3 -1
                    8 2 7 	                    3 0 -4 5 9
                                                7 -7 0 1 0
                                                -7 -6 -4 -4 9 	                    */

/*  Note: In the file "CheckMaximalSum.txt" there is ready input for easier (faster) testing:
          Input:                            Output:
                0, 2, 4, 0, 9, 5            The best platform is:
                7, 1, 3, 3, 2, 1            1 3 3
                1, 3, 9, 8, 5, 6            3 9 8
                4, 6, 7, 9, 1, 0            6 7 9
                                            The maximal sum is: 49    
 */
using System;

class Program
{
    static void Main()
    {
        // Read the matrix dimensions
        Console.Write("Number of rows = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Number of columns = ");
        int cols = int.Parse(Console.ReadLine());

        // Create (Allocate) the matrix
        int[,] matrix = new int[rows, cols];

        // Enter the matrix elements
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine()); ;
            }
        }

        Console.WriteLine("\nThe matrix is as follows:");
        PrintingMatrix(matrix);

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

        // Print the result
        Console.WriteLine("\nThe best platform is:");
        Console.WriteLine("  {0} {1} {2}", 
            matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}", 
            matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}", 
            matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        Console.WriteLine("\nThe maximal sum is: {0}\n", bestSum);
    }

    // Print the matrix on the console
    private static void PrintingMatrix(int[,] matrix)
    {

        for (int row = 0; row < matrix.GetLength(0); row++)     // rows = matrix.GetLength(0)
        {
            for (int col = 0; col < matrix.GetLength(1); col++) // cols = matrix.GetLength(1)
            {
                Console.Write("{0,-2} ", matrix[row, col]);     // left aligned
                //Console.Write("{0,2} ", matrix[row, col]);      // right aligned
            }
            Console.WriteLine();
        }
    }
}