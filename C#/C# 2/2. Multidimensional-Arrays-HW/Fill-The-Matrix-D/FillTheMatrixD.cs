/*  Problem 1. * Fill the matrix D *
    Write a program that fills and prints a matrix of size (n, n) as shown below:
    Example for n=4:
                        1 	12 	11 	10
                        2 	13 	16 	9
                        3 	14 	15 	8
                        4 	5 	6 	7
 */

using System;

class FillTheMatrixD
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
        string direction = "down";
        int row = -1, col = 0;
        for (int index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); index++)
        {
            if (direction == "down")
            {
                if (matrix[++row, col] == 0) matrix[row, col] = index;
                if (!IsTraversable(matrix, row + 1, col)) direction = "right";
            }
            else if (direction == "right")
            {
                if (matrix[row, ++col] == 0) matrix[row, col] = index;
                if (!IsTraversable(matrix, row, col + 1)) direction = "up";
            }
            else if (direction == "up")
            {
                if (matrix[--row, col] == 0) matrix[row, col] = index;
                if (!IsTraversable(matrix, row - 1, col)) direction = "left";
            }
            else if (direction == "left")
            {
                if (matrix[row, --col] == 0) matrix[row, col] = index;
                if (!IsTraversable(matrix, row, col - 1)) direction = "down";
            }
        }
    }

    static bool IsTraversable(int[,] matrix, int row, int col)
    {
        return row >= 0 && row < matrix.GetLongLength(0) &&
        col >= 0 && col < matrix.GetLongLength(1) && matrix[row, col] == 0;
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