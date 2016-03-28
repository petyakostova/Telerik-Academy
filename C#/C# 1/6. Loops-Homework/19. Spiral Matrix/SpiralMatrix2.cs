﻿/*Problem 19.** Spiral Matrix
  Write a program that reads from the console a positive integer number n (1 = n = 20) 
  and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
Examples:

n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1  2  3  4
        4 3                 8 9 4               12 13 14 5
                            7 6 5               11 16 15 6
                                                10 9  8  7
*/
using System;

class SpiralMatrix2
{
    static void Main()
    {
        System.Console.SetWindowSize(100, 30);
        int n = int.Parse(Console.ReadLine());
        Console.Clear();
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        int value = 1;

        if (n > 0 && n < 21)
        {
            while (value <= n * n)
            {
                while (col < matrix.GetLength(0) && matrix[col, row] == 0)
                {
                    matrix[row, col++] = value;
                    value++;
                }
                col--;
                row++;
                while (row < matrix.GetLength(1) && matrix[row, col] == 0)
                {
                    matrix[row++, col] = value;
                    value++;
                }
                row--;
                col--;
                while (col >= 0 && matrix[row, col] == 0)
                {
                    matrix[row, col--] = value;
                    value++;
                }
                col++;
                row--;
                while (row >= 0 && matrix[row, col] == 0)
                {
                    matrix[row--, col] = value;
                    value++;
                }
                col++;
                row++;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.SetCursorPosition(j * 5, i * 2);
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}