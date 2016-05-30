namespace _02.Two_Girls_One_Path
{
    using System;
    using System.Linq; // Select()
    using System.Numerics; // BigInteger

    class TwoGirlsOnePath
    {
        static void Main()
        {
            BigInteger[] flowers = Console.ReadLine()
            .Split(' ')
            .Select(BigInteger.Parse)
            .ToArray();

            int mollyIndex = 0; // Molly starts at cell 0 and moves towards cell N-1.
            int dollyIndex = flowers.Length - 1; // Dolly starts at cell N-1 and moves towards cell 0.

            BigInteger mollyTotalFlowers = 0;
            BigInteger dollyTotalFlowers = 0;

            string winner = string.Empty;

            while (true)
            {
                // If one of the girls reaches a cell with no flowers in it, the game ends.
                if (flowers[mollyIndex] == 0 || flowers[dollyIndex] == 0)
                {
                    if (flowers[mollyIndex] == 0 && flowers[dollyIndex] == 0)
                    {
                        winner = "Draw";
                    }
                    else if (flowers[mollyIndex] == 0)
                    {
                        winner = "Dolly";
                    }
                    else if (flowers[dollyIndex] == 0)
                    {
                        winner = "Molly";
                    }

                    mollyTotalFlowers += flowers[mollyIndex];
                    dollyTotalFlowers += flowers[dollyIndex];
                    break;
                }

                // Both girls collect the flowers on their starting cell before moving to the next one.
                BigInteger currentMollyFlowers = flowers[mollyIndex];
                BigInteger currentDollyFlowers = flowers[dollyIndex];

                // If the both girls move at the same time to the same cell full of flowers
                if (mollyIndex == dollyIndex)   // check if both indexes are equal
                {                    
                    // they split the flowers evenly  
                    mollyTotalFlowers += currentMollyFlowers / 2;
                    dollyTotalFlowers += currentDollyFlowers / 2;
                    // leave the rest into the cell
                    flowers[mollyIndex] = currentMollyFlowers % 2;  // for the cell
                }
                else
                {
                    // When one of the girls reaches a cell, she collects all the F flowers on that cell.
                    flowers[mollyIndex] = 0;
                    flowers[dollyIndex] = 0;

                    mollyTotalFlowers += currentMollyFlowers;
                    dollyTotalFlowers += currentDollyFlowers;
                }

                // jumps F cells ahead of the current cell, depending on the moving direction => moving the girls

                mollyIndex = (int)((mollyIndex + currentMollyFlowers) % flowers.Length);
                // currentMollyFlowers % flowers.Length => positions to move

                dollyIndex = (int)((dollyIndex - currentDollyFlowers) % flowers.Length);
                if (dollyIndex < 0)
                {
                    dollyIndex += flowers.Length;
                }
            }

            // output
            Console.WriteLine(winner);
            Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);
        }

    }
}