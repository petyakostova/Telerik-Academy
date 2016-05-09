﻿/*  Problem 1. Fill the matrix
    Write a program that fills and prints a matrix of size (n, n) as shown below.
    Input: On the first line you will receive the number N.
    On the second line you will receive a character (a, b, c, d*) which determines how to fill the matrix.
    Output: Print the matrix. Numbers on a row must be separated by a single spacebar. Each row must be on a new line.
    Constraints: 1 <= N <= 128
    Sample tests
Input 	Output                  Input 	Output                  Input 	Output                  Input 	Output
4       1	5	9	13          4       1	8	9	16          4       7	11	14	16          4       1	12	11	10
a       2	6	10	14          b 	    2	7	10	15          c 	    4	8	12	15          d       2	13	16	9
        3	7	11	15                  3	6	11	14                  2	5	9	13                  3	14	15	8
        4	8	12	16                  4	5	12	13                  1	3	6	10                  4	5	6	7   */

using System;

class FillTheMatrix
{
    static void Main()
    {
        // Read the matrix dimensions
        int rows = int.Parse(Console.ReadLine());
        int cols = rows;
        // Input character
        char character = char.Parse(Console.ReadLine());

        // Create (Allocate) the matrix
        int[,] matrix = new int[rows, cols];

        switch (character)
        {
            case 'a': FillMatrixA(matrix); break;
            case 'b': FillMatrixB(matrix); break;
            case 'c': FillMatrixC(matrix); break;
            case 'd': FillMatrixD(matrix); break;
        }

        PrintingMatrix(matrix);
    }

    // A => Set (Fill) the matrix elements
    private static void FillMatrixA(int[,] matrix)
    {
        for (int col = 0, index = 1; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++, index++)
            {
                matrix[row, col] = index;
            }
        }
    }

    // B => Set (Fill) the matrix elements
    private static void FillMatrixB(int[,] matrix)
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

    // C => Set (Fill) the matrix elements
    private static void FillMatrixC(int[,] matrix)
    {
        for (int row = matrix.GetLength(0) - 1, index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); row--)
        {
            for (int currCol = (row >= 0 ? 0 : -row), currRow = (row >= 0 ? row : 0);
            currCol < (matrix.GetLength(1) - (row >= 0 ? row : 0));)
            {
                matrix[currRow++, currCol++] = index++;
            }
        }
    }

    // D => Set (Fill) the matrix elements
    private static void FillMatrixD(int[,] matrix)
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
        for (int row = 0; row < matrix.GetLength(0); row++)       // rows = matrix.GetLength(0)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)   // cols = matrix.GetLength(1)
            {
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                else
                {
                    Console.Write("{0}", matrix[row, col]);
                }
                //Console.Write("{0,-2} ", matrix[row, col]);     // left aligned
                //Console.Write("{0,2} ", matrix[row, col]);      // right aligned
            }
            Console.WriteLine();
        }
    }

}