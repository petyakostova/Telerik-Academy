/* Problem 3. Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
Examples:
n 	    Divided by 7 and 5?
3 	    false
0 	    true
5 	    false
7 	    false
35 	    true
140     true                    */

using System;

class DividedBy7And5
{
    static void Main()
    {
        Console.WriteLine("Insert an integer number: ");
        int intNumber = int.Parse(Console.ReadLine());             // parsing
        bool devided = (intNumber % 35 == 0);                      // another way: bool devided = ((intNumber % 7 == 0) && (intNumber % 5 == 0));
        Console.WriteLine("'The number can be divided by 7 and 5' = " + devided);
    }
}