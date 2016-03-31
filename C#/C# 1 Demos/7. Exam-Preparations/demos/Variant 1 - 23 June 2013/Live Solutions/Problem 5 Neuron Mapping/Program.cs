using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Neuron_Mapping
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                long line = long.Parse(Console.ReadLine());
                if (line == -1)
                {
                    break;
                }

                int mostLeftIndex = -1;
                int mostRightIndex = -1;
                for (int p = 0; p < 32; p++)
                {
                    long mask = 1 << p;
                    long nAndMask = line & mask;
                    long bit = nAndMask >> p;
                    if (bit == 1)
                    {
                        if (mostRightIndex == -1)
                        {
                            mostRightIndex = p;
                        }

                        mostLeftIndex = p;
                    }
                }

                if (mostLeftIndex == -1)
                {
                    Console.WriteLine(0);
                    continue;
                }

                long result = 0;
                for (int p = mostRightIndex; p <= mostLeftIndex; p++)
                {
                    long mask = 1 << p;
                    long nAndMask = line & mask;
                    long bit = nAndMask >> p;
                    if (bit == 0)
                    {
                        result = result | mask;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
