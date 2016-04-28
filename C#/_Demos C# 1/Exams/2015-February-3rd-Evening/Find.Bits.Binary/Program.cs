namespace Find.Bits.Binary
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int pattern = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int mask = ~(1 << 31);

            int number, temp, occurences = 0;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                number = ((number << 2) & mask) >> 2;

                for (int k = 0; k <= 24; k++)
                {
                    temp = number;
                    temp = ((temp << 26 - k) & mask) >> 26;

                    if(temp == pattern)
                    {
                        occurences++;
                    }
                }
            }

            Console.WriteLine(occurences);
        }
    }
}
