/* Problem 8. Prime Check
   Write a program that reads an integer N (which will always be less than 100 or equal) and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1). Note: You should check if the number is positive. Output true if the number is prime and false otherwise. */

using System;

class PrimeCheck
{
    static void Main()
    {
        int posIntNumber = int.Parse(Console.ReadLine());

        if (posIntNumber < 2)  // when posIntNumber < 0 or posIntNumber = 0 or posIntNumber = 1
        {
            Console.WriteLine("false");
            return;
        }

        bool boolPrime = true;
        if ((posIntNumber == 2) || (posIntNumber == 5))
        {
            boolPrime = true;
        }
        else
        {
            // (posIntNumber <= 1) || (posIntNumber % 2 == 0) || (posIntNumber % 5 == 0)
            if ((posIntNumber % 2 == 0) || (posIntNumber % 5 == 0))                 
            {
                boolPrime = false;
            }
            else
            {

                int maxDivider = (int)Math.Sqrt(posIntNumber);                
                for (int i = 3; i <= maxDivider; i++)
                {
                    if (posIntNumber % i == 0)
                    {
                        boolPrime = false;
                        break;
                    }
                }
                
                //// other way
                //int maxDivider = (int)Math.Sqrt(posIntNumber);
                //int count = 0;
                //for (int i = 3; i <= maxDivider; i++)
                //{
                //    if (posIntNumber % i == 0)
                //    {
                //        count++;
                //    }
                //}
                //if (count > 0)
                //{
                //    boolPrime = false;
                //}
            }
        }
        Console.WriteLine(boolPrime ? "true" : "false");
    }
}