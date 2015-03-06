//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;
class AssignNullValues
{
    static void Main()
    {
        int? intVar = null;
        double? doubleVar = null;
        Console.WriteLine("The values of int is: {0}\nThe values of double is: {1}", intVar, doubleVar);
        intVar += 5;
        Console.WriteLine("Add some number = 5: {0}", intVar);
        doubleVar += null;
        Console.WriteLine("Add the null literal: {0}", doubleVar);

        // other
        Console.WriteLine("If we use GetValueOrDefault() the result is:");
        Console.WriteLine(intVar.GetValueOrDefault() + 6);
        Console.WriteLine(doubleVar.GetValueOrDefault() + 7);
    }
}