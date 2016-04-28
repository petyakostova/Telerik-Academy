using System;

namespace MutantSquirrels
{
    class MutantSquirrelsStartup
    {
        static void Main()
        {
            const ulong multiplier = 376439;
            const double divisor = 7.00;

            ulong trees = ulong.Parse(Console.ReadLine());
            uint branchesPerTree = uint.Parse(Console.ReadLine());
            uint birdsPerBranch = uint.Parse(Console.ReadLine());
            uint feathersPerBird = uint.Parse(Console.ReadLine());
            ulong originalTailsCount = trees * branchesPerTree * birdsPerBranch * feathersPerBird;

            Console.WriteLine("{0:F3}",
                originalTailsCount % 2 == 0 ?
                originalTailsCount * multiplier :
                originalTailsCount / divisor);
        }
    }
}
