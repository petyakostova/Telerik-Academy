namespace _01._3_6_9
{
    using System;

    class ThreeSixNine
    {
        static void Main()
        {
            long A = long.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());

            long result = 0;
            if (B == 3)
            {
                result = A + C;
            }
            else if (B == 6)
            {
                result = A * C;
            }
            else if (B == 9)
            {
                result = A % C;
            }

            if (result % 3 == 0)
            {
                Console.WriteLine(result / 3);
            }
            else
            {
                Console.WriteLine(result % 3);
            }
            Console.WriteLine(result);

        }
    }
}