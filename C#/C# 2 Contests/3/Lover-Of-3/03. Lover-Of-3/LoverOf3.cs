namespace _03.Lover_Of_3
{
    using System;
    using System.Linq;

    class LoverOf3
    {              
        // 2.1 go in that direction until possible
        // 2.2 sum cells on the way using the formula
        // 2.2.2 keep information if we have already collected this cell
        // 2.3 read another direction        

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

            for (int i = 0; i < n; i++)
            {
                string[] move = Console.ReadLine().Split(' ');

                var direction = move[0];
                int repeats = int.Parse(move[1]); // how much to move to that direction

                var deltaRow = direction.Contains("U") ? -1 : 1;
                var deltaCow = direction.Contains("L") ? -1 : 1;

                // could also be from 0 to repeats - 1
                for (int j = 1; j < repeats; j++)
                {
                    if (IsInside(row + deltaRow, col + deltaCow, field))
                    {
                        // go to the cell
                        row += deltaRow;
                        col += deltaCow;

                        if (deltaRow == -1 && deltaCow == 1)
                        {
                            currentCell += 6;
                        }
                        else if (deltaRow == 1 && deltaCow == -1)
                        {
                            currentCell -= 6;
                        }

                        // if not collected
                        if (!field[row, col])
                        {
                            sum += currentCell;
                            field[row, col] = true;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
            }

            // 3. print the result
            Console.WriteLine(sum);
        }

        static bool IsInside(int row, int col, bool[,] matrix)
        {
            bool rowIsInField = 0 <= row && row < matrix.GetLength(0);
            bool colIsInField = 0 <= col && col < matrix.GetLength(1);

            return rowIsInField && colIsInField;
        }

    }
}