/* 9. Matrix of Numbers
   Write a program that reads from the console a positive integer number N 
   and prints a matrix like in the examples below. Use two nested loops.
   Challenge: achieve the same effect without nested loops.
   Constraints: 1 <= N <= 20. N will always be a valid integer number.
   Examples:
    n = 2   matrix      n = 3   matrix      n = 4   matrix
            1 2                 1 2 3               1 2 3 4
            2 3                 2 3 4               2 3 4 5
                                3 4 5               3 4 5 6
                                                    4 5 6 7                 */

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int num = row; num < row + n; num++)    // num <= (row + n - 1)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}