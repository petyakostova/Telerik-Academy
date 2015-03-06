/*  Problem 7.* Largest area in matrix
    Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
    Example:
    matrix 	                            result
    1 	3 	2 	2 	2 	4
    3 	3 	3 	2 	4 	4
    4 	3 	1 	2 	3 	3
    4 	3 	1 	3 	3 	1
    4 	3 	3 	3 	1 	1               13
    Hint: you can use the algorithm Depth-first search or Breadth-first search.
 */

using System;
using System.Collections.Generic;

class LargestAreaEqualNeighbourElements
{
    static int answer = 0;
    static int absolutemax = 0;
    static int[,] matrix = new int[,] { { 1, 3, 2, 2, 2, 4 },       // stand for check
                                        { 3, 3, 3, 2, 4, 4 }, 
                                        { 4, 3, 1, 2, 3, 3 }, 
                                        { 4, 3, 1, 3, 3, 1 }, 
                                        { 4, 3, 3, 3, 1, 1 } };
    static void Main()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                FindTheArea(i, j, matrix[i, j]);
                answer = 0;
            }
        }
        Console.WriteLine(absolutemax);
    }

    private static void FindTheArea(int i, int j, int currelement)
    {

        if ((currelement == 0) || (i < 0) || (i >= matrix.GetLength(0)) || (j < 0) || (j >= matrix.GetLength(1))) //returns if we are out of the matrix or the element is not the same
        {
            return;
        }

        if (matrix[i, j] == currelement)
        {
            matrix[i, j] = 0;

            answer++;

            if (absolutemax < answer)
            {
                absolutemax = answer;
            }

            FindTheArea(i + 1, j, currelement);

            FindTheArea(i - 1, j, currelement);

            FindTheArea(i, j + 1, currelement);

            FindTheArea(i, j - 1, currelement);

            matrix[i, j] = currelement;

        }

    }
}