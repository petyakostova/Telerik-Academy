namespace _01._2_4_8
{
    using System;

    class TwoFourEight
    {
        static void Main()
        {
            long A = long.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());

            long result = 0;
            if (B == 2)
            {
                result = A % C;
            }
            else if (B == 4)
            {
                result = A + C;
            }
            else if (B == 8)
            {
                result = A * C;
            }

            if (result % 4 == 0)
            {
                Console.WriteLine(result / 4);
            }
            else
            {
                Console.WriteLine(result % 4);
            }
            Console.WriteLine(result);

        }
    }
}