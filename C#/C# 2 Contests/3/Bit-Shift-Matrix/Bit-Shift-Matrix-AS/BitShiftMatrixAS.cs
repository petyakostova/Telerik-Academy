namespace Bit_Shift_Matrix_AS
{
    using System;
    using System.Linq;
    using System.Numerics;

    class BitShiftMatrixAS
    {
        private static int rows;
        private static int cols;
        private static int coef;

        static void Main()
        {
            Solve();
            //                        string inputFileFormat = "..//..//tests//test.{0:000}.in.txt";
            //                        string outputFileFormat = "..//..//tests//test.{0:000}.out.txt";
            //            
            //                        for (int i = 0; i < 20; i++)
            //                        {
            //                            string inputFile = string.Format(inputFileFormat, i + 1);
            //                            string outputFile = string.Format(outputFileFormat, i + 1);
            //                            using (var reader = new StreamReader(inputFile))
            //                            using (var writer = new StreamWriter(outputFile))
            //                            {
            //                                Console.SetIn(reader);
            //                                Console.SetOut(writer);
            //                                Solve();
            //                            }
            //                        }
        }

        private static void Solve()
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            coef = Math.Max(rows, cols);
            int n = int.Parse(Console.ReadLine());
            var moves = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int row = rows - 1;
            int col = 0;

            bool[,] used = new bool[rows, cols];
            foreach (int move in moves)
            {
                int toRow = move / coef;
                int toCol = move % coef;

                while (col != toCol)
                {
                    used[row, col] = true;
                    //                    Console.WriteLine("({0}, {1})", row, col);
                    if (col < toCol)
                    {
                        col++;
                    }
                    else
                    {
                        col--;
                    }
                }

                while (row != toRow)
                {
                    used[row, col] = true;
                    //                    Console.WriteLine("({0}, {1})", row, col);
                    if (row < toRow)
                    {
                        row++;
                    }
                    else
                    {
                        row--;
                    }
                }
                used[row, col] = true;
            }
            BigInteger sum = 0;

            for (int r = 0; r < used.GetLength(0); r++)
            {
                for (int c = 0; c < used.GetLength(1); c++)
                {
                    if (used[r, c])
                    {
                        sum += GetValue(r, c, rows);
                    }
                }
            }
            Console.WriteLine(sum);
        }

        private static BigInteger GetValue(int row, int col, int rows)
        {
            return ((BigInteger)1) << (rows - row - 1 + col);
        }

    }
}