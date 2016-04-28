using System;

namespace NumberOfPagesEvening
{
    class NumberOfPagesEveningStartup
    {
        static void Main()
        {
            int D = int.Parse(Console.ReadLine());
            int N = 0;

            while (D > 0)
            {
                N++;
                int currentPage = N;
                while (currentPage > 0)
                {
                    D--;
                    currentPage /= 10;
                }
            }

            Console.WriteLine(N);
        }
    }
}
