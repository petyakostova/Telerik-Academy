// 92-96/100 in bgcoder => 1-2 time limits
namespace _03.Digits
{
    using System;
    using System.Collections.Generic; // List<bool

    class Digits
    {
        static int[,] digits;   // accessible from all the methods in the class

        static void Main()
        {
            // list with all the patterns from 0 to 9
            List<bool[,]> patterns = InitializeListOfPatterns();

            // Input
            int n = int.Parse(Console.ReadLine());

            digits = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                string[] currentLine = Console.ReadLine().Split(' ');

                for (int col = 0; col < currentLine.Length; col++)
                {
                    digits[row, col] = int.Parse(currentLine[col]);
                }
            }

            // Calculating the sum
            int sum = 0;

            for (int row = 0; row <= n - 5; row++)
            {
                for (int col = 0; col <= n - 3; col++)
                {
                    // the beginning of the one (most up right)
                    if (digits[row + 2, col] == 1)
                    {
                        if (CheckPattern(patterns[1], // whose pattern we need
                            1, // which digit
                            row,
                            col))
                        {
                            sum += 1;
                            continue;  // stops the current iteration on the inner most loop without exit the loop
                        }
                    }

                    // the beginning of the two
                    if (digits[row + 1, col] == 2)
                    {
                        if (CheckPattern(patterns[2], 2, row, col))
                        {
                            sum += 2;
                            continue;
                        }
                    }

                    // the beginning of the 3-9
                    int currentDigit = digits[row, col];

                    if (CheckPattern(patterns[currentDigit], currentDigit, row, col))
                    {
                        sum += currentDigit;
                    }
                }
            }

            // Output
            Console.WriteLine(sum);
        }

        static List<bool[,]> InitializeListOfPatterns()  // returns list of boolean 2-dimentional arrays
        {
            var list = new List<bool[,]>();

            // the first element of the list returns the pattern of the zero
            list.Add(new bool[,]
                {
                    // faking zero; => no need to sum it
                });

            // the second element of the list returns the pattern of the one
            list.Add(new bool[,]
                {
                {false, false, true},
                {false, true, true},
                {true, false, true},
                {false, false, true},
                {false, false, true},
                });

            // two
            list.Add(new bool[,]
                {
                {false, true, false},
                {true, false, true},
                {false, false, true},
                {false, true, false},
                {true, true, true},
                });

            // three
            list.Add(new bool[,]
                {
                {true, true, true},
                {false, false, true},
                {false, true, true},
                {false, false, true},
                {true, true, true},
                });

            // four
            list.Add(new bool[,]
                {
                {true, false, true},
                {true, false, true},
                {true, true, true},
                {false, false, true},
                {false, false, true},
                });

            // five
            list.Add(new bool[,]
                {
                {true, true, true},
                {true, false, false},
                {true, true, true},
                {false, false, true},
                {true, true, true},
                });

            // six
            list.Add(new bool[,]
                {
                {true, true, true},
                {true, false, false},
                {true, true, true},
                {true, false, true},
                {true, true, true},
                });

            // seven
            list.Add(new bool[,]
                {
                {true, true, true},
                {false, false, true},
                {false, true, false},
                {false, true, false},
                {false, true, false},
                });

            // eight
            list.Add(new bool[,]
                {
                {true, true, true},
                {true, false, true},
                {false, true, false},
                {true, false, true},
                {true, true, true},
                });

            // nine
            list.Add(new bool[,]
                {
                {true, true, true},
                {true, false, true},
                {false, true, true},
                {false, false, true},
                {true, true, true},
                });

            return list;
        }

        // from which row and which col to check in digits if it has such a pattern => row, col
        static bool CheckPattern(bool[,] pattern, int digit, int row, int col) 
        {
            for (int i = 0; i < pattern.GetLength(0); i++)
            {
                for (int j = 0; j < pattern.GetLength(1); j++)
                {
                    if (pattern[i, j])  // true
                    {
                        if (digits[row + i, col + j] != digit)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

    }
}