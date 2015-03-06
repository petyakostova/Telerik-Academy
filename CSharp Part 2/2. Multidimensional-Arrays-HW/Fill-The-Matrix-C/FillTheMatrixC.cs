/*  Problem 1. Fill the matrix C
    Write a program that fills and prints a matrix of size (n, n) as shown below:
    Example for n=4:
                        7 	11 	14 	16
                        4 	8 	12 	15
                        2 	5 	9 	13
                        1 	3 	6 	10
 */

using System;

class FillTheMatrixC
{
    static void Main()
    {
        // Read the matrix dimensions
        Console.Write("Number of rows and columns = ");
        int rows = int.Parse(Console.ReadLine());
        int cols = rows;

        // Create (Allocate) the matrix
        int[,] matrix = new int[rows, cols];

        FillMatrix(matrix);

        Console.WriteLine();

        PrintingMatrix(matrix);
    }

    // Set (Fill) the matrix elements
    private static void FillMatrix(int[,] matrix)
    {
        for (int row = matrix.GetLength(0) - 1, index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); row--)
        {
            for (int currCol = (row >= 0 ? 0 : -row), currRow = (row >= 0 ? row : 0);
            currCol < (matrix.GetLength(1) - (row >= 0 ? row : 0)); )
            {
                matrix[currRow++, currCol++] = index++;
            }
        }
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