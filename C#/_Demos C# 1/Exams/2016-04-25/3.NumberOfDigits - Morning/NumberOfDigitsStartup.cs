using System;

namespace NumberOfDigitsMorning
{
    class NumberOfDigitsMorningStartup
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int D = 0;

            for (int i = 1; i <= N; i++)
            {
                int currentPage = i;
                while (currentPage > 0)
                {
                    D++;
                    currentPage /= 10;
                }
            }

            Console.WriteLine(D);
        }
    }
}
