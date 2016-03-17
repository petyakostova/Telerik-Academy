/*Problem 17.* Calculate GCD
  Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
  Use the Euclidean algorithm (find it in Internet).
Examples:
a 	b 	    GCD(a, b)
3 	2 	    1
60 	40 	    20
5 	-15 	5                                */ 

using System;

class EuclideanAlgorithmGCD
{
    static void Main()
    {
        checked
        {
            int firstNum, secondNum;
            Console.Write("Enter an integer number: ");
            while (!int.TryParse(Console.ReadLine(), out firstNum))     // parsing and input check (validating the user data)
            {
                Console.WriteLine("Incorrect input!");
                Console.Write("Please enter an integer number: ");
            }
            Console.Write("Enter an integer number: ");
            while (!int.TryParse(Console.ReadLine(), out secondNum))    // parsing and input check (validating the user data)
            {
                Console.WriteLine("Incorrect input!");
                Console.Write("Please enter an integer number: ");
            }
            int numBigger = Math.Abs(firstNum);
            int numSmaller = Math.Abs(secondNum);
            if (numSmaller > numBigger)
            {
                numSmaller += numBigger;                                           // exchange the values - first way
                numBigger = numSmaller - numBigger;
                numSmaller = numSmaller - numBigger;
                //int helpingExchangeVar = numA;                        // exchange the values - second way
                //numA = numB;
                //numB = helpingExchangeVar;
            }
            int remainder = numBigger % numSmaller;
            while (remainder != 0)
            {
                numBigger = numSmaller;
                numSmaller = remainder;
                remainder = numBigger % numSmaller;
            }
            int gcd = numSmaller;

            //while (numSmaller > 0)                                          // other way
            //{
            //    int remainder = numBigger % numSmaller;
            //    numBigger = numSmaller;
            //    numSmaller = remainder;
            //}
            //int gcd = numBigger;

            Console.WriteLine("GCD ({0}, {1}) = {2}", firstNum, secondNum, gcd);
        }
    }
}