/*  19. Randomize the Numbers 1…N
    Write a program that enters an integer n and prints the numbers 1, 2, …, n in random order.
Examples:
n 	    randomized numbers 1…n
3 	    2 1 3
10 	    3 4 8 2 6 7 9 1 10 5    
Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.  */

using System;

class RandomizeTheNumbers1toN
{
    static void Main()
    {
        int n;
        Console.Write("Enter a positive integer number n = ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1)        // parsing and input check (validating the user data)
        {
            Console.WriteLine("Incorrect input!");
            Console.Write("Please enter a positive integer number n = ");
        }
        bool[] printed = new bool[n + 1];         // array with boolean n + 1 elements, which by default are false
        // using the System.Random class and its method Next(n) to generate random numbers in the range [0..n)
        Random randomGenerator = new Random();  /* Before we use the Random class we have to create instance of it, 
                                                 * at which point it is initialized with a random value 
                                                 * (derived from the current system time in the operating system) */
        int numberToPrint;
        for (int i = 1; i <= n; i++)
        {
            numberToPrint = randomGenerator.Next(1, n + 1);         // generate random numbers in the range [1...n]
            if (!printed[numberToPrint])
            {
                Console.Write(numberToPrint + " ");
                printed[numberToPrint] = true;
            }
            else
            {
                i--;
            }
        }
        Console.WriteLine();
    }
}