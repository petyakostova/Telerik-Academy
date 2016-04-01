/* 11. Interval   
   Write a program that reads two positive integer numbers N and M and 
   prints how many numbers exist between them such that the reminder of the division by 5 is 0.
   Constraints: 0 <= N <= M <= 2000 */

using System;

class DivisibleBy5InInterval
{
    static void Main()
    {
        uint start = uint.Parse(Console.ReadLine());
        uint end = uint.Parse(Console.ReadLine());
        
        uint amountDivisibleBy5 = 0;
        for (uint i = start + 1; i < end; i++)
        {
            if (i % 5 == 0)
            {
                ////for printing the numbers
                //Console.Write(i);
                //if (i < end - 3)
                //{
                //    // for not printing comma in the end
                //    Console.Write(", ");
                //}
                amountDivisibleBy5++;
            }
        }
        //Console.WriteLine();

        Console.WriteLine(amountDivisibleBy5);
    }
}