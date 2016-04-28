using System;

namespace Conductors
{
    class ConductorsStartup
    {
        static void Main()
        {
            // bitwise solution
            int p = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            int maskLength = Convert.ToString(p, 2).Length;
            int perforator = (1 << maskLength) - 1;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int pattern = p;
                int mask = perforator;

                do
                {
                    if ((number & mask) == pattern)
                    {
                        number &= ~(mask);
                    }

                    mask <<= 1;
                    pattern <<= 1;

                } while ((pattern & (1 << 31)) == 0);

                Console.WriteLine(number);
            }
        }
    }
}
