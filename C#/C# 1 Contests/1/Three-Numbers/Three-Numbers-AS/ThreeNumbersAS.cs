using System;

public class ThreeNumbersAS
{
    public static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        // Biggest number
        if (A >= B && A >= C)
        {
            Console.WriteLine(A);
        }
        else if (B >= A && B >= C)
        {
            Console.WriteLine(B);
        }
        else
        {
            Console.WriteLine(C);
        }

        // Smallest number
        if (A <= B && A <= C)
        {
            Console.WriteLine(A);
        }
        else if (B <= A && B <= C)
        {
            Console.WriteLine(B);
        }
        else
        {
            Console.WriteLine(C);
        }

        // Arithmetic mean 
        double arithmeticMean = (A + B + C) / 3.0;
        Console.WriteLine("{0:F2}", arithmeticMean);
    }
}