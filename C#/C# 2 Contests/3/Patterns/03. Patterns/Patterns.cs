namespace _03.Patterns
{
    using System;
    using System.Collections.Generic; // List<int>

    class Patterns
    {
        static void Main()
        {
            int[,] matrix = Input();

            bool[,] pattern = new bool[,]
            {
            {true, true, true, false, false},
            {false, false, true, false, false},
            {false, false, true, true, true},
            };

            long maxSum = long.MinValue;

            bool globallyFoundCorrectPattern = false;

            for (int patternStartX = 0; 
                patternStartX <= matrix.GetLength(0) - pattern.GetLength(0); 
                patternStartX++)
            {
                for (int patternStartY = 0; 
                    patternStartY <= matrix.GetLength(1) - pattern.GetLength(1); 
                    patternStartY++)
                {
                    List<int> numbersInPattern = new List<int>();
                                        
                    for (int patternX = 0; patternX < pattern.GetLength(0); patternX++)
                    {
                        for (int patternY = 0; patternY < pattern.GetLength(1); patternY++)
                        {
                            // positions, on which we will search

                            // X-position, on which we start to search + the current X on pattern
                            int x = patternStartX + patternX;  
                            int y = patternStartY + patternY;

                            if (pattern[patternX, patternY])    // true
                            {
                                numbersInPattern.Add(matrix[x, y]);
                            }
                        }
                    }

                    bool foundCorrectPattern = true;
                    for (int i = 1; i < numbersInPattern.Count; i++)
                    {
                        if (numbersInPattern[i - 1] != numbersInPattern[i] - 1)
                        {
                            foundCorrectPattern = false;
                            break;
                        }
                    }

                    if (foundCorrectPattern)
                    {
                        globallyFoundCorrectPattern = true;

                        //sum
                        long sum = 0;
                        foreach (var item in numbersInPattern)
                        {
                            sum += item;
                        }

                        maxSum = Math.Max(maxSum, sum);

                        // other way
                        //if (sum > maxSum)
                        //{
                        //    maxSum = sum;
                        //}
                    }
                }
            }

            // Output
            if (globallyFoundCorrectPattern)
            {
                Console.WriteLine("YES {0}", maxSum);
            }
            else
            {
                Console.WriteLine("NO {0}", SumDiagonal(matrix));
            }
        }

        private static int[,] Input()   // returns 2-dementional array of int
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] numbersAsString = line.Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(numbersAsString[j]);
                }
            }

            return matrix;
        }

        // Sum the elements on the main diagonal
        private static long SumDiagonal(int[,] matrix)  
        {
            long sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }

            return sum;
        }
        
    }
}