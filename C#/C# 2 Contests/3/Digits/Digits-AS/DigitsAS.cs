namespace Digits_AS
{
    using System;

    class DigitsAS
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            byte[,] matrix = new byte[n, n];
            for (int i = 0; i < n; i++)
            {
                string digits = Console.ReadLine().Replace(" ", "");
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = (byte)(digits[j] - '0');
                }
            }
            Console.WriteLine(Solve(matrix));
        }

        private static int Solve(byte[,] field)
        {
            int result = 0;
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    switch (field[row, col])
                    {
                        case 1:
                            result += CheckForOne(field, row, col);
                            break;
                        case 2:
                            result += CheckForTwo(field, row, col);
                            break;
                        case 3:
                            result += CheckForThree(field, row, col);
                            break;
                        case 4:
                            result += CheckForFour(field, row, col);
                            break;
                        case 5:
                            result += CheckForFive(field, row, col);
                            break;
                        case 6:
                            result += CheckForSix(field, row, col);
                            break;
                        case 7:
                            result += CheckForSeven(field, row, col);
                            break;
                        case 8:
                            result += CheckForEight(field, row, col);
                            break;
                        case 9:
                            result += CheckForNine(field, row, col);
                            break;
                    }
                }
            }
            return result;
        }

        private static int CheckForOne(byte[,] field, int row, int col)
        {
            bool containsOnePattern = row >= 0 && row < field.GetLength(0) - 4 &&
                                      col >= 2 && col < field.GetLength(1) &&
                                      field[row, col] == 1 &&
                                      field[row + 1, col - 1] == 1 &&
                                      field[row + 2, col - 2] == 1 &&
                                      field[row + 1, col] == 1 &&
                                      field[row + 2, col] == 1 &&
                                      field[row + 3, col] == 1 &&
                                      field[row + 4, col] == 1;
            return (containsOnePattern) ? 1 : 0;
        }

        private static int CheckForTwo(byte[,] field, int row, int col)
        {
            bool containsTwoPattern = row >= 0 && row < field.GetLength(0) - 4 &&
                                      col >= 1 && col < field.GetLength(1) - 1 &&
                                      field[row, col] == 2 &&
                                      field[row + 1, col - 1] == 2 &&
                                      field[row + 1, col + 1] == 2 &&
                                      field[row + 2, col + 1] == 2 &&
                                      field[row + 3, col] == 2 &&
                                      field[row + 3, col] == 2 &&
                                      field[row + 4, col - 1] == 2 &&
                                      field[row + 4, col] == 2 &&
                                      field[row + 4, col + 1] == 2;
            return (containsTwoPattern) ? 2 : 0;
        }

        private static int CheckForThree(byte[,] field, int row, int col)
        {
            bool containsThreePattern = row >= 0 && row < field.GetLength(0) - 4 &&
                                        col >= 2 && col < field.GetLength(1) &&
                                        field[row, col] == 3 &&
                                        field[row, col - 1] == 3 &&
                                        field[row, col - 2] == 3 &&
                                        field[row + 1, col] == 3 &&
                                        field[row + 2, col] == 3 &&
                                        field[row + 2, col - 1] == 3 &&
                                        field[row + 3, col] == 3 &&
                                        field[row + 4, col] == 3 &&
                                        field[row + 4, col - 1] == 3 &&
                                        field[row + 4, col - 2] == 3;

            return (containsThreePattern) ? 3 : 0;
        }

        private static int CheckForFour(byte[,] field, int row, int col)
        {
            bool containsFourPattern = row >= 0 && row < field.GetLength(0) - 4 &&
                                       col >= 2 && col < field.GetLength(1) &&
                                       field[row, col] == 4 &&
                                       field[row + 1, col] == 4 &&
                                       field[row + 2, col] == 4 &&
                                       field[row + 2, col - 1] == 4 &&
                                       field[row + 2, col - 2] == 4 &&
                                       field[row + 1, col - 2] == 4 &&
                                       field[row, col - 2] == 4 &&
                                       field[row + 3, col] == 4 &&
                                       field[row + 4, col] == 4;

            return (containsFourPattern) ? 4 : 0;
        }

        private static int CheckForFive(byte[,] field, int row, int col)
        {
            bool containsFivePattern = row >= 0 && row < field.GetLength(0) - 4 &&
                                       col >= 2 && col < field.GetLength(1) &&
                                       field[row, col] == 5 &&
                                       field[row, col - 1] == 5 &&
                                       field[row, col - 2] == 5 &&
                                       field[row + 1, col - 2] == 5 &&
                                       field[row + 2, col - 2] == 5 &&
                                       field[row + 2, col - 1] == 5 &&
                                       field[row + 2, col] == 5 &&
                                       field[row + 3, col] == 5 &&
                                       field[row + 4, col] == 5 &&
                                       field[row + 4, col - 1] == 5 &&
                                       field[row + 4, col - 2] == 5;
            return (containsFivePattern) ? 5 : 0;
        }

        private static int CheckForSix(byte[,] field, int row, int col)
        {
            bool containsSixPattern = row >= 0 && row < field.GetLength(0) - 4 &&
                                      col >= 2 && col < field.GetLength(1) &&
                                      field[row, col] == 6 &&
                                      field[row, col - 1] == 6 &&
                                      field[row, col - 2] == 6 &&
                                      field[row + 1, col - 2] == 6 &&
                                      field[row + 2, col - 2] == 6 &&
                                      field[row + 3, col - 2] == 6 &&
                                      field[row + 4, col - 2] == 6 &&
                                      field[row + 4, col - 1] == 6 &&
                                      field[row + 4, col] == 6 &&
                                      field[row + 3, col] == 6 &&
                                      field[row + 2, col] == 6 &&
                                      field[row + 2, col - 1] == 6;
            return containsSixPattern ? 6 : 0;
        }

        private static int CheckForSeven(byte[,] field, int row, int col)
        {
            bool containsSevenPattern = row >= 0 && row < field.GetLength(0) - 4 &&
                                        col >= 0 && col < field.GetLength(1) - 2 &&
                                        field[row, col] == 7 &&
                                        field[row, col + 1] == 7 &&
                                        field[row, col + 2] == 7 &&
                                        field[row + 1, col + 2] == 7 &&
                                        field[row + 2, col + 1] == 7 &&
                                        field[row + 3, col + 1] == 7 &&
                                        field[row + 4, col + 1] == 7;

            return containsSevenPattern ? 7 : 0;
        }

        private static int CheckForEight(byte[,] field, int row, int col)
        {
            bool containsEightPattern = row >= 0 && row < field.GetLength(0) - 4 &&
                                        col >= 0 && col < field.GetLength(1) - 2 &&
                                        field[row, col] == 8 &&
                                        field[row, col + 1] == 8 &&
                                        field[row, col + 2] == 8 &&
                                        field[row + 1, col + 2] == 8 &&
                                        field[row + 2, col + 1] == 8 &&
                                        field[row + 3, col] == 8 &&
                                        field[row + 4, col] == 8 &&
                                        field[row + 4, col + 1] == 8 &&
                                        field[row + 4, col + 2] == 8 &&
                                        field[row + 3, col + 2] == 8 &&
                                        field[row + 1, col] == 8;

            return containsEightPattern ? 8 : 0;
        }

        private static int CheckForNine(byte[,] field, int row, int col)
        {
            bool containsNinePattern = row >= 0 && row < field.GetLength(0) - 4 &&
                                       col >= 0 && col < field.GetLength(1) - 2 &&
                                       field[row, col] == 9 &&
                                       field[row, col + 1] == 9 &&
                                       field[row, col + 2] == 9 &&
                                       field[row + 1, col + 2] == 9 &&
                                       field[row + 2, col + 2] == 9 &&
                                       field[row + 2, col + 1] == 9 &&
                                       field[row + 1, col] == 9 &&
                                       field[row + 3, col + 2] == 9 &&
                                       field[row + 4, col + 2] == 9 &&
                                       field[row + 4, col + 1] == 9 &&
                                       field[row + 4, col] == 9;

            return containsNinePattern ? 9 : 0;
        }

    }
}