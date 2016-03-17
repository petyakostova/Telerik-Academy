/*  Problem 1. Fill the matrix B
    Write a program that fills and prints a matrix of size (n, n) as shown below:
    Example for n=4:
                        1 	8 	9 	16
                        2 	7 	10 	15
                        3 	6 	11 	14
                        4 	5 	12 	13
 */

using System;

class FillTheMatrixB
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
        bool isDirDown = true;
        for (int col = 0, row = 0, index = 1; col < matrix.GetLength(1); col++)
        {
            while (row >= 0 && row < matrix.GetLength(0))
            {
                matrix[row, col] = index++;
                row += isDirDown ? +1 : -1; // Change 'row' value
            }
            // Change direction and change 'row' value
            isDirDown = !isDirDown;
            row += isDirDown ? +1 : -1;
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