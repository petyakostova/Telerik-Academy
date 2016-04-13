using System;

public class TelerikLogoAS
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        //int side = (n + 2) / 3;

        int side = int.Parse(Console.ReadLine());
        int n = (3 * side) - 2;

        int antena1Position = (n - ((side * 2) - 1)) / 2;
        int antena2Position = n - (n - ((side * 2) - 1)) / 2 - 1;

        int leftToRight = antena1Position;
        int rightToLeft = antena2Position;

        //print upper part
        for (int row = 0; row < (2 * side) - 1; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == antena1Position || col == antena2Position ||
                    col == leftToRight || col == rightToLeft)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            antena1Position--;
            antena2Position++;
            leftToRight++;
            rightToLeft--;
        }

        leftToRight -= 2;
        rightToLeft += 2;
        //print lower part
        for (int row = 0; row < (side - 1); row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (col == leftToRight || col == rightToLeft)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            leftToRight--;
            rightToLeft++;
        }
    }
}