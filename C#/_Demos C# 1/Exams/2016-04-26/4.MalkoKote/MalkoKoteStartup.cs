using System;

namespace MalkoKote
{
    class MalkoKoteStartup
    {
        static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var symbol = (char)Console.Read();

            var counter = size / 4 - 1;

            var patternMinus = new string(symbol, size / 4 - 1);
            var patternPlus = new string(symbol, size / 4 + 1);
            var patternEars = string.Format("{0}{1}{0}", symbol, new string(' ', size / 4 - 1));

            var space = " ";

            // Draw ears
            Console.WriteLine(space + patternEars);

            // Draw head
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(space + patternPlus);
            }

            // Draw neck
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(space + space + patternMinus);
            }

            // Draw upper body
            for (int i = 0; i < counter + 1; i++)
            {
                if (i <= counter - 1)
                {
                    Console.WriteLine(space + patternPlus);
                }
                else
                {
                    Console.WriteLine(space + patternPlus + space + space + space + new string(symbol, size / 4));
                }
            }

            // Draw lower body
            patternPlus = new string(symbol, size / 4 + 3);

            for (int i = 0; i < size / 4 + 2; i++)
            {
                if (i <= size / 4)
                {
                    Console.WriteLine(patternPlus + space + space + symbol);
                }
                else
                {
                    Console.WriteLine(patternPlus + space + symbol + symbol);

                }
            }

            // Draw base
            patternPlus = new string(symbol, size / 4 + 4);

            Console.WriteLine(space + patternPlus);
        }
    }
}
