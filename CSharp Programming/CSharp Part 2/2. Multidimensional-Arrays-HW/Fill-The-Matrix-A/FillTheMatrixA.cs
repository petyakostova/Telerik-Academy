/*  Problem 1. Fill the matrix A
    Write a program that fills and prints a matrix of size (n, n) as shown below:
    Example for n=4:
                        1 	5 	9 	13
                        2 	6 	10 	14
                        3 	7 	11 	15
                        4 	8 	12 	16  
 */

using System;

class FillTheMatrixA
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
        for (int col = 0, index = 1; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++, index++)
            {
                matrix[row, col] = index;
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