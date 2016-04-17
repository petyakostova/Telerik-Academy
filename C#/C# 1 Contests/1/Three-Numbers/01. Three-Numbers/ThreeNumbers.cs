namespace _01.Three_Numbers
{
    using System;

    class ThreeNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(a, b), c));

            Console.WriteLine(Math.Min(Math.Min(a, b), c));

            double arithmeticMean = (a + b + c) / 3.0;
            Console.WriteLine("{0:F2}", arithmeticMean);
        }
    }
}