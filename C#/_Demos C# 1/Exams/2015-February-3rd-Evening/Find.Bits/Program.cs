using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find.Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                Convert.ToString(
                    int.Parse(
                        Console.ReadLine()), 2).PadLeft(5, '0');

            int n = int.Parse(Console.ReadLine());

            string number = string.Empty;
            bool isMatch = true;
            int occurences = 0;

            for (int i = 0; i < n; i++)
            {
                number =
                    Convert.ToString(
                        int.Parse(
                            Console.ReadLine()), 2).PadLeft(32, '0');

                for (int j = 3; j < number.Length - 4; j++)
                {
                    isMatch = true;

                    for (int k = 0; k < 5; k++)
                    {
                        if (number[j + k] != pattern[k])
                        {
                            isMatch = false;
                            break;
                        }
                    }

                    if(isMatch)
                    {
                        occurences++;
                    }
                }
            }

            Console.WriteLine(occurences);
        }
    }
}
