using System;

namespace Headphones
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalRowsCount = 2 * n;
            int totalLength = (n / 2) * 2 + 2 + n;
            //top row
            Console.Write(new string('-', n / 2));
            Console.Write(new string('*', n + 2));
            Console.WriteLine(new string('-', n / 2));

            //length
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('-', n / 2));
                Console.Write("*");
                Console.Write(new string('-', n));
                Console.Write("*");
                Console.WriteLine(new string('-', n / 2));
            }

            //headphones
            for (int i = 0; i <= n / 2; i++)
            {
                Console.Write(new string('-', n / 2 - i));
                Console.Write(new string('*', 2 * i + 1));
                Console.Write(new string('-', n - 2 * i));
                Console.Write(new string('*', 2 * i + 1));
                Console.WriteLine(new string('-', n / 2 - i));
            }
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Console.Write(new string('-', n / 2 - i));
                Console.Write(new string('*', 2 * i + 1));
                Console.Write(new string('-', n - 2 * i));
                Console.Write(new string('*', 2 * i + 1));
                Console.WriteLine(new string('-', n / 2 - i));
            }

        }
    }
}