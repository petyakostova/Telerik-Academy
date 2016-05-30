namespace _03.Digits
{
    using System;
    using System.Collections.Generic; // List<bool

    class Digits
    {
        static int[,] digits;   // така може да се достъпва по всички методи в този клас

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var patterns = InitializeListOfPatterns();

            digits = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                string[] currentLine = Console.ReadLine().Split(' ');
                for (int col = 0; col < currentLine.Length; col++)
                {
                    digits[row, col] = int.Parse(currentLine[col]);
                }
            }

            int sum = 0;

            for (int row = 0; row <= n - 5; row++)
            {
                for (int col = 0; col <= n - 3; col++)
                {
                    if (digits[row + 2, col] == 1)
                    {
                        if (CheckPattern(patterns[1], // кой pattern ни трябва
                            1, // кой digit
                            row,
                            col))
                        {
                            sum += 1;
                            continue;  // спира текущата итерация на най-вътрешния цикъл без да излиза от него
                        }
                    }

                    if (digits[row + 1, col] == 2)
                    {
                        if (CheckPattern(patterns[2], 2, row, col))
                        {
                            sum += 2;
                            continue;
                        }
                    }

                    int currentDigit = digits[row, col];

                    if (CheckPattern(patterns[currentDigit], currentDigit, row, col))
                    {
                        sum += currentDigit;
                    }
                }
            }

            Console.WriteLine(sum);
        }

        static List<bool[,]> InitializeListOfPatterns()  // list bool-еви двумерни масиви
        {
            var list = new List<bool[,]>();

            // the first element of the list returns the pattern of the zero
            list.Add(new bool[,]
                {
                    // faking zero;
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

        // от кой ред и коя колона да проверявам в digits дали имам такъв pattern => row, col
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