using System;

class MutantSquirrels
{
    static void Main()
    {
        const ulong multiplier = 376439;
        const double divisor = 7.00;

        ulong trees = ulong.Parse(Console.ReadLine());
        uint branchesOnTree = uint.Parse(Console.ReadLine());
        uint squirrelsOnBranch = uint.Parse(Console.ReadLine());
        uint averageTailsForSquirrel = uint.Parse(Console.ReadLine());

        ulong tails = trees * branchesOnTree * squirrelsOnBranch * averageTailsForSquirrel;
        double result = 0;

        if (tails % 2 == 0)
        {
            result = tails * multiplier;
        }
        else
        {
            result = tails / divisor;
        }

        Console.WriteLine("{0:F3}", result);
    }
}