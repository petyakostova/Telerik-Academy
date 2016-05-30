namespace _05.Doge_Coin
{
    using System;
    using System.Linq; // Select()

    class DogeCoin
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();   

            int rows = dimentions[0];   // number of rows
            int cols = dimentions[1];   // number of cols

            int[,] coins = new int[rows, cols]; // двумерен масив за разположението на монетите

            int k = int.Parse(Console.ReadLine());  // бр. монети

            for (int i = 0; i < k; i++) // колкото са монетите, толкова координати ще се въведат
            {
                string[] currentCoords = Console.ReadLine().Split(' '); // сплитваме координатите
                int currentCoinRow = int.Parse(currentCoords[0]);   // редът на текущата монета
                int currentCoinCol = int.Parse(currentCoords[1]);   // колоната на текущата монета

                coins[currentCoinRow, currentCoinCol]++;    // добавяме текущата монета в масива за монетите 
            }
            // дотук имаме бройките монети във всяка клетка на масива coins

            int[,] dp = new int[rows, cols];    // динамично оптимиране

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    // при движение само надясно или надолу, за конкретна клетка ще се гледа дали горната клетка или тази вляво има повече...
                    int maxAbove = 0;
                    int maxLeft = 0;

                    if (row - 1 >= 0)
                    {
                        maxAbove = dp[row - 1, col];
                    }

                    if (col - 1 >= 0)
                    {
                        maxLeft = dp[row, col - 1];
                    }

                    // максималната от клетките отгоре и отляво + монетите в текущата клетка => сборът до момента
                    dp[row, col] = Math.Max(maxAbove, maxLeft) + coins[row, col];

                }
            }

            Console.WriteLine(dp[rows - 1, cols - 1]);  // последната клетка

        }
    }
}