/*Problem 1. Odd or Even  
  Write a program that reads an integer from the console, uses an expression to check if given integer is odd or even, and prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.
  */

using System;

class OddOrEven
{
    static void Main()
    {
        // Read the input as a string (using ReadLine()) and convert this string to a number.
        int intNumber = int.Parse(Console.ReadLine());                                                       
        Console.WriteLine((intNumber % 2 == 0) 
            ? "even {0}" 
            : "odd {0}", intNumber);        
    }
}