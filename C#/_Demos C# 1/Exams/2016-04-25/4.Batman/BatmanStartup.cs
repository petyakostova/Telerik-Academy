using System;

namespace Batman
{
    class BatmanStartup
    {
        static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            char symbol = (char)Console.Read();

            var str = string.Empty;
            var start = string.Empty;
            var middle = string.Empty;

            for (int i = 0; i < size / 2; i++)
            {
                str = new string(symbol, size - i);
                if (i == 0)
                {
                    middle = new string(' ', size);
                }
                else if (i == size / 2 - 1)
                {
                    var temp = new string(' ', (size - 3) / 2);
                    middle = temp + symbol + ' ' + symbol + temp;
                }

                Console.WriteLine("{0}{1}{2}{1}{0}", start, str, middle);

                start = new string(' ', i + 1);
            }

            middle = new string(symbol, middle.Length - 2);

            for (int i = 0; i < size / 3; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", start, str, middle);
            }

            start = new string(' ', (3 * size - (size - 2)) / 2);
            middle = new string(symbol, size - 2);

            for (int i = 0; i < size / 2; i++)
            {
                middle = new string(symbol, size - 2 - 2 * i);
                Console.WriteLine(start + new string(' ', i) + middle + start);
            }
        }
    }
}
