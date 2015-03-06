/* Problem 8. Prime Number Check
Write an expression that checks if given positive integer number n (n <= 100) is prime 
(i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
Examples:
n 	Prime?
1 	false
2 	true
3 	true
4 	false
9 	false
97 	true
51 	false
-3 	false
0 	false
*/

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Insert a positive integer number n:  n <= 100: ");
        int posIntNumber = int.Parse(Console.ReadLine());      /* Read the input as a string (using ReadLine()) and convert this string to a number. 
                                                             * The operation of converting a string into another type is called parsing. */
        while ((posIntNumber < 0) || (posIntNumber > 100))  // input check n <= 100
        {
            Console.WriteLine("Incorrect number format. Please insert a positive integer number n:  n <= 100: ");
            posIntNumber = int.Parse(Console.ReadLine());
        }
        bool boolPrime = true;
        if ((posIntNumber == 2) || (posIntNumber == 5))
        {
            boolPrime = true;
        }
        else
        {
            if ((posIntNumber <= 1) || (posIntNumber % 2 == 0) || (posIntNumber % 5 == 0))
            {
                boolPrime = false;
            }
            else
            {

                int maxDivider = (int)Math.Sqrt(posIntNumber);
                int count = 0;
                for (int i = 3; i <= maxDivider; i++)
                {
                    if (posIntNumber % i == 0)
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    boolPrime = false;
                }
            }
        }
        Console.WriteLine("'The given positive integer number {0} is prime' = {1} \n", posIntNumber, boolPrime);
    }
}