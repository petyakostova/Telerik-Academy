// using the Ping Pong Ball Method

using System;

class TelerikLogoMatrix
{
    static void Main()
    {
        // initialization

        int x = int.Parse(Console.ReadLine());
        //int y = x;
        int z = x / 2 + 1;

        int width = (2 * x + 2 * z) - 3;
        // height = width; //3 * x - 3

        int[,] matrix = new int[width, width];

        // solution - filling the path with ones

        // the path starts from here
        int currentRow = x / 2;
        int currentCol = 0;

        while (true) //from 1 to 2
        {
            matrix[currentRow, currentCol] = 1;

            currentRow--;
            currentCol++;

            if (currentRow < 0)
            {
                // goint back to the right place
                currentRow++;
                currentCol--;
                break;
            }
        }

        while (true) //from 2 to 3
        {
            matrix[currentRow, currentCol] = 1;

            currentRow++;
            currentCol++;

            if (currentRow == 2 * x - 1)
            {
                currentRow--;
                currentCol--;
                break;
            }
        }

        while (true) //from 3 to 4
        {
            matrix[currentRow, currentCol] = 1;

            currentRow++;
            currentCol--;

            if (currentRow == width)
            {
                currentRow--;
                currentCol++;
                break;
            }
        }

        while (true) //from 4 to 5
        {
            matrix[currentRow, currentCol] = 1;

            currentRow--;
            currentCol--;

            if (currentCol == x / 2 - 1)
            {
                currentRow++;
                currentCol++;
                break;
            }
        }

        while (true) //from 5 to 6
        {
            matrix[currentRow, currentCol] = 1;

            currentRow--;
            currentCol++;

            if (currentRow < 0)
            {
                currentRow++;
                currentCol--;
                break;
            }
        }

        while (true) //from 6 to 7
        {
            matrix[currentRow, currentCol] = 1;

            currentRow++;
            currentCol++;

            if (currentCol == width)
            {
                break;
            }
        }

        // printing

        for (int row = 0; row < width; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write('*');
                }
            }

            Console.WriteLine();
        }

    }
}