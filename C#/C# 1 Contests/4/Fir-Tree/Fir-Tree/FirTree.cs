using System;

namespace Fir_Tree
{
    class FirTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // part 1
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n - 2 - i), new string('*', 1 + 2 * i));
            }

            // part 2
            Console.WriteLine("{0}*{0}", new string('.', n - 2));

        }
    }
}