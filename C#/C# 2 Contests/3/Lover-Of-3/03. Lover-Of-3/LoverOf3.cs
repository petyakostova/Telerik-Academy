namespace _03.Lover_Of_3
{
    using System;
    using System.Linq;

    class LoverOf3
    {
        static void Main()
        {
            /* instead of creating int matrix and fill it, just use formula to calculate the current cell's value
               and create boolean matrix with false-s (still not visited cells)*/

            // 1. read field sizes and create boolean field
            var fieldSizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // 2. read directions
            var rowsCount = fieldSizes[0];
            var colsCount = fieldSizes[1];

            // the boolean matrix will be initialize with the default bool value => false
            var field = new bool[rowsCount, colsCount];

            var n = int.Parse(Console.ReadLine()); // the number of directions

            long sum = 0;

            int row = rowsCount - 1;
            int col = 0;
            int currentCell = 0;

            // for every direction
            for (int i = 0; i < n; i++)
            {
                string[] move = Console.ReadLine().Split(' ');

                var direction = move[0];
                int repeats = int.Parse(move[1]); // how much to move to that direction

                // instead of switch with 8 cases
                var deltaRow = direction.Contains("U") ? -1 : 1;
                var deltaCol = direction.Contains("L") ? -1 : 1;

                // could also be from 0 to repeats - 1
                for (int j = 1; j < repeats; j++)
                {
                    // can we go to [row + deltaRow, col + deltaCol]
                    if (IsInside(row + deltaRow, col + deltaCol, field))
                    {
                        // 2.1 go in that direction until possible 
                        // go to the cell
                        row += deltaRow;
                        col += deltaCol;

                        // the values don't change in directions up left and down right

                        // up right
                        if (deltaRow == -1 && deltaCol == 1)
                        {
                            currentCell += 6;
                        }
                        // down left
                        else if (deltaRow == 1 && deltaCol == -1)
                        {
                            currentCell -= 6;
                        }

                        // if not collected => 2.2.2 keep information if we have already collected this cell
                        if (!field[row, col])
                        {
                            /* 2.2 other way => sum cells on the way using the formula 
                               sum += col*3 + (rowsCount-1-row)*3                 
                               every time we increase the col => the value += 3
                               every time we decrease the row => the value += 3         */
                            sum += currentCell;

                            field[row, col] = true; // mark the cell as visited
                        }
                    }
                    else
                    {
                        break; // stop the loop
                    }
                    // 2.3 read another direction 
                }
            }

            // 3. print the result
            Console.WriteLine(sum);
        }

        static bool IsInside(int row, int col, bool[,] matrix)
        {
            bool rowIsInField = 0 <= row && row < matrix.GetLength(0); // row [0; rowsCount)
            bool colIsInField = 0 <= col && col < matrix.GetLength(1); // col [0; colsCount)

            return rowIsInField && colIsInField;
        }

    }
}