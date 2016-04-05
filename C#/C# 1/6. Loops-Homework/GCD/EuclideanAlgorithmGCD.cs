/* 15.* GCD
   Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
   Use the Euclidean algorithm (find it in Internet).
   On the first and only line of the input you will receive the 2 integers A and B, separated by a whitespace.
   Output a single number - the GCD of the numbers A and B.
   Constraints: The numbers A and B will always be valid integers in the range [2, 500].                 */

using System;

class EuclideanAlgorithmGCD
{
    static void Main()
    {
        string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int firstNum = int.Parse(splitNumbers[0]);
        int secondNum = int.Parse(splitNumbers[1]);

        int numBigger = Math.Abs(firstNum);
        int numSmaller = Math.Abs(secondNum);

        if (numSmaller > numBigger)
        {
            // exchange the values - first way
            numSmaller += numBigger;
            numBigger = numSmaller - numBigger;
            numSmaller = numSmaller - numBigger;

            // exchange the values - second way
            //int helpingExchangeVar = numSmaller;
            //numSmaller = numBigger;
            //numBigger = helpingExchangeVar;
        }

        // first way
        int remainder = numBigger % numSmaller;
        while (remainder != 0)
        {
            numBigger = numSmaller;
            numSmaller = remainder;
            remainder = numBigger % numSmaller;
        }
        int gcd = numSmaller;

        // second way
        //while (numSmaller > 0)
        //{
        //    int remainder = numBigger % numSmaller;
        //    numBigger = numSmaller;
        //    numSmaller = remainder;
        //}
        //int gcd = numBigger;

        Console.WriteLine(gcd);
        
    }
}