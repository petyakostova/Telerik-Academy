namespace _03.Bit_Shift_Matrix
{
    using System;
    //using System.IO; // needed for StringReader()
    using System.Linq; // needed for Select()
    using System.Numerics; // needed for BigInteger

    class BitShiftMatrix
    {
        // 1. read input
        // 2. declare a field/matrix with R and C
        // 3. for every move
        // 3.1 calcute move coordinates
        // 3.2 go to column and collect everything on the way and mark it as collected
        // 3.3 go to row and collect everything on the way and mark it as collected
        // 3.4 do the same for all moves
        // 4. print the resulting sum

        static void Main()
        {
            //RedirectInput(); // for easier testing

            // 1. read input
            int rowsCount = int.Parse(Console.ReadLine());
            int colsCount = int.Parse(Console.ReadLine());

            var n = Console.ReadLine(); // we don't need it

            // 2. declare a field/matrix with R and C
            bool[,] collected = new bool[rowsCount, colsCount];

            int[] moves = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();

            // The max value is up right => in the example 512 = 2^(4+5)
            // In the constraints the max row=100, max col=75 => MaxCell = 2 ^ (100 + 75) => BigInteger

            BigInteger sum = 0;
            int row = rowsCount - 1; // start from this row
            int col = 0; // start from this col
            BigInteger currentCellValue = 1;
            int coeff = Math.Max(rowsCount, colsCount);

            // 3. for every move
            foreach (var move in moves)
            {
                // 3.1 calcute move coordinates
                int nextRow = move / coeff;
                int nextCol = move % coeff;
                //Console.WriteLine(nextRow + " " + nextCol); // medium check

                // 3.2 go to column and collect everything on the way and mark it as collected
                int deltaCol = nextCol < col ? -1 : 1;

                while (col != nextCol)
                {
                    if (!collected[row, col])
                    {
                        sum += currentCellValue;
                        collected[row, col] = true;
                    }

                    if (deltaCol == 1)
                    {
                        currentCellValue *= 2;
                    }
                    else //if (deltaCol == -1)
                    {
                        currentCellValue /= 2;
                    }

                    // update the col
                    col += deltaCol;
                }

                // 3.3 go to row and collect everything on the way and mark it as collected
                var deltaRow = nextRow < row ? -1 : 1;

                while (row != nextRow)
                {
                    if (!collected[row, col])
                    {
                        sum += currentCellValue;
                        collected[row, col] = true;
                    }

                    if (deltaRow == 1)
                    {
                        currentCellValue /= 2;
                    }
                    else //if (deltaCol == -1)
                    {
                        currentCellValue *= 2;
                    }

                    // update the row
                    row += deltaRow;
                }
            }

            // for the last cell check if it's not collected and sum it
            if (!collected[row, col])
            {
                sum += currentCellValue;
                collected[row, col] = true; // doesn't matter
            }

            // 4. print the resulting sum
            Console.WriteLine(sum);
        }

//        static void RedirectInput()
//        {
//            Console.SetIn(new StringReader(@"5
//6
//4
//14 27 1 5
//"));
//        }

    }
}