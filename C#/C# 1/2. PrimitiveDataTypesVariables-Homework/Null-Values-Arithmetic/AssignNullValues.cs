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
        Console.WriteLine("After adding 5 => {0}", intVar);
        doubleVar += null;
        Console.WriteLine("After adding the null literal => {0}", doubleVar);

        //// how to make it work
        //Console.WriteLine("\nIf we use GetValueOrDefault() the result is:");
        //Console.WriteLine(intVar.GetValueOrDefault() + 6);
        //Console.WriteLine(doubleVar.GetValueOrDefault() + 7);
    }
}