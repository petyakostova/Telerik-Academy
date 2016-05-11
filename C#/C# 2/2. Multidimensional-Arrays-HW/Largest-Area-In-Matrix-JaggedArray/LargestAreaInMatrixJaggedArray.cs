using System;
using System.Linq;

class LargestAreaInMatrixJaggedArray
{
    static void Main()
    {
        var result = Console.ReadLine()
            .Split(' ')
            .Select(z => Convert.ToInt16(z))
            .ToArray();

        short rows = result[0];
        short cols = result[1];

        var jaggedMatrix = new short?[rows][];

        for (short i = 0; i < rows; i++)
        {
            jaggedMatrix[i] = new short?[cols];
        }

        for (short i = 0; i < rows; i++)
        {
            result = Console.ReadLine()
            .Split(' ')
            .Select(x => Convert.ToInt16(x))
            .ToArray();

            for (short j = 0; j < cols; j++)
            {
                jaggedMatrix[i][j] = result[j];
            }
        }

        short max = 1;
        short counter = 0;
        short? curent;

        for (short i = 0; i < jaggedMatrix.Length; i++)
        {
            for (short j = 0; j < jaggedMatrix[i].Length; j++)
            {
                counter = 0;

                if (jaggedMatrix[i][j] == null) //number is part of checked sequence
                {
                    continue;
                }
                else
                {
                    //unchecked number
                    counter = 1;
                    curent = jaggedMatrix[i][j];
                    jaggedMatrix[i][j] = null; //with null mark all numbers in current sequence
                    counter = Finder(jaggedMatrix, i, j, ref curent, ref counter);

                    if (counter > max)
                    {
                        max = counter;
                    }
                }
            }
        }

        Console.WriteLine(max);
    }

    static short Finder(short?[][] matrix, short row, short col, ref short? current, ref short counter)
    {
        if (row > 0 && matrix[row - 1][col] == current) //up
        {
            counter++;
            matrix[row - 1][col] = null;
            counter = Finder(matrix, (short)(row - 1), col, ref current, ref counter);
        }

        if (row < matrix.Length - 1 && matrix[row + 1][col] == current) //down
        {
            counter++;
            matrix[row + 1][col] = null;
            counter = Finder(matrix, (short)(row + 1), col, ref current, ref counter);
        }

        if (col > 0 && matrix[row][col - 1] == current) //left
        {
            counter++;
            matrix[row][col - 1] = null;
            counter = Finder(matrix, row, (short)(col - 1), ref current, ref counter);
        }

        if (col < matrix[row].Length - 1 && matrix[row][col + 1] == current) //right
        {
            counter++;
            matrix[row][col + 1] = null;
            counter = Finder(matrix, row, (short)(col + 1), ref current, ref counter);
        }

        return counter;
    }

}