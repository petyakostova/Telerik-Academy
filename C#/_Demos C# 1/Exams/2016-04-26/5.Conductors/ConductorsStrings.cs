using System;
using System.Linq;

namespace Conductors
{
    class ConductorsStrings
    {
        static int ParseReverse(char[] binary)
        {
            int value = 0;

            int pow = 1;

            foreach (var bit in binary)
            {
                value += (bit - '0') * pow;
                pow *= 2;
            }

            return value;
        }

        static void Solve()
        {
            // string solution
            var p = Convert.ToString(int.Parse(Console.ReadLine()), 2).Reverse().ToArray();

            var n = int.Parse(Console.ReadLine());

            var perforator = new string('0', p.Length);

            for (int i = 0; i < n; i++)
            {
                var number = Convert.ToString(int.Parse(Console.ReadLine()), 2).Reverse().ToArray();
                int start = 0;

                while (start < number.Length)
                {
                    bool isMatch = true;

                    // naive search in strings is much slower than bitwise operations
                    for (int j = 0; j + start < number.Length && j < p.Length; j++)
                    {
                        if (p[j] != number[start + j])
                        {
                            isMatch = false;
                            break;
                        }

                        if (j + start + 1 == number.Length && j + 1 < p.Length)
                        {
                            isMatch = false;
                        }
                    }

                    if (isMatch)
                    {
                        for (int j = 0; j < p.Length; j++)
                        {
                            number[start + j] = '0';
                        }
                    }

                    start++;
                }

                Console.WriteLine(ParseReverse(number));
            }
        }
    }
}
