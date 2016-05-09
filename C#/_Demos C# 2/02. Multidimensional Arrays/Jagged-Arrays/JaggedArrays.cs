using System;

class JaggedArrays
{
    static void Main()
    {
        // Create jagged array
        int[][] jagged = new int[3][]; // we know the rows, but not the cols
        jagged[0] = new int[3]; // we determinate the cols like creating array for each row with fixed cols
        jagged[1] = new int[2];
        jagged[2] = new int[1];

        // Set values
        jagged[0][0] = 1;
        jagged[0][1] = 2;
        jagged[0][2] = 3;
        jagged[1][0] = 4;
        jagged[1][1] = 5;
        jagged[2][0] = 6;

        // Print the jagged array
        for (int row = 0; row < jagged.GetLength(0); row++)
        {
            foreach (var num in jagged[row])    // for each number on the current line
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        string[] beers = { "Zagorka", "Ariana", "Kamenitza", "Amstel"};
        Console.WriteLine(String.Join(", ", beers));

        Console.WriteLine();

        Console.WriteLine(String.Join(", \n", beers));
    }
}