/*  Problem 11. Random Numbers in Given Range
    Write a program that enters 3 integers n, min and max (min != max) and 
    prints n random numbers in the range [min...max].
Examples:
n 	    min 	max 	random numbers
5 	    0 	    1 	    1 0 0 1 1
10 	    10 	    15 	    12 14 12 15 10 12 14 13 13 11
Note: The above output is just an example. Due to randomness, your program most probably will produce different results.    */

using System;

class RandomNumsInRange
{
    static void Main()
    {
        int n, min, max;
        Console.Write("Enter a positive integer number n = ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1)            // parsing and input check (validating the user data)
        {
            Console.WriteLine("Incorrect input!");
            Console.Write("Please enter a positive integer number n= ");
        }
        Console.Write("Enter an integer number for start of the range min = ");
        while (!int.TryParse(Console.ReadLine(), out min))                  // parsing and input check (validating the user data)
        {
            Console.WriteLine("Incorrect input!");
            Console.Write("Please enter an integer number for start of the range min = ");
        }
        Console.Write("Enter an integer number for end of the range max = ");
        while (!int.TryParse(Console.ReadLine(), out max) || min > max)    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Incorrect input!");
            Console.Write("Please enter an integer number for end of the range max = ");
        }
        // using the System.Random class and its method Next(n) to generate random numbers in the range [0..n)
        Random randomGenerator = new Random();  /* Before we use the Random class we have to create instance of it, 
                                                 * at which point it is initialized with a random value 
                                                 * (derived from the current system time in the operating system) */
        for (int i = 0; i < n; i++)
        {
            int randomNumber = randomGenerator.Next(min, max + 1);      // generate random numbers in the range [min...max]
            Console.Write(randomNumber + " ");
        }
        Console.WriteLine();
    }
}