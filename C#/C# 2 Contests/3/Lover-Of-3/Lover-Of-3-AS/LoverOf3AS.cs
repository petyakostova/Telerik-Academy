namespace Lover_Of_3_AS
{
    using System;
    using System.Linq;
    using System.Numerics;

    class LoverOf3AS
    {
        static int GetDirection(string dirName)
        {
            switch (dirName)
            {
                case "UR":
                case "RU":
                    return 0;
                case "DR":
                case "RD":
                    return 1;
                case "DL":
                case "LD":
                    return 2;
                case "UL":
                case "LU":
                    return 3;
            }
            return -1;
        }

        static void Main()
        {
            int[] dRows = { -1, 1, 1, -1 };
            int[] dCols = { 1, 1, -1, -1 };

            int[] rowsCols = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];

            int n = int.Parse(Console.ReadLine());
            bool[,] isVisited = new bool[rows, cols];
            int row = rows - 1;
            int col = 0;
            for (int i = 0; i < n; i++)
            {
                string[] move = Console.ReadLine().Split(' ');
                int dir = GetDirection(move[0]);
                int count = int.Parse(move[1]) - 1;

                for (int j = 0; j < count; j++)
                {
                    int nextRow = row + dRows[dir];
                    int nextCol = col + dCols[dir];
                    if (!InRange(nextRow, rows - 1) || !InRange(nextCol, cols - 1))
                    {
                        break;
                    }
                    row = nextRow;
                    col = nextCol;
                    isVisited[row, col] = true;
                }
            }
            BigInteger sum = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (isVisited[r, c])
                    {
                        sum += GetValueAt(r, c, rows);
                    }
                }
            }
            Console.WriteLine(sum);
        }

        private static BigInteger GetValueAt(int row, int col, int rows)
        {
            return (rows - row - 1 + col) * 3;
        }

        private static bool InRange(int value, int max)
        {
            return 0 <= value && value <= max;
        }

    }
}