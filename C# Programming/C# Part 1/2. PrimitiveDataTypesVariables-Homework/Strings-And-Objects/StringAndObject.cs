//Problem 6. Strings and Objects
//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class StringAndObject
{
    static void Main()
    {
        string string1 = "Hello";
        string string2 = "World";
        object concat = string1 + " " + string2;
        string string3 = (string)concat;
        
        Console.WriteLine("The first string is: {0}\nThe second string is: {1}\nThe concatenation is: {2} \nThe third string is: {3}", string1, string2, concat, string3);
    }
}