/* Problem 11.* Numbers in Interval Dividable by Given Number
Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

Examples:
start 	end 	p 	comments
17 	    25 	    2 	20, 25
5 	    30 	    6 	5, 10, 15, 20, 25, 30
3 	    33 	    6 	5, 10, 15, 20, 25, 30
3 	    4 	    0 	-
99 	    120 	5 	100, 105, 110, 115, 120
107 	196 	18 	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195        */

using System;

class DivisibleBy5InInterval
{
    static void Main()
    {
        uint start, end;
        Console.Write("Enter a start of the interval (positive integer number): ");
        while (!uint.TryParse(Console.ReadLine(), out start))                // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid start.");
            Console.Write("Please enter positive integer number for start: ");
        }
        Console.Write("Enter an end of the interval (positive integer number): ");
        while (!uint.TryParse(Console.ReadLine(), out end) || end <= start)  // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid end.");
            Console.Write("Please enter positive integer number for end (end>{0}): ", start);
        }
        uint p = new uint();
        for (uint i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i);
                if (i < end - 3)                                             // for not printing comma in the end
                {
                    Console.Write(", ");
                }
                p++;
            }
        }
        if (p == 0)
        {
            Console.WriteLine("There are 0 numbers dividable by 5" + Environment.NewLine + "-");
        }
        else
        {
            Console.WriteLine(Environment.NewLine + 
                "There are {0} numbers dividable by 5 in the interval [{1}, {2}]", p, start, end);
        }
    }
}