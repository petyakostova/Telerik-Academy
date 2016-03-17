/*  Problem 3. Sequence n matrix
    We are given a matrix of strings of size N x M. 
    Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
    Write a program that finds the longest sequence of equal strings in the matrix.
    Example:
                matrix 	            result 		        matrix 	        result
            ha 	fifi 	ho 	hi                          s 	qq 	s
            fo 	ha 	    hi 	xx      ha, ha, ha          pp 	pp 	s       s, s, s
            xxx ho 	    ha 	xx                          pp 	qq 	s
 */
/* Note: In the files "Example1SequenceNMatrix" and "Example2SequenceNMatrix" 
   there are ready inputs for easier (faster) testing of the given examples.  
*/  

using System;
using System.Linq;

class SequenceNMatrix
{
    static readonly int[,] directions = { { 0, 1 }, { 1, 1 }, { -1, 1 }, { 1, 0 } };
    static void Main()
    {
        // Read the matrix dimensions
        Console.Write("Number of rows = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Number of columns = ");
        int cols = int.Parse(Console.ReadLine());

        // Create (Allocate) the matrix
        string[,] matrix = new string[rows, cols];

        // Enter the matrix elements
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        // Print the matrix on the console
        Console.WriteLine("\nThe matrix is as follows:");
        PrintingMatrix(matrix);

        // Find the longest sequence of equal strings in the matrix
        int bestLength = 0;
        string bestElement = string.Empty;
        FindLongestSequence(matrix, ref bestElement, ref bestLength);

        // Print the result 
        Console.WriteLine("\nThe longest sequence of equal strings in the matrix is:");
        Console.WriteLine(string.Join(", ", Enumerable.Repeat(bestElement, bestLength)));
        Console.WriteLine();
        
    }

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

    // Print the matrix on the console
    private static void PrintingMatrix(string[,] matrix)
    {

        for (int row = 0; row < matrix.GetLength(0); row++)     // rows = matrix.GetLength(0)
        {
            for (int col = 0; col < matrix.GetLength(1); col++) // cols = matrix.GetLength(1)
            {
                Console.Write("{0,-5} ", matrix[row, col]);     // left aligned
                //Console.Write("{0,5} ", matrix[row, col]);      // right aligned
            }
            Console.WriteLine();
        }
    }
}