using System;
using System.Linq;

class LargestAreaInMatrixJaggedArray
{
    static void Main()
    {
        var sizes = Console.ReadLine()
            .Split(' ')
            .Select(x => Convert.ToInt16(x))
            .ToArray();

        short rows = sizes[0];
        short cols = sizes[1];

        var jaggedMatrix = new short?[rows][];

        for (short i = 0; i < jaggedMatrix.Length; i++)
        {
            jaggedMatrix[i] = new short?[cols];
        
            sizes = Console.ReadLine()
            .Split(' ')
            .Select(x => Convert.ToInt16(x))
            .ToArray();

            for (short j = 0; j < jaggedMatrix[i].Length; j++)
            {
                jaggedMatrix[i][j] = sizes[j];
            }
        }

        short maxCountEqualNeighbourElements = 1;
        short currCountEqualNeighbourElements = 0;
        short? currentElement;

        for (short i = 0; i < jaggedMatrix.Length; i++)
        {
            for (short j = 0; j < jaggedMatrix[i].Length; j++)
            {
                currCountEqualNeighbourElements = 0;

                if (jaggedMatrix[i][j] == null) //number is part of checked sequence
                {
                    continue;
                }
                else
                {
                    //unchecked number
                    currCountEqualNeighbourElements = 1;
                    currentElement = jaggedMatrix[i][j];
                    jaggedMatrix[i][j] = null; //with null mark all numbers in current sequence
                    currCountEqualNeighbourElements = FindTheArea(jaggedMatrix, i, j, ref currentElement, ref currCountEqualNeighbourElements);

                    if (currCountEqualNeighbourElements > maxCountEqualNeighbourElements)
                    {
                        maxCountEqualNeighbourElements = currCountEqualNeighbourElements;
                    }
                }
            }
        }

        Console.WriteLine(maxCountEqualNeighbourElements);
    }

    static short FindTheArea(short?[][] matrix, short row, short col, ref short? current, ref short counter)
    {
        if (row > 0 && matrix[row - 1][col] == current) //up
        {
            counter++;
            matrix[row - 1][col] = null;
            counter = FindTheArea(matrix, (short)(row - 1), col, ref current, ref counter);
        }

        if (row < matrix.Length - 1 && matrix[row + 1][col] == current) //down
        {
            counter++;
            matrix[row + 1][col] = null;
            counter = FindTheArea(matrix, (short)(row + 1), col, ref current, ref counter);
        }

        if (col > 0 && matrix[row][col - 1] == current) //left
        {
            counter++;
            matrix[row][col - 1] = null;
            counter = FindTheArea(matrix, row, (short)(col - 1), ref current, ref counter);
        }

        if (col < matrix[row].Length - 1 && matrix[row][col + 1] == current) //right
        {
            counter++;
            matrix[row][col + 1] = null;
            counter = FindTheArea(matrix, row, (short)(col + 1), ref current, ref counter);
        }

        return counter;
    }

}