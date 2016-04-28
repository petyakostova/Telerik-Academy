using System;

namespace BobbyAvokadoto
{
    class BobbyStartup
    {
        static void Main()
        {
            // bitwise solution
            uint n = uint.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            uint bestComb = 0u;
            uint bestBits = 0u;

            for (int i = 0; i < c; i++)
            {
                uint nextComb = uint.Parse(Console.ReadLine());
                if ((n | nextComb) == n + nextComb)
                {
                    uint bits = 0;

                    uint comb = nextComb;
                    while (comb > 0)
                    {
                        bits += comb & 1u;
                        comb >>= 1;
                    }

                    if (bits > bestBits)
                    {
                        bestComb = nextComb;
                        bestBits = bits;
                    }
                }
            }

            Console.WriteLine(bestComb);
        }
    }
}
