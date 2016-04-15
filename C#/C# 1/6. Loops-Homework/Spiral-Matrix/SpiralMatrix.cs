/*Problem 17. Spiral Matrix
  Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and prints a matrix 
  holding the numbers from 1 to N*N in the form of square spiral like in the examples below.
  The input will always consist of a single line containing a single number - N.
  Output a spiral matrix as described below.
  Constraints: N will always be a valid integer number. 1 ≤ N ≤ 20
  Examples:
            n = 2   matrix      n = 3   matrix      n = 4   matrix
                    1 2                 1 2 3               1  2  3  4
                    4 3                 8 9 4               12 13 14 5
                                        7 6 5               11 16 15 6
                                                            10 9  8  7                  */

using System;

public class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[,] spiralMatrix = new int[N, N];

        FillMatrix(spiralMatrix, N);

        PrintMatrix(spiralMatrix, N);
    }

    private static void FillMatrix(int[,] spiralMatrix, int N)
    {
        int maxValue = N * N;

        int row = 0;
        int col = 0;
        string direction = "right";

        for (int i = 1; i <= maxValue; i++)
        {
            // check for changing the direction

            if (direction == "right" && (col > (N - 1) || spiralMatrix[row, col] != 0))
            {
                direction = "down";
                row++;
                col--;
            }

            if (direction == "down" && (row > (N - 1) || spiralMatrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }

            if (direction == "left" && (col < 0 || spiralMatrix[row, col] != 0))
            {
                direction = "up";
                row--;
                col++;
            }

            if (direction == "up" && (row < 0 || spiralMatrix[row, col] != 0))
            {
                direction = "right";
                row++;
                col++;
            }

            // fill the current element

            spiralMatrix[row, col] = i;

            // go to the next element in this direction

            if (direction == "right")
            {
                col++;
            }

            if (direction == "down")
            {
                row++;
            }

            if (direction == "left")
            {
                col--;
            }

            if (direction == "up")
            {
                row--;
            }
        }
    }

    private static void PrintMatrix(int[,] spiralMatrix, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0} ", spiralMatrix[i, j]);
            }

            Console.WriteLine();
        }
    }

}