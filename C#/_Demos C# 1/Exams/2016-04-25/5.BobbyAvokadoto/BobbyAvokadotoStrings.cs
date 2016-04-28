using System;

namespace BobbyAvokadoto
{
    class BobbyStrings
    {
        static void Solve()
        {
            // string solution
            var n = Convert.ToString(uint.Parse(Console.ReadLine()), 2).PadLeft(32, '0');
            var c = int.Parse(Console.ReadLine());
            var bestComb = 0u;
            var bestBits = 0;

            for (int i = 0; i < c; i++)
            {
                var nextComb = uint.Parse(Console.ReadLine());
                // converting every number to string is slow
                var strComb = Convert.ToString(nextComb, 2).PadLeft(32, '0');
                bool compat = true;

                for (int k = 0; k < strComb.Length; k++)
                {
                    if (strComb[k] == '1' && strComb[k] == n[k])
                    {
                        compat = false;
                        break;
                    }
                }

                if (compat)
                {
                    int bits = 0;

                    foreach (var item in strComb)
                    {
                        bits += item - '0';
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
