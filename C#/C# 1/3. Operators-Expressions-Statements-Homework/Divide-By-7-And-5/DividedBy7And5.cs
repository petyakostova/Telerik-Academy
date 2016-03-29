/* Problem 3. Divide by 7 and 5
   Write a program that does the following:
    Reads an integer number from the console.
    Stores in a variable if the number can be divided by 7 and 5 without remainder.
    Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5. Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number. */

using System;

class DividedBy7And5
{
    static void Main()
    {        
        int intNumber = int.Parse(Console.ReadLine());     
                
        bool devided = (intNumber % 35 == 0);                      
        // bool devided = ((intNumber % 7 == 0) && (intNumber % 5 == 0)); 

        Console.WriteLine(devided
            ? "true {0}"
            : "false {0}", intNumber);
    }
}