/*  Problem 7. Largest area in matrix
    Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
    Input: On the first line you will receive the numbers N and M separated by a single space
    On the next N lines there will be M numbers separated with spaces - the elements of the matrix
    Output: Print the size of the largest area of equal neighbour elements
    Constraints: 3 <= N, M <= 1024
    Sample test:
                    Input 	        Output
                    5 6             13
                    1 3 2 2 2 4
                    3 3 3 2 4 4
                    4 3 1 2 3 3
                    4 3 1 3 3 1
                    4 3 3 3 1 1 	
   Hint: you can use the algorithm Depth-first search or Breadth-first search.  */

// The solution is with jagged array => 20/100 in bgcoder; 1 wrong; 7 time limit

using System;
using System.Linq; // needed for Select() 

class LargestAreaEqualNeighbourElements
{
    static int answer = 0;
    static int absolutemax = 0;
    static int[][] jaggedMatrix;

    static void Main()
    {
        // Read the matrix dimensions
        string[] sizes = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int rows = int.Parse(sizes[0]);
        int cols = int.Parse(sizes[1]);

        // Create (Allocate) the matrix
        jaggedMatrix = new int[rows][];

        // Enter the matrix elements
        for (int row = 0; row < jaggedMatrix.GetLength(0); row++)
        {
            jaggedMatrix[row] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)            // parsing each string from the input
                                              //.Select(x => int.Parse(x))    //other way  
                .ToArray();
        }

        // Find the largest area of equal neighbour elements
        for (int row = 0; row < jaggedMatrix.Length; row++)
        {
            for (int col = 0; col < jaggedMatrix[row].Length; col++)
            {
                FindTheArea(row, col, jaggedMatrix[row][col]);
                answer = 0;
            }
        }

        // Output
        Console.WriteLine(absolutemax);
    }

    private static void FindTheArea(int i, int j, int currElement)
    {
        //returns if we are out of the matrix or the element is not the same
        if ((currElement == 0) 
            || (i < 0) || (i >= jaggedMatrix.Length) 
            || (j < 0) || (j >= jaggedMatrix[i].Length))
        {
            return;
        }

        if (jaggedMatrix[i][j] == currElement)
        {
            jaggedMatrix[i][j] = 0;

            answer++;

            if (absolutemax < answer)
            {
                absolutemax = answer;
            }

            FindTheArea(i + 1, j, currElement);

            FindTheArea(i - 1, j, currElement);

            FindTheArea(i, j + 1, currElement);

            FindTheArea(i, j - 1, currElement);

            jaggedMatrix[i][j] = currElement;
        }
    }

}