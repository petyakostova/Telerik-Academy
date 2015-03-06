/* Problem 9. Sum of n Numbers
   Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
   Note: You may need to use a for-loop.
Examples:
numbers 	sum
3 	        90
20 	        
60 	        
10 	        
5 	        6.5
2 	        
-1 	        
-0.5         	
4 	        
2 	        
1 	        1
1 	        
*/

using System;
using System.Threading;                                                         // line 21 and 22 are necessary for the line 28
using System.Globalization;

class SumOfNNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;     /* changes the culture of the program in American standard
                                                                                 * so the decimal point character is . */
        int n;
        Console.Write("Enter a number n= ");
        while (!int.TryParse(Console.ReadLine(), out n))                  // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter an integer number n= ");
        }
        double sum = 0;
        double numberI;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number: ");
            while (!double.TryParse(Console.ReadLine(), out numberI))     // parsing and validating the user data for the numbers he wants to sum
            {
                Console.WriteLine("Invalid number.");
                Console.Write("Please enter a correct number: ");
            }
            sum += numberI;
        }
        Console.WriteLine("Sum = " + sum);
    }
}