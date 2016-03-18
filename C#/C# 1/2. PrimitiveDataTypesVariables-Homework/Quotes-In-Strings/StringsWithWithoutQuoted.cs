//Problem 7. Quotes in Strings
//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;
class StringsWithWithoutQuoted
{
    static void Main()
    {
        string withQuoted = @"The ""use"" of quotations causes difficulties.";
        string withoutQuoted = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("With quoted strings: {0}\nWithout quoted strings: {1}", withQuoted, withoutQuoted);
    }
}